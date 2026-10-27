using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F60 RID: 3936
public class DrinksMenuFlavorTasteItem : UiPanelBase
{
	// Token: 0x060064B5 RID: 25781 RVA: 0x0013F20D File Offset: 0x0013D40D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060064B6 RID: 25782 RVA: 0x0013F248 File Offset: 0x0013D448
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

	// Token: 0x020075AC RID: 30124
	private static class EFlavor
	{
		// Token: 0x04026E4F RID: 159311
		public const int Icon = 0;

		// Token: 0x04026E50 RID: 159312
		public const int Txt = 1;
	}
}
