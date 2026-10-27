using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200444C RID: 17484
	public struct ICustomOnlineRefresh : IFlatbufferObject
	{
		// Token: 0x17007B32 RID: 31538
		// (get) Token: 0x0601A042 RID: 106562 RVA: 0x003B7DEC File Offset: 0x003B5FEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A043 RID: 106563 RVA: 0x003B7DF9 File Offset: 0x003B5FF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A044 RID: 106564 RVA: 0x003B7E00 File Offset: 0x003B6000
		public static ICustomOnlineRefresh GetRootAsICustomOnlineRefresh(ByteBuffer _bb)
		{
			return ICustomOnlineRefresh.GetRootAsICustomOnlineRefresh(_bb, default(ICustomOnlineRefresh));
		}

		// Token: 0x0601A045 RID: 106565 RVA: 0x003B7E1C File Offset: 0x003B601C
		public static ICustomOnlineRefresh GetRootAsICustomOnlineRefresh(ByteBuffer _bb, ICustomOnlineRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A046 RID: 106566 RVA: 0x003B7E39 File Offset: 0x003B6039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A047 RID: 106567 RVA: 0x003B7E48 File Offset: 0x003B6048
		public ICustomOnlineRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B33 RID: 31539
		// (get) Token: 0x0601A048 RID: 106568 RVA: 0x003B7E58 File Offset: 0x003B6058
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

		// Token: 0x17007B34 RID: 31540
		// (get) Token: 0x0601A049 RID: 106569 RVA: 0x003B7E94 File Offset: 0x003B6094
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

		// Token: 0x17007B35 RID: 31541
		// (get) Token: 0x0601A04A RID: 106570 RVA: 0x003B7EF4 File Offset: 0x003B60F4
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

		// Token: 0x0601A04B RID: 106571 RVA: 0x003B7F51 File Offset: 0x003B6151
		public static Offset<ICustomOnlineRefresh> CreateICustomOnlineRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None, Offset<ISingleOnlineRefresh> SingleOnlineRefreshOffset = default(Offset<ISingleOnlineRefresh>), Offset<IMultiplayerRefresh> MultiplayerRefreshOffset = default(Offset<IMultiplayerRefresh>))
		{
			builder.StartTable(3);
			ICustomOnlineRefresh.AddMultiplayerRefresh(builder, MultiplayerRefreshOffset);
			ICustomOnlineRefresh.AddSingleOnlineRefresh(builder, SingleOnlineRefreshOffset);
			ICustomOnlineRefresh.AddType(builder, Type);
			return ICustomOnlineRefresh.EndICustomOnlineRefresh(builder);
		}

		// Token: 0x0601A04C RID: 106572 RVA: 0x003B7F75 File Offset: 0x003B6175
		public static void StartICustomOnlineRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A04D RID: 106573 RVA: 0x003B7F7E File Offset: 0x003B617E
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A04E RID: 106574 RVA: 0x003B7F89 File Offset: 0x003B6189
		public static void AddSingleOnlineRefresh(FlatBufferBuilder builder, Offset<ISingleOnlineRefresh> singleOnlineRefreshOffset)
		{
			builder.AddOffset(1, singleOnlineRefreshOffset.Value, 0);
		}

		// Token: 0x0601A04F RID: 106575 RVA: 0x003B7F99 File Offset: 0x003B6199
		public static void AddMultiplayerRefresh(FlatBufferBuilder builder, Offset<IMultiplayerRefresh> multiplayerRefreshOffset)
		{
			builder.AddOffset(2, multiplayerRefreshOffset.Value, 0);
		}

		// Token: 0x0601A050 RID: 106576 RVA: 0x003B7FA9 File Offset: 0x003B61A9
		public static Offset<ICustomOnlineRefresh> EndICustomOnlineRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ICustomOnlineRefresh>(builder.EndTable());
		}

		// Token: 0x0601A051 RID: 106577 RVA: 0x003B7FB8 File Offset: 0x003B61B8
		public ICustomOnlineRefreshT UnPack()
		{
			ICustomOnlineRefreshT customOnlineRefreshT = new ICustomOnlineRefreshT();
			this.UnPackTo(customOnlineRefreshT);
			return customOnlineRefreshT;
		}

		// Token: 0x0601A052 RID: 106578 RVA: 0x003B7FD4 File Offset: 0x003B61D4
		public void UnPackTo(ICustomOnlineRefreshT _o)
		{
			_o.Type = this.Type;
			_o.SingleOnlineRefresh = ((this.SingleOnlineRefresh != null) ? this.SingleOnlineRefresh.Value.UnPack() : null);
			_o.MultiplayerRefresh = ((this.MultiplayerRefresh != null) ? this.MultiplayerRefresh.Value.UnPack() : null);
		}

		// Token: 0x0601A053 RID: 106579 RVA: 0x003B804C File Offset: 0x003B624C
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

		// Token: 0x0400C41C RID: 50204
		private Table __p;
	}
}
