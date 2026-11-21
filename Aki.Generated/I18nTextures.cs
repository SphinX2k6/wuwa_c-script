using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3F RID: 3647
	public struct I18nTextures : IFlatbufferObject
	{
		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06008882 RID: 34946 RVA: 0x0027B321 File Offset: 0x00279521
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008883 RID: 34947 RVA: 0x0027B32E File Offset: 0x0027952E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008884 RID: 34948 RVA: 0x0027B338 File Offset: 0x00279538
		public static I18nTextures GetRootAsI18nTextures(ByteBuffer _bb)
		{
			return I18nTextures.GetRootAsI18nTextures(_bb, default(I18nTextures));
		}

		// Token: 0x06008885 RID: 34949 RVA: 0x0027B354 File Offset: 0x00279554
		public static I18nTextures GetRootAsI18nTextures(ByteBuffer _bb, I18nTextures obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008886 RID: 34950 RVA: 0x0027B371 File Offset: 0x00279571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008887 RID: 34951 RVA: 0x0027B380 File Offset: 0x00279580
		public I18nTextures __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06008888 RID: 34952 RVA: 0x0027B390 File Offset: 0x00279590
		public string Id
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

		// Token: 0x06008889 RID: 34953 RVA: 0x0027B3C7 File Offset: 0x002795C7
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600888A RID: 34954 RVA: 0x0027B3D6 File Offset: 0x002795D6
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x0600888B RID: 34955 RVA: 0x0027B3F0 File Offset: 0x002795F0
		public string HandleType
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

		// Token: 0x0600888C RID: 34956 RVA: 0x0027B427 File Offset: 0x00279627
		public Span<byte> GetHandleTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600888D RID: 34957 RVA: 0x0027B436 File Offset: 0x00279636
		public byte[] GetHandleTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x0600888E RID: 34958 RVA: 0x0027B450 File Offset: 0x00279650
		public string ZhHans
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

		// Token: 0x0600888F RID: 34959 RVA: 0x0027B487 File Offset: 0x00279687
		public Span<byte> GetZhHansBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008890 RID: 34960 RVA: 0x0027B496 File Offset: 0x00279696
		public byte[] GetZhHansArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x06008891 RID: 34961 RVA: 0x0027B4B0 File Offset: 0x002796B0
		public string En
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

		// Token: 0x06008892 RID: 34962 RVA: 0x0027B4E8 File Offset: 0x002796E8
		public Span<byte> GetEnBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008893 RID: 34963 RVA: 0x0027B4F8 File Offset: 0x002796F8
		public byte[] GetEnArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x06008894 RID: 34964 RVA: 0x0027B510 File Offset: 0x00279710
		public string Ja
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

		// Token: 0x06008895 RID: 34965 RVA: 0x0027B548 File Offset: 0x00279748
		public Span<byte> GetJaBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008896 RID: 34966 RVA: 0x0027B558 File Offset: 0x00279758
		public byte[] GetJaArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x06008897 RID: 34967 RVA: 0x0027B570 File Offset: 0x00279770
		public string Ko
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008898 RID: 34968 RVA: 0x0027B5A8 File Offset: 0x002797A8
		public Span<byte> GetKoBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008899 RID: 34969 RVA: 0x0027B5B8 File Offset: 0x002797B8
		public byte[] GetKoArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x0600889A RID: 34970 RVA: 0x0027B5D0 File Offset: 0x002797D0
		public string Ru
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600889B RID: 34971 RVA: 0x0027B608 File Offset: 0x00279808
		public Span<byte> GetRuBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600889C RID: 34972 RVA: 0x0027B618 File Offset: 0x00279818
		public byte[] GetRuArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x0600889D RID: 34973 RVA: 0x0027B630 File Offset: 0x00279830
		public string ZhHant
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600889E RID: 34974 RVA: 0x0027B668 File Offset: 0x00279868
		public Span<byte> GetZhHantBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600889F RID: 34975 RVA: 0x0027B678 File Offset: 0x00279878
		public byte[] GetZhHantArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x060088A0 RID: 34976 RVA: 0x0027B690 File Offset: 0x00279890
		public string De
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088A1 RID: 34977 RVA: 0x0027B6C8 File Offset: 0x002798C8
		public Span<byte> GetDeBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060088A2 RID: 34978 RVA: 0x0027B6D8 File Offset: 0x002798D8
		public byte[] GetDeArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x060088A3 RID: 34979 RVA: 0x0027B6F0 File Offset: 0x002798F0
		public string Es
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088A4 RID: 34980 RVA: 0x0027B728 File Offset: 0x00279928
		public Span<byte> GetEsBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060088A5 RID: 34981 RVA: 0x0027B738 File Offset: 0x00279938
		public byte[] GetEsArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x060088A6 RID: 34982 RVA: 0x0027B750 File Offset: 0x00279950
		public string Pt
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088A7 RID: 34983 RVA: 0x0027B788 File Offset: 0x00279988
		public Span<byte> GetPtBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060088A8 RID: 34984 RVA: 0x0027B798 File Offset: 0x00279998
		public byte[] GetPtArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x060088A9 RID: 34985 RVA: 0x0027B7B0 File Offset: 0x002799B0
		public string Idn
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088AA RID: 34986 RVA: 0x0027B7E8 File Offset: 0x002799E8
		public Span<byte> GetIdnBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060088AB RID: 34987 RVA: 0x0027B7F8 File Offset: 0x002799F8
		public byte[] GetIdnArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x060088AC RID: 34988 RVA: 0x0027B810 File Offset: 0x00279A10
		public string Fr
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088AD RID: 34989 RVA: 0x0027B848 File Offset: 0x00279A48
		public Span<byte> GetFrBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060088AE RID: 34990 RVA: 0x0027B858 File Offset: 0x00279A58
		public byte[] GetFrArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x060088AF RID: 34991 RVA: 0x0027B870 File Offset: 0x00279A70
		public string Vi
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088B0 RID: 34992 RVA: 0x0027B8A8 File Offset: 0x00279AA8
		public Span<byte> GetViBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060088B1 RID: 34993 RVA: 0x0027B8B8 File Offset: 0x00279AB8
		public byte[] GetViArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x060088B2 RID: 34994 RVA: 0x0027B8D0 File Offset: 0x00279AD0
		public string Th
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088B3 RID: 34995 RVA: 0x0027B908 File Offset: 0x00279B08
		public Span<byte> GetThBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060088B4 RID: 34996 RVA: 0x0027B918 File Offset: 0x00279B18
		public byte[] GetThArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x040053BE RID: 21438
		private Table __p;
	}
}
