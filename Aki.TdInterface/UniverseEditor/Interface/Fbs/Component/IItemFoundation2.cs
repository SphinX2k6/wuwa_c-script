using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A1A RID: 23066
	public struct IItemFoundation2 : IFlatbufferObject
	{
		// Token: 0x1700A7AC RID: 42924
		// (get) Token: 0x06025ADE RID: 154334 RVA: 0x0052A590 File Offset: 0x00528790
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025ADF RID: 154335 RVA: 0x0052A59D File Offset: 0x0052879D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025AE0 RID: 154336 RVA: 0x0052A5A4 File Offset: 0x005287A4
		public static IItemFoundation2 GetRootAsIItemFoundation2(ByteBuffer _bb)
		{
			return IItemFoundation2.GetRootAsIItemFoundation2(_bb, default(IItemFoundation2));
		}

		// Token: 0x06025AE1 RID: 154337 RVA: 0x0052A5C0 File Offset: 0x005287C0
		public static IItemFoundation2 GetRootAsIItemFoundation2(ByteBuffer _bb, IItemFoundation2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025AE2 RID: 154338 RVA: 0x0052A5DD File Offset: 0x005287DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025AE3 RID: 154339 RVA: 0x0052A5EC File Offset: 0x005287EC
		public IItemFoundation2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7AD RID: 42925
		// (get) Token: 0x06025AE4 RID: 154340 RVA: 0x0052A5FC File Offset: 0x005287FC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A7AE RID: 42926
		// (get) Token: 0x06025AE5 RID: 154341 RVA: 0x0052A63C File Offset: 0x0052883C
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

		// Token: 0x06025AE6 RID: 154342 RVA: 0x0052A678 File Offset: 0x00528878
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025AE7 RID: 154343 RVA: 0x0052A6BC File Offset: 0x005288BC
		public IBuildingBlockFoundation ConfigAsIBuildingBlockFoundation()
		{
			return this.Config<IBuildingBlockFoundation>().Value;
		}

		// Token: 0x06025AE8 RID: 154344 RVA: 0x0052A6D8 File Offset: 0x005288D8
		public ICategoryMatchingFoundation ConfigAsICategoryMatchingFoundation()
		{
			return this.Config<ICategoryMatchingFoundation>().Value;
		}

		// Token: 0x06025AE9 RID: 154345 RVA: 0x0052A6F4 File Offset: 0x005288F4
		public IPulseDeviceFoundation ConfigAsIPulseDeviceFoundation()
		{
			return this.Config<IPulseDeviceFoundation>().Value;
		}

		// Token: 0x06025AEA RID: 154346 RVA: 0x0052A710 File Offset: 0x00528910
		public IRangeAdsorptionFoundation ConfigAsIRangeAdsorptionFoundation()
		{
			return this.Config<IRangeAdsorptionFoundation>().Value;
		}

		// Token: 0x1700A7AF RID: 42927
		// (get) Token: 0x06025AEB RID: 154347 RVA: 0x0052A72C File Offset: 0x0052892C
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

		// Token: 0x06025AEC RID: 154348 RVA: 0x0052A769 File Offset: 0x00528969
		public static Offset<IItemFoundation2> CreateIItemFoundation2(FlatBufferBuilder builder, bool Disabled = false, TItemFoundation Config_type = TItemFoundation.NONE, int ConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IItemFoundation2.AddConfig(builder, ConfigOffset);
			IItemFoundation2.AddNullMask(builder, NullMask);
			IItemFoundation2.AddConfigType(builder, Config_type);
			IItemFoundation2.AddDisabled(builder, Disabled);
			return IItemFoundation2.EndIItemFoundation2(builder);
		}

		// Token: 0x06025AED RID: 154349 RVA: 0x0052A795 File Offset: 0x00528995
		public static void StartIItemFoundation2(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025AEE RID: 154350 RVA: 0x0052A79E File Offset: 0x0052899E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025AEF RID: 154351 RVA: 0x0052A7A9 File Offset: 0x005289A9
		public static void AddConfigType(FlatBufferBuilder builder, TItemFoundation configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x06025AF0 RID: 154352 RVA: 0x0052A7B4 File Offset: 0x005289B4
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x06025AF1 RID: 154353 RVA: 0x0052A7BF File Offset: 0x005289BF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025AF2 RID: 154354 RVA: 0x0052A7CA File Offset: 0x005289CA
		public static Offset<IItemFoundation2> EndIItemFoundation2(FlatBufferBuilder builder)
		{
			return new Offset<IItemFoundation2>(builder.EndTable());
		}

		// Token: 0x06025AF3 RID: 154355 RVA: 0x0052A7D8 File Offset: 0x005289D8
		public IItemFoundation2T UnPack()
		{
			IItemFoundation2T itemFoundation2T = new IItemFoundation2T();
			this.UnPackTo(itemFoundation2T);
			return itemFoundation2T;
		}

		// Token: 0x06025AF4 RID: 154356 RVA: 0x0052A7F4 File Offset: 0x005289F4
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

		// Token: 0x06025AF5 RID: 154357 RVA: 0x0052A93C File Offset: 0x00528B3C
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

		// Token: 0x0400F35A RID: 62298
		private Table __p;
	}
}
