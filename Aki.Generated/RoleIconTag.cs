using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001136 RID: 4406
	public struct RoleIconTag : IFlatbufferObject
	{
		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600CEF6 RID: 52982 RVA: 0x00316639 File Offset: 0x00314839
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CEF7 RID: 52983 RVA: 0x00316646 File Offset: 0x00314846
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CEF8 RID: 52984 RVA: 0x00316650 File Offset: 0x00314850
		public static RoleIconTag GetRootAsRoleIconTag(ByteBuffer _bb)
		{
			return RoleIconTag.GetRootAsRoleIconTag(_bb, default(RoleIconTag));
		}

		// Token: 0x0600CEF9 RID: 52985 RVA: 0x0031666C File Offset: 0x0031486C
		public static RoleIconTag GetRootAsRoleIconTag(ByteBuffer _bb, RoleIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CEFA RID: 52986 RVA: 0x00316689 File Offset: 0x00314889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CEFB RID: 52987 RVA: 0x00316698 File Offset: 0x00314898
		public RoleIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600CEFC RID: 52988 RVA: 0x003166A8 File Offset: 0x003148A8
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

		// Token: 0x0600CEFD RID: 52989 RVA: 0x003166DF File Offset: 0x003148DF
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600CEFE RID: 52990 RVA: 0x003166EE File Offset: 0x003148EE
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600CEFF RID: 52991 RVA: 0x00316708 File Offset: 0x00314908
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

		// Token: 0x0600CF00 RID: 52992 RVA: 0x0031673F File Offset: 0x0031493F
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CF01 RID: 52993 RVA: 0x0031674E File Offset: 0x0031494E
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005734 RID: 22324
		private Table __p;
	}
}
