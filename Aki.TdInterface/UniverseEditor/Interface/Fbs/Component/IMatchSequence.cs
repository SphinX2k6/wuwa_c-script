using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AAA RID: 23210
	public struct IMatchSequence : IFlatbufferObject
	{
		// Token: 0x1700A91F RID: 43295
		// (get) Token: 0x060260C9 RID: 155849 RVA: 0x00536B73 File Offset: 0x00534D73
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060260CA RID: 155850 RVA: 0x00536B80 File Offset: 0x00534D80
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060260CB RID: 155851 RVA: 0x00536B88 File Offset: 0x00534D88
		public static IMatchSequence GetRootAsIMatchSequence(ByteBuffer _bb)
		{
			return IMatchSequence.GetRootAsIMatchSequence(_bb, default(IMatchSequence));
		}

		// Token: 0x060260CC RID: 155852 RVA: 0x00536BA4 File Offset: 0x00534DA4
		public static IMatchSequence GetRootAsIMatchSequence(ByteBuffer _bb, IMatchSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060260CD RID: 155853 RVA: 0x00536BC1 File Offset: 0x00534DC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060260CE RID: 155854 RVA: 0x00536BD0 File Offset: 0x00534DD0
		public IMatchSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A920 RID: 43296
		// (get) Token: 0x060260CF RID: 155855 RVA: 0x00536BE0 File Offset: 0x00534DE0
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

		// Token: 0x1700A921 RID: 43297
		// (get) Token: 0x060260D0 RID: 155856 RVA: 0x00536C1C File Offset: 0x00534E1C
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

		// Token: 0x1700A922 RID: 43298
		// (get) Token: 0x060260D1 RID: 155857 RVA: 0x00536C7C File Offset: 0x00534E7C
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

		// Token: 0x060260D2 RID: 155858 RVA: 0x00536CB3 File Offset: 0x00534EB3
		public Span<byte> GetMatchSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060260D3 RID: 155859 RVA: 0x00536CC2 File Offset: 0x00534EC2
		public byte[] GetMatchSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060260D4 RID: 155860 RVA: 0x00536CD0 File Offset: 0x00534ED0
		public static Offset<IMatchSequence> CreateIMatchSequence(FlatBufferBuilder builder, EItemFoundationMatchType FoundationType = EItemFoundationMatchType.Branch, Offset<IVectorInfo> MatchPointOffset = default(Offset<IVectorInfo>), StringOffset MatchSequenceOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IMatchSequence.AddMatchSequence(builder, MatchSequenceOffset);
			IMatchSequence.AddMatchPoint(builder, MatchPointOffset);
			IMatchSequence.AddFoundationType(builder, FoundationType);
			return IMatchSequence.EndIMatchSequence(builder);
		}

		// Token: 0x060260D5 RID: 155861 RVA: 0x00536CF4 File Offset: 0x00534EF4
		public static void StartIMatchSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060260D6 RID: 155862 RVA: 0x00536CFD File Offset: 0x00534EFD
		public static void AddFoundationType(FlatBufferBuilder builder, EItemFoundationMatchType foundationType)
		{
			builder.AddByte(0, (byte)foundationType, 0);
		}

		// Token: 0x060260D7 RID: 155863 RVA: 0x00536D08 File Offset: 0x00534F08
		public static void AddMatchPoint(FlatBufferBuilder builder, Offset<IVectorInfo> matchPointOffset)
		{
			builder.AddOffset(1, matchPointOffset.Value, 0);
		}

		// Token: 0x060260D8 RID: 155864 RVA: 0x00536D18 File Offset: 0x00534F18
		public static void AddMatchSequence(FlatBufferBuilder builder, StringOffset matchSequenceOffset)
		{
			builder.AddOffset(2, matchSequenceOffset.Value, 0);
		}

		// Token: 0x060260D9 RID: 155865 RVA: 0x00536D28 File Offset: 0x00534F28
		public static Offset<IMatchSequence> EndIMatchSequence(FlatBufferBuilder builder)
		{
			return new Offset<IMatchSequence>(builder.EndTable());
		}

		// Token: 0x060260DA RID: 155866 RVA: 0x00536D38 File Offset: 0x00534F38
		public IMatchSequenceT UnPack()
		{
			IMatchSequenceT matchSequenceT = new IMatchSequenceT();
			this.UnPackTo(matchSequenceT);
			return matchSequenceT;
		}

		// Token: 0x060260DB RID: 155867 RVA: 0x00536D54 File Offset: 0x00534F54
		public void UnPackTo(IMatchSequenceT _o)
		{
			_o.FoundationType = this.FoundationType;
			_o.MatchPoint = ((this.MatchPoint != null) ? this.MatchPoint.Value.UnPack() : null);
			_o.MatchSequence = this.MatchSequence;
		}

		// Token: 0x060260DC RID: 155868 RVA: 0x00536DA8 File Offset: 0x00534FA8
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

		// Token: 0x0400F44A RID: 62538
		private Table __p;
	}
}
