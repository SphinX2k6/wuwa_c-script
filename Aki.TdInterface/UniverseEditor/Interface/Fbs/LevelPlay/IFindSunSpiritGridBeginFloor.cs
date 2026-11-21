using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200491D RID: 18717
	public struct IFindSunSpiritGridBeginFloor : IFlatbufferObject
	{
		// Token: 0x1700825F RID: 33375
		// (get) Token: 0x0601BC2D RID: 113709 RVA: 0x003ECBFE File Offset: 0x003EADFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BC2E RID: 113710 RVA: 0x003ECC0B File Offset: 0x003EAE0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BC2F RID: 113711 RVA: 0x003ECC14 File Offset: 0x003EAE14
		public static IFindSunSpiritGridBeginFloor GetRootAsIFindSunSpiritGridBeginFloor(ByteBuffer _bb)
		{
			return IFindSunSpiritGridBeginFloor.GetRootAsIFindSunSpiritGridBeginFloor(_bb, default(IFindSunSpiritGridBeginFloor));
		}

		// Token: 0x0601BC30 RID: 113712 RVA: 0x003ECC30 File Offset: 0x003EAE30
		public static IFindSunSpiritGridBeginFloor GetRootAsIFindSunSpiritGridBeginFloor(ByteBuffer _bb, IFindSunSpiritGridBeginFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BC31 RID: 113713 RVA: 0x003ECC4D File Offset: 0x003EAE4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BC32 RID: 113714 RVA: 0x003ECC5C File Offset: 0x003EAE5C
		public IFindSunSpiritGridBeginFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008260 RID: 33376
		// (get) Token: 0x0601BC33 RID: 113715 RVA: 0x003ECC6C File Offset: 0x003EAE6C
		public EFindSunSpiritGridType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFindSunSpiritGridType.Empty;
				}
				return (EFindSunSpiritGridType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BC34 RID: 113716 RVA: 0x003ECCA8 File Offset: 0x003EAEA8
		public static Offset<IFindSunSpiritGridBeginFloor> CreateIFindSunSpiritGridBeginFloor(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty)
		{
			builder.StartTable(1);
			IFindSunSpiritGridBeginFloor.AddType(builder, Type);
			return IFindSunSpiritGridBeginFloor.EndIFindSunSpiritGridBeginFloor(builder);
		}

		// Token: 0x0601BC35 RID: 113717 RVA: 0x003ECCBE File Offset: 0x003EAEBE
		public static void StartIFindSunSpiritGridBeginFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601BC36 RID: 113718 RVA: 0x003ECCC7 File Offset: 0x003EAEC7
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BC37 RID: 113719 RVA: 0x003ECCD2 File Offset: 0x003EAED2
		public static Offset<IFindSunSpiritGridBeginFloor> EndIFindSunSpiritGridBeginFloor(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridBeginFloor>(builder.EndTable());
		}

		// Token: 0x0601BC38 RID: 113720 RVA: 0x003ECCE0 File Offset: 0x003EAEE0
		public IFindSunSpiritGridBeginFloorT UnPack()
		{
			IFindSunSpiritGridBeginFloorT findSunSpiritGridBeginFloorT = new IFindSunSpiritGridBeginFloorT();
			this.UnPackTo(findSunSpiritGridBeginFloorT);
			return findSunSpiritGridBeginFloorT;
		}

		// Token: 0x0601BC39 RID: 113721 RVA: 0x003ECCFB File Offset: 0x003EAEFB
		public void UnPackTo(IFindSunSpiritGridBeginFloorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601BC3A RID: 113722 RVA: 0x003ECD0C File Offset: 0x003EAF0C
		public static Offset<IFindSunSpiritGridBeginFloor> Pack(FlatBufferBuilder builder, IFindSunSpiritGridBeginFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridBeginFloor>);
			}
			return IFindSunSpiritGridBeginFloor.CreateIFindSunSpiritGridBeginFloor(builder, _o.Type);
		}

		// Token: 0x0400CEF7 RID: 52983
		private Table __p;
	}
}
