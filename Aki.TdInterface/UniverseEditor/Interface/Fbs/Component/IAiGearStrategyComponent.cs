using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E7D RID: 20093
	public struct IAiGearStrategyComponent : IFlatbufferObject
	{
		// Token: 0x17008FF5 RID: 36853
		// (get) Token: 0x0601F964 RID: 129380 RVA: 0x00466600 File Offset: 0x00464800
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F965 RID: 129381 RVA: 0x0046660D File Offset: 0x0046480D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F966 RID: 129382 RVA: 0x00466614 File Offset: 0x00464814
		public static IAiGearStrategyComponent GetRootAsIAiGearStrategyComponent(ByteBuffer _bb)
		{
			return IAiGearStrategyComponent.GetRootAsIAiGearStrategyComponent(_bb, default(IAiGearStrategyComponent));
		}

		// Token: 0x0601F967 RID: 129383 RVA: 0x00466630 File Offset: 0x00464830
		public static IAiGearStrategyComponent GetRootAsIAiGearStrategyComponent(ByteBuffer _bb, IAiGearStrategyComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F968 RID: 129384 RVA: 0x0046664D File Offset: 0x0046484D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F969 RID: 129385 RVA: 0x0046665C File Offset: 0x0046485C
		public IAiGearStrategyComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FF6 RID: 36854
		// (get) Token: 0x0601F96A RID: 129386 RVA: 0x0046666C File Offset: 0x0046486C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008FF7 RID: 36855
		// (get) Token: 0x0601F96B RID: 129387 RVA: 0x004666AC File Offset: 0x004648AC
		public TAiGearStrategy StrategyTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TAiGearStrategy.NONE;
				}
				return (TAiGearStrategy)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F96C RID: 129388 RVA: 0x004666E8 File Offset: 0x004648E8
		public TTable? StrategyType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F96D RID: 129389 RVA: 0x0046672C File Offset: 0x0046492C
		public IRaceStrategy StrategyTypeAsIRaceStrategy()
		{
			return this.StrategyType<IRaceStrategy>().Value;
		}

		// Token: 0x0601F96E RID: 129390 RVA: 0x00466748 File Offset: 0x00464948
		public IRenjuStrategy StrategyTypeAsIRenjuStrategy()
		{
			return this.StrategyType<IRenjuStrategy>().Value;
		}

		// Token: 0x17008FF8 RID: 36856
		// (get) Token: 0x0601F96F RID: 129391 RVA: 0x00466764 File Offset: 0x00464964
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F970 RID: 129392 RVA: 0x004667A1 File Offset: 0x004649A1
		public static Offset<IAiGearStrategyComponent> CreateIAiGearStrategyComponent(FlatBufferBuilder builder, bool Disabled = false, TAiGearStrategy StrategyType_type = TAiGearStrategy.NONE, int StrategyTypeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IAiGearStrategyComponent.AddStrategyType(builder, StrategyTypeOffset);
			IAiGearStrategyComponent.AddNullMask(builder, NullMask);
			IAiGearStrategyComponent.AddStrategyTypeType(builder, StrategyType_type);
			IAiGearStrategyComponent.AddDisabled(builder, Disabled);
			return IAiGearStrategyComponent.EndIAiGearStrategyComponent(builder);
		}

		// Token: 0x0601F971 RID: 129393 RVA: 0x004667CD File Offset: 0x004649CD
		public static void StartIAiGearStrategyComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F972 RID: 129394 RVA: 0x004667D6 File Offset: 0x004649D6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601F973 RID: 129395 RVA: 0x004667E1 File Offset: 0x004649E1
		public static void AddStrategyTypeType(FlatBufferBuilder builder, TAiGearStrategy strategyTypeType)
		{
			builder.AddByte(1, (byte)strategyTypeType, 0);
		}

		// Token: 0x0601F974 RID: 129396 RVA: 0x004667EC File Offset: 0x004649EC
		public static void AddStrategyType(FlatBufferBuilder builder, int strategyTypeOffset)
		{
			builder.AddOffset(2, strategyTypeOffset, 0);
		}

		// Token: 0x0601F975 RID: 129397 RVA: 0x004667F7 File Offset: 0x004649F7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601F976 RID: 129398 RVA: 0x00466802 File Offset: 0x00464A02
		public static Offset<IAiGearStrategyComponent> EndIAiGearStrategyComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAiGearStrategyComponent>(builder.EndTable());
		}

		// Token: 0x0601F977 RID: 129399 RVA: 0x00466810 File Offset: 0x00464A10
		public IAiGearStrategyComponentT UnPack()
		{
			IAiGearStrategyComponentT aiGearStrategyComponentT = new IAiGearStrategyComponentT();
			this.UnPackTo(aiGearStrategyComponentT);
			return aiGearStrategyComponentT;
		}

		// Token: 0x0601F978 RID: 129400 RVA: 0x0046682C File Offset: 0x00464A2C
		public void UnPackTo(IAiGearStrategyComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.StrategyType = new TAiGearStrategyUnion();
			_o.StrategyType.Type = this.StrategyTypeType;
			TAiGearStrategy strategyTypeType = this.StrategyTypeType;
			if (strategyTypeType != TAiGearStrategy.IRaceStrategy)
			{
				if (strategyTypeType == TAiGearStrategy.IRenjuStrategy)
				{
					_o.StrategyType.Value = ((this.StrategyType<IRenjuStrategy>() != null) ? this.StrategyType<IRenjuStrategy>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.StrategyType.Value = ((this.StrategyType<IRaceStrategy>() != null) ? this.StrategyType<IRaceStrategy>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F979 RID: 129401 RVA: 0x004668EC File Offset: 0x00464AEC
		public static Offset<IAiGearStrategyComponent> Pack(FlatBufferBuilder builder, IAiGearStrategyComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAiGearStrategyComponent>);
			}
			TAiGearStrategy strategyType_type = (_o.StrategyType == null) ? TAiGearStrategy.NONE : _o.StrategyType.Type;
			int strategyTypeOffset = (_o.StrategyType == null) ? 0 : TAiGearStrategyUnion.Pack(builder, _o.StrategyType);
			return IAiGearStrategyComponent.CreateIAiGearStrategyComponent(builder, _o.Disabled, strategyType_type, strategyTypeOffset, _o.NullMask);
		}

		// Token: 0x0400DC37 RID: 56375
		private Table __p;
	}
}
