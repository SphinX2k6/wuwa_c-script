using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E59 RID: 7769
public class SkillButtonCompose : UiPanelBase
{
	// Token: 0x06013383 RID: 78723 RVA: 0x0059E018 File Offset: 0x0059C218
	[NullableContext(1)]
	public SkillButtonCompose(UUIItem uiItem, Action onFunction)
	{
		this.ClickFunction = onFunction;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06013384 RID: 78724 RVA: 0x0059E034 File Offset: 0x0059C234
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClick))
		};
	}

	// Token: 0x06013385 RID: 78725 RVA: 0x0059E09B File Offset: 0x0059C29B
	public void Update(int id)
	{
		this.Id = id;
		if (this.Id == 0 || !PhantomBattleController.Instance.CheckIsMain(this.Id))
		{
			this.SetActive(false);
			return;
		}
		this.SetActive(true);
		this.RefreshTexture();
	}

	// Token: 0x06013386 RID: 78726 RVA: 0x0059E0D4 File Offset: 0x0059C2D4
	public void RefreshTexture()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.Id);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		PhantomBattleInstance phantomInstanceByItemId = PhantomBattleModel.Instance.GetPhantomInstanceByItemId(phantomItemDataByUniqueId.GetConfigId(false));
		if (phantomInstanceByItemId == null)
		{
			return;
		}
		PhantomSkill? phantomSkillInfoByLevel = phantomInstanceByItemId.GetPhantomSkillInfoByLevel();
		if (phantomSkillInfoByLevel == null)
		{
			return;
		}
		base.SetTextureByPath(phantomSkillInfoByLevel.Value.BattleViewIcon, base.GetTexture(0), null, null);
	}

	// Token: 0x06013387 RID: 78727 RVA: 0x0059E144 File Offset: 0x0059C344
	private void OnClick()
	{
		if (this.ClickFunction != null)
		{
			this.ClickFunction();
		}
	}

	// Token: 0x0400A4A1 RID: 42145
	private int Id;

	// Token: 0x0400A4A2 RID: 42146
	[Nullable(1)]
	private readonly Action ClickFunction;

	// Token: 0x02008134 RID: 33076
	private enum ESkillDefine
	{
		// Token: 0x04029C80 RID: 171136
		EquipSkillIconTexture,
		// Token: 0x04029C81 RID: 171137
		EquipSkillButton
	}
}
