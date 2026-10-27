using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001052 RID: 4178
	public struct RoleInfoLang : IFlatbufferObject
	{
		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600C97F RID: 51583 RVA: 0x002FCAFD File Offset: 0x002FACFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C980 RID: 51584 RVA: 0x002FCB0A File Offset: 0x002FAD0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C981 RID: 51585 RVA: 0x002FCB14 File Offset: 0x002FAD14
		public static RoleInfoLang GetRootAsRoleInfoLang(ByteBuffer _bb)
		{
			return RoleInfoLang.GetRootAsRoleInfoLang(_bb, default(RoleInfoLang));
		}

		// Token: 0x0600C982 RID: 51586 RVA: 0x002FCB30 File Offset: 0x002FAD30
		public static RoleInfoLang GetRootAsRoleInfoLang(ByteBuffer _bb, RoleInfoLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C983 RID: 51587 RVA: 0x002FCB4D File Offset: 0x002FAD4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C984 RID: 51588 RVA: 0x002FCB5C File Offset: 0x002FAD5C
		public RoleInfoLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600C985 RID: 51589 RVA: 0x002FCB6C File Offset: 0x002FAD6C
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

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600C986 RID: 51590 RVA: 0x002FCBA8 File Offset: 0x002FADA8
		public string StateGroupName
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

		// Token: 0x0600C987 RID: 51591 RVA: 0x002FCBDF File Offset: 0x002FADDF
		public Span<byte> GetStateGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C988 RID: 51592 RVA: 0x002FCBEE File Offset: 0x002FADEE
		public byte[] GetStateGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600C989 RID: 51593 RVA: 0x002FCC08 File Offset: 0x002FAE08
		public string InterruptEvent
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

		// Token: 0x0600C98A RID: 51594 RVA: 0x002FCC3F File Offset: 0x002FAE3F
		public Span<byte> GetInterruptEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C98B RID: 51595 RVA: 0x002FCC4E File Offset: 0x002FAE4E
		public byte[] GetInterruptEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005153 RID: 20819
		private Table __p;
	}
}
