using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005494 RID: 21652
	public struct IItemFoundation2 : IFlatbufferObject
	{
		// Token: 0x17009F72 RID: 40818
		// (get) Token: 0x06023A26 RID: 145958 RVA: 0x004ED51C File Offset: 0x004EB71C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023A27 RID: 145959 RVA: 0x004ED529 File Offset: 0x004EB729
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023A28 RID: 145960 RVA: 0x004ED530 File Offset: 0x004EB730
		public static IItemFoundation2 GetRootAsIItemFoundation2(ByteBuffer _bb)
		{
			return IItemFoundation2.GetRootAsIItemFoundation2(_bb, default(IItemFoundation2));
		}

		// Token: 0x06023A29 RID: 145961 RVA: 0x004ED54C File Offset: 0x004EB74C
		public static IItemFoundation2 GetRootAsIItemFoundation2(ByteBuffer _bb, IItemFoundation2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023A2A RID: 145962 RVA: 0x004ED569 File Offset: 0x004EB769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023A2B RID: 145963 RVA: 0x004ED578 File Offset: 0x004EB778
		public IItemFoundation2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F73 RID: 40819
		// (get) Token: 0x06023A2C RID: 145964 RVA: 0x004ED588 File Offset: 0x004EB788
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F74 RID: 40820
		// (get) Token: 0x06023A2D RID: 145965 RVA: 0x004ED5C8 File Offset: 0x004EB7C8
		public TItemFoundation ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TItemFoundation.NONE;
				}
				return (TItemFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023A2E RID: 145966 RVA: 0x004ED604 File Offset: 0x004EB804
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023A2F RID: 145967 RVA: 0x004ED648 File Offset: 0x004EB848
		public IBuildingBlockFoundation ConfigAsIBuildingBlockFoundation()
		{
			return this.Config<IBuildingBlockFoundation>().Value;
		}

		// Token: 0x06023A30 RID: 145968 RVA: 0x004ED664 File Offset: 0x004EB864
		public ICategoryMatchingFoundation ConfigAsICategoryMatchingFoundation()
		{
			return this.Config<ICategoryMatchingFoundation>().Value;
		}

		// Token: 0x06023A31 RID: 145969 RVA: 0x004ED680 File Offset: 0x004EB880
		public IPulseDeviceFoundation ConfigAsIPulseDeviceFoundation()
		{
			return this.Config<IPulseDeviceFoundation>().Value;
		}

		// Token: 0x06023A32 RID: 145970 RVA: 0x004ED69C File Offset: 0x004EB89C
		public IRangeAdsorptionFoundation ConfigAsIRangeAdsorptionFoundation()
		{
			return this.Config<IRangeAdsorptionFoundation>().Value;
		}

		// Token: 0x17009F75 RID: 40821
		// (get) Token: 0x06023A33 RID: 145971 RVA: 0x004ED6B8 File Offset: 0x004EB8B8
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

		// Token: 0x06023A34 RID: 145972 RVA: 0x004ED6F5 File Offset: 0x004EB8F5
		public static Offset<IItemFoundation2> CreateIItemFoundation2(FlatBufferBuilder builder, bool Disabled = false, TItemFoundation Config_type = TItemFoundation.NONE, int ConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IItemFoundation2.AddConfig(builder, ConfigOffset);
			IItemFoundation2.AddNullMask(builder, NullMask);
			IItemFoundation2.AddConfigType(builder, Config_type);
			IItemFoundation2.AddDisabled(builder, Disabled);
			return IItemFoundation2.EndIItemFoundation2(builder);
		}

		// Token: 0x06023A35 RID: 145973 RVA: 0x004ED721 File Offset: 0x004EB921
		public static void StartIItemFoundation2(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023A36 RID: 145974 RVA: 0x004ED72A File Offset: 0x004EB92A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023A37 RID: 145975 RVA: 0x004ED735 File Offset: 0x004EB935
		public static void AddConfigType(FlatBufferBuilder builder, TItemFoundation configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x06023A38 RID: 145976 RVA: 0x004ED740 File Offset: 0x004EB940
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x06023A39 RID: 145977 RVA: 0x004ED74B File Offset: 0x004EB94B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023A3A RID: 145978 RVA: 0x004ED756 File Offset: 0x004EB956
		public static Offset<IItemFoundation2> EndIItemFoundation2(FlatBufferBuilder builder)
		{
			return new Offset<IItemFoundation2>(builder.EndTable());
		}

		// Token: 0x06023A3B RID: 145979 RVA: 0x004ED764 File Offset: 0x004EB964
		public IItemFoundation2T UnPack()
		{
			IItemFoundation2T itemFoundation2T = new IItemFoundation2T();
			this.UnPackTo(itemFoundation2T);
			return itemFoundation2T;
		}

		// Token: 0x06023A3C RID: 145980 RVA: 0x004ED780 File Offset: 0x004EB980
		public void UnPackTo(IItemFoundation2T _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = new TItemFoundationUnion();
			_o.Config.Type = this.ConfigType;
			switch (this.ConfigType)
			{
			case TItemFoundation.IBuildingBlockFoundation:
				_o.Config.Value = ((this.Config<IBuildingBlockFoundation>() != null) ? this.Config<IBuildingBlockFoundation>().Value.UnPack() : null);
				break;
			case TItemFoundation.ICategoryMatchingFoundation:
				_o.Config.Value = ((this.Config<ICategoryMatchingFoundation>() != null) ? this.Config<ICategoryMatchingFoundation>().Value.UnPack() : null);
				break;
			case TItemFoundation.IPulseDeviceFoundation:
				_o.Config.Value = ((this.Config<IPulseDeviceFoundation>() != null) ? this.Config<IPulseDeviceFoundation>().Value.UnPack() : null);
				break;
			case TItemFoundation.IRangeAdsorptionFoundation:
				_o.Config.Value = ((this.Config<IRangeAdsorptionFoundation>() != null) ? this.Config<IRangeAdsorptionFoundation>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023A3D RID: 145981 RVA: 0x004ED8C8 File Offset: 0x004EBAC8
		public static Offset<IItemFoundation2> Pack(FlatBufferBuilder builder, IItemFoundation2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemFoundation2>);
			}
			TItemFoundation config_type = (_o.Config == null) ? TItemFoundation.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TItemFoundationUnion.Pack(builder, _o.Config);
			return IItemFoundation2.CreateIItemFoundation2(builder, _o.Disabled, config_type, configOffset, _o.NullMask);
		}

		// Token: 0x0400E729 RID: 59177
		private Table __p;
	}
}
