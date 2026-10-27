using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B6E RID: 7022
public class FloroRanchPhaseSettleView : UiViewBase
{
	// Token: 0x0600D0DA RID: 53466 RVA: 0x002FB74A File Offset: 0x002F994A
	[NullableContext(1)]
	public FloroRanchPhaseSettleView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D0DB RID: 53467 RVA: 0x002FB754 File Offset: 0x002F9954
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(USpineSkeletonAnimationComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickSureBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D0DC RID: 53468 RVA: 0x002FB948 File Offset: 0x002F9B48
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchPhaseSettleView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchPhaseSettleView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D0DD RID: 53469 RVA: 0x002FB98C File Offset: 0x002F9B8C
	protected override void OnBeforeShow()
	{
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			return;
		}
		FloroRanchPhaseSettleViewParam floroRanchPhaseSettleViewParam = (FloroRanchPhaseSettleViewParam)this.OpenParam;
		FloroRanchStageEnd stageEndData = floroRanchPhaseSettleViewParam.StageEndData;
		this.CloseCallback = floroRanchPhaseSettleViewParam.CloseCallback;
		int curStage = FloroRanchGamePlayModel.Instance.CurStage;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "FloroRanchStageResult", new <>z__ReadOnlySingleElementList<object>(curStage));
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		int maxStage = currentActivityData.GetFloroRanchSubDungeonData(subInstanceId).GetMaxStage();
		bool flag = curStage >= maxStage;
		this.IsSuccess = stageEndData.Win;
		string textStringId = (flag || !this.IsSuccess) ? "Farm_Confirm" : "Farm_NewState";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textStringId, Array.Empty<object>());
		this.StageTarget = FloroRanchGamePlayModel.Instance.GetStageTarget();
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(FloroRanchModel.Instance.GetCoinText(this.StageTarget), true);
		}
		string coinText = FloroRanchModel.Instance.GetCoinText(stageEndData.TotalCoin);
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.SetText(coinText.ToString(), true);
		}
		string textStringId2 = this.IsSuccess ? "FloroRanchStageSuccess" : "FloroRanchStageFail";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId2, Array.Empty<object>());
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(this.IsSuccess);
		}
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			item2.SetUIActive(!this.IsSuccess);
		}
		ESpineAnimation espineAnimation = this.IsSuccess ? ESpineAnimation.Success : ESpineAnimation.Fail;
		USpineSkeletonAnimationComponent spine = base.GetSpine(11);
		if (spine != null)
		{
			spine.SetAnimation(0, espineAnimation.ToString(), true);
		}
		FloroRanchAudioData floroRanchRandomAudioDataByType = FloroRanchModel.Instance.GetFloroRanchRandomAudioDataByType(this.IsSuccess ? EFloroRanchAudioType.StageSuccess : EFloroRanchAudioType.StageFail, currentActivityData.GetVoiceCharacterType());
		string text3 = (floroRanchRandomAudioDataByType != null) ? floroRanchRandomAudioDataByType.GetAudioText() : null;
		string text4 = (floroRanchRandomAudioDataByType != null) ? floroRanchRandomAudioDataByType.GetAudioEvent() : null;
		if (string.IsNullOrEmpty(text3))
		{
			UUIItem item3 = base.GetItem(7);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), text3, Array.Empty<object>());
			if (!string.IsNullOrEmpty(text4))
			{
				this.EventHandle = AudioSystem.Instance.PostEvent(text4);
			}
			UUIItem item4 = base.GetItem(7);
			if (item4 != null)
			{
				item4.SetUIActive(true);
			}
		}
		if (this.IsSuccess)
		{
			base.GetSpine(11).SetAnimation(0, "success", false).AnimationComplete.Add(delegate(UTrackEntry _)
			{
				base.GetSpine(11).SetAnimation(0, "success_loop", true);
			});
			return;
		}
		base.GetSpine(11).SetAnimation(0, "fail", false).AnimationComplete.Add(delegate(UTrackEntry _)
		{
			base.GetSpine(11).SetAnimation(0, "fail_loop", true);
		});
	}

	// Token: 0x0600D0DE RID: 53470 RVA: 0x002FBC48 File Offset: 0x002F9E48
	private void OnClickSureBtn()
	{
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			return;
		}
		int id = currentActivityData.Id;
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		if (this.IsSuccess)
		{
			FloroRanchController.Instance.SendFloroRanchPlayTributeRequest(id, subInstanceId, delegate(FloroRanchPlayTributeResponse response)
			{
				this.IsSettle = response.Settle;
				if (this.EventHandle != 0)
				{
					AudioSystem.Instance.ExecuteAction(this.EventHandle, EAudioActionType.Stop, null);
				}
				base.CloseMe(null);
				if (this.CloseCallback != null)
				{
					this.CloseCallback(this.IsSettle);
				}
			});
			return;
		}
		if (this.EventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.EventHandle, EAudioActionType.Stop, null);
		}
		this.IsSettle = true;
		base.CloseMe(null);
		if (this.CloseCallback != null)
		{
			this.CloseCallback(this.IsSettle);
		}
	}

	// Token: 0x04005FD6 RID: 24534
	private int EventHandle;

	// Token: 0x04005FD7 RID: 24535
	private long StageTarget;

	// Token: 0x04005FD8 RID: 24536
	private bool IsSuccess;

	// Token: 0x04005FD9 RID: 24537
	private bool IsSettle;

	// Token: 0x04005FDA RID: 24538
	[Nullable(2)]
	private Action<bool> CloseCallback;

	// Token: 0x020080E0 RID: 32992
	private class EComponents
	{
		// Token: 0x0402A0C1 RID: 172225
		public const int TextureTitleBg = 0;

		// Token: 0x0402A0C2 RID: 172226
		public const int TextTitle = 1;

		// Token: 0x0402A0C3 RID: 172227
		public const int TextDescription = 2;

		// Token: 0x0402A0C4 RID: 172228
		public const int TextTarget = 3;

		// Token: 0x0402A0C5 RID: 172229
		public const int TextCurNum = 4;

		// Token: 0x0402A0C6 RID: 172230
		public const int BtnSure = 5;

		// Token: 0x0402A0C7 RID: 172231
		public const int BtnText = 6;

		// Token: 0x0402A0C8 RID: 172232
		public const int ItemChatBubble = 7;

		// Token: 0x0402A0C9 RID: 172233
		public const int TextChatBubble = 8;

		// Token: 0x0402A0CA RID: 172234
		public const int ItemComplete = 9;

		// Token: 0x0402A0CB RID: 172235
		public const int ItemNotComplete = 10;

		// Token: 0x0402A0CC RID: 172236
		public const int SpineRole = 11;
	}
}
