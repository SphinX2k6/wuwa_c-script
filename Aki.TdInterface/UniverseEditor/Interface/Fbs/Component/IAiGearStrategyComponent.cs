using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200538E RID: 21390
	public struct IAiGearStrategyComponent : IFlatbufferObject
	{
		// Token: 0x1700972E RID: 38702
		// (get) Token: 0x060215AF RID: 136623 RVA: 0x0049A618 File Offset: 0x00498818
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060215B0 RID: 136624 RVA: 0x0049A625 File Offset: 0x00498825
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060215B1 RID: 136625 RVA: 0x0049A62C File Offset: 0x0049882C
		public static IAiGearStrategyComponent GetRootAsIAiGearStrategyComponent(ByteBuffer _bb)
		{
			return IAiGearStrategyComponent.GetRootAsIAiGearStrategyComponent(_bb, default(IAiGearStrategyComponent));
		}

		// Token: 0x060215B2 RID: 136626 RVA: 0x0049A648 File Offset: 0x00498848
		public static IAiGearStrategyComponent GetRootAsIAiGearStrategyComponent(ByteBuffer _bb, IAiGearStrategyComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060215B3 RID: 136627 RVA: 0x0049A665 File Offset: 0x00498865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060215B4 RID: 136628 RVA: 0x0049A674 File Offset: 0x00498874
		public IAiGearStrategyComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700972F RID: 38703
		// (get) Token: 0x060215B5 RID: 136629 RVA: 0x0049A684 File Offset: 0x00498884
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009730 RID: 38704
		// (get) Token: 0x060215B6 RID: 136630 RVA: 0x0049A6C4 File Offset: 0x004988C4
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

		// Token: 0x060215B7 RID: 136631 RVA: 0x0049A700 File Offset: 0x00498900
		public TTable? StrategyType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060215B8 RID: 136632 RVA: 0x0049A744 File Offset: 0x00498944
		public IRaceStrategy StrategyTypeAsIRaceStrategy()
		{
			return this.StrategyType<IRaceStrategy>().Value;
		}

		// Token: 0x060215B9 RID: 136633 RVA: 0x0049A760 File Offset: 0x00498960
		public IRenjuStrategy StrategyTypeAsIRenjuStrategy()
		{
			return this.StrategyType<IRenjuStrategy>().Value;
		}

		// Token: 0x17009731 RID: 38705
		// (get) Token: 0x060215BA RID: 136634 RVA: 0x0049A77C File Offset: 0x0049897C
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

		// Token: 0x060215BB RID: 136635 RVA: 0x0049A7B9 File Offset: 0x004989B9
		public static Offset<IAiGearStrategyComponent> CreateIAiGearStrategyComponent(FlatBufferBuilder builder, bool Disabled = false, TAiGearStrategy StrategyType_type = TAiGearStrategy.NONE, int StrategyTypeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IAiGearStrategyComponent.AddStrategyType(builder, StrategyTypeOffset);
			IAiGearStrategyComponent.AddNullMask(builder, NullMask);
			IAiGearStrategyComponent.AddStrategyTypeType(builder, StrategyType_type);
			IAiGearStrategyComponent.AddDisabled(builder, Disabled);
			return IAiGearStrategyComponent.EndIAiGearStrategyComponent(builder);
		}

		// Token: 0x060215BC RID: 136636 RVA: 0x0049A7E5 File Offset: 0x004989E5
		public static void StartIAiGearStrategyComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060215BD RID: 136637 RVA: 0x0049A7EE File Offset: 0x004989EE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060215BE RID: 136638 RVA: 0x0049A7F9 File Offset: 0x004989F9
		public static void AddStrategyTypeType(FlatBufferBuilder builder, TAiGearStrategy strategyTypeType)
		{
			builder.AddByte(1, (byte)strategyTypeType, 0);
		}

		// Token: 0x060215BF RID: 136639 RVA: 0x0049A804 File Offset: 0x00498A04
		public static void AddStrategyType(FlatBufferBuilder builder, int strategyTypeOffset)
		{
			builder.AddOffset(2, strategyTypeOffset, 0);
		}

		// Token: 0x060215C0 RID: 136640 RVA: 0x0049A80F File Offset: 0x00498A0F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060215C1 RID: 136641 RVA: 0x0049A81A File Offset: 0x00498A1A
		public static Offset<IAiGearStrategyComponent> EndIAiGearStrategyComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAiGearStrategyComponent>(builder.EndTable());
		}

		// Token: 0x060215C2 RID: 136642 RVA: 0x0049A828 File Offset: 0x00498A28
		public IAiGearStrategyComponentT UnPack()
		{
			IAiGearStrategyComponentT aiGearStrategyComponentT = new IAiGearStrategyComponentT();
			this.UnPackTo(aiGearStrategyComponentT);
			return aiGearStrategyComponentT;
		}

		// Token: 0x060215C3 RID: 136643 RVA: 0x0049A844 File Offset: 0x00498A44
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

		// Token: 0x060215C4 RID: 136644 RVA: 0x0049A904 File Offset: 0x00498B04
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

		// Token: 0x0400E7B1 RID: 59313
		private Table __p;
	}
}
