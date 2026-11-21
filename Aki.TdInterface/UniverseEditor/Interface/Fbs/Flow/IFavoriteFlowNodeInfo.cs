using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B9E RID: 19358
	public struct IFavoriteFlowNodeInfo : IFlatbufferObject
	{
		// Token: 0x17008901 RID: 35073
		// (get) Token: 0x0601D856 RID: 120918 RVA: 0x0042510B File Offset: 0x0042330B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D857 RID: 120919 RVA: 0x00425118 File Offset: 0x00423318
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D858 RID: 120920 RVA: 0x00425120 File Offset: 0x00423320
		public static IFavoriteFlowNodeInfo GetRootAsIFavoriteFlowNodeInfo(ByteBuffer _bb)
		{
			return IFavoriteFlowNodeInfo.GetRootAsIFavoriteFlowNodeInfo(_bb, default(IFavoriteFlowNodeInfo));
		}

		// Token: 0x0601D859 RID: 120921 RVA: 0x0042513C File Offset: 0x0042333C
		public static IFavoriteFlowNodeInfo GetRootAsIFavoriteFlowNodeInfo(ByteBuffer _bb, IFavoriteFlowNodeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D85A RID: 120922 RVA: 0x00425159 File Offset: 0x00423359
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D85B RID: 120923 RVA: 0x00425168 File Offset: 0x00423368
		public IFavoriteFlowNodeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008902 RID: 35074
		// (get) Token: 0x0601D85C RID: 120924 RVA: 0x00425178 File Offset: 0x00423378
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

		// Token: 0x0601D85D RID: 120925 RVA: 0x004251AF File Offset: 0x004233AF
		public Span<byte> GetHighLightPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D85E RID: 120926 RVA: 0x004251BE File Offset: 0x004233BE
		public byte[] GetHighLightPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008903 RID: 35075
		// (get) Token: 0x0601D85F RID: 120927 RVA: 0x004251CC File Offset: 0x004233CC
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

		// Token: 0x17008904 RID: 35076
		// (get) Token: 0x0601D860 RID: 120928 RVA: 0x0042522C File Offset: 0x0042342C
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

		// Token: 0x0601D861 RID: 120929 RVA: 0x00425263 File Offset: 0x00423463
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601D862 RID: 120930 RVA: 0x00425272 File Offset: 0x00423472
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601D863 RID: 120931 RVA: 0x00425280 File Offset: 0x00423480
		public static Offset<IFavoriteFlowNodeInfo> CreateIFavoriteFlowNodeInfo(FlatBufferBuilder builder, StringOffset HighLightPathOffset = default(StringOffset), Offset<IFlowStateIndex> FlowStateIndexOffset = default(Offset<IFlowStateIndex>), StringOffset DescOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IFavoriteFlowNodeInfo.AddDesc(builder, DescOffset);
			IFavoriteFlowNodeInfo.AddFlowStateIndex(builder, FlowStateIndexOffset);
			IFavoriteFlowNodeInfo.AddHighLightPath(builder, HighLightPathOffset);
			return IFavoriteFlowNodeInfo.EndIFavoriteFlowNodeInfo(builder);
		}

		// Token: 0x0601D864 RID: 120932 RVA: 0x004252A4 File Offset: 0x004234A4
		public static void StartIFavoriteFlowNodeInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D865 RID: 120933 RVA: 0x004252AD File Offset: 0x004234AD
		public static void AddHighLightPath(FlatBufferBuilder builder, StringOffset highLightPathOffset)
		{
			builder.AddOffset(0, highLightPathOffset.Value, 0);
		}

		// Token: 0x0601D866 RID: 120934 RVA: 0x004252BD File Offset: 0x004234BD
		public static void AddFlowStateIndex(FlatBufferBuilder builder, Offset<IFlowStateIndex> flowStateIndexOffset)
		{
			builder.AddOffset(1, flowStateIndexOffset.Value, 0);
		}

		// Token: 0x0601D867 RID: 120935 RVA: 0x004252CD File Offset: 0x004234CD
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0601D868 RID: 120936 RVA: 0x004252DD File Offset: 0x004234DD
		public static Offset<IFavoriteFlowNodeInfo> EndIFavoriteFlowNodeInfo(FlatBufferBuilder builder)
		{
			return new Offset<IFavoriteFlowNodeInfo>(builder.EndTable());
		}

		// Token: 0x0601D869 RID: 120937 RVA: 0x004252EC File Offset: 0x004234EC
		public IFavoriteFlowNodeInfoT UnPack()
		{
			IFavoriteFlowNodeInfoT favoriteFlowNodeInfoT = new IFavoriteFlowNodeInfoT();
			this.UnPackTo(favoriteFlowNodeInfoT);
			return favoriteFlowNodeInfoT;
		}

		// Token: 0x0601D86A RID: 120938 RVA: 0x00425308 File Offset: 0x00423508
		public void UnPackTo(IFavoriteFlowNodeInfoT _o)
		{
			_o.HighLightPath = this.HighLightPath;
			_o.FlowStateIndex = ((this.FlowStateIndex != null) ? this.FlowStateIndex.Value.UnPack() : null);
			_o.Desc = this.Desc;
		}

		// Token: 0x0601D86B RID: 120939 RVA: 0x0042535C File Offset: 0x0042355C
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

		// Token: 0x0400D44B RID: 54347
		private Table __p;
	}
}
