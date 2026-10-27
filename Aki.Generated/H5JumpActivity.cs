using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D22 RID: 3362
	public struct H5JumpActivity : IFlatbufferObject
	{
		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06007DE0 RID: 32224 RVA: 0x00252C4C File Offset: 0x00250E4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x00252C59 File Offset: 0x00250E59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007DE2 RID: 32226 RVA: 0x00252C60 File Offset: 0x00250E60
		public static H5JumpActivity GetRootAsH5JumpActivity(ByteBuffer _bb)
		{
			return H5JumpActivity.GetRootAsH5JumpActivity(_bb, default(H5JumpActivity));
		}

		// Token: 0x06007DE3 RID: 32227 RVA: 0x00252C7C File Offset: 0x00250E7C
		public static H5JumpActivity GetRootAsH5JumpActivity(ByteBuffer _bb, H5JumpActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007DE4 RID: 32228 RVA: 0x00252C99 File Offset: 0x00250E99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x00252CA8 File Offset: 0x00250EA8
		public H5JumpActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06007DE6 RID: 32230 RVA: 0x00252CB8 File Offset: 0x00250EB8
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

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06007DE7 RID: 32231 RVA: 0x00252CF4 File Offset: 0x00250EF4
		public string CNRootUrl
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

		// Token: 0x06007DE8 RID: 32232 RVA: 0x00252D2B File Offset: 0x00250F2B
		public Span<byte> GetCNRootUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007DE9 RID: 32233 RVA: 0x00252D3A File Offset: 0x00250F3A
		public byte[] GetCNRootUrlArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06007DEA RID: 32234 RVA: 0x00252D54 File Offset: 0x00250F54
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

		// Token: 0x06007DEB RID: 32235 RVA: 0x00252D8B File Offset: 0x00250F8B
		public Span<byte> GetOverseaRootUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007DEC RID: 32236 RVA: 0x00252D9A File Offset: 0x00250F9A
		public byte[] GetOverseaRootUrlArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06007DED RID: 32237 RVA: 0x00252DB4 File Offset: 0x00250FB4
		public string BgPath
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

		// Token: 0x06007DEE RID: 32238 RVA: 0x00252DEC File Offset: 0x00250FEC
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007DEF RID: 32239 RVA: 0x00252DFC File Offset: 0x00250FFC
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D9A RID: 19866
		private Table __p;
	}
}
