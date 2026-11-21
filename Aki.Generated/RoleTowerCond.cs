using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114C RID: 4428
	public struct RoleTowerCond : IFlatbufferObject
	{
		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600D1E6 RID: 53734 RVA: 0x0031D5F4 File Offset: 0x0031B7F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D1E7 RID: 53735 RVA: 0x0031D601 File Offset: 0x0031B801
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D1E8 RID: 53736 RVA: 0x0031D608 File Offset: 0x0031B808
		public static RoleTowerCond GetRootAsRoleTowerCond(ByteBuffer _bb)
		{
			return RoleTowerCond.GetRootAsRoleTowerCond(_bb, default(RoleTowerCond));
		}

		// Token: 0x0600D1E9 RID: 53737 RVA: 0x0031D624 File Offset: 0x0031B824
		public static RoleTowerCond GetRootAsRoleTowerCond(ByteBuffer _bb, RoleTowerCond obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D1EA RID: 53738 RVA: 0x0031D641 File Offset: 0x0031B841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D1EB RID: 53739 RVA: 0x0031D650 File Offset: 0x0031B850
		public RoleTowerCond __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600D1EC RID: 53740 RVA: 0x0031D660 File Offset: 0x0031B860
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

		// Token: 0x04005751 RID: 22353
		private Table __p;
	}
}
