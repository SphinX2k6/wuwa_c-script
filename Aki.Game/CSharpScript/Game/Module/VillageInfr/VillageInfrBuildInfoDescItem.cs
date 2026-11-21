using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x020037E6 RID: 14310
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class VillageInfrBuildInfoDescItem : GridProxyAbstract<string>
	{
		// Token: 0x060253B2 RID: 152498 RVA: 0x00A7FF69 File Offset: 0x00A7E169
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x060253B3 RID: 152499 RVA: 0x00A7FF8C File Offset: 0x00A7E18C
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
			base.GetText(0).ShowTextNew(data);
		}
	}
}
