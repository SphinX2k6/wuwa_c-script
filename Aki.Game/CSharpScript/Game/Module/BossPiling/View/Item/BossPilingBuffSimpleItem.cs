using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02004C03 RID: 19459
	public class BossPilingBuffSimpleItem : GridProxyAbstract<int>
	{
		// Token: 0x060308B9 RID: 198841 RVA: 0x00D86A4C File Offset: 0x00D84C4C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060308BA RID: 198842 RVA: 0x00D86BBF File Offset: 0x00D84DBF
		protected override void OnStart()
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetSelfInteractive(false);
		}

		// Token: 0x060308BB RID: 198843 RVA: 0x00D86BFC File Offset: 0x00D84DFC
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			BossPilingBuff value = BossPilingConfig.Instance.GetBuffInfo(data).Value;
			base.SetQualityIconById(base.GetSprite(0), value.Quality, null, null, null);
			base.SetTextureByPath(value.Icon, base.GetTexture(1), null, null);
		}

		// Token: 0x0200A815 RID: 43029
		private enum EChildType
		{
			// Token: 0x04033EAF RID: 212655
			QualitySprite,
			// Token: 0x04033EB0 RID: 212656
			ItemTexture,
			// Token: 0x04033EB1 RID: 212657
			BottomTextItem,
			// Token: 0x04033EB2 RID: 212658
			BottomText,
			// Token: 0x04033EB3 RID: 212659
			BottomTextBgSprite,
			// Token: 0x04033EB4 RID: 212660
			BottomAdditionItem,
			// Token: 0x04033EB5 RID: 212661
			TopAdditionItem,
			// Token: 0x04033EB6 RID: 212662
			ExtendToggle,
			// Token: 0x04033EB7 RID: 212663
			SkinQualitySprite,
			// Token: 0x04033EB8 RID: 212664
			UnderTextAdditionItem
		}
	}
}
