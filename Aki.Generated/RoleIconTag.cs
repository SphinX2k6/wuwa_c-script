using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104E RID: 4174
	public struct RoleIconTag : IFlatbufferObject
	{
		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600C8AC RID: 51372 RVA: 0x002FA96D File Offset: 0x002F8B6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C8AD RID: 51373 RVA: 0x002FA97A File Offset: 0x002F8B7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C8AE RID: 51374 RVA: 0x002FA984 File Offset: 0x002F8B84
		public static RoleIconTag GetRootAsRoleIconTag(ByteBuffer _bb)
		{
			return RoleIconTag.GetRootAsRoleIconTag(_bb, default(RoleIconTag));
		}

		// Token: 0x0600C8AF RID: 51375 RVA: 0x002FA9A0 File Offset: 0x002F8BA0
		public static RoleIconTag GetRootAsRoleIconTag(ByteBuffer _bb, RoleIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C8B0 RID: 51376 RVA: 0x002FA9BD File Offset: 0x002F8BBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C8B1 RID: 51377 RVA: 0x002FA9CC File Offset: 0x002F8BCC
		public RoleIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600C8B2 RID: 51378 RVA: 0x002FA9DC File Offset: 0x002F8BDC
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C8B3 RID: 51379 RVA: 0x002FAA13 File Offset: 0x002F8C13
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600C8B4 RID: 51380 RVA: 0x002FAA22 File Offset: 0x002F8C22
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600C8B5 RID: 51381 RVA: 0x002FAA3C File Offset: 0x002F8C3C
		public string ConfigParam
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

		// Token: 0x0600C8B6 RID: 51382 RVA: 0x002FAA73 File Offset: 0x002F8C73
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C8B7 RID: 51383 RVA: 0x002FAA82 File Offset: 0x002F8C82
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400514C RID: 20812
		private Table __p;
	}
}
