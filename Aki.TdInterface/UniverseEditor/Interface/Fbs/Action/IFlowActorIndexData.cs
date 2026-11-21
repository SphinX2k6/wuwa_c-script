using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E6F RID: 28271
	public struct IFlowActorIndexData : IFlatbufferObject
	{
		// Token: 0x1700CF2E RID: 53038
		// (get) Token: 0x06030D6F RID: 200047 RVA: 0x006A0520 File Offset: 0x0069E720
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030D70 RID: 200048 RVA: 0x006A052D File Offset: 0x0069E72D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030D71 RID: 200049 RVA: 0x006A0534 File Offset: 0x0069E734
		public static IFlowActorIndexData GetRootAsIFlowActorIndexData(ByteBuffer _bb)
		{
			return IFlowActorIndexData.GetRootAsIFlowActorIndexData(_bb, default(IFlowActorIndexData));
		}

		// Token: 0x06030D72 RID: 200050 RVA: 0x006A0550 File Offset: 0x0069E750
		public static IFlowActorIndexData GetRootAsIFlowActorIndexData(ByteBuffer _bb, IFlowActorIndexData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030D73 RID: 200051 RVA: 0x006A056D File Offset: 0x0069E76D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030D74 RID: 200052 RVA: 0x006A057C File Offset: 0x0069E77C
		public IFlowActorIndexData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF2F RID: 53039
		// (get) Token: 0x06030D75 RID: 200053 RVA: 0x006A058C File Offset: 0x0069E78C
		public int Index
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

		// Token: 0x1700CF30 RID: 53040
		// (get) Token: 0x06030D76 RID: 200054 RVA: 0x006A05C8 File Offset: 0x0069E7C8
		public IPosAndRot? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosAndRot?(default(IPosAndRot).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CF31 RID: 53041
		// (get) Token: 0x06030D77 RID: 200055 RVA: 0x006A0628 File Offset: 0x0069E828
		public bool IsUseFixedPosition
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF32 RID: 53042
		// (get) Token: 0x06030D78 RID: 200056 RVA: 0x006A0668 File Offset: 0x0069E868
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

		// Token: 0x06030D79 RID: 200057 RVA: 0x006A06A5 File Offset: 0x0069E8A5
		public static Offset<IFlowActorIndexData> CreateIFlowActorIndexData(FlatBufferBuilder builder, int Index = 0, Offset<IPosAndRot> OffsetOffset = default(Offset<IPosAndRot>), bool IsUseFixedPosition = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFlowActorIndexData.AddOffset(builder, OffsetOffset);
			IFlowActorIndexData.AddIndex(builder, Index);
			IFlowActorIndexData.AddNullMask(builder, NullMask);
			IFlowActorIndexData.AddIsUseFixedPosition(builder, IsUseFixedPosition);
			return IFlowActorIndexData.EndIFlowActorIndexData(builder);
		}

		// Token: 0x06030D7A RID: 200058 RVA: 0x006A06D1 File Offset: 0x0069E8D1
		public static void StartIFlowActorIndexData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030D7B RID: 200059 RVA: 0x006A06DA File Offset: 0x0069E8DA
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		// Token: 0x06030D7C RID: 200060 RVA: 0x006A06E5 File Offset: 0x0069E8E5
		public static void AddOffset(FlatBufferBuilder builder, Offset<IPosAndRot> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x06030D7D RID: 200061 RVA: 0x006A06F5 File Offset: 0x0069E8F5
		public static void AddIsUseFixedPosition(FlatBufferBuilder builder, bool isUseFixedPosition)
		{
			builder.AddBool(2, isUseFixedPosition, false);
		}

		// Token: 0x06030D7E RID: 200062 RVA: 0x006A0700 File Offset: 0x0069E900
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06030D7F RID: 200063 RVA: 0x006A070B File Offset: 0x0069E90B
		public static Offset<IFlowActorIndexData> EndIFlowActorIndexData(FlatBufferBuilder builder)
		{
			return new Offset<IFlowActorIndexData>(builder.EndTable());
		}

		// Token: 0x06030D80 RID: 200064 RVA: 0x006A0718 File Offset: 0x0069E918
		public IFlowActorIndexDataT UnPack()
		{
			IFlowActorIndexDataT flowActorIndexDataT = new IFlowActorIndexDataT();
			this.UnPackTo(flowActorIndexDataT);
			return flowActorIndexDataT;
		}

		// Token: 0x06030D81 RID: 200065 RVA: 0x006A0734 File Offset: 0x0069E934
		public void UnPackTo(IFlowActorIndexDataT _o)
		{
			_o.Index = this.Index;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.IsUseFixedPosition = this.IsUseFixedPosition;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030D82 RID: 200066 RVA: 0x006A0794 File Offset: 0x0069E994
		public static Offset<IFlowActorIndexData> Pack(FlatBufferBuilder builder, IFlowActorIndexDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowActorIndexData>);
			}
			Offset<IPosAndRot> offsetOffset = (_o.Offset == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.Offset);
			return IFlowActorIndexData.CreateIFlowActorIndexData(builder, _o.Index, offsetOffset, _o.IsUseFixedPosition, _o.NullMask);
		}

		// Token: 0x04011D3B RID: 73019
		private Table __p;
	}
}
