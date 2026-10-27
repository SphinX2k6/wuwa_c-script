using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004001 RID: 16385
	public struct IQuestPlayerHitStatistics : IFlatbufferObject
	{
		// Token: 0x17007325 RID: 29477
		// (get) Token: 0x06017A3D RID: 96829 RVA: 0x00368FC8 File Offset: 0x003671C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017A3E RID: 96830 RVA: 0x00368FD5 File Offset: 0x003671D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017A3F RID: 96831 RVA: 0x00368FDC File Offset: 0x003671DC
		public static IQuestPlayerHitStatistics GetRootAsIQuestPlayerHitStatistics(ByteBuffer _bb)
		{
			return IQuestPlayerHitStatistics.GetRootAsIQuestPlayerHitStatistics(_bb, default(IQuestPlayerHitStatistics));
		}

		// Token: 0x06017A40 RID: 96832 RVA: 0x00368FF8 File Offset: 0x003671F8
		public static IQuestPlayerHitStatistics GetRootAsIQuestPlayerHitStatistics(ByteBuffer _bb, IQuestPlayerHitStatistics obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017A41 RID: 96833 RVA: 0x00369015 File Offset: 0x00367215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017A42 RID: 96834 RVA: 0x00369024 File Offset: 0x00367224
		public IQuestPlayerHitStatistics __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007326 RID: 29478
		// (get) Token: 0x06017A43 RID: 96835 RVA: 0x00369034 File Offset: 0x00367234
		public EStatisticsEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStatisticsEventType.Collect;
				}
				return (EStatisticsEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007327 RID: 29479
		// (get) Token: 0x06017A44 RID: 96836 RVA: 0x00369070 File Offset: 0x00367270
		public TVarRef VarType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017A45 RID: 96837 RVA: 0x003690AC File Offset: 0x003672AC
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017A46 RID: 96838 RVA: 0x003690F0 File Offset: 0x003672F0
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06017A47 RID: 96839 RVA: 0x0036910C File Offset: 0x0036730C
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06017A48 RID: 96840 RVA: 0x00369128 File Offset: 0x00367328
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06017A49 RID: 96841 RVA: 0x00369144 File Offset: 0x00367344
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06017A4A RID: 96842 RVA: 0x00369160 File Offset: 0x00367360
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x17007328 RID: 29480
		// (get) Token: 0x06017A4B RID: 96843 RVA: 0x0036917C File Offset: 0x0036737C
		public TQuestPlayerHitStatistics ConfigType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TQuestPlayerHitStatistics.NONE;
				}
				return (TQuestPlayerHitStatistics)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017A4C RID: 96844 RVA: 0x003691BC File Offset: 0x003673BC
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017A4D RID: 96845 RVA: 0x00369204 File Offset: 0x00367404
		public IQuestPlayerBeDamage ConfigAsIQuestPlayerBeDamage()
		{
			return this.Config<IQuestPlayerBeDamage>().Value;
		}

		// Token: 0x06017A4E RID: 96846 RVA: 0x00369220 File Offset: 0x00367420
		public IQuestPlayerHitCount ConfigAsIQuestPlayerHitCount()
		{
			return this.Config<IQuestPlayerHitCount>().Value;
		}

		// Token: 0x06017A4F RID: 96847 RVA: 0x0036923B File Offset: 0x0036743B
		public static Offset<IQuestPlayerHitStatistics> CreateIQuestPlayerHitStatistics(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, TQuestPlayerHitStatistics Config_type = TQuestPlayerHitStatistics.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(5);
			IQuestPlayerHitStatistics.AddConfig(builder, ConfigOffset);
			IQuestPlayerHitStatistics.AddVar(builder, VarOffset);
			IQuestPlayerHitStatistics.AddConfigType(builder, Config_type);
			IQuestPlayerHitStatistics.AddVarType(builder, Var_type);
			IQuestPlayerHitStatistics.AddType(builder, Type);
			return IQuestPlayerHitStatistics.EndIQuestPlayerHitStatistics(builder);
		}

		// Token: 0x06017A50 RID: 96848 RVA: 0x0036926F File Offset: 0x0036746F
		public static void StartIQuestPlayerHitStatistics(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017A51 RID: 96849 RVA: 0x00369278 File Offset: 0x00367478
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017A52 RID: 96850 RVA: 0x00369283 File Offset: 0x00367483
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06017A53 RID: 96851 RVA: 0x0036928E File Offset: 0x0036748E
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06017A54 RID: 96852 RVA: 0x00369299 File Offset: 0x00367499
		public static void AddConfigType(FlatBufferBuilder builder, TQuestPlayerHitStatistics configType)
		{
			builder.AddByte(3, (byte)configType, 0);
		}

		// Token: 0x06017A55 RID: 96853 RVA: 0x003692A4 File Offset: 0x003674A4
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(4, configOffset, 0);
		}

		// Token: 0x06017A56 RID: 96854 RVA: 0x003692AF File Offset: 0x003674AF
		public static Offset<IQuestPlayerHitStatistics> EndIQuestPlayerHitStatistics(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPlayerHitStatistics>(builder.EndTable());
		}

		// Token: 0x06017A57 RID: 96855 RVA: 0x003692BC File Offset: 0x003674BC
		public IQuestPlayerHitStatisticsT UnPack()
		{
			IQuestPlayerHitStatisticsT questPlayerHitStatisticsT = new IQuestPlayerHitStatisticsT();
			this.UnPackTo(questPlayerHitStatisticsT);
			return questPlayerHitStatisticsT;
		}

		// Token: 0x06017A58 RID: 96856 RVA: 0x003692D8 File Offset: 0x003674D8
		public void UnPackTo(IQuestPlayerHitStatisticsT _o)
		{
			_o.Type = this.Type;
			_o.Var = new TVarRefUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TVarRef.IConstVarRef:
				_o.Var.Value = ((this.Var<IConstVarRef>() != null) ? this.Var<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Var.Value = ((this.Var<IGlobalVarRef>() != null) ? this.Var<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Var.Value = ((this.Var<IOtherVarRef>() != null) ? this.Var<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Var.Value = ((this.Var<ISelfVarRef>() != null) ? this.Var<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Var.Value = ((this.Var<ISystemVarRef>() != null) ? this.Var<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.Config = new TQuestPlayerHitStatisticsUnion();
			_o.Config.Type = this.ConfigType;
			TQuestPlayerHitStatistics configType = this.ConfigType;
			if (configType == TQuestPlayerHitStatistics.IQuestPlayerBeDamage)
			{
				_o.Config.Value = ((this.Config<IQuestPlayerBeDamage>() != null) ? this.Config<IQuestPlayerBeDamage>().Value.UnPack() : null);
				return;
			}
			if (configType != TQuestPlayerHitStatistics.IQuestPlayerHitCount)
			{
				return;
			}
			_o.Config.Value = ((this.Config<IQuestPlayerHitCount>() != null) ? this.Config<IQuestPlayerHitCount>().Value.UnPack() : null);
		}

		// Token: 0x06017A59 RID: 96857 RVA: 0x003694F0 File Offset: 0x003676F0
		public static Offset<IQuestPlayerHitStatistics> Pack(FlatBufferBuilder builder, IQuestPlayerHitStatisticsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestPlayerHitStatistics>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			TQuestPlayerHitStatistics config_type = (_o.Config == null) ? TQuestPlayerHitStatistics.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TQuestPlayerHitStatisticsUnion.Pack(builder, _o.Config);
			return IQuestPlayerHitStatistics.CreateIQuestPlayerHitStatistics(builder, _o.Type, var_type, varOffset, config_type, configOffset);
		}

		// Token: 0x0400BB17 RID: 47895
		private Table __p;
	}
}
