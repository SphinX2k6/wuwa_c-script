using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6E RID: 3950
	public struct NewPlayerSupV2Trial : IFlatbufferObject
	{
		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x0600A50B RID: 42251 RVA: 0x002BA9D0 File Offset: 0x002B8BD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A50C RID: 42252 RVA: 0x002BA9DD File Offset: 0x002B8BDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A50D RID: 42253 RVA: 0x002BA9E4 File Offset: 0x002B8BE4
		public static NewPlayerSupV2Trial GetRootAsNewPlayerSupV2Trial(ByteBuffer _bb)
		{
			return NewPlayerSupV2Trial.GetRootAsNewPlayerSupV2Trial(_bb, default(NewPlayerSupV2Trial));
		}

		// Token: 0x0600A50E RID: 42254 RVA: 0x002BAA00 File Offset: 0x002B8C00
		public static NewPlayerSupV2Trial GetRootAsNewPlayerSupV2Trial(ByteBuffer _bb, NewPlayerSupV2Trial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A50F RID: 42255 RVA: 0x002BAA1D File Offset: 0x002B8C1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x002BAA2C File Offset: 0x002B8C2C
		public NewPlayerSupV2Trial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002393 RID: 9107
		// (get) Token: 0x0600A511 RID: 42257 RVA: 0x002BAA3C File Offset: 0x002B8C3C
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

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x0600A512 RID: 42258 RVA: 0x002BAA78 File Offset: 0x002B8C78
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

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x0600A513 RID: 42259 RVA: 0x002BAAB4 File Offset: 0x002B8CB4
		public int TrialRoleGroupId
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

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x0600A514 RID: 42260 RVA: 0x002BAAF0 File Offset: 0x002B8CF0
		public int ConditionGroup
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x0600A515 RID: 42261 RVA: 0x002BAB30 File Offset: 0x002B8D30
		public string RolePathMale
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

		// Token: 0x0600A516 RID: 42262 RVA: 0x002BAB68 File Offset: 0x002B8D68
		public Span<byte> GetRolePathMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x002BAB78 File Offset: 0x002B8D78
		public byte[] GetRolePathMaleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x0600A518 RID: 42264 RVA: 0x002BAB90 File Offset: 0x002B8D90
		public string RoleBgPathMale
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

		// Token: 0x0600A519 RID: 42265 RVA: 0x002BABC8 File Offset: 0x002B8DC8
		public Span<byte> GetRoleBgPathMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x002BABD8 File Offset: 0x002B8DD8
		public byte[] GetRoleBgPathMaleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400551C RID: 21788
		private Table __p;
	}
}
