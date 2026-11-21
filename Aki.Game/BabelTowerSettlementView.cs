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

// Token: 0x0200063D RID: 1597
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerSettlementView : UiViewBase
{
	// Token: 0x06004A48 RID: 19016 RVA: 0x00193EE7 File Offset: 0x001920E7
	public BabelTowerSettlementView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06004A49 RID: 19017 RVA: 0x00193EF0 File Offset: 0x001920F0
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

	// Token: 0x06004A4A RID: 19018 RVA: 0x001942E9 File Offset: 0x001924E9
	protected override void OnBeforeCreate()
	{
		this.GachaSequence = new UiBehaviorGachaSequence();
		base.AddUiBehavior(this.GachaSequence);
	}

	// Token: 0x06004A4B RID: 19019 RVA: 0x00194304 File Offset: 0x00192504
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerSettlementView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerSettlementView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004A4C RID: 19020 RVA: 0x00194348 File Offset: 0x00192548
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

	// Token: 0x06004A4D RID: 19021 RVA: 0x001943CC File Offset: 0x001925CC
	protected override void OnBeforeShow()
	{
		this.TryPlayRoleSequence();
	}

	// Token: 0x06004A4E RID: 19022 RVA: 0x001943D4 File Offset: 0x001925D4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnFirstShare, new Action(this.OnRewardShare));
	}

	// Token: 0x06004A4F RID: 19023 RVA: 0x001943F2 File Offset: 0x001925F2
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFirstShare, new Action(this.OnRewardShare));
	}

	// Token: 0x06004A50 RID: 19024 RVA: 0x00194410 File Offset: 0x00192610
	private static bool IsRankImproved(int oldRank, int newRank)
	{
		return newRank > 0 && (oldRank <= 0 || newRank < oldRank);
	}

	// Token: 0x06004A51 RID: 19025 RVA: 0x00194422 File Offset: 0x00192622
	private BabelTowerSettlementDeTermLayoutItem CreateDeTermLayoutItem()
	{
		return new BabelTowerSettlementDeTermLayoutItem
		{
			TemplateActor = (base.GetItem(12).GetOwner() as AUIBaseActor)
		};
	}

	// Token: 0x06004A52 RID: 19026 RVA: 0x00194441 File Offset: 0x00192641
	private BabelTowerSettlementRoleItem CreateRoleItem()
	{
		return new BabelTowerSettlementRoleItem();
	}

	// Token: 0x06004A53 RID: 19027 RVA: 0x00194448 File Offset: 0x00192648
	private void OnShareButtonClick()
	{
		this.OpenShareView();
	}

	// Token: 0x06004A54 RID: 19028 RVA: 0x00194450 File Offset: 0x00192650
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

	// Token: 0x06004A55 RID: 19029 RVA: 0x00194480 File Offset: 0x00192680
	private UniTask WaitFrame()
	{
		BabelTowerSettlementView.<WaitFrame>d__25 <WaitFrame>d__;
		<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitFrame>d__.<>1__state = -1;
		<WaitFrame>d__.<>t__builder.Start<BabelTowerSettlementView.<WaitFrame>d__25>(ref <WaitFrame>d__);
		return <WaitFrame>d__.<>t__builder.Task;
	}

	// Token: 0x06004A56 RID: 19030 RVA: 0x001944BC File Offset: 0x001926BC
	private UniTask OpenShareViewAsync()
	{
		BabelTowerSettlementView.<OpenShareViewAsync>d__26 <OpenShareViewAsync>d__;
		<OpenShareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenShareViewAsync>d__.<>4__this = this;
		<OpenShareViewAsync>d__.<>1__state = -1;
		<OpenShareViewAsync>d__.<>t__builder.Start<BabelTowerSettlementView.<OpenShareViewAsync>d__26>(ref <OpenShareViewAsync>d__);
		return <OpenShareViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004A57 RID: 19031 RVA: 0x00194500 File Offset: 0x00192700
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

	// Token: 0x06004A58 RID: 19032 RVA: 0x0019453C File Offset: 0x0019273C
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

	// Token: 0x06004A59 RID: 19033 RVA: 0x001945AC File Offset: 0x001927AC
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

	// Token: 0x06004A5A RID: 19034 RVA: 0x0019461B File Offset: 0x0019281B
	private void OnRewardShare()
	{
		this.RefreshShareRewardTip();
	}

	// Token: 0x06004A5B RID: 19035 RVA: 0x00194624 File Offset: 0x00192824
	public UniTask RefreshAsync()
	{
		BabelTowerSettlementView.<RefreshAsync>d__31 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<BabelTowerSettlementView.<RefreshAsync>d__31>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004A5C RID: 19036 RVA: 0x00194668 File Offset: 0x00192868
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

	// Token: 0x06004A5D RID: 19037 RVA: 0x00194760 File Offset: 0x00192960
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

	// Token: 0x06004A5E RID: 19038 RVA: 0x001947A7 File Offset: 0x001929A7
	protected void TryPlayRoleSequence()
	{
		if (this.IsPlayingRoleSequence)
		{
			return;
		}
		this.IsPlayingRoleSequence = true;
		this.GachaSequence.PlayRoleSequence(this.SequenceRoleId, 0);
	}

	// Token: 0x0400370B RID: 14091
	[Nullable(2)]
	private IBabelTowerSettlementViewData Data;

	// Token: 0x0400370C RID: 14092
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<BabelTowerSettlementDeTermLayoutItem, int[]> DeTermLayout;

	// Token: 0x0400370D RID: 14093
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<BabelTowerSettlementRoleItem, int> RoleLayout;

	// Token: 0x0400370E RID: 14094
	private UiBehaviorGachaSequence GachaSequence;

	// Token: 0x0400370F RID: 14095
	[Nullable(2)]
	private AActor SceneSequenceCamera;

	// Token: 0x04003710 RID: 14096
	[Nullable(2)]
	private BP_UpdateInteract_C UpdateInteractBp;

	// Token: 0x04003711 RID: 14097
	private bool IsPlayingRoleSequence;

	// Token: 0x04003712 RID: 14098
	private FMargin? OddLinePadding;

	// Token: 0x04003713 RID: 14099
	private FMargin? EvenLinePadding;

	// Token: 0x04003714 RID: 14100
	private int SequenceRoleId;

	// Token: 0x04003715 RID: 14101
	private int ShareId;

	// Token: 0x020068F2 RID: 26866
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022955 RID: 141653
		public const int StarNumText = 0;

		// Token: 0x04022956 RID: 141654
		public const int DifficultySprite = 1;

		// Token: 0x04022957 RID: 141655
		public const int DifficultyText = 2;

		// Token: 0x04022958 RID: 141656
		public const int DungeonNameText = 3;

		// Token: 0x04022959 RID: 141657
		public const int DungeonSubTitleText = 4;

		// Token: 0x0402295A RID: 141658
		public const int PassTimeText = 5;

		// Token: 0x0402295B RID: 141659
		public const int NoneBuffItem = 6;

		// Token: 0x0402295C RID: 141660
		public const int FirstBuffIconTexture = 7;

		// Token: 0x0402295D RID: 141661
		public const int SecondBuffIconTexture = 8;

		// Token: 0x0402295E RID: 141662
		public const int DeTermVerticalLayout = 9;

		// Token: 0x0402295F RID: 141663
		public const int OddLineHorizontalLayout = 10;

		// Token: 0x04022960 RID: 141664
		public const int EvenLineHorizontalLayout = 11;

		// Token: 0x04022961 RID: 141665
		public const int DeTermItem = 12;

		// Token: 0x04022962 RID: 141666
		public const int ShareItem = 13;

		// Token: 0x04022963 RID: 141667
		public const int ShareButton = 14;

		// Token: 0x04022964 RID: 141668
		public const int ShareText = 15;

		// Token: 0x04022965 RID: 141669
		public const int RoleTeamVerticalLayout = 16;

		// Token: 0x04022966 RID: 141670
		public const int ConfirmButton = 17;

		// Token: 0x04022967 RID: 141671
		public const int ShareRewardTipItem = 18;

		// Token: 0x04022968 RID: 141672
		public const int Buff1Btn = 19;

		// Token: 0x04022969 RID: 141673
		public const int Buff2Btn = 20;

		// Token: 0x0402296A RID: 141674
		public const int RankTipsItem = 21;

		// Token: 0x0402296B RID: 141675
		public const int RankItem = 22;

		// Token: 0x0402296C RID: 141676
		public const int BuffNumText = 23;
	}
}
