using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E63 RID: 20067
	public struct ICheckCollectionShopState : IFlatbufferObject
	{
		// Token: 0x17008F15 RID: 36629
		// (get) Token: 0x0601F11D RID: 127261 RVA: 0x004561D8 File Offset: 0x004543D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F11E RID: 127262 RVA: 0x004561E5 File Offset: 0x004543E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F11F RID: 127263 RVA: 0x004561EC File Offset: 0x004543EC
		public static ICheckCollectionShopState GetRootAsICheckCollectionShopState(ByteBuffer _bb)
		{
			return ICheckCollectionShopState.GetRootAsICheckCollectionShopState(_bb, default(ICheckCollectionShopState));
		}

		// Token: 0x0601F120 RID: 127264 RVA: 0x00456208 File Offset: 0x00454408
		public static ICheckCollectionShopState GetRootAsICheckCollectionShopState(ByteBuffer _bb, ICheckCollectionShopState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F121 RID: 127265 RVA: 0x00456225 File Offset: 0x00454425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F122 RID: 127266 RVA: 0x00456234 File Offset: 0x00454434
		public ICheckCollectionShopState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F16 RID: 36630
		// (get) Token: 0x0601F123 RID: 127267 RVA: 0x00456244 File Offset: 0x00454444
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

		// Token: 0x17008F17 RID: 36631
		// (get) Token: 0x0601F124 RID: 127268 RVA: 0x00456280 File Offset: 0x00454480
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

		// Token: 0x0601F125 RID: 127269 RVA: 0x004562BC File Offset: 0x004544BC
		public static Offset<ICheckCollectionShopState> CreateICheckCollectionShopState(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, EShopType ShopType = EShopType.ChengXiaoShan)
		{
			builder.StartTable(2);
			ICheckCollectionShopState.AddShopType(builder, ShopType);
			ICheckCollectionShopState.AddType(builder, Type);
			return ICheckCollectionShopState.EndICheckCollectionShopState(builder);
		}

		// Token: 0x0601F126 RID: 127270 RVA: 0x004562D9 File Offset: 0x004544D9
		public static void StartICheckCollectionShopState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F127 RID: 127271 RVA: 0x004562E2 File Offset: 0x004544E2
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F128 RID: 127272 RVA: 0x004562ED File Offset: 0x004544ED
		public static void AddShopType(FlatBufferBuilder builder, EShopType shopType)
		{
			builder.AddByte(1, (byte)shopType, 0);
		}

		// Token: 0x0601F129 RID: 127273 RVA: 0x004562F8 File Offset: 0x004544F8
		public static Offset<ICheckCollectionShopState> EndICheckCollectionShopState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCollectionShopState>(builder.EndTable());
		}

		// Token: 0x0601F12A RID: 127274 RVA: 0x00456308 File Offset: 0x00454508
		public ICheckCollectionShopStateT UnPack()
		{
			ICheckCollectionShopStateT checkCollectionShopStateT = new ICheckCollectionShopStateT();
			this.UnPackTo(checkCollectionShopStateT);
			return checkCollectionShopStateT;
		}

		// Token: 0x0601F12B RID: 127275 RVA: 0x00456323 File Offset: 0x00454523
		public void UnPackTo(ICheckCollectionShopStateT _o)
		{
			_o.Type = this.Type;
			_o.ShopType = this.ShopType;
		}

		// Token: 0x0601F12C RID: 127276 RVA: 0x00456340 File Offset: 0x00454540
		public static Offset<ICheckCollectionShopState> Pack(FlatBufferBuilder builder, ICheckCollectionShopStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCollectionShopState>);
			}
			return ICheckCollectionShopState.CreateICheckCollectionShopState(builder, _o.Type, _o.ShopType);
		}

		// Token: 0x0400DC95 RID: 56469
		private Table __p;
	}
}
