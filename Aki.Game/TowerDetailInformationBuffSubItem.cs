using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002163 RID: 8547
public class TowerDetailInformationBuffSubItem : UiPanelBase
{
	// Token: 0x06014FC0 RID: 85952 RVA: 0x0061CFA1 File Offset: 0x0061B1A1
	[NullableContext(1)]
	public TowerDetailInformationBuffSubItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06014FC1 RID: 85953 RVA: 0x0061CFB8 File Offset: 0x0061B1B8
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

	// Token: 0x06014FC2 RID: 85954 RVA: 0x0061D042 File Offset: 0x0061B242
	[NullableContext(1)]
	public void Update(TowerDetailBuff data)
	{
		this.Data = data;
		this.RefreshView();
	}

	// Token: 0x06014FC3 RID: 85955 RVA: 0x0061D054 File Offset: 0x0061B254
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

	// Token: 0x0400B2C8 RID: 45768
	[Nullable(2)]
	private TowerDetailBuff Data;

	// Token: 0x020083E8 RID: 33768
	private enum EChildType
	{
		// Token: 0x0402A905 RID: 174341
		Icon,
		// Token: 0x0402A906 RID: 174342
		BuffName,
		// Token: 0x0402A907 RID: 174343
		Desc
	}
}
