using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C18 RID: 27672
	public struct IOpenQteAction : IFlatbufferObject
	{
		// Token: 0x1700CDD2 RID: 52690
		// (get) Token: 0x06030AA7 RID: 199335 RVA: 0x0069B558 File Offset: 0x00699758
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030AA8 RID: 199336 RVA: 0x0069B565 File Offset: 0x00699765
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030AA9 RID: 199337 RVA: 0x0069B56C File Offset: 0x0069976C
		public static IOpenQteAction GetRootAsIOpenQteAction(ByteBuffer _bb)
		{
			return IOpenQteAction.GetRootAsIOpenQteAction(_bb, default(IOpenQteAction));
		}

		// Token: 0x06030AAA RID: 199338 RVA: 0x0069B588 File Offset: 0x00699788
		public static IOpenQteAction GetRootAsIOpenQteAction(ByteBuffer _bb, IOpenQteAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030AAB RID: 199339 RVA: 0x0069B5A5 File Offset: 0x006997A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030AAC RID: 199340 RVA: 0x0069B5B4 File Offset: 0x006997B4
		public IOpenQteAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDD3 RID: 52691
		// (get) Token: 0x06030AAD RID: 199341 RVA: 0x0069B5C4 File Offset: 0x006997C4
		public TOpenQteConfig ConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TOpenQteConfig.NONE;
				}
				return (TOpenQteConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030AAE RID: 199342 RVA: 0x0069B600 File Offset: 0x00699800
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030AAF RID: 199343 RVA: 0x0069B644 File Offset: 0x00699844
		public IOpenLevelQte ConfigAsIOpenLevelQte()
		{
			return this.Config<IOpenLevelQte>().Value;
		}

		// Token: 0x06030AB0 RID: 199344 RVA: 0x0069B660 File Offset: 0x00699860
		public IOpenPanelQteQte ConfigAsIOpenPanelQteQte()
		{
			return this.Config<IOpenPanelQteQte>().Value;
		}

		// Token: 0x06030AB1 RID: 199345 RVA: 0x0069B67B File Offset: 0x0069987B
		public static Offset<IOpenQteAction> CreateIOpenQteAction(FlatBufferBuilder builder, TOpenQteConfig Config_type = TOpenQteConfig.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			IOpenQteAction.AddConfig(builder, ConfigOffset);
			IOpenQteAction.AddConfigType(builder, Config_type);
			return IOpenQteAction.EndIOpenQteAction(builder);
		}

		// Token: 0x06030AB2 RID: 199346 RVA: 0x0069B698 File Offset: 0x00699898
		public static void StartIOpenQteAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030AB3 RID: 199347 RVA: 0x0069B6A1 File Offset: 0x006998A1
		public static void AddConfigType(FlatBufferBuilder builder, TOpenQteConfig configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06030AB4 RID: 199348 RVA: 0x0069B6AC File Offset: 0x006998AC
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06030AB5 RID: 199349 RVA: 0x0069B6B7 File Offset: 0x006998B7
		public static Offset<IOpenQteAction> EndIOpenQteAction(FlatBufferBuilder builder)
		{
			return new Offset<IOpenQteAction>(builder.EndTable());
		}

		// Token: 0x06030AB6 RID: 199350 RVA: 0x0069B6C4 File Offset: 0x006998C4
		public IOpenQteActionT UnPack()
		{
			IOpenQteActionT openQteActionT = new IOpenQteActionT();
			this.UnPackTo(openQteActionT);
			return openQteActionT;
		}

		// Token: 0x06030AB7 RID: 199351 RVA: 0x0069B6E0 File Offset: 0x006998E0
		public void UnPackTo(IOpenQteActionT _o)
		{
			_o.Config = new TOpenQteConfigUnion();
			_o.Config.Type = this.ConfigType;
			TOpenQteConfig configType = this.ConfigType;
			if (configType == TOpenQteConfig.IOpenLevelQte)
			{
				_o.Config.Value = ((this.Config<IOpenLevelQte>() != null) ? this.Config<IOpenLevelQte>().Value.UnPack() : null);
				return;
			}
			if (configType != TOpenQteConfig.IOpenPanelQteQte)
			{
				return;
			}
			_o.Config.Value = ((this.Config<IOpenPanelQteQte>() != null) ? this.Config<IOpenPanelQteQte>().Value.UnPack() : null);
		}

		// Token: 0x06030AB8 RID: 199352 RVA: 0x0069B784 File Offset: 0x00699984
		public static Offset<IOpenQteAction> Pack(FlatBufferBuilder builder, IOpenQteActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenQteAction>);
			}
			TOpenQteConfig config_type = (_o.Config == null) ? TOpenQteConfig.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TOpenQteConfigUnion.Pack(builder, _o.Config);
			return IOpenQteAction.CreateIOpenQteAction(builder, config_type, configOffset);
		}

		// Token: 0x0401151D RID: 70941
		private Table __p;
	}
}
