using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF8 RID: 28664
	public struct IInformationViewConfig : IFlatbufferObject
	{
		// Token: 0x1700D1F2 RID: 53746
		// (get) Token: 0x06031AB2 RID: 203442 RVA: 0x006BA44E File Offset: 0x006B864E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031AB3 RID: 203443 RVA: 0x006BA45B File Offset: 0x006B865B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031AB4 RID: 203444 RVA: 0x006BA464 File Offset: 0x006B8664
		public static IInformationViewConfig GetRootAsIInformationViewConfig(ByteBuffer _bb)
		{
			return IInformationViewConfig.GetRootAsIInformationViewConfig(_bb, default(IInformationViewConfig));
		}

		// Token: 0x06031AB5 RID: 203445 RVA: 0x006BA480 File Offset: 0x006B8680
		public static IInformationViewConfig GetRootAsIInformationViewConfig(ByteBuffer _bb, IInformationViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031AB6 RID: 203446 RVA: 0x006BA49D File Offset: 0x006B869D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031AB7 RID: 203447 RVA: 0x006BA4AC File Offset: 0x006B86AC
		public IInformationViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1F3 RID: 53747
		// (get) Token: 0x06031AB8 RID: 203448 RVA: 0x006BA4BC File Offset: 0x006B86BC
		public int InfoDisplayGroup
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D1F4 RID: 53748
		// (get) Token: 0x06031AB9 RID: 203449 RVA: 0x006BA4F8 File Offset: 0x006B86F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031ABA RID: 203450 RVA: 0x006BA534 File Offset: 0x006B8734
		public static Offset<IInformationViewConfig> CreateIInformationViewConfig(FlatBufferBuilder builder, int InfoDisplayGroup = 0, byte NullMask = 0)
		{
			builder.StartTable(2);
			IInformationViewConfig.AddInfoDisplayGroup(builder, InfoDisplayGroup);
			IInformationViewConfig.AddNullMask(builder, NullMask);
			return IInformationViewConfig.EndIInformationViewConfig(builder);
		}

		// Token: 0x06031ABB RID: 203451 RVA: 0x006BA551 File Offset: 0x006B8751
		public static void StartIInformationViewConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031ABC RID: 203452 RVA: 0x006BA55A File Offset: 0x006B875A
		public static void AddInfoDisplayGroup(FlatBufferBuilder builder, int infoDisplayGroup)
		{
			builder.AddInt(0, infoDisplayGroup, 0);
		}

		// Token: 0x06031ABD RID: 203453 RVA: 0x006BA565 File Offset: 0x006B8765
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06031ABE RID: 203454 RVA: 0x006BA570 File Offset: 0x006B8770
		public static Offset<IInformationViewConfig> EndIInformationViewConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInformationViewConfig>(builder.EndTable());
		}

		// Token: 0x06031ABF RID: 203455 RVA: 0x006BA580 File Offset: 0x006B8780
		public IInformationViewConfigT UnPack()
		{
			IInformationViewConfigT informationViewConfigT = new IInformationViewConfigT();
			this.UnPackTo(informationViewConfigT);
			return informationViewConfigT;
		}

		// Token: 0x06031AC0 RID: 203456 RVA: 0x006BA59B File Offset: 0x006B879B
		public void UnPackTo(IInformationViewConfigT _o)
		{
			_o.InfoDisplayGroup = this.InfoDisplayGroup;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031AC1 RID: 203457 RVA: 0x006BA5B8 File Offset: 0x006B87B8
		public static Offset<IInformationViewConfig> Pack(FlatBufferBuilder builder, IInformationViewConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationViewConfig>);
			}
			return IInformationViewConfig.CreateIInformationViewConfig(builder, _o.InfoDisplayGroup, _o.NullMask);
		}

		// Token: 0x04011F2F RID: 73519
		private Table __p;
	}
}
