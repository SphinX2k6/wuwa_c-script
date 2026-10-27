using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BF2 RID: 19442
	public struct ICounterAttackCondition : IFlatbufferObject
	{
		// Token: 0x17008D38 RID: 36152
		// (get) Token: 0x0601EC73 RID: 126067 RVA: 0x0044FCA0 File Offset: 0x0044DEA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EC74 RID: 126068 RVA: 0x0044FCAD File Offset: 0x0044DEAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EC75 RID: 126069 RVA: 0x0044FCB4 File Offset: 0x0044DEB4
		public static ICounterAttackCondition GetRootAsICounterAttackCondition(ByteBuffer _bb)
		{
			return ICounterAttackCondition.GetRootAsICounterAttackCondition(_bb, default(ICounterAttackCondition));
		}

		// Token: 0x0601EC76 RID: 126070 RVA: 0x0044FCD0 File Offset: 0x0044DED0
		public static ICounterAttackCondition GetRootAsICounterAttackCondition(ByteBuffer _bb, ICounterAttackCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EC77 RID: 126071 RVA: 0x0044FCED File Offset: 0x0044DEED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EC78 RID: 126072 RVA: 0x0044FCFC File Offset: 0x0044DEFC
		public ICounterAttackCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D39 RID: 36153
		// (get) Token: 0x0601EC79 RID: 126073 RVA: 0x0044FD0C File Offset: 0x0044DF0C
		public EBattleConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBattleConditionType.BattleTag;
				}
				return (EBattleConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D3A RID: 36154
		// (get) Token: 0x0601EC7A RID: 126074 RVA: 0x0044FD48 File Offset: 0x0044DF48
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EC7B RID: 126075 RVA: 0x0044FD84 File Offset: 0x0044DF84
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601EC7C RID: 126076 RVA: 0x0044FDC8 File Offset: 0x0044DFC8
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601EC7D RID: 126077 RVA: 0x0044FDE4 File Offset: 0x0044DFE4
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601EC7E RID: 126078 RVA: 0x0044FDFF File Offset: 0x0044DFFF
		public static Offset<ICounterAttackCondition> CreateICounterAttackCondition(FlatBufferBuilder builder, EBattleConditionType Type = EBattleConditionType.BattleTag, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(3);
			ICounterAttackCondition.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICounterAttackCondition.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICounterAttackCondition.AddType(builder, Type);
			return ICounterAttackCondition.EndICounterAttackCondition(builder);
		}

		// Token: 0x0601EC7F RID: 126079 RVA: 0x0044FE23 File Offset: 0x0044E023
		public static void StartICounterAttackCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601EC80 RID: 126080 RVA: 0x0044FE2C File Offset: 0x0044E02C
		public static void AddType(FlatBufferBuilder builder, EBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EC81 RID: 126081 RVA: 0x0044FE37 File Offset: 0x0044E037
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(1, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601EC82 RID: 126082 RVA: 0x0044FE42 File Offset: 0x0044E042
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(2, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601EC83 RID: 126083 RVA: 0x0044FE4D File Offset: 0x0044E04D
		public static Offset<ICounterAttackCondition> EndICounterAttackCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICounterAttackCondition>(builder.EndTable());
		}

		// Token: 0x0601EC84 RID: 126084 RVA: 0x0044FE5C File Offset: 0x0044E05C
		public ICounterAttackConditionT UnPack()
		{
			ICounterAttackConditionT counterAttackConditionT = new ICounterAttackConditionT();
			this.UnPackTo(counterAttackConditionT);
			return counterAttackConditionT;
		}

		// Token: 0x0601EC85 RID: 126085 RVA: 0x0044FE78 File Offset: 0x0044E078
		public void UnPackTo(ICounterAttackConditionT _o)
		{
			_o.Type = this.Type;
			_o.OnlinePlayerConditionTargetOption = new TOnlinePlayerConditionTargetUnion();
			_o.OnlinePlayerConditionTargetOption.Type = this.OnlinePlayerConditionTargetOptionType;
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType = this.OnlinePlayerConditionTargetOptionType;
			if (onlinePlayerConditionTargetOptionType == TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost)
			{
				_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value.UnPack() : null);
				return;
			}
			if (onlinePlayerConditionTargetOptionType != TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator)
			{
				return;
			}
			_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value.UnPack() : null);
		}

		// Token: 0x0601EC86 RID: 126086 RVA: 0x0044FF28 File Offset: 0x0044E128
		public static Offset<ICounterAttackCondition> Pack(FlatBufferBuilder builder, ICounterAttackConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICounterAttackCondition>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICounterAttackCondition.CreateICounterAttackCondition(builder, _o.Type, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D57D RID: 54653
		private Table __p;
	}
}
