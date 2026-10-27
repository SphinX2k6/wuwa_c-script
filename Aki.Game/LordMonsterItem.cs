using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020021BB RID: 8635
public class LordMonsterItem : UiPanelBase
{
	// Token: 0x06010CDC RID: 68828 RVA: 0x00414DF8 File Offset: 0x00412FF8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06010CDD RID: 68829 RVA: 0x00414E54 File Offset: 0x00413054
	public void SetMonsterInfo(int monsterId, int level)
	{
		string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(monsterId);
		base.SetTextureByPath(monsterIcon, base.GetTexture(2), null, null);
		string monsterName = MonsterInfoConfig.Instance.GetMonsterName(monsterId);
		base.GetText(0).SetText(monsterName, true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_InstanceDungeonRecommendLevel_Text", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x02008705 RID: 34565
	private class EChildType
	{
		// Token: 0x0402BEA4 RID: 179876
		public const int NameText = 0;

		// Token: 0x0402BEA5 RID: 179877
		public const int LevelText = 1;

		// Token: 0x0402BEA6 RID: 179878
		public const int MonsterTexture = 2;
	}
}
