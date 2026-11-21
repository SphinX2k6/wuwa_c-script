using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200706D RID: 28781
	public struct IItemGetUiConfigBase : IFlatbufferObject
	{
		// Token: 0x1700D2C7 RID: 53959
		// (get) Token: 0x06031E83 RID: 204419 RVA: 0x006C13D1 File Offset: 0x006BF5D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031E84 RID: 204420 RVA: 0x006C13DE File Offset: 0x006BF5DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031E85 RID: 204421 RVA: 0x006C13E8 File Offset: 0x006BF5E8
		public static IItemGetUiConfigBase GetRootAsIItemGetUiConfigBase(ByteBuffer _bb)
		{
			return IItemGetUiConfigBase.GetRootAsIItemGetUiConfigBase(_bb, default(IItemGetUiConfigBase));
		}

		// Token: 0x06031E86 RID: 204422 RVA: 0x006C1404 File Offset: 0x006BF604
		public static IItemGetUiConfigBase GetRootAsIItemGetUiConfigBase(ByteBuffer _bb, IItemGetUiConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E87 RID: 204423 RVA: 0x006C1421 File Offset: 0x006BF621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E88 RID: 204424 RVA: 0x006C1430 File Offset: 0x006BF630
		public IItemGetUiConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2C8 RID: 53960
		// (get) Token: 0x06031E89 RID: 204425 RVA: 0x006C1440 File Offset: 0x006BF640
		public EItemGetUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemGetUiType.None;
				}
				return (EItemGetUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031E8A RID: 204426 RVA: 0x006C147C File Offset: 0x006BF67C
		public static Offset<IItemGetUiConfigBase> CreateIItemGetUiConfigBase(FlatBufferBuilder builder, EItemGetUiType Type = EItemGetUiType.None)
		{
			builder.StartTable(1);
			IItemGetUiConfigBase.AddType(builder, Type);
			return IItemGetUiConfigBase.EndIItemGetUiConfigBase(builder);
		}

		// Token: 0x06031E8B RID: 204427 RVA: 0x006C1492 File Offset: 0x006BF692
		public static void StartIItemGetUiConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031E8C RID: 204428 RVA: 0x006C149B File Offset: 0x006BF69B
		public static void AddType(FlatBufferBuilder builder, EItemGetUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031E8D RID: 204429 RVA: 0x006C14A6 File Offset: 0x006BF6A6
		public static Offset<IItemGetUiConfigBase> EndIItemGetUiConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IItemGetUiConfigBase>(builder.EndTable());
		}

		// Token: 0x06031E8E RID: 204430 RVA: 0x006C14B4 File Offset: 0x006BF6B4
		public IItemGetUiConfigBaseT UnPack()
		{
			IItemGetUiConfigBaseT itemGetUiConfigBaseT = new IItemGetUiConfigBaseT();
			this.UnPackTo(itemGetUiConfigBaseT);
			return itemGetUiConfigBaseT;
		}

		// Token: 0x06031E8F RID: 204431 RVA: 0x006C14CF File Offset: 0x006BF6CF
		public void UnPackTo(IItemGetUiConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031E90 RID: 204432 RVA: 0x006C14E0 File Offset: 0x006BF6E0
		public static Offset<IItemGetUiConfigBase> Pack(FlatBufferBuilder builder, IItemGetUiConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemGetUiConfigBase>);
			}
			return IItemGetUiConfigBase.CreateIItemGetUiConfigBase(builder, _o.Type);
		}

		// Token: 0x04011FD4 RID: 73684
		private Table __p;
	}
}
