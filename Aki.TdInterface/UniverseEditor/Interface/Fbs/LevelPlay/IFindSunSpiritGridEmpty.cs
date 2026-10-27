using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044BB RID: 17595
	public struct IFindSunSpiritGridEmpty : IFlatbufferObject
	{
		// Token: 0x17007C29 RID: 31785
		// (get) Token: 0x0601A494 RID: 107668 RVA: 0x003C1276 File Offset: 0x003BF476
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A495 RID: 107669 RVA: 0x003C1283 File Offset: 0x003BF483
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A496 RID: 107670 RVA: 0x003C128C File Offset: 0x003BF48C
		public static IFindSunSpiritGridEmpty GetRootAsIFindSunSpiritGridEmpty(ByteBuffer _bb)
		{
			return IFindSunSpiritGridEmpty.GetRootAsIFindSunSpiritGridEmpty(_bb, default(IFindSunSpiritGridEmpty));
		}

		// Token: 0x0601A497 RID: 107671 RVA: 0x003C12A8 File Offset: 0x003BF4A8
		public static IFindSunSpiritGridEmpty GetRootAsIFindSunSpiritGridEmpty(ByteBuffer _bb, IFindSunSpiritGridEmpty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A498 RID: 107672 RVA: 0x003C12C5 File Offset: 0x003BF4C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A499 RID: 107673 RVA: 0x003C12D4 File Offset: 0x003BF4D4
		public IFindSunSpiritGridEmpty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C2A RID: 31786
		// (get) Token: 0x0601A49A RID: 107674 RVA: 0x003C12E4 File Offset: 0x003BF4E4
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

		// Token: 0x17007C2B RID: 31787
		// (get) Token: 0x0601A49B RID: 107675 RVA: 0x003C1320 File Offset: 0x003BF520
		public bool SpreadDevice
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007C2C RID: 31788
		// (get) Token: 0x0601A49C RID: 107676 RVA: 0x003C1360 File Offset: 0x003BF560
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

		// Token: 0x0601A49D RID: 107677 RVA: 0x003C139C File Offset: 0x003BF59C
		public static Offset<IFindSunSpiritGridEmpty> CreateIFindSunSpiritGridEmpty(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty, bool SpreadDevice = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IFindSunSpiritGridEmpty.AddNullMask(builder, NullMask);
			IFindSunSpiritGridEmpty.AddSpreadDevice(builder, SpreadDevice);
			IFindSunSpiritGridEmpty.AddType(builder, Type);
			return IFindSunSpiritGridEmpty.EndIFindSunSpiritGridEmpty(builder);
		}

		// Token: 0x0601A49E RID: 107678 RVA: 0x003C13C0 File Offset: 0x003BF5C0
		public static void StartIFindSunSpiritGridEmpty(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A49F RID: 107679 RVA: 0x003C13C9 File Offset: 0x003BF5C9
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A4A0 RID: 107680 RVA: 0x003C13D4 File Offset: 0x003BF5D4
		public static void AddSpreadDevice(FlatBufferBuilder builder, bool spreadDevice)
		{
			builder.AddBool(1, spreadDevice, false);
		}

		// Token: 0x0601A4A1 RID: 107681 RVA: 0x003C13DF File Offset: 0x003BF5DF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601A4A2 RID: 107682 RVA: 0x003C13EA File Offset: 0x003BF5EA
		public static Offset<IFindSunSpiritGridEmpty> EndIFindSunSpiritGridEmpty(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridEmpty>(builder.EndTable());
		}

		// Token: 0x0601A4A3 RID: 107683 RVA: 0x003C13F8 File Offset: 0x003BF5F8
		public IFindSunSpiritGridEmptyT UnPack()
		{
			IFindSunSpiritGridEmptyT findSunSpiritGridEmptyT = new IFindSunSpiritGridEmptyT();
			this.UnPackTo(findSunSpiritGridEmptyT);
			return findSunSpiritGridEmptyT;
		}

		// Token: 0x0601A4A4 RID: 107684 RVA: 0x003C1413 File Offset: 0x003BF613
		public void UnPackTo(IFindSunSpiritGridEmptyT _o)
		{
			_o.Type = this.Type;
			_o.SpreadDevice = this.SpreadDevice;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A4A5 RID: 107685 RVA: 0x003C143C File Offset: 0x003BF63C
		public static Offset<IFindSunSpiritGridEmpty> Pack(FlatBufferBuilder builder, IFindSunSpiritGridEmptyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridEmpty>);
			}
			return IFindSunSpiritGridEmpty.CreateIFindSunSpiritGridEmpty(builder, _o.Type, _o.SpreadDevice, _o.NullMask);
		}

		// Token: 0x0400C4CE RID: 50382
		private Table __p;
	}
}
