using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA2 RID: 2978
	public struct CookProcessMsg : IFlatbufferObject
	{
		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06005995 RID: 22933 RVA: 0x00200200 File Offset: 0x001FE400
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x0020020D File Offset: 0x001FE40D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x00200214 File Offset: 0x001FE414
		public static CookProcessMsg GetRootAsCookProcessMsg(ByteBuffer _bb)
		{
			return CookProcessMsg.GetRootAsCookProcessMsg(_bb, default(CookProcessMsg));
		}

		// Token: 0x06005998 RID: 22936 RVA: 0x00200230 File Offset: 0x001FE430
		public static CookProcessMsg GetRootAsCookProcessMsg(ByteBuffer _bb, CookProcessMsg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005999 RID: 22937 RVA: 0x0020024D File Offset: 0x001FE44D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600599A RID: 22938 RVA: 0x0020025C File Offset: 0x001FE45C
		public CookProcessMsg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x0600599B RID: 22939 RVA: 0x0020026C File Offset: 0x001FE46C
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

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x0600599C RID: 22940 RVA: 0x002002A8 File Offset: 0x001FE4A8
		public string Description
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

		// Token: 0x0600599D RID: 22941 RVA: 0x002002DF File Offset: 0x001FE4DF
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x002002EE File Offset: 0x001FE4EE
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x0600599F RID: 22943 RVA: 0x00200308 File Offset: 0x001FE508
		public string Introduce
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

		// Token: 0x060059A0 RID: 22944 RVA: 0x0020033F File Offset: 0x001FE53F
		public Span<byte> GetIntroduceBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x0020034E File Offset: 0x001FE54E
		public byte[] GetIntroduceArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BC5 RID: 19397
		private Table __p;
	}
}
