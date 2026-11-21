using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004929 RID: 18729
	public struct IFindSunSpiritGridMutableFloor : IFlatbufferObject
	{
		// Token: 0x17008272 RID: 33394
		// (get) Token: 0x0601BC91 RID: 113809 RVA: 0x003ED88D File Offset: 0x003EBA8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BC92 RID: 113810 RVA: 0x003ED89A File Offset: 0x003EBA9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BC93 RID: 113811 RVA: 0x003ED8A4 File Offset: 0x003EBAA4
		public static IFindSunSpiritGridMutableFloor GetRootAsIFindSunSpiritGridMutableFloor(ByteBuffer _bb)
		{
			return IFindSunSpiritGridMutableFloor.GetRootAsIFindSunSpiritGridMutableFloor(_bb, default(IFindSunSpiritGridMutableFloor));
		}

		// Token: 0x0601BC94 RID: 113812 RVA: 0x003ED8C0 File Offset: 0x003EBAC0
		public static IFindSunSpiritGridMutableFloor GetRootAsIFindSunSpiritGridMutableFloor(ByteBuffer _bb, IFindSunSpiritGridMutableFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BC95 RID: 113813 RVA: 0x003ED8DD File Offset: 0x003EBADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BC96 RID: 113814 RVA: 0x003ED8EC File Offset: 0x003EBAEC
		public IFindSunSpiritGridMutableFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008273 RID: 33395
		// (get) Token: 0x0601BC97 RID: 113815 RVA: 0x003ED8FC File Offset: 0x003EBAFC
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

		// Token: 0x17008274 RID: 33396
		// (get) Token: 0x0601BC98 RID: 113816 RVA: 0x003ED938 File Offset: 0x003EBB38
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

		// Token: 0x17008275 RID: 33397
		// (get) Token: 0x0601BC99 RID: 113817 RVA: 0x003ED974 File Offset: 0x003EBB74
		public bool SpreadDevice
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008276 RID: 33398
		// (get) Token: 0x0601BC9A RID: 113818 RVA: 0x003ED9B4 File Offset: 0x003EBBB4
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

		// Token: 0x0601BC9B RID: 113819 RVA: 0x003ED9F1 File Offset: 0x003EBBF1
		public static Offset<IFindSunSpiritGridMutableFloor> CreateIFindSunSpiritGridMutableFloor(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty, EFindSunSpiritGridState State = EFindSunSpiritGridState.Virtual, bool SpreadDevice = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFindSunSpiritGridMutableFloor.AddNullMask(builder, NullMask);
			IFindSunSpiritGridMutableFloor.AddSpreadDevice(builder, SpreadDevice);
			IFindSunSpiritGridMutableFloor.AddState(builder, State);
			IFindSunSpiritGridMutableFloor.AddType(builder, Type);
			return IFindSunSpiritGridMutableFloor.EndIFindSunSpiritGridMutableFloor(builder);
		}

		// Token: 0x0601BC9C RID: 113820 RVA: 0x003EDA1D File Offset: 0x003EBC1D
		public static void StartIFindSunSpiritGridMutableFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601BC9D RID: 113821 RVA: 0x003EDA26 File Offset: 0x003EBC26
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BC9E RID: 113822 RVA: 0x003EDA31 File Offset: 0x003EBC31
		public static void AddState(FlatBufferBuilder builder, EFindSunSpiritGridState state)
		{
			builder.AddByte(1, (byte)state, 0);
		}

		// Token: 0x0601BC9F RID: 113823 RVA: 0x003EDA3C File Offset: 0x003EBC3C
		public static void AddSpreadDevice(FlatBufferBuilder builder, bool spreadDevice)
		{
			builder.AddBool(2, spreadDevice, false);
		}

		// Token: 0x0601BCA0 RID: 113824 RVA: 0x003EDA47 File Offset: 0x003EBC47
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601BCA1 RID: 113825 RVA: 0x003EDA52 File Offset: 0x003EBC52
		public static Offset<IFindSunSpiritGridMutableFloor> EndIFindSunSpiritGridMutableFloor(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridMutableFloor>(builder.EndTable());
		}

		// Token: 0x0601BCA2 RID: 113826 RVA: 0x003EDA60 File Offset: 0x003EBC60
		public IFindSunSpiritGridMutableFloorT UnPack()
		{
			IFindSunSpiritGridMutableFloorT findSunSpiritGridMutableFloorT = new IFindSunSpiritGridMutableFloorT();
			this.UnPackTo(findSunSpiritGridMutableFloorT);
			return findSunSpiritGridMutableFloorT;
		}

		// Token: 0x0601BCA3 RID: 113827 RVA: 0x003EDA7B File Offset: 0x003EBC7B
		public void UnPackTo(IFindSunSpiritGridMutableFloorT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
			_o.SpreadDevice = this.SpreadDevice;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BCA4 RID: 113828 RVA: 0x003EDAB0 File Offset: 0x003EBCB0
		public static Offset<IFindSunSpiritGridMutableFloor> Pack(FlatBufferBuilder builder, IFindSunSpiritGridMutableFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridMutableFloor>);
			}
			return IFindSunSpiritGridMutableFloor.CreateIFindSunSpiritGridMutableFloor(builder, _o.Type, _o.State, _o.SpreadDevice, _o.NullMask);
		}

		// Token: 0x0400CF02 RID: 52994
		private Table __p;
	}
}
