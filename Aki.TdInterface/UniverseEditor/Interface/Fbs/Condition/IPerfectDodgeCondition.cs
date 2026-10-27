using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C6D RID: 19565
	public struct IPerfectDodgeCondition : IFlatbufferObject
	{
		// Token: 0x17008E1B RID: 36379
		// (get) Token: 0x0601F05B RID: 127067 RVA: 0x004564F4 File Offset: 0x004546F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F05C RID: 127068 RVA: 0x00456501 File Offset: 0x00454701
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F05D RID: 127069 RVA: 0x00456508 File Offset: 0x00454708
		public static IPerfectDodgeCondition GetRootAsIPerfectDodgeCondition(ByteBuffer _bb)
		{
			return IPerfectDodgeCondition.GetRootAsIPerfectDodgeCondition(_bb, default(IPerfectDodgeCondition));
		}

		// Token: 0x0601F05E RID: 127070 RVA: 0x00456524 File Offset: 0x00454724
		public static IPerfectDodgeCondition GetRootAsIPerfectDodgeCondition(ByteBuffer _bb, IPerfectDodgeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F05F RID: 127071 RVA: 0x00456541 File Offset: 0x00454741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F060 RID: 127072 RVA: 0x00456550 File Offset: 0x00454750
		public IPerfectDodgeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E1C RID: 36380
		// (get) Token: 0x0601F061 RID: 127073 RVA: 0x00456560 File Offset: 0x00454760
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

		// Token: 0x17008E1D RID: 36381
		// (get) Token: 0x0601F062 RID: 127074 RVA: 0x0045659C File Offset: 0x0045479C
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

		// Token: 0x0601F063 RID: 127075 RVA: 0x004565D8 File Offset: 0x004547D8
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F064 RID: 127076 RVA: 0x0045661C File Offset: 0x0045481C
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601F065 RID: 127077 RVA: 0x00456638 File Offset: 0x00454838
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601F066 RID: 127078 RVA: 0x00456653 File Offset: 0x00454853
		public static Offset<IPerfectDodgeCondition> CreateIPerfectDodgeCondition(FlatBufferBuilder builder, EBattleConditionType Type = EBattleConditionType.BattleTag, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(3);
			IPerfectDodgeCondition.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			IPerfectDodgeCondition.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			IPerfectDodgeCondition.AddType(builder, Type);
			return IPerfectDodgeCondition.EndIPerfectDodgeCondition(builder);
		}

		// Token: 0x0601F067 RID: 127079 RVA: 0x00456677 File Offset: 0x00454877
		public static void StartIPerfectDodgeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F068 RID: 127080 RVA: 0x00456680 File Offset: 0x00454880
		public static void AddType(FlatBufferBuilder builder, EBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F069 RID: 127081 RVA: 0x0045668B File Offset: 0x0045488B
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(1, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601F06A RID: 127082 RVA: 0x00456696 File Offset: 0x00454896
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(2, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601F06B RID: 127083 RVA: 0x004566A1 File Offset: 0x004548A1
		public static Offset<IPerfectDodgeCondition> EndIPerfectDodgeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IPerfectDodgeCondition>(builder.EndTable());
		}

		// Token: 0x0601F06C RID: 127084 RVA: 0x004566B0 File Offset: 0x004548B0
		public IPerfectDodgeConditionT UnPack()
		{
			IPerfectDodgeConditionT perfectDodgeConditionT = new IPerfectDodgeConditionT();
			this.UnPackTo(perfectDodgeConditionT);
			return perfectDodgeConditionT;
		}

		// Token: 0x0601F06D RID: 127085 RVA: 0x004566CC File Offset: 0x004548CC
		public void UnPackTo(IPerfectDodgeConditionT _o)
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

		// Token: 0x0601F06E RID: 127086 RVA: 0x0045677C File Offset: 0x0045497C
		public static Offset<IPerfectDodgeCondition> Pack(FlatBufferBuilder builder, IPerfectDodgeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerfectDodgeCondition>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return IPerfectDodgeCondition.CreateIPerfectDodgeCondition(builder, _o.Type, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D61E RID: 54814
		private Table __p;
	}
}
