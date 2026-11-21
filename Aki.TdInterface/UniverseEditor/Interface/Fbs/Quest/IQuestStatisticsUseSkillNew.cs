using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200449F RID: 17567
	public struct IQuestStatisticsUseSkillNew : IFlatbufferObject
	{
		// Token: 0x17007A09 RID: 31241
		// (get) Token: 0x060194EC RID: 103660 RVA: 0x0039C9E8 File Offset: 0x0039ABE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060194ED RID: 103661 RVA: 0x0039C9F5 File Offset: 0x0039ABF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060194EE RID: 103662 RVA: 0x0039C9FC File Offset: 0x0039ABFC
		public static IQuestStatisticsUseSkillNew GetRootAsIQuestStatisticsUseSkillNew(ByteBuffer _bb)
		{
			return IQuestStatisticsUseSkillNew.GetRootAsIQuestStatisticsUseSkillNew(_bb, default(IQuestStatisticsUseSkillNew));
		}

		// Token: 0x060194EF RID: 103663 RVA: 0x0039CA18 File Offset: 0x0039AC18
		public static IQuestStatisticsUseSkillNew GetRootAsIQuestStatisticsUseSkillNew(ByteBuffer _bb, IQuestStatisticsUseSkillNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060194F0 RID: 103664 RVA: 0x0039CA35 File Offset: 0x0039AC35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060194F1 RID: 103665 RVA: 0x0039CA44 File Offset: 0x0039AC44
		public IQuestStatisticsUseSkillNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A0A RID: 31242
		// (get) Token: 0x060194F2 RID: 103666 RVA: 0x0039CA54 File Offset: 0x0039AC54
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

		// Token: 0x17007A0B RID: 31243
		// (get) Token: 0x060194F3 RID: 103667 RVA: 0x0039CA90 File Offset: 0x0039AC90
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

		// Token: 0x060194F4 RID: 103668 RVA: 0x0039CACC File Offset: 0x0039ACCC
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060194F5 RID: 103669 RVA: 0x0039CB10 File Offset: 0x0039AD10
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x060194F6 RID: 103670 RVA: 0x0039CB2C File Offset: 0x0039AD2C
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x060194F7 RID: 103671 RVA: 0x0039CB48 File Offset: 0x0039AD48
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x060194F8 RID: 103672 RVA: 0x0039CB64 File Offset: 0x0039AD64
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x060194F9 RID: 103673 RVA: 0x0039CB80 File Offset: 0x0039AD80
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x17007A0C RID: 31244
		// (get) Token: 0x060194FA RID: 103674 RVA: 0x0039CB9C File Offset: 0x0039AD9C
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

		// Token: 0x060194FB RID: 103675 RVA: 0x0039CBDC File Offset: 0x0039ADDC
		public TTable? SkillCheck<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060194FC RID: 103676 RVA: 0x0039CC24 File Offset: 0x0039AE24
		public IUseSkillCheckByFollowShooterSkillId SkillCheckAsIUseSkillCheckByFollowShooterSkillId()
		{
			return this.SkillCheck<IUseSkillCheckByFollowShooterSkillId>().Value;
		}

		// Token: 0x060194FD RID: 103677 RVA: 0x0039CC40 File Offset: 0x0039AE40
		public IUseSkillCheckBySkillGenre SkillCheckAsIUseSkillCheckBySkillGenre()
		{
			return this.SkillCheck<IUseSkillCheckBySkillGenre>().Value;
		}

		// Token: 0x060194FE RID: 103678 RVA: 0x0039CC5C File Offset: 0x0039AE5C
		public IUseSkillCheckBySkillId SkillCheckAsIUseSkillCheckBySkillId()
		{
			return this.SkillCheck<IUseSkillCheckBySkillId>().Value;
		}

		// Token: 0x060194FF RID: 103679 RVA: 0x0039CC78 File Offset: 0x0039AE78
		public IUseSkillCheckByVisionShowId SkillCheckAsIUseSkillCheckByVisionShowId()
		{
			return this.SkillCheck<IUseSkillCheckByVisionShowId>().Value;
		}

		// Token: 0x06019500 RID: 103680 RVA: 0x0039CC94 File Offset: 0x0039AE94
		public IUseSkillCheckByVisionSummonId SkillCheckAsIUseSkillCheckByVisionSummonId()
		{
			return this.SkillCheck<IUseSkillCheckByVisionSummonId>().Value;
		}

		// Token: 0x17007A0D RID: 31245
		// (get) Token: 0x06019501 RID: 103681 RVA: 0x0039CCB0 File Offset: 0x0039AEB0
		public bool IsWaitFinish
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007A0E RID: 31246
		// (get) Token: 0x06019502 RID: 103682 RVA: 0x0039CCF0 File Offset: 0x0039AEF0
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

		// Token: 0x06019503 RID: 103683 RVA: 0x0039CD30 File Offset: 0x0039AF30
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

		// Token: 0x06019504 RID: 103684 RVA: 0x0039CD7F File Offset: 0x0039AF7F
		public static void StartIQuestStatisticsUseSkillNew(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06019505 RID: 103685 RVA: 0x0039CD88 File Offset: 0x0039AF88
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019506 RID: 103686 RVA: 0x0039CD93 File Offset: 0x0039AF93
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06019507 RID: 103687 RVA: 0x0039CD9E File Offset: 0x0039AF9E
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06019508 RID: 103688 RVA: 0x0039CDA9 File Offset: 0x0039AFA9
		public static void AddSkillCheckType(FlatBufferBuilder builder, TUseSkillCheck skillCheckType)
		{
			builder.AddByte(3, (byte)skillCheckType, 0);
		}

		// Token: 0x06019509 RID: 103689 RVA: 0x0039CDB4 File Offset: 0x0039AFB4
		public static void AddSkillCheck(FlatBufferBuilder builder, int skillCheckOffset)
		{
			builder.AddOffset(4, skillCheckOffset, 0);
		}

		// Token: 0x0601950A RID: 103690 RVA: 0x0039CDBF File Offset: 0x0039AFBF
		public static void AddIsWaitFinish(FlatBufferBuilder builder, bool isWaitFinish)
		{
			builder.AddBool(5, isWaitFinish, false);
		}

		// Token: 0x0601950B RID: 103691 RVA: 0x0039CDCA File Offset: 0x0039AFCA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601950C RID: 103692 RVA: 0x0039CDD5 File Offset: 0x0039AFD5
		public static Offset<IQuestStatisticsUseSkillNew> EndIQuestStatisticsUseSkillNew(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatisticsUseSkillNew>(builder.EndTable());
		}

		// Token: 0x0601950D RID: 103693 RVA: 0x0039CDE4 File Offset: 0x0039AFE4
		public IQuestStatisticsUseSkillNewT UnPack()
		{
			IQuestStatisticsUseSkillNewT questStatisticsUseSkillNewT = new IQuestStatisticsUseSkillNewT();
			this.UnPackTo(questStatisticsUseSkillNewT);
			return questStatisticsUseSkillNewT;
		}

		// Token: 0x0601950E RID: 103694 RVA: 0x0039CE00 File Offset: 0x0039B000
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

		// Token: 0x0601950F RID: 103695 RVA: 0x0039D0F8 File Offset: 0x0039B2F8
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

		// Token: 0x0400C5A0 RID: 50592
		private Table __p;
	}
}
