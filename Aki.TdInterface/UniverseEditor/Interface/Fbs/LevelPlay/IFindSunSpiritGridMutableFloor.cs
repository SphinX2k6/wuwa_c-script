using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044C1 RID: 17601
	public struct IFindSunSpiritGridMutableFloor : IFlatbufferObject
	{
		// Token: 0x17007C33 RID: 31795
		// (get) Token: 0x0601A4C0 RID: 107712 RVA: 0x003C1681 File Offset: 0x003BF881
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A4C1 RID: 107713 RVA: 0x003C168E File Offset: 0x003BF88E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A4C2 RID: 107714 RVA: 0x003C1698 File Offset: 0x003BF898
		public static IFindSunSpiritGridMutableFloor GetRootAsIFindSunSpiritGridMutableFloor(ByteBuffer _bb)
		{
			return IFindSunSpiritGridMutableFloor.GetRootAsIFindSunSpiritGridMutableFloor(_bb, default(IFindSunSpiritGridMutableFloor));
		}

		// Token: 0x0601A4C3 RID: 107715 RVA: 0x003C16B4 File Offset: 0x003BF8B4
		public static IFindSunSpiritGridMutableFloor GetRootAsIFindSunSpiritGridMutableFloor(ByteBuffer _bb, IFindSunSpiritGridMutableFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A4C4 RID: 107716 RVA: 0x003C16D1 File Offset: 0x003BF8D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A4C5 RID: 107717 RVA: 0x003C16E0 File Offset: 0x003BF8E0
		public IFindSunSpiritGridMutableFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C34 RID: 31796
		// (get) Token: 0x0601A4C6 RID: 107718 RVA: 0x003C16F0 File Offset: 0x003BF8F0
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

		// Token: 0x17007C35 RID: 31797
		// (get) Token: 0x0601A4C7 RID: 107719 RVA: 0x003C172C File Offset: 0x003BF92C
		public EFindSunSpiritGridState State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EFindSunSpiritGridState.Virtual;
				}
				return (EFindSunSpiritGridState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007C36 RID: 31798
		// (get) Token: 0x0601A4C8 RID: 107720 RVA: 0x003C1768 File Offset: 0x003BF968
		public bool SpreadDevice
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007C37 RID: 31799
		// (get) Token: 0x0601A4C9 RID: 107721 RVA: 0x003C17A8 File Offset: 0x003BF9A8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A4CA RID: 107722 RVA: 0x003C17E5 File Offset: 0x003BF9E5
		public static Offset<IFindSunSpiritGridMutableFloor> CreateIFindSunSpiritGridMutableFloor(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty, EFindSunSpiritGridState State = EFindSunSpiritGridState.Virtual, bool SpreadDevice = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFindSunSpiritGridMutableFloor.AddNullMask(builder, NullMask);
			IFindSunSpiritGridMutableFloor.AddSpreadDevice(builder, SpreadDevice);
			IFindSunSpiritGridMutableFloor.AddState(builder, State);
			IFindSunSpiritGridMutableFloor.AddType(builder, Type);
			return IFindSunSpiritGridMutableFloor.EndIFindSunSpiritGridMutableFloor(builder);
		}

		// Token: 0x0601A4CB RID: 107723 RVA: 0x003C1811 File Offset: 0x003BFA11
		public static void StartIFindSunSpiritGridMutableFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A4CC RID: 107724 RVA: 0x003C181A File Offset: 0x003BFA1A
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A4CD RID: 107725 RVA: 0x003C1825 File Offset: 0x003BFA25
		public static void AddState(FlatBufferBuilder builder, EFindSunSpiritGridState state)
		{
			builder.AddByte(1, (byte)state, 0);
		}

		// Token: 0x0601A4CE RID: 107726 RVA: 0x003C1830 File Offset: 0x003BFA30
		public static void AddSpreadDevice(FlatBufferBuilder builder, bool spreadDevice)
		{
			builder.AddBool(2, spreadDevice, false);
		}

		// Token: 0x0601A4CF RID: 107727 RVA: 0x003C183B File Offset: 0x003BFA3B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601A4D0 RID: 107728 RVA: 0x003C1846 File Offset: 0x003BFA46
		public static Offset<IFindSunSpiritGridMutableFloor> EndIFindSunSpiritGridMutableFloor(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridMutableFloor>(builder.EndTable());
		}

		// Token: 0x0601A4D1 RID: 107729 RVA: 0x003C1854 File Offset: 0x003BFA54
		public IFindSunSpiritGridMutableFloorT UnPack()
		{
			IFindSunSpiritGridMutableFloorT findSunSpiritGridMutableFloorT = new IFindSunSpiritGridMutableFloorT();
			this.UnPackTo(findSunSpiritGridMutableFloorT);
			return findSunSpiritGridMutableFloorT;
		}

		// Token: 0x0601A4D2 RID: 107730 RVA: 0x003C186F File Offset: 0x003BFA6F
		public void UnPackTo(IFindSunSpiritGridMutableFloorT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
			_o.SpreadDevice = this.SpreadDevice;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A4D3 RID: 107731 RVA: 0x003C18A4 File Offset: 0x003BFAA4
		public static Offset<IFindSunSpiritGridMutableFloor> Pack(FlatBufferBuilder builder, IFindSunSpiritGridMutableFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridMutableFloor>);
			}
			return IFindSunSpiritGridMutableFloor.CreateIFindSunSpiritGridMutableFloor(builder, _o.Type, _o.State, _o.SpreadDevice, _o.NullMask);
		}

		// Token: 0x0400C4D4 RID: 50388
		private Table __p;
	}
}
