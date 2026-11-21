using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043E2 RID: 17378
	public struct IPlayerHavingItemCount : IFlatbufferObject
	{
		// Token: 0x170077B8 RID: 30648
		// (get) Token: 0x06018AEF RID: 101103 RVA: 0x00384E77 File Offset: 0x00383077
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018AF0 RID: 101104 RVA: 0x00384E84 File Offset: 0x00383084
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018AF1 RID: 101105 RVA: 0x00384E8C File Offset: 0x0038308C
		public static IPlayerHavingItemCount GetRootAsIPlayerHavingItemCount(ByteBuffer _bb)
		{
			return IPlayerHavingItemCount.GetRootAsIPlayerHavingItemCount(_bb, default(IPlayerHavingItemCount));
		}

		// Token: 0x06018AF2 RID: 101106 RVA: 0x00384EA8 File Offset: 0x003830A8
		public static IPlayerHavingItemCount GetRootAsIPlayerHavingItemCount(ByteBuffer _bb, IPlayerHavingItemCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018AF3 RID: 101107 RVA: 0x00384EC5 File Offset: 0x003830C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018AF4 RID: 101108 RVA: 0x00384ED4 File Offset: 0x003830D4
		public IPlayerHavingItemCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077B9 RID: 30649
		// (get) Token: 0x06018AF5 RID: 101109 RVA: 0x00384EE4 File Offset: 0x003830E4
		public EBindingProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBindingProgressType.PlayerHavingItemCount;
				}
				return (EBindingProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170077BA RID: 30650
		// (get) Token: 0x06018AF6 RID: 101110 RVA: 0x00384F20 File Offset: 0x00383120
		public int ItemId
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

		// Token: 0x06018AF7 RID: 101111 RVA: 0x00384F5C File Offset: 0x0038315C
		public static Offset<IPlayerHavingItemCount> CreateIPlayerHavingItemCount(FlatBufferBuilder builder, EBindingProgressType Type = EBindingProgressType.PlayerHavingItemCount, int ItemId = 0)
		{
			builder.StartTable(2);
			IPlayerHavingItemCount.AddItemId(builder, ItemId);
			IPlayerHavingItemCount.AddType(builder, Type);
			return IPlayerHavingItemCount.EndIPlayerHavingItemCount(builder);
		}

		// Token: 0x06018AF8 RID: 101112 RVA: 0x00384F79 File Offset: 0x00383179
		public static void StartIPlayerHavingItemCount(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018AF9 RID: 101113 RVA: 0x00384F82 File Offset: 0x00383182
		public static void AddType(FlatBufferBuilder builder, EBindingProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018AFA RID: 101114 RVA: 0x00384F8D File Offset: 0x0038318D
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x06018AFB RID: 101115 RVA: 0x00384F98 File Offset: 0x00383198
		public static Offset<IPlayerHavingItemCount> EndIPlayerHavingItemCount(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerHavingItemCount>(builder.EndTable());
		}

		// Token: 0x06018AFC RID: 101116 RVA: 0x00384FA8 File Offset: 0x003831A8
		public IPlayerHavingItemCountT UnPack()
		{
			IPlayerHavingItemCountT playerHavingItemCountT = new IPlayerHavingItemCountT();
			this.UnPackTo(playerHavingItemCountT);
			return playerHavingItemCountT;
		}

		// Token: 0x06018AFD RID: 101117 RVA: 0x00384FC3 File Offset: 0x003831C3
		public void UnPackTo(IPlayerHavingItemCountT _o)
		{
			_o.Type = this.Type;
			_o.ItemId = this.ItemId;
		}

		// Token: 0x06018AFE RID: 101118 RVA: 0x00384FE0 File Offset: 0x003831E0
		public static Offset<IPlayerHavingItemCount> Pack(FlatBufferBuilder builder, IPlayerHavingItemCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerHavingItemCount>);
			}
			return IPlayerHavingItemCount.CreateIPlayerHavingItemCount(builder, _o.Type, _o.ItemId);
		}

		// Token: 0x0400C3ED RID: 50157
		private Table __p;
	}
}
