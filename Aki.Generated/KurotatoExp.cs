using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9D RID: 3485
	public struct KurotatoExp : IFlatbufferObject
	{
		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x0600896C RID: 35180 RVA: 0x0026D879 File Offset: 0x0026BA79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600896D RID: 35181 RVA: 0x0026D886 File Offset: 0x0026BA86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600896E RID: 35182 RVA: 0x0026D890 File Offset: 0x0026BA90
		public static KurotatoExp GetRootAsKurotatoExp(ByteBuffer _bb)
		{
			return KurotatoExp.GetRootAsKurotatoExp(_bb, default(KurotatoExp));
		}

		// Token: 0x0600896F RID: 35183 RVA: 0x0026D8AC File Offset: 0x0026BAAC
		public static KurotatoExp GetRootAsKurotatoExp(ByteBuffer _bb, KurotatoExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008970 RID: 35184 RVA: 0x0026D8C9 File Offset: 0x0026BAC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008971 RID: 35185 RVA: 0x0026D8D8 File Offset: 0x0026BAD8
		public KurotatoExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06008972 RID: 35186 RVA: 0x0026D8E8 File Offset: 0x0026BAE8
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

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06008973 RID: 35187 RVA: 0x0026D924 File Offset: 0x0026BB24
		public int RoleLevel
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

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06008974 RID: 35188 RVA: 0x0026D960 File Offset: 0x0026BB60
		public int ActivityId
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

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06008975 RID: 35189 RVA: 0x0026D99C File Offset: 0x0026BB9C
		public int LevelExp
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

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06008976 RID: 35190 RVA: 0x0026D9DC File Offset: 0x0026BBDC
		public int Type
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004E2D RID: 20013
		private Table __p;
	}
}
