using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C58 RID: 27736
	public class IOverrideLookAtTypeT
	{
		// Token: 0x1700CE96 RID: 52886
		// (get) Token: 0x06030DF5 RID: 200181 RVA: 0x006A36BA File Offset: 0x006A18BA
		// (set) Token: 0x06030DF6 RID: 200182 RVA: 0x006A36C2 File Offset: 0x006A18C2
		public EOverrideLookAtType Type { get; set; }

		// Token: 0x06030DF7 RID: 200183 RVA: 0x006A36CB File Offset: 0x006A18CB
		public IOverrideLookAtTypeT()
		{
			this.Type = EOverrideLookAtType.CheckFlowLookAt;
		}
	}
}
