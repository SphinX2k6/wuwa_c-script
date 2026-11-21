using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D35 RID: 7477
	public class ILiftMoveTypeTeleport : ILiftMoveType
	{
		// Token: 0x06009ECB RID: 40651 RVA: 0x0016D134 File Offset: 0x0016B334
		private ILiftMoveTypeTeleport_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiftMoveTypeTeleport 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiftMoveTypeTeleport_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiftMoveTypeTeleport_SetValue());
			}
			return result;
		}

		// Token: 0x06009ECC RID: 40652 RVA: 0x0016D16C File Offset: 0x0016B36C
		public static ILiftMoveTypeTeleport Create([Nullable(2)] ILiftMoveTypeTeleport instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveTypeTeleport
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009ECD RID: 40653 RVA: 0x0016D17F File Offset: 0x0016B37F
		public static ILiftMoveTypeTeleport CreateFromSetValue([Nullable(2)] ILiftMoveTypeTeleport_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiftMoveTypeTeleport
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009ECE RID: 40654 RVA: 0x0016D194 File Offset: 0x0016B394
		public new ILiftMoveTypeTeleport_SetValue ToSetValue()
		{
			return new ILiftMoveTypeTeleport_SetValue
			{
				Type = this.Type,
				StartTeleportOffsetDistance = this.StartTeleportOffsetDistance,
				EndTeleportOffsetDistance = this.EndTeleportOffsetDistance,
				SendTeleportEvent = this.SendTeleportEvent,
				TeleportStartEventOffsetDistance = this.TeleportStartEventOffsetDistance
			};
		}

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x06009ECF RID: 40655 RVA: 0x0016D1E2 File Offset: 0x0016B3E2
		// (set) Token: 0x06009ED0 RID: 40656 RVA: 0x0016D20D File Offset: 0x0016B40D
		public override ELiftMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiftMoveType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x06009ED1 RID: 40657 RVA: 0x0016D21B File Offset: 0x0016B41B
		// (set) Token: 0x06009ED2 RID: 40658 RVA: 0x0016D24A File Offset: 0x0016B44A
		public virtual float StartTeleportOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTeleportOffsetDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.StartTeleportOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().StartTeleportOffsetDistance = value;
			}
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x06009ED3 RID: 40659 RVA: 0x0016D258 File Offset: 0x0016B458
		// (set) Token: 0x06009ED4 RID: 40660 RVA: 0x0016D287 File Offset: 0x0016B487
		public virtual float EndTeleportOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndTeleportOffsetDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.EndTeleportOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().EndTeleportOffsetDistance = value;
			}
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x06009ED5 RID: 40661 RVA: 0x0016D295 File Offset: 0x0016B495
		// (set) Token: 0x06009ED6 RID: 40662 RVA: 0x0016D2C0 File Offset: 0x0016B4C0
		public virtual bool SendTeleportEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SendTeleportEvent;
				}
				return this.PocoInterface != null && this.PocoInterface.SendTeleportEvent;
			}
			set
			{
				this.GetOrCreatePoco().SendTeleportEvent = value;
			}
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x06009ED7 RID: 40663 RVA: 0x0016D2CE File Offset: 0x0016B4CE
		// (set) Token: 0x06009ED8 RID: 40664 RVA: 0x0016D2FD File Offset: 0x0016B4FD
		public virtual float TeleportStartEventOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeleportStartEventOffsetDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TeleportStartEventOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().TeleportStartEventOffsetDistance = value;
			}
		}

		// Token: 0x040060CB RID: 24779
		[Nullable(2)]
		protected new ILiftMoveTypeTeleport FbInstance;

		// Token: 0x040060CC RID: 24780
		[Nullable(2)]
		protected new ILiftMoveTypeTeleport_SetValue PocoInterface;
	}
}
