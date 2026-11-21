using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048ED RID: 18669
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrastructureMissionItem : GridProxyAbstract<InfrastructureMissionItemData>
	{
		// Token: 0x0602EDBD RID: 191933 RVA: 0x00D112F8 File Offset: 0x00D0F4F8
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

		// Token: 0x0602EDBE RID: 191934 RVA: 0x00D113C4 File Offset: 0x00D0F5C4
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

		// Token: 0x0200A5A0 RID: 42400
		private class EChildType
		{
			// Token: 0x040333D1 RID: 209873
			public const int SpriteCompleteIcon = 0;

			// Token: 0x040333D2 RID: 209874
			public const int SpriteDone = 1;

			// Token: 0x040333D3 RID: 209875
			public const int TextName = 2;

			// Token: 0x040333D4 RID: 209876
			public const int TextNum = 3;

			// Token: 0x040333D5 RID: 209877
			public const int SpriteLine = 4;
		}
	}
}
