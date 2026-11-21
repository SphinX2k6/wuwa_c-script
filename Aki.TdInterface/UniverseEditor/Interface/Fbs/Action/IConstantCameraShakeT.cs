using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B31 RID: 27441
	public class IConstantCameraShakeT
	{
		// Token: 0x1700C987 RID: 51591
		// (get) Token: 0x0602F37E RID: 193406 RVA: 0x00672B26 File Offset: 0x00670D26
		// (set) Token: 0x0602F37F RID: 193407 RVA: 0x00672B2E File Offset: 0x00670D2E
		public ECameraShakeType Type { get; set; }

		// Token: 0x0602F380 RID: 193408 RVA: 0x00672B37 File Offset: 0x00670D37
		public IConstantCameraShakeT()
		{
			this.Type = ECameraShakeType.Constant;
		}
	}
}
