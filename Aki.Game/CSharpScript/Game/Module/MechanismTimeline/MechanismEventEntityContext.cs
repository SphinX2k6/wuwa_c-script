using System;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x0200445C RID: 17500
	public class MechanismEventEntityContext : MechanismEventContext
	{
		// Token: 0x0602C228 RID: 180776 RVA: 0x00C65462 File Offset: 0x00C63662
		public MechanismEventEntityContext(int entityId, long createDataId, int pbDataId)
		{
		}

		// Token: 0x17005824 RID: 22564
		// (get) Token: 0x0602C229 RID: 180777 RVA: 0x00C6547F File Offset: 0x00C6367F
		public override EMechanismEventContextType ContextType
		{
			get
			{
				return EMechanismEventContextType.Entity;
			}
		}

		// Token: 0x04017C48 RID: 97352
		public readonly int EntityId = entityId;

		// Token: 0x04017C49 RID: 97353
		public readonly long CreateDataId = createDataId;

		// Token: 0x04017C4A RID: 97354
		public readonly int PbDataId = pbDataId;
	}
}
