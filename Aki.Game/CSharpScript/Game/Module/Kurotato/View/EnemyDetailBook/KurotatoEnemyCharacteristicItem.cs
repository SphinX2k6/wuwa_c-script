using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.EnemyDetailBook
{
	// Token: 0x0200576B RID: 22379
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoEnemyCharacteristicItem : GridProxyAbstract<KurotatoEnemyCharacteristicData>
	{
		// Token: 0x06038D9A RID: 232858 RVA: 0x00D81A38 File Offset: 0x00D7FC38
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

		// Token: 0x06038D9B RID: 232859 RVA: 0x00D81AC4 File Offset: 0x00D7FCC4
		[NullableContext(1)]
		public override void Refresh(KurotatoEnemyCharacteristicData data, bool isSelected, int gridIndex)
		{
			this.SetSpriteByPath(data.IconPath, base.GetSprite(0), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Desc, Array.Empty<object>());
		}

		// Token: 0x0200B974 RID: 47476
		private class ECharacteristicComponent
		{
			// Token: 0x04038141 RID: 229697
			public const int SpriteIcon = 0;

			// Token: 0x04038142 RID: 229698
			public const int TextTitle = 1;

			// Token: 0x04038143 RID: 229699
			public const int TextDesc = 2;
		}
	}
}
