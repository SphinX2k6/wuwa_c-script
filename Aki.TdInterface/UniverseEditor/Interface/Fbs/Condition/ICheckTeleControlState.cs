using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005040 RID: 20544
	public struct ICheckTeleControlState : IFlatbufferObject
	{
		// Token: 0x170092FC RID: 37628
		// (get) Token: 0x06020195 RID: 131477 RVA: 0x00473F4E File Offset: 0x0047214E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020196 RID: 131478 RVA: 0x00473F5B File Offset: 0x0047215B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020197 RID: 131479 RVA: 0x00473F64 File Offset: 0x00472164
		public static ICheckTeleControlState GetRootAsICheckTeleControlState(ByteBuffer _bb)
		{
			return ICheckTeleControlState.GetRootAsICheckTeleControlState(_bb, default(ICheckTeleControlState));
		}

		// Token: 0x06020198 RID: 131480 RVA: 0x00473F80 File Offset: 0x00472180
		public static ICheckTeleControlState GetRootAsICheckTeleControlState(ByteBuffer _bb, ICheckTeleControlState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020199 RID: 131481 RVA: 0x00473F9D File Offset: 0x0047219D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602019A RID: 131482 RVA: 0x00473FAC File Offset: 0x004721AC
		public ICheckTeleControlState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092FD RID: 37629
		// (get) Token: 0x0602019B RID: 131483 RVA: 0x00473FBC File Offset: 0x004721BC
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170092FE RID: 37630
		// (get) Token: 0x0602019C RID: 131484 RVA: 0x00473FF8 File Offset: 0x004721F8
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170092FF RID: 37631
		// (get) Token: 0x0602019D RID: 131485 RVA: 0x00474034 File Offset: 0x00472234
		public ECompare CompareType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009300 RID: 37632
		// (get) Token: 0x0602019E RID: 131486 RVA: 0x00474070 File Offset: 0x00472270
		public ETeleControlState State
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ETeleControlState.Hold;
				}
				return (ETeleControlState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009301 RID: 37633
		// (get) Token: 0x0602019F RID: 131487 RVA: 0x004740B0 File Offset: 0x004722B0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060201A0 RID: 131488 RVA: 0x004740ED File Offset: 0x004722ED
		public static Offset<ICheckTeleControlState> CreateICheckTeleControlState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, ECompare CompareType = ECompare.Eq, ETeleControlState State = ETeleControlState.Hold, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICheckTeleControlState.AddEntityId(builder, EntityId);
			ICheckTeleControlState.AddNullMask(builder, NullMask);
			ICheckTeleControlState.AddState(builder, State);
			ICheckTeleControlState.AddCompareType(builder, CompareType);
			ICheckTeleControlState.AddType(builder, Type);
			return ICheckTeleControlState.EndICheckTeleControlState(builder);
		}

		// Token: 0x060201A1 RID: 131489 RVA: 0x00474121 File Offset: 0x00472321
		public static void StartICheckTeleControlState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060201A2 RID: 131490 RVA: 0x0047412A File Offset: 0x0047232A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060201A3 RID: 131491 RVA: 0x00474135 File Offset: 0x00472335
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060201A4 RID: 131492 RVA: 0x00474140 File Offset: 0x00472340
		public static void AddCompareType(FlatBufferBuilder builder, ECompare compareType)
		{
			builder.AddByte(2, (byte)compareType, 0);
		}

		// Token: 0x060201A5 RID: 131493 RVA: 0x0047414B File Offset: 0x0047234B
		public static void AddState(FlatBufferBuilder builder, ETeleControlState state)
		{
			builder.AddByte(3, (byte)state, 0);
		}

		// Token: 0x060201A6 RID: 131494 RVA: 0x00474156 File Offset: 0x00472356
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060201A7 RID: 131495 RVA: 0x00474161 File Offset: 0x00472361
		public static Offset<ICheckTeleControlState> EndICheckTeleControlState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTeleControlState>(builder.EndTable());
		}

		// Token: 0x060201A8 RID: 131496 RVA: 0x00474170 File Offset: 0x00472370
		public ICheckTeleControlStateT UnPack()
		{
			ICheckTeleControlStateT checkTeleControlStateT = new ICheckTeleControlStateT();
			this.UnPackTo(checkTeleControlStateT);
			return checkTeleControlStateT;
		}

		// Token: 0x060201A9 RID: 131497 RVA: 0x0047418B File Offset: 0x0047238B
		public void UnPackTo(ICheckTeleControlStateT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.CompareType = this.CompareType;
			_o.State = this.State;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060201AA RID: 131498 RVA: 0x004741CC File Offset: 0x004723CC
		public static Offset<ICheckTeleControlState> Pack(FlatBufferBuilder builder, ICheckTeleControlStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTeleControlState>);
			}
			return ICheckTeleControlState.CreateICheckTeleControlState(builder, _o.Type, _o.EntityId, _o.CompareType, _o.State, _o.NullMask);
		}

		// Token: 0x0400DF1A RID: 57114
		private Table __p;
	}
}
