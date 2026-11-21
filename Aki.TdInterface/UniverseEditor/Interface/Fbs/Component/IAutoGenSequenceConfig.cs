using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005412 RID: 21522
	public struct IAutoGenSequenceConfig : IFlatbufferObject
	{
		// Token: 0x17009866 RID: 39014
		// (get) Token: 0x06021A8F RID: 137871 RVA: 0x004A3AD2 File Offset: 0x004A1CD2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A90 RID: 137872 RVA: 0x004A3ADF File Offset: 0x004A1CDF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A91 RID: 137873 RVA: 0x004A3AE8 File Offset: 0x004A1CE8
		public static IAutoGenSequenceConfig GetRootAsIAutoGenSequenceConfig(ByteBuffer _bb)
		{
			return IAutoGenSequenceConfig.GetRootAsIAutoGenSequenceConfig(_bb, default(IAutoGenSequenceConfig));
		}

		// Token: 0x06021A92 RID: 137874 RVA: 0x004A3B04 File Offset: 0x004A1D04
		public static IAutoGenSequenceConfig GetRootAsIAutoGenSequenceConfig(ByteBuffer _bb, IAutoGenSequenceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A93 RID: 137875 RVA: 0x004A3B21 File Offset: 0x004A1D21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A94 RID: 137876 RVA: 0x004A3B30 File Offset: 0x004A1D30
		public IAutoGenSequenceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009867 RID: 39015
		// (get) Token: 0x06021A95 RID: 137877 RVA: 0x004A3B40 File Offset: 0x004A1D40
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

		// Token: 0x06021A96 RID: 137878 RVA: 0x004A3B77 File Offset: 0x004A1D77
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06021A97 RID: 137879 RVA: 0x004A3B86 File Offset: 0x004A1D86
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009868 RID: 39016
		// (get) Token: 0x06021A98 RID: 137880 RVA: 0x004A3B94 File Offset: 0x004A1D94
		public IPlayLevelSequence? SequenceConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayLevelSequence?(default(IPlayLevelSequence).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009869 RID: 39017
		// (get) Token: 0x06021A99 RID: 137881 RVA: 0x004A3BF4 File Offset: 0x004A1DF4
		public int Count
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021A9A RID: 137882 RVA: 0x004A3C30 File Offset: 0x004A1E30
		public static Offset<IAutoGenSequenceConfig> CreateIAutoGenSequenceConfig(FlatBufferBuilder builder, StringOffset SequencePathOffset = default(StringOffset), Offset<IPlayLevelSequence> SequenceConfigOffset = default(Offset<IPlayLevelSequence>), int Count = 0)
		{
			builder.StartTable(3);
			IAutoGenSequenceConfig.AddCount(builder, Count);
			IAutoGenSequenceConfig.AddSequenceConfig(builder, SequenceConfigOffset);
			IAutoGenSequenceConfig.AddSequencePath(builder, SequencePathOffset);
			return IAutoGenSequenceConfig.EndIAutoGenSequenceConfig(builder);
		}

		// Token: 0x06021A9B RID: 137883 RVA: 0x004A3C54 File Offset: 0x004A1E54
		public static void StartIAutoGenSequenceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021A9C RID: 137884 RVA: 0x004A3C5D File Offset: 0x004A1E5D
		public static void AddSequencePath(FlatBufferBuilder builder, StringOffset sequencePathOffset)
		{
			builder.AddOffset(0, sequencePathOffset.Value, 0);
		}

		// Token: 0x06021A9D RID: 137885 RVA: 0x004A3C6D File Offset: 0x004A1E6D
		public static void AddSequenceConfig(FlatBufferBuilder builder, Offset<IPlayLevelSequence> sequenceConfigOffset)
		{
			builder.AddOffset(1, sequenceConfigOffset.Value, 0);
		}

		// Token: 0x06021A9E RID: 137886 RVA: 0x004A3C7D File Offset: 0x004A1E7D
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x06021A9F RID: 137887 RVA: 0x004A3C88 File Offset: 0x004A1E88
		public static Offset<IAutoGenSequenceConfig> EndIAutoGenSequenceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAutoGenSequenceConfig>(builder.EndTable());
		}

		// Token: 0x06021AA0 RID: 137888 RVA: 0x004A3C98 File Offset: 0x004A1E98
		public IAutoGenSequenceConfigT UnPack()
		{
			IAutoGenSequenceConfigT autoGenSequenceConfigT = new IAutoGenSequenceConfigT();
			this.UnPackTo(autoGenSequenceConfigT);
			return autoGenSequenceConfigT;
		}

		// Token: 0x06021AA1 RID: 137889 RVA: 0x004A3CB4 File Offset: 0x004A1EB4
		public void UnPackTo(IAutoGenSequenceConfigT _o)
		{
			_o.SequencePath = this.SequencePath;
			_o.SequenceConfig = ((this.SequenceConfig != null) ? this.SequenceConfig.Value.UnPack() : null);
			_o.Count = this.Count;
		}

		// Token: 0x06021AA2 RID: 137890 RVA: 0x004A3D08 File Offset: 0x004A1F08
		public static Offset<IAutoGenSequenceConfig> Pack(FlatBufferBuilder builder, IAutoGenSequenceConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAutoGenSequenceConfig>);
			}
			StringOffset sequencePathOffset = (_o.SequencePath == null) ? default(StringOffset) : builder.CreateString(_o.SequencePath);
			Offset<IPlayLevelSequence> sequenceConfigOffset = (_o.SequenceConfig == null) ? default(Offset<IPlayLevelSequence>) : IPlayLevelSequence.Pack(builder, _o.SequenceConfig);
			return IAutoGenSequenceConfig.CreateIAutoGenSequenceConfig(builder, sequencePathOffset, sequenceConfigOffset, _o.Count);
		}

		// Token: 0x0400E892 RID: 59538
		private Table __p;
	}
}
