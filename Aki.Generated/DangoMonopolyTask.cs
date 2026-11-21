using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBF RID: 3263
	public struct DangoMonopolyTask : IFlatbufferObject
	{
		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06006683 RID: 26243 RVA: 0x0022F6FC File Offset: 0x0022D8FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x0022F709 File Offset: 0x0022D909
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x0022F710 File Offset: 0x0022D910
		public static DangoMonopolyTask GetRootAsDangoMonopolyTask(ByteBuffer _bb)
		{
			return DangoMonopolyTask.GetRootAsDangoMonopolyTask(_bb, default(DangoMonopolyTask));
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x0022F72C File Offset: 0x0022D92C
		public static DangoMonopolyTask GetRootAsDangoMonopolyTask(ByteBuffer _bb, DangoMonopolyTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x0022F749 File Offset: 0x0022D949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x0022F758 File Offset: 0x0022D958
		public DangoMonopolyTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06006689 RID: 26249 RVA: 0x0022F768 File Offset: 0x0022D968
		public int TaskId
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

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x0600668A RID: 26250 RVA: 0x0022F7A4 File Offset: 0x0022D9A4
		public int TaskGroupId
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

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x0600668B RID: 26251 RVA: 0x0022F7E0 File Offset: 0x0022D9E0
		public int Sort
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

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x0600668C RID: 26252 RVA: 0x0022F81C File Offset: 0x0022DA1C
		public int Source
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

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x0600668D RID: 26253 RVA: 0x0022F85C File Offset: 0x0022DA5C
		public int TaskType
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

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x0600668E RID: 26254 RVA: 0x0022F89C File Offset: 0x0022DA9C
		public int ConditionGroupId
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

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x0600668F RID: 26255 RVA: 0x0022F8DC File Offset: 0x0022DADC
		public int ProgressConditionId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06006690 RID: 26256 RVA: 0x0022F91C File Offset: 0x0022DB1C
		public int ItemId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06006691 RID: 26257 RVA: 0x0022F95C File Offset: 0x0022DB5C
		public int ItemNum
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06006692 RID: 26258 RVA: 0x0022F99C File Offset: 0x0022DB9C
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x0022F9D4 File Offset: 0x0022DBD4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x0022F9E4 File Offset: 0x0022DBE4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06006695 RID: 26261 RVA: 0x0022F9FC File Offset: 0x0022DBFC
		public string Title
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x0022FA34 File Offset: 0x0022DC34
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x0022FA44 File Offset: 0x0022DC44
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x040051EC RID: 20972
		private Table __p;
	}
}
