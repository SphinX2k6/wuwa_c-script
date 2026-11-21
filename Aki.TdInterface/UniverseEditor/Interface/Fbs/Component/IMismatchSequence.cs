using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE9 RID: 23273
	public struct IMismatchSequence : IFlatbufferObject
	{
		// Token: 0x1700A9CA RID: 43466
		// (get) Token: 0x06026388 RID: 156552 RVA: 0x0053CCB8 File Offset: 0x0053AEB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026389 RID: 156553 RVA: 0x0053CCC5 File Offset: 0x0053AEC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602638A RID: 156554 RVA: 0x0053CCCC File Offset: 0x0053AECC
		public static IMismatchSequence GetRootAsIMismatchSequence(ByteBuffer _bb)
		{
			return IMismatchSequence.GetRootAsIMismatchSequence(_bb, default(IMismatchSequence));
		}

		// Token: 0x0602638B RID: 156555 RVA: 0x0053CCE8 File Offset: 0x0053AEE8
		public static IMismatchSequence GetRootAsIMismatchSequence(ByteBuffer _bb, IMismatchSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602638C RID: 156556 RVA: 0x0053CD05 File Offset: 0x0053AF05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602638D RID: 156557 RVA: 0x0053CD14 File Offset: 0x0053AF14
		public IMismatchSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9CB RID: 43467
		// (get) Token: 0x0602638E RID: 156558 RVA: 0x0053CD24 File Offset: 0x0053AF24
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

		// Token: 0x1700A9CC RID: 43468
		// (get) Token: 0x0602638F RID: 156559 RVA: 0x0053CD60 File Offset: 0x0053AF60
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

		// Token: 0x06026390 RID: 156560 RVA: 0x0053CD97 File Offset: 0x0053AF97
		public Span<byte> GetMatchSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026391 RID: 156561 RVA: 0x0053CDA6 File Offset: 0x0053AFA6
		public byte[] GetMatchSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026392 RID: 156562 RVA: 0x0053CDB4 File Offset: 0x0053AFB4
		public static Offset<IMismatchSequence> CreateIMismatchSequence(FlatBufferBuilder builder, EItemFoundationMatchType FoundationType = EItemFoundationMatchType.Branch, StringOffset MatchSequenceOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMismatchSequence.AddMatchSequence(builder, MatchSequenceOffset);
			IMismatchSequence.AddFoundationType(builder, FoundationType);
			return IMismatchSequence.EndIMismatchSequence(builder);
		}

		// Token: 0x06026393 RID: 156563 RVA: 0x0053CDD1 File Offset: 0x0053AFD1
		public static void StartIMismatchSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026394 RID: 156564 RVA: 0x0053CDDA File Offset: 0x0053AFDA
		public static void AddFoundationType(FlatBufferBuilder builder, EItemFoundationMatchType foundationType)
		{
			builder.AddByte(0, (byte)foundationType, 0);
		}

		// Token: 0x06026395 RID: 156565 RVA: 0x0053CDE5 File Offset: 0x0053AFE5
		public static void AddMatchSequence(FlatBufferBuilder builder, StringOffset matchSequenceOffset)
		{
			builder.AddOffset(1, matchSequenceOffset.Value, 0);
		}

		// Token: 0x06026396 RID: 156566 RVA: 0x0053CDF5 File Offset: 0x0053AFF5
		public static Offset<IMismatchSequence> EndIMismatchSequence(FlatBufferBuilder builder)
		{
			return new Offset<IMismatchSequence>(builder.EndTable());
		}

		// Token: 0x06026397 RID: 156567 RVA: 0x0053CE04 File Offset: 0x0053B004
		public IMismatchSequenceT UnPack()
		{
			IMismatchSequenceT mismatchSequenceT = new IMismatchSequenceT();
			this.UnPackTo(mismatchSequenceT);
			return mismatchSequenceT;
		}

		// Token: 0x06026398 RID: 156568 RVA: 0x0053CE1F File Offset: 0x0053B01F
		public void UnPackTo(IMismatchSequenceT _o)
		{
			_o.FoundationType = this.FoundationType;
			_o.MatchSequence = this.MatchSequence;
		}

		// Token: 0x06026399 RID: 156569 RVA: 0x0053CE3C File Offset: 0x0053B03C
		public static Offset<IMismatchSequence> Pack(FlatBufferBuilder builder, IMismatchSequenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMismatchSequence>);
			}
			StringOffset matchSequenceOffset = (_o.MatchSequence == null) ? default(StringOffset) : builder.CreateString(_o.MatchSequence);
			return IMismatchSequence.CreateIMismatchSequence(builder, _o.FoundationType, matchSequenceOffset);
		}

		// Token: 0x0400F4B6 RID: 62646
		private Table __p;
	}
}
