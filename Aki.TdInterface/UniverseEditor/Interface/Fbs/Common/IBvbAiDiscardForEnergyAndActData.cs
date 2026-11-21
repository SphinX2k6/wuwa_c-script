using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200635F RID: 25439
	public struct IBvbAiDiscardForEnergyAndActData : IFlatbufferObject
	{
		// Token: 0x1700BC1E RID: 48158
		// (get) Token: 0x0602B291 RID: 176785 RVA: 0x005E1E14 File Offset: 0x005E0014
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B292 RID: 176786 RVA: 0x005E1E21 File Offset: 0x005E0021
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B293 RID: 176787 RVA: 0x005E1E28 File Offset: 0x005E0028
		public static IBvbAiDiscardForEnergyAndActData GetRootAsIBvbAiDiscardForEnergyAndActData(ByteBuffer _bb)
		{
			return IBvbAiDiscardForEnergyAndActData.GetRootAsIBvbAiDiscardForEnergyAndActData(_bb, default(IBvbAiDiscardForEnergyAndActData));
		}

		// Token: 0x0602B294 RID: 176788 RVA: 0x005E1E44 File Offset: 0x005E0044
		public static IBvbAiDiscardForEnergyAndActData GetRootAsIBvbAiDiscardForEnergyAndActData(ByteBuffer _bb, IBvbAiDiscardForEnergyAndActData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B295 RID: 176789 RVA: 0x005E1E61 File Offset: 0x005E0061
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B296 RID: 176790 RVA: 0x005E1E70 File Offset: 0x005E0070
		public IBvbAiDiscardForEnergyAndActData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC1F RID: 48159
		// (get) Token: 0x0602B297 RID: 176791 RVA: 0x005E1E80 File Offset: 0x005E0080
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC20 RID: 48160
		// (get) Token: 0x0602B298 RID: 176792 RVA: 0x005E1EBC File Offset: 0x005E00BC
		public TGoalActData GoalActType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TGoalActData.NONE;
				}
				return (TGoalActData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B299 RID: 176793 RVA: 0x005E1EF8 File Offset: 0x005E00F8
		public TTable? GoalAct<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B29A RID: 176794 RVA: 0x005E1F3C File Offset: 0x005E013C
		public IDiscardForEnergyToDeployType GoalActAsIDiscardForEnergyToDeployType()
		{
			return this.GoalAct<IDiscardForEnergyToDeployType>().Value;
		}

		// Token: 0x0602B29B RID: 176795 RVA: 0x005E1F58 File Offset: 0x005E0158
		public IDiscardForEnergyToEvolutionType GoalActAsIDiscardForEnergyToEvolutionType()
		{
			return this.GoalAct<IDiscardForEnergyToEvolutionType>().Value;
		}

		// Token: 0x1700BC21 RID: 48161
		// (get) Token: 0x0602B29C RID: 176796 RVA: 0x005E1F74 File Offset: 0x005E0174
		public EDiscardForEnergyAndActStrategy Strategy
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EDiscardForEnergyAndActStrategy.Default;
				}
				return (EDiscardForEnergyAndActStrategy)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B29D RID: 176797 RVA: 0x005E1FB1 File Offset: 0x005E01B1
		public static Offset<IBvbAiDiscardForEnergyAndActData> CreateIBvbAiDiscardForEnergyAndActData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TGoalActData GoalAct_type = TGoalActData.NONE, int GoalActOffset = 0, EDiscardForEnergyAndActStrategy Strategy = EDiscardForEnergyAndActStrategy.Default)
		{
			builder.StartTable(4);
			IBvbAiDiscardForEnergyAndActData.AddGoalAct(builder, GoalActOffset);
			IBvbAiDiscardForEnergyAndActData.AddStrategy(builder, Strategy);
			IBvbAiDiscardForEnergyAndActData.AddGoalActType(builder, GoalAct_type);
			IBvbAiDiscardForEnergyAndActData.AddType(builder, Type);
			return IBvbAiDiscardForEnergyAndActData.EndIBvbAiDiscardForEnergyAndActData(builder);
		}

		// Token: 0x0602B29E RID: 176798 RVA: 0x005E1FDD File Offset: 0x005E01DD
		public static void StartIBvbAiDiscardForEnergyAndActData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602B29F RID: 176799 RVA: 0x005E1FE6 File Offset: 0x005E01E6
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B2A0 RID: 176800 RVA: 0x005E1FF1 File Offset: 0x005E01F1
		public static void AddGoalActType(FlatBufferBuilder builder, TGoalActData goalActType)
		{
			builder.AddByte(1, (byte)goalActType, 0);
		}

		// Token: 0x0602B2A1 RID: 176801 RVA: 0x005E1FFC File Offset: 0x005E01FC
		public static void AddGoalAct(FlatBufferBuilder builder, int goalActOffset)
		{
			builder.AddOffset(2, goalActOffset, 0);
		}

		// Token: 0x0602B2A2 RID: 176802 RVA: 0x005E2007 File Offset: 0x005E0207
		public static void AddStrategy(FlatBufferBuilder builder, EDiscardForEnergyAndActStrategy strategy)
		{
			builder.AddByte(3, (byte)strategy, 0);
		}

		// Token: 0x0602B2A3 RID: 176803 RVA: 0x005E2012 File Offset: 0x005E0212
		public static Offset<IBvbAiDiscardForEnergyAndActData> EndIBvbAiDiscardForEnergyAndActData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiDiscardForEnergyAndActData>(builder.EndTable());
		}

		// Token: 0x0602B2A4 RID: 176804 RVA: 0x005E2020 File Offset: 0x005E0220
		public IBvbAiDiscardForEnergyAndActDataT UnPack()
		{
			IBvbAiDiscardForEnergyAndActDataT bvbAiDiscardForEnergyAndActDataT = new IBvbAiDiscardForEnergyAndActDataT();
			this.UnPackTo(bvbAiDiscardForEnergyAndActDataT);
			return bvbAiDiscardForEnergyAndActDataT;
		}

		// Token: 0x0602B2A5 RID: 176805 RVA: 0x005E203C File Offset: 0x005E023C
		public void UnPackTo(IBvbAiDiscardForEnergyAndActDataT _o)
		{
			_o.Type = this.Type;
			_o.GoalAct = new TGoalActDataUnion();
			_o.GoalAct.Type = this.GoalActType;
			TGoalActData goalActType = this.GoalActType;
			if (goalActType != TGoalActData.IDiscardForEnergyToDeployType)
			{
				if (goalActType == TGoalActData.IDiscardForEnergyToEvolutionType)
				{
					_o.GoalAct.Value = ((this.GoalAct<IDiscardForEnergyToEvolutionType>() != null) ? this.GoalAct<IDiscardForEnergyToEvolutionType>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.GoalAct.Value = ((this.GoalAct<IDiscardForEnergyToDeployType>() != null) ? this.GoalAct<IDiscardForEnergyToDeployType>().Value.UnPack() : null);
			}
			_o.Strategy = this.Strategy;
		}

		// Token: 0x0602B2A6 RID: 176806 RVA: 0x005E20FC File Offset: 0x005E02FC
		public static Offset<IBvbAiDiscardForEnergyAndActData> Pack(FlatBufferBuilder builder, IBvbAiDiscardForEnergyAndActDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiDiscardForEnergyAndActData>);
			}
			TGoalActData goalAct_type = (_o.GoalAct == null) ? TGoalActData.NONE : _o.GoalAct.Type;
			int goalActOffset = (_o.GoalAct == null) ? 0 : TGoalActDataUnion.Pack(builder, _o.GoalAct);
			return IBvbAiDiscardForEnergyAndActData.CreateIBvbAiDiscardForEnergyAndActData(builder, _o.Type, goalAct_type, goalActOffset, _o.Strategy);
		}

		// Token: 0x04010429 RID: 66601
		private Table __p;
	}
}
