using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071EF RID: 29167
	public struct IModifyEntityDecoration : IFlatbufferObject
	{
		// Token: 0x1700D587 RID: 54663
		// (get) Token: 0x06032BDC RID: 207836 RVA: 0x006DABAF File Offset: 0x006D8DAF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032BDD RID: 207837 RVA: 0x006DABBC File Offset: 0x006D8DBC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032BDE RID: 207838 RVA: 0x006DABC4 File Offset: 0x006D8DC4
		public static IModifyEntityDecoration GetRootAsIModifyEntityDecoration(ByteBuffer _bb)
		{
			return IModifyEntityDecoration.GetRootAsIModifyEntityDecoration(_bb, default(IModifyEntityDecoration));
		}

		// Token: 0x06032BDF RID: 207839 RVA: 0x006DABE0 File Offset: 0x006D8DE0
		public static IModifyEntityDecoration GetRootAsIModifyEntityDecoration(ByteBuffer _bb, IModifyEntityDecoration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032BE0 RID: 207840 RVA: 0x006DABFD File Offset: 0x006D8DFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032BE1 RID: 207841 RVA: 0x006DAC0C File Offset: 0x006D8E0C
		public IModifyEntityDecoration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D588 RID: 54664
		// (get) Token: 0x06032BE2 RID: 207842 RVA: 0x006DAC1C File Offset: 0x006D8E1C
		public int EntityId
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

		// Token: 0x1700D589 RID: 54665
		// (get) Token: 0x06032BE3 RID: 207843 RVA: 0x006DAC58 File Offset: 0x006D8E58
		public TEntityDecorationConfig ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TEntityDecorationConfig.NONE;
				}
				return (TEntityDecorationConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032BE4 RID: 207844 RVA: 0x006DAC94 File Offset: 0x006D8E94
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032BE5 RID: 207845 RVA: 0x006DACD8 File Offset: 0x006D8ED8
		public IAddEntityDecoration ConfigAsIAddEntityDecoration()
		{
			return this.Config<IAddEntityDecoration>().Value;
		}

		// Token: 0x06032BE6 RID: 207846 RVA: 0x006DACF4 File Offset: 0x006D8EF4
		public IRemoveEntityDecoration ConfigAsIRemoveEntityDecoration()
		{
			return this.Config<IRemoveEntityDecoration>().Value;
		}

		// Token: 0x06032BE7 RID: 207847 RVA: 0x006DAD0F File Offset: 0x006D8F0F
		public static Offset<IModifyEntityDecoration> CreateIModifyEntityDecoration(FlatBufferBuilder builder, int EntityId = 0, TEntityDecorationConfig Config_type = TEntityDecorationConfig.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			IModifyEntityDecoration.AddConfig(builder, ConfigOffset);
			IModifyEntityDecoration.AddEntityId(builder, EntityId);
			IModifyEntityDecoration.AddConfigType(builder, Config_type);
			return IModifyEntityDecoration.EndIModifyEntityDecoration(builder);
		}

		// Token: 0x06032BE8 RID: 207848 RVA: 0x006DAD33 File Offset: 0x006D8F33
		public static void StartIModifyEntityDecoration(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032BE9 RID: 207849 RVA: 0x006DAD3C File Offset: 0x006D8F3C
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06032BEA RID: 207850 RVA: 0x006DAD47 File Offset: 0x006D8F47
		public static void AddConfigType(FlatBufferBuilder builder, TEntityDecorationConfig configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x06032BEB RID: 207851 RVA: 0x006DAD52 File Offset: 0x006D8F52
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x06032BEC RID: 207852 RVA: 0x006DAD5D File Offset: 0x006D8F5D
		public static Offset<IModifyEntityDecoration> EndIModifyEntityDecoration(FlatBufferBuilder builder)
		{
			return new Offset<IModifyEntityDecoration>(builder.EndTable());
		}

		// Token: 0x06032BED RID: 207853 RVA: 0x006DAD6C File Offset: 0x006D8F6C
		public IModifyEntityDecorationT UnPack()
		{
			IModifyEntityDecorationT modifyEntityDecorationT = new IModifyEntityDecorationT();
			this.UnPackTo(modifyEntityDecorationT);
			return modifyEntityDecorationT;
		}

		// Token: 0x06032BEE RID: 207854 RVA: 0x006DAD88 File Offset: 0x006D8F88
		public void UnPackTo(IModifyEntityDecorationT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Config = new TEntityDecorationConfigUnion();
			_o.Config.Type = this.ConfigType;
			TEntityDecorationConfig configType = this.ConfigType;
			if (configType == TEntityDecorationConfig.IAddEntityDecoration)
			{
				_o.Config.Value = ((this.Config<IAddEntityDecoration>() != null) ? this.Config<IAddEntityDecoration>().Value.UnPack() : null);
				return;
			}
			if (configType != TEntityDecorationConfig.IRemoveEntityDecoration)
			{
				return;
			}
			_o.Config.Value = ((this.Config<IRemoveEntityDecoration>() != null) ? this.Config<IRemoveEntityDecoration>().Value.UnPack() : null);
		}

		// Token: 0x06032BEF RID: 207855 RVA: 0x006DAE38 File Offset: 0x006D9038
		public static Offset<IModifyEntityDecoration> Pack(FlatBufferBuilder builder, IModifyEntityDecorationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyEntityDecoration>);
			}
			TEntityDecorationConfig config_type = (_o.Config == null) ? TEntityDecorationConfig.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TEntityDecorationConfigUnion.Pack(builder, _o.Config);
			return IModifyEntityDecoration.CreateIModifyEntityDecoration(builder, _o.EntityId, config_type, configOffset);
		}

		// Token: 0x0401220B RID: 74251
		private Table __p;
	}
}
