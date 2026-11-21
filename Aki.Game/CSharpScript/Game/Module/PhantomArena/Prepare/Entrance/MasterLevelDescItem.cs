using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004149 RID: 16713
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MasterLevelDescItem : GridProxyAbstract<MasterLevelDescData>
	{
		// Token: 0x0602A45C RID: 173148 RVA: 0x00BEFB9C File Offset: 0x00BEDD9C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite))
			};
		}

		// Token: 0x0602A45D RID: 173149 RVA: 0x00BEFBF8 File Offset: 0x00BEDDF8
		[NullableContext(1)]
		public override void Refresh(MasterLevelDescData data, bool isSelected, int gridIndex)
		{
			base.GetSprite(0).SetUIActive(data.IsDone);
			base.GetSprite(2).SetUIActive(!data.IsDone);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.StringId, Array.Empty<object>());
		}

		// Token: 0x02009D24 RID: 40228
		private class EDescComponent
		{
			// Token: 0x04030DC7 RID: 200135
			public const int SpriteDone = 0;

			// Token: 0x04030DC8 RID: 200136
			public const int TextDesc = 1;

			// Token: 0x04030DC9 RID: 200137
			public const int SpritePending = 2;
		}
	}
}
