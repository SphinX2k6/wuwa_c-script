using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200405B RID: 16475
	public struct IQuestStatisticsUseSkill : IFlatbufferObject
	{
		// Token: 0x170073FC RID: 29692
		// (get) Token: 0x06017E2A RID: 97834 RVA: 0x003725B0 File Offset: 0x003707B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017E2B RID: 97835 RVA: 0x003725BD File Offset: 0x003707BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017E2C RID: 97836 RVA: 0x003725C4 File Offset: 0x003707C4
		public static IQuestStatisticsUseSkill GetRootAsIQuestStatisticsUseSkill(ByteBuffer _bb)
		{
			return IQuestStatisticsUseSkill.GetRootAsIQuestStatisticsUseSkill(_bb, default(IQuestStatisticsUseSkill));
		}

		// Token: 0x06017E2D RID: 97837 RVA: 0x003725E0 File Offset: 0x003707E0
		public static IQuestStatisticsUseSkill GetRootAsIQuestStatisticsUseSkill(ByteBuffer _bb, IQuestStatisticsUseSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017E2E RID: 97838 RVA: 0x003725FD File Offset: 0x003707FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017E2F RID: 97839 RVA: 0x0037260C File Offset: 0x0037080C
		public IQuestStatisticsUseSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073FD RID: 29693
		// (get) Token: 0x06017E30 RID: 97840 RVA: 0x0037261C File Offset: 0x0037081C
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

		// Token: 0x170073FE RID: 29694
		// (get) Token: 0x06017E31 RID: 97841 RVA: 0x00372658 File Offset: 0x00370858
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

		// Token: 0x06017E32 RID: 97842 RVA: 0x00372694 File Offset: 0x00370894
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017E33 RID: 97843 RVA: 0x003726D8 File Offset: 0x003708D8
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06017E34 RID: 97844 RVA: 0x003726F4 File Offset: 0x003708F4
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06017E35 RID: 97845 RVA: 0x00372710 File Offset: 0x00370910
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06017E36 RID: 97846 RVA: 0x0037272C File Offset: 0x0037092C
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06017E37 RID: 97847 RVA: 0x00372748 File Offset: 0x00370948
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170073FF RID: 29695
		// (get) Token: 0x06017E38 RID: 97848 RVA: 0x00372764 File Offset: 0x00370964
		public int SkillId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007400 RID: 29696
		// (get) Token: 0x06017E39 RID: 97849 RVA: 0x003727A4 File Offset: 0x003709A4
		public bool IsWaitFinish
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007401 RID: 29697
		// (get) Token: 0x06017E3A RID: 97850 RVA: 0x003727E4 File Offset: 0x003709E4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017E3B RID: 97851 RVA: 0x00372821 File Offset: 0x00370A21
		public static Offset<IQuestStatisticsUseSkill> CreateIQuestStatisticsUseSkill(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, int SkillId = 0, bool IsWaitFinish = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IQuestStatisticsUseSkill.AddSkillId(builder, SkillId);
			IQuestStatisticsUseSkill.AddVar(builder, VarOffset);
			IQuestStatisticsUseSkill.AddNullMask(builder, NullMask);
			IQuestStatisticsUseSkill.AddIsWaitFinish(builder, IsWaitFinish);
			IQuestStatisticsUseSkill.AddVarType(builder, Var_type);
			IQuestStatisticsUseSkill.AddType(builder, Type);
			return IQuestStatisticsUseSkill.EndIQuestStatisticsUseSkill(builder);
		}

		// Token: 0x06017E3C RID: 97852 RVA: 0x0037285D File Offset: 0x00370A5D
		public static void StartIQuestStatisticsUseSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06017E3D RID: 97853 RVA: 0x00372866 File Offset: 0x00370A66
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017E3E RID: 97854 RVA: 0x00372871 File Offset: 0x00370A71
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06017E3F RID: 97855 RVA: 0x0037287C File Offset: 0x00370A7C
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06017E40 RID: 97856 RVA: 0x00372887 File Offset: 0x00370A87
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(3, skillId, 0);
		}

		// Token: 0x06017E41 RID: 97857 RVA: 0x00372892 File Offset: 0x00370A92
		public static void AddIsWaitFinish(FlatBufferBuilder builder, bool isWaitFinish)
		{
			builder.AddBool(4, isWaitFinish, false);
		}

		// Token: 0x06017E42 RID: 97858 RVA: 0x0037289D File Offset: 0x00370A9D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06017E43 RID: 97859 RVA: 0x003728A8 File Offset: 0x00370AA8
		public static Offset<IQuestStatisticsUseSkill> EndIQuestStatisticsUseSkill(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatisticsUseSkill>(builder.EndTable());
		}

		// Token: 0x06017E44 RID: 97860 RVA: 0x003728B8 File Offset: 0x00370AB8
		public IQuestStatisticsUseSkillT UnPack()
		{
			IQuestStatisticsUseSkillT questStatisticsUseSkillT = new IQuestStatisticsUseSkillT();
			this.UnPackTo(questStatisticsUseSkillT);
			return questStatisticsUseSkillT;
		}

		// Token: 0x06017E45 RID: 97861 RVA: 0x003728D4 File Offset: 0x00370AD4
		public void UnPackTo(IQuestStatisticsUseSkillT _o)
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
			_o.SkillId = this.SkillId;
			_o.IsWaitFinish = this.IsWaitFinish;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017E46 RID: 97862 RVA: 0x00372A74 File Offset: 0x00370C74
		public static Offset<IQuestStatisticsUseSkill> Pack(FlatBufferBuilder builder, IQuestStatisticsUseSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestStatisticsUseSkill>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IQuestStatisticsUseSkill.CreateIQuestStatisticsUseSkill(builder, _o.Type, var_type, varOffset, _o.SkillId, _o.IsWaitFinish, _o.NullMask);
		}

		// Token: 0x0400BBB3 RID: 48051
		private Table __p;
	}
}
