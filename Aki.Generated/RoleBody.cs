using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001124 RID: 4388
	public struct RoleBody : IFlatbufferObject
	{
		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600CDB7 RID: 52663 RVA: 0x00313D2C File Offset: 0x00311F2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CDB8 RID: 52664 RVA: 0x00313D39 File Offset: 0x00311F39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CDB9 RID: 52665 RVA: 0x00313D40 File Offset: 0x00311F40
		public static RoleBody GetRootAsRoleBody(ByteBuffer _bb)
		{
			return RoleBody.GetRootAsRoleBody(_bb, default(RoleBody));
		}

		// Token: 0x0600CDBA RID: 52666 RVA: 0x00313D5C File Offset: 0x00311F5C
		public static RoleBody GetRootAsRoleBody(ByteBuffer _bb, RoleBody obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDBB RID: 52667 RVA: 0x00313D79 File Offset: 0x00311F79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDBC RID: 52668 RVA: 0x00313D88 File Offset: 0x00311F88
		public RoleBody __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600CDBD RID: 52669 RVA: 0x00313D98 File Offset: 0x00311F98
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

		// Token: 0x0600CDBE RID: 52670 RVA: 0x00313DCF File Offset: 0x00311FCF
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600CDBF RID: 52671 RVA: 0x00313DDE File Offset: 0x00311FDE
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600CDC0 RID: 52672 RVA: 0x00313DF8 File Offset: 0x00311FF8
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

		// Token: 0x0600CDC1 RID: 52673 RVA: 0x00313E2F File Offset: 0x0031202F
		public Span<byte> GetMotorStandAnimPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CDC2 RID: 52674 RVA: 0x00313E3E File Offset: 0x0031203E
		public byte[] GetMotorStandAnimPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005721 RID: 22305
		private Table __p;
	}
}
