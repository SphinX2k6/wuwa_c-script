using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050DF RID: 20703
	public struct ICounterAttackCondition : IFlatbufferObject
	{
		// Token: 0x1700945C RID: 37980
		// (get) Token: 0x06020859 RID: 133209 RVA: 0x00483308 File Offset: 0x00481508
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602085A RID: 133210 RVA: 0x00483315 File Offset: 0x00481515
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602085B RID: 133211 RVA: 0x0048331C File Offset: 0x0048151C
		public static ICounterAttackCondition GetRootAsICounterAttackCondition(ByteBuffer _bb)
		{
			return ICounterAttackCondition.GetRootAsICounterAttackCondition(_bb, default(ICounterAttackCondition));
		}

		// Token: 0x0602085C RID: 133212 RVA: 0x00483338 File Offset: 0x00481538
		public static ICounterAttackCondition GetRootAsICounterAttackCondition(ByteBuffer _bb, ICounterAttackCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602085D RID: 133213 RVA: 0x00483355 File Offset: 0x00481555
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602085E RID: 133214 RVA: 0x00483364 File Offset: 0x00481564
		public ICounterAttackCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700945D RID: 37981
		// (get) Token: 0x0602085F RID: 133215 RVA: 0x00483374 File Offset: 0x00481574
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

		// Token: 0x1700945E RID: 37982
		// (get) Token: 0x06020860 RID: 133216 RVA: 0x004833B0 File Offset: 0x004815B0
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

		// Token: 0x06020861 RID: 133217 RVA: 0x004833EC File Offset: 0x004815EC
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020862 RID: 133218 RVA: 0x00483430 File Offset: 0x00481630
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x06020863 RID: 133219 RVA: 0x0048344C File Offset: 0x0048164C
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x06020864 RID: 133220 RVA: 0x00483467 File Offset: 0x00481667
		public static Offset<ICounterAttackCondition> CreateICounterAttackCondition(FlatBufferBuilder builder, EBattleConditionType Type = EBattleConditionType.BattleTag, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(3);
			ICounterAttackCondition.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICounterAttackCondition.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICounterAttackCondition.AddType(builder, Type);
			return ICounterAttackCondition.EndICounterAttackCondition(builder);
		}

		// Token: 0x06020865 RID: 133221 RVA: 0x0048348B File Offset: 0x0048168B
		public static void StartICounterAttackCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020866 RID: 133222 RVA: 0x00483494 File Offset: 0x00481694
		public static void AddType(FlatBufferBuilder builder, EBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020867 RID: 133223 RVA: 0x0048349F File Offset: 0x0048169F
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(1, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x06020868 RID: 133224 RVA: 0x004834AA File Offset: 0x004816AA
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(2, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x06020869 RID: 133225 RVA: 0x004834B5 File Offset: 0x004816B5
		public static Offset<ICounterAttackCondition> EndICounterAttackCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICounterAttackCondition>(builder.EndTable());
		}

		// Token: 0x0602086A RID: 133226 RVA: 0x004834C4 File Offset: 0x004816C4
		public ICounterAttackConditionT UnPack()
		{
			ICounterAttackConditionT counterAttackConditionT = new ICounterAttackConditionT();
			this.UnPackTo(counterAttackConditionT);
			return counterAttackConditionT;
		}

		// Token: 0x0602086B RID: 133227 RVA: 0x004834E0 File Offset: 0x004816E0
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

		// Token: 0x0602086C RID: 133228 RVA: 0x00483590 File Offset: 0x00481790
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

		// Token: 0x0400E094 RID: 57492
		private Table __p;
	}
}
