using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x020046FE RID: 18174
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoConfigData : IWuWaGoLevelData
	{
		// Token: 0x1700768D RID: 30349
		// (get) Token: 0x0602F820 RID: 194592 RVA: 0x00B03629 File Offset: 0x00B01829
		// (set) Token: 0x0602F821 RID: 194593 RVA: 0x00B03631 File Offset: 0x00B01831
		[RequiredMember]
		public List<int> LevelEntityIds { get; set; }

		// Token: 0x0602F822 RID: 194594 RVA: 0x00B0363A File Offset: 0x00B0183A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoConfigData()
		{
		}
	}
}
