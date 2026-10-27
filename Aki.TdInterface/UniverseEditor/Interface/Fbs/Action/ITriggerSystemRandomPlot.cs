using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200748D RID: 29837
	public struct ITriggerSystemRandomPlot : IFlatbufferObject
	{
		// Token: 0x1700E280 RID: 57984
		// (get) Token: 0x06036392 RID: 222098 RVA: 0x0075F201 File Offset: 0x0075D401
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036393 RID: 222099 RVA: 0x0075F20E File Offset: 0x0075D40E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036394 RID: 222100 RVA: 0x0075F218 File Offset: 0x0075D418
		public static ITriggerSystemRandomPlot GetRootAsITriggerSystemRandomPlot(ByteBuffer _bb)
		{
			return ITriggerSystemRandomPlot.GetRootAsITriggerSystemRandomPlot(_bb, default(ITriggerSystemRandomPlot));
		}

		// Token: 0x06036395 RID: 222101 RVA: 0x0075F234 File Offset: 0x0075D434
		public static ITriggerSystemRandomPlot GetRootAsITriggerSystemRandomPlot(ByteBuffer _bb, ITriggerSystemRandomPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036396 RID: 222102 RVA: 0x0075F251 File Offset: 0x0075D451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036397 RID: 222103 RVA: 0x0075F260 File Offset: 0x0075D460
		public ITriggerSystemRandomPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E281 RID: 57985
		// (get) Token: 0x06036398 RID: 222104 RVA: 0x0075F270 File Offset: 0x0075D470
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

		// Token: 0x06036399 RID: 222105 RVA: 0x0075F2AC File Offset: 0x0075D4AC
		public static Offset<ITriggerSystemRandomPlot> CreateITriggerSystemRandomPlot(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			ITriggerSystemRandomPlot.AddId(builder, Id);
			return ITriggerSystemRandomPlot.EndITriggerSystemRandomPlot(builder);
		}

		// Token: 0x0603639A RID: 222106 RVA: 0x0075F2C2 File Offset: 0x0075D4C2
		public static void StartITriggerSystemRandomPlot(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603639B RID: 222107 RVA: 0x0075F2CB File Offset: 0x0075D4CB
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0603639C RID: 222108 RVA: 0x0075F2D6 File Offset: 0x0075D4D6
		public static Offset<ITriggerSystemRandomPlot> EndITriggerSystemRandomPlot(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerSystemRandomPlot>(builder.EndTable());
		}

		// Token: 0x0603639D RID: 222109 RVA: 0x0075F2E4 File Offset: 0x0075D4E4
		public ITriggerSystemRandomPlotT UnPack()
		{
			ITriggerSystemRandomPlotT triggerSystemRandomPlotT = new ITriggerSystemRandomPlotT();
			this.UnPackTo(triggerSystemRandomPlotT);
			return triggerSystemRandomPlotT;
		}

		// Token: 0x0603639E RID: 222110 RVA: 0x0075F2FF File Offset: 0x0075D4FF
		public void UnPackTo(ITriggerSystemRandomPlotT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x0603639F RID: 222111 RVA: 0x0075F310 File Offset: 0x0075D510
		public static Offset<ITriggerSystemRandomPlot> Pack(FlatBufferBuilder builder, ITriggerSystemRandomPlotT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerSystemRandomPlot>);
			}
			return ITriggerSystemRandomPlot.CreateITriggerSystemRandomPlot(builder, _o.Id);
		}

		// Token: 0x04012323 RID: 74531
		private Table __p;
	}
}
