using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200795A RID: 31066
	public class ISplineMoveMontageTypeT
	{
		// Token: 0x1700E3D3 RID: 58323
		// (get) Token: 0x06036B5C RID: 224092 RVA: 0x00751E1E File Offset: 0x0075001E
		// (set) Token: 0x06036B5D RID: 224093 RVA: 0x00751E26 File Offset: 0x00750026
		public ESplineMoveMontageType Type { get; set; }

		// Token: 0x06036B5E RID: 224094 RVA: 0x00751E2F File Offset: 0x0075002F
		public ISplineMoveMontageTypeT()
		{
			this.Type = ESplineMoveMontageType.ThreeStageMontage;
		}
	}
}
