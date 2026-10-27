using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C59 RID: 3161
	public struct FaceExpressionData : IFlatbufferObject
	{
		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06006C69 RID: 27753 RVA: 0x0022A8C8 File Offset: 0x00228AC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006C6A RID: 27754 RVA: 0x0022A8D5 File Offset: 0x00228AD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x0022A8DC File Offset: 0x00228ADC
		public static FaceExpressionData GetRootAsFaceExpressionData(ByteBuffer _bb)
		{
			return FaceExpressionData.GetRootAsFaceExpressionData(_bb, default(FaceExpressionData));
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x0022A8F8 File Offset: 0x00228AF8
		public static FaceExpressionData GetRootAsFaceExpressionData(ByteBuffer _bb, FaceExpressionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x0022A915 File Offset: 0x00228B15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006C6E RID: 27758 RVA: 0x0022A924 File Offset: 0x00228B24
		public FaceExpressionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06006C6F RID: 27759 RVA: 0x0022A934 File Offset: 0x00228B34
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

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06006C70 RID: 27760 RVA: 0x0022A970 File Offset: 0x00228B70
		public string FaceExpression
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

		// Token: 0x06006C71 RID: 27761 RVA: 0x0022A9A7 File Offset: 0x00228BA7
		public Span<byte> GetFaceExpressionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x0022A9B6 File Offset: 0x00228BB6
		public byte[] GetFaceExpressionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06006C73 RID: 27763 RVA: 0x0022A9D0 File Offset: 0x00228BD0
		public string MaleVariant
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

		// Token: 0x06006C74 RID: 27764 RVA: 0x0022AA07 File Offset: 0x00228C07
		public Span<byte> GetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006C75 RID: 27765 RVA: 0x0022AA16 File Offset: 0x00228C16
		public byte[] GetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06006C76 RID: 27766 RVA: 0x0022AA30 File Offset: 0x00228C30
		public bool CloseAutoBlink
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004CA4 RID: 19620
		private Table __p;
	}
}
