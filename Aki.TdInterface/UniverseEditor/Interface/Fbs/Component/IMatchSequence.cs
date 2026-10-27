using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005524 RID: 21796
	public struct IMatchSequence : IFlatbufferObject
	{
		// Token: 0x1700A0E5 RID: 41189
		// (get) Token: 0x0602400F RID: 147471 RVA: 0x004F9A4F File Offset: 0x004F7C4F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024010 RID: 147472 RVA: 0x004F9A5C File Offset: 0x004F7C5C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024011 RID: 147473 RVA: 0x004F9A64 File Offset: 0x004F7C64
		public static IMatchSequence GetRootAsIMatchSequence(ByteBuffer _bb)
		{
			return IMatchSequence.GetRootAsIMatchSequence(_bb, default(IMatchSequence));
		}

		// Token: 0x06024012 RID: 147474 RVA: 0x004F9A80 File Offset: 0x004F7C80
		public static IMatchSequence GetRootAsIMatchSequence(ByteBuffer _bb, IMatchSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024013 RID: 147475 RVA: 0x004F9A9D File Offset: 0x004F7C9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024014 RID: 147476 RVA: 0x004F9AAC File Offset: 0x004F7CAC
		public IMatchSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0E6 RID: 41190
		// (get) Token: 0x06024015 RID: 147477 RVA: 0x004F9ABC File Offset: 0x004F7CBC
		public EItemFoundationMatchType FoundationType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemFoundationMatchType.Branch;
				}
				return (EItemFoundationMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A0E7 RID: 41191
		// (get) Token: 0x06024016 RID: 147478 RVA: 0x004F9AF8 File Offset: 0x004F7CF8
		public IVectorInfo? MatchPoint
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

		// Token: 0x1700A0E8 RID: 41192
		// (get) Token: 0x06024017 RID: 147479 RVA: 0x004F9B58 File Offset: 0x004F7D58
		public string MatchSequence
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

		// Token: 0x06024018 RID: 147480 RVA: 0x004F9B8F File Offset: 0x004F7D8F
		public Span<byte> GetMatchSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024019 RID: 147481 RVA: 0x004F9B9E File Offset: 0x004F7D9E
		public byte[] GetMatchSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602401A RID: 147482 RVA: 0x004F9BAC File Offset: 0x004F7DAC
		public static Offset<IMatchSequence> CreateIMatchSequence(FlatBufferBuilder builder, EItemFoundationMatchType FoundationType = EItemFoundationMatchType.Branch, Offset<IVectorInfo> MatchPointOffset = default(Offset<IVectorInfo>), StringOffset MatchSequenceOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IMatchSequence.AddMatchSequence(builder, MatchSequenceOffset);
			IMatchSequence.AddMatchPoint(builder, MatchPointOffset);
			IMatchSequence.AddFoundationType(builder, FoundationType);
			return IMatchSequence.EndIMatchSequence(builder);
		}

		// Token: 0x0602401B RID: 147483 RVA: 0x004F9BD0 File Offset: 0x004F7DD0
		public static void StartIMatchSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602401C RID: 147484 RVA: 0x004F9BD9 File Offset: 0x004F7DD9
		public static void AddFoundationType(FlatBufferBuilder builder, EItemFoundationMatchType foundationType)
		{
			builder.AddByte(0, (byte)foundationType, 0);
		}

		// Token: 0x0602401D RID: 147485 RVA: 0x004F9BE4 File Offset: 0x004F7DE4
		public static void AddMatchPoint(FlatBufferBuilder builder, Offset<IVectorInfo> matchPointOffset)
		{
			builder.AddOffset(1, matchPointOffset.Value, 0);
		}

		// Token: 0x0602401E RID: 147486 RVA: 0x004F9BF4 File Offset: 0x004F7DF4
		public static void AddMatchSequence(FlatBufferBuilder builder, StringOffset matchSequenceOffset)
		{
			builder.AddOffset(2, matchSequenceOffset.Value, 0);
		}

		// Token: 0x0602401F RID: 147487 RVA: 0x004F9C04 File Offset: 0x004F7E04
		public static Offset<IMatchSequence> EndIMatchSequence(FlatBufferBuilder builder)
		{
			return new Offset<IMatchSequence>(builder.EndTable());
		}

		// Token: 0x06024020 RID: 147488 RVA: 0x004F9C14 File Offset: 0x004F7E14
		public IMatchSequenceT UnPack()
		{
			IMatchSequenceT matchSequenceT = new IMatchSequenceT();
			this.UnPackTo(matchSequenceT);
			return matchSequenceT;
		}

		// Token: 0x06024021 RID: 147489 RVA: 0x004F9C30 File Offset: 0x004F7E30
		public void UnPackTo(IMatchSequenceT _o)
		{
			_o.FoundationType = this.FoundationType;
			_o.MatchPoint = ((this.MatchPoint != null) ? this.MatchPoint.Value.UnPack() : null);
			_o.MatchSequence = this.MatchSequence;
		}

		// Token: 0x06024022 RID: 147490 RVA: 0x004F9C84 File Offset: 0x004F7E84
		public static Offset<IMatchSequence> Pack(FlatBufferBuilder builder, IMatchSequenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMatchSequence>);
			}
			Offset<IVectorInfo> matchPointOffset = (_o.MatchPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.MatchPoint);
			StringOffset matchSequenceOffset = (_o.MatchSequence == null) ? default(StringOffset) : builder.CreateString(_o.MatchSequence);
			return IMatchSequence.CreateIMatchSequence(builder, _o.FoundationType, matchPointOffset, matchSequenceOffset);
		}

		// Token: 0x0400E819 RID: 59417
		private Table __p;
	}
}
