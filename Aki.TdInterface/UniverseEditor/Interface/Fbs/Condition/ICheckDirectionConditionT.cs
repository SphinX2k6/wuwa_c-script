using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E88 RID: 20104
	public class ICheckDirectionConditionT
	{
		// Token: 0x17008F62 RID: 36706
		// (get) Token: 0x0601F251 RID: 127569 RVA: 0x004581B9 File Offset: 0x004563B9
		// (set) Token: 0x0601F252 RID: 127570 RVA: 0x004581C1 File Offset: 0x004563C1
		public ECondition Type { get; set; }

		// Token: 0x17008F63 RID: 36707
		// (get) Token: 0x0601F253 RID: 127571 RVA: 0x004581CA File Offset: 0x004563CA
		// (set) Token: 0x0601F254 RID: 127572 RVA: 0x004581D2 File Offset: 0x004563D2
		public IVectorInfoT Direction { get; set; }

		// Token: 0x17008F64 RID: 36708
		// (get) Token: 0x0601F255 RID: 127573 RVA: 0x004581DB File Offset: 0x004563DB
		// (set) Token: 0x0601F256 RID: 127574 RVA: 0x004581E3 File Offset: 0x004563E3
		public int AngleInterval { get; set; }

		// Token: 0x0601F257 RID: 127575 RVA: 0x004581EC File Offset: 0x004563EC
		public ICheckDirectionConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Direction = null;
			this.AngleInterval = 0;
		}
	}
}
