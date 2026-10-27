using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C23 RID: 23587
	public class BossPilingBuffSimpleItem : GridProxyAbstract<int>
	{
		// Token: 0x0603B96E RID: 244078 RVA: 0x00E366F0 File Offset: 0x00E348F0
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

		// Token: 0x0603B96F RID: 244079 RVA: 0x00E36863 File Offset: 0x00E34A63
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

		// Token: 0x0603B970 RID: 244080 RVA: 0x00E368A0 File Offset: 0x00E34AA0
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			BossPilingBuff value = BossPilingConfig.Instance.GetBuffInfo(data).Value;
			base.SetQualityIconById(base.GetSprite(0), value.Quality, null, null, null);
			base.SetTextureByPath(value.Icon, base.GetTexture(1), null, null);
		}

		// Token: 0x0200BE0D RID: 48653
		private enum EChildType
		{
			// Token: 0x040394EC RID: 234732
			QualitySprite,
			// Token: 0x040394ED RID: 234733
			ItemTexture,
			// Token: 0x040394EE RID: 234734
			BottomTextItem,
			// Token: 0x040394EF RID: 234735
			BottomText,
			// Token: 0x040394F0 RID: 234736
			BottomTextBgSprite,
			// Token: 0x040394F1 RID: 234737
			BottomAdditionItem,
			// Token: 0x040394F2 RID: 234738
			TopAdditionItem,
			// Token: 0x040394F3 RID: 234739
			ExtendToggle,
			// Token: 0x040394F4 RID: 234740
			SkinQualitySprite,
			// Token: 0x040394F5 RID: 234741
			UnderTextAdditionItem
		}
	}
}
