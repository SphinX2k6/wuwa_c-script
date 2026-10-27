using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104C RID: 4172
	public struct RoleGiftConfig : IFlatbufferObject
	{
		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600C888 RID: 51336 RVA: 0x002FA490 File Offset: 0x002F8690
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C889 RID: 51337 RVA: 0x002FA49D File Offset: 0x002F869D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C88A RID: 51338 RVA: 0x002FA4A4 File Offset: 0x002F86A4
		public static RoleGiftConfig GetRootAsRoleGiftConfig(ByteBuffer _bb)
		{
			return RoleGiftConfig.GetRootAsRoleGiftConfig(_bb, default(RoleGiftConfig));
		}

		// Token: 0x0600C88B RID: 51339 RVA: 0x002FA4C0 File Offset: 0x002F86C0
		public static RoleGiftConfig GetRootAsRoleGiftConfig(ByteBuffer _bb, RoleGiftConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C88C RID: 51340 RVA: 0x002FA4DD File Offset: 0x002F86DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C88D RID: 51341 RVA: 0x002FA4EC File Offset: 0x002F86EC
		public RoleGiftConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600C88E RID: 51342 RVA: 0x002FA4FC File Offset: 0x002F86FC
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

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600C88F RID: 51343 RVA: 0x002FA538 File Offset: 0x002F8738
		public int ActivityId
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

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600C890 RID: 51344 RVA: 0x002FA574 File Offset: 0x002F8774
		public int DropId
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

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600C891 RID: 51345 RVA: 0x002FA5B0 File Offset: 0x002F87B0
		public string MainPrefabId
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

		// Token: 0x0600C892 RID: 51346 RVA: 0x002FA5E8 File Offset: 0x002F87E8
		public Span<byte> GetMainPrefabIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C893 RID: 51347 RVA: 0x002FA5F8 File Offset: 0x002F87F8
		public byte[] GetMainPrefabIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600C894 RID: 51348 RVA: 0x002FA610 File Offset: 0x002F8810
		public string SplashPrefabId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C895 RID: 51349 RVA: 0x002FA648 File Offset: 0x002F8848
		public Span<byte> GetSplashPrefabIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C896 RID: 51350 RVA: 0x002FA658 File Offset: 0x002F8858
		public byte[] GetSplashPrefabIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400514A RID: 20810
		private Table __p;
	}
}
