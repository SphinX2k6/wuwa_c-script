using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C8A RID: 27786
	public struct IPerformerAiMoveToPosition : IFlatbufferObject
	{
		// Token: 0x1700CEEA RID: 52970
		// (get) Token: 0x06030F63 RID: 200547 RVA: 0x006A5C71 File Offset: 0x006A3E71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030F64 RID: 200548 RVA: 0x006A5C7E File Offset: 0x006A3E7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030F65 RID: 200549 RVA: 0x006A5C88 File Offset: 0x006A3E88
		public static IPerformerAiMoveToPosition GetRootAsIPerformerAiMoveToPosition(ByteBuffer _bb)
		{
			return IPerformerAiMoveToPosition.GetRootAsIPerformerAiMoveToPosition(_bb, default(IPerformerAiMoveToPosition));
		}

		// Token: 0x06030F66 RID: 200550 RVA: 0x006A5CA4 File Offset: 0x006A3EA4
		public static IPerformerAiMoveToPosition GetRootAsIPerformerAiMoveToPosition(ByteBuffer _bb, IPerformerAiMoveToPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030F67 RID: 200551 RVA: 0x006A5CC1 File Offset: 0x006A3EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030F68 RID: 200552 RVA: 0x006A5CD0 File Offset: 0x006A3ED0
		public IPerformerAiMoveToPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEEB RID: 52971
		// (get) Token: 0x06030F69 RID: 200553 RVA: 0x006A5CE0 File Offset: 0x006A3EE0
		public EPerformerAiMoveToType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiMoveToType.Position;
				}
				return (EPerformerAiMoveToType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEEC RID: 52972
		// (get) Token: 0x06030F6A RID: 200554 RVA: 0x006A5D1C File Offset: 0x006A3F1C
		public IVectorInfo? Destination
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06030F6B RID: 200555 RVA: 0x006A5D79 File Offset: 0x006A3F79
		public static Offset<IPerformerAiMoveToPosition> CreateIPerformerAiMoveToPosition(FlatBufferBuilder builder, EPerformerAiMoveToType Type = EPerformerAiMoveToType.Position, Offset<IVectorInfo> DestinationOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPerformerAiMoveToPosition.AddDestination(builder, DestinationOffset);
			IPerformerAiMoveToPosition.AddType(builder, Type);
			return IPerformerAiMoveToPosition.EndIPerformerAiMoveToPosition(builder);
		}

		// Token: 0x06030F6C RID: 200556 RVA: 0x006A5D96 File Offset: 0x006A3F96
		public static void StartIPerformerAiMoveToPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030F6D RID: 200557 RVA: 0x006A5D9F File Offset: 0x006A3F9F
		public static void AddType(FlatBufferBuilder builder, EPerformerAiMoveToType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030F6E RID: 200558 RVA: 0x006A5DAA File Offset: 0x006A3FAA
		public static void AddDestination(FlatBufferBuilder builder, Offset<IVectorInfo> destinationOffset)
		{
			builder.AddOffset(1, destinationOffset.Value, 0);
		}

		// Token: 0x06030F6F RID: 200559 RVA: 0x006A5DBA File Offset: 0x006A3FBA
		public static Offset<IPerformerAiMoveToPosition> EndIPerformerAiMoveToPosition(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiMoveToPosition>(builder.EndTable());
		}

		// Token: 0x06030F70 RID: 200560 RVA: 0x006A5DC8 File Offset: 0x006A3FC8
		public IPerformerAiMoveToPositionT UnPack()
		{
			IPerformerAiMoveToPositionT performerAiMoveToPositionT = new IPerformerAiMoveToPositionT();
			this.UnPackTo(performerAiMoveToPositionT);
			return performerAiMoveToPositionT;
		}

		// Token: 0x06030F71 RID: 200561 RVA: 0x006A5DE4 File Offset: 0x006A3FE4
		public void UnPackTo(IPerformerAiMoveToPositionT _o)
		{
			_o.Type = this.Type;
			_o.Destination = ((this.Destination != null) ? this.Destination.Value.UnPack() : null);
		}

		// Token: 0x06030F72 RID: 200562 RVA: 0x006A5E2C File Offset: 0x006A402C
		public static Offset<IPerformerAiMoveToPosition> Pack(FlatBufferBuilder builder, IPerformerAiMoveToPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiMoveToPosition>);
			}
			Offset<IVectorInfo> destinationOffset = (_o.Destination == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Destination);
			return IPerformerAiMoveToPosition.CreateIPerformerAiMoveToPosition(builder, _o.Type, destinationOffset);
		}

		// Token: 0x040115DE RID: 71134
		private Table __p;
	}
}
