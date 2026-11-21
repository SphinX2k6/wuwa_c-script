using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E06 RID: 3590
	public struct H5CircumUrl : IFlatbufferObject
	{
		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x060083E3 RID: 33763 RVA: 0x00271291 File Offset: 0x0026F491
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060083E4 RID: 33764 RVA: 0x0027129E File Offset: 0x0026F49E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060083E5 RID: 33765 RVA: 0x002712A8 File Offset: 0x0026F4A8
		public static H5CircumUrl GetRootAsH5CircumUrl(ByteBuffer _bb)
		{
			return H5CircumUrl.GetRootAsH5CircumUrl(_bb, default(H5CircumUrl));
		}

		// Token: 0x060083E6 RID: 33766 RVA: 0x002712C4 File Offset: 0x0026F4C4
		public static H5CircumUrl GetRootAsH5CircumUrl(ByteBuffer _bb, H5CircumUrl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060083E7 RID: 33767 RVA: 0x002712E1 File Offset: 0x0026F4E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060083E8 RID: 33768 RVA: 0x002712F0 File Offset: 0x0026F4F0
		public H5CircumUrl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x060083E9 RID: 33769 RVA: 0x00271300 File Offset: 0x0026F500
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

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x060083EA RID: 33770 RVA: 0x0027133C File Offset: 0x0026F53C
		public string RootUrl
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

		// Token: 0x060083EB RID: 33771 RVA: 0x00271373 File Offset: 0x0026F573
		public Span<byte> GetRootUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060083EC RID: 33772 RVA: 0x00271382 File Offset: 0x0026F582
		public byte[] GetRootUrlArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x060083ED RID: 33773 RVA: 0x0027139C File Offset: 0x0026F59C
		public string OverseaRootUrl
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

		// Token: 0x060083EE RID: 33774 RVA: 0x002713D3 File Offset: 0x0026F5D3
		public Span<byte> GetOverseaRootUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060083EF RID: 33775 RVA: 0x002713E2 File Offset: 0x0026F5E2
		public byte[] GetOverseaRootUrlArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x060083F0 RID: 33776 RVA: 0x002713FC File Offset: 0x0026F5FC
		public string Ps5RootUrl
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

		// Token: 0x060083F1 RID: 33777 RVA: 0x00271434 File Offset: 0x0026F634
		public Span<byte> GetPs5RootUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060083F2 RID: 33778 RVA: 0x00271444 File Offset: 0x0026F644
		public byte[] GetPs5RootUrlArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x060083F3 RID: 33779 RVA: 0x0027145C File Offset: 0x0026F65C
		public bool IsInternalBrowser
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x060083F4 RID: 33780 RVA: 0x0027149C File Offset: 0x0026F69C
		public string ScoreText
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

		// Token: 0x060083F5 RID: 33781 RVA: 0x002714D4 File Offset: 0x0026F6D4
		public Span<byte> GetScoreTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060083F6 RID: 33782 RVA: 0x002714E4 File Offset: 0x0026F6E4
		public byte[] GetScoreTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x060083F7 RID: 33783 RVA: 0x002714FC File Offset: 0x0026F6FC
		public string BgPath
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

		// Token: 0x060083F8 RID: 33784 RVA: 0x00271534 File Offset: 0x0026F734
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060083F9 RID: 33785 RVA: 0x00271544 File Offset: 0x0026F744
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0400537E RID: 21374
		private Table __p;
	}
}
