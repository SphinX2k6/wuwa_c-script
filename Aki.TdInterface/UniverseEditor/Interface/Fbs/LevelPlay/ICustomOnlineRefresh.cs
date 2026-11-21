using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048B4 RID: 18612
	public struct ICustomOnlineRefresh : IFlatbufferObject
	{
		// Token: 0x17008171 RID: 33137
		// (get) Token: 0x0601B813 RID: 112659 RVA: 0x003E3FF8 File Offset: 0x003E21F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B814 RID: 112660 RVA: 0x003E4005 File Offset: 0x003E2205
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B815 RID: 112661 RVA: 0x003E400C File Offset: 0x003E220C
		public static ICustomOnlineRefresh GetRootAsICustomOnlineRefresh(ByteBuffer _bb)
		{
			return ICustomOnlineRefresh.GetRootAsICustomOnlineRefresh(_bb, default(ICustomOnlineRefresh));
		}

		// Token: 0x0601B816 RID: 112662 RVA: 0x003E4028 File Offset: 0x003E2228
		public static ICustomOnlineRefresh GetRootAsICustomOnlineRefresh(ByteBuffer _bb, ICustomOnlineRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B817 RID: 112663 RVA: 0x003E4045 File Offset: 0x003E2245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B818 RID: 112664 RVA: 0x003E4054 File Offset: 0x003E2254
		public ICustomOnlineRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008172 RID: 33138
		// (get) Token: 0x0601B819 RID: 112665 RVA: 0x003E4064 File Offset: 0x003E2264
		public ELevelPlayRefreshType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayRefreshType.None;
				}
				return (ELevelPlayRefreshType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008173 RID: 33139
		// (get) Token: 0x0601B81A RID: 112666 RVA: 0x003E40A0 File Offset: 0x003E22A0
		public ISingleOnlineRefresh? SingleOnlineRefresh
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISingleOnlineRefresh?(default(ISingleOnlineRefresh).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008174 RID: 33140
		// (get) Token: 0x0601B81B RID: 112667 RVA: 0x003E4100 File Offset: 0x003E2300
		public IMultiplayerRefresh? MultiplayerRefresh
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMultiplayerRefresh?(default(IMultiplayerRefresh).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601B81C RID: 112668 RVA: 0x003E415D File Offset: 0x003E235D
		public static Offset<ICustomOnlineRefresh> CreateICustomOnlineRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None, Offset<ISingleOnlineRefresh> SingleOnlineRefreshOffset = default(Offset<ISingleOnlineRefresh>), Offset<IMultiplayerRefresh> MultiplayerRefreshOffset = default(Offset<IMultiplayerRefresh>))
		{
			builder.StartTable(3);
			ICustomOnlineRefresh.AddMultiplayerRefresh(builder, MultiplayerRefreshOffset);
			ICustomOnlineRefresh.AddSingleOnlineRefresh(builder, SingleOnlineRefreshOffset);
			ICustomOnlineRefresh.AddType(builder, Type);
			return ICustomOnlineRefresh.EndICustomOnlineRefresh(builder);
		}

		// Token: 0x0601B81D RID: 112669 RVA: 0x003E4181 File Offset: 0x003E2381
		public static void StartICustomOnlineRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B81E RID: 112670 RVA: 0x003E418A File Offset: 0x003E238A
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B81F RID: 112671 RVA: 0x003E4195 File Offset: 0x003E2395
		public static void AddSingleOnlineRefresh(FlatBufferBuilder builder, Offset<ISingleOnlineRefresh> singleOnlineRefreshOffset)
		{
			builder.AddOffset(1, singleOnlineRefreshOffset.Value, 0);
		}

		// Token: 0x0601B820 RID: 112672 RVA: 0x003E41A5 File Offset: 0x003E23A5
		public static void AddMultiplayerRefresh(FlatBufferBuilder builder, Offset<IMultiplayerRefresh> multiplayerRefreshOffset)
		{
			builder.AddOffset(2, multiplayerRefreshOffset.Value, 0);
		}

		// Token: 0x0601B821 RID: 112673 RVA: 0x003E41B5 File Offset: 0x003E23B5
		public static Offset<ICustomOnlineRefresh> EndICustomOnlineRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ICustomOnlineRefresh>(builder.EndTable());
		}

		// Token: 0x0601B822 RID: 112674 RVA: 0x003E41C4 File Offset: 0x003E23C4
		public ICustomOnlineRefreshT UnPack()
		{
			ICustomOnlineRefreshT customOnlineRefreshT = new ICustomOnlineRefreshT();
			this.UnPackTo(customOnlineRefreshT);
			return customOnlineRefreshT;
		}

		// Token: 0x0601B823 RID: 112675 RVA: 0x003E41E0 File Offset: 0x003E23E0
		public void UnPackTo(ICustomOnlineRefreshT _o)
		{
			_o.Type = this.Type;
			_o.SingleOnlineRefresh = ((this.SingleOnlineRefresh != null) ? this.SingleOnlineRefresh.Value.UnPack() : null);
			_o.MultiplayerRefresh = ((this.MultiplayerRefresh != null) ? this.MultiplayerRefresh.Value.UnPack() : null);
		}

		// Token: 0x0601B824 RID: 112676 RVA: 0x003E4258 File Offset: 0x003E2458
		public static Offset<ICustomOnlineRefresh> Pack(FlatBufferBuilder builder, ICustomOnlineRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomOnlineRefresh>);
			}
			Offset<ISingleOnlineRefresh> singleOnlineRefreshOffset = (_o.SingleOnlineRefresh == null) ? default(Offset<ISingleOnlineRefresh>) : ISingleOnlineRefresh.Pack(builder, _o.SingleOnlineRefresh);
			Offset<IMultiplayerRefresh> multiplayerRefreshOffset = (_o.MultiplayerRefresh == null) ? default(Offset<IMultiplayerRefresh>) : IMultiplayerRefresh.Pack(builder, _o.MultiplayerRefresh);
			return ICustomOnlineRefresh.CreateICustomOnlineRefresh(builder, _o.Type, singleOnlineRefreshOffset, multiplayerRefreshOffset);
		}

		// Token: 0x0400CE4A RID: 52810
		private Table __p;
	}
}
