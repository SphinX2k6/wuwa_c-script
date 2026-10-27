using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EE3 RID: 20195
	public struct IAutoGenSequenceConfig : IFlatbufferObject
	{
		// Token: 0x170090F3 RID: 37107
		// (get) Token: 0x0601FD4B RID: 130379 RVA: 0x0046DD02 File Offset: 0x0046BF02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD4C RID: 130380 RVA: 0x0046DD0F File Offset: 0x0046BF0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD4D RID: 130381 RVA: 0x0046DD18 File Offset: 0x0046BF18
		public static IAutoGenSequenceConfig GetRootAsIAutoGenSequenceConfig(ByteBuffer _bb)
		{
			return IAutoGenSequenceConfig.GetRootAsIAutoGenSequenceConfig(_bb, default(IAutoGenSequenceConfig));
		}

		// Token: 0x0601FD4E RID: 130382 RVA: 0x0046DD34 File Offset: 0x0046BF34
		public static IAutoGenSequenceConfig GetRootAsIAutoGenSequenceConfig(ByteBuffer _bb, IAutoGenSequenceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD4F RID: 130383 RVA: 0x0046DD51 File Offset: 0x0046BF51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD50 RID: 130384 RVA: 0x0046DD60 File Offset: 0x0046BF60
		public IAutoGenSequenceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090F4 RID: 37108
		// (get) Token: 0x0601FD51 RID: 130385 RVA: 0x0046DD70 File Offset: 0x0046BF70
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

		// Token: 0x0601FD52 RID: 130386 RVA: 0x0046DDA7 File Offset: 0x0046BFA7
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601FD53 RID: 130387 RVA: 0x0046DDB6 File Offset: 0x0046BFB6
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170090F5 RID: 37109
		// (get) Token: 0x0601FD54 RID: 130388 RVA: 0x0046DDC4 File Offset: 0x0046BFC4
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

		// Token: 0x170090F6 RID: 37110
		// (get) Token: 0x0601FD55 RID: 130389 RVA: 0x0046DE24 File Offset: 0x0046C024
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

		// Token: 0x0601FD56 RID: 130390 RVA: 0x0046DE60 File Offset: 0x0046C060
		public static Offset<IAutoGenSequenceConfig> CreateIAutoGenSequenceConfig(FlatBufferBuilder builder, StringOffset SequencePathOffset = default(StringOffset), Offset<IPlayLevelSequence> SequenceConfigOffset = default(Offset<IPlayLevelSequence>), int Count = 0)
		{
			builder.StartTable(3);
			IAutoGenSequenceConfig.AddCount(builder, Count);
			IAutoGenSequenceConfig.AddSequenceConfig(builder, SequenceConfigOffset);
			IAutoGenSequenceConfig.AddSequencePath(builder, SequencePathOffset);
			return IAutoGenSequenceConfig.EndIAutoGenSequenceConfig(builder);
		}

		// Token: 0x0601FD57 RID: 130391 RVA: 0x0046DE84 File Offset: 0x0046C084
		public static void StartIAutoGenSequenceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FD58 RID: 130392 RVA: 0x0046DE8D File Offset: 0x0046C08D
		public static void AddSequencePath(FlatBufferBuilder builder, StringOffset sequencePathOffset)
		{
			builder.AddOffset(0, sequencePathOffset.Value, 0);
		}

		// Token: 0x0601FD59 RID: 130393 RVA: 0x0046DE9D File Offset: 0x0046C09D
		public static void AddSequenceConfig(FlatBufferBuilder builder, Offset<IPlayLevelSequence> sequenceConfigOffset)
		{
			builder.AddOffset(1, sequenceConfigOffset.Value, 0);
		}

		// Token: 0x0601FD5A RID: 130394 RVA: 0x0046DEAD File Offset: 0x0046C0AD
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x0601FD5B RID: 130395 RVA: 0x0046DEB8 File Offset: 0x0046C0B8
		public static Offset<IAutoGenSequenceConfig> EndIAutoGenSequenceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAutoGenSequenceConfig>(builder.EndTable());
		}

		// Token: 0x0601FD5C RID: 130396 RVA: 0x0046DEC8 File Offset: 0x0046C0C8
		public IAutoGenSequenceConfigT UnPack()
		{
			IAutoGenSequenceConfigT autoGenSequenceConfigT = new IAutoGenSequenceConfigT();
			this.UnPackTo(autoGenSequenceConfigT);
			return autoGenSequenceConfigT;
		}

		// Token: 0x0601FD5D RID: 130397 RVA: 0x0046DEE4 File Offset: 0x0046C0E4
		public void UnPackTo(IAutoGenSequenceConfigT _o)
		{
			_o.SequencePath = this.SequencePath;
			_o.SequenceConfig = ((this.SequenceConfig != null) ? this.SequenceConfig.Value.UnPack() : null);
			_o.Count = this.Count;
		}

		// Token: 0x0601FD5E RID: 130398 RVA: 0x0046DF38 File Offset: 0x0046C138
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

		// Token: 0x0400DCEB RID: 56555
		private Table __p;
	}
}
