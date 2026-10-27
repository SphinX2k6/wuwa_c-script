using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067DA RID: 26586
	public struct IFixShowTargetRange : IFlatbufferObject
	{
		// Token: 0x1700C557 RID: 50519
		// (get) Token: 0x0602E482 RID: 189570 RVA: 0x00651D7F File Offset: 0x0064FF7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E483 RID: 189571 RVA: 0x00651D8C File Offset: 0x0064FF8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E484 RID: 189572 RVA: 0x00651D94 File Offset: 0x0064FF94
		public static IFixShowTargetRange GetRootAsIFixShowTargetRange(ByteBuffer _bb)
		{
			return IFixShowTargetRange.GetRootAsIFixShowTargetRange(_bb, default(IFixShowTargetRange));
		}

		// Token: 0x0602E485 RID: 189573 RVA: 0x00651DB0 File Offset: 0x0064FFB0
		public static IFixShowTargetRange GetRootAsIFixShowTargetRange(ByteBuffer _bb, IFixShowTargetRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E486 RID: 189574 RVA: 0x00651DCD File Offset: 0x0064FFCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E487 RID: 189575 RVA: 0x00651DDC File Offset: 0x0064FFDC
		public IFixShowTargetRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E488 RID: 189576 RVA: 0x00651DEC File Offset: 0x0064FFEC
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C558 RID: 50520
		// (get) Token: 0x0602E489 RID: 189577 RVA: 0x00651E2C File Offset: 0x0065002C
		public int RangeEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602E48A RID: 189578 RVA: 0x00651E57 File Offset: 0x00650057
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602E48B RID: 189579 RVA: 0x00651E66 File Offset: 0x00650066
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700C559 RID: 50521
		// (get) Token: 0x0602E48C RID: 189580 RVA: 0x00651E74 File Offset: 0x00650074
		public bool DelayShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602E48D RID: 189581 RVA: 0x00651EB3 File Offset: 0x006500B3
		public static Offset<IFixShowTargetRange> CreateIFixShowTargetRange(FlatBufferBuilder builder, VectorOffset RangeEntitiesOffset = default(VectorOffset), bool DelayShow = false)
		{
			builder.StartTable(2);
			IFixShowTargetRange.AddRangeEntities(builder, RangeEntitiesOffset);
			IFixShowTargetRange.AddDelayShow(builder, DelayShow);
			return IFixShowTargetRange.EndIFixShowTargetRange(builder);
		}

		// Token: 0x0602E48E RID: 189582 RVA: 0x00651ED0 File Offset: 0x006500D0
		public static void StartIFixShowTargetRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E48F RID: 189583 RVA: 0x00651ED9 File Offset: 0x006500D9
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(0, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0602E490 RID: 189584 RVA: 0x00651EEC File Offset: 0x006500EC
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E491 RID: 189585 RVA: 0x00651F23 File Offset: 0x00650123
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E492 RID: 189586 RVA: 0x00651F3D File Offset: 0x0065013D
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E493 RID: 189587 RVA: 0x00651F5B File Offset: 0x0065015B
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E494 RID: 189588 RVA: 0x00651F74 File Offset: 0x00650174
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E495 RID: 189589 RVA: 0x00651F7F File Offset: 0x0065017F
		public static void AddDelayShow(FlatBufferBuilder builder, bool delayShow)
		{
			builder.AddBool(1, delayShow, false);
		}

		// Token: 0x0602E496 RID: 189590 RVA: 0x00651F8A File Offset: 0x0065018A
		public static Offset<IFixShowTargetRange> EndIFixShowTargetRange(FlatBufferBuilder builder)
		{
			return new Offset<IFixShowTargetRange>(builder.EndTable());
		}

		// Token: 0x0602E497 RID: 189591 RVA: 0x00651F98 File Offset: 0x00650198
		public IFixShowTargetRangeT UnPack()
		{
			IFixShowTargetRangeT fixShowTargetRangeT = new IFixShowTargetRangeT();
			this.UnPackTo(fixShowTargetRangeT);
			return fixShowTargetRangeT;
		}

		// Token: 0x0602E498 RID: 189592 RVA: 0x00651FB4 File Offset: 0x006501B4
		public void UnPackTo(IFixShowTargetRangeT _o)
		{
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.DelayShow = this.DelayShow;
		}

		// Token: 0x0602E499 RID: 189593 RVA: 0x00651FFC File Offset: 0x006501FC
		public static Offset<IFixShowTargetRange> Pack(FlatBufferBuilder builder, IFixShowTargetRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixShowTargetRange>);
			}
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IFixShowTargetRange.CreateRangeEntitiesVector(builder, data);
			}
			return IFixShowTargetRange.CreateIFixShowTargetRange(builder, rangeEntitiesOffset, _o.DelayShow);
		}

		// Token: 0x04010EF5 RID: 69365
		private Table __p;
	}
}
