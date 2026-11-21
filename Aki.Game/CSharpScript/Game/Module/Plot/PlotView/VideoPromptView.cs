using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004044 RID: 16452
	public class VideoPromptView : UiViewBase
	{
		// Token: 0x06029B2C RID: 170796 RVA: 0x00BC94ED File Offset: 0x00BC76ED
		[NullableContext(1)]
		public VideoPromptView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06029B2D RID: 170797 RVA: 0x00BC94F8 File Offset: 0x00BC76F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06029B2E RID: 170798 RVA: 0x00BC9540 File Offset: 0x00BC7740
		protected override UniTask OnBeforeStartAsync()
		{
			VideoPromptView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VideoPromptView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029B2F RID: 170799 RVA: 0x00BC9583 File Offset: 0x00BC7783
		protected override void OnStart()
		{
			this.OnVideoViewShow();
			EventSystem.Instance.Add(EEventName.VideoViewShow, new Action(this.OnVideoViewShow));
			EventSystem.Instance.Add<bool>(EEventName.VideoViewHide, new Action<bool>(this.OnVideoViewHide));
		}

		// Token: 0x06029B30 RID: 170800 RVA: 0x00BC95C4 File Offset: 0x00BC77C4
		protected override void OnAfterShow()
		{
			VideoPromptParam videoPromptParam = this.OpenParam as VideoPromptParam;
			if (videoPromptParam != null && videoPromptParam.AutoCloseTime != null)
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					base.CloseMe(null);
				}, videoPromptParam.AutoCloseTime.Value * 1000f, null, null, true, 1f);
			}
		}

		// Token: 0x06029B31 RID: 170801 RVA: 0x00BC9624 File Offset: 0x00BC7824
		protected override void OnAfterHide()
		{
			this.OnVideoViewHide(false);
			EventSystem.Instance.Remove(EEventName.VideoViewShow, new Action(this.OnVideoViewShow));
			EventSystem.Instance.Remove<bool>(EEventName.VideoViewHide, new Action<bool>(this.OnVideoViewHide));
		}

		// Token: 0x06029B32 RID: 170802 RVA: 0x00BC9670 File Offset: 0x00BC7870
		private void OnVideoViewShow()
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.VideoView);
			if (!this.HasAttachVideoView && viewByName != null)
			{
				UUIItem rootItem = viewByName.GetRootItem();
				UUIItem originalItem = this.GetOriginalItem();
				if (originalItem != null)
				{
					originalItem.SetUIParent(rootItem, false);
				}
				this.HasAttachVideoView = true;
			}
		}

		// Token: 0x06029B33 RID: 170803 RVA: 0x00BC96B9 File Offset: 0x00BC78B9
		private void OnVideoViewHide(bool _)
		{
			if (this.HasAttachVideoView)
			{
				UUIItem originalItem = this.GetOriginalItem();
				if (originalItem != null)
				{
					originalItem.SetUIParent(UiLayer.Instance.GetLayerRootUiItem(ELayerType.Float), false);
				}
				this.HasAttachVideoView = false;
			}
		}

		// Token: 0x04016C09 RID: 93193
		private bool HasAttachVideoView;

		// Token: 0x02009C49 RID: 40009
		private enum EChildComp
		{
			// Token: 0x04030A26 RID: 199206
			Texture
		}
	}
}
