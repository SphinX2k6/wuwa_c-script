using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200737F RID: 29567
	public struct IOpenQteAction : IFlatbufferObject
	{
		// Token: 0x1700D8ED RID: 55533
		// (get) Token: 0x060339FB RID: 211451 RVA: 0x006F5854 File Offset: 0x006F3A54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060339FC RID: 211452 RVA: 0x006F5861 File Offset: 0x006F3A61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060339FD RID: 211453 RVA: 0x006F5868 File Offset: 0x006F3A68
		public static IOpenQteAction GetRootAsIOpenQteAction(ByteBuffer _bb)
		{
			return IOpenQteAction.GetRootAsIOpenQteAction(_bb, default(IOpenQteAction));
		}

		// Token: 0x060339FE RID: 211454 RVA: 0x006F5884 File Offset: 0x006F3A84
		public static IOpenQteAction GetRootAsIOpenQteAction(ByteBuffer _bb, IOpenQteAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060339FF RID: 211455 RVA: 0x006F58A1 File Offset: 0x006F3AA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033A00 RID: 211456 RVA: 0x006F58B0 File Offset: 0x006F3AB0
		public IOpenQteAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8EE RID: 55534
		// (get) Token: 0x06033A01 RID: 211457 RVA: 0x006F58C0 File Offset: 0x006F3AC0
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

		// Token: 0x06033A02 RID: 211458 RVA: 0x006F58FC File Offset: 0x006F3AFC
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033A03 RID: 211459 RVA: 0x006F5940 File Offset: 0x006F3B40
		public IOpenLevelQte ConfigAsIOpenLevelQte()
		{
			return this.Config<IOpenLevelQte>().Value;
		}

		// Token: 0x06033A04 RID: 211460 RVA: 0x006F595C File Offset: 0x006F3B5C
		public IOpenPanelQteQte ConfigAsIOpenPanelQteQte()
		{
			return this.Config<IOpenPanelQteQte>().Value;
		}

		// Token: 0x06033A05 RID: 211461 RVA: 0x006F5977 File Offset: 0x006F3B77
		public static Offset<IOpenQteAction> CreateIOpenQteAction(FlatBufferBuilder builder, TOpenQteConfig Config_type = TOpenQteConfig.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			IOpenQteAction.AddConfig(builder, ConfigOffset);
			IOpenQteAction.AddConfigType(builder, Config_type);
			return IOpenQteAction.EndIOpenQteAction(builder);
		}

		// Token: 0x06033A06 RID: 211462 RVA: 0x006F5994 File Offset: 0x006F3B94
		public static void StartIOpenQteAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033A07 RID: 211463 RVA: 0x006F599D File Offset: 0x006F3B9D
		public static void AddConfigType(FlatBufferBuilder builder, TOpenQteConfig configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06033A08 RID: 211464 RVA: 0x006F59A8 File Offset: 0x006F3BA8
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06033A09 RID: 211465 RVA: 0x006F59B3 File Offset: 0x006F3BB3
		public static Offset<IOpenQteAction> EndIOpenQteAction(FlatBufferBuilder builder)
		{
			return new Offset<IOpenQteAction>(builder.EndTable());
		}

		// Token: 0x06033A0A RID: 211466 RVA: 0x006F59C0 File Offset: 0x006F3BC0
		public IOpenQteActionT UnPack()
		{
			IOpenQteActionT openQteActionT = new IOpenQteActionT();
			this.UnPackTo(openQteActionT);
			return openQteActionT;
		}

		// Token: 0x06033A0B RID: 211467 RVA: 0x006F59DC File Offset: 0x006F3BDC
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

		// Token: 0x06033A0C RID: 211468 RVA: 0x006F5A80 File Offset: 0x006F3C80
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

		// Token: 0x04012474 RID: 74868
		private Table __p;
	}
}
