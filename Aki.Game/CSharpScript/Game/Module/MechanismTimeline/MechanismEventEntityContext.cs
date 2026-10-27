using System;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x02005479 RID: 21625
	public class MechanismEventEntityContext : MechanismEventContext
	{
		// Token: 0x060372DF RID: 226015 RVA: 0x00D1600A File Offset: 0x00D1420A
		public MechanismEventEntityContext(int entityId, long createDataId, int pbDataId)
		{
		}

		// Token: 0x17008458 RID: 33880
		// (get) Token: 0x060372E0 RID: 226016 RVA: 0x00D16027 File Offset: 0x00D14227
		public override EMechanismEventContextType ContextType
		{
			get
			{
				return EMechanismEventContextType.Entity;
			}
		}

		// Token: 0x0401D1AF RID: 119215
		public readonly int EntityId = entityId;

		// Token: 0x0401D1B0 RID: 119216
		public readonly long CreateDataId = createDataId;

		// Token: 0x0401D1B1 RID: 119217
		public readonly int PbDataId = pbDataId;
	}
}
