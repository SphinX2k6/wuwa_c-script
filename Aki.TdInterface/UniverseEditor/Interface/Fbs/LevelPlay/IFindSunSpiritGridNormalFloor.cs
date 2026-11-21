using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200492C RID: 18732
	public struct IFindSunSpiritGridNormalFloor : IFlatbufferObject
	{
		// Token: 0x1700827B RID: 33403
		// (get) Token: 0x0601BCAF RID: 113839 RVA: 0x003EDBAC File Offset: 0x003EBDAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BCB0 RID: 113840 RVA: 0x003EDBB9 File Offset: 0x003EBDB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BCB1 RID: 113841 RVA: 0x003EDBC0 File Offset: 0x003EBDC0
		public static IFindSunSpiritGridNormalFloor GetRootAsIFindSunSpiritGridNormalFloor(ByteBuffer _bb)
		{
			return IFindSunSpiritGridNormalFloor.GetRootAsIFindSunSpiritGridNormalFloor(_bb, default(IFindSunSpiritGridNormalFloor));
		}

		// Token: 0x0601BCB2 RID: 113842 RVA: 0x003EDBDC File Offset: 0x003EBDDC
		public static IFindSunSpiritGridNormalFloor GetRootAsIFindSunSpiritGridNormalFloor(ByteBuffer _bb, IFindSunSpiritGridNormalFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BCB3 RID: 113843 RVA: 0x003EDBF9 File Offset: 0x003EBDF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BCB4 RID: 113844 RVA: 0x003EDC08 File Offset: 0x003EBE08
		public IFindSunSpiritGridNormalFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700827C RID: 33404
		// (get) Token: 0x0601BCB5 RID: 113845 RVA: 0x003EDC18 File Offset: 0x003EBE18
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

		// Token: 0x1700827D RID: 33405
		// (get) Token: 0x0601BCB6 RID: 113846 RVA: 0x003EDC54 File Offset: 0x003EBE54
		public bool SpreadDevice
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700827E RID: 33406
		// (get) Token: 0x0601BCB7 RID: 113847 RVA: 0x003EDC94 File Offset: 0x003EBE94
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

		// Token: 0x0601BCB8 RID: 113848 RVA: 0x003EDCD0 File Offset: 0x003EBED0
		public static Offset<IFindSunSpiritGridNormalFloor> CreateIFindSunSpiritGridNormalFloor(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty, bool SpreadDevice = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IFindSunSpiritGridNormalFloor.AddNullMask(builder, NullMask);
			IFindSunSpiritGridNormalFloor.AddSpreadDevice(builder, SpreadDevice);
			IFindSunSpiritGridNormalFloor.AddType(builder, Type);
			return IFindSunSpiritGridNormalFloor.EndIFindSunSpiritGridNormalFloor(builder);
		}

		// Token: 0x0601BCB9 RID: 113849 RVA: 0x003EDCF4 File Offset: 0x003EBEF4
		public static void StartIFindSunSpiritGridNormalFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BCBA RID: 113850 RVA: 0x003EDCFD File Offset: 0x003EBEFD
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BCBB RID: 113851 RVA: 0x003EDD08 File Offset: 0x003EBF08
		public static void AddSpreadDevice(FlatBufferBuilder builder, bool spreadDevice)
		{
			builder.AddBool(1, spreadDevice, false);
		}

		// Token: 0x0601BCBC RID: 113852 RVA: 0x003EDD13 File Offset: 0x003EBF13
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601BCBD RID: 113853 RVA: 0x003EDD1E File Offset: 0x003EBF1E
		public static Offset<IFindSunSpiritGridNormalFloor> EndIFindSunSpiritGridNormalFloor(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridNormalFloor>(builder.EndTable());
		}

		// Token: 0x0601BCBE RID: 113854 RVA: 0x003EDD2C File Offset: 0x003EBF2C
		public IFindSunSpiritGridNormalFloorT UnPack()
		{
			IFindSunSpiritGridNormalFloorT findSunSpiritGridNormalFloorT = new IFindSunSpiritGridNormalFloorT();
			this.UnPackTo(findSunSpiritGridNormalFloorT);
			return findSunSpiritGridNormalFloorT;
		}

		// Token: 0x0601BCBF RID: 113855 RVA: 0x003EDD47 File Offset: 0x003EBF47
		public void UnPackTo(IFindSunSpiritGridNormalFloorT _o)
		{
			_o.Type = this.Type;
			_o.SpreadDevice = this.SpreadDevice;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BCC0 RID: 113856 RVA: 0x003EDD70 File Offset: 0x003EBF70
		public static Offset<IFindSunSpiritGridNormalFloor> Pack(FlatBufferBuilder builder, IFindSunSpiritGridNormalFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridNormalFloor>);
			}
			return IFindSunSpiritGridNormalFloor.CreateIFindSunSpiritGridNormalFloor(builder, _o.Type, _o.SpreadDevice, _o.NullMask);
		}

		// Token: 0x0400CF07 RID: 52999
		private Table __p;
	}
}
