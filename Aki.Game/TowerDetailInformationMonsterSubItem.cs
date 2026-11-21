using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002166 RID: 8550
public class TowerDetailInformationMonsterSubItem : UiPanelBase
{
	// Token: 0x06014FD3 RID: 85971 RVA: 0x0061D433 File Offset: 0x0061B633
	[NullableContext(1)]
	public TowerDetailInformationMonsterSubItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06014FD4 RID: 85972 RVA: 0x0061D448 File Offset: 0x0061B648
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

	// Token: 0x06014FD5 RID: 85973 RVA: 0x0061D4F3 File Offset: 0x0061B6F3
	protected override void OnStart()
	{
	}

	// Token: 0x06014FD6 RID: 85974 RVA: 0x0061D4F5 File Offset: 0x0061B6F5
	public void Update(int data, int level)
	{
		this.MonsterInfoId = data;
		this.ShowLevel = level;
		this.RefreshView();
	}

	// Token: 0x06014FD7 RID: 85975 RVA: 0x0061D50C File Offset: 0x0061B70C
	private void RefreshView()
	{
		string monsterName = MonsterInfoConfig.Instance.GetMonsterName(this.MonsterInfoId);
		base.GetText(0).SetText(monsterName, true);
		string newText = this.ShowLevel.ToString();
		base.GetText(1).SetText(newText, true);
		string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(this.MonsterInfoId);
		base.SetTextureByPath(monsterIcon, base.GetTexture(2), null, null);
	}

	// Token: 0x0400B2CD RID: 45773
	private int MonsterInfoId;

	// Token: 0x0400B2CE RID: 45774
	private int ShowLevel;

	// Token: 0x020083EB RID: 33771
	private enum EChildType
	{
		// Token: 0x0402A910 RID: 174352
		NameText,
		// Token: 0x0402A911 RID: 174353
		LevelText,
		// Token: 0x0402A912 RID: 174354
		MonsterIcon,
		// Token: 0x0402A913 RID: 174355
		RoleItem
	}
}
