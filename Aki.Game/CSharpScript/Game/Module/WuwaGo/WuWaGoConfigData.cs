using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200362E RID: 13870
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoConfigData : IWuWaGoLevelData
	{
		// Token: 0x17004949 RID: 18761
		// (get) Token: 0x06023FE6 RID: 147430 RVA: 0x00A332F9 File Offset: 0x00A314F9
		// (set) Token: 0x06023FE7 RID: 147431 RVA: 0x00A33301 File Offset: 0x00A31501
		[RequiredMember]
		public List<int> LevelEntityIds { get; set; }

		// Token: 0x06023FE8 RID: 147432 RVA: 0x00A3330A File Offset: 0x00A3150A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoConfigData()
		{
		}
	}
}
