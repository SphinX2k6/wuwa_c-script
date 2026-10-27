using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004733 RID: 18227
	public struct IFavoriteFlowConfig : IFlatbufferObject
	{
		// Token: 0x170082B9 RID: 33465
		// (get) Token: 0x0601C061 RID: 114785 RVA: 0x003F8A37 File Offset: 0x003F6C37
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C062 RID: 114786 RVA: 0x003F8A44 File Offset: 0x003F6C44
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C063 RID: 114787 RVA: 0x003F8A4C File Offset: 0x003F6C4C
		public static IFavoriteFlowConfig GetRootAsIFavoriteFlowConfig(ByteBuffer _bb)
		{
			return IFavoriteFlowConfig.GetRootAsIFavoriteFlowConfig(_bb, default(IFavoriteFlowConfig));
		}

		// Token: 0x0601C064 RID: 114788 RVA: 0x003F8A68 File Offset: 0x003F6C68
		public static IFavoriteFlowConfig GetRootAsIFavoriteFlowConfig(ByteBuffer _bb, IFavoriteFlowConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C065 RID: 114789 RVA: 0x003F8A85 File Offset: 0x003F6C85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C066 RID: 114790 RVA: 0x003F8A94 File Offset: 0x003F6C94
		public IFavoriteFlowConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082BA RID: 33466
		// (get) Token: 0x0601C067 RID: 114791 RVA: 0x003F8AA4 File Offset: 0x003F6CA4
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601C068 RID: 114792 RVA: 0x003F8AE4 File Offset: 0x003F6CE4
		public IFavoriteFlowNodeInfo? FavoriteFlowNodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFavoriteFlowNodeInfo?(default(IFavoriteFlowNodeInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082BB RID: 33467
		// (get) Token: 0x0601C069 RID: 114793 RVA: 0x003F8B44 File Offset: 0x003F6D44
		public int FavoriteFlowNodesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170082BC RID: 33468
		// (get) Token: 0x0601C06A RID: 114794 RVA: 0x003F8B70 File Offset: 0x003F6D70
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C06B RID: 114795 RVA: 0x003F8BAC File Offset: 0x003F6DAC
		public static Offset<IFavoriteFlowConfig> CreateIFavoriteFlowConfig(FlatBufferBuilder builder, bool _foldedForTree = false, VectorOffset FavoriteFlowNodesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IFavoriteFlowConfig.AddFavoriteFlowNodes(builder, FavoriteFlowNodesOffset);
			IFavoriteFlowConfig.AddNullMask(builder, NullMask);
			IFavoriteFlowConfig.Add_FoldedForTree(builder, _foldedForTree);
			return IFavoriteFlowConfig.EndIFavoriteFlowConfig(builder);
		}

		// Token: 0x0601C06C RID: 114796 RVA: 0x003F8BD0 File Offset: 0x003F6DD0
		public static void StartIFavoriteFlowConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C06D RID: 114797 RVA: 0x003F8BD9 File Offset: 0x003F6DD9
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(0, _FoldedForTree, false);
		}

		// Token: 0x0601C06E RID: 114798 RVA: 0x003F8BE4 File Offset: 0x003F6DE4
		public static void AddFavoriteFlowNodes(FlatBufferBuilder builder, VectorOffset favoriteFlowNodesOffset)
		{
			builder.AddOffset(1, favoriteFlowNodesOffset.Value, 0);
		}

		// Token: 0x0601C06F RID: 114799 RVA: 0x003F8BF4 File Offset: 0x003F6DF4
		public static VectorOffset CreateFavoriteFlowNodesVector(FlatBufferBuilder builder, Offset<IFavoriteFlowNodeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C070 RID: 114800 RVA: 0x003F8C34 File Offset: 0x003F6E34
		public static VectorOffset CreateFavoriteFlowNodesVectorBlock(FlatBufferBuilder builder, Offset<IFavoriteFlowNodeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFavoriteFlowNodeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C071 RID: 114801 RVA: 0x003F8C4E File Offset: 0x003F6E4E
		public static VectorOffset CreateFavoriteFlowNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFavoriteFlowNodeInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFavoriteFlowNodeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C072 RID: 114802 RVA: 0x003F8C6C File Offset: 0x003F6E6C
		public static VectorOffset CreateFavoriteFlowNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFavoriteFlowNodeInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C073 RID: 114803 RVA: 0x003F8C85 File Offset: 0x003F6E85
		public static void StartFavoriteFlowNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C074 RID: 114804 RVA: 0x003F8C90 File Offset: 0x003F6E90
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601C075 RID: 114805 RVA: 0x003F8C9B File Offset: 0x003F6E9B
		public static Offset<IFavoriteFlowConfig> EndIFavoriteFlowConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFavoriteFlowConfig>(builder.EndTable());
		}

		// Token: 0x0601C076 RID: 114806 RVA: 0x003F8CA8 File Offset: 0x003F6EA8
		public IFavoriteFlowConfigT UnPack()
		{
			IFavoriteFlowConfigT favoriteFlowConfigT = new IFavoriteFlowConfigT();
			this.UnPackTo(favoriteFlowConfigT);
			return favoriteFlowConfigT;
		}

		// Token: 0x0601C077 RID: 114807 RVA: 0x003F8CC4 File Offset: 0x003F6EC4
		public void UnPackTo(IFavoriteFlowConfigT _o)
		{
			_o._FoldedForTree = this._FoldedForTree;
			_o.FavoriteFlowNodes = new List<IFavoriteFlowNodeInfoT>();
			for (int i = 0; i < this.FavoriteFlowNodesLength; i++)
			{
				_o.FavoriteFlowNodes.Add((this.FavoriteFlowNodes(i) != null) ? this.FavoriteFlowNodes(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C078 RID: 114808 RVA: 0x003F8D3C File Offset: 0x003F6F3C
		public static Offset<IFavoriteFlowConfig> Pack(FlatBufferBuilder builder, IFavoriteFlowConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFavoriteFlowConfig>);
			}
			VectorOffset favoriteFlowNodesOffset = default(VectorOffset);
			if (_o.FavoriteFlowNodes != null)
			{
				Offset<IFavoriteFlowNodeInfo>[] array = new Offset<IFavoriteFlowNodeInfo>[_o.FavoriteFlowNodes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFavoriteFlowNodeInfo.Pack(builder, _o.FavoriteFlowNodes[i]);
				}
				favoriteFlowNodesOffset = IFavoriteFlowConfig.CreateFavoriteFlowNodesVector(builder, array);
			}
			return IFavoriteFlowConfig.CreateIFavoriteFlowConfig(builder, _o._FoldedForTree, favoriteFlowNodesOffset, _o.NullMask);
		}

		// Token: 0x0400CA18 RID: 51736
		private Table __p;
	}
}
