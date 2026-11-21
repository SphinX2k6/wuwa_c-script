using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E07 RID: 3591
	public struct H5JumpActivity : IFlatbufferObject
	{
		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x060083FA RID: 33786 RVA: 0x0027155C File Offset: 0x0026F75C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060083FB RID: 33787 RVA: 0x00271569 File Offset: 0x0026F769
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060083FC RID: 33788 RVA: 0x00271570 File Offset: 0x0026F770
		public static H5JumpActivity GetRootAsH5JumpActivity(ByteBuffer _bb)
		{
			return H5JumpActivity.GetRootAsH5JumpActivity(_bb, default(H5JumpActivity));
		}

		// Token: 0x060083FD RID: 33789 RVA: 0x0027158C File Offset: 0x0026F78C
		public static H5JumpActivity GetRootAsH5JumpActivity(ByteBuffer _bb, H5JumpActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060083FE RID: 33790 RVA: 0x002715A9 File Offset: 0x0026F7A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060083FF RID: 33791 RVA: 0x002715B8 File Offset: 0x0026F7B8
		public H5JumpActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06008400 RID: 33792 RVA: 0x002715C8 File Offset: 0x0026F7C8
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

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06008401 RID: 33793 RVA: 0x00271604 File Offset: 0x0026F804
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

		// Token: 0x06008402 RID: 33794 RVA: 0x0027163B File Offset: 0x0026F83B
		public Span<byte> GetCNRootUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008403 RID: 33795 RVA: 0x0027164A File Offset: 0x0026F84A
		public byte[] GetCNRootUrlArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06008404 RID: 33796 RVA: 0x00271664 File Offset: 0x0026F864
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

		// Token: 0x06008405 RID: 33797 RVA: 0x0027169B File Offset: 0x0026F89B
		public Span<byte> GetOverseaRootUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008406 RID: 33798 RVA: 0x002716AA File Offset: 0x0026F8AA
		public byte[] GetOverseaRootUrlArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06008407 RID: 33799 RVA: 0x002716C4 File Offset: 0x0026F8C4
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

		// Token: 0x06008408 RID: 33800 RVA: 0x002716FC File Offset: 0x0026F8FC
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008409 RID: 33801 RVA: 0x0027170C File Offset: 0x0026F90C
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400537F RID: 21375
		private Table __p;
	}
}
