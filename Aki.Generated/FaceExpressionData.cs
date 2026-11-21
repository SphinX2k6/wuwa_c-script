using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3D RID: 3389
	public struct FaceExpressionData : IFlatbufferObject
	{
		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06007274 RID: 29300 RVA: 0x00249C54 File Offset: 0x00247E54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007275 RID: 29301 RVA: 0x00249C61 File Offset: 0x00247E61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007276 RID: 29302 RVA: 0x00249C68 File Offset: 0x00247E68
		public static FaceExpressionData GetRootAsFaceExpressionData(ByteBuffer _bb)
		{
			return FaceExpressionData.GetRootAsFaceExpressionData(_bb, default(FaceExpressionData));
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x00249C84 File Offset: 0x00247E84
		public static FaceExpressionData GetRootAsFaceExpressionData(ByteBuffer _bb, FaceExpressionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x00249CA1 File Offset: 0x00247EA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x00249CB0 File Offset: 0x00247EB0
		public FaceExpressionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x0600727A RID: 29306 RVA: 0x00249CC0 File Offset: 0x00247EC0
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

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x0600727B RID: 29307 RVA: 0x00249CFC File Offset: 0x00247EFC
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

		// Token: 0x0600727C RID: 29308 RVA: 0x00249D33 File Offset: 0x00247F33
		public Span<byte> GetFaceExpressionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x00249D42 File Offset: 0x00247F42
		public byte[] GetFaceExpressionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x0600727E RID: 29310 RVA: 0x00249D5C File Offset: 0x00247F5C
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

		// Token: 0x0600727F RID: 29311 RVA: 0x00249D93 File Offset: 0x00247F93
		public Span<byte> GetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007280 RID: 29312 RVA: 0x00249DA2 File Offset: 0x00247FA2
		public byte[] GetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06007281 RID: 29313 RVA: 0x00249DBC File Offset: 0x00247FBC
		public bool CloseAutoBlink
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005288 RID: 21128
		private Table __p;
	}
}
