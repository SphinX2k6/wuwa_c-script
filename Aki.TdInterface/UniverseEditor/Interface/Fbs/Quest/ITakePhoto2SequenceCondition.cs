using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045DA RID: 17882
	public struct ITakePhoto2SequenceCondition : IFlatbufferObject
	{
		// Token: 0x17007D12 RID: 32018
		// (get) Token: 0x0601A1E7 RID: 106983 RVA: 0x003B8BF5 File Offset: 0x003B6DF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A1E8 RID: 106984 RVA: 0x003B8C02 File Offset: 0x003B6E02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A1E9 RID: 106985 RVA: 0x003B8C0C File Offset: 0x003B6E0C
		public static ITakePhoto2SequenceCondition GetRootAsITakePhoto2SequenceCondition(ByteBuffer _bb)
		{
			return ITakePhoto2SequenceCondition.GetRootAsITakePhoto2SequenceCondition(_bb, default(ITakePhoto2SequenceCondition));
		}

		// Token: 0x0601A1EA RID: 106986 RVA: 0x003B8C28 File Offset: 0x003B6E28
		public static ITakePhoto2SequenceCondition GetRootAsITakePhoto2SequenceCondition(ByteBuffer _bb, ITakePhoto2SequenceCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A1EB RID: 106987 RVA: 0x003B8C45 File Offset: 0x003B6E45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A1EC RID: 106988 RVA: 0x003B8C54 File Offset: 0x003B6E54
		public ITakePhoto2SequenceCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D13 RID: 32019
		// (get) Token: 0x0601A1ED RID: 106989 RVA: 0x003B8C64 File Offset: 0x003B6E64
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

		// Token: 0x0601A1EE RID: 106990 RVA: 0x003B8C9B File Offset: 0x003B6E9B
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601A1EF RID: 106991 RVA: 0x003B8CAA File Offset: 0x003B6EAA
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601A1F0 RID: 106992 RVA: 0x003B8CB8 File Offset: 0x003B6EB8
		public static Offset<ITakePhoto2SequenceCondition> CreateITakePhoto2SequenceCondition(FlatBufferBuilder builder, StringOffset SequencePathOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ITakePhoto2SequenceCondition.AddSequencePath(builder, SequencePathOffset);
			return ITakePhoto2SequenceCondition.EndITakePhoto2SequenceCondition(builder);
		}

		// Token: 0x0601A1F1 RID: 106993 RVA: 0x003B8CCE File Offset: 0x003B6ECE
		public static void StartITakePhoto2SequenceCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A1F2 RID: 106994 RVA: 0x003B8CD7 File Offset: 0x003B6ED7
		public static void AddSequencePath(FlatBufferBuilder builder, StringOffset sequencePathOffset)
		{
			builder.AddOffset(0, sequencePathOffset.Value, 0);
		}

		// Token: 0x0601A1F3 RID: 106995 RVA: 0x003B8CE7 File Offset: 0x003B6EE7
		public static Offset<ITakePhoto2SequenceCondition> EndITakePhoto2SequenceCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2SequenceCondition>(builder.EndTable());
		}

		// Token: 0x0601A1F4 RID: 106996 RVA: 0x003B8CF4 File Offset: 0x003B6EF4
		public ITakePhoto2SequenceConditionT UnPack()
		{
			ITakePhoto2SequenceConditionT takePhoto2SequenceConditionT = new ITakePhoto2SequenceConditionT();
			this.UnPackTo(takePhoto2SequenceConditionT);
			return takePhoto2SequenceConditionT;
		}

		// Token: 0x0601A1F5 RID: 106997 RVA: 0x003B8D0F File Offset: 0x003B6F0F
		public void UnPackTo(ITakePhoto2SequenceConditionT _o)
		{
			_o.SequencePath = this.SequencePath;
		}

		// Token: 0x0601A1F6 RID: 106998 RVA: 0x003B8D20 File Offset: 0x003B6F20
		public static Offset<ITakePhoto2SequenceCondition> Pack(FlatBufferBuilder builder, ITakePhoto2SequenceConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2SequenceCondition>);
			}
			StringOffset sequencePathOffset = (_o.SequencePath == null) ? default(StringOffset) : builder.CreateString(_o.SequencePath);
			return ITakePhoto2SequenceCondition.CreateITakePhoto2SequenceCondition(builder, sequencePathOffset);
		}

		// Token: 0x0400C7B7 RID: 51127
		private Table __p;
	}
}
