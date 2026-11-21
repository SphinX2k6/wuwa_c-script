using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C80 RID: 31872
	public struct ITriggerSystemRandomPlot : IFlatbufferObject
	{
		// Token: 0x1700EE9F RID: 61087
		// (get) Token: 0x0603977F RID: 235391 RVA: 0x007C1FBD File Offset: 0x007C01BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039780 RID: 235392 RVA: 0x007C1FCA File Offset: 0x007C01CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039781 RID: 235393 RVA: 0x007C1FD4 File Offset: 0x007C01D4
		public static ITriggerSystemRandomPlot GetRootAsITriggerSystemRandomPlot(ByteBuffer _bb)
		{
			return ITriggerSystemRandomPlot.GetRootAsITriggerSystemRandomPlot(_bb, default(ITriggerSystemRandomPlot));
		}

		// Token: 0x06039782 RID: 235394 RVA: 0x007C1FF0 File Offset: 0x007C01F0
		public static ITriggerSystemRandomPlot GetRootAsITriggerSystemRandomPlot(ByteBuffer _bb, ITriggerSystemRandomPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039783 RID: 235395 RVA: 0x007C200D File Offset: 0x007C020D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039784 RID: 235396 RVA: 0x007C201C File Offset: 0x007C021C
		public ITriggerSystemRandomPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EEA0 RID: 61088
		// (get) Token: 0x06039785 RID: 235397 RVA: 0x007C202C File Offset: 0x007C022C
		public int Id
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

		// Token: 0x06039786 RID: 235398 RVA: 0x007C2068 File Offset: 0x007C0268
		public static Offset<ITriggerSystemRandomPlot> CreateITriggerSystemRandomPlot(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			ITriggerSystemRandomPlot.AddId(builder, Id);
			return ITriggerSystemRandomPlot.EndITriggerSystemRandomPlot(builder);
		}

		// Token: 0x06039787 RID: 235399 RVA: 0x007C207E File Offset: 0x007C027E
		public static void StartITriggerSystemRandomPlot(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039788 RID: 235400 RVA: 0x007C2087 File Offset: 0x007C0287
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06039789 RID: 235401 RVA: 0x007C2092 File Offset: 0x007C0292
		public static Offset<ITriggerSystemRandomPlot> EndITriggerSystemRandomPlot(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerSystemRandomPlot>(builder.EndTable());
		}

		// Token: 0x0603978A RID: 235402 RVA: 0x007C20A0 File Offset: 0x007C02A0
		public ITriggerSystemRandomPlotT UnPack()
		{
			ITriggerSystemRandomPlotT triggerSystemRandomPlotT = new ITriggerSystemRandomPlotT();
			this.UnPackTo(triggerSystemRandomPlotT);
			return triggerSystemRandomPlotT;
		}

		// Token: 0x0603978B RID: 235403 RVA: 0x007C20BB File Offset: 0x007C02BB
		public void UnPackTo(ITriggerSystemRandomPlotT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x0603978C RID: 235404 RVA: 0x007C20CC File Offset: 0x007C02CC
		public static Offset<ITriggerSystemRandomPlot> Pack(FlatBufferBuilder builder, ITriggerSystemRandomPlotT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerSystemRandomPlot>);
			}
			return ITriggerSystemRandomPlot.CreateITriggerSystemRandomPlot(builder, _o.Id);
		}

		// Token: 0x0401334B RID: 78667
		private Table __p;
	}
}
