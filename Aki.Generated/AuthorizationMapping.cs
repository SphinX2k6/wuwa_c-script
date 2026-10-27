using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B10 RID: 2832
	public struct AuthorizationMapping : IFlatbufferObject
	{
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060049AA RID: 18858 RVA: 0x001DA46D File Offset: 0x001D866D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x001DA47A File Offset: 0x001D867A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x001DA484 File Offset: 0x001D8684
		public static AuthorizationMapping GetRootAsAuthorizationMapping(ByteBuffer _bb)
		{
			return AuthorizationMapping.GetRootAsAuthorizationMapping(_bb, default(AuthorizationMapping));
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x001DA4A0 File Offset: 0x001D86A0
		public static AuthorizationMapping GetRootAsAuthorizationMapping(ByteBuffer _bb, AuthorizationMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x001DA4BD File Offset: 0x001D86BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x001DA4CC File Offset: 0x001D86CC
		public AuthorizationMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060049B0 RID: 18864 RVA: 0x001DA4DC File Offset: 0x001D86DC
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

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060049B1 RID: 18865 RVA: 0x001DA518 File Offset: 0x001D8718
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

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060049B2 RID: 18866 RVA: 0x001DA554 File Offset: 0x001D8754
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

		// Token: 0x04004AF8 RID: 19192
		private Table __p;
	}
}
