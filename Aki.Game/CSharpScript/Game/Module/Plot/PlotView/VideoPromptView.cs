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
	// Token: 0x02005074 RID: 20596
	public class VideoPromptView : UiViewBase
	{
		// Token: 0x06034C37 RID: 216119 RVA: 0x00C7C115 File Offset: 0x00C7A315
		[NullableContext(1)]
		public VideoPromptView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034C38 RID: 216120 RVA: 0x00C7C120 File Offset: 0x00C7A320
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

		// Token: 0x06034C39 RID: 216121 RVA: 0x00C7C168 File Offset: 0x00C7A368
		protected override UniTask OnBeforeStartAsync()
		{
			VideoPromptView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VideoPromptView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034C3A RID: 216122 RVA: 0x00C7C1AB File Offset: 0x00C7A3AB
		protected override void OnStart()
		{
			this.OnVideoViewShow();
			EventSystem.Instance.Add(EEventName.VideoViewShow, new Action(this.OnVideoViewShow));
			EventSystem.Instance.Add<bool>(EEventName.VideoViewHide, new Action<bool>(this.OnVideoViewHide));
		}

		// Token: 0x06034C3B RID: 216123 RVA: 0x00C7C1EC File Offset: 0x00C7A3EC
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

		// Token: 0x06034C3C RID: 216124 RVA: 0x00C7C24C File Offset: 0x00C7A44C
		protected override void OnAfterHide()
		{
			this.OnVideoViewHide(false);
			EventSystem.Instance.Remove(EEventName.VideoViewShow, new Action(this.OnVideoViewShow));
			EventSystem.Instance.Remove<bool>(EEventName.VideoViewHide, new Action<bool>(this.OnVideoViewHide));
		}

		// Token: 0x06034C3D RID: 216125 RVA: 0x00C7C298 File Offset: 0x00C7A498
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

		// Token: 0x06034C3E RID: 216126 RVA: 0x00C7C2E1 File Offset: 0x00C7A4E1
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

		// Token: 0x0401C1DE RID: 115166
		private bool HasAttachVideoView;

		// Token: 0x0200B210 RID: 45584
		private enum EChildComp
		{
			// Token: 0x04035FD2 RID: 221138
			Texture
		}
	}
}
