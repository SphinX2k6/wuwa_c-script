using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B28 RID: 27432
	public class IMotorRadioOperationRestrictionT
	{
		// Token: 0x1700CBE1 RID: 52193
		// (get) Token: 0x0603026B RID: 197227 RVA: 0x0068B7DE File Offset: 0x006899DE
		// (set) Token: 0x0603026C RID: 197228 RVA: 0x0068B7E6 File Offset: 0x006899E6
		public EMotorRadioOperationType Type { get; set; }

		// Token: 0x0603026D RID: 197229 RVA: 0x0068B7EF File Offset: 0x006899EF
		public IMotorRadioOperationRestrictionT()
		{
			this.Type = EMotorRadioOperationType.EnableAll;
		}
	}
}
