using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B9B RID: 19355
	public struct IFavoriteFlowConfig : IFlatbufferObject
	{
		// Token: 0x170088FA RID: 35066
		// (get) Token: 0x0601D836 RID: 120886 RVA: 0x00424CD3 File Offset: 0x00422ED3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D837 RID: 120887 RVA: 0x00424CE0 File Offset: 0x00422EE0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D838 RID: 120888 RVA: 0x00424CE8 File Offset: 0x00422EE8
		public static IFavoriteFlowConfig GetRootAsIFavoriteFlowConfig(ByteBuffer _bb)
		{
			return IFavoriteFlowConfig.GetRootAsIFavoriteFlowConfig(_bb, default(IFavoriteFlowConfig));
		}

		// Token: 0x0601D839 RID: 120889 RVA: 0x00424D04 File Offset: 0x00422F04
		public static IFavoriteFlowConfig GetRootAsIFavoriteFlowConfig(ByteBuffer _bb, IFavoriteFlowConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D83A RID: 120890 RVA: 0x00424D21 File Offset: 0x00422F21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D83B RID: 120891 RVA: 0x00424D30 File Offset: 0x00422F30
		public IFavoriteFlowConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088FB RID: 35067
		// (get) Token: 0x0601D83C RID: 120892 RVA: 0x00424D40 File Offset: 0x00422F40
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D83D RID: 120893 RVA: 0x00424D80 File Offset: 0x00422F80
		public IFavoriteFlowNodeInfo? FavoriteFlowNodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFavoriteFlowNodeInfo?(default(IFavoriteFlowNodeInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170088FC RID: 35068
		// (get) Token: 0x0601D83E RID: 120894 RVA: 0x00424DE0 File Offset: 0x00422FE0
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

		// Token: 0x170088FD RID: 35069
		// (get) Token: 0x0601D83F RID: 120895 RVA: 0x00424E0C File Offset: 0x0042300C
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

		// Token: 0x0601D840 RID: 120896 RVA: 0x00424E48 File Offset: 0x00423048
		public static Offset<IFavoriteFlowConfig> CreateIFavoriteFlowConfig(FlatBufferBuilder builder, bool _foldedForTree = false, VectorOffset FavoriteFlowNodesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IFavoriteFlowConfig.AddFavoriteFlowNodes(builder, FavoriteFlowNodesOffset);
			IFavoriteFlowConfig.AddNullMask(builder, NullMask);
			IFavoriteFlowConfig.Add_FoldedForTree(builder, _foldedForTree);
			return IFavoriteFlowConfig.EndIFavoriteFlowConfig(builder);
		}

		// Token: 0x0601D841 RID: 120897 RVA: 0x00424E6C File Offset: 0x0042306C
		public static void StartIFavoriteFlowConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D842 RID: 120898 RVA: 0x00424E75 File Offset: 0x00423075
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(0, _FoldedForTree, false);
		}

		// Token: 0x0601D843 RID: 120899 RVA: 0x00424E80 File Offset: 0x00423080
		public static void AddFavoriteFlowNodes(FlatBufferBuilder builder, VectorOffset favoriteFlowNodesOffset)
		{
			builder.AddOffset(1, favoriteFlowNodesOffset.Value, 0);
		}

		// Token: 0x0601D844 RID: 120900 RVA: 0x00424E90 File Offset: 0x00423090
		public static VectorOffset CreateFavoriteFlowNodesVector(FlatBufferBuilder builder, Offset<IFavoriteFlowNodeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D845 RID: 120901 RVA: 0x00424ED0 File Offset: 0x004230D0
		public static VectorOffset CreateFavoriteFlowNodesVectorBlock(FlatBufferBuilder builder, Offset<IFavoriteFlowNodeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFavoriteFlowNodeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D846 RID: 120902 RVA: 0x00424EEA File Offset: 0x004230EA
		public static VectorOffset CreateFavoriteFlowNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFavoriteFlowNodeInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFavoriteFlowNodeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D847 RID: 120903 RVA: 0x00424F08 File Offset: 0x00423108
		public static VectorOffset CreateFavoriteFlowNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFavoriteFlowNodeInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D848 RID: 120904 RVA: 0x00424F21 File Offset: 0x00423121
		public static void StartFavoriteFlowNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D849 RID: 120905 RVA: 0x00424F2C File Offset: 0x0042312C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601D84A RID: 120906 RVA: 0x00424F37 File Offset: 0x00423137
		public static Offset<IFavoriteFlowConfig> EndIFavoriteFlowConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFavoriteFlowConfig>(builder.EndTable());
		}

		// Token: 0x0601D84B RID: 120907 RVA: 0x00424F44 File Offset: 0x00423144
		public IFavoriteFlowConfigT UnPack()
		{
			IFavoriteFlowConfigT favoriteFlowConfigT = new IFavoriteFlowConfigT();
			this.UnPackTo(favoriteFlowConfigT);
			return favoriteFlowConfigT;
		}

		// Token: 0x0601D84C RID: 120908 RVA: 0x00424F60 File Offset: 0x00423160
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

		// Token: 0x0601D84D RID: 120909 RVA: 0x00424FD8 File Offset: 0x004231D8
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

		// Token: 0x0400D447 RID: 54343
		private Table __p;
	}
}
