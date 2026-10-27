using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200452A RID: 17706
	public struct IMultiplayerRefresh : IFlatbufferObject
	{
		// Token: 0x17007D95 RID: 32149
		// (get) Token: 0x0601A9F7 RID: 109047 RVA: 0x003CCD97 File Offset: 0x003CAF97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A9F8 RID: 109048 RVA: 0x003CCDA4 File Offset: 0x003CAFA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A9F9 RID: 109049 RVA: 0x003CCDAC File Offset: 0x003CAFAC
		public static IMultiplayerRefresh GetRootAsIMultiplayerRefresh(ByteBuffer _bb)
		{
			return IMultiplayerRefresh.GetRootAsIMultiplayerRefresh(_bb, default(IMultiplayerRefresh));
		}

		// Token: 0x0601A9FA RID: 109050 RVA: 0x003CCDC8 File Offset: 0x003CAFC8
		public static IMultiplayerRefresh GetRootAsIMultiplayerRefresh(ByteBuffer _bb, IMultiplayerRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A9FB RID: 109051 RVA: 0x003CCDE5 File Offset: 0x003CAFE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A9FC RID: 109052 RVA: 0x003CCDF4 File Offset: 0x003CAFF4
		public IMultiplayerRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D96 RID: 32150
		// (get) Token: 0x0601A9FD RID: 109053 RVA: 0x003CCE04 File Offset: 0x003CB004
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

		// Token: 0x17007D97 RID: 32151
		// (get) Token: 0x0601A9FE RID: 109054 RVA: 0x003CCE40 File Offset: 0x003CB040
		public int AllPlayerAwardedRefreshTime
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

		// Token: 0x17007D98 RID: 32152
		// (get) Token: 0x0601A9FF RID: 109055 RVA: 0x003CCE7C File Offset: 0x003CB07C
		public int AnyPlayerAwardedRefreshTime
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

		// Token: 0x17007D99 RID: 32153
		// (get) Token: 0x0601AA00 RID: 109056 RVA: 0x003CCEB8 File Offset: 0x003CB0B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AA01 RID: 109057 RVA: 0x003CCEF5 File Offset: 0x003CB0F5
		public static Offset<IMultiplayerRefresh> CreateIMultiplayerRefresh(FlatBufferBuilder builder, int CompletedRefreshTime = 0, int AllPlayerAwardedRefreshTime = 0, int AnyPlayerAwardedRefreshTime = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IMultiplayerRefresh.AddAnyPlayerAwardedRefreshTime(builder, AnyPlayerAwardedRefreshTime);
			IMultiplayerRefresh.AddAllPlayerAwardedRefreshTime(builder, AllPlayerAwardedRefreshTime);
			IMultiplayerRefresh.AddCompletedRefreshTime(builder, CompletedRefreshTime);
			IMultiplayerRefresh.AddNullMask(builder, NullMask);
			return IMultiplayerRefresh.EndIMultiplayerRefresh(builder);
		}

		// Token: 0x0601AA02 RID: 109058 RVA: 0x003CCF21 File Offset: 0x003CB121
		public static void StartIMultiplayerRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601AA03 RID: 109059 RVA: 0x003CCF2A File Offset: 0x003CB12A
		public static void AddCompletedRefreshTime(FlatBufferBuilder builder, int completedRefreshTime)
		{
			builder.AddInt(0, completedRefreshTime, 0);
		}

		// Token: 0x0601AA04 RID: 109060 RVA: 0x003CCF35 File Offset: 0x003CB135
		public static void AddAllPlayerAwardedRefreshTime(FlatBufferBuilder builder, int allPlayerAwardedRefreshTime)
		{
			builder.AddInt(1, allPlayerAwardedRefreshTime, 0);
		}

		// Token: 0x0601AA05 RID: 109061 RVA: 0x003CCF40 File Offset: 0x003CB140
		public static void AddAnyPlayerAwardedRefreshTime(FlatBufferBuilder builder, int anyPlayerAwardedRefreshTime)
		{
			builder.AddInt(2, anyPlayerAwardedRefreshTime, 0);
		}

		// Token: 0x0601AA06 RID: 109062 RVA: 0x003CCF4B File Offset: 0x003CB14B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601AA07 RID: 109063 RVA: 0x003CCF56 File Offset: 0x003CB156
		public static Offset<IMultiplayerRefresh> EndIMultiplayerRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IMultiplayerRefresh>(builder.EndTable());
		}

		// Token: 0x0601AA08 RID: 109064 RVA: 0x003CCF64 File Offset: 0x003CB164
		public IMultiplayerRefreshT UnPack()
		{
			IMultiplayerRefreshT multiplayerRefreshT = new IMultiplayerRefreshT();
			this.UnPackTo(multiplayerRefreshT);
			return multiplayerRefreshT;
		}

		// Token: 0x0601AA09 RID: 109065 RVA: 0x003CCF7F File Offset: 0x003CB17F
		public void UnPackTo(IMultiplayerRefreshT _o)
		{
			_o.CompletedRefreshTime = this.CompletedRefreshTime;
			_o.AllPlayerAwardedRefreshTime = this.AllPlayerAwardedRefreshTime;
			_o.AnyPlayerAwardedRefreshTime = this.AnyPlayerAwardedRefreshTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601AA0A RID: 109066 RVA: 0x003CCFB4 File Offset: 0x003CB1B4
		public static Offset<IMultiplayerRefresh> Pack(FlatBufferBuilder builder, IMultiplayerRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMultiplayerRefresh>);
			}
			return IMultiplayerRefresh.CreateIMultiplayerRefresh(builder, _o.CompletedRefreshTime, _o.AllPlayerAwardedRefreshTime, _o.AnyPlayerAwardedRefreshTime, _o.NullMask);
		}

		// Token: 0x0400C5AE RID: 50606
		private Table __p;
	}
}
