using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004923 RID: 18723
	public struct IFindSunSpiritGridEmpty : IFlatbufferObject
	{
		// Token: 0x17008268 RID: 33384
		// (get) Token: 0x0601BC65 RID: 113765 RVA: 0x003ED482 File Offset: 0x003EB682
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BC66 RID: 113766 RVA: 0x003ED48F File Offset: 0x003EB68F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BC67 RID: 113767 RVA: 0x003ED498 File Offset: 0x003EB698
		public static IFindSunSpiritGridEmpty GetRootAsIFindSunSpiritGridEmpty(ByteBuffer _bb)
		{
			return IFindSunSpiritGridEmpty.GetRootAsIFindSunSpiritGridEmpty(_bb, default(IFindSunSpiritGridEmpty));
		}

		// Token: 0x0601BC68 RID: 113768 RVA: 0x003ED4B4 File Offset: 0x003EB6B4
		public static IFindSunSpiritGridEmpty GetRootAsIFindSunSpiritGridEmpty(ByteBuffer _bb, IFindSunSpiritGridEmpty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BC69 RID: 113769 RVA: 0x003ED4D1 File Offset: 0x003EB6D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BC6A RID: 113770 RVA: 0x003ED4E0 File Offset: 0x003EB6E0
		public IFindSunSpiritGridEmpty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008269 RID: 33385
		// (get) Token: 0x0601BC6B RID: 113771 RVA: 0x003ED4F0 File Offset: 0x003EB6F0
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

		// Token: 0x1700826A RID: 33386
		// (get) Token: 0x0601BC6C RID: 113772 RVA: 0x003ED52C File Offset: 0x003EB72C
		public bool SpreadDevice
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700826B RID: 33387
		// (get) Token: 0x0601BC6D RID: 113773 RVA: 0x003ED56C File Offset: 0x003EB76C
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

		// Token: 0x0601BC6E RID: 113774 RVA: 0x003ED5A8 File Offset: 0x003EB7A8
		public static Offset<IFindSunSpiritGridEmpty> CreateIFindSunSpiritGridEmpty(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty, bool SpreadDevice = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IFindSunSpiritGridEmpty.AddNullMask(builder, NullMask);
			IFindSunSpiritGridEmpty.AddSpreadDevice(builder, SpreadDevice);
			IFindSunSpiritGridEmpty.AddType(builder, Type);
			return IFindSunSpiritGridEmpty.EndIFindSunSpiritGridEmpty(builder);
		}

		// Token: 0x0601BC6F RID: 113775 RVA: 0x003ED5CC File Offset: 0x003EB7CC
		public static void StartIFindSunSpiritGridEmpty(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BC70 RID: 113776 RVA: 0x003ED5D5 File Offset: 0x003EB7D5
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BC71 RID: 113777 RVA: 0x003ED5E0 File Offset: 0x003EB7E0
		public static void AddSpreadDevice(FlatBufferBuilder builder, bool spreadDevice)
		{
			builder.AddBool(1, spreadDevice, false);
		}

		// Token: 0x0601BC72 RID: 113778 RVA: 0x003ED5EB File Offset: 0x003EB7EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601BC73 RID: 113779 RVA: 0x003ED5F6 File Offset: 0x003EB7F6
		public static Offset<IFindSunSpiritGridEmpty> EndIFindSunSpiritGridEmpty(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridEmpty>(builder.EndTable());
		}

		// Token: 0x0601BC74 RID: 113780 RVA: 0x003ED604 File Offset: 0x003EB804
		public IFindSunSpiritGridEmptyT UnPack()
		{
			IFindSunSpiritGridEmptyT findSunSpiritGridEmptyT = new IFindSunSpiritGridEmptyT();
			this.UnPackTo(findSunSpiritGridEmptyT);
			return findSunSpiritGridEmptyT;
		}

		// Token: 0x0601BC75 RID: 113781 RVA: 0x003ED61F File Offset: 0x003EB81F
		public void UnPackTo(IFindSunSpiritGridEmptyT _o)
		{
			_o.Type = this.Type;
			_o.SpreadDevice = this.SpreadDevice;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BC76 RID: 113782 RVA: 0x003ED648 File Offset: 0x003EB848
		public static Offset<IFindSunSpiritGridEmpty> Pack(FlatBufferBuilder builder, IFindSunSpiritGridEmptyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridEmpty>);
			}
			return IFindSunSpiritGridEmpty.CreateIFindSunSpiritGridEmpty(builder, _o.Type, _o.SpreadDevice, _o.NullMask);
		}

		// Token: 0x0400CEFC RID: 52988
		private Table __p;
	}
}
