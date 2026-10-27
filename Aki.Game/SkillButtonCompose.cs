using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028DE RID: 10462
public class SkillButtonCompose : UiPanelBase
{
	// Token: 0x0601597F RID: 88447 RVA: 0x00573150 File Offset: 0x00571350
	[NullableContext(1)]
	public SkillButtonCompose(UUIItem uiItem, Action onFunction)
	{
		this.ClickFunction = onFunction;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06015980 RID: 88448 RVA: 0x0057316C File Offset: 0x0057136C
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

	// Token: 0x06015981 RID: 88449 RVA: 0x005731D3 File Offset: 0x005713D3
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

	// Token: 0x06015982 RID: 88450 RVA: 0x0057320C File Offset: 0x0057140C
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

	// Token: 0x06015983 RID: 88451 RVA: 0x0057327C File Offset: 0x0057147C
	private void OnClick()
	{
		if (this.ClickFunction != null)
		{
			this.ClickFunction();
		}
	}

	// Token: 0x0400A0B7 RID: 41143
	private int Id;

	// Token: 0x0400A0B8 RID: 41144
	[Nullable(1)]
	private readonly Action ClickFunction;

	// Token: 0x02008EEC RID: 36588
	private enum ESkillDefine
	{
		// Token: 0x0402E585 RID: 189829
		EquipSkillIconTexture,
		// Token: 0x0402E586 RID: 189830
		EquipSkillButton
	}
}
