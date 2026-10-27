using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200486F RID: 18543
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class VillageInfrBuildInfoDescItem : GridProxyAbstract<string>
	{
		// Token: 0x06030886 RID: 198790 RVA: 0x00B451CD File Offset: 0x00B433CD
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06030887 RID: 198791 RVA: 0x00B451F0 File Offset: 0x00B433F0
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
			base.GetText(0).ShowTextNew(data);
		}
	}
}
