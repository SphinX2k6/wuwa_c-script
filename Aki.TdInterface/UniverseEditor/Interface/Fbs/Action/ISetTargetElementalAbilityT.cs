using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007086 RID: 28806
	public class ISetTargetElementalAbilityT
	{
		// Token: 0x1700D611 RID: 54801
		// (get) Token: 0x06033021 RID: 208929 RVA: 0x006E1783 File Offset: 0x006DF983
		// (set) Token: 0x06033022 RID: 208930 RVA: 0x006E178B File Offset: 0x006DF98B
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700D612 RID: 54802
		// (get) Token: 0x06033023 RID: 208931 RVA: 0x006E1794 File Offset: 0x006DF994
		// (set) Token: 0x06033024 RID: 208932 RVA: 0x006E179C File Offset: 0x006DF99C
		public EElementalType ElementalType { get; set; }

		// Token: 0x1700D613 RID: 54803
		// (get) Token: 0x06033025 RID: 208933 RVA: 0x006E17A5 File Offset: 0x006DF9A5
		// (set) Token: 0x06033026 RID: 208934 RVA: 0x006E17AD File Offset: 0x006DF9AD
		public EElementalOpType OpType { get; set; }

		// Token: 0x1700D614 RID: 54804
		// (get) Token: 0x06033027 RID: 208935 RVA: 0x006E17B6 File Offset: 0x006DF9B6
		// (set) Token: 0x06033028 RID: 208936 RVA: 0x006E17BE File Offset: 0x006DF9BE
		public int Priority { get; set; }

		// Token: 0x06033029 RID: 208937 RVA: 0x006E17C7 File Offset: 0x006DF9C7
		public ISetTargetElementalAbilityT()
		{
			this.Target = null;
			this.ElementalType = EElementalType.Fire;
			this.OpType = EElementalOpType.Grant;
			this.Priority = 0;
		}
	}
}
