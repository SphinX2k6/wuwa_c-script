using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E51 RID: 20049
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleEnvironmentBuffItemWithTexture : GridProxyAbstract<IRogueBattleEnvironmentInfo>
	{
		// Token: 0x06033AB6 RID: 211638 RVA: 0x00C19084 File Offset: 0x00C17284
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06033AB7 RID: 211639 RVA: 0x00C190C0 File Offset: 0x00C172C0
		public override void Refresh(IRogueBattleEnvironmentInfo data, bool isSelected, int gridIndex)
		{
			base.SetTextureByPath(data.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TextId, data.Param);
		}
	}
}
