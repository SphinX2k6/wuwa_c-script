using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D2B RID: 15659
	public struct IBehaviorTree : IFlatbufferObject
	{
		// Token: 0x17006B68 RID: 27496
		// (get) Token: 0x060159D9 RID: 88537 RVA: 0x0031ECDD File Offset: 0x0031CEDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060159DA RID: 88538 RVA: 0x0031ECEA File Offset: 0x0031CEEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060159DB RID: 88539 RVA: 0x0031ECF4 File Offset: 0x0031CEF4
		public static IBehaviorTree GetRootAsIBehaviorTree(ByteBuffer _bb)
		{
			return IBehaviorTree.GetRootAsIBehaviorTree(_bb, default(IBehaviorTree));
		}

		// Token: 0x060159DC RID: 88540 RVA: 0x0031ED10 File Offset: 0x0031CF10
		public static IBehaviorTree GetRootAsIBehaviorTree(ByteBuffer _bb, IBehaviorTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060159DD RID: 88541 RVA: 0x0031ED2D File Offset: 0x0031CF2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060159DE RID: 88542 RVA: 0x0031ED3C File Offset: 0x0031CF3C
		public IBehaviorTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060159DF RID: 88543 RVA: 0x0031ED4C File Offset: 0x0031CF4C
		public IVarDefine? Vars(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IVarDefine?(default(IVarDefine).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006B69 RID: 27497
		// (get) Token: 0x060159E0 RID: 88544 RVA: 0x0031EDAC File Offset: 0x0031CFAC
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

		// Token: 0x17006B6A RID: 27498
		// (get) Token: 0x060159E1 RID: 88545 RVA: 0x0031EDD8 File Offset: 0x0031CFD8
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

		// Token: 0x060159E2 RID: 88546 RVA: 0x0031EE38 File Offset: 0x0031D038
		public int _SelectedNodeIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006B6B RID: 27499
		// (get) Token: 0x060159E3 RID: 88547 RVA: 0x0031EE78 File Offset: 0x0031D078
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

		// Token: 0x060159E4 RID: 88548 RVA: 0x0031EEA3 File Offset: 0x0031D0A3
		public Span<int> Get_SelectedNodeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060159E5 RID: 88549 RVA: 0x0031EEB2 File Offset: 0x0031D0B2
		public int[] Get_SelectedNodeIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x060159E6 RID: 88550 RVA: 0x0031EEC0 File Offset: 0x0031D0C0
		public IFavoriteBtNodeInfo? _FavoriteNodes(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IFavoriteBtNodeInfo?(default(IFavoriteBtNodeInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006B6C RID: 27500
		// (get) Token: 0x060159E7 RID: 88551 RVA: 0x0031EF24 File Offset: 0x0031D124
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

		// Token: 0x17006B6D RID: 27501
		// (get) Token: 0x060159E8 RID: 88552 RVA: 0x0031EF50 File Offset: 0x0031D150
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

		// Token: 0x060159E9 RID: 88553 RVA: 0x0031EF8D File Offset: 0x0031D18D
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

		// Token: 0x060159EA RID: 88554 RVA: 0x0031EFC1 File Offset: 0x0031D1C1
		public static void StartIBehaviorTree(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060159EB RID: 88555 RVA: 0x0031EFCA File Offset: 0x0031D1CA
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(0, varsOffset.Value, 0);
		}

		// Token: 0x060159EC RID: 88556 RVA: 0x0031EFDC File Offset: 0x0031D1DC
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060159ED RID: 88557 RVA: 0x0031F01C File Offset: 0x0031D21C
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x060159EE RID: 88558 RVA: 0x0031F036 File Offset: 0x0031D236
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVarDefine>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x060159EF RID: 88559 RVA: 0x0031F054 File Offset: 0x0031D254
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVarDefine>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060159F0 RID: 88560 RVA: 0x0031F06D File Offset: 0x0031D26D
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060159F1 RID: 88561 RVA: 0x0031F078 File Offset: 0x0031D278
		public static void AddRoot(FlatBufferBuilder builder, Offset<IStartBtNode> rootOffset)
		{
			builder.AddOffset(1, rootOffset.Value, 0);
		}

		// Token: 0x060159F2 RID: 88562 RVA: 0x0031F088 File Offset: 0x0031D288
		public static void Add_SelectedNodeIds(FlatBufferBuilder builder, VectorOffset _SelectedNodeIdsOffset)
		{
			builder.AddOffset(2, _SelectedNodeIdsOffset.Value, 0);
		}

		// Token: 0x060159F3 RID: 88563 RVA: 0x0031F098 File Offset: 0x0031D298
		public static VectorOffset Create_SelectedNodeIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060159F4 RID: 88564 RVA: 0x0031F0CF File Offset: 0x0031D2CF
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060159F5 RID: 88565 RVA: 0x0031F0E9 File Offset: 0x0031D2E9
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060159F6 RID: 88566 RVA: 0x0031F107 File Offset: 0x0031D307
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060159F7 RID: 88567 RVA: 0x0031F120 File Offset: 0x0031D320
		public static void Start_SelectedNodeIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060159F8 RID: 88568 RVA: 0x0031F12B File Offset: 0x0031D32B
		public static void Add_FavoriteNodes(FlatBufferBuilder builder, VectorOffset _FavoriteNodesOffset)
		{
			builder.AddOffset(3, _FavoriteNodesOffset.Value, 0);
		}

		// Token: 0x060159F9 RID: 88569 RVA: 0x0031F13C File Offset: 0x0031D33C
		public static VectorOffset Create_FavoriteNodesVector(FlatBufferBuilder builder, Offset<IFavoriteBtNodeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060159FA RID: 88570 RVA: 0x0031F17C File Offset: 0x0031D37C
		public static VectorOffset Create_FavoriteNodesVectorBlock(FlatBufferBuilder builder, Offset<IFavoriteBtNodeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFavoriteBtNodeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060159FB RID: 88571 RVA: 0x0031F196 File Offset: 0x0031D396
		public static VectorOffset Create_FavoriteNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFavoriteBtNodeInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFavoriteBtNodeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060159FC RID: 88572 RVA: 0x0031F1B4 File Offset: 0x0031D3B4
		public static VectorOffset Create_FavoriteNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFavoriteBtNodeInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060159FD RID: 88573 RVA: 0x0031F1CD File Offset: 0x0031D3CD
		public static void Start_FavoriteNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060159FE RID: 88574 RVA: 0x0031F1D8 File Offset: 0x0031D3D8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060159FF RID: 88575 RVA: 0x0031F1E3 File Offset: 0x0031D3E3
		public static Offset<IBehaviorTree> EndIBehaviorTree(FlatBufferBuilder builder)
		{
			return new Offset<IBehaviorTree>(builder.EndTable());
		}

		// Token: 0x06015A00 RID: 88576 RVA: 0x0031F1F0 File Offset: 0x0031D3F0
		public IBehaviorTreeT UnPack()
		{
			IBehaviorTreeT behaviorTreeT = new IBehaviorTreeT();
			this.UnPackTo(behaviorTreeT);
			return behaviorTreeT;
		}

		// Token: 0x06015A01 RID: 88577 RVA: 0x0031F20C File Offset: 0x0031D40C
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

		// Token: 0x06015A02 RID: 88578 RVA: 0x0031F338 File Offset: 0x0031D538
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

		// Token: 0x0400B5E7 RID: 46567
		private Table __p;
	}
}
