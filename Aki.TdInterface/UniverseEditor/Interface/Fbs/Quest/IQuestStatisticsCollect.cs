using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004490 RID: 17552
	public struct IQuestStatisticsCollect : IFlatbufferObject
	{
		// Token: 0x170079E3 RID: 31203
		// (get) Token: 0x06019436 RID: 103478 RVA: 0x0039ADB6 File Offset: 0x00398FB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019437 RID: 103479 RVA: 0x0039ADC3 File Offset: 0x00398FC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019438 RID: 103480 RVA: 0x0039ADCC File Offset: 0x00398FCC
		public static IQuestStatisticsCollect GetRootAsIQuestStatisticsCollect(ByteBuffer _bb)
		{
			return IQuestStatisticsCollect.GetRootAsIQuestStatisticsCollect(_bb, default(IQuestStatisticsCollect));
		}

		// Token: 0x06019439 RID: 103481 RVA: 0x0039ADE8 File Offset: 0x00398FE8
		public static IQuestStatisticsCollect GetRootAsIQuestStatisticsCollect(ByteBuffer _bb, IQuestStatisticsCollect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601943A RID: 103482 RVA: 0x0039AE05 File Offset: 0x00399005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601943B RID: 103483 RVA: 0x0039AE14 File Offset: 0x00399014
		public IQuestStatisticsCollect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079E4 RID: 31204
		// (get) Token: 0x0601943C RID: 103484 RVA: 0x0039AE24 File Offset: 0x00399024
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

		// Token: 0x170079E5 RID: 31205
		// (get) Token: 0x0601943D RID: 103485 RVA: 0x0039AE60 File Offset: 0x00399060
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

		// Token: 0x0601943E RID: 103486 RVA: 0x0039AE9C File Offset: 0x0039909C
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601943F RID: 103487 RVA: 0x0039AEE0 File Offset: 0x003990E0
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06019440 RID: 103488 RVA: 0x0039AEFC File Offset: 0x003990FC
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06019441 RID: 103489 RVA: 0x0039AF18 File Offset: 0x00399118
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06019442 RID: 103490 RVA: 0x0039AF34 File Offset: 0x00399134
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06019443 RID: 103491 RVA: 0x0039AF50 File Offset: 0x00399150
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170079E6 RID: 31206
		// (get) Token: 0x06019444 RID: 103492 RVA: 0x0039AF6C File Offset: 0x0039916C
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

		// Token: 0x170079E7 RID: 31207
		// (get) Token: 0x06019445 RID: 103493 RVA: 0x0039AFCC File Offset: 0x003991CC
		public bool IsGlobal
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170079E8 RID: 31208
		// (get) Token: 0x06019446 RID: 103494 RVA: 0x0039B00C File Offset: 0x0039920C
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

		// Token: 0x06019447 RID: 103495 RVA: 0x0039B04C File Offset: 0x0039924C
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019448 RID: 103496 RVA: 0x0039B094 File Offset: 0x00399294
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x06019449 RID: 103497 RVA: 0x0039B0B0 File Offset: 0x003992B0
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x170079E9 RID: 31209
		// (get) Token: 0x0601944A RID: 103498 RVA: 0x0039B0CC File Offset: 0x003992CC
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

		// Token: 0x0601944B RID: 103499 RVA: 0x0039B10C File Offset: 0x0039930C
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

		// Token: 0x0601944C RID: 103500 RVA: 0x0039B163 File Offset: 0x00399363
		public static void StartIQuestStatisticsCollect(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601944D RID: 103501 RVA: 0x0039B16C File Offset: 0x0039936C
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601944E RID: 103502 RVA: 0x0039B177 File Offset: 0x00399377
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x0601944F RID: 103503 RVA: 0x0039B182 File Offset: 0x00399382
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06019450 RID: 103504 RVA: 0x0039B18D File Offset: 0x0039938D
		public static void AddEntitiyMatch(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> entitiyMatchOffset)
		{
			builder.AddOffset(3, entitiyMatchOffset.Value, 0);
		}

		// Token: 0x06019451 RID: 103505 RVA: 0x0039B19D File Offset: 0x0039939D
		public static void AddIsGlobal(FlatBufferBuilder builder, bool isGlobal)
		{
			builder.AddBool(4, isGlobal, false);
		}

		// Token: 0x06019452 RID: 103506 RVA: 0x0039B1A8 File Offset: 0x003993A8
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(5, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x06019453 RID: 103507 RVA: 0x0039B1B3 File Offset: 0x003993B3
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(6, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x06019454 RID: 103508 RVA: 0x0039B1BE File Offset: 0x003993BE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06019455 RID: 103509 RVA: 0x0039B1C9 File Offset: 0x003993C9
		public static Offset<IQuestStatisticsCollect> EndIQuestStatisticsCollect(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatisticsCollect>(builder.EndTable());
		}

		// Token: 0x06019456 RID: 103510 RVA: 0x0039B1D8 File Offset: 0x003993D8
		public IQuestStatisticsCollectT UnPack()
		{
			IQuestStatisticsCollectT questStatisticsCollectT = new IQuestStatisticsCollectT();
			this.UnPackTo(questStatisticsCollectT);
			return questStatisticsCollectT;
		}

		// Token: 0x06019457 RID: 103511 RVA: 0x0039B1F4 File Offset: 0x003993F4
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

		// Token: 0x06019458 RID: 103512 RVA: 0x0039B458 File Offset: 0x00399658
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

		// Token: 0x0400C57D RID: 50557
		private Table __p;
	}
}
