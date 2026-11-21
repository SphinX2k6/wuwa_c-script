using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001023 RID: 4131
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchGamePlayView : UiViewBase
{
	// Token: 0x0600A42F RID: 42031 RVA: 0x00302737 File Offset: 0x00300937
	public FloroRanchGamePlayView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A430 RID: 42032 RVA: 0x0030276C File Offset: 0x0030096C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 61;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(52, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(51, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(54, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(40, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(41, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(42, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(43, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(44, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(45, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(46, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(47, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(48, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(49, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(50, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(53, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(55, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(56, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(57, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(58, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(59, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(60, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 11;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBackButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickSpeedChangeButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickHelpButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(20, new Action(this.OnClickUseSkillButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.OnClickNewDayButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(54, new Action(this.OnClickLastDayDetailButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(49, new Action(this.HideTips));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(55, new Action(this.OnClickLevelDetailButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickShowButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(56, new Action(this.OnClickDebugButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(59, new Action(this.OnClickCardCountButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A431 RID: 42033 RVA: 0x00303148 File Offset: 0x00301348
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchGamePlayView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchGamePlayView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A432 RID: 42034 RVA: 0x0030318C File Offset: 0x0030138C
	protected override void OnBeforeShow()
	{
		this.SetNewDayButtonActive(false);
		this.SetMaskPanelActive(false);
		this.SetShowButtonActive(false);
		this.RefreshCurrencyInfo();
		this.RefreshStageInfo();
		base.GetSpine(18).SetAnimation(0, "idle", true);
		base.GetItem(45).SetUIActive(false);
		base.GetItem(47).SetUIActive(false);
		foreach (FloroRanchEntityBase floroRanchEntityBase in FloroRanchGamePlayModel.Instance.GetShowTerrainEntityList())
		{
			floroRanchEntityBase.GetUiItemComponent().PlayShowAnim();
		}
		foreach (FloroRanchEntityBase floroRanchEntityBase2 in FloroRanchGamePlayModel.Instance.GetShowToyEntityList())
		{
			floroRanchEntityBase2.GetUiItemComponent().PlayShowAnim();
		}
		FloroRanchGamePlayModel.Instance.RoleEntity.GetUiItemComponent().PlayShowAnim();
	}

	// Token: 0x0600A433 RID: 42035 RVA: 0x00303298 File Offset: 0x00301498
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnFloroRanchStageInfoRefresh, new Action(this.OnFloroRanchBasicInfoRefresh));
		EventSystem.Instance.Add(EEventName.OnFloroRanchCardEntityCountChange, new Action(this.OnFloroRanchCardEntityCountChange));
	}

	// Token: 0x0600A434 RID: 42036 RVA: 0x003032D2 File Offset: 0x003014D2
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFloroRanchStageInfoRefresh, new Action(this.OnFloroRanchBasicInfoRefresh));
		EventSystem.Instance.Remove(EEventName.OnFloroRanchCardEntityCountChange, new Action(this.OnFloroRanchCardEntityCountChange));
	}

	// Token: 0x0600A435 RID: 42037 RVA: 0x0030330C File Offset: 0x0030150C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<FloroRanchUiTerrainItem> BindTerrainItem(FloroRanchEntityBase terrainEntity)
	{
		FloroRanchGamePlayView.<BindTerrainItem>d__29 <BindTerrainItem>d__;
		<BindTerrainItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiTerrainItem>.Create();
		<BindTerrainItem>d__.<>4__this = this;
		<BindTerrainItem>d__.terrainEntity = terrainEntity;
		<BindTerrainItem>d__.<>1__state = -1;
		<BindTerrainItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<BindTerrainItem>d__29>(ref <BindTerrainItem>d__);
		return <BindTerrainItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A436 RID: 42038 RVA: 0x00303358 File Offset: 0x00301558
	private UniTask CreateTerrainItem(int point)
	{
		FloroRanchGamePlayView.<CreateTerrainItem>d__30 <CreateTerrainItem>d__;
		<CreateTerrainItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTerrainItem>d__.<>4__this = this;
		<CreateTerrainItem>d__.point = point;
		<CreateTerrainItem>d__.<>1__state = -1;
		<CreateTerrainItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<CreateTerrainItem>d__30>(ref <CreateTerrainItem>d__);
		return <CreateTerrainItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A437 RID: 42039 RVA: 0x003033A4 File Offset: 0x003015A4
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<FloroRanchUiToyItem> BindToyItem(FloroRanchEntityBase toyEntity)
	{
		FloroRanchGamePlayView.<BindToyItem>d__31 <BindToyItem>d__;
		<BindToyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiToyItem>.Create();
		<BindToyItem>d__.<>4__this = this;
		<BindToyItem>d__.toyEntity = toyEntity;
		<BindToyItem>d__.<>1__state = -1;
		<BindToyItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<BindToyItem>d__31>(ref <BindToyItem>d__);
		return <BindToyItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A438 RID: 42040 RVA: 0x003033F0 File Offset: 0x003015F0
	private UniTask CreateToyItem(int point)
	{
		FloroRanchGamePlayView.<CreateToyItem>d__32 <CreateToyItem>d__;
		<CreateToyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateToyItem>d__.<>4__this = this;
		<CreateToyItem>d__.point = point;
		<CreateToyItem>d__.<>1__state = -1;
		<CreateToyItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<CreateToyItem>d__32>(ref <CreateToyItem>d__);
		return <CreateToyItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A439 RID: 42041 RVA: 0x0030343C File Offset: 0x0030163C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<FloroRanchUiCardItem> BindSpineItem(FloroRanchEntityBase cardEntity)
	{
		FloroRanchGamePlayView.<BindSpineItem>d__33 <BindSpineItem>d__;
		<BindSpineItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiCardItem>.Create();
		<BindSpineItem>d__.<>4__this = this;
		<BindSpineItem>d__.cardEntity = cardEntity;
		<BindSpineItem>d__.<>1__state = -1;
		<BindSpineItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<BindSpineItem>d__33>(ref <BindSpineItem>d__);
		return <BindSpineItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A43A RID: 42042 RVA: 0x00303488 File Offset: 0x00301688
	private UniTask CreateSpineItem(int point)
	{
		FloroRanchGamePlayView.<CreateSpineItem>d__34 <CreateSpineItem>d__;
		<CreateSpineItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSpineItem>d__.<>4__this = this;
		<CreateSpineItem>d__.point = point;
		<CreateSpineItem>d__.<>1__state = -1;
		<CreateSpineItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<CreateSpineItem>d__34>(ref <CreateSpineItem>d__);
		return <CreateSpineItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A43B RID: 42043 RVA: 0x003034D4 File Offset: 0x003016D4
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<FloroRanchUiRoleSkillItem> BindRoleSkillItem(FloroRanchEntityBase skillEntity)
	{
		FloroRanchGamePlayView.<BindRoleSkillItem>d__35 <BindRoleSkillItem>d__;
		<BindRoleSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiRoleSkillItem>.Create();
		<BindRoleSkillItem>d__.<>4__this = this;
		<BindRoleSkillItem>d__.skillEntity = skillEntity;
		<BindRoleSkillItem>d__.<>1__state = -1;
		<BindRoleSkillItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<BindRoleSkillItem>d__35>(ref <BindRoleSkillItem>d__);
		return <BindRoleSkillItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A43C RID: 42044 RVA: 0x00303520 File Offset: 0x00301720
	private UniTask CreateRoleSkillItem()
	{
		FloroRanchGamePlayView.<CreateRoleSkillItem>d__36 <CreateRoleSkillItem>d__;
		<CreateRoleSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRoleSkillItem>d__.<>4__this = this;
		<CreateRoleSkillItem>d__.<>1__state = -1;
		<CreateRoleSkillItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<CreateRoleSkillItem>d__36>(ref <CreateRoleSkillItem>d__);
		return <CreateRoleSkillItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A43D RID: 42045 RVA: 0x00303564 File Offset: 0x00301764
	private UniTask InitRightInfoTipItem()
	{
		FloroRanchGamePlayView.<InitRightInfoTipItem>d__37 <InitRightInfoTipItem>d__;
		<InitRightInfoTipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRightInfoTipItem>d__.<>4__this = this;
		<InitRightInfoTipItem>d__.<>1__state = -1;
		<InitRightInfoTipItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<InitRightInfoTipItem>d__37>(ref <InitRightInfoTipItem>d__);
		return <InitRightInfoTipItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A43E RID: 42046 RVA: 0x003035A8 File Offset: 0x003017A8
	private UniTask InitPopupRewardPanel()
	{
		FloroRanchGamePlayView.<InitPopupRewardPanel>d__38 <InitPopupRewardPanel>d__;
		<InitPopupRewardPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPopupRewardPanel>d__.<>4__this = this;
		<InitPopupRewardPanel>d__.<>1__state = -1;
		<InitPopupRewardPanel>d__.<>t__builder.Start<FloroRanchGamePlayView.<InitPopupRewardPanel>d__38>(ref <InitPopupRewardPanel>d__);
		return <InitPopupRewardPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600A43F RID: 42047 RVA: 0x003035EC File Offset: 0x003017EC
	private void InitSpeedInfo()
	{
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		this.SpeedList = (FloroRanchGamePlayModel.Instance.GetCurrentActivityData().GetFloroRanchSubDungeonData(subInstanceId).IsEndlessMode ? FloroRanchDefine.FloroRanchEndlessSpeedList : FloroRanchDefine.FloroRanchSpeedList);
		int num = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.FloroRanchSpeed, 1);
		if (num != 0)
		{
			this.CurSpeedIndex = this.SpeedList.IndexOf(num);
			if (this.CurSpeedIndex == -1)
			{
				this.CurSpeedIndex = this.SpeedList.Count - 1;
			}
		}
		num = this.SpeedList[this.CurSpeedIndex];
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.FloroRanchSpeed, num);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanch;
		ELogAuthor author = ELogAuthor.LRC;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
		defaultInterpolatedStringHandler.AppendLiteral("speed: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		defaultInterpolatedStringHandler.AppendLiteral(", CurSpeedIndex: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurSpeedIndex);
		instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		FloroRanchGamePlayModel.Instance.SetTimeDilation(num);
		if (num == 50)
		{
			base.GetText(2).SetText("MAX", true);
		}
		else
		{
			base.GetText(2).SetText("×" + num.ToString("F1"), true);
		}
		base.GetSprite(4).SetUIActive(this.CurSpeedIndex != 0);
	}

	// Token: 0x0600A440 RID: 42048 RVA: 0x00303740 File Offset: 0x00301940
	private UniTask InitDayProgressItem()
	{
		FloroRanchGamePlayView.<InitDayProgressItem>d__40 <InitDayProgressItem>d__;
		<InitDayProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDayProgressItem>d__.<>4__this = this;
		<InitDayProgressItem>d__.<>1__state = -1;
		<InitDayProgressItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<InitDayProgressItem>d__40>(ref <InitDayProgressItem>d__);
		return <InitDayProgressItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A441 RID: 42049 RVA: 0x00303784 File Offset: 0x00301984
	private UniTask InitEndlessDayProgressItem()
	{
		FloroRanchGamePlayView.<InitEndlessDayProgressItem>d__41 <InitEndlessDayProgressItem>d__;
		<InitEndlessDayProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitEndlessDayProgressItem>d__.<>4__this = this;
		<InitEndlessDayProgressItem>d__.<>1__state = -1;
		<InitEndlessDayProgressItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<InitEndlessDayProgressItem>d__41>(ref <InitEndlessDayProgressItem>d__);
		return <InitEndlessDayProgressItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A442 RID: 42050 RVA: 0x003037C8 File Offset: 0x003019C8
	private UniTask InitCurve()
	{
		FloroRanchGamePlayView.<InitCurve>d__42 <InitCurve>d__;
		<InitCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCurve>d__.<>4__this = this;
		<InitCurve>d__.<>1__state = -1;
		<InitCurve>d__.<>t__builder.Start<FloroRanchGamePlayView.<InitCurve>d__42>(ref <InitCurve>d__);
		return <InitCurve>d__.<>t__builder.Task;
	}

	// Token: 0x0600A443 RID: 42051 RVA: 0x0030380C File Offset: 0x00301A0C
	public void RefreshCurrencyInfo()
	{
		FloroRanchCurrencyData coinData = FloroRanchGamePlayModel.Instance.CoinData;
		FloroRanchCurrencyData diamondData = FloroRanchGamePlayModel.Instance.DiamondData;
		long amount = coinData.GetAmount();
		long stageTarget = FloroRanchGamePlayModel.Instance.StageTarget;
		base.GetText(12).SetText(FloroRanchModel.Instance.GetCoinText(amount) + "/" + FloroRanchModel.Instance.GetCoinText(stageTarget), true);
		base.GetTexture(14).SetFillAmount((float)amount * 1f / (float)stageTarget);
		this.ItemCost.SetCurrencyData(diamondData);
		long lastDayIncome = FloroRanchGamePlayModel.Instance.GetLastDayIncome();
		base.GetText(52).SetText(FloroRanchModel.Instance.GetCoinText(lastDayIncome), true);
		base.SetTextureByPath(coinData.ConfigData.GetSmallIcon(), base.GetTexture(51), null, null);
		base.SetTextureByPath(coinData.ConfigData.GetSmallIcon(), base.GetTexture(13), null, null);
	}

	// Token: 0x0600A444 RID: 42052 RVA: 0x00303904 File Offset: 0x00301B04
	private void RefreshStageInfo()
	{
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		FloroRanchSubDungeonData floroRanchSubDungeonData = this.ActivityData.GetFloroRanchSubDungeonData(subInstanceId);
		FloroRanchDungeonData floroRanchDungeonData = this.ActivityData.GetFloroRanchDungeonData(floroRanchSubDungeonData.InstanceId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), floroRanchDungeonData.GetDungeonName(), Array.Empty<object>());
		int curStage = FloroRanchGamePlayModel.Instance.CurStage;
		bool isEndlessMode = FloroRanchGamePlayModel.Instance.IsEndlessMode;
		if (isEndlessMode)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Farm_Stage1", new <>z__ReadOnlySingleElementList<object>(curStage));
		}
		else
		{
			int maxStage = floroRanchSubDungeonData.GetMaxStage();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Farm_Stage2", new <>z__ReadOnlyArray<object>(new object[]
			{
				curStage,
				maxStage
			}));
		}
		this.EndlessDayProgressItem.SetUiActive(isEndlessMode);
		this.DayProgressItem.SetUiActive(!isEndlessMode);
		int remindDay = FloroRanchGamePlayModel.Instance.RemindDay;
		int stageDayCount = FloroRanchGamePlayModel.Instance.StageDayCount;
		if (isEndlessMode)
		{
			this.EndlessDayProgressItem.RefreshDay(remindDay, (long)stageDayCount);
		}
		else
		{
			this.DayProgressItem.RefreshDay(remindDay, (long)stageDayCount);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Farm_DaySum", new <>z__ReadOnlySingleElementList<object>(FloroRanchGamePlayModel.Instance.TotalDayCount));
		this.SetCardNumText();
	}

	// Token: 0x0600A445 RID: 42053 RVA: 0x00303A60 File Offset: 0x00301C60
	private void OnBindEntityChanged(int point)
	{
		FloroRanchUiTerrainItem floroRanchUiTerrainItem = this.TerrainItemMap[point];
		bool flag = ((floroRanchUiTerrainItem != null) ? floroRanchUiTerrainItem.GetEntity() : null) != null;
		FloroRanchUiCardItem floroRanchUiCardItem = this.CardItemMap[point];
		FloroRanchEntityBase floroRanchEntityBase = (floroRanchUiCardItem != null) ? floroRanchUiCardItem.GetEntity() : null;
		bool flag2 = !flag && floroRanchEntityBase == null;
		FloroRanchUiTerrainItem floroRanchUiTerrainItem2 = this.TerrainItemMap[point];
		if (floroRanchUiTerrainItem2 == null)
		{
			return;
		}
		floroRanchUiTerrainItem2.SetInteractive(!flag2);
	}

	// Token: 0x0600A446 RID: 42054 RVA: 0x00303AC4 File Offset: 0x00301CC4
	public void SetNewDayButtonActive(bool bActive)
	{
		UUIButtonComponent button = base.GetButton(17);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(bActive);
	}

	// Token: 0x0600A447 RID: 42055 RVA: 0x00303AF4 File Offset: 0x00301CF4
	public void SetShowButtonActive(bool bActive)
	{
		UUIButtonComponent button = base.GetButton(6);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(bActive);
	}

	// Token: 0x0600A448 RID: 42056 RVA: 0x00303B20 File Offset: 0x00301D20
	public void SetMaskPanelActive(bool bActive)
	{
		UUIItem item = base.GetItem(50);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bActive);
	}

	// Token: 0x0600A449 RID: 42057 RVA: 0x00303B35 File Offset: 0x00301D35
	public void SetToyPanelActive(bool bActive)
	{
		UUIItem item = base.GetItem(21);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bActive);
	}

	// Token: 0x0600A44A RID: 42058 RVA: 0x00303B4C File Offset: 0x00301D4C
	public UniTask PlayNewDayAnim()
	{
		FloroRanchGamePlayView.<PlayNewDayAnim>d__50 <PlayNewDayAnim>d__;
		<PlayNewDayAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNewDayAnim>d__.<>4__this = this;
		<PlayNewDayAnim>d__.<>1__state = -1;
		<PlayNewDayAnim>d__.<>t__builder.Start<FloroRanchGamePlayView.<PlayNewDayAnim>d__50>(ref <PlayNewDayAnim>d__);
		return <PlayNewDayAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A44B RID: 42059 RVA: 0x00303B90 File Offset: 0x00301D90
	private void OnRemoveEntity(FloroRanchEntityBase entity)
	{
		EFloroRanchEntityType entityType = entity.EntityType;
		int point = entity.CheckGetComponent<FloroRanchEntityDataComponent>().Point;
		if (entityType == EFloroRanchEntityType.Card)
		{
			FloroRanchEntityBase terrainEntityByPoint = FloroRanchGamePlayModel.Instance.GetTerrainEntityByPoint(point);
			this.ChangeTerrainSelectTipByEntity(null, terrainEntityByPoint);
		}
		else if (entityType == EFloroRanchEntityType.Toy)
		{
			this.ChangeToySelectTipByEntity(null);
		}
		this.RefreshCurrencyInfo();
	}

	// Token: 0x0600A44C RID: 42060 RVA: 0x00303BDB File Offset: 0x00301DDB
	[NullableContext(2)]
	private void ChangeTerrainSelectTipByEntity(FloroRanchEntityBase mainEntity, FloroRanchEntityBase subEntity)
	{
		this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Terrain, mainEntity, subEntity);
		this.ShowTips();
	}

	// Token: 0x0600A44D RID: 42061 RVA: 0x00303BF4 File Offset: 0x00301DF4
	private void ChangeTerrainSelectTip(int point)
	{
		FloroRanchEntityBase terrainEntityByPoint = FloroRanchGamePlayModel.Instance.GetTerrainEntityByPoint(point);
		FloroRanchEntityBase cardEntityByPoint = FloroRanchGamePlayModel.Instance.GetCardEntityByPoint(point);
		this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Terrain, cardEntityByPoint, terrainEntityByPoint);
		this.ShowTips();
	}

	// Token: 0x0600A44E RID: 42062 RVA: 0x00303C2D File Offset: 0x00301E2D
	[NullableContext(2)]
	private void ChangeToySelectTipByEntity(FloroRanchEntityBase mainEntity)
	{
		this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Toy, mainEntity, null);
		this.ShowTips();
	}

	// Token: 0x0600A44F RID: 42063 RVA: 0x00303C44 File Offset: 0x00301E44
	private void ChangeToySelectTip(int point)
	{
		FloroRanchEntityBase toyEntityByPoint = FloroRanchGamePlayModel.Instance.GetToyEntityByPoint(point);
		this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Toy, toyEntityByPoint, null);
		this.ShowTips();
	}

	// Token: 0x0600A450 RID: 42064 RVA: 0x00303C74 File Offset: 0x00301E74
	private void ChangeCardItemSelectState(int point)
	{
		FloroRanchEntityBase cardEntityByPoint = FloroRanchGamePlayModel.Instance.GetCardEntityByPoint(point);
		if (cardEntityByPoint == null)
		{
			this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.None, null, null);
		}
		else
		{
			this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Terrain, cardEntityByPoint, null);
		}
		this.ChangeItemSelectState();
	}

	// Token: 0x0600A451 RID: 42065 RVA: 0x00303CB4 File Offset: 0x00301EB4
	private void ShowTips()
	{
		FloroRanchEntityBase lastMainEntityData = this.SelectTipData.LastMainEntityData;
		FloroRanchEntityBase lastSubEntityData = this.SelectTipData.LastSubEntityData;
		bool mainEntityData = this.SelectTipData.MainEntityData != null;
		FloroRanchEntityBase subEntityData = this.SelectTipData.SubEntityData;
		bool lastTipType = this.SelectTipData.LastTipType != EFloroRanchTipType.None;
		EFloroRanchTipType tipType = this.SelectTipData.TipType;
		bool playAnim = !lastTipType || tipType == EFloroRanchTipType.None;
		if (mainEntityData)
		{
			this.ShowMainTip(playAnim);
		}
		else if (lastMainEntityData != null)
		{
			this.HideMainTip(playAnim);
		}
		if (subEntityData != null)
		{
			this.ShowSubTip(playAnim);
		}
		else if (lastSubEntityData != null)
		{
			this.HideSubTip(playAnim);
		}
		this.ChangeItemSelectState();
	}

	// Token: 0x0600A452 RID: 42066 RVA: 0x00303D47 File Offset: 0x00301F47
	private void HideTips()
	{
		this.SelectTipData.Clear();
		this.ShowTips();
		this.HideMaskButton();
	}

	// Token: 0x0600A453 RID: 42067 RVA: 0x00303D60 File Offset: 0x00301F60
	private void StopSequenceIfPlaying(LevelSequencePlayer player, string sequenceName)
	{
		if (!player.IsPlayingSequence(sequenceName))
		{
			return;
		}
		player.StopSequenceByKey(sequenceName, false, false);
	}

	// Token: 0x0600A454 RID: 42068 RVA: 0x00303D78 File Offset: 0x00301F78
	private void HideSubTip(bool playAnim = true)
	{
		this.StopSequenceIfPlaying(this.SubTipLevelSequencePlayer, "Start");
		this.SubTipLevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		if (!playAnim)
		{
			this.SubTipLevelSequencePlayer.EndSequenceLastFrame("Close");
			FloroRanchTerrainTipItem subTipInfoItem = this.SubTipInfoItem;
			if (subTipInfoItem == null)
			{
				return;
			}
			subTipInfoItem.SetUiActive(false);
		}
	}

	// Token: 0x0600A455 RID: 42069 RVA: 0x00303DD8 File Offset: 0x00301FD8
	private void HideMainTip(bool playAnim = true)
	{
		this.StopSequenceIfPlaying(this.MainTipLevelSequencePlayer, "Start");
		this.MainTipLevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		if (!playAnim)
		{
			this.MainTipLevelSequencePlayer.EndSequenceLastFrame("Close");
			FloroRanchCommonTipItem mainTipInfoItem = this.MainTipInfoItem;
			if (mainTipInfoItem == null)
			{
				return;
			}
			mainTipInfoItem.SetUiActive(false);
		}
	}

	// Token: 0x0600A456 RID: 42070 RVA: 0x00303E38 File Offset: 0x00302038
	private void ShowSubTip(bool playAnim = true)
	{
		FloroRanchEntityBase subEntityData = this.SelectTipData.SubEntityData;
		this.SubTipInfoItem.RefreshInfoTipByEntity(subEntityData);
		this.SetSubTipHeight((float)((this.SelectTipData.MainEntityData != null) ? 240 : 380));
		this.StopSequenceIfPlaying(this.SubTipLevelSequencePlayer, "Close");
		this.SubTipLevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		if (!playAnim)
		{
			this.SubTipLevelSequencePlayer.EndSequenceLastFrame("Start");
		}
		this.ShowMaskButton();
	}

	// Token: 0x0600A457 RID: 42071 RVA: 0x00303EC8 File Offset: 0x003020C8
	private void ShowMainTip(bool playAnim = true)
	{
		FloroRanchEntityBase mainEntityData = this.SelectTipData.MainEntityData;
		FloroRanchCommonTipItem mainTipInfoItem = this.MainTipInfoItem;
		if (mainTipInfoItem != null)
		{
			mainTipInfoItem.RefreshInfoTipByParam(new FloroRanchCommonTipParam
			{
				TipType = EFloroRanchCommonTipType.Entity,
				EntityData = mainEntityData,
				RemoveCallback = new Action<FloroRanchEntityBase>(this.OnRemoveEntity),
				CurrencyData = null
			});
		}
		this.StopSequenceIfPlaying(this.MainTipLevelSequencePlayer, "Close");
		this.MainTipLevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		if (!playAnim)
		{
			this.MainTipLevelSequencePlayer.EndSequenceLastFrame("Start");
		}
		this.ShowMaskButton();
	}

	// Token: 0x0600A458 RID: 42072 RVA: 0x00303F64 File Offset: 0x00302164
	private void SetSubTipHeight(float height)
	{
		FloroRanchTerrainTipItem subTipInfoItem = this.SubTipInfoItem;
		UUIItem uuiitem = (subTipInfoItem != null) ? subTipInfoItem.GetRootItem() : null;
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetHeight(height);
	}

	// Token: 0x0600A459 RID: 42073 RVA: 0x00303F8F File Offset: 0x0030218F
	private void MainTipSequenceFinishEvent(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			FloroRanchCommonTipItem mainTipInfoItem = this.MainTipInfoItem;
			if (mainTipInfoItem == null)
			{
				return;
			}
			mainTipInfoItem.SetUiActive(false);
		}
	}

	// Token: 0x0600A45A RID: 42074 RVA: 0x00303FAF File Offset: 0x003021AF
	private void SubTipSequenceFinishEvent(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			FloroRanchTerrainTipItem subTipInfoItem = this.SubTipInfoItem;
			if (subTipInfoItem == null)
			{
				return;
			}
			subTipInfoItem.SetUiActive(false);
		}
	}

	// Token: 0x0600A45B RID: 42075 RVA: 0x00303FD0 File Offset: 0x003021D0
	private void ChangeItemSelectState()
	{
		this.SetItemSelectState(this.SelectTipData.LastTipType, this.SelectTipData.LastMainEntityData, this.SelectTipData.LastSubEntityData, false);
		this.SetItemSelectState(this.SelectTipData.TipType, this.SelectTipData.MainEntityData, this.SelectTipData.SubEntityData, true);
	}

	// Token: 0x0600A45C RID: 42076 RVA: 0x00304030 File Offset: 0x00302230
	[NullableContext(2)]
	private void SetItemSelectState(EFloroRanchTipType tipType, FloroRanchEntityBase mainEntityData, FloroRanchEntityBase subEntityData, bool isSelect)
	{
		if (tipType == EFloroRanchTipType.Terrain)
		{
			int key = -1;
			if (mainEntityData != null)
			{
				key = mainEntityData.GetPoint();
			}
			else if (subEntityData != null)
			{
				key = subEntityData.GetPoint();
			}
			FloroRanchUiTerrainItem floroRanchUiTerrainItem;
			if (this.TerrainItemMap.TryGetValue(key, out floroRanchUiTerrainItem))
			{
				floroRanchUiTerrainItem.SetSelectState(isSelect);
			}
		}
		if (tipType == EFloroRanchTipType.Toy)
		{
			int key2 = (mainEntityData != null) ? mainEntityData.GetPoint() : -1;
			FloroRanchUiToyItem floroRanchUiToyItem;
			if (this.ToyItemMap.TryGetValue(key2, out floroRanchUiToyItem))
			{
				floroRanchUiToyItem.SetSelectState(isSelect);
			}
		}
	}

	// Token: 0x0600A45D RID: 42077 RVA: 0x0030409C File Offset: 0x0030229C
	private void ShowMaskButton()
	{
		base.GetButton(49).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0600A45E RID: 42078 RVA: 0x003040C4 File Offset: 0x003022C4
	private void HideMaskButton()
	{
		base.GetButton(49).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600A45F RID: 42079 RVA: 0x003040EC File Offset: 0x003022EC
	public UniTask ShowPopupReward(FloroRanchUiItemBase item, EFloroRanchPopupRewardType rewardType, long count)
	{
		FloroRanchGamePlayView.<ShowPopupReward>d__71 <ShowPopupReward>d__;
		<ShowPopupReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowPopupReward>d__.<>4__this = this;
		<ShowPopupReward>d__.item = item;
		<ShowPopupReward>d__.rewardType = rewardType;
		<ShowPopupReward>d__.count = count;
		<ShowPopupReward>d__.<>1__state = -1;
		<ShowPopupReward>d__.<>t__builder.Start<FloroRanchGamePlayView.<ShowPopupReward>d__71>(ref <ShowPopupReward>d__);
		return <ShowPopupReward>d__.<>t__builder.Task;
	}

	// Token: 0x0600A460 RID: 42080 RVA: 0x00304147 File Offset: 0x00302347
	protected override void OnBeforeDestroy()
	{
		FloroRanchGamePlayModel.Instance.SetTimeDilation(1);
		if (!FloroRanchGamePlayModel.Instance.IsExit)
		{
			FloroRanchGamePlayModel.Instance.ExitGame(false);
		}
	}

	// Token: 0x0600A461 RID: 42081 RVA: 0x0030416C File Offset: 0x0030236C
	private void OnCoinChangeCallBack(long _)
	{
		this.RefreshCurrencyInfo();
		LevelSequencePlayer progressLevelSequencePlayer = this.ProgressLevelSequencePlayer;
		if (((progressLevelSequencePlayer != null) ? progressLevelSequencePlayer.GetCurrentSequence() : null) == "Hit")
		{
			LevelSequencePlayer progressLevelSequencePlayer2 = this.ProgressLevelSequencePlayer;
			if (progressLevelSequencePlayer2 == null)
			{
				return;
			}
			progressLevelSequencePlayer2.ReplaySequenceByKey("Hit");
			return;
		}
		else
		{
			LevelSequencePlayer progressLevelSequencePlayer3 = this.ProgressLevelSequencePlayer;
			if (progressLevelSequencePlayer3 == null)
			{
				return;
			}
			progressLevelSequencePlayer3.PlayLevelSequenceByName("Hit", false, null, false);
			return;
		}
	}

	// Token: 0x0600A462 RID: 42082 RVA: 0x003041D3 File Offset: 0x003023D3
	private void OnDiamondChangeCallBack(long _)
	{
		this.RefreshCurrencyInfo();
	}

	// Token: 0x0600A463 RID: 42083 RVA: 0x003041DC File Offset: 0x003023DC
	public void PlayFloroAudio(EFloroRanchAudioType type)
	{
		if (this.EventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.EventHandle, EAudioActionType.Stop, null);
		}
		if (this.ChatPanelHideTimer != null && TimerSystem.GameplayTimeInstance.Has(this.ChatPanelHideTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.ChatPanelHideTimer);
			this.ChatPanelHideTimer = null;
		}
		FloroRanchAudioData floroRanchRandomAudioDataByType = FloroRanchModel.Instance.GetFloroRanchRandomAudioDataByType(type, this.ActivityData.GetVoiceCharacterType());
		string audioText = floroRanchRandomAudioDataByType.GetAudioText();
		string audioEvent = floroRanchRandomAudioDataByType.GetAudioEvent();
		if (audioText == "")
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(48), audioText, Array.Empty<object>());
		base.GetItem(47).SetUIActive(true);
		if (audioEvent != "")
		{
			FTransformDouble? target = null;
			this.EventHandle = AudioSystem.Instance.PostEvent(audioEvent, target, new PostEventArgs?(new PostEventArgs
			{
				CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (callbackType == EAkCallbackType.EndOfEvent)
					{
						UUIItem item = base.GetItem(47);
						if (item == null)
						{
							return;
						}
						item.SetUIActive(false);
					}
				}
			}));
		}
		else
		{
			this.ChatPanelHideTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UUIItem item = base.GetItem(47);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				this.ChatPanelHideTimer = null;
			}, 3000f, null, null, true, 1f);
		}
		if (type == EFloroRanchAudioType.Skill)
		{
			FloroRanchEntityBase roleEntity = FloroRanchGamePlayModel.Instance.RoleEntity;
			if (roleEntity != null)
			{
				roleEntity.GetUiItemComponent().PlaySkillAnim();
			}
		}
	}

	// Token: 0x0600A464 RID: 42084 RVA: 0x00304338 File Offset: 0x00302538
	private void SetCardNumText()
	{
		int ownCardEntityCount = FloroRanchGamePlayModel.Instance.OwnCardEntityCount;
		string value = "#ffffff";
		if (ownCardEntityCount >= this.ActivityData.CardLimitCount)
		{
			value = "#ff5d5d";
		}
		else if (ownCardEntityCount >= 20)
		{
			value = "#fec455";
		}
		UUIText text = base.GetText(53);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
		defaultInterpolatedStringHandler.AppendLiteral("<color=");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral(">");
		defaultInterpolatedStringHandler.AppendFormatted<int>(ownCardEntityCount);
		defaultInterpolatedStringHandler.AppendLiteral("</color>/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(20);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0600A465 RID: 42085 RVA: 0x003043D3 File Offset: 0x003025D3
	private void OnClickToyItem(int point)
	{
		this.ChangeToySelectTip(point);
	}

	// Token: 0x0600A466 RID: 42086 RVA: 0x003043DC File Offset: 0x003025DC
	private void OnClickTerrainItem(int point)
	{
		this.ChangeTerrainSelectTip(point);
	}

	// Token: 0x0600A467 RID: 42087 RVA: 0x003043E5 File Offset: 0x003025E5
	private void OnClickUseSkillButton()
	{
		this.OnClickSkillButton(null);
	}

	// Token: 0x0600A468 RID: 42088 RVA: 0x003043EE File Offset: 0x003025EE
	private void OnClickSkillButton(FloroRanchEntityBase entity)
	{
		if (!FloroRanchGamePlayModel.Instance.CanFsmInsertSkillTask())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("FloroRanchSkillCantUse", Array.Empty<object>());
			return;
		}
		this.HideTips();
		UiManager.Instance.OpenView(EUiViewName.FloroRanchSkillTipView, entity, null);
	}

	// Token: 0x0600A469 RID: 42089 RVA: 0x00304428 File Offset: 0x00302628
	private void OnClickNewDayButton()
	{
		if (!FloroRanchGamePlayModel.Instance.CanFsmInsertSkillTask())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_NextDayLock", Array.Empty<object>());
			return;
		}
		this.HideTips();
		this.SetMaskPanelActive(true);
		this.SetNewDayButtonActive(false);
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		FloroRanchController.Instance.SendFloroRanchPlayNextDayRequest(this.ActivityData.Id, subInstanceId, delegate(FloroRanchPlayNextDayResponse response)
		{
			if (response != null)
			{
				this.RefreshCurrencyInfo();
				this.RefreshStageInfo();
			}
		});
	}

	// Token: 0x0600A46A RID: 42090 RVA: 0x00304497 File Offset: 0x00302697
	private void OnClickLastDayDetailButton()
	{
		this.HideTips();
		UiManager.Instance.OpenView(EUiViewName.FloroRanchIncomeDetailView, new Action<int>(this.ChangeCardItemSelectState), null);
	}

	// Token: 0x0600A46B RID: 42091 RVA: 0x003044BB File Offset: 0x003026BB
	private void OnClickLevelDetailButton()
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchGamePlayExplainView, null, null);
	}

	// Token: 0x0600A46C RID: 42092 RVA: 0x003044CE File Offset: 0x003026CE
	private void OnClickShowButton()
	{
		this.HideTips();
		FloroRanchGamePlayModel.Instance.ShowRecordView();
	}

	// Token: 0x0600A46D RID: 42093 RVA: 0x003044E0 File Offset: 0x003026E0
	private void OnClickDebugButton()
	{
		if (this.DebugInfoPanel.IsShowOrShowing)
		{
			this.DebugInfoPanel.Hide(null);
			return;
		}
		this.DebugInfoPanel.Show(null);
	}

	// Token: 0x0600A46E RID: 42094 RVA: 0x00304508 File Offset: 0x00302708
	private void OnClickCardCountButton()
	{
		ScrollingTipsController.Instance.ShowTipsByTextId("Farm_AnimalAllFull", Array.Empty<object>());
	}

	// Token: 0x0600A46F RID: 42095 RVA: 0x0030451E File Offset: 0x0030271E
	private void OnClickBackButton()
	{
		this.HideTips();
		FloroRanchGamePlayModel.Instance.PauseGame();
		FloroRanchGamePlayModel.Instance.OpenAndRecordView(EUiViewName.FloroRanchPauseView, null, null);
	}

	// Token: 0x0600A470 RID: 42096 RVA: 0x00304544 File Offset: 0x00302744
	private void OnClickSpeedChangeButton()
	{
		this.HideTips();
		this.CurSpeedIndex = (this.CurSpeedIndex + 1) % this.SpeedList.Count;
		int num = this.SpeedList[this.CurSpeedIndex];
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.FloroRanchSpeed, num);
		FloroRanchGamePlayModel.Instance.SetTimeDilation(num);
		if (num >= 50)
		{
			base.GetText(2).SetText("MAX", true);
		}
		else
		{
			base.GetText(2).SetText("×" + num.ToString("F1"), true);
		}
		base.GetSprite(4).SetUIActive(this.CurSpeedIndex != 0);
	}

	// Token: 0x0600A471 RID: 42097 RVA: 0x003045F0 File Offset: 0x003027F0
	private void OnClickHelpButton()
	{
		this.HideTips();
		global::FloroRanchActivityData activityData = this.ActivityData;
		if (activityData != null && activityData.ActivityDataType == EFloroRanchActivityDataType.Weekly)
		{
			HelpController.Instance.OpenHelpById(629);
			return;
		}
		HelpController.Instance.OpenHelpById(354);
	}

	// Token: 0x0600A472 RID: 42098 RVA: 0x0030462E File Offset: 0x0030282E
	private void OnFloroRanchBasicInfoRefresh()
	{
		this.RefreshCurrencyInfo();
		this.RefreshStageInfo();
	}

	// Token: 0x0600A473 RID: 42099 RVA: 0x0030463C File Offset: 0x0030283C
	private void OnFloroRanchCardEntityCountChange()
	{
		this.SetCardNumText();
	}

	// Token: 0x0600A474 RID: 42100 RVA: 0x00304644 File Offset: 0x00302844
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		string a = configParams[0];
		if (a == "FirstTerrainWithCard")
		{
			int i = 0;
			while (i < 20)
			{
				if (FloroRanchGamePlayModel.Instance.GetCardEntityByPoint(i) != null)
				{
					FloroRanchUiTerrainItem valueOrDefault = this.TerrainItemMap.GetValueOrDefault(i);
					UUIItem uuiitem = (valueOrDefault != null) ? valueOrDefault.GetRootItem() : null;
					if (uuiitem == null)
					{
						return null;
					}
					return new UUIItem[]
					{
						uuiitem,
						uuiitem
					};
				}
				else
				{
					i++;
				}
			}
		}
		if (a == "Tips")
		{
			FloroRanchCommonTipItem mainTipInfoItem = this.MainTipInfoItem;
			UUIItem uuiitem2 = (mainTipInfoItem != null) ? mainTipInfoItem.GetRootItem() : null;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}
		else if (a == "RemoveBtn")
		{
			FloroRanchCommonTipItem mainTipInfoItem2 = this.MainTipInfoItem;
			UUIItem uuiitem3 = (mainTipInfoItem2 != null) ? mainTipInfoItem2.GetGuideUiItem("0") : null;
			if (uuiitem3 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem3,
				uuiitem3
			};
		}
		else
		{
			if (a == "FirstTerrainWithRedCard")
			{
				for (int j = 0; j < 20; j++)
				{
					FloroRanchEntityBase cardEntityByPoint = FloroRanchGamePlayModel.Instance.GetCardEntityByPoint(j);
					if (cardEntityByPoint != null)
					{
						FloroRanchCardDataComponent floroRanchCardDataComponent = cardEntityByPoint.CheckGetComponent<FloroRanchCardDataComponent>();
						if (floroRanchCardDataComponent != null)
						{
							FloroRanchCardData cardData = floroRanchCardDataComponent.CardData;
							if (cardData != null && cardData.GetCardSpecialEffect() == EFloroRanchSpecialEffectType.Red)
							{
								FloroRanchUiTerrainItem valueOrDefault2 = this.TerrainItemMap.GetValueOrDefault(j);
								UUIItem uuiitem4 = (valueOrDefault2 != null) ? valueOrDefault2.GetRootItem() : null;
								if (uuiitem4 == null)
								{
									return null;
								}
								return new UUIItem[]
								{
									uuiitem4,
									uuiitem4
								};
							}
						}
					}
				}
			}
			if (!(a == "ToyItem"))
			{
				return null;
			}
			int key = int.Parse(configParams[1]);
			FloroRanchUiToyItem floroRanchUiToyItem;
			this.ToyItemMap.TryGetValue(key, out floroRanchUiToyItem);
			if (floroRanchUiToyItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				floroRanchUiToyItem.GetRootItem(),
				floroRanchUiToyItem.GetRootItem()
			};
		}
	}

	// Token: 0x0400606A RID: 24682
	private const int TERRAIN_ITEM_START_INDEX = 24;

	// Token: 0x0400606B RID: 24683
	private int CurSpeedIndex;

	// Token: 0x0400606C RID: 24684
	private List<int> SpeedList = new List<int>();

	// Token: 0x0400606D RID: 24685
	private UCurveFloat CardMoveCurve;

	// Token: 0x0400606E RID: 24686
	[Nullable(2)]
	private global::FloroRanchActivityData ActivityData;

	// Token: 0x0400606F RID: 24687
	private FloroRanchTipData SelectTipData;

	// Token: 0x04006070 RID: 24688
	[Nullable(2)]
	private FloroRanchCurrencyItem ItemCost;

	// Token: 0x04006071 RID: 24689
	[Nullable(2)]
	private FloroRanchDayProgressItem DayProgressItem;

	// Token: 0x04006072 RID: 24690
	[Nullable(2)]
	private FloroRanchDayProgressItem EndlessDayProgressItem;

	// Token: 0x04006073 RID: 24691
	[Nullable(2)]
	private FloroRanchCommonTipItem MainTipInfoItem;

	// Token: 0x04006074 RID: 24692
	[Nullable(2)]
	private FloroRanchTerrainTipItem SubTipInfoItem;

	// Token: 0x04006075 RID: 24693
	[Nullable(2)]
	private LevelSequencePlayer MainTipLevelSequencePlayer;

	// Token: 0x04006076 RID: 24694
	[Nullable(2)]
	private LevelSequencePlayer SubTipLevelSequencePlayer;

	// Token: 0x04006077 RID: 24695
	[Nullable(2)]
	private LevelSequencePlayer ProgressLevelSequencePlayer;

	// Token: 0x04006078 RID: 24696
	private int EventHandle;

	// Token: 0x04006079 RID: 24697
	[Nullable(2)]
	private TimerHandle ChatPanelHideTimer;

	// Token: 0x0400607A RID: 24698
	private readonly Dictionary<int, FloroRanchUiTerrainItem> TerrainItemMap = new Dictionary<int, FloroRanchUiTerrainItem>();

	// Token: 0x0400607B RID: 24699
	private readonly Dictionary<int, FloroRanchUiCardItem> CardItemMap = new Dictionary<int, FloroRanchUiCardItem>();

	// Token: 0x0400607C RID: 24700
	private readonly Dictionary<int, FloroRanchUiToyItem> ToyItemMap = new Dictionary<int, FloroRanchUiToyItem>();

	// Token: 0x0400607D RID: 24701
	[Nullable(2)]
	private FloroRanchPopupRewardPanel PopupRewardPanel;

	// Token: 0x0400607E RID: 24702
	[Nullable(2)]
	private FloroRanchUiRoleSkillItem RoleSkillItem;

	// Token: 0x0400607F RID: 24703
	[Nullable(2)]
	private FloroRanchDebugInfoPanel DebugInfoPanel;

	// Token: 0x0200724D RID: 29261
	[NullableContext(0)]
	public class EComponentDefine
	{
		// Token: 0x04025311 RID: 152337
		public const int CloseButton = 0;

		// Token: 0x04025312 RID: 152338
		public const int ItemCost = 1;

		// Token: 0x04025313 RID: 152339
		public const int SpeedText = 2;

		// Token: 0x04025314 RID: 152340
		public const int SpeedChangeButton = 3;

		// Token: 0x04025315 RID: 152341
		public const int SpeedSprite = 4;

		// Token: 0x04025316 RID: 152342
		public const int HelpButton = 5;

		// Token: 0x04025317 RID: 152343
		public const int ShowButton = 6;

		// Token: 0x04025318 RID: 152344
		public const int RightInfoRoot = 7;

		// Token: 0x04025319 RID: 152345
		public const int BasicInfoPanel = 8;

		// Token: 0x0402531A RID: 152346
		public const int LevelNameText = 9;

		// Token: 0x0402531B RID: 152347
		public const int StageText = 10;

		// Token: 0x0402531C RID: 152348
		public const int DayText = 11;

		// Token: 0x0402531D RID: 152349
		public const int TargetText = 12;

		// Token: 0x0402531E RID: 152350
		public const int TargetIconTexture = 13;

		// Token: 0x0402531F RID: 152351
		public const int TargetProgressTexture = 14;

		// Token: 0x04025320 RID: 152352
		public const int TargetProgressItem = 15;

		// Token: 0x04025321 RID: 152353
		public const int DayProgressItem = 16;

		// Token: 0x04025322 RID: 152354
		public const int NewDayButton = 17;

		// Token: 0x04025323 RID: 152355
		public const int FloroSpine = 18;

		// Token: 0x04025324 RID: 152356
		public const int FloroPanel = 19;

		// Token: 0x04025325 RID: 152357
		public const int UseSkillButton = 20;

		// Token: 0x04025326 RID: 152358
		public const int ToyItemRoot = 21;

		// Token: 0x04025327 RID: 152359
		public const int ToyItemTemplate = 22;

		// Token: 0x04025328 RID: 152360
		public const int TerrainItemRoot = 23;

		// Token: 0x04025329 RID: 152361
		public const int TerrainItem1 = 24;

		// Token: 0x0402532A RID: 152362
		public const int TerrainItem2 = 25;

		// Token: 0x0402532B RID: 152363
		public const int TerrainItem3 = 26;

		// Token: 0x0402532C RID: 152364
		public const int TerrainItem4 = 27;

		// Token: 0x0402532D RID: 152365
		public const int TerrainItem5 = 28;

		// Token: 0x0402532E RID: 152366
		public const int TerrainItem6 = 29;

		// Token: 0x0402532F RID: 152367
		public const int TerrainItem7 = 30;

		// Token: 0x04025330 RID: 152368
		public const int TerrainItem8 = 31;

		// Token: 0x04025331 RID: 152369
		public const int TerrainItem9 = 32;

		// Token: 0x04025332 RID: 152370
		public const int TerrainItem10 = 33;

		// Token: 0x04025333 RID: 152371
		public const int TerrainItem11 = 34;

		// Token: 0x04025334 RID: 152372
		public const int TerrainItem12 = 35;

		// Token: 0x04025335 RID: 152373
		public const int TerrainItem13 = 36;

		// Token: 0x04025336 RID: 152374
		public const int TerrainItem14 = 37;

		// Token: 0x04025337 RID: 152375
		public const int TerrainItem15 = 38;

		// Token: 0x04025338 RID: 152376
		public const int TerrainItem16 = 39;

		// Token: 0x04025339 RID: 152377
		public const int TerrainItem17 = 40;

		// Token: 0x0402533A RID: 152378
		public const int TerrainItem18 = 41;

		// Token: 0x0402533B RID: 152379
		public const int TerrainItem19 = 42;

		// Token: 0x0402533C RID: 152380
		public const int TerrainItem20 = 43;

		// Token: 0x0402533D RID: 152381
		public const int SpineRootItem = 44;

		// Token: 0x0402533E RID: 152382
		public const int SpineItemTemplate = 45;

		// Token: 0x0402533F RID: 152383
		public const int PopupRewardPanel = 46;

		// Token: 0x04025340 RID: 152384
		public const int ChatPanel = 47;

		// Token: 0x04025341 RID: 152385
		public const int ChatText = 48;

		// Token: 0x04025342 RID: 152386
		public const int ClickMaskButton = 49;

		// Token: 0x04025343 RID: 152387
		public const int MaskPanel = 50;

		// Token: 0x04025344 RID: 152388
		public const int LastDayIncomeTexture = 51;

		// Token: 0x04025345 RID: 152389
		public const int LastDayIncomeText = 52;

		// Token: 0x04025346 RID: 152390
		public const int CardNumText = 53;

		// Token: 0x04025347 RID: 152391
		public const int LastDayDetailButton = 54;

		// Token: 0x04025348 RID: 152392
		public const int LevelDetailButton = 55;

		// Token: 0x04025349 RID: 152393
		public const int DebugButton = 56;

		// Token: 0x0402534A RID: 152394
		public const int RightDebugRoot = 57;

		// Token: 0x0402534B RID: 152395
		public const int RightMaskTexture = 58;

		// Token: 0x0402534C RID: 152396
		public const int CardCountButton = 59;

		// Token: 0x0402534D RID: 152397
		public const int LeafItem = 60;
	}
}
