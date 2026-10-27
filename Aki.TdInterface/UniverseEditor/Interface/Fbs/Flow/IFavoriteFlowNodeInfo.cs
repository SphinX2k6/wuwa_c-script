using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004736 RID: 18230
	public struct IFavoriteFlowNodeInfo : IFlatbufferObject
	{
		// Token: 0x170082C0 RID: 33472
		// (get) Token: 0x0601C081 RID: 114817 RVA: 0x003F8E6F File Offset: 0x003F706F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C082 RID: 114818 RVA: 0x003F8E7C File Offset: 0x003F707C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C083 RID: 114819 RVA: 0x003F8E84 File Offset: 0x003F7084
		public static IFavoriteFlowNodeInfo GetRootAsIFavoriteFlowNodeInfo(ByteBuffer _bb)
		{
			return IFavoriteFlowNodeInfo.GetRootAsIFavoriteFlowNodeInfo(_bb, default(IFavoriteFlowNodeInfo));
		}

		// Token: 0x0601C084 RID: 114820 RVA: 0x003F8EA0 File Offset: 0x003F70A0
		public static IFavoriteFlowNodeInfo GetRootAsIFavoriteFlowNodeInfo(ByteBuffer _bb, IFavoriteFlowNodeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C085 RID: 114821 RVA: 0x003F8EBD File Offset: 0x003F70BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C086 RID: 114822 RVA: 0x003F8ECC File Offset: 0x003F70CC
		public IFavoriteFlowNodeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082C1 RID: 33473
		// (get) Token: 0x0601C087 RID: 114823 RVA: 0x003F8EDC File Offset: 0x003F70DC
		public string HighLightPath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C088 RID: 114824 RVA: 0x003F8F13 File Offset: 0x003F7113
		public Span<byte> GetHighLightPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C089 RID: 114825 RVA: 0x003F8F22 File Offset: 0x003F7122
		public byte[] GetHighLightPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170082C2 RID: 33474
		// (get) Token: 0x0601C08A RID: 114826 RVA: 0x003F8F30 File Offset: 0x003F7130
		public IFlowStateIndex? FlowStateIndex
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFlowStateIndex?(default(IFlowStateIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170082C3 RID: 33475
		// (get) Token: 0x0601C08B RID: 114827 RVA: 0x003F8F90 File Offset: 0x003F7190
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C08C RID: 114828 RVA: 0x003F8FC7 File Offset: 0x003F71C7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601C08D RID: 114829 RVA: 0x003F8FD6 File Offset: 0x003F71D6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601C08E RID: 114830 RVA: 0x003F8FE4 File Offset: 0x003F71E4
		public static Offset<IFavoriteFlowNodeInfo> CreateIFavoriteFlowNodeInfo(FlatBufferBuilder builder, StringOffset HighLightPathOffset = default(StringOffset), Offset<IFlowStateIndex> FlowStateIndexOffset = default(Offset<IFlowStateIndex>), StringOffset DescOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IFavoriteFlowNodeInfo.AddDesc(builder, DescOffset);
			IFavoriteFlowNodeInfo.AddFlowStateIndex(builder, FlowStateIndexOffset);
			IFavoriteFlowNodeInfo.AddHighLightPath(builder, HighLightPathOffset);
			return IFavoriteFlowNodeInfo.EndIFavoriteFlowNodeInfo(builder);
		}

		// Token: 0x0601C08F RID: 114831 RVA: 0x003F9008 File Offset: 0x003F7208
		public static void StartIFavoriteFlowNodeInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C090 RID: 114832 RVA: 0x003F9011 File Offset: 0x003F7211
		public static void AddHighLightPath(FlatBufferBuilder builder, StringOffset highLightPathOffset)
		{
			builder.AddOffset(0, highLightPathOffset.Value, 0);
		}

		// Token: 0x0601C091 RID: 114833 RVA: 0x003F9021 File Offset: 0x003F7221
		public static void AddFlowStateIndex(FlatBufferBuilder builder, Offset<IFlowStateIndex> flowStateIndexOffset)
		{
			builder.AddOffset(1, flowStateIndexOffset.Value, 0);
		}

		// Token: 0x0601C092 RID: 114834 RVA: 0x003F9031 File Offset: 0x003F7231
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0601C093 RID: 114835 RVA: 0x003F9041 File Offset: 0x003F7241
		public static Offset<IFavoriteFlowNodeInfo> EndIFavoriteFlowNodeInfo(FlatBufferBuilder builder)
		{
			return new Offset<IFavoriteFlowNodeInfo>(builder.EndTable());
		}

		// Token: 0x0601C094 RID: 114836 RVA: 0x003F9050 File Offset: 0x003F7250
		public IFavoriteFlowNodeInfoT UnPack()
		{
			IFavoriteFlowNodeInfoT favoriteFlowNodeInfoT = new IFavoriteFlowNodeInfoT();
			this.UnPackTo(favoriteFlowNodeInfoT);
			return favoriteFlowNodeInfoT;
		}

		// Token: 0x0601C095 RID: 114837 RVA: 0x003F906C File Offset: 0x003F726C
		public void UnPackTo(IFavoriteFlowNodeInfoT _o)
		{
			_o.HighLightPath = this.HighLightPath;
			_o.FlowStateIndex = ((this.FlowStateIndex != null) ? this.FlowStateIndex.Value.UnPack() : null);
			_o.Desc = this.Desc;
		}

		// Token: 0x0601C096 RID: 114838 RVA: 0x003F90C0 File Offset: 0x003F72C0
		public static Offset<IFavoriteFlowNodeInfo> Pack(FlatBufferBuilder builder, IFavoriteFlowNodeInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFavoriteFlowNodeInfo>);
			}
			StringOffset highLightPathOffset = (_o.HighLightPath == null) ? default(StringOffset) : builder.CreateString(_o.HighLightPath);
			Offset<IFlowStateIndex> flowStateIndexOffset = (_o.FlowStateIndex == null) ? default(Offset<IFlowStateIndex>) : IFlowStateIndex.Pack(builder, _o.FlowStateIndex);
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			return IFavoriteFlowNodeInfo.CreateIFavoriteFlowNodeInfo(builder, highLightPathOffset, flowStateIndexOffset, descOffset);
		}

		// Token: 0x0400CA1C RID: 51740
		private Table __p;
	}
}
