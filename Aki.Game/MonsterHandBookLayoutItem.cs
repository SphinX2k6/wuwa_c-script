using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012F6 RID: 4854
[NullableContext(1)]
[Nullable(0)]
internal class MonsterHandBookLayoutItem : UiPanelBase
{
	// Token: 0x0600BF26 RID: 48934 RVA: 0x00386A6C File Offset: 0x00384C6C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600BF27 RID: 48935 RVA: 0x00386A8F File Offset: 0x00384C8F
	protected override void OnStart()
	{
		this.GridLayout = new GenericLayout<MonsterHandBookMonsterItem, int>(base.GetGridLayout(0), new Func<MonsterHandBookMonsterItem>(this.InitItem), null, false, true);
	}

	// Token: 0x0600BF28 RID: 48936 RVA: 0x00386AB2 File Offset: 0x00384CB2
	private MonsterHandBookMonsterItem InitItem()
	{
		return new MonsterHandBookMonsterItem
		{
			OnClickCallBack = this.OnClickCallBack
		};
	}

	// Token: 0x0600BF29 RID: 48937 RVA: 0x00386AC5 File Offset: 0x00384CC5
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

	// Token: 0x04006DE9 RID: 28137
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int, bool> OnClickCallBack;

	// Token: 0x04006DEA RID: 28138
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<MonsterHandBookMonsterItem, int> GridLayout;
}
