using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BE8 RID: 11240
public class TowerDetailInformationBuffSubItem : UiPanelBase
{
	// Token: 0x0601758F RID: 95631 RVA: 0x005F0441 File Offset: 0x005EE641
	[NullableContext(1)]
	public TowerDetailInformationBuffSubItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06017590 RID: 95632 RVA: 0x005F0458 File Offset: 0x005EE658
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06017591 RID: 95633 RVA: 0x005F04E2 File Offset: 0x005EE6E2
	[NullableContext(1)]
	public void Update(TowerDetailBuff data)
	{
		this.Data = data;
		this.RefreshView();
	}

	// Token: 0x06017592 RID: 95634 RVA: 0x005F04F4 File Offset: 0x005EE6F4
	private void RefreshView()
	{
		string desc = this.Data.Desc;
		base.GetText(2).SetText(desc, true);
		string name = this.Data.Name;
		base.GetText(1).SetText(name, true);
		string iconPath = this.Data.IconPath;
		if (iconPath == "" || iconPath == null)
		{
			if (StringUtils.IsEmpty(iconPath))
			{
				base.GetTexture(0).SetUIActive(false);
				return;
			}
			base.SetTextureByPath(iconPath, base.GetTexture(0), null, null);
			base.GetTexture(0).SetUIActive(true);
		}
	}

	// Token: 0x0400AEC3 RID: 44739
	[Nullable(2)]
	private TowerDetailBuff Data;

	// Token: 0x020091A5 RID: 37285
	private enum EChildType
	{
		// Token: 0x0402F204 RID: 193028
		Icon,
		// Token: 0x0402F205 RID: 193029
		BuffName,
		// Token: 0x0402F206 RID: 193030
		Desc
	}
}
