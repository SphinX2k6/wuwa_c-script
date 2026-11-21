using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004442 RID: 17474
	public struct IQuestPlayerHitStatistics : IFlatbufferObject
	{
		// Token: 0x17007927 RID: 31015
		// (get) Token: 0x060190D6 RID: 102614 RVA: 0x00392DBC File Offset: 0x00390FBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060190D7 RID: 102615 RVA: 0x00392DC9 File Offset: 0x00390FC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060190D8 RID: 102616 RVA: 0x00392DD0 File Offset: 0x00390FD0
		public static IQuestPlayerHitStatistics GetRootAsIQuestPlayerHitStatistics(ByteBuffer _bb)
		{
			return IQuestPlayerHitStatistics.GetRootAsIQuestPlayerHitStatistics(_bb, default(IQuestPlayerHitStatistics));
		}

		// Token: 0x060190D9 RID: 102617 RVA: 0x00392DEC File Offset: 0x00390FEC
		public static IQuestPlayerHitStatistics GetRootAsIQuestPlayerHitStatistics(ByteBuffer _bb, IQuestPlayerHitStatistics obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060190DA RID: 102618 RVA: 0x00392E09 File Offset: 0x00391009
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060190DB RID: 102619 RVA: 0x00392E18 File Offset: 0x00391018
		public IQuestPlayerHitStatistics __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007928 RID: 31016
		// (get) Token: 0x060190DC RID: 102620 RVA: 0x00392E28 File Offset: 0x00391028
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

		// Token: 0x17007929 RID: 31017
		// (get) Token: 0x060190DD RID: 102621 RVA: 0x00392E64 File Offset: 0x00391064
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

		// Token: 0x060190DE RID: 102622 RVA: 0x00392EA0 File Offset: 0x003910A0
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060190DF RID: 102623 RVA: 0x00392EE4 File Offset: 0x003910E4
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x060190E0 RID: 102624 RVA: 0x00392F00 File Offset: 0x00391100
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x060190E1 RID: 102625 RVA: 0x00392F1C File Offset: 0x0039111C
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x060190E2 RID: 102626 RVA: 0x00392F38 File Offset: 0x00391138
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x060190E3 RID: 102627 RVA: 0x00392F54 File Offset: 0x00391154
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x1700792A RID: 31018
		// (get) Token: 0x060190E4 RID: 102628 RVA: 0x00392F70 File Offset: 0x00391170
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

		// Token: 0x060190E5 RID: 102629 RVA: 0x00392FB0 File Offset: 0x003911B0
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060190E6 RID: 102630 RVA: 0x00392FF8 File Offset: 0x003911F8
		public IQuestPlayerBeDamage ConfigAsIQuestPlayerBeDamage()
		{
			return this.Config<IQuestPlayerBeDamage>().Value;
		}

		// Token: 0x060190E7 RID: 102631 RVA: 0x00393014 File Offset: 0x00391214
		public IQuestPlayerHitCount ConfigAsIQuestPlayerHitCount()
		{
			return this.Config<IQuestPlayerHitCount>().Value;
		}

		// Token: 0x060190E8 RID: 102632 RVA: 0x0039302F File Offset: 0x0039122F
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

		// Token: 0x060190E9 RID: 102633 RVA: 0x00393063 File Offset: 0x00391263
		public static void StartIQuestPlayerHitStatistics(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060190EA RID: 102634 RVA: 0x0039306C File Offset: 0x0039126C
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060190EB RID: 102635 RVA: 0x00393077 File Offset: 0x00391277
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x060190EC RID: 102636 RVA: 0x00393082 File Offset: 0x00391282
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x060190ED RID: 102637 RVA: 0x0039308D File Offset: 0x0039128D
		public static void AddConfigType(FlatBufferBuilder builder, TQuestPlayerHitStatistics configType)
		{
			builder.AddByte(3, (byte)configType, 0);
		}

		// Token: 0x060190EE RID: 102638 RVA: 0x00393098 File Offset: 0x00391298
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(4, configOffset, 0);
		}

		// Token: 0x060190EF RID: 102639 RVA: 0x003930A3 File Offset: 0x003912A3
		public static Offset<IQuestPlayerHitStatistics> EndIQuestPlayerHitStatistics(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPlayerHitStatistics>(builder.EndTable());
		}

		// Token: 0x060190F0 RID: 102640 RVA: 0x003930B0 File Offset: 0x003912B0
		public IQuestPlayerHitStatisticsT UnPack()
		{
			IQuestPlayerHitStatisticsT questPlayerHitStatisticsT = new IQuestPlayerHitStatisticsT();
			this.UnPackTo(questPlayerHitStatisticsT);
			return questPlayerHitStatisticsT;
		}

		// Token: 0x060190F1 RID: 102641 RVA: 0x003930CC File Offset: 0x003912CC
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

		// Token: 0x060190F2 RID: 102642 RVA: 0x003932E4 File Offset: 0x003914E4
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

		// Token: 0x0400C4FE RID: 50430
		private Table __p;
	}
}
