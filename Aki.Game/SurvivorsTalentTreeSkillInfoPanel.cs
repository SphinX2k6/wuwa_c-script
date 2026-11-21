using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020CC RID: 8396
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsTalentTreeSkillInfoPanel : UiPanelBase
{
	// Token: 0x06014A34 RID: 84532 RVA: 0x00603B14 File Offset: 0x00601D14
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem))
		};
	}

	// Token: 0x06014A35 RID: 84533 RVA: 0x00603C94 File Offset: 0x00601E94
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsTalentTreeSkillInfoPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsTalentTreeSkillInfoPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014A36 RID: 84534 RVA: 0x00603CD7 File Offset: 0x00601ED7
	private SurvivorsTalentTreeMediumItemGrid InitGridItem()
	{
		return new SurvivorsTalentTreeMediumItemGrid();
	}

	// Token: 0x06014A37 RID: 84535 RVA: 0x00603CE0 File Offset: 0x00601EE0
	public UniTask RefreshAsync(SurvivorsTalentNode talentNode)
	{
		SurvivorsTalentTreeSkillInfoPanel.<RefreshAsync>d__8 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.talentNode = talentNode;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<SurvivorsTalentTreeSkillInfoPanel.<RefreshAsync>d__8>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014A38 RID: 84536 RVA: 0x00603D2C File Offset: 0x00601F2C
	private void OnClickConfirmBtn(int _)
	{
		if (!this.CostItem.IsEnough)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsTalentTreeNotEnough", Array.Empty<object>());
			return;
		}
		SurvivorsTalentEffect? effectConfig = SurvivorsRogueConfig.Instance.GetTalentTreeEffect(this.TalentNode.EffectId);
		if (effectConfig == null)
		{
			return;
		}
		SurvivorsActivityController.Instance.SurvivorsTalentLevelUpRequest(this.TalentNode.NodeId, delegate
		{
			if (effectConfig.Value.ShowType == 1)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsTalentTreeUnlocked", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SurvivorsTalentUnlockView, effectConfig, null);
		});
	}

	// Token: 0x0400AFB7 RID: 44983
	private SurvivorsTalentNode TalentNode;

	// Token: 0x0400AFB8 RID: 44984
	[Nullable(2)]
	private ButtonItem ConfirmBtnItem;

	// Token: 0x0400AFB9 RID: 44985
	private CommonCostItem CostItem;

	// Token: 0x0400AFBA RID: 44986
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SurvivorsTalentTreeMediumItemGrid, int> ItemLayout;

	// Token: 0x0400AFBB RID: 44987
	[Nullable(2)]
	private FunctionalPanelConditionLock LockTipsItem;
}
