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

// Token: 0x02001B64 RID: 7012
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchGamePlayView : UiViewBase
{
	// Token: 0x0600D01E RID: 53278 RVA: 0x002F765F File Offset: 0x002F585F
	public FloroRanchGamePlayView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D01F RID: 53279 RVA: 0x002F7694 File Offset: 0x002F5894
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

	// Token: 0x0600D020 RID: 53280 RVA: 0x002F8070 File Offset: 0x002F6270
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchGamePlayView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchGamePlayView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D021 RID: 53281 RVA: 0x002F80B4 File Offset: 0x002F62B4
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

	// Token: 0x0600D022 RID: 53282 RVA: 0x002F81C0 File Offset: 0x002F63C0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnFloroRanchStageInfoRefresh, new Action(this.OnFloroRanchBasicInfoRefresh));
		EventSystem.Instance.Add(EEventName.OnFloroRanchCardEntityCountChange, new Action(this.OnFloroRanchCardEntityCountChange));
	}

	// Token: 0x0600D023 RID: 53283 RVA: 0x002F81FA File Offset: 0x002F63FA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFloroRanchStageInfoRefresh, new Action(this.OnFloroRanchBasicInfoRefresh));
		EventSystem.Instance.Remove(EEventName.OnFloroRanchCardEntityCountChange, new Action(this.OnFloroRanchCardEntityCountChange));
	}

	// Token: 0x0600D024 RID: 53284 RVA: 0x002F8234 File Offset: 0x002F6434
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

	// Token: 0x0600D025 RID: 53285 RVA: 0x002F8280 File Offset: 0x002F6480
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

	// Token: 0x0600D026 RID: 53286 RVA: 0x002F82CC File Offset: 0x002F64CC
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

	// Token: 0x0600D027 RID: 53287 RVA: 0x002F8318 File Offset: 0x002F6518
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

	// Token: 0x0600D028 RID: 53288 RVA: 0x002F8364 File Offset: 0x002F6564
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

	// Token: 0x0600D029 RID: 53289 RVA: 0x002F83B0 File Offset: 0x002F65B0
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

	// Token: 0x0600D02A RID: 53290 RVA: 0x002F83FC File Offset: 0x002F65FC
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

	// Token: 0x0600D02B RID: 53291 RVA: 0x002F8448 File Offset: 0x002F6648
	private UniTask CreateRoleSkillItem()
	{
		FloroRanchGamePlayView.<CreateRoleSkillItem>d__36 <CreateRoleSkillItem>d__;
		<CreateRoleSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRoleSkillItem>d__.<>4__this = this;
		<CreateRoleSkillItem>d__.<>1__state = -1;
		<CreateRoleSkillItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<CreateRoleSkillItem>d__36>(ref <CreateRoleSkillItem>d__);
		return <CreateRoleSkillItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D02C RID: 53292 RVA: 0x002F848C File Offset: 0x002F668C
	private UniTask InitRightInfoTipItem()
	{
		FloroRanchGamePlayView.<InitRightInfoTipItem>d__37 <InitRightInfoTipItem>d__;
		<InitRightInfoTipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRightInfoTipItem>d__.<>4__this = this;
		<InitRightInfoTipItem>d__.<>1__state = -1;
		<InitRightInfoTipItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<InitRightInfoTipItem>d__37>(ref <InitRightInfoTipItem>d__);
		return <InitRightInfoTipItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D02D RID: 53293 RVA: 0x002F84D0 File Offset: 0x002F66D0
	private UniTask InitPopupRewardPanel()
	{
		FloroRanchGamePlayView.<InitPopupRewardPanel>d__38 <InitPopupRewardPanel>d__;
		<InitPopupRewardPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPopupRewardPanel>d__.<>4__this = this;
		<InitPopupRewardPanel>d__.<>1__state = -1;
		<InitPopupRewardPanel>d__.<>t__builder.Start<FloroRanchGamePlayView.<InitPopupRewardPanel>d__38>(ref <InitPopupRewardPanel>d__);
		return <InitPopupRewardPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600D02E RID: 53294 RVA: 0x002F8514 File Offset: 0x002F6714
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

	// Token: 0x0600D02F RID: 53295 RVA: 0x002F8668 File Offset: 0x002F6868
	private UniTask InitDayProgressItem()
	{
		FloroRanchGamePlayView.<InitDayProgressItem>d__40 <InitDayProgressItem>d__;
		<InitDayProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDayProgressItem>d__.<>4__this = this;
		<InitDayProgressItem>d__.<>1__state = -1;
		<InitDayProgressItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<InitDayProgressItem>d__40>(ref <InitDayProgressItem>d__);
		return <InitDayProgressItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D030 RID: 53296 RVA: 0x002F86AC File Offset: 0x002F68AC
	private UniTask InitEndlessDayProgressItem()
	{
		FloroRanchGamePlayView.<InitEndlessDayProgressItem>d__41 <InitEndlessDayProgressItem>d__;
		<InitEndlessDayProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitEndlessDayProgressItem>d__.<>4__this = this;
		<InitEndlessDayProgressItem>d__.<>1__state = -1;
		<InitEndlessDayProgressItem>d__.<>t__builder.Start<FloroRanchGamePlayView.<InitEndlessDayProgressItem>d__41>(ref <InitEndlessDayProgressItem>d__);
		return <InitEndlessDayProgressItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D031 RID: 53297 RVA: 0x002F86F0 File Offset: 0x002F68F0
	private UniTask InitCurve()
	{
		FloroRanchGamePlayView.<InitCurve>d__42 <InitCurve>d__;
		<InitCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCurve>d__.<>4__this = this;
		<InitCurve>d__.<>1__state = -1;
		<InitCurve>d__.<>t__builder.Start<FloroRanchGamePlayView.<InitCurve>d__42>(ref <InitCurve>d__);
		return <InitCurve>d__.<>t__builder.Task;
	}

	// Token: 0x0600D032 RID: 53298 RVA: 0x002F8734 File Offset: 0x002F6934
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

	// Token: 0x0600D033 RID: 53299 RVA: 0x002F882C File Offset: 0x002F6A2C
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

	// Token: 0x0600D034 RID: 53300 RVA: 0x002F8988 File Offset: 0x002F6B88
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

	// Token: 0x0600D035 RID: 53301 RVA: 0x002F89EC File Offset: 0x002F6BEC
	public void SetNewDayButtonActive(bool bActive)
	{
		UUIButtonComponent button = base.GetButton(17);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(bActive);
	}

	// Token: 0x0600D036 RID: 53302 RVA: 0x002F8A1C File Offset: 0x002F6C1C
	public void SetShowButtonActive(bool bActive)
	{
		UUIButtonComponent button = base.GetButton(6);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(bActive);
	}

	// Token: 0x0600D037 RID: 53303 RVA: 0x002F8A48 File Offset: 0x002F6C48
	public void SetMaskPanelActive(bool bActive)
	{
		UUIItem item = base.GetItem(50);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bActive);
	}

	// Token: 0x0600D038 RID: 53304 RVA: 0x002F8A5D File Offset: 0x002F6C5D
	public void SetToyPanelActive(bool bActive)
	{
		UUIItem item = base.GetItem(21);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bActive);
	}

	// Token: 0x0600D039 RID: 53305 RVA: 0x002F8A74 File Offset: 0x002F6C74
	public UniTask PlayNewDayAnim()
	{
		FloroRanchGamePlayView.<PlayNewDayAnim>d__50 <PlayNewDayAnim>d__;
		<PlayNewDayAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNewDayAnim>d__.<>4__this = this;
		<PlayNewDayAnim>d__.<>1__state = -1;
		<PlayNewDayAnim>d__.<>t__builder.Start<FloroRanchGamePlayView.<PlayNewDayAnim>d__50>(ref <PlayNewDayAnim>d__);
		return <PlayNewDayAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D03A RID: 53306 RVA: 0x002F8AB8 File Offset: 0x002F6CB8
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

	// Token: 0x0600D03B RID: 53307 RVA: 0x002F8B03 File Offset: 0x002F6D03
	[NullableContext(2)]
	private void ChangeTerrainSelectTipByEntity(FloroRanchEntityBase mainEntity, FloroRanchEntityBase subEntity)
	{
		this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Terrain, mainEntity, subEntity);
		this.ShowTips();
	}

	// Token: 0x0600D03C RID: 53308 RVA: 0x002F8B1C File Offset: 0x002F6D1C
	private void ChangeTerrainSelectTip(int point)
	{
		FloroRanchEntityBase terrainEntityByPoint = FloroRanchGamePlayModel.Instance.GetTerrainEntityByPoint(point);
		FloroRanchEntityBase cardEntityByPoint = FloroRanchGamePlayModel.Instance.GetCardEntityByPoint(point);
		this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Terrain, cardEntityByPoint, terrainEntityByPoint);
		this.ShowTips();
	}

	// Token: 0x0600D03D RID: 53309 RVA: 0x002F8B55 File Offset: 0x002F6D55
	[NullableContext(2)]
	private void ChangeToySelectTipByEntity(FloroRanchEntityBase mainEntity)
	{
		this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Toy, mainEntity, null);
		this.ShowTips();
	}

	// Token: 0x0600D03E RID: 53310 RVA: 0x002F8B6C File Offset: 0x002F6D6C
	private void ChangeToySelectTip(int point)
	{
		FloroRanchEntityBase toyEntityByPoint = FloroRanchGamePlayModel.Instance.GetToyEntityByPoint(point);
		this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Toy, toyEntityByPoint, null);
		this.ShowTips();
	}

	// Token: 0x0600D03F RID: 53311 RVA: 0x002F8B9C File Offset: 0x002F6D9C
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

	// Token: 0x0600D040 RID: 53312 RVA: 0x002F8BDC File Offset: 0x002F6DDC
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

	// Token: 0x0600D041 RID: 53313 RVA: 0x002F8C6F File Offset: 0x002F6E6F
	private void HideTips()
	{
		this.SelectTipData.Clear();
		this.ShowTips();
		this.HideMaskButton();
	}

	// Token: 0x0600D042 RID: 53314 RVA: 0x002F8C88 File Offset: 0x002F6E88
	private void StopSequenceIfPlaying(LevelSequencePlayer player, string sequenceName)
	{
		if (!player.IsPlayingSequence(sequenceName))
		{
			return;
		}
		player.StopSequenceByKey(sequenceName, false, false);
	}

	// Token: 0x0600D043 RID: 53315 RVA: 0x002F8CA0 File Offset: 0x002F6EA0
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

	// Token: 0x0600D044 RID: 53316 RVA: 0x002F8D00 File Offset: 0x002F6F00
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

	// Token: 0x0600D045 RID: 53317 RVA: 0x002F8D60 File Offset: 0x002F6F60
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

	// Token: 0x0600D046 RID: 53318 RVA: 0x002F8DF0 File Offset: 0x002F6FF0
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

	// Token: 0x0600D047 RID: 53319 RVA: 0x002F8E8C File Offset: 0x002F708C
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

	// Token: 0x0600D048 RID: 53320 RVA: 0x002F8EB7 File Offset: 0x002F70B7
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

	// Token: 0x0600D049 RID: 53321 RVA: 0x002F8ED7 File Offset: 0x002F70D7
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

	// Token: 0x0600D04A RID: 53322 RVA: 0x002F8EF8 File Offset: 0x002F70F8
	private void ChangeItemSelectState()
	{
		this.SetItemSelectState(this.SelectTipData.LastTipType, this.SelectTipData.LastMainEntityData, this.SelectTipData.LastSubEntityData, false);
		this.SetItemSelectState(this.SelectTipData.TipType, this.SelectTipData.MainEntityData, this.SelectTipData.SubEntityData, true);
	}

	// Token: 0x0600D04B RID: 53323 RVA: 0x002F8F58 File Offset: 0x002F7158
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

	// Token: 0x0600D04C RID: 53324 RVA: 0x002F8FC4 File Offset: 0x002F71C4
	private void ShowMaskButton()
	{
		base.GetButton(49).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0600D04D RID: 53325 RVA: 0x002F8FEC File Offset: 0x002F71EC
	private void HideMaskButton()
	{
		base.GetButton(49).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600D04E RID: 53326 RVA: 0x002F9014 File Offset: 0x002F7214
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

	// Token: 0x0600D04F RID: 53327 RVA: 0x002F906F File Offset: 0x002F726F
	protected override void OnBeforeDestroy()
	{
		FloroRanchGamePlayModel.Instance.SetTimeDilation(1);
		if (!FloroRanchGamePlayModel.Instance.IsExit)
		{
			FloroRanchGamePlayModel.Instance.ExitGame(false);
		}
	}

	// Token: 0x0600D050 RID: 53328 RVA: 0x002F9094 File Offset: 0x002F7294
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

	// Token: 0x0600D051 RID: 53329 RVA: 0x002F90FB File Offset: 0x002F72FB
	private void OnDiamondChangeCallBack(long _)
	{
		this.RefreshCurrencyInfo();
	}

	// Token: 0x0600D052 RID: 53330 RVA: 0x002F9104 File Offset: 0x002F7304
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

	// Token: 0x0600D053 RID: 53331 RVA: 0x002F9260 File Offset: 0x002F7460
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

	// Token: 0x0600D054 RID: 53332 RVA: 0x002F92FB File Offset: 0x002F74FB
	private void OnClickToyItem(int point)
	{
		this.ChangeToySelectTip(point);
	}

	// Token: 0x0600D055 RID: 53333 RVA: 0x002F9304 File Offset: 0x002F7504
	private void OnClickTerrainItem(int point)
	{
		this.ChangeTerrainSelectTip(point);
	}

	// Token: 0x0600D056 RID: 53334 RVA: 0x002F930D File Offset: 0x002F750D
	private void OnClickUseSkillButton()
	{
		this.OnClickSkillButton(null);
	}

	// Token: 0x0600D057 RID: 53335 RVA: 0x002F9316 File Offset: 0x002F7516
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

	// Token: 0x0600D058 RID: 53336 RVA: 0x002F9350 File Offset: 0x002F7550
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

	// Token: 0x0600D059 RID: 53337 RVA: 0x002F93BF File Offset: 0x002F75BF
	private void OnClickLastDayDetailButton()
	{
		this.HideTips();
		UiManager.Instance.OpenView(EUiViewName.FloroRanchIncomeDetailView, new Action<int>(this.ChangeCardItemSelectState), null);
	}

	// Token: 0x0600D05A RID: 53338 RVA: 0x002F93E3 File Offset: 0x002F75E3
	private void OnClickLevelDetailButton()
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchGamePlayExplainView, null, null);
	}

	// Token: 0x0600D05B RID: 53339 RVA: 0x002F93F6 File Offset: 0x002F75F6
	private void OnClickShowButton()
	{
		this.HideTips();
		FloroRanchGamePlayModel.Instance.ShowRecordView();
	}

	// Token: 0x0600D05C RID: 53340 RVA: 0x002F9408 File Offset: 0x002F7608
	private void OnClickDebugButton()
	{
		if (this.DebugInfoPanel.IsShowOrShowing)
		{
			this.DebugInfoPanel.Hide(null);
			return;
		}
		this.DebugInfoPanel.Show(null);
	}

	// Token: 0x0600D05D RID: 53341 RVA: 0x002F9430 File Offset: 0x002F7630
	private void OnClickCardCountButton()
	{
		ScrollingTipsController.Instance.ShowTipsByTextId("Farm_AnimalAllFull", Array.Empty<object>());
	}

	// Token: 0x0600D05E RID: 53342 RVA: 0x002F9446 File Offset: 0x002F7646
	private void OnClickBackButton()
	{
		this.HideTips();
		FloroRanchGamePlayModel.Instance.PauseGame();
		FloroRanchGamePlayModel.Instance.OpenAndRecordView(EUiViewName.FloroRanchPauseView, null, null);
	}

	// Token: 0x0600D05F RID: 53343 RVA: 0x002F946C File Offset: 0x002F766C
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

	// Token: 0x0600D060 RID: 53344 RVA: 0x002F9518 File Offset: 0x002F7718
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

	// Token: 0x0600D061 RID: 53345 RVA: 0x002F9556 File Offset: 0x002F7756
	private void OnFloroRanchBasicInfoRefresh()
	{
		this.RefreshCurrencyInfo();
		this.RefreshStageInfo();
	}

	// Token: 0x0600D062 RID: 53346 RVA: 0x002F9564 File Offset: 0x002F7764
	private void OnFloroRanchCardEntityCountChange()
	{
		this.SetCardNumText();
	}

	// Token: 0x0600D063 RID: 53347 RVA: 0x002F956C File Offset: 0x002F776C
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

	// Token: 0x04005F9B RID: 24475
	private const int TERRAIN_ITEM_START_INDEX = 24;

	// Token: 0x04005F9C RID: 24476
	private int CurSpeedIndex;

	// Token: 0x04005F9D RID: 24477
	private List<int> SpeedList = new List<int>();

	// Token: 0x04005F9E RID: 24478
	private UCurveFloat CardMoveCurve;

	// Token: 0x04005F9F RID: 24479
	[Nullable(2)]
	private global::FloroRanchActivityData ActivityData;

	// Token: 0x04005FA0 RID: 24480
	private FloroRanchTipData SelectTipData;

	// Token: 0x04005FA1 RID: 24481
	[Nullable(2)]
	private FloroRanchCurrencyItem ItemCost;

	// Token: 0x04005FA2 RID: 24482
	[Nullable(2)]
	private FloroRanchDayProgressItem DayProgressItem;

	// Token: 0x04005FA3 RID: 24483
	[Nullable(2)]
	private FloroRanchDayProgressItem EndlessDayProgressItem;

	// Token: 0x04005FA4 RID: 24484
	[Nullable(2)]
	private FloroRanchCommonTipItem MainTipInfoItem;

	// Token: 0x04005FA5 RID: 24485
	[Nullable(2)]
	private FloroRanchTerrainTipItem SubTipInfoItem;

	// Token: 0x04005FA6 RID: 24486
	[Nullable(2)]
	private LevelSequencePlayer MainTipLevelSequencePlayer;

	// Token: 0x04005FA7 RID: 24487
	[Nullable(2)]
	private LevelSequencePlayer SubTipLevelSequencePlayer;

	// Token: 0x04005FA8 RID: 24488
	[Nullable(2)]
	private LevelSequencePlayer ProgressLevelSequencePlayer;

	// Token: 0x04005FA9 RID: 24489
	private int EventHandle;

	// Token: 0x04005FAA RID: 24490
	[Nullable(2)]
	private TimerHandle ChatPanelHideTimer;

	// Token: 0x04005FAB RID: 24491
	private readonly Dictionary<int, FloroRanchUiTerrainItem> TerrainItemMap = new Dictionary<int, FloroRanchUiTerrainItem>();

	// Token: 0x04005FAC RID: 24492
	private readonly Dictionary<int, FloroRanchUiCardItem> CardItemMap = new Dictionary<int, FloroRanchUiCardItem>();

	// Token: 0x04005FAD RID: 24493
	private readonly Dictionary<int, FloroRanchUiToyItem> ToyItemMap = new Dictionary<int, FloroRanchUiToyItem>();

	// Token: 0x04005FAE RID: 24494
	[Nullable(2)]
	private FloroRanchPopupRewardPanel PopupRewardPanel;

	// Token: 0x04005FAF RID: 24495
	[Nullable(2)]
	private FloroRanchUiRoleSkillItem RoleSkillItem;

	// Token: 0x04005FB0 RID: 24496
	[Nullable(2)]
	private FloroRanchDebugInfoPanel DebugInfoPanel;

	// Token: 0x020080BF RID: 32959
	[NullableContext(0)]
	public class EComponentDefine
	{
		// Token: 0x04029FDD RID: 171997
		public const int CloseButton = 0;

		// Token: 0x04029FDE RID: 171998
		public const int ItemCost = 1;

		// Token: 0x04029FDF RID: 171999
		public const int SpeedText = 2;

		// Token: 0x04029FE0 RID: 172000
		public const int SpeedChangeButton = 3;

		// Token: 0x04029FE1 RID: 172001
		public const int SpeedSprite = 4;

		// Token: 0x04029FE2 RID: 172002
		public const int HelpButton = 5;

		// Token: 0x04029FE3 RID: 172003
		public const int ShowButton = 6;

		// Token: 0x04029FE4 RID: 172004
		public const int RightInfoRoot = 7;

		// Token: 0x04029FE5 RID: 172005
		public const int BasicInfoPanel = 8;

		// Token: 0x04029FE6 RID: 172006
		public const int LevelNameText = 9;

		// Token: 0x04029FE7 RID: 172007
		public const int StageText = 10;

		// Token: 0x04029FE8 RID: 172008
		public const int DayText = 11;

		// Token: 0x04029FE9 RID: 172009
		public const int TargetText = 12;

		// Token: 0x04029FEA RID: 172010
		public const int TargetIconTexture = 13;

		// Token: 0x04029FEB RID: 172011
		public const int TargetProgressTexture = 14;

		// Token: 0x04029FEC RID: 172012
		public const int TargetProgressItem = 15;

		// Token: 0x04029FED RID: 172013
		public const int DayProgressItem = 16;

		// Token: 0x04029FEE RID: 172014
		public const int NewDayButton = 17;

		// Token: 0x04029FEF RID: 172015
		public const int FloroSpine = 18;

		// Token: 0x04029FF0 RID: 172016
		public const int FloroPanel = 19;

		// Token: 0x04029FF1 RID: 172017
		public const int UseSkillButton = 20;

		// Token: 0x04029FF2 RID: 172018
		public const int ToyItemRoot = 21;

		// Token: 0x04029FF3 RID: 172019
		public const int ToyItemTemplate = 22;

		// Token: 0x04029FF4 RID: 172020
		public const int TerrainItemRoot = 23;

		// Token: 0x04029FF5 RID: 172021
		public const int TerrainItem1 = 24;

		// Token: 0x04029FF6 RID: 172022
		public const int TerrainItem2 = 25;

		// Token: 0x04029FF7 RID: 172023
		public const int TerrainItem3 = 26;

		// Token: 0x04029FF8 RID: 172024
		public const int TerrainItem4 = 27;

		// Token: 0x04029FF9 RID: 172025
		public const int TerrainItem5 = 28;

		// Token: 0x04029FFA RID: 172026
		public const int TerrainItem6 = 29;

		// Token: 0x04029FFB RID: 172027
		public const int TerrainItem7 = 30;

		// Token: 0x04029FFC RID: 172028
		public const int TerrainItem8 = 31;

		// Token: 0x04029FFD RID: 172029
		public const int TerrainItem9 = 32;

		// Token: 0x04029FFE RID: 172030
		public const int TerrainItem10 = 33;

		// Token: 0x04029FFF RID: 172031
		public const int TerrainItem11 = 34;

		// Token: 0x0402A000 RID: 172032
		public const int TerrainItem12 = 35;

		// Token: 0x0402A001 RID: 172033
		public const int TerrainItem13 = 36;

		// Token: 0x0402A002 RID: 172034
		public const int TerrainItem14 = 37;

		// Token: 0x0402A003 RID: 172035
		public const int TerrainItem15 = 38;

		// Token: 0x0402A004 RID: 172036
		public const int TerrainItem16 = 39;

		// Token: 0x0402A005 RID: 172037
		public const int TerrainItem17 = 40;

		// Token: 0x0402A006 RID: 172038
		public const int TerrainItem18 = 41;

		// Token: 0x0402A007 RID: 172039
		public const int TerrainItem19 = 42;

		// Token: 0x0402A008 RID: 172040
		public const int TerrainItem20 = 43;

		// Token: 0x0402A009 RID: 172041
		public const int SpineRootItem = 44;

		// Token: 0x0402A00A RID: 172042
		public const int SpineItemTemplate = 45;

		// Token: 0x0402A00B RID: 172043
		public const int PopupRewardPanel = 46;

		// Token: 0x0402A00C RID: 172044
		public const int ChatPanel = 47;

		// Token: 0x0402A00D RID: 172045
		public const int ChatText = 48;

		// Token: 0x0402A00E RID: 172046
		public const int ClickMaskButton = 49;

		// Token: 0x0402A00F RID: 172047
		public const int MaskPanel = 50;

		// Token: 0x0402A010 RID: 172048
		public const int LastDayIncomeTexture = 51;

		// Token: 0x0402A011 RID: 172049
		public const int LastDayIncomeText = 52;

		// Token: 0x0402A012 RID: 172050
		public const int CardNumText = 53;

		// Token: 0x0402A013 RID: 172051
		public const int LastDayDetailButton = 54;

		// Token: 0x0402A014 RID: 172052
		public const int LevelDetailButton = 55;

		// Token: 0x0402A015 RID: 172053
		public const int DebugButton = 56;

		// Token: 0x0402A016 RID: 172054
		public const int RightDebugRoot = 57;

		// Token: 0x0402A017 RID: 172055
		public const int RightMaskTexture = 58;

		// Token: 0x0402A018 RID: 172056
		public const int CardCountButton = 59;

		// Token: 0x0402A019 RID: 172057
		public const int LeafItem = 60;
	}
}
