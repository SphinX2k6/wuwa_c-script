using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103A RID: 4154
	public struct RoleBeHitMap : IFlatbufferObject
	{
		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600C74F RID: 51023 RVA: 0x002F7B49 File Offset: 0x002F5D49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C750 RID: 51024 RVA: 0x002F7B56 File Offset: 0x002F5D56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C751 RID: 51025 RVA: 0x002F7B60 File Offset: 0x002F5D60
		public static RoleBeHitMap GetRootAsRoleBeHitMap(ByteBuffer _bb)
		{
			return RoleBeHitMap.GetRootAsRoleBeHitMap(_bb, default(RoleBeHitMap));
		}

		// Token: 0x0600C752 RID: 51026 RVA: 0x002F7B7C File Offset: 0x002F5D7C
		public static RoleBeHitMap GetRootAsRoleBeHitMap(ByteBuffer _bb, RoleBeHitMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C753 RID: 51027 RVA: 0x002F7B99 File Offset: 0x002F5D99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C754 RID: 51028 RVA: 0x002F7BA8 File Offset: 0x002F5DA8
		public RoleBeHitMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600C755 RID: 51029 RVA: 0x002F7BB8 File Offset: 0x002F5DB8
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

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600C756 RID: 51030 RVA: 0x002F7BF4 File Offset: 0x002F5DF4
		public string StateMachineName
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

		// Token: 0x0600C757 RID: 51031 RVA: 0x002F7C2B File Offset: 0x002F5E2B
		public Span<byte> GetStateMachineNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C758 RID: 51032 RVA: 0x002F7C3A File Offset: 0x002F5E3A
		public byte[] GetStateMachineNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005137 RID: 20791
		private Table __p;
	}
}
