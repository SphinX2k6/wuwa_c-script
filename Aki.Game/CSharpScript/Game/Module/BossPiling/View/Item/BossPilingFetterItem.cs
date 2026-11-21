using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02004C09 RID: 19465
	public class BossPilingFetterItem : UiPanelBase
	{
		// Token: 0x060308D9 RID: 198873 RVA: 0x00D87D50 File Offset: 0x00D85F50
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060308DA RID: 198874 RVA: 0x00D87DBC File Offset: 0x00D85FBC
		public void Refresh(int id)
		{
			ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(id);
			if (elementConfig == null)
			{
				return;
			}
			FColor color = FColor.FromHex(elementConfig.Value.ElementColor);
			base.GetSprite(0).SetColor(color);
			base.SetTextureByPath(elementConfig.Value.Icon5, base.GetTexture(1), null, null);
		}

		// Token: 0x0200A81B RID: 43035
		private enum EFetter
		{
			// Token: 0x04033EDE RID: 212702
			Sprite,
			// Token: 0x04033EDF RID: 212703
			Tex
		}
	}
}
