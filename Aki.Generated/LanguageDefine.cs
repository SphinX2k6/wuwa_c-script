using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBE RID: 3518
	public struct LanguageDefine : IFlatbufferObject
	{
		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06008D10 RID: 36112 RVA: 0x00275924 File Offset: 0x00273B24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D11 RID: 36113 RVA: 0x00275931 File Offset: 0x00273B31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D12 RID: 36114 RVA: 0x00275938 File Offset: 0x00273B38
		public static LanguageDefine GetRootAsLanguageDefine(ByteBuffer _bb)
		{
			return LanguageDefine.GetRootAsLanguageDefine(_bb, default(LanguageDefine));
		}

		// Token: 0x06008D13 RID: 36115 RVA: 0x00275954 File Offset: 0x00273B54
		public static LanguageDefine GetRootAsLanguageDefine(ByteBuffer _bb, LanguageDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D14 RID: 36116 RVA: 0x00275971 File Offset: 0x00273B71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D15 RID: 36117 RVA: 0x00275980 File Offset: 0x00273B80
		public LanguageDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06008D16 RID: 36118 RVA: 0x00275990 File Offset: 0x00273B90
		public int LanguageType
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

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06008D17 RID: 36119 RVA: 0x002759CC File Offset: 0x00273BCC
		public string LanguageCode
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

		// Token: 0x06008D18 RID: 36120 RVA: 0x00275A03 File Offset: 0x00273C03
		public Span<byte> GetLanguageCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008D19 RID: 36121 RVA: 0x00275A12 File Offset: 0x00273C12
		public byte[] GetLanguageCodeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06008D1A RID: 36122 RVA: 0x00275A2C File Offset: 0x00273C2C
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06008D1B RID: 36123 RVA: 0x00275A6C File Offset: 0x00273C6C
		public int QuestionnaireId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x06008D1C RID: 36124 RVA: 0x00275AAC File Offset: 0x00273CAC
		public string AudioCode
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008D1D RID: 36125 RVA: 0x00275AE4 File Offset: 0x00273CE4
		public Span<byte> GetAudioCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008D1E RID: 36126 RVA: 0x00275AF4 File Offset: 0x00273CF4
		public byte[] GetAudioCodeArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x06008D1F RID: 36127 RVA: 0x00275B0C File Offset: 0x00273D0C
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004E54 RID: 20052
		private Table __p;
	}
}
