using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E34 RID: 7732
[NullableContext(1)]
[Nullable(0)]
internal class MonsterHandBookLayoutItem : UiPanelBase
{
	// Token: 0x0600EB07 RID: 60167 RVA: 0x0037ADE0 File Offset: 0x00378FE0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600EB08 RID: 60168 RVA: 0x0037AE03 File Offset: 0x00379003
	protected override void OnStart()
	{
		this.GridLayout = new GenericLayout<MonsterHandBookMonsterItem, int>(base.GetGridLayout(0), new Func<MonsterHandBookMonsterItem>(this.InitItem), null, false, true);
	}

	// Token: 0x0600EB09 RID: 60169 RVA: 0x0037AE26 File Offset: 0x00379026
	private MonsterHandBookMonsterItem InitItem()
	{
		return new MonsterHandBookMonsterItem
		{
			OnClickCallBack = this.OnClickCallBack
		};
	}

	// Token: 0x0600EB0A RID: 60170 RVA: 0x0037AE39 File Offset: 0x00379039
	public void Update(int[] dataList)
	{
		if (this.GridLayout != null)
		{
			this.GridLayout.RefreshByData(new List<int>(dataList), delegate
			{
				GenericLayout<MonsterHandBookMonsterItem, int> gridLayout = this.GridLayout;
				foreach (MonsterHandBookMonsterItem monsterHandBookMonsterItem in (((gridLayout != null) ? gridLayout.GetLayoutItemList() : null) ?? new List<MonsterHandBookMonsterItem>()))
				{
					if (monsterHandBookMonsterItem.HandBookId == HandBookModel.Instance.CurrentSelectMonsterHandBookId)
					{
						monsterHandBookMonsterItem.OnSelected(true);
						break;
					}
				}
			}, false);
		}
	}

	// Token: 0x04006D08 RID: 27912
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int, bool> OnClickCallBack;

	// Token: 0x04006D09 RID: 27913
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<MonsterHandBookMonsterItem, int> GridLayout;
}
