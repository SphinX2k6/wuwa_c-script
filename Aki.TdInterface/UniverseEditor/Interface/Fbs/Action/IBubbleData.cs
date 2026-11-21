using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200689E RID: 26782
	public struct IBubbleData : IFlatbufferObject
	{
		// Token: 0x1700C4CC RID: 50380
		// (get) Token: 0x0602DC85 RID: 187525 RVA: 0x00641FEE File Offset: 0x006401EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC86 RID: 187526 RVA: 0x00641FFB File Offset: 0x006401FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC87 RID: 187527 RVA: 0x00642004 File Offset: 0x00640204
		public static IBubbleData GetRootAsIBubbleData(ByteBuffer _bb)
		{
			return IBubbleData.GetRootAsIBubbleData(_bb, default(IBubbleData));
		}

		// Token: 0x0602DC88 RID: 187528 RVA: 0x00642020 File Offset: 0x00640220
		public static IBubbleData GetRootAsIBubbleData(ByteBuffer _bb, IBubbleData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC89 RID: 187529 RVA: 0x0064203D File Offset: 0x0064023D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC8A RID: 187530 RVA: 0x0064204C File Offset: 0x0064024C
		public IBubbleData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4CD RID: 50381
		// (get) Token: 0x0602DC8B RID: 187531 RVA: 0x0064205C File Offset: 0x0064025C
		public IBubbleIndex? FlowIndex
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleIndex?(default(IBubbleIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C4CE RID: 50382
		// (get) Token: 0x0602DC8C RID: 187532 RVA: 0x006420BC File Offset: 0x006402BC
		public int WaitTime
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

		// Token: 0x0602DC8D RID: 187533 RVA: 0x006420F8 File Offset: 0x006402F8
		public static Offset<IBubbleData> CreateIBubbleData(FlatBufferBuilder builder, Offset<IBubbleIndex> FlowIndexOffset = default(Offset<IBubbleIndex>), int WaitTime = 0)
		{
			builder.StartTable(2);
			IBubbleData.AddWaitTime(builder, WaitTime);
			IBubbleData.AddFlowIndex(builder, FlowIndexOffset);
			return IBubbleData.EndIBubbleData(builder);
		}

		// Token: 0x0602DC8E RID: 187534 RVA: 0x00642115 File Offset: 0x00640315
		public static void StartIBubbleData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DC8F RID: 187535 RVA: 0x0064211E File Offset: 0x0064031E
		public static void AddFlowIndex(FlatBufferBuilder builder, Offset<IBubbleIndex> flowIndexOffset)
		{
			builder.AddOffset(0, flowIndexOffset.Value, 0);
		}

		// Token: 0x0602DC90 RID: 187536 RVA: 0x0064212E File Offset: 0x0064032E
		public static void AddWaitTime(FlatBufferBuilder builder, int waitTime)
		{
			builder.AddInt(1, waitTime, 0);
		}

		// Token: 0x0602DC91 RID: 187537 RVA: 0x00642139 File Offset: 0x00640339
		public static Offset<IBubbleData> EndIBubbleData(FlatBufferBuilder builder)
		{
			return new Offset<IBubbleData>(builder.EndTable());
		}

		// Token: 0x0602DC92 RID: 187538 RVA: 0x00642148 File Offset: 0x00640348
		public IBubbleDataT UnPack()
		{
			IBubbleDataT bubbleDataT = new IBubbleDataT();
			this.UnPackTo(bubbleDataT);
			return bubbleDataT;
		}

		// Token: 0x0602DC93 RID: 187539 RVA: 0x00642164 File Offset: 0x00640364
		public void UnPackTo(IBubbleDataT _o)
		{
			_o.FlowIndex = ((this.FlowIndex != null) ? this.FlowIndex.Value.UnPack() : null);
			_o.WaitTime = this.WaitTime;
		}

		// Token: 0x0602DC94 RID: 187540 RVA: 0x006421AC File Offset: 0x006403AC
		public static Offset<IBubbleData> Pack(FlatBufferBuilder builder, IBubbleDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBubbleData>);
			}
			Offset<IBubbleIndex> flowIndexOffset = (_o.FlowIndex == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.FlowIndex);
			return IBubbleData.CreateIBubbleData(builder, flowIndexOffset, _o.WaitTime);
		}

		// Token: 0x04011585 RID: 71045
		private Table __p;
	}
}
