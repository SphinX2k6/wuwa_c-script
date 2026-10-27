using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049A9 RID: 18857
	public struct ICheckCollectionShopState : IFlatbufferObject
	{
		// Token: 0x17008853 RID: 34899
		// (get) Token: 0x0601D6DE RID: 120542 RVA: 0x00425A90 File Offset: 0x00423C90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D6DF RID: 120543 RVA: 0x00425A9D File Offset: 0x00423C9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D6E0 RID: 120544 RVA: 0x00425AA4 File Offset: 0x00423CA4
		public static ICheckCollectionShopState GetRootAsICheckCollectionShopState(ByteBuffer _bb)
		{
			return ICheckCollectionShopState.GetRootAsICheckCollectionShopState(_bb, default(ICheckCollectionShopState));
		}

		// Token: 0x0601D6E1 RID: 120545 RVA: 0x00425AC0 File Offset: 0x00423CC0
		public static ICheckCollectionShopState GetRootAsICheckCollectionShopState(ByteBuffer _bb, ICheckCollectionShopState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D6E2 RID: 120546 RVA: 0x00425ADD File Offset: 0x00423CDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D6E3 RID: 120547 RVA: 0x00425AEC File Offset: 0x00423CEC
		public ICheckCollectionShopState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008854 RID: 34900
		// (get) Token: 0x0601D6E4 RID: 120548 RVA: 0x00425AFC File Offset: 0x00423CFC
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008855 RID: 34901
		// (get) Token: 0x0601D6E5 RID: 120549 RVA: 0x00425B38 File Offset: 0x00423D38
		public EShopType ShopType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EShopType.ChengXiaoShan;
				}
				return (EShopType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D6E6 RID: 120550 RVA: 0x00425B74 File Offset: 0x00423D74
		public static Offset<ICheckCollectionShopState> CreateICheckCollectionShopState(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, EShopType ShopType = EShopType.ChengXiaoShan)
		{
			builder.StartTable(2);
			ICheckCollectionShopState.AddShopType(builder, ShopType);
			ICheckCollectionShopState.AddType(builder, Type);
			return ICheckCollectionShopState.EndICheckCollectionShopState(builder);
		}

		// Token: 0x0601D6E7 RID: 120551 RVA: 0x00425B91 File Offset: 0x00423D91
		public static void StartICheckCollectionShopState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D6E8 RID: 120552 RVA: 0x00425B9A File Offset: 0x00423D9A
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D6E9 RID: 120553 RVA: 0x00425BA5 File Offset: 0x00423DA5
		public static void AddShopType(FlatBufferBuilder builder, EShopType shopType)
		{
			builder.AddByte(1, (byte)shopType, 0);
		}

		// Token: 0x0601D6EA RID: 120554 RVA: 0x00425BB0 File Offset: 0x00423DB0
		public static Offset<ICheckCollectionShopState> EndICheckCollectionShopState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCollectionShopState>(builder.EndTable());
		}

		// Token: 0x0601D6EB RID: 120555 RVA: 0x00425BC0 File Offset: 0x00423DC0
		public ICheckCollectionShopStateT UnPack()
		{
			ICheckCollectionShopStateT checkCollectionShopStateT = new ICheckCollectionShopStateT();
			this.UnPackTo(checkCollectionShopStateT);
			return checkCollectionShopStateT;
		}

		// Token: 0x0601D6EC RID: 120556 RVA: 0x00425BDB File Offset: 0x00423DDB
		public void UnPackTo(ICheckCollectionShopStateT _o)
		{
			_o.Type = this.Type;
			_o.ShopType = this.ShopType;
		}

		// Token: 0x0601D6ED RID: 120557 RVA: 0x00425BF8 File Offset: 0x00423DF8
		public static Offset<ICheckCollectionShopState> Pack(FlatBufferBuilder builder, ICheckCollectionShopStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCollectionShopState>);
			}
			return ICheckCollectionShopState.CreateICheckCollectionShopState(builder, _o.Type, _o.ShopType);
		}

		// Token: 0x0400D1C9 RID: 53705
		private Table __p;
	}
}
