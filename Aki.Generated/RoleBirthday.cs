using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103B RID: 4155
	public struct RoleBirthday : IFlatbufferObject
	{
		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600C759 RID: 51033 RVA: 0x002F7C51 File Offset: 0x002F5E51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C75A RID: 51034 RVA: 0x002F7C5E File Offset: 0x002F5E5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C75B RID: 51035 RVA: 0x002F7C68 File Offset: 0x002F5E68
		public static RoleBirthday GetRootAsRoleBirthday(ByteBuffer _bb)
		{
			return RoleBirthday.GetRootAsRoleBirthday(_bb, default(RoleBirthday));
		}

		// Token: 0x0600C75C RID: 51036 RVA: 0x002F7C84 File Offset: 0x002F5E84
		public static RoleBirthday GetRootAsRoleBirthday(ByteBuffer _bb, RoleBirthday obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C75D RID: 51037 RVA: 0x002F7CA1 File Offset: 0x002F5EA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C75E RID: 51038 RVA: 0x002F7CB0 File Offset: 0x002F5EB0
		public RoleBirthday __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600C75F RID: 51039 RVA: 0x002F7CC0 File Offset: 0x002F5EC0
		public int RoleId
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

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600C760 RID: 51040 RVA: 0x002F7CFC File Offset: 0x002F5EFC
		public int Priority
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

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600C761 RID: 51041 RVA: 0x002F7D38 File Offset: 0x002F5F38
		public string CardTextKey
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

		// Token: 0x0600C762 RID: 51042 RVA: 0x002F7D6F File Offset: 0x002F5F6F
		public Span<byte> GetCardTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C763 RID: 51043 RVA: 0x002F7D7E File Offset: 0x002F5F7E
		public byte[] GetCardTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600C764 RID: 51044 RVA: 0x002F7D98 File Offset: 0x002F5F98
		public string VoiceEvent
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

		// Token: 0x0600C765 RID: 51045 RVA: 0x002F7DD0 File Offset: 0x002F5FD0
		public Span<byte> GetVoiceEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C766 RID: 51046 RVA: 0x002F7DE0 File Offset: 0x002F5FE0
		public byte[] GetVoiceEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600C767 RID: 51047 RVA: 0x002F7DF8 File Offset: 0x002F5FF8
		public string SceneCameraId
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

		// Token: 0x0600C768 RID: 51048 RVA: 0x002F7E30 File Offset: 0x002F6030
		public Span<byte> GetSceneCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C769 RID: 51049 RVA: 0x002F7E40 File Offset: 0x002F6040
		public byte[] GetSceneCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600C76A RID: 51050 RVA: 0x002F7E58 File Offset: 0x002F6058
		public string CardCameraId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C76B RID: 51051 RVA: 0x002F7E90 File Offset: 0x002F6090
		public Span<byte> GetCardCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C76C RID: 51052 RVA: 0x002F7EA0 File Offset: 0x002F60A0
		public byte[] GetCardCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005138 RID: 20792
		private Table __p;
	}
}
