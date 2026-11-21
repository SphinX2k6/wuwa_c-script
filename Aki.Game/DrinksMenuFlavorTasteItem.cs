using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000415 RID: 1045
public class DrinksMenuFlavorTasteItem : UiPanelBase
{
	// Token: 0x0600384D RID: 14413 RVA: 0x00147AA9 File Offset: 0x00145CA9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600384E RID: 14414 RVA: 0x00147AE4 File Offset: 0x00145CE4
	[NullableContext(2)]
	public void Refresh(ITasteInfo data)
	{
		if (data == null)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(false);
			return;
		}
		else
		{
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 != null)
			{
				rootItem2.SetUIActive(true);
			}
			base.SetTextureByPath(DrinksConfig.Instance.GetFlavorType(data.Type).Value.Icon, base.GetTexture(0), null, null);
			string newText;
			if (data.Value.Length == 1)
			{
				newText = StringUtils.Format(data.Key, new string[]
				{
					data.Value[0]
				});
			}
			else if (data.Value.Length >= 2)
			{
				newText = StringUtils.Format(data.Key, new string[]
				{
					data.Value[0],
					data.Value[1]
				});
			}
			else
			{
				newText = data.Key;
			}
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
			return;
		}
	}

	// Token: 0x02006740 RID: 26432
	private static class EFlavor
	{
		// Token: 0x0402219A RID: 139674
		public const int Icon = 0;

		// Token: 0x0402219B RID: 139675
		public const int Txt = 1;
	}
}
