using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002830 RID: 10288
	public class ILiftMoveTypeTeleport : ILiftMoveType
	{
		// Token: 0x0600E421 RID: 58401 RVA: 0x002197CA File Offset: 0x002179CA
		[NullableContext(1)]
		public static ILiftMoveTypeTeleport Create(ILiftMoveTypeTeleport? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveTypeTeleport
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004583 RID: 17795
		// (get) Token: 0x0600E422 RID: 58402 RVA: 0x002197E9 File Offset: 0x002179E9
		public override ELiftMoveType Type
		{
			get
			{
				return (ELiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x17004584 RID: 17796
		// (get) Token: 0x0600E423 RID: 58403 RVA: 0x002197F6 File Offset: 0x002179F6
		public virtual float StartTeleportOffsetDistance
		{
			get
			{
				return this.Instance.StartTeleportOffsetDistance;
			}
		}

		// Token: 0x17004585 RID: 17797
		// (get) Token: 0x0600E424 RID: 58404 RVA: 0x00219803 File Offset: 0x00217A03
		public virtual float EndTeleportOffsetDistance
		{
			get
			{
				return this.Instance.EndTeleportOffsetDistance;
			}
		}

		// Token: 0x17004586 RID: 17798
		// (get) Token: 0x0600E425 RID: 58405 RVA: 0x00219810 File Offset: 0x00217A10
		public virtual bool SendTeleportEvent
		{
			get
			{
				return this.Instance.SendTeleportEvent;
			}
		}

		// Token: 0x17004587 RID: 17799
		// (get) Token: 0x0600E426 RID: 58406 RVA: 0x0021981D File Offset: 0x00217A1D
		public virtual float TeleportStartEventOffsetDistance
		{
			get
			{
				return this.Instance.TeleportStartEventOffsetDistance;
			}
		}

		// Token: 0x04007E3E RID: 32318
		private ILiftMoveTypeTeleport Instance;
	}
}
