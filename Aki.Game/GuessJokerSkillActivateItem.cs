using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001078 RID: 4216
public class GuessJokerSkillActivateItem : UiPanelBase
{
	// Token: 0x06006CF2 RID: 27890 RVA: 0x001610F0 File Offset: 0x0015F2F0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
	}

	// Token: 0x06006CF3 RID: 27891 RVA: 0x00161176 File Offset: 0x0015F376
	protected override void OnStart()
	{
	}

	// Token: 0x06006CF4 RID: 27892 RVA: 0x00161178 File Offset: 0x0015F378
	public void Refresh(int skillId)
	{
		JokerSkill? jokerSkill = GuessJokerConfig.Instance.GetJokerSkill(skillId);
		if (jokerSkill == null)
		{
			return;
		}
		JokerSkill value = jokerSkill.Value;
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.ShowTextNew(value.SkillName);
		}
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.ShowTextNew(value.ShortSkillDesc);
		}
		base.SetTextureByPath(value.SkillIconPath, base.GetTexture(2), null, null);
		if (value.SkillPlayTextureLength == 1)
		{
			base.SetTextureByPath(value.SkillPlayTexture(0), base.GetTexture(1), null, null);
			return;
		}
		string path = (WorldLevelModel.Instance.Sex == 1) ? value.SkillPlayTexture(0) : value.SkillPlayTexture(1);
		base.SetTextureByPath(path, base.GetTexture(1), null, null);
	}

	// Token: 0x02007673 RID: 30323
	private static class EComponentDefine
	{
		// Token: 0x0402717E RID: 160126
		public const int MaskButton = 0;

		// Token: 0x0402717F RID: 160127
		public const int RoleTexture = 1;

		// Token: 0x04027180 RID: 160128
		public const int SkillIconTexture = 2;

		// Token: 0x04027181 RID: 160129
		public const int DescText = 3;

		// Token: 0x04027182 RID: 160130
		public const int ValueText = 4;
	}
}
