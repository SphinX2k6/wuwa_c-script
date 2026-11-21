using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C71 RID: 3185
	public struct CommonTouchUiEdit : IFlatbufferObject
	{
		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06005D6F RID: 23919 RVA: 0x0021AE08 File Offset: 0x00219008
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x0021AE15 File Offset: 0x00219015
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x0021AE1C File Offset: 0x0021901C
		public static CommonTouchUiEdit GetRootAsCommonTouchUiEdit(ByteBuffer _bb)
		{
			return CommonTouchUiEdit.GetRootAsCommonTouchUiEdit(_bb, default(CommonTouchUiEdit));
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x0021AE38 File Offset: 0x00219038
		public static CommonTouchUiEdit GetRootAsCommonTouchUiEdit(ByteBuffer _bb, CommonTouchUiEdit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x0021AE55 File Offset: 0x00219055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x0021AE64 File Offset: 0x00219064
		public CommonTouchUiEdit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06005D75 RID: 23925 RVA: 0x0021AE74 File Offset: 0x00219074
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

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06005D76 RID: 23926 RVA: 0x0021AEB0 File Offset: 0x002190B0
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

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06005D77 RID: 23927 RVA: 0x0021AEEC File Offset: 0x002190EC
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

		// Token: 0x06005D78 RID: 23928 RVA: 0x0021AF23 File Offset: 0x00219123
		public Span<byte> GetPanelResIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x0021AF32 File Offset: 0x00219132
		public byte[] GetPanelResIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06005D7A RID: 23930 RVA: 0x0021AF4C File Offset: 0x0021914C
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

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06005D7B RID: 23931 RVA: 0x0021AF8C File Offset: 0x0021918C
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

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06005D7C RID: 23932 RVA: 0x0021AFCC File Offset: 0x002191CC
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

		// Token: 0x06005D7D RID: 23933 RVA: 0x0021B004 File Offset: 0x00219204
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x0021B014 File Offset: 0x00219214
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06005D7F RID: 23935 RVA: 0x0021B02C File Offset: 0x0021922C
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

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06005D80 RID: 23936 RVA: 0x0021B070 File Offset: 0x00219270
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

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06005D81 RID: 23937 RVA: 0x0021B0B4 File Offset: 0x002192B4
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

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06005D82 RID: 23938 RVA: 0x0021B0F8 File Offset: 0x002192F8
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

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06005D83 RID: 23939 RVA: 0x0021B13C File Offset: 0x0021933C
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

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06005D84 RID: 23940 RVA: 0x0021B17C File Offset: 0x0021937C
		public bool IsCheckOverlap
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06005D85 RID: 23941 RVA: 0x0021B1BC File Offset: 0x002193BC
		public bool IsDefaultSelected
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06005D86 RID: 23942 RVA: 0x0021B1FC File Offset: 0x002193FC
		public bool Editable
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005180 RID: 20864
		private Table __p;
	}
}
