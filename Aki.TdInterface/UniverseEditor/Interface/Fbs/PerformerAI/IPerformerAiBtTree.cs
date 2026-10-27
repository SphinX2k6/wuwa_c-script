using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200435A RID: 17242
	public struct IPerformerAiBtTree : IFlatbufferObject
	{
		// Token: 0x170079AB RID: 31147
		// (get) Token: 0x06019902 RID: 104706 RVA: 0x003A8D75 File Offset: 0x003A6F75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019903 RID: 104707 RVA: 0x003A8D82 File Offset: 0x003A6F82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019904 RID: 104708 RVA: 0x003A8D8C File Offset: 0x003A6F8C
		public static IPerformerAiBtTree GetRootAsIPerformerAiBtTree(ByteBuffer _bb)
		{
			return IPerformerAiBtTree.GetRootAsIPerformerAiBtTree(_bb, default(IPerformerAiBtTree));
		}

		// Token: 0x06019905 RID: 104709 RVA: 0x003A8DA8 File Offset: 0x003A6FA8
		public static IPerformerAiBtTree GetRootAsIPerformerAiBtTree(ByteBuffer _bb, IPerformerAiBtTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019906 RID: 104710 RVA: 0x003A8DC5 File Offset: 0x003A6FC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019907 RID: 104711 RVA: 0x003A8DD4 File Offset: 0x003A6FD4
		public IPerformerAiBtTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079AC RID: 31148
		// (get) Token: 0x06019908 RID: 104712 RVA: 0x003A8DE4 File Offset: 0x003A6FE4
		public IPerformerAiStart? Root
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPerformerAiStart?(default(IPerformerAiStart).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06019909 RID: 104713 RVA: 0x003A8E44 File Offset: 0x003A7044
		public int _StSelectedNodeIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170079AD RID: 31149
		// (get) Token: 0x0601990A RID: 104714 RVA: 0x003A8E84 File Offset: 0x003A7084
		public int _StSelectedNodeIdsLength
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

		// Token: 0x0601990B RID: 104715 RVA: 0x003A8EAF File Offset: 0x003A70AF
		public Span<int> Get_StSelectedNodeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601990C RID: 104716 RVA: 0x003A8EBE File Offset: 0x003A70BE
		public int[] Get_StSelectedNodeIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x170079AE RID: 31150
		// (get) Token: 0x0601990D RID: 104717 RVA: 0x003A8ECC File Offset: 0x003A70CC
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

		// Token: 0x0601990E RID: 104718 RVA: 0x003A8F08 File Offset: 0x003A7108
		public static Offset<IPerformerAiBtTree> CreateIPerformerAiBtTree(FlatBufferBuilder builder, Offset<IPerformerAiStart> RootOffset = default(Offset<IPerformerAiStart>), VectorOffset _StSelectedNodeIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IPerformerAiBtTree.Add_StSelectedNodeIds(builder, _StSelectedNodeIdsOffset);
			IPerformerAiBtTree.AddRoot(builder, RootOffset);
			IPerformerAiBtTree.AddNullMask(builder, NullMask);
			return IPerformerAiBtTree.EndIPerformerAiBtTree(builder);
		}

		// Token: 0x0601990F RID: 104719 RVA: 0x003A8F2C File Offset: 0x003A712C
		public static void StartIPerformerAiBtTree(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019910 RID: 104720 RVA: 0x003A8F35 File Offset: 0x003A7135
		public static void AddRoot(FlatBufferBuilder builder, Offset<IPerformerAiStart> rootOffset)
		{
			builder.AddOffset(0, rootOffset.Value, 0);
		}

		// Token: 0x06019911 RID: 104721 RVA: 0x003A8F45 File Offset: 0x003A7145
		public static void Add_StSelectedNodeIds(FlatBufferBuilder builder, VectorOffset _StSelectedNodeIdsOffset)
		{
			builder.AddOffset(1, _StSelectedNodeIdsOffset.Value, 0);
		}

		// Token: 0x06019912 RID: 104722 RVA: 0x003A8F58 File Offset: 0x003A7158
		public static VectorOffset Create_StSelectedNodeIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019913 RID: 104723 RVA: 0x003A8F8F File Offset: 0x003A718F
		public static VectorOffset Create_StSelectedNodeIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019914 RID: 104724 RVA: 0x003A8FA9 File Offset: 0x003A71A9
		public static VectorOffset Create_StSelectedNodeIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019915 RID: 104725 RVA: 0x003A8FC7 File Offset: 0x003A71C7
		public static VectorOffset Create_StSelectedNodeIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019916 RID: 104726 RVA: 0x003A8FE0 File Offset: 0x003A71E0
		public static void Start_StSelectedNodeIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019917 RID: 104727 RVA: 0x003A8FEB File Offset: 0x003A71EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06019918 RID: 104728 RVA: 0x003A8FF6 File Offset: 0x003A71F6
		public static Offset<IPerformerAiBtTree> EndIPerformerAiBtTree(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiBtTree>(builder.EndTable());
		}

		// Token: 0x06019919 RID: 104729 RVA: 0x003A9004 File Offset: 0x003A7204
		public IPerformerAiBtTreeT UnPack()
		{
			IPerformerAiBtTreeT performerAiBtTreeT = new IPerformerAiBtTreeT();
			this.UnPackTo(performerAiBtTreeT);
			return performerAiBtTreeT;
		}

		// Token: 0x0601991A RID: 104730 RVA: 0x003A9020 File Offset: 0x003A7220
		public void UnPackTo(IPerformerAiBtTreeT _o)
		{
			_o.Root = ((this.Root != null) ? this.Root.Value.UnPack() : null);
			_o._StSelectedNodeIds = new List<int>();
			for (int i = 0; i < this._StSelectedNodeIdsLength; i++)
			{
				_o._StSelectedNodeIds.Add(this._StSelectedNodeIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601991B RID: 104731 RVA: 0x003A9098 File Offset: 0x003A7298
		public static Offset<IPerformerAiBtTree> Pack(FlatBufferBuilder builder, IPerformerAiBtTreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiBtTree>);
			}
			Offset<IPerformerAiStart> rootOffset = (_o.Root == null) ? default(Offset<IPerformerAiStart>) : IPerformerAiStart.Pack(builder, _o.Root);
			VectorOffset stSelectedNodeIdsOffset = default(VectorOffset);
			if (_o._StSelectedNodeIds != null)
			{
				int[] data = _o._StSelectedNodeIds.ToArray();
				stSelectedNodeIdsOffset = IPerformerAiBtTree.Create_StSelectedNodeIdsVector(builder, data);
			}
			return IPerformerAiBtTree.CreateIPerformerAiBtTree(builder, rootOffset, stSelectedNodeIdsOffset, _o.NullMask);
		}

		// Token: 0x0400C149 RID: 49481
		private Table __p;
	}
}
