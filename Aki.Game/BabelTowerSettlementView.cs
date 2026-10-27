using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001189 RID: 4489
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerSettlementView : UiViewBase
{
	// Token: 0x060076B1 RID: 30385 RVA: 0x0018B337 File Offset: 0x00189537
	public BabelTowerSettlementView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060076B2 RID: 30386 RVA: 0x0018B340 File Offset: 0x00189540
	protected unsafe override void OnRegisterComponent()
	{
		int num = 24;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnShareButtonClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.OnConfirmButtonClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(19, new Action(this.OnBuff1ButtonClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(20, new Action(this.OnBuff2ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060076B3 RID: 30387 RVA: 0x0018B739 File Offset: 0x00189939
	protected override void OnBeforeCreate()
	{
		this.GachaSequence = new UiBehaviorGachaSequence();
		base.AddUiBehavior(this.GachaSequence);
	}

	// Token: 0x060076B4 RID: 30388 RVA: 0x0018B754 File Offset: 0x00189954
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerSettlementView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerSettlementView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060076B5 RID: 30389 RVA: 0x0018B798 File Offset: 0x00189998
	protected override void OnHandleLoadScene()
	{
		this.SceneSequenceCamera = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("SceneCamera1").Value, ECollectActorType.Default);
		this.GachaSequence.BindSceneSequenceCamera(this.SceneSequenceCamera);
		this.UpdateInteractBp = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("UpdateInteractBP").Value, ECollectActorType.Default) as BP_UpdateInteract_C);
		if (this.UpdateInteractBp != null)
		{
			this.UpdateInteractBp.SetTickableWhenPaused(true);
		}
		this.GachaSequence.BindUpdateInteractBp(this.UpdateInteractBp);
	}

	// Token: 0x060076B6 RID: 30390 RVA: 0x0018B81C File Offset: 0x00189A1C
	protected override void OnBeforeShow()
	{
		this.TryPlayRoleSequence();
	}

	// Token: 0x060076B7 RID: 30391 RVA: 0x0018B824 File Offset: 0x00189A24
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnFirstShare, new Action(this.OnRewardShare));
	}

	// Token: 0x060076B8 RID: 30392 RVA: 0x0018B842 File Offset: 0x00189A42
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFirstShare, new Action(this.OnRewardShare));
	}

	// Token: 0x060076B9 RID: 30393 RVA: 0x0018B860 File Offset: 0x00189A60
	private static bool IsRankImproved(int oldRank, int newRank)
	{
		return newRank > 0 && (oldRank <= 0 || newRank < oldRank);
	}

	// Token: 0x060076BA RID: 30394 RVA: 0x0018B872 File Offset: 0x00189A72
	private BabelTowerSettlementDeTermLayoutItem CreateDeTermLayoutItem()
	{
		return new BabelTowerSettlementDeTermLayoutItem
		{
			TemplateActor = (base.GetItem(12).GetOwner() as AUIBaseActor)
		};
	}

	// Token: 0x060076BB RID: 30395 RVA: 0x0018B891 File Offset: 0x00189A91
	private BabelTowerSettlementRoleItem CreateRoleItem()
	{
		return new BabelTowerSettlementRoleItem();
	}

	// Token: 0x060076BC RID: 30396 RVA: 0x0018B898 File Offset: 0x00189A98
	private void OnShareButtonClick()
	{
		this.OpenShareView();
	}

	// Token: 0x060076BD RID: 30397 RVA: 0x0018B8A0 File Offset: 0x00189AA0
	private void OpenShareView()
	{
		UiAsyncTask task = new UiAsyncTask("OpenShareView", delegate()
		{
			BabelTowerSettlementView.<<OpenShareView>b__24_0>d <<OpenShareView>b__24_0>d;
			<<OpenShareView>b__24_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OpenShareView>b__24_0>d.<>4__this = this;
			<<OpenShareView>b__24_0>d.<>1__state = -1;
			<<OpenShareView>b__24_0>d.<>t__builder.Start<BabelTowerSettlementView.<<OpenShareView>b__24_0>d>(ref <<OpenShareView>b__24_0>d);
			return <<OpenShareView>b__24_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060076BE RID: 30398 RVA: 0x0018B8D0 File Offset: 0x00189AD0
	private UniTask WaitFrame()
	{
		BabelTowerSettlementView.<WaitFrame>d__25 <WaitFrame>d__;
		<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitFrame>d__.<>1__state = -1;
		<WaitFrame>d__.<>t__builder.Start<BabelTowerSettlementView.<WaitFrame>d__25>(ref <WaitFrame>d__);
		return <WaitFrame>d__.<>t__builder.Task;
	}

	// Token: 0x060076BF RID: 30399 RVA: 0x0018B90C File Offset: 0x00189B0C
	private UniTask OpenShareViewAsync()
	{
		BabelTowerSettlementView.<OpenShareViewAsync>d__26 <OpenShareViewAsync>d__;
		<OpenShareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenShareViewAsync>d__.<>4__this = this;
		<OpenShareViewAsync>d__.<>1__state = -1;
		<OpenShareViewAsync>d__.<>t__builder.Start<BabelTowerSettlementView.<OpenShareViewAsync>d__26>(ref <OpenShareViewAsync>d__);
		return <OpenShareViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060076C0 RID: 30400 RVA: 0x0018B950 File Offset: 0x00189B50
	private void OnConfirmButtonClick()
	{
		BabelTowerHardLevelChoseViewData param = new BabelTowerHardLevelChoseViewData
		{
			IfReturnToBabelTowerMainView = true,
			IfLeaveInstanceDungeonWhenMainViewClose = true
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerHardLevelChoseView, param, null);
		base.CloseMe(null);
	}

	// Token: 0x060076C1 RID: 30401 RVA: 0x0018B98C File Offset: 0x00189B8C
	private void OnBuff1ButtonClick()
	{
		BabelTowerItemInfoViewInfo babelTowerItemInfoViewInfo = new BabelTowerItemInfoViewInfo();
		babelTowerItemInfoViewInfo.IsDeTerm = false;
		IBabelTowerSettlementViewData data = this.Data;
		int? num;
		if (data == null)
		{
			num = null;
		}
		else
		{
			List<int> buffIdList = data.BuffIdList;
			num = ((buffIdList != null) ? buffIdList.GetValueOrNull(0) : null);
		}
		int? num2 = num;
		babelTowerItemInfoViewInfo.ConfigId = num2.GetValueOrDefault();
		babelTowerItemInfoViewInfo.ShowWays = false;
		BabelTowerItemInfoViewInfo param = babelTowerItemInfoViewInfo;
		UiManager.Instance.OpenView(EUiViewName.BabelTowerItemInfoView, param, null);
	}

	// Token: 0x060076C2 RID: 30402 RVA: 0x0018B9FC File Offset: 0x00189BFC
	private void OnBuff2ButtonClick()
	{
		BabelTowerItemInfoViewInfo babelTowerItemInfoViewInfo = new BabelTowerItemInfoViewInfo();
		babelTowerItemInfoViewInfo.IsDeTerm = false;
		IBabelTowerSettlementViewData data = this.Data;
		int? num;
		if (data == null)
		{
			num = null;
		}
		else
		{
			List<int> buffIdList = data.BuffIdList;
			num = ((buffIdList != null) ? buffIdList.GetValueOrNull(1) : null);
		}
		int? num2 = num;
		babelTowerItemInfoViewInfo.ConfigId = num2.GetValueOrDefault();
		babelTowerItemInfoViewInfo.ShowWays = false;
		BabelTowerItemInfoViewInfo param = babelTowerItemInfoViewInfo;
		UiManager.Instance.OpenView(EUiViewName.BabelTowerItemInfoView, param, null);
	}

	// Token: 0x060076C3 RID: 30403 RVA: 0x0018BA6B File Offset: 0x00189C6B
	private void OnRewardShare()
	{
		this.RefreshShareRewardTip();
	}

	// Token: 0x060076C4 RID: 30404 RVA: 0x0018BA74 File Offset: 0x00189C74
	public UniTask RefreshAsync()
	{
		BabelTowerSettlementView.<RefreshAsync>d__31 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<BabelTowerSettlementView.<RefreshAsync>d__31>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060076C5 RID: 30405 RVA: 0x0018BAB8 File Offset: 0x00189CB8
	private void RefreshShareRewardTip()
	{
		if (this.ShareId <= 0)
		{
			return;
		}
		bool flag = ChannelModel.Instance.CouldGetShareReward((EShareActionId)this.ShareId);
		base.GetItem(18).SetUIActive(flag);
		if (flag)
		{
			ShareReward? config = ConfigShareRewardById.GetConfig(this.ShareId, true);
			if (config == null)
			{
				return;
			}
			int itemConfigId = 0;
			int num = 0;
			if (config.Value.RewardLength > 0)
			{
				DicIntInt? dicIntInt = config.Value.Reward(0);
				if (dicIntInt != null)
				{
					itemConfigId = dicIntInt.Value.Key;
					num = dicIntInt.Value.Value;
				}
			}
			string iconSmall = ItemConfig.Instance.GetConfig(itemConfigId).Value.IconSmall;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "BabelTowerResultShare_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				iconSmall,
				num
			}));
		}
	}

	// Token: 0x060076C6 RID: 30406 RVA: 0x0018BBB0 File Offset: 0x00189DB0
	public void SetShareState(bool showShareBtn)
	{
		UUIButtonComponent button = base.GetButton(17);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(showShareBtn);
			}
		}
		UUIItem item = base.GetItem(13);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(showShareBtn);
	}

	// Token: 0x060076C7 RID: 30407 RVA: 0x0018BBF7 File Offset: 0x00189DF7
	protected void TryPlayRoleSequence()
	{
		if (this.IsPlayingRoleSequence)
		{
			return;
		}
		this.IsPlayingRoleSequence = true;
		this.GachaSequence.PlayRoleSequence(this.SequenceRoleId, 0);
	}

	// Token: 0x04003672 RID: 13938
	[Nullable(2)]
	private IBabelTowerSettlementViewData Data;

	// Token: 0x04003673 RID: 13939
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<BabelTowerSettlementDeTermLayoutItem, int[]> DeTermLayout;

	// Token: 0x04003674 RID: 13940
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<BabelTowerSettlementRoleItem, int> RoleLayout;

	// Token: 0x04003675 RID: 13941
	private UiBehaviorGachaSequence GachaSequence;

	// Token: 0x04003676 RID: 13942
	[Nullable(2)]
	private AActor SceneSequenceCamera;

	// Token: 0x04003677 RID: 13943
	[Nullable(2)]
	private BP_UpdateInteract_C UpdateInteractBp;

	// Token: 0x04003678 RID: 13944
	private bool IsPlayingRoleSequence;

	// Token: 0x04003679 RID: 13945
	private FMargin? OddLinePadding;

	// Token: 0x0400367A RID: 13946
	private FMargin? EvenLinePadding;

	// Token: 0x0400367B RID: 13947
	private int SequenceRoleId;

	// Token: 0x0400367C RID: 13948
	private int ShareId;

	// Token: 0x02007765 RID: 30565
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402761C RID: 161308
		public const int StarNumText = 0;

		// Token: 0x0402761D RID: 161309
		public const int DifficultySprite = 1;

		// Token: 0x0402761E RID: 161310
		public const int DifficultyText = 2;

		// Token: 0x0402761F RID: 161311
		public const int DungeonNameText = 3;

		// Token: 0x04027620 RID: 161312
		public const int DungeonSubTitleText = 4;

		// Token: 0x04027621 RID: 161313
		public const int PassTimeText = 5;

		// Token: 0x04027622 RID: 161314
		public const int NoneBuffItem = 6;

		// Token: 0x04027623 RID: 161315
		public const int FirstBuffIconTexture = 7;

		// Token: 0x04027624 RID: 161316
		public const int SecondBuffIconTexture = 8;

		// Token: 0x04027625 RID: 161317
		public const int DeTermVerticalLayout = 9;

		// Token: 0x04027626 RID: 161318
		public const int OddLineHorizontalLayout = 10;

		// Token: 0x04027627 RID: 161319
		public const int EvenLineHorizontalLayout = 11;

		// Token: 0x04027628 RID: 161320
		public const int DeTermItem = 12;

		// Token: 0x04027629 RID: 161321
		public const int ShareItem = 13;

		// Token: 0x0402762A RID: 161322
		public const int ShareButton = 14;

		// Token: 0x0402762B RID: 161323
		public const int ShareText = 15;

		// Token: 0x0402762C RID: 161324
		public const int RoleTeamVerticalLayout = 16;

		// Token: 0x0402762D RID: 161325
		public const int ConfirmButton = 17;

		// Token: 0x0402762E RID: 161326
		public const int ShareRewardTipItem = 18;

		// Token: 0x0402762F RID: 161327
		public const int Buff1Btn = 19;

		// Token: 0x04027630 RID: 161328
		public const int Buff2Btn = 20;

		// Token: 0x04027631 RID: 161329
		public const int RankTipsItem = 21;

		// Token: 0x04027632 RID: 161330
		public const int RankItem = 22;

		// Token: 0x04027633 RID: 161331
		public const int BuffNumText = 23;
	}
}
