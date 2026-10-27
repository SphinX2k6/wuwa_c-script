using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001073 RID: 4211
public class GuessJokerHeroSkillItem : UiPanelBase
{
	// Token: 0x06006CC9 RID: 27849 RVA: 0x0016033C File Offset: 0x0015E53C
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

	// Token: 0x06006CCA RID: 27850 RVA: 0x00160428 File Offset: 0x0015E628
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

	// Token: 0x06006CCB RID: 27851 RVA: 0x001604D2 File Offset: 0x0015E6D2
	public void CloseDetail()
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshDetail(false);
	}

	// Token: 0x06006CCC RID: 27852 RVA: 0x001604EB File Offset: 0x0015E6EB
	private void RefreshDetail(bool isShowDetail)
	{
		base.GetItem(5).SetUIActive(isShowDetail);
		base.GetItem(3).SetUIActive(!isShowDetail);
	}

	// Token: 0x06006CCD RID: 27853 RVA: 0x0016050A File Offset: 0x0015E70A
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
