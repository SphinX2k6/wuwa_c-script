using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.EnemyDetailBook
{
	// Token: 0x02004742 RID: 18242
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoEnemyCharacteristicItem : GridProxyAbstract<KurotatoEnemyCharacteristicData>
	{
		// Token: 0x0602DCAA RID: 187562 RVA: 0x00CD0534 File Offset: 0x00CCE734
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DCAB RID: 187563 RVA: 0x00CD05C0 File Offset: 0x00CCE7C0
		[NullableContext(1)]
		public override void Refresh(KurotatoEnemyCharacteristicData data, bool isSelected, int gridIndex)
		{
			this.SetSpriteByPath(data.IconPath, base.GetSprite(0), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Desc, Array.Empty<object>());
		}

		// Token: 0x0200A38E RID: 41870
		private class ECharacteristicComponent
		{
			// Token: 0x04032B3B RID: 207675
			public const int SpriteIcon = 0;

			// Token: 0x04032B3C RID: 207676
			public const int TextTitle = 1;

			// Token: 0x04032B3D RID: 207677
			public const int TextDesc = 2;
		}
	}
}
