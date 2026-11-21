using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063C4 RID: 25540
	[NullableContext(1)]
	public interface IFlowInfo
	{
		// Token: 0x170075A6 RID: 30118
		// (get) Token: 0x0603DF36 RID: 253750
		// (set) Token: 0x0603DF37 RID: 253751
		int Id { get; set; }

		// Token: 0x170075A7 RID: 30119
		// (get) Token: 0x0603DF38 RID: 253752
		// (set) Token: 0x0603DF39 RID: 253753
		string Name { get; set; }

		// Token: 0x170075A8 RID: 30120
		// (get) Token: 0x0603DF3A RID: 253754
		// (set) Token: 0x0603DF3B RID: 253755
		bool? _folded { get; set; }

		// Token: 0x170075A9 RID: 30121
		// (get) Token: 0x0603DF3C RID: 253756
		// (set) Token: 0x0603DF3D RID: 253757
		int StateGenId { get; set; }

		// Token: 0x170075AA RID: 30122
		// (get) Token: 0x0603DF3E RID: 253758
		// (set) Token: 0x0603DF3F RID: 253759
		IStateInfo[] States { get; set; }
	}
}
