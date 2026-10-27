using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.EnemyDetailBook
{
	// Token: 0x0200576A RID: 22378
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoEnemyBasePropertyItem : GridProxyAbstract<KurotatoEnemyBasePropertyData>
	{
		// Token: 0x06038D97 RID: 232855 RVA: 0x00D81940 File Offset: 0x00D7FB40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D98 RID: 232856 RVA: 0x00D819CC File Offset: 0x00D7FBCC
		[NullableContext(1)]
		public override void Refresh(KurotatoEnemyBasePropertyData data, bool isSelected, int gridIndex)
		{
			base.SetTextureByPath(data.IconPath, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			base.GetText(2).SetText(data.Value.ToString(), true);
		}

		// Token: 0x0200B973 RID: 47475
		private class EBasePropertyComponent
		{
			// Token: 0x0403813E RID: 229694
			public const int TexIcon = 0;

			// Token: 0x0403813F RID: 229695
			public const int TextTitle = 1;

			// Token: 0x04038140 RID: 229696
			public const int TextValue = 2;
		}
	}
}
