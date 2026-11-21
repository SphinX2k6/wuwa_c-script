using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004142 RID: 16706
	public struct IBehaviorTree : IFlatbufferObject
	{
		// Token: 0x17007122 RID: 28962
		// (get) Token: 0x06016F11 RID: 93969 RVA: 0x00345F55 File Offset: 0x00344155
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016F12 RID: 93970 RVA: 0x00345F62 File Offset: 0x00344162
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016F13 RID: 93971 RVA: 0x00345F6C File Offset: 0x0034416C
		public static IBehaviorTree GetRootAsIBehaviorTree(ByteBuffer _bb)
		{
			return IBehaviorTree.GetRootAsIBehaviorTree(_bb, default(IBehaviorTree));
		}

		// Token: 0x06016F14 RID: 93972 RVA: 0x00345F88 File Offset: 0x00344188
		public static IBehaviorTree GetRootAsIBehaviorTree(ByteBuffer _bb, IBehaviorTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016F15 RID: 93973 RVA: 0x00345FA5 File Offset: 0x003441A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016F16 RID: 93974 RVA: 0x00345FB4 File Offset: 0x003441B4
		public IBehaviorTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06016F17 RID: 93975 RVA: 0x00345FC4 File Offset: 0x003441C4
		public IVarDefine? Vars(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IVarDefine?(default(IVarDefine).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007123 RID: 28963
		// (get) Token: 0x06016F18 RID: 93976 RVA: 0x00346024 File Offset: 0x00344224
		public int VarsLength
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

		// Token: 0x17007124 RID: 28964
		// (get) Token: 0x06016F19 RID: 93977 RVA: 0x00346050 File Offset: 0x00344250
		public IStartBtNode? Root
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IStartBtNode?(default(IStartBtNode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06016F1A RID: 93978 RVA: 0x003460B0 File Offset: 0x003442B0
		public int _SelectedNodeIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007125 RID: 28965
		// (get) Token: 0x06016F1B RID: 93979 RVA: 0x003460F0 File Offset: 0x003442F0
		public int _SelectedNodeIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06016F1C RID: 93980 RVA: 0x0034611B File Offset: 0x0034431B
		public Span<int> Get_SelectedNodeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06016F1D RID: 93981 RVA: 0x0034612A File Offset: 0x0034432A
		public int[] Get_SelectedNodeIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06016F1E RID: 93982 RVA: 0x00346138 File Offset: 0x00344338
		public IFavoriteBtNodeInfo? _FavoriteNodes(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IFavoriteBtNodeInfo?(default(IFavoriteBtNodeInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007126 RID: 28966
		// (get) Token: 0x06016F1F RID: 93983 RVA: 0x0034619C File Offset: 0x0034439C
		public int _FavoriteNodesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007127 RID: 28967
		// (get) Token: 0x06016F20 RID: 93984 RVA: 0x003461C8 File Offset: 0x003443C8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016F21 RID: 93985 RVA: 0x00346205 File Offset: 0x00344405
		public static Offset<IBehaviorTree> CreateIBehaviorTree(FlatBufferBuilder builder, VectorOffset VarsOffset = default(VectorOffset), Offset<IStartBtNode> RootOffset = default(Offset<IStartBtNode>), VectorOffset _selectedNodeIdsOffset = default(VectorOffset), VectorOffset _favoriteNodesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IBehaviorTree.Add_FavoriteNodes(builder, _favoriteNodesOffset);
			IBehaviorTree.Add_SelectedNodeIds(builder, _selectedNodeIdsOffset);
			IBehaviorTree.AddRoot(builder, RootOffset);
			IBehaviorTree.AddVars(builder, VarsOffset);
			IBehaviorTree.AddNullMask(builder, NullMask);
			return IBehaviorTree.EndIBehaviorTree(builder);
		}

		// Token: 0x06016F22 RID: 93986 RVA: 0x00346239 File Offset: 0x00344439
		public static void StartIBehaviorTree(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016F23 RID: 93987 RVA: 0x00346242 File Offset: 0x00344442
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(0, varsOffset.Value, 0);
		}

		// Token: 0x06016F24 RID: 93988 RVA: 0x00346254 File Offset: 0x00344454
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016F25 RID: 93989 RVA: 0x00346294 File Offset: 0x00344494
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F26 RID: 93990 RVA: 0x003462AE File Offset: 0x003444AE
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVarDefine>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F27 RID: 93991 RVA: 0x003462CC File Offset: 0x003444CC
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVarDefine>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016F28 RID: 93992 RVA: 0x003462E5 File Offset: 0x003444E5
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016F29 RID: 93993 RVA: 0x003462F0 File Offset: 0x003444F0
		public static void AddRoot(FlatBufferBuilder builder, Offset<IStartBtNode> rootOffset)
		{
			builder.AddOffset(1, rootOffset.Value, 0);
		}

		// Token: 0x06016F2A RID: 93994 RVA: 0x00346300 File Offset: 0x00344500
		public static void Add_SelectedNodeIds(FlatBufferBuilder builder, VectorOffset _SelectedNodeIdsOffset)
		{
			builder.AddOffset(2, _SelectedNodeIdsOffset.Value, 0);
		}

		// Token: 0x06016F2B RID: 93995 RVA: 0x00346310 File Offset: 0x00344510
		public static VectorOffset Create_SelectedNodeIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016F2C RID: 93996 RVA: 0x00346347 File Offset: 0x00344547
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F2D RID: 93997 RVA: 0x00346361 File Offset: 0x00344561
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F2E RID: 93998 RVA: 0x0034637F File Offset: 0x0034457F
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016F2F RID: 93999 RVA: 0x00346398 File Offset: 0x00344598
		public static void Start_SelectedNodeIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016F30 RID: 94000 RVA: 0x003463A3 File Offset: 0x003445A3
		public static void Add_FavoriteNodes(FlatBufferBuilder builder, VectorOffset _FavoriteNodesOffset)
		{
			builder.AddOffset(3, _FavoriteNodesOffset.Value, 0);
		}

		// Token: 0x06016F31 RID: 94001 RVA: 0x003463B4 File Offset: 0x003445B4
		public static VectorOffset Create_FavoriteNodesVector(FlatBufferBuilder builder, Offset<IFavoriteBtNodeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016F32 RID: 94002 RVA: 0x003463F4 File Offset: 0x003445F4
		public static VectorOffset Create_FavoriteNodesVectorBlock(FlatBufferBuilder builder, Offset<IFavoriteBtNodeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFavoriteBtNodeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F33 RID: 94003 RVA: 0x0034640E File Offset: 0x0034460E
		public static VectorOffset Create_FavoriteNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFavoriteBtNodeInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFavoriteBtNodeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F34 RID: 94004 RVA: 0x0034642C File Offset: 0x0034462C
		public static VectorOffset Create_FavoriteNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFavoriteBtNodeInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016F35 RID: 94005 RVA: 0x00346445 File Offset: 0x00344645
		public static void Start_FavoriteNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016F36 RID: 94006 RVA: 0x00346450 File Offset: 0x00344650
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06016F37 RID: 94007 RVA: 0x0034645B File Offset: 0x0034465B
		public static Offset<IBehaviorTree> EndIBehaviorTree(FlatBufferBuilder builder)
		{
			return new Offset<IBehaviorTree>(builder.EndTable());
		}

		// Token: 0x06016F38 RID: 94008 RVA: 0x00346468 File Offset: 0x00344668
		public IBehaviorTreeT UnPack()
		{
			IBehaviorTreeT behaviorTreeT = new IBehaviorTreeT();
			this.UnPackTo(behaviorTreeT);
			return behaviorTreeT;
		}

		// Token: 0x06016F39 RID: 94009 RVA: 0x00346484 File Offset: 0x00344684
		public void UnPackTo(IBehaviorTreeT _o)
		{
			_o.Vars = new List<IVarDefineT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
			_o.Root = ((this.Root != null) ? this.Root.Value.UnPack() : null);
			_o._SelectedNodeIds = new List<int>();
			for (int j = 0; j < this._SelectedNodeIdsLength; j++)
			{
				_o._SelectedNodeIds.Add(this._SelectedNodeIds(j));
			}
			_o._FavoriteNodes = new List<IFavoriteBtNodeInfoT>();
			for (int k = 0; k < this._FavoriteNodesLength; k++)
			{
				_o._FavoriteNodes.Add((this._FavoriteNodes(k) != null) ? this._FavoriteNodes(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016F3A RID: 94010 RVA: 0x003465B0 File Offset: 0x003447B0
		public static Offset<IBehaviorTree> Pack(FlatBufferBuilder builder, IBehaviorTreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBehaviorTree>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IVarDefine>[] array = new Offset<IVarDefine>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVarDefine.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IBehaviorTree.CreateVarsVector(builder, array);
			}
			Offset<IStartBtNode> rootOffset = (_o.Root == null) ? default(Offset<IStartBtNode>) : IStartBtNode.Pack(builder, _o.Root);
			VectorOffset selectedNodeIdsOffset = default(VectorOffset);
			if (_o._SelectedNodeIds != null)
			{
				int[] data = _o._SelectedNodeIds.ToArray();
				selectedNodeIdsOffset = IBehaviorTree.Create_SelectedNodeIdsVector(builder, data);
			}
			VectorOffset favoriteNodesOffset = default(VectorOffset);
			if (_o._FavoriteNodes != null)
			{
				Offset<IFavoriteBtNodeInfo>[] array2 = new Offset<IFavoriteBtNodeInfo>[_o._FavoriteNodes.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IFavoriteBtNodeInfo.Pack(builder, _o._FavoriteNodes[j]);
				}
				favoriteNodesOffset = IBehaviorTree.Create_FavoriteNodesVector(builder, array2);
			}
			return IBehaviorTree.CreateIBehaviorTree(builder, varsOffset, rootOffset, selectedNodeIdsOffset, favoriteNodesOffset, _o.NullMask);
		}

		// Token: 0x0400BF94 RID: 49044
		private Table __p;
	}
}
