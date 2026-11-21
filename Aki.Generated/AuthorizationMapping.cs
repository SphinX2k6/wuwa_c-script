using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BEA RID: 3050
	public struct AuthorizationMapping : IFlatbufferObject
	{
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06004EF1 RID: 20209 RVA: 0x001F9BA1 File Offset: 0x001F7DA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x001F9BAE File Offset: 0x001F7DAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x001F9BB8 File Offset: 0x001F7DB8
		public static AuthorizationMapping GetRootAsAuthorizationMapping(ByteBuffer _bb)
		{
			return AuthorizationMapping.GetRootAsAuthorizationMapping(_bb, default(AuthorizationMapping));
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x001F9BD4 File Offset: 0x001F7DD4
		public static AuthorizationMapping GetRootAsAuthorizationMapping(ByteBuffer _bb, AuthorizationMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x001F9BF1 File Offset: 0x001F7DF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x001F9C00 File Offset: 0x001F7E00
		public AuthorizationMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06004EF7 RID: 20215 RVA: 0x001F9C10 File Offset: 0x001F7E10
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

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06004EF8 RID: 20216 RVA: 0x001F9C4C File Offset: 0x001F7E4C
		public int CountryId
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

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06004EF9 RID: 20217 RVA: 0x001F9C88 File Offset: 0x001F7E88
		public int StateId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040050D2 RID: 20690
		private Table __p;
	}
}
