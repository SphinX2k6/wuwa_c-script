using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8F RID: 2959
	public struct CommonTouchUiEdit : IFlatbufferObject
	{
		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06005796 RID: 22422 RVA: 0x001FB010 File Offset: 0x001F9210
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x001FB01D File Offset: 0x001F921D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x001FB024 File Offset: 0x001F9224
		public static CommonTouchUiEdit GetRootAsCommonTouchUiEdit(ByteBuffer _bb)
		{
			return CommonTouchUiEdit.GetRootAsCommonTouchUiEdit(_bb, default(CommonTouchUiEdit));
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x001FB040 File Offset: 0x001F9240
		public static CommonTouchUiEdit GetRootAsCommonTouchUiEdit(ByteBuffer _bb, CommonTouchUiEdit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x001FB05D File Offset: 0x001F925D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x001FB06C File Offset: 0x001F926C
		public CommonTouchUiEdit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x0600579C RID: 22428 RVA: 0x001FB07C File Offset: 0x001F927C
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

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600579D RID: 22429 RVA: 0x001FB0B8 File Offset: 0x001F92B8
		public int EditGroup
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x0600579E RID: 22430 RVA: 0x001FB0F4 File Offset: 0x001F92F4
		public string PanelResId
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

		// Token: 0x0600579F RID: 22431 RVA: 0x001FB12B File Offset: 0x001F932B
		public Span<byte> GetPanelResIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x001FB13A File Offset: 0x001F933A
		public byte[] GetPanelResIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x001FB154 File Offset: 0x001F9354
		public int SubPanelIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060057A2 RID: 22434 RVA: 0x001FB194 File Offset: 0x001F9394
		public int ItemIndex
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060057A3 RID: 22435 RVA: 0x001FB1D4 File Offset: 0x001F93D4
		public string Name
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

		// Token: 0x060057A4 RID: 22436 RVA: 0x001FB20C File Offset: 0x001F940C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060057A5 RID: 22437 RVA: 0x001FB21C File Offset: 0x001F941C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060057A6 RID: 22438 RVA: 0x001FB234 File Offset: 0x001F9434
		public float SourceSize
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060057A7 RID: 22439 RVA: 0x001FB278 File Offset: 0x001F9478
		public float SourceAlpha
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060057A8 RID: 22440 RVA: 0x001FB2BC File Offset: 0x001F94BC
		public float SourceOffsetX
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060057A9 RID: 22441 RVA: 0x001FB300 File Offset: 0x001F9500
		public float SourceOffsetY
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060057AA RID: 22442 RVA: 0x001FB344 File Offset: 0x001F9544
		public int SourceHierarchyIndex
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060057AB RID: 22443 RVA: 0x001FB384 File Offset: 0x001F9584
		public bool IsCheckOverlap
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060057AC RID: 22444 RVA: 0x001FB3C4 File Offset: 0x001F95C4
		public bool IsDefaultSelected
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060057AD RID: 22445 RVA: 0x001FB404 File Offset: 0x001F9604
		public bool Editable
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004B9E RID: 19358
		private Table __p;
	}
}
