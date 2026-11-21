using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.EnemyDetailBook
{
	// Token: 0x02004741 RID: 18241
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoEnemyBasePropertyItem : GridProxyAbstract<KurotatoEnemyBasePropertyData>
	{
		// Token: 0x0602DCA7 RID: 187559 RVA: 0x00CD043C File Offset: 0x00CCE63C
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

		// Token: 0x0602DCA8 RID: 187560 RVA: 0x00CD04C8 File Offset: 0x00CCE6C8
		[NullableContext(1)]
		public override void Refresh(KurotatoEnemyBasePropertyData data, bool isSelected, int gridIndex)
		{
			base.SetTextureByPath(data.IconPath, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			base.GetText(2).SetText(data.Value.ToString(), true);
		}

		// Token: 0x0200A38D RID: 41869
		private class EBasePropertyComponent
		{
			// Token: 0x04032B38 RID: 207672
			public const int TexIcon = 0;

			// Token: 0x04032B39 RID: 207673
			public const int TextTitle = 1;

			// Token: 0x04032B3A RID: 207674
			public const int TextValue = 2;
		}
	}
}
