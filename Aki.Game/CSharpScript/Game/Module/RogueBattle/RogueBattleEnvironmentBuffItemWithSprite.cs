using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E53 RID: 20051
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleEnvironmentBuffItemWithSprite : GridProxyAbstract<IRogueBattleEnvironmentInfo>
	{
		// Token: 0x06033AB9 RID: 211641 RVA: 0x00C1910F File Offset: 0x00C1730F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06033ABA RID: 211642 RVA: 0x00C19148 File Offset: 0x00C17348
		public override void Refresh(IRogueBattleEnvironmentInfo data, bool isSelected, int gridIndex)
		{
			this.SetSpriteByPath(data.Icon, base.GetSprite(0), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TextId, data.Param);
		}
	}
}
