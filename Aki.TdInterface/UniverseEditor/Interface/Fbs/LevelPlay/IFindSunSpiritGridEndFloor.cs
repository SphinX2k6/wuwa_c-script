using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044BE RID: 17598
	public struct IFindSunSpiritGridEndFloor : IFlatbufferObject
	{
		// Token: 0x17007C30 RID: 31792
		// (get) Token: 0x0601A4AE RID: 107694 RVA: 0x003C150C File Offset: 0x003BF70C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A4AF RID: 107695 RVA: 0x003C1519 File Offset: 0x003BF719
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A4B0 RID: 107696 RVA: 0x003C1520 File Offset: 0x003BF720
		public static IFindSunSpiritGridEndFloor GetRootAsIFindSunSpiritGridEndFloor(ByteBuffer _bb)
		{
			return IFindSunSpiritGridEndFloor.GetRootAsIFindSunSpiritGridEndFloor(_bb, default(IFindSunSpiritGridEndFloor));
		}

		// Token: 0x0601A4B1 RID: 107697 RVA: 0x003C153C File Offset: 0x003BF73C
		public static IFindSunSpiritGridEndFloor GetRootAsIFindSunSpiritGridEndFloor(ByteBuffer _bb, IFindSunSpiritGridEndFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A4B2 RID: 107698 RVA: 0x003C1559 File Offset: 0x003BF759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A4B3 RID: 107699 RVA: 0x003C1568 File Offset: 0x003BF768
		public IFindSunSpiritGridEndFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C31 RID: 31793
		// (get) Token: 0x0601A4B4 RID: 107700 RVA: 0x003C1578 File Offset: 0x003BF778
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

		// Token: 0x0601A4B5 RID: 107701 RVA: 0x003C15B4 File Offset: 0x003BF7B4
		public static Offset<IFindSunSpiritGridEndFloor> CreateIFindSunSpiritGridEndFloor(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty)
		{
			builder.StartTable(1);
			IFindSunSpiritGridEndFloor.AddType(builder, Type);
			return IFindSunSpiritGridEndFloor.EndIFindSunSpiritGridEndFloor(builder);
		}

		// Token: 0x0601A4B6 RID: 107702 RVA: 0x003C15CA File Offset: 0x003BF7CA
		public static void StartIFindSunSpiritGridEndFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A4B7 RID: 107703 RVA: 0x003C15D3 File Offset: 0x003BF7D3
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A4B8 RID: 107704 RVA: 0x003C15DE File Offset: 0x003BF7DE
		public static Offset<IFindSunSpiritGridEndFloor> EndIFindSunSpiritGridEndFloor(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridEndFloor>(builder.EndTable());
		}

		// Token: 0x0601A4B9 RID: 107705 RVA: 0x003C15EC File Offset: 0x003BF7EC
		public IFindSunSpiritGridEndFloorT UnPack()
		{
			IFindSunSpiritGridEndFloorT findSunSpiritGridEndFloorT = new IFindSunSpiritGridEndFloorT();
			this.UnPackTo(findSunSpiritGridEndFloorT);
			return findSunSpiritGridEndFloorT;
		}

		// Token: 0x0601A4BA RID: 107706 RVA: 0x003C1607 File Offset: 0x003BF807
		public void UnPackTo(IFindSunSpiritGridEndFloorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A4BB RID: 107707 RVA: 0x003C1618 File Offset: 0x003BF818
		public static Offset<IFindSunSpiritGridEndFloor> Pack(FlatBufferBuilder builder, IFindSunSpiritGridEndFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridEndFloor>);
			}
			return IFindSunSpiritGridEndFloor.CreateIFindSunSpiritGridEndFloor(builder, _o.Type);
		}

		// Token: 0x0400C4D2 RID: 50386
		private Table __p;
	}
}
