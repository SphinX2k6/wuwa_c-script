using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1A RID: 3098
	public struct BlackSwordGameplay : IFlatbufferObject
	{
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06005385 RID: 21381 RVA: 0x00204E55 File Offset: 0x00203055
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x00204E62 File Offset: 0x00203062
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x00204E6C File Offset: 0x0020306C
		public static BlackSwordGameplay GetRootAsBlackSwordGameplay(ByteBuffer _bb)
		{
			return BlackSwordGameplay.GetRootAsBlackSwordGameplay(_bb, default(BlackSwordGameplay));
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x00204E88 File Offset: 0x00203088
		public static BlackSwordGameplay GetRootAsBlackSwordGameplay(ByteBuffer _bb, BlackSwordGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x00204EA5 File Offset: 0x002030A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x00204EB4 File Offset: 0x002030B4
		public BlackSwordGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600538B RID: 21387 RVA: 0x00204EC4 File Offset: 0x002030C4
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

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600538C RID: 21388 RVA: 0x00204F00 File Offset: 0x00203100
		public int UIConfigId
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

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600538D RID: 21389 RVA: 0x00204F3C File Offset: 0x0020313C
		public string TitleText
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

		// Token: 0x0600538E RID: 21390 RVA: 0x00204F73 File Offset: 0x00203173
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x00204F82 File Offset: 0x00203182
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06005390 RID: 21392 RVA: 0x00204F9C File Offset: 0x0020319C
		public string GoalText
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x00204FD4 File Offset: 0x002031D4
		public Span<byte> GetGoalTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x00204FE4 File Offset: 0x002031E4
		public byte[] GetGoalTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06005393 RID: 21395 RVA: 0x00204FFC File Offset: 0x002031FC
		public string MapGoalText
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

		// Token: 0x06005394 RID: 21396 RVA: 0x00205034 File Offset: 0x00203234
		public Span<byte> GetMapGoalTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x00205044 File Offset: 0x00203244
		public byte[] GetMapGoalTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06005396 RID: 21398 RVA: 0x0020505C File Offset: 0x0020325C
		public string RuleText
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

		// Token: 0x06005397 RID: 21399 RVA: 0x00205094 File Offset: 0x00203294
		public Span<byte> GetRuleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x002050A4 File Offset: 0x002032A4
		public byte[] GetRuleTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005115 RID: 20757
		private Table __p;
	}
}
