using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A2B RID: 31275
	public struct ISwitchDataLayersTransitionWithSequence : IFlatbufferObject
	{
		// Token: 0x1700E524 RID: 58660
		// (get) Token: 0x060371B4 RID: 225716 RVA: 0x0075CF62 File Offset: 0x0075B162
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060371B5 RID: 225717 RVA: 0x0075CF6F File Offset: 0x0075B16F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060371B6 RID: 225718 RVA: 0x0075CF78 File Offset: 0x0075B178
		public static ISwitchDataLayersTransitionWithSequence GetRootAsISwitchDataLayersTransitionWithSequence(ByteBuffer _bb)
		{
			return ISwitchDataLayersTransitionWithSequence.GetRootAsISwitchDataLayersTransitionWithSequence(_bb, default(ISwitchDataLayersTransitionWithSequence));
		}

		// Token: 0x060371B7 RID: 225719 RVA: 0x0075CF94 File Offset: 0x0075B194
		public static ISwitchDataLayersTransitionWithSequence GetRootAsISwitchDataLayersTransitionWithSequence(ByteBuffer _bb, ISwitchDataLayersTransitionWithSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060371B8 RID: 225720 RVA: 0x0075CFB1 File Offset: 0x0075B1B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060371B9 RID: 225721 RVA: 0x0075CFC0 File Offset: 0x0075B1C0
		public ISwitchDataLayersTransitionWithSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E525 RID: 58661
		// (get) Token: 0x060371BA RID: 225722 RVA: 0x0075CFD0 File Offset: 0x0075B1D0
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

		// Token: 0x1700E526 RID: 58662
		// (get) Token: 0x060371BB RID: 225723 RVA: 0x0075D00C File Offset: 0x0075B20C
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

		// Token: 0x060371BC RID: 225724 RVA: 0x0075D043 File Offset: 0x0075B243
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060371BD RID: 225725 RVA: 0x0075D052 File Offset: 0x0075B252
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E527 RID: 58663
		// (get) Token: 0x060371BE RID: 225726 RVA: 0x0075D060 File Offset: 0x0075B260
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

		// Token: 0x060371BF RID: 225727 RVA: 0x0075D097 File Offset: 0x0075B297
		public Span<byte> GetSeqMarkBeforeModifyMatBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060371C0 RID: 225728 RVA: 0x0075D0A6 File Offset: 0x0075B2A6
		public byte[] GetSeqMarkBeforeModifyMatArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060371C1 RID: 225729 RVA: 0x0075D0B4 File Offset: 0x0075B2B4
		public static Offset<ISwitchDataLayersTransitionWithSequence> CreateISwitchDataLayersTransitionWithSequence(FlatBufferBuilder builder, ESwitchDataLayersTransitionType Type = ESwitchDataLayersTransitionType.Sequence, StringOffset SequencePathOffset = default(StringOffset), StringOffset SeqMarkBeforeModifyMatOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ISwitchDataLayersTransitionWithSequence.AddSeqMarkBeforeModifyMat(builder, SeqMarkBeforeModifyMatOffset);
			ISwitchDataLayersTransitionWithSequence.AddSequencePath(builder, SequencePathOffset);
			ISwitchDataLayersTransitionWithSequence.AddType(builder, Type);
			return ISwitchDataLayersTransitionWithSequence.EndISwitchDataLayersTransitionWithSequence(builder);
		}

		// Token: 0x060371C2 RID: 225730 RVA: 0x0075D0D8 File Offset: 0x0075B2D8
		public static void StartISwitchDataLayersTransitionWithSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060371C3 RID: 225731 RVA: 0x0075D0E1 File Offset: 0x0075B2E1
		public static void AddType(FlatBufferBuilder builder, ESwitchDataLayersTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060371C4 RID: 225732 RVA: 0x0075D0EC File Offset: 0x0075B2EC
		public static void AddSequencePath(FlatBufferBuilder builder, StringOffset sequencePathOffset)
		{
			builder.AddOffset(1, sequencePathOffset.Value, 0);
		}

		// Token: 0x060371C5 RID: 225733 RVA: 0x0075D0FC File Offset: 0x0075B2FC
		public static void AddSeqMarkBeforeModifyMat(FlatBufferBuilder builder, StringOffset seqMarkBeforeModifyMatOffset)
		{
			builder.AddOffset(2, seqMarkBeforeModifyMatOffset.Value, 0);
		}

		// Token: 0x060371C6 RID: 225734 RVA: 0x0075D10C File Offset: 0x0075B30C
		public static Offset<ISwitchDataLayersTransitionWithSequence> EndISwitchDataLayersTransitionWithSequence(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchDataLayersTransitionWithSequence>(builder.EndTable());
		}

		// Token: 0x060371C7 RID: 225735 RVA: 0x0075D11C File Offset: 0x0075B31C
		public ISwitchDataLayersTransitionWithSequenceT UnPack()
		{
			ISwitchDataLayersTransitionWithSequenceT switchDataLayersTransitionWithSequenceT = new ISwitchDataLayersTransitionWithSequenceT();
			this.UnPackTo(switchDataLayersTransitionWithSequenceT);
			return switchDataLayersTransitionWithSequenceT;
		}

		// Token: 0x060371C8 RID: 225736 RVA: 0x0075D137 File Offset: 0x0075B337
		public void UnPackTo(ISwitchDataLayersTransitionWithSequenceT _o)
		{
			_o.Type = this.Type;
			_o.SequencePath = this.SequencePath;
			_o.SeqMarkBeforeModifyMat = this.SeqMarkBeforeModifyMat;
		}

		// Token: 0x060371C9 RID: 225737 RVA: 0x0075D160 File Offset: 0x0075B360
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

		// Token: 0x04012D4E RID: 77134
		private Table __p;
	}
}
