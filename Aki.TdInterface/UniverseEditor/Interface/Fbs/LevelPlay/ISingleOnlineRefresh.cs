using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045AE RID: 17838
	public struct ISingleOnlineRefresh : IFlatbufferObject
	{
		// Token: 0x17007EC7 RID: 32455
		// (get) Token: 0x0601AF7B RID: 110459 RVA: 0x003D899A File Offset: 0x003D6B9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AF7C RID: 110460 RVA: 0x003D89A7 File Offset: 0x003D6BA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AF7D RID: 110461 RVA: 0x003D89B0 File Offset: 0x003D6BB0
		public static ISingleOnlineRefresh GetRootAsISingleOnlineRefresh(ByteBuffer _bb)
		{
			return ISingleOnlineRefresh.GetRootAsISingleOnlineRefresh(_bb, default(ISingleOnlineRefresh));
		}

		// Token: 0x0601AF7E RID: 110462 RVA: 0x003D89CC File Offset: 0x003D6BCC
		public static ISingleOnlineRefresh GetRootAsISingleOnlineRefresh(ByteBuffer _bb, ISingleOnlineRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AF7F RID: 110463 RVA: 0x003D89E9 File Offset: 0x003D6BE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AF80 RID: 110464 RVA: 0x003D89F8 File Offset: 0x003D6BF8
		public ISingleOnlineRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EC8 RID: 32456
		// (get) Token: 0x0601AF81 RID: 110465 RVA: 0x003D8A08 File Offset: 0x003D6C08
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

		// Token: 0x17007EC9 RID: 32457
		// (get) Token: 0x0601AF82 RID: 110466 RVA: 0x003D8A44 File Offset: 0x003D6C44
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

		// Token: 0x17007ECA RID: 32458
		// (get) Token: 0x0601AF83 RID: 110467 RVA: 0x003D8A80 File Offset: 0x003D6C80
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

		// Token: 0x0601AF84 RID: 110468 RVA: 0x003D8ABC File Offset: 0x003D6CBC
		public static Offset<ISingleOnlineRefresh> CreateISingleOnlineRefresh(FlatBufferBuilder builder, int CompletedRefreshTime = 0, int AwardedRefreshTime = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISingleOnlineRefresh.AddAwardedRefreshTime(builder, AwardedRefreshTime);
			ISingleOnlineRefresh.AddCompletedRefreshTime(builder, CompletedRefreshTime);
			ISingleOnlineRefresh.AddNullMask(builder, NullMask);
			return ISingleOnlineRefresh.EndISingleOnlineRefresh(builder);
		}

		// Token: 0x0601AF85 RID: 110469 RVA: 0x003D8AE0 File Offset: 0x003D6CE0
		public static void StartISingleOnlineRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601AF86 RID: 110470 RVA: 0x003D8AE9 File Offset: 0x003D6CE9
		public static void AddCompletedRefreshTime(FlatBufferBuilder builder, int completedRefreshTime)
		{
			builder.AddInt(0, completedRefreshTime, 0);
		}

		// Token: 0x0601AF87 RID: 110471 RVA: 0x003D8AF4 File Offset: 0x003D6CF4
		public static void AddAwardedRefreshTime(FlatBufferBuilder builder, int awardedRefreshTime)
		{
			builder.AddInt(1, awardedRefreshTime, 0);
		}

		// Token: 0x0601AF88 RID: 110472 RVA: 0x003D8AFF File Offset: 0x003D6CFF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601AF89 RID: 110473 RVA: 0x003D8B0A File Offset: 0x003D6D0A
		public static Offset<ISingleOnlineRefresh> EndISingleOnlineRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ISingleOnlineRefresh>(builder.EndTable());
		}

		// Token: 0x0601AF8A RID: 110474 RVA: 0x003D8B18 File Offset: 0x003D6D18
		public ISingleOnlineRefreshT UnPack()
		{
			ISingleOnlineRefreshT singleOnlineRefreshT = new ISingleOnlineRefreshT();
			this.UnPackTo(singleOnlineRefreshT);
			return singleOnlineRefreshT;
		}

		// Token: 0x0601AF8B RID: 110475 RVA: 0x003D8B33 File Offset: 0x003D6D33
		public void UnPackTo(ISingleOnlineRefreshT _o)
		{
			_o.CompletedRefreshTime = this.CompletedRefreshTime;
			_o.AwardedRefreshTime = this.AwardedRefreshTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601AF8C RID: 110476 RVA: 0x003D8B5C File Offset: 0x003D6D5C
		public static Offset<ISingleOnlineRefresh> Pack(FlatBufferBuilder builder, ISingleOnlineRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISingleOnlineRefresh>);
			}
			return ISingleOnlineRefresh.CreateISingleOnlineRefresh(builder, _o.CompletedRefreshTime, _o.AwardedRefreshTime, _o.NullMask);
		}

		// Token: 0x0400C676 RID: 50806
		private Table __p;
	}
}
