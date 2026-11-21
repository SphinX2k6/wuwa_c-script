using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt.GenericPromptSubViews;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x02004971 RID: 18801
	[NullableContext(1)]
	[Nullable(0)]
	public class GenericPromptView : UiTickViewBase
	{
		// Token: 0x0602F269 RID: 193129 RVA: 0x00D24568 File Offset: 0x00D22768
		private int Compare(IPromptParamHub prompt1, IPromptParamHub prompt2)
		{
			GenericPromptConfig instance = GenericPromptConfig.Instance;
			int priority = instance.GetPriority(prompt1);
			return instance.GetPriority(prompt2) - priority;
		}

		// Token: 0x0602F26A RID: 193130 RVA: 0x00D2458A File Offset: 0x00D2278A
		public GenericPromptView(UiViewInfo info) : base(info)
		{
			this.WaitingTipsList = new PriorityQueue<IPromptParamHub>(new Comparison<IPromptParamHub>(this.Compare));
		}

		// Token: 0x0602F26B RID: 193131 RVA: 0x00D245B8 File Offset: 0x00D227B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602F26C RID: 193132 RVA: 0x00D24624 File Offset: 0x00D22824
		protected override UniTask OnBeforeStartAsync()
		{
			GenericPromptView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GenericPromptView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F26D RID: 193133 RVA: 0x00D24667 File Offset: 0x00D22867
		protected override void OnTick(float delta)
		{
			this.PromptView.Tick(delta);
		}

		// Token: 0x0602F26E RID: 193134 RVA: 0x00D24675 File Offset: 0x00D22875
		protected override void OnBeforeDestroy()
		{
			this.PromptView.SetHideCallback(null);
			this.WaitingTipsList.Clear();
			this.CanCancelPromptMap.Clear();
		}

		// Token: 0x0602F26F RID: 193135 RVA: 0x00D2469C File Offset: 0x00D2289C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IPromptParamHub>(EEventName.InsertFloatTips, new Action<IPromptParamHub>(this.InsertFloatTips));
			EventSystem.Instance.Add<string>(EEventName.RemoveFloatTips, new Action<string>(this.RemoveFloatTips));
			EventSystem.Instance.Add<bool>(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
		}

		// Token: 0x0602F270 RID: 193136 RVA: 0x00D24700 File Offset: 0x00D22900
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IPromptParamHub>(EEventName.InsertFloatTips, new Action<IPromptParamHub>(this.InsertFloatTips));
			EventSystem.Instance.Remove<string>(EEventName.RemoveFloatTips, new Action<string>(this.RemoveFloatTips));
			EventSystem.Instance.Remove<bool>(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
		}

		// Token: 0x0602F271 RID: 193137 RVA: 0x00D24761 File Offset: 0x00D22961
		private void InsertFloatTips(IPromptParamHub promptParamHub)
		{
			if (!string.IsNullOrEmpty(promptParamHub.PromptKey))
			{
				this.CanCancelPromptMap[promptParamHub.PromptKey] = promptParamHub;
			}
			this.WaitingTipsList.Push(promptParamHub);
			this.InvokeShow();
		}

		// Token: 0x0602F272 RID: 193138 RVA: 0x00D24794 File Offset: 0x00D22994
		private void RemoveFloatTips(string promptKey)
		{
			IPromptParamHub item;
			if (this.CanCancelPromptMap.TryGetValue(promptKey, out item))
			{
				this.WaitingTipsList.Remove(item);
				this.CanCancelPromptMap.Remove(promptKey);
				return;
			}
			PromptForFloatLineView promptView = this.PromptView;
			string value;
			if (promptView == null)
			{
				value = null;
			}
			else
			{
				IPromptParamHub paramHub = promptView.ParamHub;
				value = ((paramHub != null) ? paramHub.PromptKey : null);
			}
			if (!string.IsNullOrEmpty(value) && this.PromptView.ParamHub.PromptKey == promptKey)
			{
				this.PromptView.HideView();
			}
		}

		// Token: 0x0602F273 RID: 193139 RVA: 0x00D24814 File Offset: 0x00D22A14
		private void SetVerticalOffset()
		{
			GenericPromptTypes? promptTypeInfo = GenericPromptConfig.Instance.GetPromptTypeInfo(9);
			if (promptTypeInfo.Value.OffsetY == 0f)
			{
				return;
			}
			UUIItem item = base.GetItem(0);
			item.SetAnchorOffsetY(item.GetAnchorOffsetY() + promptTypeInfo.Value.OffsetY);
		}

		// Token: 0x0602F274 RID: 193140 RVA: 0x00D24868 File Offset: 0x00D22A68
		private void HidePromptViewCallback(PromptForFloatLineView promptView)
		{
			if (this.WaitingTipsList.Empty)
			{
				return;
			}
			Log.Instance.Info(ELogModule.GenericPrompt, ELogAuthor.XXJ, "获取下一个显示数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.InvokeShow();
		}

		// Token: 0x0602F275 RID: 193141 RVA: 0x00D248A5 File Offset: 0x00D22AA5
		private void ShowByType(IPromptParamHub promptParamHub)
		{
			this.PromptView.SetPromptHub(promptParamHub);
			this.PromptView.ShowView();
		}

		// Token: 0x0602F276 RID: 193142 RVA: 0x00D248C0 File Offset: 0x00D22AC0
		private void InvokeShow()
		{
			IPromptParamHub promptParamHub = this.WaitingTipsList.Pop();
			if (!string.IsNullOrEmpty(promptParamHub.PromptKey))
			{
				this.CanCancelPromptMap.Remove(promptParamHub.PromptKey);
			}
			this.ShowByType(promptParamHub);
		}

		// Token: 0x0602F277 RID: 193143 RVA: 0x00D24900 File Offset: 0x00D22B00
		private void OnPreparePhotoScreenShot(bool _)
		{
			PromptForFloatLineView promptView = this.PromptView;
			if (promptView != null)
			{
				UUIItem rootItem = promptView.GetRootItem();
				if (rootItem != null)
				{
					rootItem.SetUIActive(false);
				}
			}
			PromptForFloatLineView promptView2 = this.PromptView;
			if (promptView2 != null && promptView2.IsShowOrShowing)
			{
				PromptForFloatLineView promptView3 = this.PromptView;
				if (promptView3 == null)
				{
					return;
				}
				promptView3.SetActive(false);
			}
		}

		// Token: 0x04019079 RID: 102521
		public Dictionary<string, IPromptParamHub> CanCancelPromptMap = new Dictionary<string, IPromptParamHub>();

		// Token: 0x0401907A RID: 102522
		private readonly PriorityQueue<IPromptParamHub> WaitingTipsList;

		// Token: 0x0401907B RID: 102523
		[Nullable(2)]
		private PromptForFloatLineView PromptView;

		// Token: 0x0200A61F RID: 42527
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x0403361D RID: 210461
			public const int FloatTipsParentItem = 0;

			// Token: 0x0403361E RID: 210462
			public const int FloatTipsItem = 1;
		}
	}
}
