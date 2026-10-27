using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004121 RID: 16673
	public struct IShowUiCondition : IFlatbufferObject
	{
		// Token: 0x1700760D RID: 30221
		// (get) Token: 0x0601869D RID: 99997 RVA: 0x00385509 File Offset: 0x00383709
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601869E RID: 99998 RVA: 0x00385516 File Offset: 0x00383716
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601869F RID: 99999 RVA: 0x00385520 File Offset: 0x00383720
		public static IShowUiCondition GetRootAsIShowUiCondition(ByteBuffer _bb)
		{
			return IShowUiCondition.GetRootAsIShowUiCondition(_bb, default(IShowUiCondition));
		}

		// Token: 0x060186A0 RID: 100000 RVA: 0x0038553C File Offset: 0x0038373C
		public static IShowUiCondition GetRootAsIShowUiCondition(ByteBuffer _bb, IShowUiCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060186A1 RID: 100001 RVA: 0x00385559 File Offset: 0x00383759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060186A2 RID: 100002 RVA: 0x00385568 File Offset: 0x00383768
		public IShowUiCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700760E RID: 30222
		// (get) Token: 0x060186A3 RID: 100003 RVA: 0x00385578 File Offset: 0x00383778
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700760F RID: 30223
		// (get) Token: 0x060186A4 RID: 100004 RVA: 0x003855B4 File Offset: 0x003837B4
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007610 RID: 30224
		// (get) Token: 0x060186A5 RID: 100005 RVA: 0x00385614 File Offset: 0x00383814
		public TShowUi UiTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TShowUi.NONE;
				}
				return (TShowUi)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060186A6 RID: 100006 RVA: 0x00385650 File Offset: 0x00383850
		public TTable? UiType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060186A7 RID: 100007 RVA: 0x00385698 File Offset: 0x00383898
		public ICiacconaAvgBoard UiTypeAsICiacconaAvgBoard()
		{
			return this.UiType<ICiacconaAvgBoard>().Value;
		}

		// Token: 0x060186A8 RID: 100008 RVA: 0x003856B4 File Offset: 0x003838B4
		public IInformationView UiTypeAsIInformationView()
		{
			return this.UiType<IInformationView>().Value;
		}

		// Token: 0x060186A9 RID: 100009 RVA: 0x003856D0 File Offset: 0x003838D0
		public IItemObtain UiTypeAsIItemObtain()
		{
			return this.UiType<IItemObtain>().Value;
		}

		// Token: 0x060186AA RID: 100010 RVA: 0x003856EC File Offset: 0x003838EC
		public IMowBuffDistribute UiTypeAsIMowBuffDistribute()
		{
			return this.UiType<IMowBuffDistribute>().Value;
		}

		// Token: 0x060186AB RID: 100011 RVA: 0x00385708 File Offset: 0x00383908
		public IPermanentRogueUi UiTypeAsIPermanentRogueUi()
		{
			return this.UiType<IPermanentRogueUi>().Value;
		}

		// Token: 0x060186AC RID: 100012 RVA: 0x00385724 File Offset: 0x00383924
		public IRogueAbilitySelect UiTypeAsIRogueAbilitySelect()
		{
			return this.UiType<IRogueAbilitySelect>().Value;
		}

		// Token: 0x060186AD RID: 100013 RVA: 0x00385740 File Offset: 0x00383940
		public IRogueRandomEvent UiTypeAsIRogueRandomEvent()
		{
			return this.UiType<IRogueRandomEvent>().Value;
		}

		// Token: 0x060186AE RID: 100014 RVA: 0x0038575C File Offset: 0x0038395C
		public IRoleSkinTrialActivities UiTypeAsIRoleSkinTrialActivities()
		{
			return this.UiType<IRoleSkinTrialActivities>().Value;
		}

		// Token: 0x060186AF RID: 100015 RVA: 0x00385778 File Offset: 0x00383978
		public IRoleTrialActivities UiTypeAsIRoleTrialActivities()
		{
			return this.UiType<IRoleTrialActivities>().Value;
		}

		// Token: 0x060186B0 RID: 100016 RVA: 0x00385794 File Offset: 0x00383994
		public IShowUiAll UiTypeAsIShowUiAll()
		{
			return this.UiType<IShowUiAll>().Value;
		}

		// Token: 0x060186B1 RID: 100017 RVA: 0x003857B0 File Offset: 0x003839B0
		public IShowUiCook UiTypeAsIShowUiCook()
		{
			return this.UiType<IShowUiCook>().Value;
		}

		// Token: 0x060186B2 RID: 100018 RVA: 0x003857CC File Offset: 0x003839CC
		public IShowUiForging UiTypeAsIShowUiForging()
		{
			return this.UiType<IShowUiForging>().Value;
		}

		// Token: 0x060186B3 RID: 100019 RVA: 0x003857E8 File Offset: 0x003839E8
		public IShowUiSynthetic UiTypeAsIShowUiSynthetic()
		{
			return this.UiType<IShowUiSynthetic>().Value;
		}

		// Token: 0x17007611 RID: 30225
		// (get) Token: 0x060186B4 RID: 100020 RVA: 0x00385804 File Offset: 0x00383A04
		public bool KeepUiOpen
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007612 RID: 30226
		// (get) Token: 0x060186B5 RID: 100021 RVA: 0x00385844 File Offset: 0x00383A44
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

		// Token: 0x060186B6 RID: 100022 RVA: 0x00385881 File Offset: 0x00383A81
		public static Offset<IShowUiCondition> CreateIShowUiCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TShowUi UiType_type = TShowUi.NONE, int UiTypeOffset = 0, bool KeepUiOpen = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IShowUiCondition.AddUiType(builder, UiTypeOffset);
			IShowUiCondition.AddPreConditions(builder, PreConditionsOffset);
			IShowUiCondition.AddNullMask(builder, NullMask);
			IShowUiCondition.AddKeepUiOpen(builder, KeepUiOpen);
			IShowUiCondition.AddUiTypeType(builder, UiType_type);
			IShowUiCondition.AddType(builder, Type);
			return IShowUiCondition.EndIShowUiCondition(builder);
		}

		// Token: 0x060186B7 RID: 100023 RVA: 0x003858BD File Offset: 0x00383ABD
		public static void StartIShowUiCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060186B8 RID: 100024 RVA: 0x003858C6 File Offset: 0x00383AC6
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060186B9 RID: 100025 RVA: 0x003858D1 File Offset: 0x00383AD1
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060186BA RID: 100026 RVA: 0x003858E1 File Offset: 0x00383AE1
		public static void AddUiTypeType(FlatBufferBuilder builder, TShowUi uiTypeType)
		{
			builder.AddByte(2, (byte)uiTypeType, 0);
		}

		// Token: 0x060186BB RID: 100027 RVA: 0x003858EC File Offset: 0x00383AEC
		public static void AddUiType(FlatBufferBuilder builder, int uiTypeOffset)
		{
			builder.AddOffset(3, uiTypeOffset, 0);
		}

		// Token: 0x060186BC RID: 100028 RVA: 0x003858F7 File Offset: 0x00383AF7
		public static void AddKeepUiOpen(FlatBufferBuilder builder, bool keepUiOpen)
		{
			builder.AddBool(4, keepUiOpen, false);
		}

		// Token: 0x060186BD RID: 100029 RVA: 0x00385902 File Offset: 0x00383B02
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060186BE RID: 100030 RVA: 0x0038590D File Offset: 0x00383B0D
		public static Offset<IShowUiCondition> EndIShowUiCondition(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiCondition>(builder.EndTable());
		}

		// Token: 0x060186BF RID: 100031 RVA: 0x0038591C File Offset: 0x00383B1C
		public IShowUiConditionT UnPack()
		{
			IShowUiConditionT showUiConditionT = new IShowUiConditionT();
			this.UnPackTo(showUiConditionT);
			return showUiConditionT;
		}

		// Token: 0x060186C0 RID: 100032 RVA: 0x00385938 File Offset: 0x00383B38
		public void UnPackTo(IShowUiConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.UiType = new TShowUiUnion();
			_o.UiType.Type = this.UiTypeType;
			switch (this.UiTypeType)
			{
			case TShowUi.ICiacconaAvgBoard:
				_o.UiType.Value = ((this.UiType<ICiacconaAvgBoard>() != null) ? this.UiType<ICiacconaAvgBoard>().Value.UnPack() : null);
				break;
			case TShowUi.IInformationView:
				_o.UiType.Value = ((this.UiType<IInformationView>() != null) ? this.UiType<IInformationView>().Value.UnPack() : null);
				break;
			case TShowUi.IItemObtain:
				_o.UiType.Value = ((this.UiType<IItemObtain>() != null) ? this.UiType<IItemObtain>().Value.UnPack() : null);
				break;
			case TShowUi.IMowBuffDistribute:
				_o.UiType.Value = ((this.UiType<IMowBuffDistribute>() != null) ? this.UiType<IMowBuffDistribute>().Value.UnPack() : null);
				break;
			case TShowUi.IPermanentRogueUi:
				_o.UiType.Value = ((this.UiType<IPermanentRogueUi>() != null) ? this.UiType<IPermanentRogueUi>().Value.UnPack() : null);
				break;
			case TShowUi.IRogueAbilitySelect:
				_o.UiType.Value = ((this.UiType<IRogueAbilitySelect>() != null) ? this.UiType<IRogueAbilitySelect>().Value.UnPack() : null);
				break;
			case TShowUi.IRogueRandomEvent:
				_o.UiType.Value = ((this.UiType<IRogueRandomEvent>() != null) ? this.UiType<IRogueRandomEvent>().Value.UnPack() : null);
				break;
			case TShowUi.IRoleSkinTrialActivities:
				_o.UiType.Value = ((this.UiType<IRoleSkinTrialActivities>() != null) ? this.UiType<IRoleSkinTrialActivities>().Value.UnPack() : null);
				break;
			case TShowUi.IRoleTrialActivities:
				_o.UiType.Value = ((this.UiType<IRoleTrialActivities>() != null) ? this.UiType<IRoleTrialActivities>().Value.UnPack() : null);
				break;
			case TShowUi.IShowUiAll:
				_o.UiType.Value = ((this.UiType<IShowUiAll>() != null) ? this.UiType<IShowUiAll>().Value.UnPack() : null);
				break;
			case TShowUi.IShowUiCook:
				_o.UiType.Value = ((this.UiType<IShowUiCook>() != null) ? this.UiType<IShowUiCook>().Value.UnPack() : null);
				break;
			case TShowUi.IShowUiForging:
				_o.UiType.Value = ((this.UiType<IShowUiForging>() != null) ? this.UiType<IShowUiForging>().Value.UnPack() : null);
				break;
			case TShowUi.IShowUiSynthetic:
				_o.UiType.Value = ((this.UiType<IShowUiSynthetic>() != null) ? this.UiType<IShowUiSynthetic>().Value.UnPack() : null);
				break;
			}
			_o.KeepUiOpen = this.KeepUiOpen;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060186C1 RID: 100033 RVA: 0x00385CFC File Offset: 0x00383EFC
		public static Offset<IShowUiCondition> Pack(FlatBufferBuilder builder, IShowUiConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowUiCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TShowUi uiType_type = (_o.UiType == null) ? TShowUi.NONE : _o.UiType.Type;
			int uiTypeOffset = (_o.UiType == null) ? 0 : TShowUiUnion.Pack(builder, _o.UiType);
			return IShowUiCondition.CreateIShowUiCondition(builder, _o.Type, preConditionsOffset, uiType_type, uiTypeOffset, _o.KeepUiOpen, _o.NullMask);
		}

		// Token: 0x0400BD0A RID: 48394
		private Table __p;
	}
}
