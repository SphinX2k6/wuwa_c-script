using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007430 RID: 29744
	public struct ITraceTracingMaxStepRewardRuleItem : IFlatbufferObject
	{
		// Token: 0x1700E1D9 RID: 57817
		// (get) Token: 0x06036094 RID: 221332 RVA: 0x00759A6A File Offset: 0x00757C6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036095 RID: 221333 RVA: 0x00759A77 File Offset: 0x00757C77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036096 RID: 221334 RVA: 0x00759A80 File Offset: 0x00757C80
		public static ITraceTracingMaxStepRewardRuleItem GetRootAsITraceTracingMaxStepRewardRuleItem(ByteBuffer _bb)
		{
			return ITraceTracingMaxStepRewardRuleItem.GetRootAsITraceTracingMaxStepRewardRuleItem(_bb, default(ITraceTracingMaxStepRewardRuleItem));
		}

		// Token: 0x06036097 RID: 221335 RVA: 0x00759A9C File Offset: 0x00757C9C
		public static ITraceTracingMaxStepRewardRuleItem GetRootAsITraceTracingMaxStepRewardRuleItem(ByteBuffer _bb, ITraceTracingMaxStepRewardRuleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036098 RID: 221336 RVA: 0x00759AB9 File Offset: 0x00757CB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036099 RID: 221337 RVA: 0x00759AC8 File Offset: 0x00757CC8
		public ITraceTracingMaxStepRewardRuleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1DA RID: 57818
		// (get) Token: 0x0603609A RID: 221338 RVA: 0x00759AD8 File Offset: 0x00757CD8
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

		// Token: 0x1700E1DB RID: 57819
		// (get) Token: 0x0603609B RID: 221339 RVA: 0x00759B14 File Offset: 0x00757D14
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

		// Token: 0x0603609C RID: 221340 RVA: 0x00759B50 File Offset: 0x00757D50
		public static Offset<ITraceTracingMaxStepRewardRuleItem> CreateITraceTracingMaxStepRewardRuleItem(FlatBufferBuilder builder, int RestartCount = 0, int AddStep = 0)
		{
			builder.StartTable(2);
			ITraceTracingMaxStepRewardRuleItem.AddAddStep(builder, AddStep);
			ITraceTracingMaxStepRewardRuleItem.AddRestartCount(builder, RestartCount);
			return ITraceTracingMaxStepRewardRuleItem.EndITraceTracingMaxStepRewardRuleItem(builder);
		}

		// Token: 0x0603609D RID: 221341 RVA: 0x00759B6D File Offset: 0x00757D6D
		public static void StartITraceTracingMaxStepRewardRuleItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603609E RID: 221342 RVA: 0x00759B76 File Offset: 0x00757D76
		public static void AddRestartCount(FlatBufferBuilder builder, int restartCount)
		{
			builder.AddInt(0, restartCount, 0);
		}

		// Token: 0x0603609F RID: 221343 RVA: 0x00759B81 File Offset: 0x00757D81
		public static void AddAddStep(FlatBufferBuilder builder, int addStep)
		{
			builder.AddInt(1, addStep, 0);
		}

		// Token: 0x060360A0 RID: 221344 RVA: 0x00759B8C File Offset: 0x00757D8C
		public static Offset<ITraceTracingMaxStepRewardRuleItem> EndITraceTracingMaxStepRewardRuleItem(FlatBufferBuilder builder)
		{
			return new Offset<ITraceTracingMaxStepRewardRuleItem>(builder.EndTable());
		}

		// Token: 0x060360A1 RID: 221345 RVA: 0x00759B9C File Offset: 0x00757D9C
		public ITraceTracingMaxStepRewardRuleItemT UnPack()
		{
			ITraceTracingMaxStepRewardRuleItemT traceTracingMaxStepRewardRuleItemT = new ITraceTracingMaxStepRewardRuleItemT();
			this.UnPackTo(traceTracingMaxStepRewardRuleItemT);
			return traceTracingMaxStepRewardRuleItemT;
		}

		// Token: 0x060360A2 RID: 221346 RVA: 0x00759BB7 File Offset: 0x00757DB7
		public void UnPackTo(ITraceTracingMaxStepRewardRuleItemT _o)
		{
			_o.RestartCount = this.RestartCount;
			_o.AddStep = this.AddStep;
		}

		// Token: 0x060360A3 RID: 221347 RVA: 0x00759BD4 File Offset: 0x00757DD4
		public static Offset<ITraceTracingMaxStepRewardRuleItem> Pack(FlatBufferBuilder builder, ITraceTracingMaxStepRewardRuleItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITraceTracingMaxStepRewardRuleItem>);
			}
			return ITraceTracingMaxStepRewardRuleItem.CreateITraceTracingMaxStepRewardRuleItem(builder, _o.RestartCount, _o.AddStep);
		}

		// Token: 0x040122A9 RID: 74409
		private Table __p;
	}
}
