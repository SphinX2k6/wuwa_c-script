using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103C RID: 4156
	public struct RoleBody : IFlatbufferObject
	{
		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600C76D RID: 51053 RVA: 0x002F7EB8 File Offset: 0x002F60B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C76E RID: 51054 RVA: 0x002F7EC5 File Offset: 0x002F60C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C76F RID: 51055 RVA: 0x002F7ECC File Offset: 0x002F60CC
		public static RoleBody GetRootAsRoleBody(ByteBuffer _bb)
		{
			return RoleBody.GetRootAsRoleBody(_bb, default(RoleBody));
		}

		// Token: 0x0600C770 RID: 51056 RVA: 0x002F7EE8 File Offset: 0x002F60E8
		public static RoleBody GetRootAsRoleBody(ByteBuffer _bb, RoleBody obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C771 RID: 51057 RVA: 0x002F7F05 File Offset: 0x002F6105
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C772 RID: 51058 RVA: 0x002F7F14 File Offset: 0x002F6114
		public RoleBody __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600C773 RID: 51059 RVA: 0x002F7F24 File Offset: 0x002F6124
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

		// Token: 0x0600C774 RID: 51060 RVA: 0x002F7F5B File Offset: 0x002F615B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600C775 RID: 51061 RVA: 0x002F7F6A File Offset: 0x002F616A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600C776 RID: 51062 RVA: 0x002F7F84 File Offset: 0x002F6184
		public string MotorStandAnimPath
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

		// Token: 0x0600C777 RID: 51063 RVA: 0x002F7FBB File Offset: 0x002F61BB
		public Span<byte> GetMotorStandAnimPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C778 RID: 51064 RVA: 0x002F7FCA File Offset: 0x002F61CA
		public byte[] GetMotorStandAnimPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005139 RID: 20793
		private Table __p;
	}
}
