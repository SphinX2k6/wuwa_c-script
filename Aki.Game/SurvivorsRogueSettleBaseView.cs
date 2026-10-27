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

// Token: 0x02002B79 RID: 11129
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueSettleBaseView : UiViewBase
{
	// Token: 0x060170C4 RID: 94404 RVA: 0x005DA157 File Offset: 0x005D8357
	public SurvivorsRogueSettleBaseView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060170C5 RID: 94405 RVA: 0x005DA16C File Offset: 0x005D836C
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

	// Token: 0x060170C6 RID: 94406 RVA: 0x005DA370 File Offset: 0x005D8570
	protected void SetBtnReturnMainVisible(bool bVisible)
	{
		base.GetButton(18).RootUIComp.Get().SetUIActive(bVisible);
	}

	// Token: 0x060170C7 RID: 94407 RVA: 0x005DA398 File Offset: 0x005D8598
	protected virtual void OnClickBtnReturn()
	{
	}

	// Token: 0x060170C8 RID: 94408 RVA: 0x005DA39A File Offset: 0x005D859A
	protected virtual void OnClickBtnReturnMain()
	{
	}

	// Token: 0x060170C9 RID: 94409 RVA: 0x005DA39C File Offset: 0x005D859C
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueSettleBaseView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueSettleBaseView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060170CA RID: 94410 RVA: 0x005DA3DF File Offset: 0x005D85DF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x060170CB RID: 94411 RVA: 0x005DA3FD File Offset: 0x005D85FD
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x060170CC RID: 94412 RVA: 0x005DA41C File Offset: 0x005D861C
	protected override void OnAfterShow()
	{
		foreach (SurvivorsRogueWeaponSettleItem survivorsRogueWeaponSettleItem in this.WeaponList.GetLayoutItemList())
		{
			survivorsRogueWeaponSettleItem.PlayAnim();
		}
	}

	// Token: 0x060170CD RID: 94413 RVA: 0x005DA474 File Offset: 0x005D8674
	protected override void OnBeforeDestroyImplement()
	{
		this.ScrollingNumberTool.Clear();
	}

	// Token: 0x060170CE RID: 94414 RVA: 0x005DA481 File Offset: 0x005D8681
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

	// Token: 0x060170CF RID: 94415 RVA: 0x005DA4B8 File Offset: 0x005D86B8
	private SurvivorsRogueWeaponSettleItem CreateWeaponInfo()
	{
		return new SurvivorsRogueWeaponSettleItem();
	}

	// Token: 0x060170D0 RID: 94416 RVA: 0x005DA4BF File Offset: 0x005D86BF
	[NullableContext(2)]
	protected virtual ResultView GetViewInfo()
	{
		return null;
	}

	// Token: 0x060170D1 RID: 94417 RVA: 0x005DA4C4 File Offset: 0x005D86C4
	private List<ISurvivorsWeaponGridData> GetAllWeaponGridData(IList<Aki.Protocol.SurvivorsGainData> dataList, int weaponMaxCount)
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

	// Token: 0x060170D2 RID: 94418 RVA: 0x005DA57C File Offset: 0x005D877C
	protected UniTask RefreshAsync()
	{
		SurvivorsRogueSettleBaseView.<RefreshAsync>d__19 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<SurvivorsRogueSettleBaseView.<RefreshAsync>d__19>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400AC8A RID: 44170
	private const string ENDLESS_NO_ACHIEVED_ICON = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Settlement/SP_SurvivorSettlementIconWuJin01.SP_SurvivorSettlementIconWuJin01";

	// Token: 0x0400AC8B RID: 44171
	private const string ENDLESS_ACHIEVED_ICON = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Settlement/SP_SurvivorSettlementIconWuJin02.SP_SurvivorSettlementIconWuJin02";

	// Token: 0x0400AC8C RID: 44172
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsRogueWeaponSettleItem, ISurvivorsWeaponGridData> WeaponList;

	// Token: 0x0400AC8D RID: 44173
	[Nullable(2)]
	private SurvivorsRogueRoleInfoItem RoleInfo;

	// Token: 0x0400AC8E RID: 44174
	private readonly ScrollingNumberTool ScrollingNumberTool = new ScrollingNumberTool();
}
