using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004688 RID: 18056
	public struct ITrapDefenseConditionStepMapChange : IFlatbufferObject
	{
		// Token: 0x17007E80 RID: 32384
		// (get) Token: 0x0601A822 RID: 108578 RVA: 0x003C5DA1 File Offset: 0x003C3FA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A823 RID: 108579 RVA: 0x003C5DAE File Offset: 0x003C3FAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A824 RID: 108580 RVA: 0x003C5DB8 File Offset: 0x003C3FB8
		public static ITrapDefenseConditionStepMapChange GetRootAsITrapDefenseConditionStepMapChange(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepMapChange.GetRootAsITrapDefenseConditionStepMapChange(_bb, default(ITrapDefenseConditionStepMapChange));
		}

		// Token: 0x0601A825 RID: 108581 RVA: 0x003C5DD4 File Offset: 0x003C3FD4
		public static ITrapDefenseConditionStepMapChange GetRootAsITrapDefenseConditionStepMapChange(ByteBuffer _bb, ITrapDefenseConditionStepMapChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A826 RID: 108582 RVA: 0x003C5DF1 File Offset: 0x003C3FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A827 RID: 108583 RVA: 0x003C5E00 File Offset: 0x003C4000
		public ITrapDefenseConditionStepMapChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E81 RID: 32385
		// (get) Token: 0x0601A828 RID: 108584 RVA: 0x003C5E10 File Offset: 0x003C4010
		public ETrapDefenseConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseConditionStep.Reward;
				}
				return (ETrapDefenseConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A829 RID: 108585 RVA: 0x003C5E4C File Offset: 0x003C404C
		public static Offset<ITrapDefenseConditionStepMapChange> CreateITrapDefenseConditionStepMapChange(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepMapChange.AddType(builder, Type);
			return ITrapDefenseConditionStepMapChange.EndITrapDefenseConditionStepMapChange(builder);
		}

		// Token: 0x0601A82A RID: 108586 RVA: 0x003C5E62 File Offset: 0x003C4062
		public static void StartITrapDefenseConditionStepMapChange(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A82B RID: 108587 RVA: 0x003C5E6B File Offset: 0x003C406B
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A82C RID: 108588 RVA: 0x003C5E76 File Offset: 0x003C4076
		public static Offset<ITrapDefenseConditionStepMapChange> EndITrapDefenseConditionStepMapChange(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepMapChange>(builder.EndTable());
		}

		// Token: 0x0601A82D RID: 108589 RVA: 0x003C5E84 File Offset: 0x003C4084
		public ITrapDefenseConditionStepMapChangeT UnPack()
		{
			ITrapDefenseConditionStepMapChangeT trapDefenseConditionStepMapChangeT = new ITrapDefenseConditionStepMapChangeT();
			this.UnPackTo(trapDefenseConditionStepMapChangeT);
			return trapDefenseConditionStepMapChangeT;
		}

		// Token: 0x0601A82E RID: 108590 RVA: 0x003C5E9F File Offset: 0x003C409F
		public void UnPackTo(ITrapDefenseConditionStepMapChangeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A82F RID: 108591 RVA: 0x003C5EB0 File Offset: 0x003C40B0
		public static Offset<ITrapDefenseConditionStepMapChange> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepMapChangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepMapChange>);
			}
			return ITrapDefenseConditionStepMapChange.CreateITrapDefenseConditionStepMapChange(builder, _o.Type);
		}

		// Token: 0x0400C8BF RID: 51391
		private Table __p;
	}
}
