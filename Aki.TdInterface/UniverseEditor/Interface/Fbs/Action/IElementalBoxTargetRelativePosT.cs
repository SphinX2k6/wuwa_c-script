using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200663A RID: 26170
	public class IElementalBoxTargetRelativePosT
	{
		// Token: 0x1700C269 RID: 49769
		// (get) Token: 0x0602D727 RID: 186151 RVA: 0x00639AA7 File Offset: 0x00637CA7
		// (set) Token: 0x0602D728 RID: 186152 RVA: 0x00639AAF File Offset: 0x00637CAF
		public EElementalBoxTargetPosType Type { get; set; }

		// Token: 0x1700C26A RID: 49770
		// (get) Token: 0x0602D729 RID: 186153 RVA: 0x00639AB8 File Offset: 0x00637CB8
		// (set) Token: 0x0602D72A RID: 186154 RVA: 0x00639AC0 File Offset: 0x00637CC0
		public IVectorInfoT RelativePos { get; set; }

		// Token: 0x0602D72B RID: 186155 RVA: 0x00639AC9 File Offset: 0x00637CC9
		public IElementalBoxTargetRelativePosT()
		{
			this.Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
			this.RelativePos = null;
		}
	}
}
