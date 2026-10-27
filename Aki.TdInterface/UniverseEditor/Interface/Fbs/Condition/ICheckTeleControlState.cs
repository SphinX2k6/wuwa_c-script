using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B59 RID: 19289
	public struct ICheckTeleControlState : IFlatbufferObject
	{
		// Token: 0x17008BEC RID: 35820
		// (get) Token: 0x0601E607 RID: 124423 RVA: 0x00441702 File Offset: 0x0043F902
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E608 RID: 124424 RVA: 0x0044170F File Offset: 0x0043F90F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E609 RID: 124425 RVA: 0x00441718 File Offset: 0x0043F918
		public static ICheckTeleControlState GetRootAsICheckTeleControlState(ByteBuffer _bb)
		{
			return ICheckTeleControlState.GetRootAsICheckTeleControlState(_bb, default(ICheckTeleControlState));
		}

		// Token: 0x0601E60A RID: 124426 RVA: 0x00441734 File Offset: 0x0043F934
		public static ICheckTeleControlState GetRootAsICheckTeleControlState(ByteBuffer _bb, ICheckTeleControlState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E60B RID: 124427 RVA: 0x00441751 File Offset: 0x0043F951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E60C RID: 124428 RVA: 0x00441760 File Offset: 0x0043F960
		public ICheckTeleControlState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BED RID: 35821
		// (get) Token: 0x0601E60D RID: 124429 RVA: 0x00441770 File Offset: 0x0043F970
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

		// Token: 0x17008BEE RID: 35822
		// (get) Token: 0x0601E60E RID: 124430 RVA: 0x004417AC File Offset: 0x0043F9AC
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

		// Token: 0x17008BEF RID: 35823
		// (get) Token: 0x0601E60F RID: 124431 RVA: 0x004417E8 File Offset: 0x0043F9E8
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

		// Token: 0x17008BF0 RID: 35824
		// (get) Token: 0x0601E610 RID: 124432 RVA: 0x00441824 File Offset: 0x0043FA24
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

		// Token: 0x17008BF1 RID: 35825
		// (get) Token: 0x0601E611 RID: 124433 RVA: 0x00441864 File Offset: 0x0043FA64
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

		// Token: 0x0601E612 RID: 124434 RVA: 0x004418A1 File Offset: 0x0043FAA1
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

		// Token: 0x0601E613 RID: 124435 RVA: 0x004418D5 File Offset: 0x0043FAD5
		public static void StartICheckTeleControlState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601E614 RID: 124436 RVA: 0x004418DE File Offset: 0x0043FADE
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E615 RID: 124437 RVA: 0x004418E9 File Offset: 0x0043FAE9
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601E616 RID: 124438 RVA: 0x004418F4 File Offset: 0x0043FAF4
		public static void AddCompareType(FlatBufferBuilder builder, ECompare compareType)
		{
			builder.AddByte(2, (byte)compareType, 0);
		}

		// Token: 0x0601E617 RID: 124439 RVA: 0x004418FF File Offset: 0x0043FAFF
		public static void AddState(FlatBufferBuilder builder, ETeleControlState state)
		{
			builder.AddByte(3, (byte)state, 0);
		}

		// Token: 0x0601E618 RID: 124440 RVA: 0x0044190A File Offset: 0x0043FB0A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601E619 RID: 124441 RVA: 0x00441915 File Offset: 0x0043FB15
		public static Offset<ICheckTeleControlState> EndICheckTeleControlState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTeleControlState>(builder.EndTable());
		}

		// Token: 0x0601E61A RID: 124442 RVA: 0x00441924 File Offset: 0x0043FB24
		public ICheckTeleControlStateT UnPack()
		{
			ICheckTeleControlStateT checkTeleControlStateT = new ICheckTeleControlStateT();
			this.UnPackTo(checkTeleControlStateT);
			return checkTeleControlStateT;
		}

		// Token: 0x0601E61B RID: 124443 RVA: 0x0044193F File Offset: 0x0043FB3F
		public void UnPackTo(ICheckTeleControlStateT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.CompareType = this.CompareType;
			_o.State = this.State;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601E61C RID: 124444 RVA: 0x00441980 File Offset: 0x0043FB80
		public static Offset<ICheckTeleControlState> Pack(FlatBufferBuilder builder, ICheckTeleControlStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTeleControlState>);
			}
			return ICheckTeleControlState.CreateICheckTeleControlState(builder, _o.Type, _o.EntityId, _o.CompareType, _o.State, _o.NullMask);
		}

		// Token: 0x0400D41A RID: 54298
		private Table __p;
	}
}
