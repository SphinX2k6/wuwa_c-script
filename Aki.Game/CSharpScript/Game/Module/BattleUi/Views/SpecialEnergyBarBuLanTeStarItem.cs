using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DCE RID: 24014
	public class SpecialEnergyBarBuLanTeStarItem : UiPanelBase
	{
		// Token: 0x0603D07C RID: 249980 RVA: 0x00EAD594 File Offset: 0x00EAB794
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D07D RID: 249981 RVA: 0x00EAD61E File Offset: 0x00EAB81E
		public void SetIsEmpty(bool isEmpty)
		{
			UUITexture texture = base.GetTexture(0);
			if (texture != null)
			{
				texture.SetUIActive(isEmpty);
			}
			UUITexture texture2 = base.GetTexture(1);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetUIActive(!isEmpty);
		}

		// Token: 0x0603D07E RID: 249982 RVA: 0x00EAD648 File Offset: 0x00EAB848
		public void SetStarEnable(bool isEnable)
		{
			UUITexture texture = base.GetTexture(2);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(isEnable);
		}

		// Token: 0x0200C0E1 RID: 49377
		private enum EChildType
		{
			// Token: 0x0403A33B RID: 238395
			StarBgTexture1,
			// Token: 0x0403A33C RID: 238396
			StarBgTexture2,
			// Token: 0x0403A33D RID: 238397
			StarTexture
		}
	}
}
