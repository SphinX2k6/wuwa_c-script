using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D28 RID: 23848
	public struct IBvbAiDiscardForEnergyAndActData : IFlatbufferObject
	{
		// Token: 0x1700B2BD RID: 45757
		// (get) Token: 0x06028C27 RID: 166951 RVA: 0x005993A4 File Offset: 0x005975A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028C28 RID: 166952 RVA: 0x005993B1 File Offset: 0x005975B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028C29 RID: 166953 RVA: 0x005993B8 File Offset: 0x005975B8
		public static IBvbAiDiscardForEnergyAndActData GetRootAsIBvbAiDiscardForEnergyAndActData(ByteBuffer _bb)
		{
			return IBvbAiDiscardForEnergyAndActData.GetRootAsIBvbAiDiscardForEnergyAndActData(_bb, default(IBvbAiDiscardForEnergyAndActData));
		}

		// Token: 0x06028C2A RID: 166954 RVA: 0x005993D4 File Offset: 0x005975D4
		public static IBvbAiDiscardForEnergyAndActData GetRootAsIBvbAiDiscardForEnergyAndActData(ByteBuffer _bb, IBvbAiDiscardForEnergyAndActData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028C2B RID: 166955 RVA: 0x005993F1 File Offset: 0x005975F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028C2C RID: 166956 RVA: 0x00599400 File Offset: 0x00597600
		public IBvbAiDiscardForEnergyAndActData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2BE RID: 45758
		// (get) Token: 0x06028C2D RID: 166957 RVA: 0x00599410 File Offset: 0x00597610
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

		// Token: 0x1700B2BF RID: 45759
		// (get) Token: 0x06028C2E RID: 166958 RVA: 0x0059944C File Offset: 0x0059764C
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

		// Token: 0x06028C2F RID: 166959 RVA: 0x00599488 File Offset: 0x00597688
		public TTable? GoalAct<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028C30 RID: 166960 RVA: 0x005994CC File Offset: 0x005976CC
		public IDiscardForEnergyToDeployType GoalActAsIDiscardForEnergyToDeployType()
		{
			return this.GoalAct<IDiscardForEnergyToDeployType>().Value;
		}

		// Token: 0x06028C31 RID: 166961 RVA: 0x005994E8 File Offset: 0x005976E8
		public IDiscardForEnergyToEvolutionType GoalActAsIDiscardForEnergyToEvolutionType()
		{
			return this.GoalAct<IDiscardForEnergyToEvolutionType>().Value;
		}

		// Token: 0x1700B2C0 RID: 45760
		// (get) Token: 0x06028C32 RID: 166962 RVA: 0x00599504 File Offset: 0x00597704
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

		// Token: 0x06028C33 RID: 166963 RVA: 0x00599541 File Offset: 0x00597741
		public static Offset<IBvbAiDiscardForEnergyAndActData> CreateIBvbAiDiscardForEnergyAndActData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TGoalActData GoalAct_type = TGoalActData.NONE, int GoalActOffset = 0, EDiscardForEnergyAndActStrategy Strategy = EDiscardForEnergyAndActStrategy.Default)
		{
			builder.StartTable(4);
			IBvbAiDiscardForEnergyAndActData.AddGoalAct(builder, GoalActOffset);
			IBvbAiDiscardForEnergyAndActData.AddStrategy(builder, Strategy);
			IBvbAiDiscardForEnergyAndActData.AddGoalActType(builder, GoalAct_type);
			IBvbAiDiscardForEnergyAndActData.AddType(builder, Type);
			return IBvbAiDiscardForEnergyAndActData.EndIBvbAiDiscardForEnergyAndActData(builder);
		}

		// Token: 0x06028C34 RID: 166964 RVA: 0x0059956D File Offset: 0x0059776D
		public static void StartIBvbAiDiscardForEnergyAndActData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028C35 RID: 166965 RVA: 0x00599576 File Offset: 0x00597776
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028C36 RID: 166966 RVA: 0x00599581 File Offset: 0x00597781
		public static void AddGoalActType(FlatBufferBuilder builder, TGoalActData goalActType)
		{
			builder.AddByte(1, (byte)goalActType, 0);
		}

		// Token: 0x06028C37 RID: 166967 RVA: 0x0059958C File Offset: 0x0059778C
		public static void AddGoalAct(FlatBufferBuilder builder, int goalActOffset)
		{
			builder.AddOffset(2, goalActOffset, 0);
		}

		// Token: 0x06028C38 RID: 166968 RVA: 0x00599597 File Offset: 0x00597797
		public static void AddStrategy(FlatBufferBuilder builder, EDiscardForEnergyAndActStrategy strategy)
		{
			builder.AddByte(3, (byte)strategy, 0);
		}

		// Token: 0x06028C39 RID: 166969 RVA: 0x005995A2 File Offset: 0x005977A2
		public static Offset<IBvbAiDiscardForEnergyAndActData> EndIBvbAiDiscardForEnergyAndActData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiDiscardForEnergyAndActData>(builder.EndTable());
		}

		// Token: 0x06028C3A RID: 166970 RVA: 0x005995B0 File Offset: 0x005977B0
		public IBvbAiDiscardForEnergyAndActDataT UnPack()
		{
			IBvbAiDiscardForEnergyAndActDataT bvbAiDiscardForEnergyAndActDataT = new IBvbAiDiscardForEnergyAndActDataT();
			this.UnPackTo(bvbAiDiscardForEnergyAndActDataT);
			return bvbAiDiscardForEnergyAndActDataT;
		}

		// Token: 0x06028C3B RID: 166971 RVA: 0x005995CC File Offset: 0x005977CC
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

		// Token: 0x06028C3C RID: 166972 RVA: 0x0059968C File Offset: 0x0059788C
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

		// Token: 0x0400F6D7 RID: 63191
		private Table __p;
	}
}
