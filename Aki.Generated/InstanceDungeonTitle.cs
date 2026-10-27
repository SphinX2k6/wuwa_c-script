using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D71 RID: 3441
	public struct InstanceDungeonTitle : IFlatbufferObject
	{
		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06008574 RID: 34164 RVA: 0x00264003 File Offset: 0x00262203
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008575 RID: 34165 RVA: 0x00264010 File Offset: 0x00262210
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008576 RID: 34166 RVA: 0x00264018 File Offset: 0x00262218
		public static InstanceDungeonTitle GetRootAsInstanceDungeonTitle(ByteBuffer _bb)
		{
			return InstanceDungeonTitle.GetRootAsInstanceDungeonTitle(_bb, default(InstanceDungeonTitle));
		}

		// Token: 0x06008577 RID: 34167 RVA: 0x00264034 File Offset: 0x00262234
		public static InstanceDungeonTitle GetRootAsInstanceDungeonTitle(ByteBuffer _bb, InstanceDungeonTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008578 RID: 34168 RVA: 0x00264051 File Offset: 0x00262251
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008579 RID: 34169 RVA: 0x00264060 File Offset: 0x00262260
		public InstanceDungeonTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x0600857A RID: 34170 RVA: 0x00264070 File Offset: 0x00262270
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

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x0600857B RID: 34171 RVA: 0x002640AC File Offset: 0x002622AC
		public string CommonText
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

		// Token: 0x0600857C RID: 34172 RVA: 0x002640E3 File Offset: 0x002622E3
		public Span<byte> GetCommonTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600857D RID: 34173 RVA: 0x002640F2 File Offset: 0x002622F2
		public byte[] GetCommonTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x0600857E RID: 34174 RVA: 0x0026410C File Offset: 0x0026230C
		public string IconTexture
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

		// Token: 0x0600857F RID: 34175 RVA: 0x00264143 File Offset: 0x00262343
		public Span<byte> GetIconTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008580 RID: 34176 RVA: 0x00264152 File Offset: 0x00262352
		public byte[] GetIconTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DF9 RID: 19961
		private Table __p;
	}
}
