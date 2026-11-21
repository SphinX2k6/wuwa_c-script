using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045D9 RID: 17881
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RewardItem : GridProxyAbstract<ChangeItemInfoData>
	{
		// Token: 0x0602CFBB RID: 184251 RVA: 0x00C93D4C File Offset: 0x00C91F4C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0602CFBC RID: 184252 RVA: 0x00C93DA6 File Offset: 0x00C91FA6
		public override void Refresh(ChangeItemInfoData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TitleId, Array.Empty<object>());
			base.GetText(2).SetText(data.Value, true);
		}
	}
}
