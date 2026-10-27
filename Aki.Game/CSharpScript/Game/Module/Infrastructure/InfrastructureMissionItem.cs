using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005914 RID: 22804
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrastructureMissionItem : GridProxyAbstract<InfrastructureMissionItemData>
	{
		// Token: 0x06039E9A RID: 237210 RVA: 0x00DC1FF8 File Offset: 0x00DC01F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039E9B RID: 237211 RVA: 0x00DC20C4 File Offset: 0x00DC02C4
		[NullableContext(1)]
		public override void Refresh(InfrastructureMissionItemData data, bool isSelected, int gridIndex)
		{
			base.GetText(2).SetUIActive(true);
			base.GetText(2).ShowTextNew(data.DesText);
			base.GetSprite(1).SetUIActive(data.CurrentCount >= data.MaxCount);
			UUIText text = base.GetText(3);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.CurrentCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.MaxCount);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			if (data.CurrentCount >= data.MaxCount)
			{
				base.GetText(3).SetColor(FColor.FromHex("#d5ec20"));
				base.GetText(2).SetColor(FColor.FromHex("#d5ec20"));
				return;
			}
			base.GetText(3).SetColor(FColor.FromHex("#ffffff"));
			base.GetText(2).SetColor(FColor.FromHex("#ffffff"));
		}

		// Token: 0x0200BB90 RID: 48016
		private class EChildType
		{
			// Token: 0x040389E9 RID: 231913
			public const int SpriteCompleteIcon = 0;

			// Token: 0x040389EA RID: 231914
			public const int SpriteDone = 1;

			// Token: 0x040389EB RID: 231915
			public const int TextName = 2;

			// Token: 0x040389EC RID: 231916
			public const int TextNum = 3;

			// Token: 0x040389ED RID: 231917
			public const int SpriteLine = 4;
		}
	}
}
