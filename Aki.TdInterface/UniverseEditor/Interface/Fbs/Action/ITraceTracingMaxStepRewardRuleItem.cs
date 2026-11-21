using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C23 RID: 31779
	public struct ITraceTracingMaxStepRewardRuleItem : IFlatbufferObject
	{
		// Token: 0x1700EDF6 RID: 60918
		// (get) Token: 0x0603947D RID: 234621 RVA: 0x007BC796 File Offset: 0x007BA996
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603947E RID: 234622 RVA: 0x007BC7A3 File Offset: 0x007BA9A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603947F RID: 234623 RVA: 0x007BC7AC File Offset: 0x007BA9AC
		public static ITraceTracingMaxStepRewardRuleItem GetRootAsITraceTracingMaxStepRewardRuleItem(ByteBuffer _bb)
		{
			return ITraceTracingMaxStepRewardRuleItem.GetRootAsITraceTracingMaxStepRewardRuleItem(_bb, default(ITraceTracingMaxStepRewardRuleItem));
		}

		// Token: 0x06039480 RID: 234624 RVA: 0x007BC7C8 File Offset: 0x007BA9C8
		public static ITraceTracingMaxStepRewardRuleItem GetRootAsITraceTracingMaxStepRewardRuleItem(ByteBuffer _bb, ITraceTracingMaxStepRewardRuleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039481 RID: 234625 RVA: 0x007BC7E5 File Offset: 0x007BA9E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039482 RID: 234626 RVA: 0x007BC7F4 File Offset: 0x007BA9F4
		public ITraceTracingMaxStepRewardRuleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDF7 RID: 60919
		// (get) Token: 0x06039483 RID: 234627 RVA: 0x007BC804 File Offset: 0x007BAA04
		public int RestartCount
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EDF8 RID: 60920
		// (get) Token: 0x06039484 RID: 234628 RVA: 0x007BC840 File Offset: 0x007BAA40
		public int AddStep
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039485 RID: 234629 RVA: 0x007BC87C File Offset: 0x007BAA7C
		public static Offset<ITraceTracingMaxStepRewardRuleItem> CreateITraceTracingMaxStepRewardRuleItem(FlatBufferBuilder builder, int RestartCount = 0, int AddStep = 0)
		{
			builder.StartTable(2);
			ITraceTracingMaxStepRewardRuleItem.AddAddStep(builder, AddStep);
			ITraceTracingMaxStepRewardRuleItem.AddRestartCount(builder, RestartCount);
			return ITraceTracingMaxStepRewardRuleItem.EndITraceTracingMaxStepRewardRuleItem(builder);
		}

		// Token: 0x06039486 RID: 234630 RVA: 0x007BC899 File Offset: 0x007BAA99
		public static void StartITraceTracingMaxStepRewardRuleItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039487 RID: 234631 RVA: 0x007BC8A2 File Offset: 0x007BAAA2
		public static void AddRestartCount(FlatBufferBuilder builder, int restartCount)
		{
			builder.AddInt(0, restartCount, 0);
		}

		// Token: 0x06039488 RID: 234632 RVA: 0x007BC8AD File Offset: 0x007BAAAD
		public static void AddAddStep(FlatBufferBuilder builder, int addStep)
		{
			builder.AddInt(1, addStep, 0);
		}

		// Token: 0x06039489 RID: 234633 RVA: 0x007BC8B8 File Offset: 0x007BAAB8
		public static Offset<ITraceTracingMaxStepRewardRuleItem> EndITraceTracingMaxStepRewardRuleItem(FlatBufferBuilder builder)
		{
			return new Offset<ITraceTracingMaxStepRewardRuleItem>(builder.EndTable());
		}

		// Token: 0x0603948A RID: 234634 RVA: 0x007BC8C8 File Offset: 0x007BAAC8
		public ITraceTracingMaxStepRewardRuleItemT UnPack()
		{
			ITraceTracingMaxStepRewardRuleItemT traceTracingMaxStepRewardRuleItemT = new ITraceTracingMaxStepRewardRuleItemT();
			this.UnPackTo(traceTracingMaxStepRewardRuleItemT);
			return traceTracingMaxStepRewardRuleItemT;
		}

		// Token: 0x0603948B RID: 234635 RVA: 0x007BC8E3 File Offset: 0x007BAAE3
		public void UnPackTo(ITraceTracingMaxStepRewardRuleItemT _o)
		{
			_o.RestartCount = this.RestartCount;
			_o.AddStep = this.AddStep;
		}

		// Token: 0x0603948C RID: 234636 RVA: 0x007BC900 File Offset: 0x007BAB00
		public static Offset<ITraceTracingMaxStepRewardRuleItem> Pack(FlatBufferBuilder builder, ITraceTracingMaxStepRewardRuleItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITraceTracingMaxStepRewardRuleItem>);
			}
			return ITraceTracingMaxStepRewardRuleItem.CreateITraceTracingMaxStepRewardRuleItem(builder, _o.RestartCount, _o.AddStep);
		}

		// Token: 0x040132D0 RID: 78544
		private Table __p;
	}
}
