using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112A RID: 4394
	public struct RoleDevelopType : IFlatbufferObject
	{
		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600CE37 RID: 52791 RVA: 0x00314E7D File Offset: 0x0031307D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE38 RID: 52792 RVA: 0x00314E8A File Offset: 0x0031308A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE39 RID: 52793 RVA: 0x00314E94 File Offset: 0x00313094
		public static RoleDevelopType GetRootAsRoleDevelopType(ByteBuffer _bb)
		{
			return RoleDevelopType.GetRootAsRoleDevelopType(_bb, default(RoleDevelopType));
		}

		// Token: 0x0600CE3A RID: 52794 RVA: 0x00314EB0 File Offset: 0x003130B0
		public static RoleDevelopType GetRootAsRoleDevelopType(ByteBuffer _bb, RoleDevelopType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE3B RID: 52795 RVA: 0x00314ECD File Offset: 0x003130CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE3C RID: 52796 RVA: 0x00314EDC File Offset: 0x003130DC
		public RoleDevelopType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0600CE3D RID: 52797 RVA: 0x00314EEC File Offset: 0x003130EC
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

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x0600CE3E RID: 52798 RVA: 0x00314F28 File Offset: 0x00313128
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

		// Token: 0x0600CE3F RID: 52799 RVA: 0x00314F5F File Offset: 0x0031315F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CE40 RID: 52800 RVA: 0x00314F6E File Offset: 0x0031316E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005728 RID: 22312
		private Table __p;
	}
}
