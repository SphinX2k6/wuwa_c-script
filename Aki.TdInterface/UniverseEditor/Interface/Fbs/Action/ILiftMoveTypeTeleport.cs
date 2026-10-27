using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A0B RID: 27147
	public struct ILiftMoveTypeTeleport : IFlatbufferObject
	{
		// Token: 0x1700C967 RID: 51559
		// (get) Token: 0x0602F809 RID: 194569 RVA: 0x00677E91 File Offset: 0x00676091
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F80A RID: 194570 RVA: 0x00677E9E File Offset: 0x0067609E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F80B RID: 194571 RVA: 0x00677EA8 File Offset: 0x006760A8
		public static ILiftMoveTypeTeleport GetRootAsILiftMoveTypeTeleport(ByteBuffer _bb)
		{
			return ILiftMoveTypeTeleport.GetRootAsILiftMoveTypeTeleport(_bb, default(ILiftMoveTypeTeleport));
		}

		// Token: 0x0602F80C RID: 194572 RVA: 0x00677EC4 File Offset: 0x006760C4
		public static ILiftMoveTypeTeleport GetRootAsILiftMoveTypeTeleport(ByteBuffer _bb, ILiftMoveTypeTeleport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F80D RID: 194573 RVA: 0x00677EE1 File Offset: 0x006760E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F80E RID: 194574 RVA: 0x00677EF0 File Offset: 0x006760F0
		public ILiftMoveTypeTeleport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C968 RID: 51560
		// (get) Token: 0x0602F80F RID: 194575 RVA: 0x00677F00 File Offset: 0x00676100
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

		// Token: 0x1700C969 RID: 51561
		// (get) Token: 0x0602F810 RID: 194576 RVA: 0x00677F3C File Offset: 0x0067613C
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

		// Token: 0x1700C96A RID: 51562
		// (get) Token: 0x0602F811 RID: 194577 RVA: 0x00677F7C File Offset: 0x0067617C
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

		// Token: 0x1700C96B RID: 51563
		// (get) Token: 0x0602F812 RID: 194578 RVA: 0x00677FBC File Offset: 0x006761BC
		public bool SendTeleportEvent
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C96C RID: 51564
		// (get) Token: 0x0602F813 RID: 194579 RVA: 0x00677FFC File Offset: 0x006761FC
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

		// Token: 0x0602F814 RID: 194580 RVA: 0x0067803D File Offset: 0x0067623D
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

		// Token: 0x0602F815 RID: 194581 RVA: 0x00678071 File Offset: 0x00676271
		public static void StartILiftMoveTypeTeleport(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602F816 RID: 194582 RVA: 0x0067807A File Offset: 0x0067627A
		public static void AddType(FlatBufferBuilder builder, ELiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F817 RID: 194583 RVA: 0x00678085 File Offset: 0x00676285
		public static void AddStartTeleportOffsetDistance(FlatBufferBuilder builder, float startTeleportOffsetDistance)
		{
			builder.AddFloat(1, startTeleportOffsetDistance, 0.0);
		}

		// Token: 0x0602F818 RID: 194584 RVA: 0x00678098 File Offset: 0x00676298
		public static void AddEndTeleportOffsetDistance(FlatBufferBuilder builder, float endTeleportOffsetDistance)
		{
			builder.AddFloat(2, endTeleportOffsetDistance, 0.0);
		}

		// Token: 0x0602F819 RID: 194585 RVA: 0x006780AB File Offset: 0x006762AB
		public static void AddSendTeleportEvent(FlatBufferBuilder builder, bool sendTeleportEvent)
		{
			builder.AddBool(3, sendTeleportEvent, false);
		}

		// Token: 0x0602F81A RID: 194586 RVA: 0x006780B6 File Offset: 0x006762B6
		public static void AddTeleportStartEventOffsetDistance(FlatBufferBuilder builder, float teleportStartEventOffsetDistance)
		{
			builder.AddFloat(4, teleportStartEventOffsetDistance, 0.0);
		}

		// Token: 0x0602F81B RID: 194587 RVA: 0x006780C9 File Offset: 0x006762C9
		public static Offset<ILiftMoveTypeTeleport> EndILiftMoveTypeTeleport(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveTypeTeleport>(builder.EndTable());
		}

		// Token: 0x0602F81C RID: 194588 RVA: 0x006780D8 File Offset: 0x006762D8
		public ILiftMoveTypeTeleportT UnPack()
		{
			ILiftMoveTypeTeleportT liftMoveTypeTeleportT = new ILiftMoveTypeTeleportT();
			this.UnPackTo(liftMoveTypeTeleportT);
			return liftMoveTypeTeleportT;
		}

		// Token: 0x0602F81D RID: 194589 RVA: 0x006780F3 File Offset: 0x006762F3
		public void UnPackTo(ILiftMoveTypeTeleportT _o)
		{
			_o.Type = this.Type;
			_o.StartTeleportOffsetDistance = this.StartTeleportOffsetDistance;
			_o.EndTeleportOffsetDistance = this.EndTeleportOffsetDistance;
			_o.SendTeleportEvent = this.SendTeleportEvent;
			_o.TeleportStartEventOffsetDistance = this.TeleportStartEventOffsetDistance;
		}

		// Token: 0x0602F81E RID: 194590 RVA: 0x00678134 File Offset: 0x00676334
		public static Offset<ILiftMoveTypeTeleport> Pack(FlatBufferBuilder builder, ILiftMoveTypeTeleportT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveTypeTeleport>);
			}
			return ILiftMoveTypeTeleport.CreateILiftMoveTypeTeleport(builder, _o.Type, _o.StartTeleportOffsetDistance, _o.EndTeleportOffsetDistance, _o.SendTeleportEvent, _o.TeleportStartEventOffsetDistance);
		}

		// Token: 0x0401120A RID: 70154
		private Table __p;
	}
}
