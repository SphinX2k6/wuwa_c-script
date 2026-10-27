using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005557 RID: 21847
	public struct IMismatchSequence : IFlatbufferObject
	{
		// Token: 0x1700A156 RID: 41302
		// (get) Token: 0x060241ED RID: 147949 RVA: 0x004FD5D0 File Offset: 0x004FB7D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060241EE RID: 147950 RVA: 0x004FD5DD File Offset: 0x004FB7DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060241EF RID: 147951 RVA: 0x004FD5E4 File Offset: 0x004FB7E4
		public static IMismatchSequence GetRootAsIMismatchSequence(ByteBuffer _bb)
		{
			return IMismatchSequence.GetRootAsIMismatchSequence(_bb, default(IMismatchSequence));
		}

		// Token: 0x060241F0 RID: 147952 RVA: 0x004FD600 File Offset: 0x004FB800
		public static IMismatchSequence GetRootAsIMismatchSequence(ByteBuffer _bb, IMismatchSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060241F1 RID: 147953 RVA: 0x004FD61D File Offset: 0x004FB81D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060241F2 RID: 147954 RVA: 0x004FD62C File Offset: 0x004FB82C
		public IMismatchSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A157 RID: 41303
		// (get) Token: 0x060241F3 RID: 147955 RVA: 0x004FD63C File Offset: 0x004FB83C
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

		// Token: 0x1700A158 RID: 41304
		// (get) Token: 0x060241F4 RID: 147956 RVA: 0x004FD678 File Offset: 0x004FB878
		public string MatchSequence
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

		// Token: 0x060241F5 RID: 147957 RVA: 0x004FD6AF File Offset: 0x004FB8AF
		public Span<byte> GetMatchSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060241F6 RID: 147958 RVA: 0x004FD6BE File Offset: 0x004FB8BE
		public byte[] GetMatchSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060241F7 RID: 147959 RVA: 0x004FD6CC File Offset: 0x004FB8CC
		public static Offset<IMismatchSequence> CreateIMismatchSequence(FlatBufferBuilder builder, EItemFoundationMatchType FoundationType = EItemFoundationMatchType.Branch, StringOffset MatchSequenceOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMismatchSequence.AddMatchSequence(builder, MatchSequenceOffset);
			IMismatchSequence.AddFoundationType(builder, FoundationType);
			return IMismatchSequence.EndIMismatchSequence(builder);
		}

		// Token: 0x060241F8 RID: 147960 RVA: 0x004FD6E9 File Offset: 0x004FB8E9
		public static void StartIMismatchSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060241F9 RID: 147961 RVA: 0x004FD6F2 File Offset: 0x004FB8F2
		public static void AddFoundationType(FlatBufferBuilder builder, EItemFoundationMatchType foundationType)
		{
			builder.AddByte(0, (byte)foundationType, 0);
		}

		// Token: 0x060241FA RID: 147962 RVA: 0x004FD6FD File Offset: 0x004FB8FD
		public static void AddMatchSequence(FlatBufferBuilder builder, StringOffset matchSequenceOffset)
		{
			builder.AddOffset(1, matchSequenceOffset.Value, 0);
		}

		// Token: 0x060241FB RID: 147963 RVA: 0x004FD70D File Offset: 0x004FB90D
		public static Offset<IMismatchSequence> EndIMismatchSequence(FlatBufferBuilder builder)
		{
			return new Offset<IMismatchSequence>(builder.EndTable());
		}

		// Token: 0x060241FC RID: 147964 RVA: 0x004FD71C File Offset: 0x004FB91C
		public IMismatchSequenceT UnPack()
		{
			IMismatchSequenceT mismatchSequenceT = new IMismatchSequenceT();
			this.UnPackTo(mismatchSequenceT);
			return mismatchSequenceT;
		}

		// Token: 0x060241FD RID: 147965 RVA: 0x004FD737 File Offset: 0x004FB937
		public void UnPackTo(IMismatchSequenceT _o)
		{
			_o.FoundationType = this.FoundationType;
			_o.MatchSequence = this.MatchSequence;
		}

		// Token: 0x060241FE RID: 147966 RVA: 0x004FD754 File Offset: 0x004FB954
		public static Offset<IMismatchSequence> Pack(FlatBufferBuilder builder, IMismatchSequenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMismatchSequence>);
			}
			StringOffset matchSequenceOffset = (_o.MatchSequence == null) ? default(StringOffset) : builder.CreateString(_o.MatchSequence);
			return IMismatchSequence.CreateIMismatchSequence(builder, _o.FoundationType, matchSequenceOffset);
		}

		// Token: 0x0400E865 RID: 59493
		private Table __p;
	}
}
