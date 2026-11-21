using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200052C RID: 1324
public class GuessJokerSkillActivateItem : UiPanelBase
{
	// Token: 0x06004087 RID: 16519 RVA: 0x00169A24 File Offset: 0x00167C24
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

	// Token: 0x06004088 RID: 16520 RVA: 0x00169AAA File Offset: 0x00167CAA
	protected override void OnStart()
	{
	}

	// Token: 0x06004089 RID: 16521 RVA: 0x00169AAC File Offset: 0x00167CAC
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

	// Token: 0x02006807 RID: 26631
	private static class EComponentDefine
	{
		// Token: 0x040224C9 RID: 140489
		public const int MaskButton = 0;

		// Token: 0x040224CA RID: 140490
		public const int RoleTexture = 1;

		// Token: 0x040224CB RID: 140491
		public const int SkillIconTexture = 2;

		// Token: 0x040224CC RID: 140492
		public const int DescText = 3;

		// Token: 0x040224CD RID: 140493
		public const int ValueText = 4;
	}
}
