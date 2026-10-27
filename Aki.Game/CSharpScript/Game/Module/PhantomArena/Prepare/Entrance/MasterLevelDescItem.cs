using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005179 RID: 20857
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MasterLevelDescItem : GridProxyAbstract<MasterLevelDescData>
	{
		// Token: 0x06035561 RID: 218465 RVA: 0x00CA25E4 File Offset: 0x00CA07E4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite))
			};
		}

		// Token: 0x06035562 RID: 218466 RVA: 0x00CA2640 File Offset: 0x00CA0840
		[NullableContext(1)]
		public override void Refresh(MasterLevelDescData data, bool isSelected, int gridIndex)
		{
			base.GetSprite(0).SetUIActive(data.IsDone);
			base.GetSprite(2).SetUIActive(!data.IsDone);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.StringId, Array.Empty<object>());
		}

		// Token: 0x0200B2EB RID: 45803
		private class EDescComponent
		{
			// Token: 0x04036372 RID: 222066
			public const int SpriteDone = 0;

			// Token: 0x04036373 RID: 222067
			public const int TextDesc = 1;

			// Token: 0x04036374 RID: 222068
			public const int SpritePending = 2;
		}
	}
}
