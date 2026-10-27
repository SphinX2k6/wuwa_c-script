using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007256 RID: 29270
	public struct ISwitchDataLayersTransitionWithSequence : IFlatbufferObject
	{
		// Token: 0x1700D92B RID: 55595
		// (get) Token: 0x06033EB2 RID: 212658 RVA: 0x006FBC02 File Offset: 0x006F9E02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033EB3 RID: 212659 RVA: 0x006FBC0F File Offset: 0x006F9E0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033EB4 RID: 212660 RVA: 0x006FBC18 File Offset: 0x006F9E18
		public static ISwitchDataLayersTransitionWithSequence GetRootAsISwitchDataLayersTransitionWithSequence(ByteBuffer _bb)
		{
			return ISwitchDataLayersTransitionWithSequence.GetRootAsISwitchDataLayersTransitionWithSequence(_bb, default(ISwitchDataLayersTransitionWithSequence));
		}

		// Token: 0x06033EB5 RID: 212661 RVA: 0x006FBC34 File Offset: 0x006F9E34
		public static ISwitchDataLayersTransitionWithSequence GetRootAsISwitchDataLayersTransitionWithSequence(ByteBuffer _bb, ISwitchDataLayersTransitionWithSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033EB6 RID: 212662 RVA: 0x006FBC51 File Offset: 0x006F9E51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033EB7 RID: 212663 RVA: 0x006FBC60 File Offset: 0x006F9E60
		public ISwitchDataLayersTransitionWithSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D92C RID: 55596
		// (get) Token: 0x06033EB8 RID: 212664 RVA: 0x006FBC70 File Offset: 0x006F9E70
		public ESwitchDataLayersTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESwitchDataLayersTransitionType.Sequence;
				}
				return (ESwitchDataLayersTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D92D RID: 55597
		// (get) Token: 0x06033EB9 RID: 212665 RVA: 0x006FBCAC File Offset: 0x006F9EAC
		public string SequencePath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033EBA RID: 212666 RVA: 0x006FBCE3 File Offset: 0x006F9EE3
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033EBB RID: 212667 RVA: 0x006FBCF2 File Offset: 0x006F9EF2
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D92E RID: 55598
		// (get) Token: 0x06033EBC RID: 212668 RVA: 0x006FBD00 File Offset: 0x006F9F00
		public string SeqMarkBeforeModifyMat
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033EBD RID: 212669 RVA: 0x006FBD37 File Offset: 0x006F9F37
		public Span<byte> GetSeqMarkBeforeModifyMatBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06033EBE RID: 212670 RVA: 0x006FBD46 File Offset: 0x006F9F46
		public byte[] GetSeqMarkBeforeModifyMatArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06033EBF RID: 212671 RVA: 0x006FBD54 File Offset: 0x006F9F54
		public static Offset<ISwitchDataLayersTransitionWithSequence> CreateISwitchDataLayersTransitionWithSequence(FlatBufferBuilder builder, ESwitchDataLayersTransitionType Type = ESwitchDataLayersTransitionType.Sequence, StringOffset SequencePathOffset = default(StringOffset), StringOffset SeqMarkBeforeModifyMatOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ISwitchDataLayersTransitionWithSequence.AddSeqMarkBeforeModifyMat(builder, SeqMarkBeforeModifyMatOffset);
			ISwitchDataLayersTransitionWithSequence.AddSequencePath(builder, SequencePathOffset);
			ISwitchDataLayersTransitionWithSequence.AddType(builder, Type);
			return ISwitchDataLayersTransitionWithSequence.EndISwitchDataLayersTransitionWithSequence(builder);
		}

		// Token: 0x06033EC0 RID: 212672 RVA: 0x006FBD78 File Offset: 0x006F9F78
		public static void StartISwitchDataLayersTransitionWithSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033EC1 RID: 212673 RVA: 0x006FBD81 File Offset: 0x006F9F81
		public static void AddType(FlatBufferBuilder builder, ESwitchDataLayersTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033EC2 RID: 212674 RVA: 0x006FBD8C File Offset: 0x006F9F8C
		public static void AddSequencePath(FlatBufferBuilder builder, StringOffset sequencePathOffset)
		{
			builder.AddOffset(1, sequencePathOffset.Value, 0);
		}

		// Token: 0x06033EC3 RID: 212675 RVA: 0x006FBD9C File Offset: 0x006F9F9C
		public static void AddSeqMarkBeforeModifyMat(FlatBufferBuilder builder, StringOffset seqMarkBeforeModifyMatOffset)
		{
			builder.AddOffset(2, seqMarkBeforeModifyMatOffset.Value, 0);
		}

		// Token: 0x06033EC4 RID: 212676 RVA: 0x006FBDAC File Offset: 0x006F9FAC
		public static Offset<ISwitchDataLayersTransitionWithSequence> EndISwitchDataLayersTransitionWithSequence(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchDataLayersTransitionWithSequence>(builder.EndTable());
		}

		// Token: 0x06033EC5 RID: 212677 RVA: 0x006FBDBC File Offset: 0x006F9FBC
		public ISwitchDataLayersTransitionWithSequenceT UnPack()
		{
			ISwitchDataLayersTransitionWithSequenceT switchDataLayersTransitionWithSequenceT = new ISwitchDataLayersTransitionWithSequenceT();
			this.UnPackTo(switchDataLayersTransitionWithSequenceT);
			return switchDataLayersTransitionWithSequenceT;
		}

		// Token: 0x06033EC6 RID: 212678 RVA: 0x006FBDD7 File Offset: 0x006F9FD7
		public void UnPackTo(ISwitchDataLayersTransitionWithSequenceT _o)
		{
			_o.Type = this.Type;
			_o.SequencePath = this.SequencePath;
			_o.SeqMarkBeforeModifyMat = this.SeqMarkBeforeModifyMat;
		}

		// Token: 0x06033EC7 RID: 212679 RVA: 0x006FBE00 File Offset: 0x006FA000
		public static Offset<ISwitchDataLayersTransitionWithSequence> Pack(FlatBufferBuilder builder, ISwitchDataLayersTransitionWithSequenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchDataLayersTransitionWithSequence>);
			}
			StringOffset sequencePathOffset = (_o.SequencePath == null) ? default(StringOffset) : builder.CreateString(_o.SequencePath);
			StringOffset seqMarkBeforeModifyMatOffset = (_o.SeqMarkBeforeModifyMat == null) ? default(StringOffset) : builder.CreateString(_o.SeqMarkBeforeModifyMat);
			return ISwitchDataLayersTransitionWithSequence.CreateISwitchDataLayersTransitionWithSequence(builder, _o.Type, sequencePathOffset, seqMarkBeforeModifyMatOffset);
		}

		// Token: 0x04011D4C RID: 73036
		private Table __p;
	}
}
