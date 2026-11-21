using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E1A RID: 15898
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleEnvironmentBuffItemWithTexture : GridProxyAbstract<IRogueBattleEnvironmentInfo>
	{
		// Token: 0x06028921 RID: 166177 RVA: 0x00B625AC File Offset: 0x00B607AC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06028922 RID: 166178 RVA: 0x00B625E8 File Offset: 0x00B607E8
		public override void Refresh(IRogueBattleEnvironmentInfo data, bool isSelected, int gridIndex)
		{
			base.SetTextureByPath(data.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TextId, data.Param);
		}
	}
}
