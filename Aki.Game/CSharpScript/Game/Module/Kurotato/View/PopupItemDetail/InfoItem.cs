using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.PopupItemDetail
{
	// Token: 0x02004712 RID: 18194
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class InfoItem : GridProxyAbstract<IInfoItemData>
	{
		// Token: 0x0602DB6D RID: 187245 RVA: 0x00CC8E78 File Offset: 0x00CC7078
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DB6E RID: 187246 RVA: 0x00CC8EE4 File Offset: 0x00CC70E4
		[NullableContext(1)]
		public override void Refresh(IInfoItemData data, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText("(" + data.Level.ToString() + ") " + data.Description, true);
			if (data.Level > data.BuildLevel)
			{
				base.GetText(0).SetColor(FColor.FromHex("#909090"));
			}
			else
			{
				base.GetText(0).SetColor(FColor.FromHex("#ffffff"));
			}
			base.GetSprite(1).SetUIActive(data.IsArrowLevel);
		}

		// Token: 0x0200A33C RID: 41788
		private enum EInfoItemComp
		{
			// Token: 0x040329CD RID: 207309
			TextDesc,
			// Token: 0x040329CE RID: 207310
			SpriteArrow
		}
	}
}
