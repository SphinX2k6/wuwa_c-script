using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001042 RID: 4162
	public struct RoleDevelopType : IFlatbufferObject
	{
		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600C7ED RID: 51181 RVA: 0x002F90E1 File Offset: 0x002F72E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C7EE RID: 51182 RVA: 0x002F90EE File Offset: 0x002F72EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C7EF RID: 51183 RVA: 0x002F90F8 File Offset: 0x002F72F8
		public static RoleDevelopType GetRootAsRoleDevelopType(ByteBuffer _bb)
		{
			return RoleDevelopType.GetRootAsRoleDevelopType(_bb, default(RoleDevelopType));
		}

		// Token: 0x0600C7F0 RID: 51184 RVA: 0x002F9114 File Offset: 0x002F7314
		public static RoleDevelopType GetRootAsRoleDevelopType(ByteBuffer _bb, RoleDevelopType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C7F1 RID: 51185 RVA: 0x002F9131 File Offset: 0x002F7331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C7F2 RID: 51186 RVA: 0x002F9140 File Offset: 0x002F7340
		public RoleDevelopType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0600C7F3 RID: 51187 RVA: 0x002F9150 File Offset: 0x002F7350
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

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600C7F4 RID: 51188 RVA: 0x002F918C File Offset: 0x002F738C
		public string Icon
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

		// Token: 0x0600C7F5 RID: 51189 RVA: 0x002F91C3 File Offset: 0x002F73C3
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C7F6 RID: 51190 RVA: 0x002F91D2 File Offset: 0x002F73D2
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005140 RID: 20800
		private Table __p;
	}
}
