using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B33 RID: 31539
	public struct ITalkSequenceTransition : IFlatbufferObject
	{
		// Token: 0x1700EC3F RID: 60479
		// (get) Token: 0x06038CC5 RID: 232645 RVA: 0x007AE85D File Offset: 0x007ACA5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038CC6 RID: 232646 RVA: 0x007AE86A File Offset: 0x007ACA6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038CC7 RID: 232647 RVA: 0x007AE874 File Offset: 0x007ACA74
		public static ITalkSequenceTransition GetRootAsITalkSequenceTransition(ByteBuffer _bb)
		{
			return ITalkSequenceTransition.GetRootAsITalkSequenceTransition(_bb, default(ITalkSequenceTransition));
		}

		// Token: 0x06038CC8 RID: 232648 RVA: 0x007AE890 File Offset: 0x007ACA90
		public static ITalkSequenceTransition GetRootAsITalkSequenceTransition(ByteBuffer _bb, ITalkSequenceTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038CC9 RID: 232649 RVA: 0x007AE8AD File Offset: 0x007ACAAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038CCA RID: 232650 RVA: 0x007AE8BC File Offset: 0x007ACABC
		public ITalkSequenceTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC40 RID: 60480
		// (get) Token: 0x06038CCB RID: 232651 RVA: 0x007AE8CC File Offset: 0x007ACACC
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

		// Token: 0x06038CCC RID: 232652 RVA: 0x007AE903 File Offset: 0x007ACB03
		public Span<byte> GetOptionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06038CCD RID: 232653 RVA: 0x007AE912 File Offset: 0x007ACB12
		public byte[] GetOptionTextArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700EC41 RID: 60481
		// (get) Token: 0x06038CCE RID: 232654 RVA: 0x007AE920 File Offset: 0x007ACB20
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

		// Token: 0x06038CCF RID: 232655 RVA: 0x007AE957 File Offset: 0x007ACB57
		public Span<byte> GetOptionTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06038CD0 RID: 232656 RVA: 0x007AE966 File Offset: 0x007ACB66
		public byte[] GetOptionTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700EC42 RID: 60482
		// (get) Token: 0x06038CD1 RID: 232657 RVA: 0x007AE974 File Offset: 0x007ACB74
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

		// Token: 0x06038CD2 RID: 232658 RVA: 0x007AE9B0 File Offset: 0x007ACBB0
		public static Offset<ITalkSequenceTransition> CreateITalkSequenceTransition(FlatBufferBuilder builder, StringOffset OptionTextOffset = default(StringOffset), StringOffset OptionTextKeyOffset = default(StringOffset), int NextSequenceIndex = 0)
		{
			builder.StartTable(3);
			ITalkSequenceTransition.AddNextSequenceIndex(builder, NextSequenceIndex);
			ITalkSequenceTransition.AddOptionTextKey(builder, OptionTextKeyOffset);
			ITalkSequenceTransition.AddOptionText(builder, OptionTextOffset);
			return ITalkSequenceTransition.EndITalkSequenceTransition(builder);
		}

		// Token: 0x06038CD3 RID: 232659 RVA: 0x007AE9D4 File Offset: 0x007ACBD4
		public static void StartITalkSequenceTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06038CD4 RID: 232660 RVA: 0x007AE9DD File Offset: 0x007ACBDD
		public static void AddOptionText(FlatBufferBuilder builder, StringOffset optionTextOffset)
		{
			builder.AddOffset(0, optionTextOffset.Value, 0);
		}

		// Token: 0x06038CD5 RID: 232661 RVA: 0x007AE9ED File Offset: 0x007ACBED
		public static void AddOptionTextKey(FlatBufferBuilder builder, StringOffset optionTextKeyOffset)
		{
			builder.AddOffset(1, optionTextKeyOffset.Value, 0);
		}

		// Token: 0x06038CD6 RID: 232662 RVA: 0x007AE9FD File Offset: 0x007ACBFD
		public static void AddNextSequenceIndex(FlatBufferBuilder builder, int nextSequenceIndex)
		{
			builder.AddInt(2, nextSequenceIndex, 0);
		}

		// Token: 0x06038CD7 RID: 232663 RVA: 0x007AEA08 File Offset: 0x007ACC08
		public static Offset<ITalkSequenceTransition> EndITalkSequenceTransition(FlatBufferBuilder builder)
		{
			return new Offset<ITalkSequenceTransition>(builder.EndTable());
		}

		// Token: 0x06038CD8 RID: 232664 RVA: 0x007AEA18 File Offset: 0x007ACC18
		public ITalkSequenceTransitionT UnPack()
		{
			ITalkSequenceTransitionT talkSequenceTransitionT = new ITalkSequenceTransitionT();
			this.UnPackTo(talkSequenceTransitionT);
			return talkSequenceTransitionT;
		}

		// Token: 0x06038CD9 RID: 232665 RVA: 0x007AEA33 File Offset: 0x007ACC33
		public void UnPackTo(ITalkSequenceTransitionT _o)
		{
			_o.OptionText = this.OptionText;
			_o.OptionTextKey = this.OptionTextKey;
			_o.NextSequenceIndex = this.NextSequenceIndex;
		}

		// Token: 0x06038CDA RID: 232666 RVA: 0x007AEA5C File Offset: 0x007ACC5C
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

		// Token: 0x0401315F RID: 78175
		private Table __p;
	}
}
