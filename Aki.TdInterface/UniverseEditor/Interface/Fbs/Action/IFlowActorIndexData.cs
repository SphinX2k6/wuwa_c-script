using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067EF RID: 26607
	public struct IFlowActorIndexData : IFlatbufferObject
	{
		// Token: 0x1700C578 RID: 50552
		// (get) Token: 0x0602E529 RID: 189737 RVA: 0x00652DDC File Offset: 0x00650FDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E52A RID: 189738 RVA: 0x00652DE9 File Offset: 0x00650FE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E52B RID: 189739 RVA: 0x00652DF0 File Offset: 0x00650FF0
		public static IFlowActorIndexData GetRootAsIFlowActorIndexData(ByteBuffer _bb)
		{
			return IFlowActorIndexData.GetRootAsIFlowActorIndexData(_bb, default(IFlowActorIndexData));
		}

		// Token: 0x0602E52C RID: 189740 RVA: 0x00652E0C File Offset: 0x0065100C
		public static IFlowActorIndexData GetRootAsIFlowActorIndexData(ByteBuffer _bb, IFlowActorIndexData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E52D RID: 189741 RVA: 0x00652E29 File Offset: 0x00651029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E52E RID: 189742 RVA: 0x00652E38 File Offset: 0x00651038
		public IFlowActorIndexData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C579 RID: 50553
		// (get) Token: 0x0602E52F RID: 189743 RVA: 0x00652E48 File Offset: 0x00651048
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

		// Token: 0x1700C57A RID: 50554
		// (get) Token: 0x0602E530 RID: 189744 RVA: 0x00652E84 File Offset: 0x00651084
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

		// Token: 0x1700C57B RID: 50555
		// (get) Token: 0x0602E531 RID: 189745 RVA: 0x00652EE4 File Offset: 0x006510E4
		public bool IsUseFixedPosition
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C57C RID: 50556
		// (get) Token: 0x0602E532 RID: 189746 RVA: 0x00652F24 File Offset: 0x00651124
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

		// Token: 0x0602E533 RID: 189747 RVA: 0x00652F61 File Offset: 0x00651161
		public static Offset<IFlowActorIndexData> CreateIFlowActorIndexData(FlatBufferBuilder builder, int Index = 0, Offset<IPosAndRot> OffsetOffset = default(Offset<IPosAndRot>), bool IsUseFixedPosition = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFlowActorIndexData.AddOffset(builder, OffsetOffset);
			IFlowActorIndexData.AddIndex(builder, Index);
			IFlowActorIndexData.AddNullMask(builder, NullMask);
			IFlowActorIndexData.AddIsUseFixedPosition(builder, IsUseFixedPosition);
			return IFlowActorIndexData.EndIFlowActorIndexData(builder);
		}

		// Token: 0x0602E534 RID: 189748 RVA: 0x00652F8D File Offset: 0x0065118D
		public static void StartIFlowActorIndexData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E535 RID: 189749 RVA: 0x00652F96 File Offset: 0x00651196
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		// Token: 0x0602E536 RID: 189750 RVA: 0x00652FA1 File Offset: 0x006511A1
		public static void AddOffset(FlatBufferBuilder builder, Offset<IPosAndRot> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x0602E537 RID: 189751 RVA: 0x00652FB1 File Offset: 0x006511B1
		public static void AddIsUseFixedPosition(FlatBufferBuilder builder, bool isUseFixedPosition)
		{
			builder.AddBool(2, isUseFixedPosition, false);
		}

		// Token: 0x0602E538 RID: 189752 RVA: 0x00652FBC File Offset: 0x006511BC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602E539 RID: 189753 RVA: 0x00652FC7 File Offset: 0x006511C7
		public static Offset<IFlowActorIndexData> EndIFlowActorIndexData(FlatBufferBuilder builder)
		{
			return new Offset<IFlowActorIndexData>(builder.EndTable());
		}

		// Token: 0x0602E53A RID: 189754 RVA: 0x00652FD4 File Offset: 0x006511D4
		public IFlowActorIndexDataT UnPack()
		{
			IFlowActorIndexDataT flowActorIndexDataT = new IFlowActorIndexDataT();
			this.UnPackTo(flowActorIndexDataT);
			return flowActorIndexDataT;
		}

		// Token: 0x0602E53B RID: 189755 RVA: 0x00652FF0 File Offset: 0x006511F0
		public void UnPackTo(IFlowActorIndexDataT _o)
		{
			_o.Index = this.Index;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.IsUseFixedPosition = this.IsUseFixedPosition;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E53C RID: 189756 RVA: 0x00653050 File Offset: 0x00651250
		public static Offset<IFlowActorIndexData> Pack(FlatBufferBuilder builder, IFlowActorIndexDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowActorIndexData>);
			}
			Offset<IPosAndRot> offsetOffset = (_o.Offset == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.Offset);
			return IFlowActorIndexData.CreateIFlowActorIndexData(builder, _o.Index, offsetOffset, _o.IsUseFixedPosition, _o.NullMask);
		}

		// Token: 0x04010F09 RID: 69385
		private Table __p;
	}
}
