using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BEF RID: 3055
	public struct AvgLocationChange : IFlatbufferObject
	{
		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06004F38 RID: 20280 RVA: 0x001FA410 File Offset: 0x001F8610
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x001FA41D File Offset: 0x001F861D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x001FA424 File Offset: 0x001F8624
		public static AvgLocationChange GetRootAsAvgLocationChange(ByteBuffer _bb)
		{
			return AvgLocationChange.GetRootAsAvgLocationChange(_bb, default(AvgLocationChange));
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x001FA440 File Offset: 0x001F8640
		public static AvgLocationChange GetRootAsAvgLocationChange(ByteBuffer _bb, AvgLocationChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x001FA45D File Offset: 0x001F865D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x001FA46C File Offset: 0x001F866C
		public AvgLocationChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06004F3E RID: 20286 RVA: 0x001FA47C File Offset: 0x001F867C
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

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06004F3F RID: 20287 RVA: 0x001FA4B8 File Offset: 0x001F86B8
		public int Text
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

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06004F40 RID: 20288 RVA: 0x001FA4F4 File Offset: 0x001F86F4
		public string IconPath
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

		// Token: 0x06004F41 RID: 20289 RVA: 0x001FA52B File Offset: 0x001F872B
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x001FA53A File Offset: 0x001F873A
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040050D7 RID: 20695
		private Table __p;
	}
}
