using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000527 RID: 1319
public class GuessJokerHeroSkillItem : UiPanelBase
{
	// Token: 0x0600405E RID: 16478 RVA: 0x00168C70 File Offset: 0x00166E70
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600405F RID: 16479 RVA: 0x00168D5C File Offset: 0x00166F5C
	protected override void OnStart()
	{
		int sex = WorldLevelModel.Instance.Sex;
		base.GetTexture(1).SetUIActive(sex == 0);
		base.GetTexture(2).SetUIActive(sex == 1);
		JokerSkill? jokerSkill = GuessJokerConfig.Instance.GetJokerSkill(100001);
		if (jokerSkill == null)
		{
			return;
		}
		base.GetText(4).ShowTextNew(jokerSkill.Value.SkillName);
		base.GetText(6).ShowTextNew(jokerSkill.Value.SkillName);
		base.GetText(7).ShowTextNew(jokerSkill.Value.SkillDesc);
		this.RefreshDetail(false);
	}

	// Token: 0x06004060 RID: 16480 RVA: 0x00168E06 File Offset: 0x00167006
	public void CloseDetail()
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshDetail(false);
	}

	// Token: 0x06004061 RID: 16481 RVA: 0x00168E1F File Offset: 0x0016701F
	private void RefreshDetail(bool isShowDetail)
	{
		base.GetItem(5).SetUIActive(isShowDetail);
		base.GetItem(3).SetUIActive(!isShowDetail);
	}

	// Token: 0x06004062 RID: 16482 RVA: 0x00168E3E File Offset: 0x0016703E
	private void OnClickToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.RefreshDetail(true);
			return;
		}
		this.RefreshDetail(false);
	}
}
