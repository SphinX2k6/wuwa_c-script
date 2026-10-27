using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FA1 RID: 16289
	public struct IPlayerHavingItemCount : IFlatbufferObject
	{
		// Token: 0x170071BA RID: 29114
		// (get) Token: 0x06017460 RID: 95328 RVA: 0x0035B25F File Offset: 0x0035945F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017461 RID: 95329 RVA: 0x0035B26C File Offset: 0x0035946C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017462 RID: 95330 RVA: 0x0035B274 File Offset: 0x00359474
		public static IPlayerHavingItemCount GetRootAsIPlayerHavingItemCount(ByteBuffer _bb)
		{
			return IPlayerHavingItemCount.GetRootAsIPlayerHavingItemCount(_bb, default(IPlayerHavingItemCount));
		}

		// Token: 0x06017463 RID: 95331 RVA: 0x0035B290 File Offset: 0x00359490
		public static IPlayerHavingItemCount GetRootAsIPlayerHavingItemCount(ByteBuffer _bb, IPlayerHavingItemCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017464 RID: 95332 RVA: 0x0035B2AD File Offset: 0x003594AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017465 RID: 95333 RVA: 0x0035B2BC File Offset: 0x003594BC
		public IPlayerHavingItemCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071BB RID: 29115
		// (get) Token: 0x06017466 RID: 95334 RVA: 0x0035B2CC File Offset: 0x003594CC
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

		// Token: 0x170071BC RID: 29116
		// (get) Token: 0x06017467 RID: 95335 RVA: 0x0035B308 File Offset: 0x00359508
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

		// Token: 0x06017468 RID: 95336 RVA: 0x0035B344 File Offset: 0x00359544
		public static Offset<IPlayerHavingItemCount> CreateIPlayerHavingItemCount(FlatBufferBuilder builder, EBindingProgressType Type = EBindingProgressType.PlayerHavingItemCount, int ItemId = 0)
		{
			builder.StartTable(2);
			IPlayerHavingItemCount.AddItemId(builder, ItemId);
			IPlayerHavingItemCount.AddType(builder, Type);
			return IPlayerHavingItemCount.EndIPlayerHavingItemCount(builder);
		}

		// Token: 0x06017469 RID: 95337 RVA: 0x0035B361 File Offset: 0x00359561
		public static void StartIPlayerHavingItemCount(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601746A RID: 95338 RVA: 0x0035B36A File Offset: 0x0035956A
		public static void AddType(FlatBufferBuilder builder, EBindingProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601746B RID: 95339 RVA: 0x0035B375 File Offset: 0x00359575
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x0601746C RID: 95340 RVA: 0x0035B380 File Offset: 0x00359580
		public static Offset<IPlayerHavingItemCount> EndIPlayerHavingItemCount(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerHavingItemCount>(builder.EndTable());
		}

		// Token: 0x0601746D RID: 95341 RVA: 0x0035B390 File Offset: 0x00359590
		public IPlayerHavingItemCountT UnPack()
		{
			IPlayerHavingItemCountT playerHavingItemCountT = new IPlayerHavingItemCountT();
			this.UnPackTo(playerHavingItemCountT);
			return playerHavingItemCountT;
		}

		// Token: 0x0601746E RID: 95342 RVA: 0x0035B3AB File Offset: 0x003595AB
		public void UnPackTo(IPlayerHavingItemCountT _o)
		{
			_o.Type = this.Type;
			_o.ItemId = this.ItemId;
		}

		// Token: 0x0601746F RID: 95343 RVA: 0x0035B3C8 File Offset: 0x003595C8
		public static Offset<IPlayerHavingItemCount> Pack(FlatBufferBuilder builder, IPlayerHavingItemCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerHavingItemCount>);
			}
			return IPlayerHavingItemCount.CreateIPlayerHavingItemCount(builder, _o.Type, _o.ItemId);
		}

		// Token: 0x0400BA08 RID: 47624
		private Table __p;
	}
}
