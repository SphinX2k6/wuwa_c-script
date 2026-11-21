using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200449C RID: 17564
	public struct IQuestStatisticsUseSkill : IFlatbufferObject
	{
		// Token: 0x170079FE RID: 31230
		// (get) Token: 0x060194C3 RID: 103619 RVA: 0x0039C3A4 File Offset: 0x0039A5A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060194C4 RID: 103620 RVA: 0x0039C3B1 File Offset: 0x0039A5B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060194C5 RID: 103621 RVA: 0x0039C3B8 File Offset: 0x0039A5B8
		public static IQuestStatisticsUseSkill GetRootAsIQuestStatisticsUseSkill(ByteBuffer _bb)
		{
			return IQuestStatisticsUseSkill.GetRootAsIQuestStatisticsUseSkill(_bb, default(IQuestStatisticsUseSkill));
		}

		// Token: 0x060194C6 RID: 103622 RVA: 0x0039C3D4 File Offset: 0x0039A5D4
		public static IQuestStatisticsUseSkill GetRootAsIQuestStatisticsUseSkill(ByteBuffer _bb, IQuestStatisticsUseSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060194C7 RID: 103623 RVA: 0x0039C3F1 File Offset: 0x0039A5F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060194C8 RID: 103624 RVA: 0x0039C400 File Offset: 0x0039A600
		public IQuestStatisticsUseSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079FF RID: 31231
		// (get) Token: 0x060194C9 RID: 103625 RVA: 0x0039C410 File Offset: 0x0039A610
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

		// Token: 0x17007A00 RID: 31232
		// (get) Token: 0x060194CA RID: 103626 RVA: 0x0039C44C File Offset: 0x0039A64C
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

		// Token: 0x060194CB RID: 103627 RVA: 0x0039C488 File Offset: 0x0039A688
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060194CC RID: 103628 RVA: 0x0039C4CC File Offset: 0x0039A6CC
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x060194CD RID: 103629 RVA: 0x0039C4E8 File Offset: 0x0039A6E8
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x060194CE RID: 103630 RVA: 0x0039C504 File Offset: 0x0039A704
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x060194CF RID: 103631 RVA: 0x0039C520 File Offset: 0x0039A720
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x060194D0 RID: 103632 RVA: 0x0039C53C File Offset: 0x0039A73C
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x17007A01 RID: 31233
		// (get) Token: 0x060194D1 RID: 103633 RVA: 0x0039C558 File Offset: 0x0039A758
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

		// Token: 0x17007A02 RID: 31234
		// (get) Token: 0x060194D2 RID: 103634 RVA: 0x0039C598 File Offset: 0x0039A798
		public bool IsWaitFinish
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007A03 RID: 31235
		// (get) Token: 0x060194D3 RID: 103635 RVA: 0x0039C5D8 File Offset: 0x0039A7D8
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

		// Token: 0x060194D4 RID: 103636 RVA: 0x0039C615 File Offset: 0x0039A815
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

		// Token: 0x060194D5 RID: 103637 RVA: 0x0039C651 File Offset: 0x0039A851
		public static void StartIQuestStatisticsUseSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060194D6 RID: 103638 RVA: 0x0039C65A File Offset: 0x0039A85A
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060194D7 RID: 103639 RVA: 0x0039C665 File Offset: 0x0039A865
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x060194D8 RID: 103640 RVA: 0x0039C670 File Offset: 0x0039A870
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x060194D9 RID: 103641 RVA: 0x0039C67B File Offset: 0x0039A87B
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(3, skillId, 0);
		}

		// Token: 0x060194DA RID: 103642 RVA: 0x0039C686 File Offset: 0x0039A886
		public static void AddIsWaitFinish(FlatBufferBuilder builder, bool isWaitFinish)
		{
			builder.AddBool(4, isWaitFinish, false);
		}

		// Token: 0x060194DB RID: 103643 RVA: 0x0039C691 File Offset: 0x0039A891
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060194DC RID: 103644 RVA: 0x0039C69C File Offset: 0x0039A89C
		public static Offset<IQuestStatisticsUseSkill> EndIQuestStatisticsUseSkill(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatisticsUseSkill>(builder.EndTable());
		}

		// Token: 0x060194DD RID: 103645 RVA: 0x0039C6AC File Offset: 0x0039A8AC
		public IQuestStatisticsUseSkillT UnPack()
		{
			IQuestStatisticsUseSkillT questStatisticsUseSkillT = new IQuestStatisticsUseSkillT();
			this.UnPackTo(questStatisticsUseSkillT);
			return questStatisticsUseSkillT;
		}

		// Token: 0x060194DE RID: 103646 RVA: 0x0039C6C8 File Offset: 0x0039A8C8
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

		// Token: 0x060194DF RID: 103647 RVA: 0x0039C868 File Offset: 0x0039AA68
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

		// Token: 0x0400C59A RID: 50586
		private Table __p;
	}
}
