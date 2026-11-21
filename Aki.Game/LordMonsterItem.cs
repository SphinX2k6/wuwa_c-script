using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200169F RID: 5791
public class LordMonsterItem : UiPanelBase
{
	// Token: 0x0600E16D RID: 57709 RVA: 0x004216D8 File Offset: 0x0041F8D8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600E16E RID: 57710 RVA: 0x00421734 File Offset: 0x0041F934
	public void SetMonsterInfo(int monsterId, int level)
	{
		string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(monsterId);
		base.SetTextureByPath(monsterIcon, base.GetTexture(2), null, null);
		string monsterName = MonsterInfoConfig.Instance.GetMonsterName(monsterId);
		base.GetText(0).SetText(monsterName, true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_InstanceDungeonRecommendLevel_Text", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x02007890 RID: 30864
	private class EChildType
	{
		// Token: 0x040271C5 RID: 160197
		public const int NameText = 0;

		// Token: 0x040271C6 RID: 160198
		public const int LevelText = 1;

		// Token: 0x040271C7 RID: 160199
		public const int MonsterTexture = 2;
	}
}
