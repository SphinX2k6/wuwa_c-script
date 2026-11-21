using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020F5 RID: 8437
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueSettleBaseView : UiViewBase
{
	// Token: 0x06014AF5 RID: 84725 RVA: 0x00606CC7 File Offset: 0x00604EC7
	public SurvivorsRogueSettleBaseView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014AF6 RID: 84726 RVA: 0x00606CDC File Offset: 0x00604EDC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(18, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(17, new Action(this.OnClickBtnReturn)),
			new ValueTuple<int, Delegate>(18, new Action(this.OnClickBtnReturnMain))
		};
	}

	// Token: 0x06014AF7 RID: 84727 RVA: 0x00606EE0 File Offset: 0x006050E0
	protected void SetBtnReturnMainVisible(bool bVisible)
	{
		base.GetButton(18).RootUIComp.Get().SetUIActive(bVisible);
	}

	// Token: 0x06014AF8 RID: 84728 RVA: 0x00606F08 File Offset: 0x00605108
	protected virtual void OnClickBtnReturn()
	{
	}

	// Token: 0x06014AF9 RID: 84729 RVA: 0x00606F0A File Offset: 0x0060510A
	protected virtual void OnClickBtnReturnMain()
	{
	}

	// Token: 0x06014AFA RID: 84730 RVA: 0x00606F0C File Offset: 0x0060510C
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueSettleBaseView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueSettleBaseView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014AFB RID: 84731 RVA: 0x00606F4F File Offset: 0x0060514F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06014AFC RID: 84732 RVA: 0x00606F6D File Offset: 0x0060516D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06014AFD RID: 84733 RVA: 0x00606F8C File Offset: 0x0060518C
	protected override void OnAfterShow()
	{
		foreach (SurvivorsRogueWeaponSettleItem survivorsRogueWeaponSettleItem in this.WeaponList.GetLayoutItemList())
		{
			survivorsRogueWeaponSettleItem.PlayAnim();
		}
	}

	// Token: 0x06014AFE RID: 84734 RVA: 0x00606FE4 File Offset: 0x006051E4
	protected override void OnBeforeDestroyImplement()
	{
		this.ScrollingNumberTool.Clear();
	}

	// Token: 0x06014AFF RID: 84735 RVA: 0x00606FF1 File Offset: 0x006051F1
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "InturnAni")
		{
			UUIInturnAnimController uiAnimController = this.WeaponList.GetUiAnimController();
			if (uiAnimController != null)
			{
				uiAnimController.Play("", -1, false);
			}
			this.ScrollingNumberTool.StartScrolling();
		}
	}

	// Token: 0x06014B00 RID: 84736 RVA: 0x00607028 File Offset: 0x00605228
	private SurvivorsRogueWeaponSettleItem CreateWeaponInfo()
	{
		return new SurvivorsRogueWeaponSettleItem();
	}

	// Token: 0x06014B01 RID: 84737 RVA: 0x0060702F File Offset: 0x0060522F
	[NullableContext(2)]
	protected virtual ResultView GetViewInfo()
	{
		return null;
	}

	// Token: 0x06014B02 RID: 84738 RVA: 0x00607034 File Offset: 0x00605234
	private List<ISurvivorsWeaponGridData> GetAllWeaponGridData(IReadOnlyList<Aki.Protocol.SurvivorsGainData> dataList, int weaponMaxCount)
	{
		List<SurvivorsWeaponGainData> list = new List<SurvivorsWeaponGainData>();
		foreach (Aki.Protocol.SurvivorsGainData survivorsGainData in dataList)
		{
			Aki.Protocol.SurvivorsGainData survivorsGainData2 = survivorsGainData;
			if (survivorsGainData2.DataCase.ToString() == "Proto_SurvivorsWeapon")
			{
				SurvivorsWeaponGainData item = new SurvivorsWeaponGainData(survivorsGainData.IncId, survivorsGainData.ConfigId, survivorsGainData2.SurvivorsWeapon, ESurvivorsRogueItemType.Weapon);
				list.Add(item);
			}
		}
		List<ISurvivorsWeaponWithBondInfo> weaponGainListWithBondInfo = SurvivorsRogueModel.Instance.GainData.GetWeaponGainListWithBondInfo(list);
		return SurvivorsRogueModel.Instance.GainData.GetWeaponGridDataList(weaponGainListWithBondInfo, new int?(weaponMaxCount));
	}

	// Token: 0x06014B03 RID: 84739 RVA: 0x006070EC File Offset: 0x006052EC
	protected UniTask RefreshAsync()
	{
		SurvivorsRogueSettleBaseView.<RefreshAsync>d__19 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<SurvivorsRogueSettleBaseView.<RefreshAsync>d__19>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400B090 RID: 45200
	private const string ENDLESS_NO_ACHIEVED_ICON = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Settlement/SP_SurvivorSettlementIconWuJin01.SP_SurvivorSettlementIconWuJin01";

	// Token: 0x0400B091 RID: 45201
	private const string ENDLESS_ACHIEVED_ICON = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Settlement/SP_SurvivorSettlementIconWuJin02.SP_SurvivorSettlementIconWuJin02";

	// Token: 0x0400B092 RID: 45202
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsRogueWeaponSettleItem, ISurvivorsWeaponGridData> WeaponList;

	// Token: 0x0400B093 RID: 45203
	[Nullable(2)]
	private SurvivorsRogueRoleInfoItem RoleInfo;

	// Token: 0x0400B094 RID: 45204
	private readonly ScrollingNumberTool ScrollingNumberTool = new ScrollingNumberTool();
}
