using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043A4 RID: 17316
	public struct INodeRefOccupationData : IFlatbufferObject
	{
		// Token: 0x17007A62 RID: 31330
		// (get) Token: 0x06019C63 RID: 105571 RVA: 0x003B09B9 File Offset: 0x003AEBB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019C64 RID: 105572 RVA: 0x003B09C6 File Offset: 0x003AEBC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019C65 RID: 105573 RVA: 0x003B09D0 File Offset: 0x003AEBD0
		public static INodeRefOccupationData GetRootAsINodeRefOccupationData(ByteBuffer _bb)
		{
			return INodeRefOccupationData.GetRootAsINodeRefOccupationData(_bb, default(INodeRefOccupationData));
		}

		// Token: 0x06019C66 RID: 105574 RVA: 0x003B09EC File Offset: 0x003AEBEC
		public static INodeRefOccupationData GetRootAsINodeRefOccupationData(ByteBuffer _bb, INodeRefOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019C67 RID: 105575 RVA: 0x003B0A09 File Offset: 0x003AEC09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019C68 RID: 105576 RVA: 0x003B0A18 File Offset: 0x003AEC18
		public INodeRefOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A63 RID: 31331
		// (get) Token: 0x06019C69 RID: 105577 RVA: 0x003B0A28 File Offset: 0x003AEC28
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

		// Token: 0x17007A64 RID: 31332
		// (get) Token: 0x06019C6A RID: 105578 RVA: 0x003B0A64 File Offset: 0x003AEC64
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

		// Token: 0x17007A65 RID: 31333
		// (get) Token: 0x06019C6B RID: 105579 RVA: 0x003B0AA0 File Offset: 0x003AECA0
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

		// Token: 0x06019C6C RID: 105580 RVA: 0x003B0ADC File Offset: 0x003AECDC
		public TTable? RefSource<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019C6D RID: 105581 RVA: 0x003B0B24 File Offset: 0x003AED24
		public IAwakeEntityRefSource RefSourceAsIAwakeEntityRefSource()
		{
			return this.RefSource<IAwakeEntityRefSource>().Value;
		}

		// Token: 0x06019C6E RID: 105582 RVA: 0x003B0B40 File Offset: 0x003AED40
		public IDestroyEntityRefSource RefSourceAsIDestroyEntityRefSource()
		{
			return this.RefSource<IDestroyEntityRefSource>().Value;
		}

		// Token: 0x06019C6F RID: 105583 RVA: 0x003B0B5C File Offset: 0x003AED5C
		public IManualOccupationRefSource RefSourceAsIManualOccupationRefSource()
		{
			return this.RefSource<IManualOccupationRefSource>().Value;
		}

		// Token: 0x17007A66 RID: 31334
		// (get) Token: 0x06019C70 RID: 105584 RVA: 0x003B0B78 File Offset: 0x003AED78
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

		// Token: 0x06019C71 RID: 105585 RVA: 0x003B0BB0 File Offset: 0x003AEDB0
		public Span<byte> GetOccupationBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06019C72 RID: 105586 RVA: 0x003B0BC0 File Offset: 0x003AEDC0
		public byte[] GetOccupationArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17007A67 RID: 31335
		// (get) Token: 0x06019C73 RID: 105587 RVA: 0x003B0BD0 File Offset: 0x003AEDD0
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

		// Token: 0x06019C74 RID: 105588 RVA: 0x003B0C0D File Offset: 0x003AEE0D
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

		// Token: 0x06019C75 RID: 105589 RVA: 0x003B0C49 File Offset: 0x003AEE49
		public static void StartINodeRefOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06019C76 RID: 105590 RVA: 0x003B0C52 File Offset: 0x003AEE52
		public static void AddNodeRefTiming(FlatBufferBuilder builder, TNodeRefTiming nodeRefTiming)
		{
			builder.AddByte(0, (byte)nodeRefTiming, 0);
		}

		// Token: 0x06019C77 RID: 105591 RVA: 0x003B0C5D File Offset: 0x003AEE5D
		public static void AddRefType(FlatBufferBuilder builder, TRefType refType)
		{
			builder.AddByte(1, (byte)refType, 0);
		}

		// Token: 0x06019C78 RID: 105592 RVA: 0x003B0C68 File Offset: 0x003AEE68
		public static void AddRefSourceType(FlatBufferBuilder builder, TRefSourceData refSourceType)
		{
			builder.AddByte(2, (byte)refSourceType, 0);
		}

		// Token: 0x06019C79 RID: 105593 RVA: 0x003B0C73 File Offset: 0x003AEE73
		public static void AddRefSource(FlatBufferBuilder builder, int refSourceOffset)
		{
			builder.AddOffset(3, refSourceOffset, 0);
		}

		// Token: 0x06019C7A RID: 105594 RVA: 0x003B0C7E File Offset: 0x003AEE7E
		public static void AddOccupation(FlatBufferBuilder builder, StringOffset occupationOffset)
		{
			builder.AddOffset(4, occupationOffset.Value, 0);
		}

		// Token: 0x06019C7B RID: 105595 RVA: 0x003B0C8E File Offset: 0x003AEE8E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06019C7C RID: 105596 RVA: 0x003B0C99 File Offset: 0x003AEE99
		public static Offset<INodeRefOccupationData> EndINodeRefOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<INodeRefOccupationData>(builder.EndTable());
		}

		// Token: 0x06019C7D RID: 105597 RVA: 0x003B0CA8 File Offset: 0x003AEEA8
		public INodeRefOccupationDataT UnPack()
		{
			INodeRefOccupationDataT nodeRefOccupationDataT = new INodeRefOccupationDataT();
			this.UnPackTo(nodeRefOccupationDataT);
			return nodeRefOccupationDataT;
		}

		// Token: 0x06019C7E RID: 105598 RVA: 0x003B0CC4 File Offset: 0x003AEEC4
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

		// Token: 0x06019C7F RID: 105599 RVA: 0x003B0DE4 File Offset: 0x003AEFE4
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

		// Token: 0x0400C1D7 RID: 49623
		private Table __p;
	}
}
