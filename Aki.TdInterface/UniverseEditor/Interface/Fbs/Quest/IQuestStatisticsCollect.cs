using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200404F RID: 16463
	public struct IQuestStatisticsCollect : IFlatbufferObject
	{
		// Token: 0x170073E1 RID: 29665
		// (get) Token: 0x06017D9D RID: 97693 RVA: 0x00370FC2 File Offset: 0x0036F1C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017D9E RID: 97694 RVA: 0x00370FCF File Offset: 0x0036F1CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017D9F RID: 97695 RVA: 0x00370FD8 File Offset: 0x0036F1D8
		public static IQuestStatisticsCollect GetRootAsIQuestStatisticsCollect(ByteBuffer _bb)
		{
			return IQuestStatisticsCollect.GetRootAsIQuestStatisticsCollect(_bb, default(IQuestStatisticsCollect));
		}

		// Token: 0x06017DA0 RID: 97696 RVA: 0x00370FF4 File Offset: 0x0036F1F4
		public static IQuestStatisticsCollect GetRootAsIQuestStatisticsCollect(ByteBuffer _bb, IQuestStatisticsCollect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017DA1 RID: 97697 RVA: 0x00371011 File Offset: 0x0036F211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017DA2 RID: 97698 RVA: 0x00371020 File Offset: 0x0036F220
		public IQuestStatisticsCollect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073E2 RID: 29666
		// (get) Token: 0x06017DA3 RID: 97699 RVA: 0x00371030 File Offset: 0x0036F230
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

		// Token: 0x170073E3 RID: 29667
		// (get) Token: 0x06017DA4 RID: 97700 RVA: 0x0037106C File Offset: 0x0036F26C
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

		// Token: 0x06017DA5 RID: 97701 RVA: 0x003710A8 File Offset: 0x0036F2A8
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017DA6 RID: 97702 RVA: 0x003710EC File Offset: 0x0036F2EC
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06017DA7 RID: 97703 RVA: 0x00371108 File Offset: 0x0036F308
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06017DA8 RID: 97704 RVA: 0x00371124 File Offset: 0x0036F324
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06017DA9 RID: 97705 RVA: 0x00371140 File Offset: 0x0036F340
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06017DAA RID: 97706 RVA: 0x0037115C File Offset: 0x0036F35C
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170073E4 RID: 29668
		// (get) Token: 0x06017DAB RID: 97707 RVA: 0x00371178 File Offset: 0x0036F378
		public IStaticEntitiyMatch? EntitiyMatch
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IStaticEntitiyMatch?(default(IStaticEntitiyMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170073E5 RID: 29669
		// (get) Token: 0x06017DAC RID: 97708 RVA: 0x003711D8 File Offset: 0x0036F3D8
		public bool IsGlobal
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170073E6 RID: 29670
		// (get) Token: 0x06017DAD RID: 97709 RVA: 0x00371218 File Offset: 0x0036F418
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017DAE RID: 97710 RVA: 0x00371258 File Offset: 0x0036F458
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017DAF RID: 97711 RVA: 0x003712A0 File Offset: 0x0036F4A0
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x06017DB0 RID: 97712 RVA: 0x003712BC File Offset: 0x0036F4BC
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x170073E7 RID: 29671
		// (get) Token: 0x06017DB1 RID: 97713 RVA: 0x003712D8 File Offset: 0x0036F4D8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017DB2 RID: 97714 RVA: 0x00371318 File Offset: 0x0036F518
		public static Offset<IQuestStatisticsCollect> CreateIQuestStatisticsCollect(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, Offset<IStaticEntitiyMatch> EntitiyMatchOffset = default(Offset<IStaticEntitiyMatch>), bool IsGlobal = false, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(8);
			IQuestStatisticsCollect.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			IQuestStatisticsCollect.AddEntitiyMatch(builder, EntitiyMatchOffset);
			IQuestStatisticsCollect.AddVar(builder, VarOffset);
			IQuestStatisticsCollect.AddNullMask(builder, NullMask);
			IQuestStatisticsCollect.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			IQuestStatisticsCollect.AddIsGlobal(builder, IsGlobal);
			IQuestStatisticsCollect.AddVarType(builder, Var_type);
			IQuestStatisticsCollect.AddType(builder, Type);
			return IQuestStatisticsCollect.EndIQuestStatisticsCollect(builder);
		}

		// Token: 0x06017DB3 RID: 97715 RVA: 0x0037136F File Offset: 0x0036F56F
		public static void StartIQuestStatisticsCollect(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06017DB4 RID: 97716 RVA: 0x00371378 File Offset: 0x0036F578
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017DB5 RID: 97717 RVA: 0x00371383 File Offset: 0x0036F583
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06017DB6 RID: 97718 RVA: 0x0037138E File Offset: 0x0036F58E
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06017DB7 RID: 97719 RVA: 0x00371399 File Offset: 0x0036F599
		public static void AddEntitiyMatch(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> entitiyMatchOffset)
		{
			builder.AddOffset(3, entitiyMatchOffset.Value, 0);
		}

		// Token: 0x06017DB8 RID: 97720 RVA: 0x003713A9 File Offset: 0x0036F5A9
		public static void AddIsGlobal(FlatBufferBuilder builder, bool isGlobal)
		{
			builder.AddBool(4, isGlobal, false);
		}

		// Token: 0x06017DB9 RID: 97721 RVA: 0x003713B4 File Offset: 0x0036F5B4
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(5, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x06017DBA RID: 97722 RVA: 0x003713BF File Offset: 0x0036F5BF
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(6, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x06017DBB RID: 97723 RVA: 0x003713CA File Offset: 0x0036F5CA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06017DBC RID: 97724 RVA: 0x003713D5 File Offset: 0x0036F5D5
		public static Offset<IQuestStatisticsCollect> EndIQuestStatisticsCollect(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatisticsCollect>(builder.EndTable());
		}

		// Token: 0x06017DBD RID: 97725 RVA: 0x003713E4 File Offset: 0x0036F5E4
		public IQuestStatisticsCollectT UnPack()
		{
			IQuestStatisticsCollectT questStatisticsCollectT = new IQuestStatisticsCollectT();
			this.UnPackTo(questStatisticsCollectT);
			return questStatisticsCollectT;
		}

		// Token: 0x06017DBE RID: 97726 RVA: 0x00371400 File Offset: 0x0036F600
		public void UnPackTo(IQuestStatisticsCollectT _o)
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
			_o.EntitiyMatch = ((this.EntitiyMatch != null) ? this.EntitiyMatch.Value.UnPack() : null);
			_o.IsGlobal = this.IsGlobal;
			_o.OnlinePlayerConditionTargetOption = new TOnlinePlayerConditionTargetUnion();
			_o.OnlinePlayerConditionTargetOption.Type = this.OnlinePlayerConditionTargetOptionType;
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType = this.OnlinePlayerConditionTargetOptionType;
			if (onlinePlayerConditionTargetOptionType != TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost)
			{
				if (onlinePlayerConditionTargetOptionType == TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator)
				{
					_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017DBF RID: 97727 RVA: 0x00371664 File Offset: 0x0036F864
		public static Offset<IQuestStatisticsCollect> Pack(FlatBufferBuilder builder, IQuestStatisticsCollectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestStatisticsCollect>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			Offset<IStaticEntitiyMatch> entitiyMatchOffset = (_o.EntitiyMatch == null) ? default(Offset<IStaticEntitiyMatch>) : IStaticEntitiyMatch.Pack(builder, _o.EntitiyMatch);
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return IQuestStatisticsCollect.CreateIQuestStatisticsCollect(builder, _o.Type, var_type, varOffset, entitiyMatchOffset, _o.IsGlobal, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset, _o.NullMask);
		}

		// Token: 0x0400BB96 RID: 48022
		private Table __p;
	}
}
