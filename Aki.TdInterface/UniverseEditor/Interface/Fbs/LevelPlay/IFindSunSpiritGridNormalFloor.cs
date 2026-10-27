using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044C4 RID: 17604
	public struct IFindSunSpiritGridNormalFloor : IFlatbufferObject
	{
		// Token: 0x17007C3C RID: 31804
		// (get) Token: 0x0601A4DE RID: 107742 RVA: 0x003C19A0 File Offset: 0x003BFBA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A4DF RID: 107743 RVA: 0x003C19AD File Offset: 0x003BFBAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A4E0 RID: 107744 RVA: 0x003C19B4 File Offset: 0x003BFBB4
		public static IFindSunSpiritGridNormalFloor GetRootAsIFindSunSpiritGridNormalFloor(ByteBuffer _bb)
		{
			return IFindSunSpiritGridNormalFloor.GetRootAsIFindSunSpiritGridNormalFloor(_bb, default(IFindSunSpiritGridNormalFloor));
		}

		// Token: 0x0601A4E1 RID: 107745 RVA: 0x003C19D0 File Offset: 0x003BFBD0
		public static IFindSunSpiritGridNormalFloor GetRootAsIFindSunSpiritGridNormalFloor(ByteBuffer _bb, IFindSunSpiritGridNormalFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A4E2 RID: 107746 RVA: 0x003C19ED File Offset: 0x003BFBED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A4E3 RID: 107747 RVA: 0x003C19FC File Offset: 0x003BFBFC
		public IFindSunSpiritGridNormalFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C3D RID: 31805
		// (get) Token: 0x0601A4E4 RID: 107748 RVA: 0x003C1A0C File Offset: 0x003BFC0C
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

		// Token: 0x17007C3E RID: 31806
		// (get) Token: 0x0601A4E5 RID: 107749 RVA: 0x003C1A48 File Offset: 0x003BFC48
		public bool SpreadDevice
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007C3F RID: 31807
		// (get) Token: 0x0601A4E6 RID: 107750 RVA: 0x003C1A88 File Offset: 0x003BFC88
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A4E7 RID: 107751 RVA: 0x003C1AC4 File Offset: 0x003BFCC4
		public static Offset<IFindSunSpiritGridNormalFloor> CreateIFindSunSpiritGridNormalFloor(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty, bool SpreadDevice = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IFindSunSpiritGridNormalFloor.AddNullMask(builder, NullMask);
			IFindSunSpiritGridNormalFloor.AddSpreadDevice(builder, SpreadDevice);
			IFindSunSpiritGridNormalFloor.AddType(builder, Type);
			return IFindSunSpiritGridNormalFloor.EndIFindSunSpiritGridNormalFloor(builder);
		}

		// Token: 0x0601A4E8 RID: 107752 RVA: 0x003C1AE8 File Offset: 0x003BFCE8
		public static void StartIFindSunSpiritGridNormalFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A4E9 RID: 107753 RVA: 0x003C1AF1 File Offset: 0x003BFCF1
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A4EA RID: 107754 RVA: 0x003C1AFC File Offset: 0x003BFCFC
		public static void AddSpreadDevice(FlatBufferBuilder builder, bool spreadDevice)
		{
			builder.AddBool(1, spreadDevice, false);
		}

		// Token: 0x0601A4EB RID: 107755 RVA: 0x003C1B07 File Offset: 0x003BFD07
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601A4EC RID: 107756 RVA: 0x003C1B12 File Offset: 0x003BFD12
		public static Offset<IFindSunSpiritGridNormalFloor> EndIFindSunSpiritGridNormalFloor(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridNormalFloor>(builder.EndTable());
		}

		// Token: 0x0601A4ED RID: 107757 RVA: 0x003C1B20 File Offset: 0x003BFD20
		public IFindSunSpiritGridNormalFloorT UnPack()
		{
			IFindSunSpiritGridNormalFloorT findSunSpiritGridNormalFloorT = new IFindSunSpiritGridNormalFloorT();
			this.UnPackTo(findSunSpiritGridNormalFloorT);
			return findSunSpiritGridNormalFloorT;
		}

		// Token: 0x0601A4EE RID: 107758 RVA: 0x003C1B3B File Offset: 0x003BFD3B
		public void UnPackTo(IFindSunSpiritGridNormalFloorT _o)
		{
			_o.Type = this.Type;
			_o.SpreadDevice = this.SpreadDevice;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A4EF RID: 107759 RVA: 0x003C1B64 File Offset: 0x003BFD64
		public static Offset<IFindSunSpiritGridNormalFloor> Pack(FlatBufferBuilder builder, IFindSunSpiritGridNormalFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridNormalFloor>);
			}
			return IFindSunSpiritGridNormalFloor.CreateIFindSunSpiritGridNormalFloor(builder, _o.Type, _o.SpreadDevice, _o.NullMask);
		}

		// Token: 0x0400C4D9 RID: 50393
		private Table __p;
	}
}
