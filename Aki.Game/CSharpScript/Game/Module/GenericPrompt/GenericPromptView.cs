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
	// Token: 0x02005998 RID: 22936
	[NullableContext(1)]
	[Nullable(0)]
	public class GenericPromptView : UiTickViewBase
	{
		// Token: 0x0603A343 RID: 238403 RVA: 0x00DD50D8 File Offset: 0x00DD32D8
		private int Compare(IPromptParamHub prompt1, IPromptParamHub prompt2)
		{
			GenericPromptConfig instance = GenericPromptConfig.Instance;
			int priority = instance.GetPriority(prompt1);
			return instance.GetPriority(prompt2) - priority;
		}

		// Token: 0x0603A344 RID: 238404 RVA: 0x00DD50FA File Offset: 0x00DD32FA
		public GenericPromptView(UiViewInfo info) : base(info)
		{
			this.WaitingTipsList = new PriorityQueue<IPromptParamHub>(new Comparison<IPromptParamHub>(this.Compare));
		}

		// Token: 0x0603A345 RID: 238405 RVA: 0x00DD5128 File Offset: 0x00DD3328
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

		// Token: 0x0603A346 RID: 238406 RVA: 0x00DD5194 File Offset: 0x00DD3394
		protected override UniTask OnBeforeStartAsync()
		{
			GenericPromptView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GenericPromptView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A347 RID: 238407 RVA: 0x00DD51D7 File Offset: 0x00DD33D7
		protected override void OnTick(float delta)
		{
			this.PromptView.Tick(delta);
		}

		// Token: 0x0603A348 RID: 238408 RVA: 0x00DD51E5 File Offset: 0x00DD33E5
		protected override void OnBeforeDestroy()
		{
			this.PromptView.SetHideCallback(null);
			this.WaitingTipsList.Clear();
			this.CanCancelPromptMap.Clear();
		}

		// Token: 0x0603A349 RID: 238409 RVA: 0x00DD520C File Offset: 0x00DD340C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IPromptParamHub>(EEventName.InsertFloatTips, new Action<IPromptParamHub>(this.InsertFloatTips));
			EventSystem.Instance.Add<string>(EEventName.RemoveFloatTips, new Action<string>(this.RemoveFloatTips));
			EventSystem.Instance.Add<bool>(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
		}

		// Token: 0x0603A34A RID: 238410 RVA: 0x00DD5270 File Offset: 0x00DD3470
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IPromptParamHub>(EEventName.InsertFloatTips, new Action<IPromptParamHub>(this.InsertFloatTips));
			EventSystem.Instance.Remove<string>(EEventName.RemoveFloatTips, new Action<string>(this.RemoveFloatTips));
			EventSystem.Instance.Remove<bool>(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
		}

		// Token: 0x0603A34B RID: 238411 RVA: 0x00DD52D1 File Offset: 0x00DD34D1
		private void InsertFloatTips(IPromptParamHub promptParamHub)
		{
			if (!string.IsNullOrEmpty(promptParamHub.PromptKey))
			{
				this.CanCancelPromptMap[promptParamHub.PromptKey] = promptParamHub;
			}
			this.WaitingTipsList.Push(promptParamHub);
			this.InvokeShow();
		}

		// Token: 0x0603A34C RID: 238412 RVA: 0x00DD5304 File Offset: 0x00DD3504
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

		// Token: 0x0603A34D RID: 238413 RVA: 0x00DD5384 File Offset: 0x00DD3584
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

		// Token: 0x0603A34E RID: 238414 RVA: 0x00DD53D8 File Offset: 0x00DD35D8
		private void HidePromptViewCallback(PromptForFloatLineView promptView)
		{
			if (this.WaitingTipsList.Empty)
			{
				return;
			}
			Log.Instance.Info(ELogModule.GenericPrompt, ELogAuthor.XXJ, "获取下一个显示数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.InvokeShow();
		}

		// Token: 0x0603A34F RID: 238415 RVA: 0x00DD5415 File Offset: 0x00DD3615
		private void ShowByType(IPromptParamHub promptParamHub)
		{
			this.PromptView.SetPromptHub(promptParamHub);
			this.PromptView.ShowView();
		}

		// Token: 0x0603A350 RID: 238416 RVA: 0x00DD5430 File Offset: 0x00DD3630
		private void InvokeShow()
		{
			IPromptParamHub promptParamHub = this.WaitingTipsList.Pop();
			if (!string.IsNullOrEmpty(promptParamHub.PromptKey))
			{
				this.CanCancelPromptMap.Remove(promptParamHub.PromptKey);
			}
			this.ShowByType(promptParamHub);
		}

		// Token: 0x0603A351 RID: 238417 RVA: 0x00DD5470 File Offset: 0x00DD3670
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

		// Token: 0x0401E5DB RID: 124379
		public Dictionary<string, IPromptParamHub> CanCancelPromptMap = new Dictionary<string, IPromptParamHub>();

		// Token: 0x0401E5DC RID: 124380
		private readonly PriorityQueue<IPromptParamHub> WaitingTipsList;

		// Token: 0x0401E5DD RID: 124381
		[Nullable(2)]
		private PromptForFloatLineView PromptView;

		// Token: 0x0200BC14 RID: 48148
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x04038C4E RID: 232526
			public const int FloatTipsParentItem = 0;

			// Token: 0x04038C4F RID: 232527
			public const int FloatTipsItem = 1;
		}
	}
}
