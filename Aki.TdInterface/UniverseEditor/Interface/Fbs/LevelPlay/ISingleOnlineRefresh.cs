using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A16 RID: 18966
	public struct ISingleOnlineRefresh : IFlatbufferObject
	{
		// Token: 0x17008508 RID: 34056
		// (get) Token: 0x0601C750 RID: 116560 RVA: 0x00404C36 File Offset: 0x00402E36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C751 RID: 116561 RVA: 0x00404C43 File Offset: 0x00402E43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C752 RID: 116562 RVA: 0x00404C4C File Offset: 0x00402E4C
		public static ISingleOnlineRefresh GetRootAsISingleOnlineRefresh(ByteBuffer _bb)
		{
			return ISingleOnlineRefresh.GetRootAsISingleOnlineRefresh(_bb, default(ISingleOnlineRefresh));
		}

		// Token: 0x0601C753 RID: 116563 RVA: 0x00404C68 File Offset: 0x00402E68
		public static ISingleOnlineRefresh GetRootAsISingleOnlineRefresh(ByteBuffer _bb, ISingleOnlineRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C754 RID: 116564 RVA: 0x00404C85 File Offset: 0x00402E85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C755 RID: 116565 RVA: 0x00404C94 File Offset: 0x00402E94
		public ISingleOnlineRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008509 RID: 34057
		// (get) Token: 0x0601C756 RID: 116566 RVA: 0x00404CA4 File Offset: 0x00402EA4
		public int CompletedRefreshTime
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

		// Token: 0x1700850A RID: 34058
		// (get) Token: 0x0601C757 RID: 116567 RVA: 0x00404CE0 File Offset: 0x00402EE0
		public int AwardedRefreshTime
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

		// Token: 0x1700850B RID: 34059
		// (get) Token: 0x0601C758 RID: 116568 RVA: 0x00404D1C File Offset: 0x00402F1C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C759 RID: 116569 RVA: 0x00404D58 File Offset: 0x00402F58
		public static Offset<ISingleOnlineRefresh> CreateISingleOnlineRefresh(FlatBufferBuilder builder, int CompletedRefreshTime = 0, int AwardedRefreshTime = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISingleOnlineRefresh.AddAwardedRefreshTime(builder, AwardedRefreshTime);
			ISingleOnlineRefresh.AddCompletedRefreshTime(builder, CompletedRefreshTime);
			ISingleOnlineRefresh.AddNullMask(builder, NullMask);
			return ISingleOnlineRefresh.EndISingleOnlineRefresh(builder);
		}

		// Token: 0x0601C75A RID: 116570 RVA: 0x00404D7C File Offset: 0x00402F7C
		public static void StartISingleOnlineRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C75B RID: 116571 RVA: 0x00404D85 File Offset: 0x00402F85
		public static void AddCompletedRefreshTime(FlatBufferBuilder builder, int completedRefreshTime)
		{
			builder.AddInt(0, completedRefreshTime, 0);
		}

		// Token: 0x0601C75C RID: 116572 RVA: 0x00404D90 File Offset: 0x00402F90
		public static void AddAwardedRefreshTime(FlatBufferBuilder builder, int awardedRefreshTime)
		{
			builder.AddInt(1, awardedRefreshTime, 0);
		}

		// Token: 0x0601C75D RID: 116573 RVA: 0x00404D9B File Offset: 0x00402F9B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601C75E RID: 116574 RVA: 0x00404DA6 File Offset: 0x00402FA6
		public static Offset<ISingleOnlineRefresh> EndISingleOnlineRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ISingleOnlineRefresh>(builder.EndTable());
		}

		// Token: 0x0601C75F RID: 116575 RVA: 0x00404DB4 File Offset: 0x00402FB4
		public ISingleOnlineRefreshT UnPack()
		{
			ISingleOnlineRefreshT singleOnlineRefreshT = new ISingleOnlineRefreshT();
			this.UnPackTo(singleOnlineRefreshT);
			return singleOnlineRefreshT;
		}

		// Token: 0x0601C760 RID: 116576 RVA: 0x00404DCF File Offset: 0x00402FCF
		public void UnPackTo(ISingleOnlineRefreshT _o)
		{
			_o.CompletedRefreshTime = this.CompletedRefreshTime;
			_o.AwardedRefreshTime = this.AwardedRefreshTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C761 RID: 116577 RVA: 0x00404DF8 File Offset: 0x00402FF8
		public static Offset<ISingleOnlineRefresh> Pack(FlatBufferBuilder builder, ISingleOnlineRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISingleOnlineRefresh>);
			}
			return ISingleOnlineRefresh.CreateISingleOnlineRefresh(builder, _o.CompletedRefreshTime, _o.AwardedRefreshTime, _o.NullMask);
		}

		// Token: 0x0400D0A5 RID: 53413
		private Table __p;
	}
}
