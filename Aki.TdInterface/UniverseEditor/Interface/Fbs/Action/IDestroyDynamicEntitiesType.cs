using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BED RID: 27629
	public struct IDestroyDynamicEntitiesType : IFlatbufferObject
	{
		// Token: 0x1700CA99 RID: 51865
		// (get) Token: 0x0602F8CD RID: 194765 RVA: 0x0067B597 File Offset: 0x00679797
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F8CE RID: 194766 RVA: 0x0067B5A4 File Offset: 0x006797A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F8CF RID: 194767 RVA: 0x0067B5AC File Offset: 0x006797AC
		public static IDestroyDynamicEntitiesType GetRootAsIDestroyDynamicEntitiesType(ByteBuffer _bb)
		{
			return IDestroyDynamicEntitiesType.GetRootAsIDestroyDynamicEntitiesType(_bb, default(IDestroyDynamicEntitiesType));
		}

		// Token: 0x0602F8D0 RID: 194768 RVA: 0x0067B5C8 File Offset: 0x006797C8
		public static IDestroyDynamicEntitiesType GetRootAsIDestroyDynamicEntitiesType(ByteBuffer _bb, IDestroyDynamicEntitiesType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F8D1 RID: 194769 RVA: 0x0067B5E5 File Offset: 0x006797E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F8D2 RID: 194770 RVA: 0x0067B5F4 File Offset: 0x006797F4
		public IDestroyDynamicEntitiesType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA9A RID: 51866
		// (get) Token: 0x0602F8D3 RID: 194771 RVA: 0x0067B604 File Offset: 0x00679804
		public EDynamicEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicEntityType.VisionDisplay;
				}
				return (EDynamicEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F8D4 RID: 194772 RVA: 0x0067B640 File Offset: 0x00679840
		public static Offset<IDestroyDynamicEntitiesType> CreateIDestroyDynamicEntitiesType(FlatBufferBuilder builder, EDynamicEntityType Type = EDynamicEntityType.VisionDisplay)
		{
			builder.StartTable(1);
			IDestroyDynamicEntitiesType.AddType(builder, Type);
			return IDestroyDynamicEntitiesType.EndIDestroyDynamicEntitiesType(builder);
		}

		// Token: 0x0602F8D5 RID: 194773 RVA: 0x0067B656 File Offset: 0x00679856
		public static void StartIDestroyDynamicEntitiesType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F8D6 RID: 194774 RVA: 0x0067B65F File Offset: 0x0067985F
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F8D7 RID: 194775 RVA: 0x0067B66A File Offset: 0x0067986A
		public static Offset<IDestroyDynamicEntitiesType> EndIDestroyDynamicEntitiesType(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyDynamicEntitiesType>(builder.EndTable());
		}

		// Token: 0x0602F8D8 RID: 194776 RVA: 0x0067B678 File Offset: 0x00679878
		public IDestroyDynamicEntitiesTypeT UnPack()
		{
			IDestroyDynamicEntitiesTypeT destroyDynamicEntitiesTypeT = new IDestroyDynamicEntitiesTypeT();
			this.UnPackTo(destroyDynamicEntitiesTypeT);
			return destroyDynamicEntitiesTypeT;
		}

		// Token: 0x0602F8D9 RID: 194777 RVA: 0x0067B693 File Offset: 0x00679893
		public void UnPackTo(IDestroyDynamicEntitiesTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F8DA RID: 194778 RVA: 0x0067B6A4 File Offset: 0x006798A4
		public static Offset<IDestroyDynamicEntitiesType> Pack(FlatBufferBuilder builder, IDestroyDynamicEntitiesTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyDynamicEntitiesType>);
			}
			return IDestroyDynamicEntitiesType.CreateIDestroyDynamicEntitiesType(builder, _o.Type);
		}

		// Token: 0x040119EE RID: 72174
		private Table __p;
	}
}
