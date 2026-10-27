using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200705E RID: 28766
	public struct ISetRegionConfig : IFlatbufferObject
	{
		// Token: 0x1700D5D5 RID: 54741
		// (get) Token: 0x06032EF6 RID: 208630 RVA: 0x006DF45B File Offset: 0x006DD65B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032EF7 RID: 208631 RVA: 0x006DF468 File Offset: 0x006DD668
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032EF8 RID: 208632 RVA: 0x006DF470 File Offset: 0x006DD670
		public static ISetRegionConfig GetRootAsISetRegionConfig(ByteBuffer _bb)
		{
			return ISetRegionConfig.GetRootAsISetRegionConfig(_bb, default(ISetRegionConfig));
		}

		// Token: 0x06032EF9 RID: 208633 RVA: 0x006DF48C File Offset: 0x006DD68C
		public static ISetRegionConfig GetRootAsISetRegionConfig(ByteBuffer _bb, ISetRegionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032EFA RID: 208634 RVA: 0x006DF4A9 File Offset: 0x006DD6A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032EFB RID: 208635 RVA: 0x006DF4B8 File Offset: 0x006DD6B8
		public ISetRegionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5D6 RID: 54742
		// (get) Token: 0x06032EFC RID: 208636 RVA: 0x006DF4C8 File Offset: 0x006DD6C8
		public ERegionConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERegionConfigType.Mpc;
				}
				return (ERegionConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032EFD RID: 208637 RVA: 0x006DF504 File Offset: 0x006DD704
		public static Offset<ISetRegionConfig> CreateISetRegionConfig(FlatBufferBuilder builder, ERegionConfigType Type = ERegionConfigType.Mpc)
		{
			builder.StartTable(1);
			ISetRegionConfig.AddType(builder, Type);
			return ISetRegionConfig.EndISetRegionConfig(builder);
		}

		// Token: 0x06032EFE RID: 208638 RVA: 0x006DF51A File Offset: 0x006DD71A
		public static void StartISetRegionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032EFF RID: 208639 RVA: 0x006DF523 File Offset: 0x006DD723
		public static void AddType(FlatBufferBuilder builder, ERegionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032F00 RID: 208640 RVA: 0x006DF52E File Offset: 0x006DD72E
		public static Offset<ISetRegionConfig> EndISetRegionConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISetRegionConfig>(builder.EndTable());
		}

		// Token: 0x06032F01 RID: 208641 RVA: 0x006DF53C File Offset: 0x006DD73C
		public ISetRegionConfigT UnPack()
		{
			ISetRegionConfigT setRegionConfigT = new ISetRegionConfigT();
			this.UnPackTo(setRegionConfigT);
			return setRegionConfigT;
		}

		// Token: 0x06032F02 RID: 208642 RVA: 0x006DF557 File Offset: 0x006DD757
		public void UnPackTo(ISetRegionConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032F03 RID: 208643 RVA: 0x006DF568 File Offset: 0x006DD768
		public static Offset<ISetRegionConfig> Pack(FlatBufferBuilder builder, ISetRegionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetRegionConfig>);
			}
			return ISetRegionConfig.CreateISetRegionConfig(builder, _o.Type);
		}

		// Token: 0x04011ABF RID: 72383
		private Table __p;
	}
}
