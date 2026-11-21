using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004806 RID: 18438
	public struct INodeRefOccupationData : IFlatbufferObject
	{
		// Token: 0x17008097 RID: 32919
		// (get) Token: 0x0601B3F1 RID: 111601 RVA: 0x003DC3E1 File Offset: 0x003DA5E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B3F2 RID: 111602 RVA: 0x003DC3EE File Offset: 0x003DA5EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B3F3 RID: 111603 RVA: 0x003DC3F8 File Offset: 0x003DA5F8
		public static INodeRefOccupationData GetRootAsINodeRefOccupationData(ByteBuffer _bb)
		{
			return INodeRefOccupationData.GetRootAsINodeRefOccupationData(_bb, default(INodeRefOccupationData));
		}

		// Token: 0x0601B3F4 RID: 111604 RVA: 0x003DC414 File Offset: 0x003DA614
		public static INodeRefOccupationData GetRootAsINodeRefOccupationData(ByteBuffer _bb, INodeRefOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B3F5 RID: 111605 RVA: 0x003DC431 File Offset: 0x003DA631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B3F6 RID: 111606 RVA: 0x003DC440 File Offset: 0x003DA640
		public INodeRefOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008098 RID: 32920
		// (get) Token: 0x0601B3F7 RID: 111607 RVA: 0x003DC450 File Offset: 0x003DA650
		public TNodeRefTiming NodeRefTiming
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TNodeRefTiming.Enter;
				}
				return (TNodeRefTiming)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008099 RID: 32921
		// (get) Token: 0x0601B3F8 RID: 111608 RVA: 0x003DC48C File Offset: 0x003DA68C
		public TRefType RefType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TRefType.Release;
				}
				return (TRefType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700809A RID: 32922
		// (get) Token: 0x0601B3F9 RID: 111609 RVA: 0x003DC4C8 File Offset: 0x003DA6C8
		public TRefSourceData RefSourceType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TRefSourceData.NONE;
				}
				return (TRefSourceData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B3FA RID: 111610 RVA: 0x003DC504 File Offset: 0x003DA704
		public TTable? RefSource<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601B3FB RID: 111611 RVA: 0x003DC54C File Offset: 0x003DA74C
		public IAwakeEntityRefSource RefSourceAsIAwakeEntityRefSource()
		{
			return this.RefSource<IAwakeEntityRefSource>().Value;
		}

		// Token: 0x0601B3FC RID: 111612 RVA: 0x003DC568 File Offset: 0x003DA768
		public IDestroyEntityRefSource RefSourceAsIDestroyEntityRefSource()
		{
			return this.RefSource<IDestroyEntityRefSource>().Value;
		}

		// Token: 0x0601B3FD RID: 111613 RVA: 0x003DC584 File Offset: 0x003DA784
		public IManualOccupationRefSource RefSourceAsIManualOccupationRefSource()
		{
			return this.RefSource<IManualOccupationRefSource>().Value;
		}

		// Token: 0x1700809B RID: 32923
		// (get) Token: 0x0601B3FE RID: 111614 RVA: 0x003DC5A0 File Offset: 0x003DA7A0
		public string Occupation
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B3FF RID: 111615 RVA: 0x003DC5D8 File Offset: 0x003DA7D8
		public Span<byte> GetOccupationBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601B400 RID: 111616 RVA: 0x003DC5E8 File Offset: 0x003DA7E8
		public byte[] GetOccupationArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700809C RID: 32924
		// (get) Token: 0x0601B401 RID: 111617 RVA: 0x003DC5F8 File Offset: 0x003DA7F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B402 RID: 111618 RVA: 0x003DC635 File Offset: 0x003DA835
		public static Offset<INodeRefOccupationData> CreateINodeRefOccupationData(FlatBufferBuilder builder, TNodeRefTiming NodeRefTiming = TNodeRefTiming.Enter, TRefType RefType = TRefType.Release, TRefSourceData RefSource_type = TRefSourceData.NONE, int RefSourceOffset = 0, StringOffset OccupationOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			INodeRefOccupationData.AddOccupation(builder, OccupationOffset);
			INodeRefOccupationData.AddRefSource(builder, RefSourceOffset);
			INodeRefOccupationData.AddNullMask(builder, NullMask);
			INodeRefOccupationData.AddRefSourceType(builder, RefSource_type);
			INodeRefOccupationData.AddRefType(builder, RefType);
			INodeRefOccupationData.AddNodeRefTiming(builder, NodeRefTiming);
			return INodeRefOccupationData.EndINodeRefOccupationData(builder);
		}

		// Token: 0x0601B403 RID: 111619 RVA: 0x003DC671 File Offset: 0x003DA871
		public static void StartINodeRefOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601B404 RID: 111620 RVA: 0x003DC67A File Offset: 0x003DA87A
		public static void AddNodeRefTiming(FlatBufferBuilder builder, TNodeRefTiming nodeRefTiming)
		{
			builder.AddByte(0, (byte)nodeRefTiming, 0);
		}

		// Token: 0x0601B405 RID: 111621 RVA: 0x003DC685 File Offset: 0x003DA885
		public static void AddRefType(FlatBufferBuilder builder, TRefType refType)
		{
			builder.AddByte(1, (byte)refType, 0);
		}

		// Token: 0x0601B406 RID: 111622 RVA: 0x003DC690 File Offset: 0x003DA890
		public static void AddRefSourceType(FlatBufferBuilder builder, TRefSourceData refSourceType)
		{
			builder.AddByte(2, (byte)refSourceType, 0);
		}

		// Token: 0x0601B407 RID: 111623 RVA: 0x003DC69B File Offset: 0x003DA89B
		public static void AddRefSource(FlatBufferBuilder builder, int refSourceOffset)
		{
			builder.AddOffset(3, refSourceOffset, 0);
		}

		// Token: 0x0601B408 RID: 111624 RVA: 0x003DC6A6 File Offset: 0x003DA8A6
		public static void AddOccupation(FlatBufferBuilder builder, StringOffset occupationOffset)
		{
			builder.AddOffset(4, occupationOffset.Value, 0);
		}

		// Token: 0x0601B409 RID: 111625 RVA: 0x003DC6B6 File Offset: 0x003DA8B6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601B40A RID: 111626 RVA: 0x003DC6C1 File Offset: 0x003DA8C1
		public static Offset<INodeRefOccupationData> EndINodeRefOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<INodeRefOccupationData>(builder.EndTable());
		}

		// Token: 0x0601B40B RID: 111627 RVA: 0x003DC6D0 File Offset: 0x003DA8D0
		public INodeRefOccupationDataT UnPack()
		{
			INodeRefOccupationDataT nodeRefOccupationDataT = new INodeRefOccupationDataT();
			this.UnPackTo(nodeRefOccupationDataT);
			return nodeRefOccupationDataT;
		}

		// Token: 0x0601B40C RID: 111628 RVA: 0x003DC6EC File Offset: 0x003DA8EC
		public void UnPackTo(INodeRefOccupationDataT _o)
		{
			_o.NodeRefTiming = this.NodeRefTiming;
			_o.RefType = this.RefType;
			_o.RefSource = new TRefSourceDataUnion();
			_o.RefSource.Type = this.RefSourceType;
			switch (this.RefSourceType)
			{
			case TRefSourceData.IAwakeEntityRefSource:
				_o.RefSource.Value = ((this.RefSource<IAwakeEntityRefSource>() != null) ? this.RefSource<IAwakeEntityRefSource>().Value.UnPack() : null);
				break;
			case TRefSourceData.IDestroyEntityRefSource:
				_o.RefSource.Value = ((this.RefSource<IDestroyEntityRefSource>() != null) ? this.RefSource<IDestroyEntityRefSource>().Value.UnPack() : null);
				break;
			case TRefSourceData.IManualOccupationRefSource:
				_o.RefSource.Value = ((this.RefSource<IManualOccupationRefSource>() != null) ? this.RefSource<IManualOccupationRefSource>().Value.UnPack() : null);
				break;
			}
			_o.Occupation = this.Occupation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B40D RID: 111629 RVA: 0x003DC80C File Offset: 0x003DAA0C
		public static Offset<INodeRefOccupationData> Pack(FlatBufferBuilder builder, INodeRefOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<INodeRefOccupationData>);
			}
			TRefSourceData refSource_type = (_o.RefSource == null) ? TRefSourceData.NONE : _o.RefSource.Type;
			int refSourceOffset = (_o.RefSource == null) ? 0 : TRefSourceDataUnion.Pack(builder, _o.RefSource);
			StringOffset occupationOffset = (_o.Occupation == null) ? default(StringOffset) : builder.CreateString(_o.Occupation);
			return INodeRefOccupationData.CreateINodeRefOccupationData(builder, _o.NodeRefTiming, _o.RefType, refSource_type, refSourceOffset, occupationOffset, _o.NullMask);
		}

		// Token: 0x0400CBF6 RID: 52214
		private Table __p;
	}
}
