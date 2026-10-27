using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BEB RID: 11243
public class TowerDetailInformationMonsterSubItem : UiPanelBase
{
	// Token: 0x060175A2 RID: 95650 RVA: 0x005F08D3 File Offset: 0x005EEAD3
	[NullableContext(1)]
	public TowerDetailInformationMonsterSubItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060175A3 RID: 95651 RVA: 0x005F08E8 File Offset: 0x005EEAE8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060175A4 RID: 95652 RVA: 0x005F0993 File Offset: 0x005EEB93
	protected override void OnStart()
	{
	}

	// Token: 0x060175A5 RID: 95653 RVA: 0x005F0995 File Offset: 0x005EEB95
	public void Update(int data, int level)
	{
		this.MonsterInfoId = data;
		this.ShowLevel = level;
		this.RefreshView();
	}

	// Token: 0x060175A6 RID: 95654 RVA: 0x005F09AC File Offset: 0x005EEBAC
	private void RefreshView()
	{
		string monsterName = MonsterInfoConfig.Instance.GetMonsterName(this.MonsterInfoId);
		base.GetText(0).SetText(monsterName, true);
		string newText = this.ShowLevel.ToString();
		base.GetText(1).SetText(newText, true);
		string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(this.MonsterInfoId);
		base.SetTextureByPath(monsterIcon, base.GetTexture(2), null, null);
	}

	// Token: 0x0400AEC8 RID: 44744
	private int MonsterInfoId;

	// Token: 0x0400AEC9 RID: 44745
	private int ShowLevel;

	// Token: 0x020091A8 RID: 37288
	private enum EChildType
	{
		// Token: 0x0402F20F RID: 193039
		NameText,
		// Token: 0x0402F210 RID: 193040
		LevelText,
		// Token: 0x0402F211 RID: 193041
		MonsterIcon,
		// Token: 0x0402F212 RID: 193042
		RoleItem
	}
}
