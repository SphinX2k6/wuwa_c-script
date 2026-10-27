using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004187 RID: 16775
	public struct ITakePhoto2SequenceCondition : IFlatbufferObject
	{
		// Token: 0x170076EB RID: 30443
		// (get) Token: 0x06018AB1 RID: 101041 RVA: 0x0038DA61 File Offset: 0x0038BC61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018AB2 RID: 101042 RVA: 0x0038DA6E File Offset: 0x0038BC6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018AB3 RID: 101043 RVA: 0x0038DA78 File Offset: 0x0038BC78
		public static ITakePhoto2SequenceCondition GetRootAsITakePhoto2SequenceCondition(ByteBuffer _bb)
		{
			return ITakePhoto2SequenceCondition.GetRootAsITakePhoto2SequenceCondition(_bb, default(ITakePhoto2SequenceCondition));
		}

		// Token: 0x06018AB4 RID: 101044 RVA: 0x0038DA94 File Offset: 0x0038BC94
		public static ITakePhoto2SequenceCondition GetRootAsITakePhoto2SequenceCondition(ByteBuffer _bb, ITakePhoto2SequenceCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018AB5 RID: 101045 RVA: 0x0038DAB1 File Offset: 0x0038BCB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018AB6 RID: 101046 RVA: 0x0038DAC0 File Offset: 0x0038BCC0
		public ITakePhoto2SequenceCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076EC RID: 30444
		// (get) Token: 0x06018AB7 RID: 101047 RVA: 0x0038DAD0 File Offset: 0x0038BCD0
		public string SequencePath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018AB8 RID: 101048 RVA: 0x0038DB07 File Offset: 0x0038BD07
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06018AB9 RID: 101049 RVA: 0x0038DB16 File Offset: 0x0038BD16
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06018ABA RID: 101050 RVA: 0x0038DB24 File Offset: 0x0038BD24
		public static Offset<ITakePhoto2SequenceCondition> CreateITakePhoto2SequenceCondition(FlatBufferBuilder builder, StringOffset SequencePathOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ITakePhoto2SequenceCondition.AddSequencePath(builder, SequencePathOffset);
			return ITakePhoto2SequenceCondition.EndITakePhoto2SequenceCondition(builder);
		}

		// Token: 0x06018ABB RID: 101051 RVA: 0x0038DB3A File Offset: 0x0038BD3A
		public static void StartITakePhoto2SequenceCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018ABC RID: 101052 RVA: 0x0038DB43 File Offset: 0x0038BD43
		public static void AddSequencePath(FlatBufferBuilder builder, StringOffset sequencePathOffset)
		{
			builder.AddOffset(0, sequencePathOffset.Value, 0);
		}

		// Token: 0x06018ABD RID: 101053 RVA: 0x0038DB53 File Offset: 0x0038BD53
		public static Offset<ITakePhoto2SequenceCondition> EndITakePhoto2SequenceCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2SequenceCondition>(builder.EndTable());
		}

		// Token: 0x06018ABE RID: 101054 RVA: 0x0038DB60 File Offset: 0x0038BD60
		public ITakePhoto2SequenceConditionT UnPack()
		{
			ITakePhoto2SequenceConditionT takePhoto2SequenceConditionT = new ITakePhoto2SequenceConditionT();
			this.UnPackTo(takePhoto2SequenceConditionT);
			return takePhoto2SequenceConditionT;
		}

		// Token: 0x06018ABF RID: 101055 RVA: 0x0038DB7B File Offset: 0x0038BD7B
		public void UnPackTo(ITakePhoto2SequenceConditionT _o)
		{
			_o.SequencePath = this.SequencePath;
		}

		// Token: 0x06018AC0 RID: 101056 RVA: 0x0038DB8C File Offset: 0x0038BD8C
		public static Offset<ITakePhoto2SequenceCondition> Pack(FlatBufferBuilder builder, ITakePhoto2SequenceConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2SequenceCondition>);
			}
			StringOffset sequencePathOffset = (_o.SequencePath == null) ? default(StringOffset) : builder.CreateString(_o.SequencePath);
			return ITakePhoto2SequenceCondition.CreateITakePhoto2SequenceCondition(builder, sequencePathOffset);
		}

		// Token: 0x0400BDB6 RID: 48566
		private Table __p;
	}
}
