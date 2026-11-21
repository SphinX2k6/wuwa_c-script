using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047BC RID: 18364
	public struct IPerformerAiBtTree : IFlatbufferObject
	{
		// Token: 0x17007FE0 RID: 32736
		// (get) Token: 0x0601B090 RID: 110736 RVA: 0x003D479D File Offset: 0x003D299D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B091 RID: 110737 RVA: 0x003D47AA File Offset: 0x003D29AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B092 RID: 110738 RVA: 0x003D47B4 File Offset: 0x003D29B4
		public static IPerformerAiBtTree GetRootAsIPerformerAiBtTree(ByteBuffer _bb)
		{
			return IPerformerAiBtTree.GetRootAsIPerformerAiBtTree(_bb, default(IPerformerAiBtTree));
		}

		// Token: 0x0601B093 RID: 110739 RVA: 0x003D47D0 File Offset: 0x003D29D0
		public static IPerformerAiBtTree GetRootAsIPerformerAiBtTree(ByteBuffer _bb, IPerformerAiBtTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B094 RID: 110740 RVA: 0x003D47ED File Offset: 0x003D29ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B095 RID: 110741 RVA: 0x003D47FC File Offset: 0x003D29FC
		public IPerformerAiBtTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FE1 RID: 32737
		// (get) Token: 0x0601B096 RID: 110742 RVA: 0x003D480C File Offset: 0x003D2A0C
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

		// Token: 0x0601B097 RID: 110743 RVA: 0x003D486C File Offset: 0x003D2A6C
		public int _StSelectedNodeIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007FE2 RID: 32738
		// (get) Token: 0x0601B098 RID: 110744 RVA: 0x003D48AC File Offset: 0x003D2AAC
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

		// Token: 0x0601B099 RID: 110745 RVA: 0x003D48D7 File Offset: 0x003D2AD7
		public Span<int> Get_StSelectedNodeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601B09A RID: 110746 RVA: 0x003D48E6 File Offset: 0x003D2AE6
		public int[] Get_StSelectedNodeIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17007FE3 RID: 32739
		// (get) Token: 0x0601B09B RID: 110747 RVA: 0x003D48F4 File Offset: 0x003D2AF4
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

		// Token: 0x0601B09C RID: 110748 RVA: 0x003D4930 File Offset: 0x003D2B30
		public static Offset<IPerformerAiBtTree> CreateIPerformerAiBtTree(FlatBufferBuilder builder, Offset<IPerformerAiStart> RootOffset = default(Offset<IPerformerAiStart>), VectorOffset _StSelectedNodeIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IPerformerAiBtTree.Add_StSelectedNodeIds(builder, _StSelectedNodeIdsOffset);
			IPerformerAiBtTree.AddRoot(builder, RootOffset);
			IPerformerAiBtTree.AddNullMask(builder, NullMask);
			return IPerformerAiBtTree.EndIPerformerAiBtTree(builder);
		}

		// Token: 0x0601B09D RID: 110749 RVA: 0x003D4954 File Offset: 0x003D2B54
		public static void StartIPerformerAiBtTree(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B09E RID: 110750 RVA: 0x003D495D File Offset: 0x003D2B5D
		public static void AddRoot(FlatBufferBuilder builder, Offset<IPerformerAiStart> rootOffset)
		{
			builder.AddOffset(0, rootOffset.Value, 0);
		}

		// Token: 0x0601B09F RID: 110751 RVA: 0x003D496D File Offset: 0x003D2B6D
		public static void Add_StSelectedNodeIds(FlatBufferBuilder builder, VectorOffset _StSelectedNodeIdsOffset)
		{
			builder.AddOffset(1, _StSelectedNodeIdsOffset.Value, 0);
		}

		// Token: 0x0601B0A0 RID: 110752 RVA: 0x003D4980 File Offset: 0x003D2B80
		public static VectorOffset Create_StSelectedNodeIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B0A1 RID: 110753 RVA: 0x003D49B7 File Offset: 0x003D2BB7
		public static VectorOffset Create_StSelectedNodeIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B0A2 RID: 110754 RVA: 0x003D49D1 File Offset: 0x003D2BD1
		public static VectorOffset Create_StSelectedNodeIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B0A3 RID: 110755 RVA: 0x003D49EF File Offset: 0x003D2BEF
		public static VectorOffset Create_StSelectedNodeIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B0A4 RID: 110756 RVA: 0x003D4A08 File Offset: 0x003D2C08
		public static void Start_StSelectedNodeIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B0A5 RID: 110757 RVA: 0x003D4A13 File Offset: 0x003D2C13
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601B0A6 RID: 110758 RVA: 0x003D4A1E File Offset: 0x003D2C1E
		public static Offset<IPerformerAiBtTree> EndIPerformerAiBtTree(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiBtTree>(builder.EndTable());
		}

		// Token: 0x0601B0A7 RID: 110759 RVA: 0x003D4A2C File Offset: 0x003D2C2C
		public IPerformerAiBtTreeT UnPack()
		{
			IPerformerAiBtTreeT performerAiBtTreeT = new IPerformerAiBtTreeT();
			this.UnPackTo(performerAiBtTreeT);
			return performerAiBtTreeT;
		}

		// Token: 0x0601B0A8 RID: 110760 RVA: 0x003D4A48 File Offset: 0x003D2C48
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

		// Token: 0x0601B0A9 RID: 110761 RVA: 0x003D4AC0 File Offset: 0x003D2CC0
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

		// Token: 0x0400CB67 RID: 52071
		private Table __p;
	}
}
