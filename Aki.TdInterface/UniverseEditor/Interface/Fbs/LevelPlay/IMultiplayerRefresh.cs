using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004992 RID: 18834
	public struct IMultiplayerRefresh : IFlatbufferObject
	{
		// Token: 0x170083D6 RID: 33750
		// (get) Token: 0x0601C1CC RID: 115148 RVA: 0x003F9033 File Offset: 0x003F7233
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C1CD RID: 115149 RVA: 0x003F9040 File Offset: 0x003F7240
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C1CE RID: 115150 RVA: 0x003F9048 File Offset: 0x003F7248
		public static IMultiplayerRefresh GetRootAsIMultiplayerRefresh(ByteBuffer _bb)
		{
			return IMultiplayerRefresh.GetRootAsIMultiplayerRefresh(_bb, default(IMultiplayerRefresh));
		}

		// Token: 0x0601C1CF RID: 115151 RVA: 0x003F9064 File Offset: 0x003F7264
		public static IMultiplayerRefresh GetRootAsIMultiplayerRefresh(ByteBuffer _bb, IMultiplayerRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C1D0 RID: 115152 RVA: 0x003F9081 File Offset: 0x003F7281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C1D1 RID: 115153 RVA: 0x003F9090 File Offset: 0x003F7290
		public IMultiplayerRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083D7 RID: 33751
		// (get) Token: 0x0601C1D2 RID: 115154 RVA: 0x003F90A0 File Offset: 0x003F72A0
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

		// Token: 0x170083D8 RID: 33752
		// (get) Token: 0x0601C1D3 RID: 115155 RVA: 0x003F90DC File Offset: 0x003F72DC
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

		// Token: 0x170083D9 RID: 33753
		// (get) Token: 0x0601C1D4 RID: 115156 RVA: 0x003F9118 File Offset: 0x003F7318
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

		// Token: 0x170083DA RID: 33754
		// (get) Token: 0x0601C1D5 RID: 115157 RVA: 0x003F9154 File Offset: 0x003F7354
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

		// Token: 0x0601C1D6 RID: 115158 RVA: 0x003F9191 File Offset: 0x003F7391
		public static Offset<IMultiplayerRefresh> CreateIMultiplayerRefresh(FlatBufferBuilder builder, int CompletedRefreshTime = 0, int AllPlayerAwardedRefreshTime = 0, int AnyPlayerAwardedRefreshTime = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IMultiplayerRefresh.AddAnyPlayerAwardedRefreshTime(builder, AnyPlayerAwardedRefreshTime);
			IMultiplayerRefresh.AddAllPlayerAwardedRefreshTime(builder, AllPlayerAwardedRefreshTime);
			IMultiplayerRefresh.AddCompletedRefreshTime(builder, CompletedRefreshTime);
			IMultiplayerRefresh.AddNullMask(builder, NullMask);
			return IMultiplayerRefresh.EndIMultiplayerRefresh(builder);
		}

		// Token: 0x0601C1D7 RID: 115159 RVA: 0x003F91BD File Offset: 0x003F73BD
		public static void StartIMultiplayerRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C1D8 RID: 115160 RVA: 0x003F91C6 File Offset: 0x003F73C6
		public static void AddCompletedRefreshTime(FlatBufferBuilder builder, int completedRefreshTime)
		{
			builder.AddInt(0, completedRefreshTime, 0);
		}

		// Token: 0x0601C1D9 RID: 115161 RVA: 0x003F91D1 File Offset: 0x003F73D1
		public static void AddAllPlayerAwardedRefreshTime(FlatBufferBuilder builder, int allPlayerAwardedRefreshTime)
		{
			builder.AddInt(1, allPlayerAwardedRefreshTime, 0);
		}

		// Token: 0x0601C1DA RID: 115162 RVA: 0x003F91DC File Offset: 0x003F73DC
		public static void AddAnyPlayerAwardedRefreshTime(FlatBufferBuilder builder, int anyPlayerAwardedRefreshTime)
		{
			builder.AddInt(2, anyPlayerAwardedRefreshTime, 0);
		}

		// Token: 0x0601C1DB RID: 115163 RVA: 0x003F91E7 File Offset: 0x003F73E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601C1DC RID: 115164 RVA: 0x003F91F2 File Offset: 0x003F73F2
		public static Offset<IMultiplayerRefresh> EndIMultiplayerRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IMultiplayerRefresh>(builder.EndTable());
		}

		// Token: 0x0601C1DD RID: 115165 RVA: 0x003F9200 File Offset: 0x003F7400
		public IMultiplayerRefreshT UnPack()
		{
			IMultiplayerRefreshT multiplayerRefreshT = new IMultiplayerRefreshT();
			this.UnPackTo(multiplayerRefreshT);
			return multiplayerRefreshT;
		}

		// Token: 0x0601C1DE RID: 115166 RVA: 0x003F921B File Offset: 0x003F741B
		public void UnPackTo(IMultiplayerRefreshT _o)
		{
			_o.CompletedRefreshTime = this.CompletedRefreshTime;
			_o.AllPlayerAwardedRefreshTime = this.AllPlayerAwardedRefreshTime;
			_o.AnyPlayerAwardedRefreshTime = this.AnyPlayerAwardedRefreshTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C1DF RID: 115167 RVA: 0x003F9250 File Offset: 0x003F7450
		public static Offset<IMultiplayerRefresh> Pack(FlatBufferBuilder builder, IMultiplayerRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMultiplayerRefresh>);
			}
			return IMultiplayerRefresh.CreateIMultiplayerRefresh(builder, _o.CompletedRefreshTime, _o.AllPlayerAwardedRefreshTime, _o.AnyPlayerAwardedRefreshTime, _o.NullMask);
		}

		// Token: 0x0400CFDD RID: 53213
		private Table __p;
	}
}
