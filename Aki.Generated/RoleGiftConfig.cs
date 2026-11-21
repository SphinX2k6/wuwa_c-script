using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001134 RID: 4404
	public struct RoleGiftConfig : IFlatbufferObject
	{
		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600CED2 RID: 52946 RVA: 0x0031615C File Offset: 0x0031435C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CED3 RID: 52947 RVA: 0x00316169 File Offset: 0x00314369
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CED4 RID: 52948 RVA: 0x00316170 File Offset: 0x00314370
		public static RoleGiftConfig GetRootAsRoleGiftConfig(ByteBuffer _bb)
		{
			return RoleGiftConfig.GetRootAsRoleGiftConfig(_bb, default(RoleGiftConfig));
		}

		// Token: 0x0600CED5 RID: 52949 RVA: 0x0031618C File Offset: 0x0031438C
		public static RoleGiftConfig GetRootAsRoleGiftConfig(ByteBuffer _bb, RoleGiftConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CED6 RID: 52950 RVA: 0x003161A9 File Offset: 0x003143A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CED7 RID: 52951 RVA: 0x003161B8 File Offset: 0x003143B8
		public RoleGiftConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0600CED8 RID: 52952 RVA: 0x003161C8 File Offset: 0x003143C8
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

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0600CED9 RID: 52953 RVA: 0x00316204 File Offset: 0x00314404
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

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0600CEDA RID: 52954 RVA: 0x00316240 File Offset: 0x00314440
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

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0600CEDB RID: 52955 RVA: 0x0031627C File Offset: 0x0031447C
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

		// Token: 0x0600CEDC RID: 52956 RVA: 0x003162B4 File Offset: 0x003144B4
		public Span<byte> GetMainPrefabIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CEDD RID: 52957 RVA: 0x003162C4 File Offset: 0x003144C4
		public byte[] GetMainPrefabIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0600CEDE RID: 52958 RVA: 0x003162DC File Offset: 0x003144DC
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

		// Token: 0x0600CEDF RID: 52959 RVA: 0x00316314 File Offset: 0x00314514
		public Span<byte> GetSplashPrefabIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CEE0 RID: 52960 RVA: 0x00316324 File Offset: 0x00314524
		public byte[] GetSplashPrefabIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005732 RID: 22322
		private Table __p;
	}
}
