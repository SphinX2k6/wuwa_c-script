using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F1 RID: 29681
	public struct IPerformerAiMoveToPosition : IFlatbufferObject
	{
		// Token: 0x1700DA05 RID: 55813
		// (get) Token: 0x06033EBE RID: 212670 RVA: 0x00700171 File Offset: 0x006FE371
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033EBF RID: 212671 RVA: 0x0070017E File Offset: 0x006FE37E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033EC0 RID: 212672 RVA: 0x00700188 File Offset: 0x006FE388
		public static IPerformerAiMoveToPosition GetRootAsIPerformerAiMoveToPosition(ByteBuffer _bb)
		{
			return IPerformerAiMoveToPosition.GetRootAsIPerformerAiMoveToPosition(_bb, default(IPerformerAiMoveToPosition));
		}

		// Token: 0x06033EC1 RID: 212673 RVA: 0x007001A4 File Offset: 0x006FE3A4
		public static IPerformerAiMoveToPosition GetRootAsIPerformerAiMoveToPosition(ByteBuffer _bb, IPerformerAiMoveToPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033EC2 RID: 212674 RVA: 0x007001C1 File Offset: 0x006FE3C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033EC3 RID: 212675 RVA: 0x007001D0 File Offset: 0x006FE3D0
		public IPerformerAiMoveToPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA06 RID: 55814
		// (get) Token: 0x06033EC4 RID: 212676 RVA: 0x007001E0 File Offset: 0x006FE3E0
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

		// Token: 0x1700DA07 RID: 55815
		// (get) Token: 0x06033EC5 RID: 212677 RVA: 0x0070021C File Offset: 0x006FE41C
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

		// Token: 0x06033EC6 RID: 212678 RVA: 0x00700279 File Offset: 0x006FE479
		public static Offset<IPerformerAiMoveToPosition> CreateIPerformerAiMoveToPosition(FlatBufferBuilder builder, EPerformerAiMoveToType Type = EPerformerAiMoveToType.Position, Offset<IVectorInfo> DestinationOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPerformerAiMoveToPosition.AddDestination(builder, DestinationOffset);
			IPerformerAiMoveToPosition.AddType(builder, Type);
			return IPerformerAiMoveToPosition.EndIPerformerAiMoveToPosition(builder);
		}

		// Token: 0x06033EC7 RID: 212679 RVA: 0x00700296 File Offset: 0x006FE496
		public static void StartIPerformerAiMoveToPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033EC8 RID: 212680 RVA: 0x0070029F File Offset: 0x006FE49F
		public static void AddType(FlatBufferBuilder builder, EPerformerAiMoveToType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033EC9 RID: 212681 RVA: 0x007002AA File Offset: 0x006FE4AA
		public static void AddDestination(FlatBufferBuilder builder, Offset<IVectorInfo> destinationOffset)
		{
			builder.AddOffset(1, destinationOffset.Value, 0);
		}

		// Token: 0x06033ECA RID: 212682 RVA: 0x007002BA File Offset: 0x006FE4BA
		public static Offset<IPerformerAiMoveToPosition> EndIPerformerAiMoveToPosition(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiMoveToPosition>(builder.EndTable());
		}

		// Token: 0x06033ECB RID: 212683 RVA: 0x007002C8 File Offset: 0x006FE4C8
		public IPerformerAiMoveToPositionT UnPack()
		{
			IPerformerAiMoveToPositionT performerAiMoveToPositionT = new IPerformerAiMoveToPositionT();
			this.UnPackTo(performerAiMoveToPositionT);
			return performerAiMoveToPositionT;
		}

		// Token: 0x06033ECC RID: 212684 RVA: 0x007002E4 File Offset: 0x006FE4E4
		public void UnPackTo(IPerformerAiMoveToPositionT _o)
		{
			_o.Type = this.Type;
			_o.Destination = ((this.Destination != null) ? this.Destination.Value.UnPack() : null);
		}

		// Token: 0x06033ECD RID: 212685 RVA: 0x0070032C File Offset: 0x006FE52C
		public static Offset<IPerformerAiMoveToPosition> Pack(FlatBufferBuilder builder, IPerformerAiMoveToPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiMoveToPosition>);
			}
			Offset<IVectorInfo> destinationOffset = (_o.Destination == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Destination);
			return IPerformerAiMoveToPosition.CreateIPerformerAiMoveToPosition(builder, _o.Type, destinationOffset);
		}

		// Token: 0x04012536 RID: 75062
		private Table __p;
	}
}
