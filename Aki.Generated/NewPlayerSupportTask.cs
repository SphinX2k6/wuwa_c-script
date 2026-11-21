using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6D RID: 3949
	public struct NewPlayerSupportTask : IFlatbufferObject
	{
		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x0600A4FC RID: 42236 RVA: 0x002BA78D File Offset: 0x002B898D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A4FD RID: 42237 RVA: 0x002BA79A File Offset: 0x002B899A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A4FE RID: 42238 RVA: 0x002BA7A4 File Offset: 0x002B89A4
		public static NewPlayerSupportTask GetRootAsNewPlayerSupportTask(ByteBuffer _bb)
		{
			return NewPlayerSupportTask.GetRootAsNewPlayerSupportTask(_bb, default(NewPlayerSupportTask));
		}

		// Token: 0x0600A4FF RID: 42239 RVA: 0x002BA7C0 File Offset: 0x002B89C0
		public static NewPlayerSupportTask GetRootAsNewPlayerSupportTask(ByteBuffer _bb, NewPlayerSupportTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A500 RID: 42240 RVA: 0x002BA7DD File Offset: 0x002B89DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A501 RID: 42241 RVA: 0x002BA7EC File Offset: 0x002B89EC
		public NewPlayerSupportTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700238B RID: 9099
		// (get) Token: 0x0600A502 RID: 42242 RVA: 0x002BA7FC File Offset: 0x002B89FC
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

		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x0600A503 RID: 42243 RVA: 0x002BA838 File Offset: 0x002B8A38
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

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x0600A504 RID: 42244 RVA: 0x002BA874 File Offset: 0x002B8A74
		public int Index
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

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x0600A505 RID: 42245 RVA: 0x002BA8B0 File Offset: 0x002B8AB0
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

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x0600A506 RID: 42246 RVA: 0x002BA8F0 File Offset: 0x002B8AF0
		public int NormalDropId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x0600A507 RID: 42247 RVA: 0x002BA930 File Offset: 0x002B8B30
		public int TrialRoleGroupId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x0600A508 RID: 42248 RVA: 0x002BA970 File Offset: 0x002B8B70
		public string RewardName
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A509 RID: 42249 RVA: 0x002BA9A8 File Offset: 0x002B8BA8
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A50A RID: 42250 RVA: 0x002BA9B8 File Offset: 0x002B8BB8
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0400551B RID: 21787
		private Table __p;
	}
}
