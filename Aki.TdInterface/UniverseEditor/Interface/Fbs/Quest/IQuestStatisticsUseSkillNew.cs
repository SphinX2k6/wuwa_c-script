using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200405E RID: 16478
	public struct IQuestStatisticsUseSkillNew : IFlatbufferObject
	{
		// Token: 0x17007407 RID: 29703
		// (get) Token: 0x06017E53 RID: 97875 RVA: 0x00372BF4 File Offset: 0x00370DF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017E54 RID: 97876 RVA: 0x00372C01 File Offset: 0x00370E01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017E55 RID: 97877 RVA: 0x00372C08 File Offset: 0x00370E08
		public static IQuestStatisticsUseSkillNew GetRootAsIQuestStatisticsUseSkillNew(ByteBuffer _bb)
		{
			return IQuestStatisticsUseSkillNew.GetRootAsIQuestStatisticsUseSkillNew(_bb, default(IQuestStatisticsUseSkillNew));
		}

		// Token: 0x06017E56 RID: 97878 RVA: 0x00372C24 File Offset: 0x00370E24
		public static IQuestStatisticsUseSkillNew GetRootAsIQuestStatisticsUseSkillNew(ByteBuffer _bb, IQuestStatisticsUseSkillNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017E57 RID: 97879 RVA: 0x00372C41 File Offset: 0x00370E41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017E58 RID: 97880 RVA: 0x00372C50 File Offset: 0x00370E50
		public IQuestStatisticsUseSkillNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007408 RID: 29704
		// (get) Token: 0x06017E59 RID: 97881 RVA: 0x00372C60 File Offset: 0x00370E60
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

		// Token: 0x17007409 RID: 29705
		// (get) Token: 0x06017E5A RID: 97882 RVA: 0x00372C9C File Offset: 0x00370E9C
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

		// Token: 0x06017E5B RID: 97883 RVA: 0x00372CD8 File Offset: 0x00370ED8
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017E5C RID: 97884 RVA: 0x00372D1C File Offset: 0x00370F1C
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06017E5D RID: 97885 RVA: 0x00372D38 File Offset: 0x00370F38
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06017E5E RID: 97886 RVA: 0x00372D54 File Offset: 0x00370F54
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06017E5F RID: 97887 RVA: 0x00372D70 File Offset: 0x00370F70
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06017E60 RID: 97888 RVA: 0x00372D8C File Offset: 0x00370F8C
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x1700740A RID: 29706
		// (get) Token: 0x06017E61 RID: 97889 RVA: 0x00372DA8 File Offset: 0x00370FA8
		public TUseSkillCheck SkillCheckType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TUseSkillCheck.NONE;
				}
				return (TUseSkillCheck)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017E62 RID: 97890 RVA: 0x00372DE8 File Offset: 0x00370FE8
		public TTable? SkillCheck<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017E63 RID: 97891 RVA: 0x00372E30 File Offset: 0x00371030
		public IUseSkillCheckByFollowShooterSkillId SkillCheckAsIUseSkillCheckByFollowShooterSkillId()
		{
			return this.SkillCheck<IUseSkillCheckByFollowShooterSkillId>().Value;
		}

		// Token: 0x06017E64 RID: 97892 RVA: 0x00372E4C File Offset: 0x0037104C
		public IUseSkillCheckBySkillGenre SkillCheckAsIUseSkillCheckBySkillGenre()
		{
			return this.SkillCheck<IUseSkillCheckBySkillGenre>().Value;
		}

		// Token: 0x06017E65 RID: 97893 RVA: 0x00372E68 File Offset: 0x00371068
		public IUseSkillCheckBySkillId SkillCheckAsIUseSkillCheckBySkillId()
		{
			return this.SkillCheck<IUseSkillCheckBySkillId>().Value;
		}

		// Token: 0x06017E66 RID: 97894 RVA: 0x00372E84 File Offset: 0x00371084
		public IUseSkillCheckByVisionShowId SkillCheckAsIUseSkillCheckByVisionShowId()
		{
			return this.SkillCheck<IUseSkillCheckByVisionShowId>().Value;
		}

		// Token: 0x06017E67 RID: 97895 RVA: 0x00372EA0 File Offset: 0x003710A0
		public IUseSkillCheckByVisionSummonId SkillCheckAsIUseSkillCheckByVisionSummonId()
		{
			return this.SkillCheck<IUseSkillCheckByVisionSummonId>().Value;
		}

		// Token: 0x1700740B RID: 29707
		// (get) Token: 0x06017E68 RID: 97896 RVA: 0x00372EBC File Offset: 0x003710BC
		public bool IsWaitFinish
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700740C RID: 29708
		// (get) Token: 0x06017E69 RID: 97897 RVA: 0x00372EFC File Offset: 0x003710FC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017E6A RID: 97898 RVA: 0x00372F3C File Offset: 0x0037113C
		public static Offset<IQuestStatisticsUseSkillNew> CreateIQuestStatisticsUseSkillNew(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, TUseSkillCheck SkillCheck_type = TUseSkillCheck.NONE, int SkillCheckOffset = 0, bool IsWaitFinish = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IQuestStatisticsUseSkillNew.AddSkillCheck(builder, SkillCheckOffset);
			IQuestStatisticsUseSkillNew.AddVar(builder, VarOffset);
			IQuestStatisticsUseSkillNew.AddNullMask(builder, NullMask);
			IQuestStatisticsUseSkillNew.AddIsWaitFinish(builder, IsWaitFinish);
			IQuestStatisticsUseSkillNew.AddSkillCheckType(builder, SkillCheck_type);
			IQuestStatisticsUseSkillNew.AddVarType(builder, Var_type);
			IQuestStatisticsUseSkillNew.AddType(builder, Type);
			return IQuestStatisticsUseSkillNew.EndIQuestStatisticsUseSkillNew(builder);
		}

		// Token: 0x06017E6B RID: 97899 RVA: 0x00372F8B File Offset: 0x0037118B
		public static void StartIQuestStatisticsUseSkillNew(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06017E6C RID: 97900 RVA: 0x00372F94 File Offset: 0x00371194
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017E6D RID: 97901 RVA: 0x00372F9F File Offset: 0x0037119F
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06017E6E RID: 97902 RVA: 0x00372FAA File Offset: 0x003711AA
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06017E6F RID: 97903 RVA: 0x00372FB5 File Offset: 0x003711B5
		public static void AddSkillCheckType(FlatBufferBuilder builder, TUseSkillCheck skillCheckType)
		{
			builder.AddByte(3, (byte)skillCheckType, 0);
		}

		// Token: 0x06017E70 RID: 97904 RVA: 0x00372FC0 File Offset: 0x003711C0
		public static void AddSkillCheck(FlatBufferBuilder builder, int skillCheckOffset)
		{
			builder.AddOffset(4, skillCheckOffset, 0);
		}

		// Token: 0x06017E71 RID: 97905 RVA: 0x00372FCB File Offset: 0x003711CB
		public static void AddIsWaitFinish(FlatBufferBuilder builder, bool isWaitFinish)
		{
			builder.AddBool(5, isWaitFinish, false);
		}

		// Token: 0x06017E72 RID: 97906 RVA: 0x00372FD6 File Offset: 0x003711D6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06017E73 RID: 97907 RVA: 0x00372FE1 File Offset: 0x003711E1
		public static Offset<IQuestStatisticsUseSkillNew> EndIQuestStatisticsUseSkillNew(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatisticsUseSkillNew>(builder.EndTable());
		}

		// Token: 0x06017E74 RID: 97908 RVA: 0x00372FF0 File Offset: 0x003711F0
		public IQuestStatisticsUseSkillNewT UnPack()
		{
			IQuestStatisticsUseSkillNewT questStatisticsUseSkillNewT = new IQuestStatisticsUseSkillNewT();
			this.UnPackTo(questStatisticsUseSkillNewT);
			return questStatisticsUseSkillNewT;
		}

		// Token: 0x06017E75 RID: 97909 RVA: 0x0037300C File Offset: 0x0037120C
		public void UnPackTo(IQuestStatisticsUseSkillNewT _o)
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
			_o.SkillCheck = new TUseSkillCheckUnion();
			_o.SkillCheck.Type = this.SkillCheckType;
			switch (this.SkillCheckType)
			{
			case TUseSkillCheck.IUseSkillCheckByFollowShooterSkillId:
				_o.SkillCheck.Value = ((this.SkillCheck<IUseSkillCheckByFollowShooterSkillId>() != null) ? this.SkillCheck<IUseSkillCheckByFollowShooterSkillId>().Value.UnPack() : null);
				break;
			case TUseSkillCheck.IUseSkillCheckBySkillGenre:
				_o.SkillCheck.Value = ((this.SkillCheck<IUseSkillCheckBySkillGenre>() != null) ? this.SkillCheck<IUseSkillCheckBySkillGenre>().Value.UnPack() : null);
				break;
			case TUseSkillCheck.IUseSkillCheckBySkillId:
				_o.SkillCheck.Value = ((this.SkillCheck<IUseSkillCheckBySkillId>() != null) ? this.SkillCheck<IUseSkillCheckBySkillId>().Value.UnPack() : null);
				break;
			case TUseSkillCheck.IUseSkillCheckByVisionShowId:
				_o.SkillCheck.Value = ((this.SkillCheck<IUseSkillCheckByVisionShowId>() != null) ? this.SkillCheck<IUseSkillCheckByVisionShowId>().Value.UnPack() : null);
				break;
			case TUseSkillCheck.IUseSkillCheckByVisionSummonId:
				_o.SkillCheck.Value = ((this.SkillCheck<IUseSkillCheckByVisionSummonId>() != null) ? this.SkillCheck<IUseSkillCheckByVisionSummonId>().Value.UnPack() : null);
				break;
			}
			_o.IsWaitFinish = this.IsWaitFinish;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017E76 RID: 97910 RVA: 0x00373304 File Offset: 0x00371504
		public static Offset<IQuestStatisticsUseSkillNew> Pack(FlatBufferBuilder builder, IQuestStatisticsUseSkillNewT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestStatisticsUseSkillNew>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			TUseSkillCheck skillCheck_type = (_o.SkillCheck == null) ? TUseSkillCheck.NONE : _o.SkillCheck.Type;
			int skillCheckOffset = (_o.SkillCheck == null) ? 0 : TUseSkillCheckUnion.Pack(builder, _o.SkillCheck);
			return IQuestStatisticsUseSkillNew.CreateIQuestStatisticsUseSkillNew(builder, _o.Type, var_type, varOffset, skillCheck_type, skillCheckOffset, _o.IsWaitFinish, _o.NullMask);
		}

		// Token: 0x0400BBB9 RID: 48057
		private Table __p;
	}
}
