using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004800 RID: 18432
	public struct ILevelPlayAllRefOccupations : IFlatbufferObject
	{
		// Token: 0x1700808D RID: 32909
		// (get) Token: 0x0601B3B9 RID: 111545 RVA: 0x003DBC8B File Offset: 0x003D9E8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B3BA RID: 111546 RVA: 0x003DBC98 File Offset: 0x003D9E98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B3BB RID: 111547 RVA: 0x003DBCA0 File Offset: 0x003D9EA0
		public static ILevelPlayAllRefOccupations GetRootAsILevelPlayAllRefOccupations(ByteBuffer _bb)
		{
			return ILevelPlayAllRefOccupations.GetRootAsILevelPlayAllRefOccupations(_bb, default(ILevelPlayAllRefOccupations));
		}

		// Token: 0x0601B3BC RID: 111548 RVA: 0x003DBCBC File Offset: 0x003D9EBC
		public static ILevelPlayAllRefOccupations GetRootAsILevelPlayAllRefOccupations(ByteBuffer _bb, ILevelPlayAllRefOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B3BD RID: 111549 RVA: 0x003DBCD9 File Offset: 0x003D9ED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B3BE RID: 111550 RVA: 0x003DBCE8 File Offset: 0x003D9EE8
		public ILevelPlayAllRefOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700808E RID: 32910
		// (get) Token: 0x0601B3BF RID: 111551 RVA: 0x003DBCF8 File Offset: 0x003D9EF8
		public int LevelPlayId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B3C0 RID: 111552 RVA: 0x003DBD34 File Offset: 0x003D9F34
		public INodeRefOccupationData? LevelPlayOpenOccupations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupationData?(default(INodeRefOccupationData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700808F RID: 32911
		// (get) Token: 0x0601B3C1 RID: 111553 RVA: 0x003DBD94 File Offset: 0x003D9F94
		public int LevelPlayOpenOccupationsLength
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

		// Token: 0x0601B3C2 RID: 111554 RVA: 0x003DBDC0 File Offset: 0x003D9FC0
		public INodeRefOccupations? NodeOccupations(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupations?(default(INodeRefOccupations).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008090 RID: 32912
		// (get) Token: 0x0601B3C3 RID: 111555 RVA: 0x003DBE20 File Offset: 0x003DA020
		public int NodeOccupationsLength
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

		// Token: 0x0601B3C4 RID: 111556 RVA: 0x003DBE4B File Offset: 0x003DA04B
		public static Offset<ILevelPlayAllRefOccupations> CreateILevelPlayAllRefOccupations(FlatBufferBuilder builder, int LevelPlayId = 0, VectorOffset LevelPlayOpenOccupationsOffset = default(VectorOffset), VectorOffset NodeOccupationsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ILevelPlayAllRefOccupations.AddNodeOccupations(builder, NodeOccupationsOffset);
			ILevelPlayAllRefOccupations.AddLevelPlayOpenOccupations(builder, LevelPlayOpenOccupationsOffset);
			ILevelPlayAllRefOccupations.AddLevelPlayId(builder, LevelPlayId);
			return ILevelPlayAllRefOccupations.EndILevelPlayAllRefOccupations(builder);
		}

		// Token: 0x0601B3C5 RID: 111557 RVA: 0x003DBE6F File Offset: 0x003DA06F
		public static void StartILevelPlayAllRefOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B3C6 RID: 111558 RVA: 0x003DBE78 File Offset: 0x003DA078
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(0, levelPlayId, 0);
		}

		// Token: 0x0601B3C7 RID: 111559 RVA: 0x003DBE83 File Offset: 0x003DA083
		public static void AddLevelPlayOpenOccupations(FlatBufferBuilder builder, VectorOffset levelPlayOpenOccupationsOffset)
		{
			builder.AddOffset(1, levelPlayOpenOccupationsOffset.Value, 0);
		}

		// Token: 0x0601B3C8 RID: 111560 RVA: 0x003DBE94 File Offset: 0x003DA094
		public static VectorOffset CreateLevelPlayOpenOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B3C9 RID: 111561 RVA: 0x003DBED4 File Offset: 0x003DA0D4
		public static VectorOffset CreateLevelPlayOpenOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B3CA RID: 111562 RVA: 0x003DBEEE File Offset: 0x003DA0EE
		public static VectorOffset CreateLevelPlayOpenOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupationData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B3CB RID: 111563 RVA: 0x003DBF0C File Offset: 0x003DA10C
		public static VectorOffset CreateLevelPlayOpenOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupationData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B3CC RID: 111564 RVA: 0x003DBF25 File Offset: 0x003DA125
		public static void StartLevelPlayOpenOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B3CD RID: 111565 RVA: 0x003DBF30 File Offset: 0x003DA130
		public static void AddNodeOccupations(FlatBufferBuilder builder, VectorOffset nodeOccupationsOffset)
		{
			builder.AddOffset(2, nodeOccupationsOffset.Value, 0);
		}

		// Token: 0x0601B3CE RID: 111566 RVA: 0x003DBF40 File Offset: 0x003DA140
		public static VectorOffset CreateNodeOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B3CF RID: 111567 RVA: 0x003DBF80 File Offset: 0x003DA180
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B3D0 RID: 111568 RVA: 0x003DBF9A File Offset: 0x003DA19A
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupations>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B3D1 RID: 111569 RVA: 0x003DBFB8 File Offset: 0x003DA1B8
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupations>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B3D2 RID: 111570 RVA: 0x003DBFD1 File Offset: 0x003DA1D1
		public static void StartNodeOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B3D3 RID: 111571 RVA: 0x003DBFDC File Offset: 0x003DA1DC
		public static Offset<ILevelPlayAllRefOccupations> EndILevelPlayAllRefOccupations(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayAllRefOccupations>(builder.EndTable());
		}

		// Token: 0x0601B3D4 RID: 111572 RVA: 0x003DBFEC File Offset: 0x003DA1EC
		public ILevelPlayAllRefOccupationsT UnPack()
		{
			ILevelPlayAllRefOccupationsT levelPlayAllRefOccupationsT = new ILevelPlayAllRefOccupationsT();
			this.UnPackTo(levelPlayAllRefOccupationsT);
			return levelPlayAllRefOccupationsT;
		}

		// Token: 0x0601B3D5 RID: 111573 RVA: 0x003DC008 File Offset: 0x003DA208
		public void UnPackTo(ILevelPlayAllRefOccupationsT _o)
		{
			_o.LevelPlayId = this.LevelPlayId;
			_o.LevelPlayOpenOccupations = new List<INodeRefOccupationDataT>();
			for (int i = 0; i < this.LevelPlayOpenOccupationsLength; i++)
			{
				_o.LevelPlayOpenOccupations.Add((this.LevelPlayOpenOccupations(i) != null) ? this.LevelPlayOpenOccupations(i).Value.UnPack() : null);
			}
			_o.NodeOccupations = new List<INodeRefOccupationsT>();
			for (int j = 0; j < this.NodeOccupationsLength; j++)
			{
				_o.NodeOccupations.Add((this.NodeOccupations(j) != null) ? this.NodeOccupations(j).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B3D6 RID: 111574 RVA: 0x003DC0C8 File Offset: 0x003DA2C8
		public static Offset<ILevelPlayAllRefOccupations> Pack(FlatBufferBuilder builder, ILevelPlayAllRefOccupationsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayAllRefOccupations>);
			}
			VectorOffset levelPlayOpenOccupationsOffset = default(VectorOffset);
			if (_o.LevelPlayOpenOccupations != null)
			{
				Offset<INodeRefOccupationData>[] array = new Offset<INodeRefOccupationData>[_o.LevelPlayOpenOccupations.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INodeRefOccupationData.Pack(builder, _o.LevelPlayOpenOccupations[i]);
				}
				levelPlayOpenOccupationsOffset = ILevelPlayAllRefOccupations.CreateLevelPlayOpenOccupationsVector(builder, array);
			}
			VectorOffset nodeOccupationsOffset = default(VectorOffset);
			if (_o.NodeOccupations != null)
			{
				Offset<INodeRefOccupations>[] array2 = new Offset<INodeRefOccupations>[_o.NodeOccupations.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = INodeRefOccupations.Pack(builder, _o.NodeOccupations[j]);
				}
				nodeOccupationsOffset = ILevelPlayAllRefOccupations.CreateNodeOccupationsVector(builder, array2);
			}
			return ILevelPlayAllRefOccupations.CreateILevelPlayAllRefOccupations(builder, _o.LevelPlayId, levelPlayOpenOccupationsOffset, nodeOccupationsOffset);
		}

		// Token: 0x0400CBF0 RID: 52208
		private Table __p;
	}
}
