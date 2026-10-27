using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007358 RID: 29528
	public struct ITalkSequenceTransition : IFlatbufferObject
	{
		// Token: 0x1700E03E RID: 57406
		// (get) Token: 0x0603597C RID: 219516 RVA: 0x0074CA8A File Offset: 0x0074AC8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603597D RID: 219517 RVA: 0x0074CA97 File Offset: 0x0074AC97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603597E RID: 219518 RVA: 0x0074CAA0 File Offset: 0x0074ACA0
		public static ITalkSequenceTransition GetRootAsITalkSequenceTransition(ByteBuffer _bb)
		{
			return ITalkSequenceTransition.GetRootAsITalkSequenceTransition(_bb, default(ITalkSequenceTransition));
		}

		// Token: 0x0603597F RID: 219519 RVA: 0x0074CABC File Offset: 0x0074ACBC
		public static ITalkSequenceTransition GetRootAsITalkSequenceTransition(ByteBuffer _bb, ITalkSequenceTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035980 RID: 219520 RVA: 0x0074CAD9 File Offset: 0x0074ACD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035981 RID: 219521 RVA: 0x0074CAE8 File Offset: 0x0074ACE8
		public ITalkSequenceTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E03F RID: 57407
		// (get) Token: 0x06035982 RID: 219522 RVA: 0x0074CAF8 File Offset: 0x0074ACF8
		public string OptionText
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

		// Token: 0x06035983 RID: 219523 RVA: 0x0074CB2F File Offset: 0x0074AD2F
		public Span<byte> GetOptionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06035984 RID: 219524 RVA: 0x0074CB3E File Offset: 0x0074AD3E
		public byte[] GetOptionTextArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E040 RID: 57408
		// (get) Token: 0x06035985 RID: 219525 RVA: 0x0074CB4C File Offset: 0x0074AD4C
		public string OptionTextKey
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

		// Token: 0x06035986 RID: 219526 RVA: 0x0074CB83 File Offset: 0x0074AD83
		public Span<byte> GetOptionTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06035987 RID: 219527 RVA: 0x0074CB92 File Offset: 0x0074AD92
		public byte[] GetOptionTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E041 RID: 57409
		// (get) Token: 0x06035988 RID: 219528 RVA: 0x0074CBA0 File Offset: 0x0074ADA0
		public int NextSequenceIndex
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

		// Token: 0x06035989 RID: 219529 RVA: 0x0074CBDC File Offset: 0x0074ADDC
		public static Offset<ITalkSequenceTransition> CreateITalkSequenceTransition(FlatBufferBuilder builder, StringOffset OptionTextOffset = default(StringOffset), StringOffset OptionTextKeyOffset = default(StringOffset), int NextSequenceIndex = 0)
		{
			builder.StartTable(3);
			ITalkSequenceTransition.AddNextSequenceIndex(builder, NextSequenceIndex);
			ITalkSequenceTransition.AddOptionTextKey(builder, OptionTextKeyOffset);
			ITalkSequenceTransition.AddOptionText(builder, OptionTextOffset);
			return ITalkSequenceTransition.EndITalkSequenceTransition(builder);
		}

		// Token: 0x0603598A RID: 219530 RVA: 0x0074CC00 File Offset: 0x0074AE00
		public static void StartITalkSequenceTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603598B RID: 219531 RVA: 0x0074CC09 File Offset: 0x0074AE09
		public static void AddOptionText(FlatBufferBuilder builder, StringOffset optionTextOffset)
		{
			builder.AddOffset(0, optionTextOffset.Value, 0);
		}

		// Token: 0x0603598C RID: 219532 RVA: 0x0074CC19 File Offset: 0x0074AE19
		public static void AddOptionTextKey(FlatBufferBuilder builder, StringOffset optionTextKeyOffset)
		{
			builder.AddOffset(1, optionTextKeyOffset.Value, 0);
		}

		// Token: 0x0603598D RID: 219533 RVA: 0x0074CC29 File Offset: 0x0074AE29
		public static void AddNextSequenceIndex(FlatBufferBuilder builder, int nextSequenceIndex)
		{
			builder.AddInt(2, nextSequenceIndex, 0);
		}

		// Token: 0x0603598E RID: 219534 RVA: 0x0074CC34 File Offset: 0x0074AE34
		public static Offset<ITalkSequenceTransition> EndITalkSequenceTransition(FlatBufferBuilder builder)
		{
			return new Offset<ITalkSequenceTransition>(builder.EndTable());
		}

		// Token: 0x0603598F RID: 219535 RVA: 0x0074CC44 File Offset: 0x0074AE44
		public ITalkSequenceTransitionT UnPack()
		{
			ITalkSequenceTransitionT talkSequenceTransitionT = new ITalkSequenceTransitionT();
			this.UnPackTo(talkSequenceTransitionT);
			return talkSequenceTransitionT;
		}

		// Token: 0x06035990 RID: 219536 RVA: 0x0074CC5F File Offset: 0x0074AE5F
		public void UnPackTo(ITalkSequenceTransitionT _o)
		{
			_o.OptionText = this.OptionText;
			_o.OptionTextKey = this.OptionTextKey;
			_o.NextSequenceIndex = this.NextSequenceIndex;
		}

		// Token: 0x06035991 RID: 219537 RVA: 0x0074CC88 File Offset: 0x0074AE88
		public static Offset<ITalkSequenceTransition> Pack(FlatBufferBuilder builder, ITalkSequenceTransitionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkSequenceTransition>);
			}
			StringOffset optionTextOffset = (_o.OptionText == null) ? default(StringOffset) : builder.CreateString(_o.OptionText);
			StringOffset optionTextKeyOffset = (_o.OptionTextKey == null) ? default(StringOffset) : builder.CreateString(_o.OptionTextKey);
			return ITalkSequenceTransition.CreateITalkSequenceTransition(builder, optionTextOffset, optionTextKeyOffset, _o.NextSequenceIndex);
		}

		// Token: 0x04012156 RID: 74070
		private Table __p;
	}
}
