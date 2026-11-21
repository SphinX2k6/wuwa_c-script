using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070BB RID: 28859
	public struct ILiftMoveTypeTeleport : IFlatbufferObject
	{
		// Token: 0x1700D367 RID: 54119
		// (get) Token: 0x060321C9 RID: 205257 RVA: 0x006C81E9 File Offset: 0x006C63E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060321CA RID: 205258 RVA: 0x006C81F6 File Offset: 0x006C63F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060321CB RID: 205259 RVA: 0x006C8200 File Offset: 0x006C6400
		public static ILiftMoveTypeTeleport GetRootAsILiftMoveTypeTeleport(ByteBuffer _bb)
		{
			return ILiftMoveTypeTeleport.GetRootAsILiftMoveTypeTeleport(_bb, default(ILiftMoveTypeTeleport));
		}

		// Token: 0x060321CC RID: 205260 RVA: 0x006C821C File Offset: 0x006C641C
		public static ILiftMoveTypeTeleport GetRootAsILiftMoveTypeTeleport(ByteBuffer _bb, ILiftMoveTypeTeleport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060321CD RID: 205261 RVA: 0x006C8239 File Offset: 0x006C6439
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060321CE RID: 205262 RVA: 0x006C8248 File Offset: 0x006C6448
		public ILiftMoveTypeTeleport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D368 RID: 54120
		// (get) Token: 0x060321CF RID: 205263 RVA: 0x006C8258 File Offset: 0x006C6458
		public ELiftMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiftMoveType.Default;
				}
				return (ELiftMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D369 RID: 54121
		// (get) Token: 0x060321D0 RID: 205264 RVA: 0x006C8294 File Offset: 0x006C6494
		public float StartTeleportOffsetDistance
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D36A RID: 54122
		// (get) Token: 0x060321D1 RID: 205265 RVA: 0x006C82D4 File Offset: 0x006C64D4
		public float EndTeleportOffsetDistance
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D36B RID: 54123
		// (get) Token: 0x060321D2 RID: 205266 RVA: 0x006C8314 File Offset: 0x006C6514
		public bool SendTeleportEvent
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D36C RID: 54124
		// (get) Token: 0x060321D3 RID: 205267 RVA: 0x006C8354 File Offset: 0x006C6554
		public float TeleportStartEventOffsetDistance
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060321D4 RID: 205268 RVA: 0x006C8395 File Offset: 0x006C6595
		public static Offset<ILiftMoveTypeTeleport> CreateILiftMoveTypeTeleport(FlatBufferBuilder builder, ELiftMoveType Type = ELiftMoveType.Default, float StartTeleportOffsetDistance = 0f, float EndTeleportOffsetDistance = 0f, bool SendTeleportEvent = false, float TeleportStartEventOffsetDistance = 0f)
		{
			builder.StartTable(5);
			ILiftMoveTypeTeleport.AddTeleportStartEventOffsetDistance(builder, TeleportStartEventOffsetDistance);
			ILiftMoveTypeTeleport.AddEndTeleportOffsetDistance(builder, EndTeleportOffsetDistance);
			ILiftMoveTypeTeleport.AddStartTeleportOffsetDistance(builder, StartTeleportOffsetDistance);
			ILiftMoveTypeTeleport.AddSendTeleportEvent(builder, SendTeleportEvent);
			ILiftMoveTypeTeleport.AddType(builder, Type);
			return ILiftMoveTypeTeleport.EndILiftMoveTypeTeleport(builder);
		}

		// Token: 0x060321D5 RID: 205269 RVA: 0x006C83C9 File Offset: 0x006C65C9
		public static void StartILiftMoveTypeTeleport(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060321D6 RID: 205270 RVA: 0x006C83D2 File Offset: 0x006C65D2
		public static void AddType(FlatBufferBuilder builder, ELiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060321D7 RID: 205271 RVA: 0x006C83DD File Offset: 0x006C65DD
		public static void AddStartTeleportOffsetDistance(FlatBufferBuilder builder, float startTeleportOffsetDistance)
		{
			builder.AddFloat(1, startTeleportOffsetDistance, 0.0);
		}

		// Token: 0x060321D8 RID: 205272 RVA: 0x006C83F0 File Offset: 0x006C65F0
		public static void AddEndTeleportOffsetDistance(FlatBufferBuilder builder, float endTeleportOffsetDistance)
		{
			builder.AddFloat(2, endTeleportOffsetDistance, 0.0);
		}

		// Token: 0x060321D9 RID: 205273 RVA: 0x006C8403 File Offset: 0x006C6603
		public static void AddSendTeleportEvent(FlatBufferBuilder builder, bool sendTeleportEvent)
		{
			builder.AddBool(3, sendTeleportEvent, false);
		}

		// Token: 0x060321DA RID: 205274 RVA: 0x006C840E File Offset: 0x006C660E
		public static void AddTeleportStartEventOffsetDistance(FlatBufferBuilder builder, float teleportStartEventOffsetDistance)
		{
			builder.AddFloat(4, teleportStartEventOffsetDistance, 0.0);
		}

		// Token: 0x060321DB RID: 205275 RVA: 0x006C8421 File Offset: 0x006C6621
		public static Offset<ILiftMoveTypeTeleport> EndILiftMoveTypeTeleport(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveTypeTeleport>(builder.EndTable());
		}

		// Token: 0x060321DC RID: 205276 RVA: 0x006C8430 File Offset: 0x006C6630
		public ILiftMoveTypeTeleportT UnPack()
		{
			ILiftMoveTypeTeleportT liftMoveTypeTeleportT = new ILiftMoveTypeTeleportT();
			this.UnPackTo(liftMoveTypeTeleportT);
			return liftMoveTypeTeleportT;
		}

		// Token: 0x060321DD RID: 205277 RVA: 0x006C844B File Offset: 0x006C664B
		public void UnPackTo(ILiftMoveTypeTeleportT _o)
		{
			_o.Type = this.Type;
			_o.StartTeleportOffsetDistance = this.StartTeleportOffsetDistance;
			_o.EndTeleportOffsetDistance = this.EndTeleportOffsetDistance;
			_o.SendTeleportEvent = this.SendTeleportEvent;
			_o.TeleportStartEventOffsetDistance = this.TeleportStartEventOffsetDistance;
		}

		// Token: 0x060321DE RID: 205278 RVA: 0x006C848C File Offset: 0x006C668C
		public static Offset<ILiftMoveTypeTeleport> Pack(FlatBufferBuilder builder, ILiftMoveTypeTeleportT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveTypeTeleport>);
			}
			return ILiftMoveTypeTeleport.CreateILiftMoveTypeTeleport(builder, _o.Type, _o.StartTeleportOffsetDistance, _o.EndTeleportOffsetDistance, _o.SendTeleportEvent, _o.TeleportStartEventOffsetDistance);
		}

		// Token: 0x04012074 RID: 73844
		private Table __p;
	}
}
