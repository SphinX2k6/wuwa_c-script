using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DB2 RID: 19890
	public class SpecialEnergyBarBuLanTeStarItem : UiPanelBase
	{
		// Token: 0x06031FF3 RID: 204787 RVA: 0x00DFE488 File Offset: 0x00DFC688
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

		// Token: 0x06031FF4 RID: 204788 RVA: 0x00DFE512 File Offset: 0x00DFC712
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

		// Token: 0x06031FF5 RID: 204789 RVA: 0x00DFE53C File Offset: 0x00DFC73C
		public void SetStarEnable(bool isEnable)
		{
			UUITexture texture = base.GetTexture(2);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(isEnable);
		}

		// Token: 0x0200AAEA RID: 43754
		private enum EChildType
		{
			// Token: 0x04034D0D RID: 216333
			StarBgTexture1,
			// Token: 0x04034D0E RID: 216334
			StarBgTexture2,
			// Token: 0x04034D0F RID: 216335
			StarTexture
		}
	}
}
