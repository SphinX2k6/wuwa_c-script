using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200622D RID: 25133
	public struct IBubbleData : IFlatbufferObject
	{
		// Token: 0x1700BB44 RID: 47940
		// (get) Token: 0x0602B524 RID: 177444 RVA: 0x005F71E6 File Offset: 0x005F53E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B525 RID: 177445 RVA: 0x005F71F3 File Offset: 0x005F53F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B526 RID: 177446 RVA: 0x005F71FC File Offset: 0x005F53FC
		public static IBubbleData GetRootAsIBubbleData(ByteBuffer _bb)
		{
			return IBubbleData.GetRootAsIBubbleData(_bb, default(IBubbleData));
		}

		// Token: 0x0602B527 RID: 177447 RVA: 0x005F7218 File Offset: 0x005F5418
		public static IBubbleData GetRootAsIBubbleData(ByteBuffer _bb, IBubbleData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B528 RID: 177448 RVA: 0x005F7235 File Offset: 0x005F5435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B529 RID: 177449 RVA: 0x005F7244 File Offset: 0x005F5444
		public IBubbleData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB45 RID: 47941
		// (get) Token: 0x0602B52A RID: 177450 RVA: 0x005F7254 File Offset: 0x005F5454
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

		// Token: 0x1700BB46 RID: 47942
		// (get) Token: 0x0602B52B RID: 177451 RVA: 0x005F72B4 File Offset: 0x005F54B4
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

		// Token: 0x0602B52C RID: 177452 RVA: 0x005F72F0 File Offset: 0x005F54F0
		public static Offset<IBubbleData> CreateIBubbleData(FlatBufferBuilder builder, Offset<IBubbleIndex> FlowIndexOffset = default(Offset<IBubbleIndex>), int WaitTime = 0)
		{
			builder.StartTable(2);
			IBubbleData.AddWaitTime(builder, WaitTime);
			IBubbleData.AddFlowIndex(builder, FlowIndexOffset);
			return IBubbleData.EndIBubbleData(builder);
		}

		// Token: 0x0602B52D RID: 177453 RVA: 0x005F730D File Offset: 0x005F550D
		public static void StartIBubbleData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B52E RID: 177454 RVA: 0x005F7316 File Offset: 0x005F5516
		public static void AddFlowIndex(FlatBufferBuilder builder, Offset<IBubbleIndex> flowIndexOffset)
		{
			builder.AddOffset(0, flowIndexOffset.Value, 0);
		}

		// Token: 0x0602B52F RID: 177455 RVA: 0x005F7326 File Offset: 0x005F5526
		public static void AddWaitTime(FlatBufferBuilder builder, int waitTime)
		{
			builder.AddInt(1, waitTime, 0);
		}

		// Token: 0x0602B530 RID: 177456 RVA: 0x005F7331 File Offset: 0x005F5531
		public static Offset<IBubbleData> EndIBubbleData(FlatBufferBuilder builder)
		{
			return new Offset<IBubbleData>(builder.EndTable());
		}

		// Token: 0x0602B531 RID: 177457 RVA: 0x005F7340 File Offset: 0x005F5540
		public IBubbleDataT UnPack()
		{
			IBubbleDataT bubbleDataT = new IBubbleDataT();
			this.UnPackTo(bubbleDataT);
			return bubbleDataT;
		}

		// Token: 0x0602B532 RID: 177458 RVA: 0x005F735C File Offset: 0x005F555C
		public void UnPackTo(IBubbleDataT _o)
		{
			_o.FlowIndex = ((this.FlowIndex != null) ? this.FlowIndex.Value.UnPack() : null);
			_o.WaitTime = this.WaitTime;
		}

		// Token: 0x0602B533 RID: 177459 RVA: 0x005F73A4 File Offset: 0x005F55A4
		public static Offset<IBubbleData> Pack(FlatBufferBuilder builder, IBubbleDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBubbleData>);
			}
			Offset<IBubbleIndex> flowIndexOffset = (_o.FlowIndex == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.FlowIndex);
			return IBubbleData.CreateIBubbleData(builder, flowIndexOffset, _o.WaitTime);
		}

		// Token: 0x04010770 RID: 67440
		private Table __p;
	}
}
