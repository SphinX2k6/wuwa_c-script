using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE6 RID: 3302
	public struct DrinksFlavorType : IFlatbufferObject
	{
		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x060069F3 RID: 27123 RVA: 0x00237086 File Offset: 0x00235286
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x00237093 File Offset: 0x00235293
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x0023709C File Offset: 0x0023529C
		public static DrinksFlavorType GetRootAsDrinksFlavorType(ByteBuffer _bb)
		{
			return DrinksFlavorType.GetRootAsDrinksFlavorType(_bb, default(DrinksFlavorType));
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x002370B8 File Offset: 0x002352B8
		public static DrinksFlavorType GetRootAsDrinksFlavorType(ByteBuffer _bb, DrinksFlavorType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x002370D5 File Offset: 0x002352D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x002370E4 File Offset: 0x002352E4
		public DrinksFlavorType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x060069F9 RID: 27129 RVA: 0x002370F4 File Offset: 0x002352F4
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

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x060069FA RID: 27130 RVA: 0x00237130 File Offset: 0x00235330
		public string Icon
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

		// Token: 0x060069FB RID: 27131 RVA: 0x00237167 File Offset: 0x00235367
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x00237176 File Offset: 0x00235376
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x060069FD RID: 27133 RVA: 0x00237190 File Offset: 0x00235390
		public string IconRichTxt
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

		// Token: 0x060069FE RID: 27134 RVA: 0x002371C7 File Offset: 0x002353C7
		public Span<byte> GetIconRichTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x002371D6 File Offset: 0x002353D6
		public byte[] GetIconRichTxtArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400521C RID: 21020
		private Table __p;
	}
}
