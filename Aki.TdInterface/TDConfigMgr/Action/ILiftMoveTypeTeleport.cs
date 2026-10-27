using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B88 RID: 7048
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftMoveTypeTeleport : ILiftMoveType
	{
		// Token: 0x060096E9 RID: 38633 RVA: 0x0015C588 File Offset: 0x0015A788
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

		// Token: 0x060096EA RID: 38634 RVA: 0x0015C5C0 File Offset: 0x0015A7C0
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

		// Token: 0x060096EB RID: 38635 RVA: 0x0015C5D3 File Offset: 0x0015A7D3
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

		// Token: 0x060096EC RID: 38636 RVA: 0x0015C5E8 File Offset: 0x0015A7E8
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

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x060096ED RID: 38637 RVA: 0x0015C636 File Offset: 0x0015A836
		// (set) Token: 0x060096EE RID: 38638 RVA: 0x0015C661 File Offset: 0x0015A861
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

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x060096EF RID: 38639 RVA: 0x0015C66F File Offset: 0x0015A86F
		// (set) Token: 0x060096F0 RID: 38640 RVA: 0x0015C69E File Offset: 0x0015A89E
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

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x060096F1 RID: 38641 RVA: 0x0015C6AC File Offset: 0x0015A8AC
		// (set) Token: 0x060096F2 RID: 38642 RVA: 0x0015C6DB File Offset: 0x0015A8DB
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

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x060096F3 RID: 38643 RVA: 0x0015C6E9 File Offset: 0x0015A8E9
		// (set) Token: 0x060096F4 RID: 38644 RVA: 0x0015C714 File Offset: 0x0015A914
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

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x060096F5 RID: 38645 RVA: 0x0015C722 File Offset: 0x0015A922
		// (set) Token: 0x060096F6 RID: 38646 RVA: 0x0015C751 File Offset: 0x0015A951
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

		// Token: 0x04005C32 RID: 23602
		[Nullable(2)]
		protected new ILiftMoveTypeTeleport FbInstance;

		// Token: 0x04005C33 RID: 23603
		[Nullable(2)]
		protected new ILiftMoveTypeTeleport_SetValue PocoInterface;
	}
}
