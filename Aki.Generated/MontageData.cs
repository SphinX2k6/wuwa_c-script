using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F04 RID: 3844
	public struct MontageData : IFlatbufferObject
	{
		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x06009BC7 RID: 39879 RVA: 0x002A6A64 File Offset: 0x002A4C64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009BC8 RID: 39880 RVA: 0x002A6A71 File Offset: 0x002A4C71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009BC9 RID: 39881 RVA: 0x002A6A78 File Offset: 0x002A4C78
		public static MontageData GetRootAsMontageData(ByteBuffer _bb)
		{
			return MontageData.GetRootAsMontageData(_bb, default(MontageData));
		}

		// Token: 0x06009BCA RID: 39882 RVA: 0x002A6A94 File Offset: 0x002A4C94
		public static MontageData GetRootAsMontageData(ByteBuffer _bb, MontageData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009BCB RID: 39883 RVA: 0x002A6AB1 File Offset: 0x002A4CB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009BCC RID: 39884 RVA: 0x002A6AC0 File Offset: 0x002A4CC0
		public MontageData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x06009BCD RID: 39885 RVA: 0x002A6AD0 File Offset: 0x002A4CD0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x06009BCE RID: 39886 RVA: 0x002A6B0C File Offset: 0x002A4D0C
		public string ActionMontage
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

		// Token: 0x06009BCF RID: 39887 RVA: 0x002A6B43 File Offset: 0x002A4D43
		public Span<byte> GetActionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009BD0 RID: 39888 RVA: 0x002A6B52 File Offset: 0x002A4D52
		public byte[] GetActionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x06009BD1 RID: 39889 RVA: 0x002A6B6C File Offset: 0x002A4D6C
		public string ExpressionMontage
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

		// Token: 0x06009BD2 RID: 39890 RVA: 0x002A6BA3 File Offset: 0x002A4DA3
		public Span<byte> GetExpressionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009BD3 RID: 39891 RVA: 0x002A6BB2 File Offset: 0x002A4DB2
		public byte[] GetExpressionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x06009BD4 RID: 39892 RVA: 0x002A6BCC File Offset: 0x002A4DCC
		public string MouthSequence
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009BD5 RID: 39893 RVA: 0x002A6C04 File Offset: 0x002A4E04
		public Span<byte> GetMouthSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009BD6 RID: 39894 RVA: 0x002A6C14 File Offset: 0x002A4E14
		public byte[] GetMouthSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040054A9 RID: 21673
		private Table __p;
	}
}
