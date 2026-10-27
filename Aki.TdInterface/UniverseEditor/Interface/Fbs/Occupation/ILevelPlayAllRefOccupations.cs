using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200439E RID: 17310
	public struct ILevelPlayAllRefOccupations : IFlatbufferObject
	{
		// Token: 0x17007A58 RID: 31320
		// (get) Token: 0x06019C2B RID: 105515 RVA: 0x003B0263 File Offset: 0x003AE463
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019C2C RID: 105516 RVA: 0x003B0270 File Offset: 0x003AE470
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019C2D RID: 105517 RVA: 0x003B0278 File Offset: 0x003AE478
		public static ILevelPlayAllRefOccupations GetRootAsILevelPlayAllRefOccupations(ByteBuffer _bb)
		{
			return ILevelPlayAllRefOccupations.GetRootAsILevelPlayAllRefOccupations(_bb, default(ILevelPlayAllRefOccupations));
		}

		// Token: 0x06019C2E RID: 105518 RVA: 0x003B0294 File Offset: 0x003AE494
		public static ILevelPlayAllRefOccupations GetRootAsILevelPlayAllRefOccupations(ByteBuffer _bb, ILevelPlayAllRefOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019C2F RID: 105519 RVA: 0x003B02B1 File Offset: 0x003AE4B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019C30 RID: 105520 RVA: 0x003B02C0 File Offset: 0x003AE4C0
		public ILevelPlayAllRefOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A59 RID: 31321
		// (get) Token: 0x06019C31 RID: 105521 RVA: 0x003B02D0 File Offset: 0x003AE4D0
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

		// Token: 0x06019C32 RID: 105522 RVA: 0x003B030C File Offset: 0x003AE50C
		public INodeRefOccupationData? LevelPlayOpenOccupations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupationData?(default(INodeRefOccupationData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007A5A RID: 31322
		// (get) Token: 0x06019C33 RID: 105523 RVA: 0x003B036C File Offset: 0x003AE56C
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

		// Token: 0x06019C34 RID: 105524 RVA: 0x003B0398 File Offset: 0x003AE598
		public INodeRefOccupations? NodeOccupations(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupations?(default(INodeRefOccupations).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007A5B RID: 31323
		// (get) Token: 0x06019C35 RID: 105525 RVA: 0x003B03F8 File Offset: 0x003AE5F8
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

		// Token: 0x06019C36 RID: 105526 RVA: 0x003B0423 File Offset: 0x003AE623
		public static Offset<ILevelPlayAllRefOccupations> CreateILevelPlayAllRefOccupations(FlatBufferBuilder builder, int LevelPlayId = 0, VectorOffset LevelPlayOpenOccupationsOffset = default(VectorOffset), VectorOffset NodeOccupationsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ILevelPlayAllRefOccupations.AddNodeOccupations(builder, NodeOccupationsOffset);
			ILevelPlayAllRefOccupations.AddLevelPlayOpenOccupations(builder, LevelPlayOpenOccupationsOffset);
			ILevelPlayAllRefOccupations.AddLevelPlayId(builder, LevelPlayId);
			return ILevelPlayAllRefOccupations.EndILevelPlayAllRefOccupations(builder);
		}

		// Token: 0x06019C37 RID: 105527 RVA: 0x003B0447 File Offset: 0x003AE647
		public static void StartILevelPlayAllRefOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019C38 RID: 105528 RVA: 0x003B0450 File Offset: 0x003AE650
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(0, levelPlayId, 0);
		}

		// Token: 0x06019C39 RID: 105529 RVA: 0x003B045B File Offset: 0x003AE65B
		public static void AddLevelPlayOpenOccupations(FlatBufferBuilder builder, VectorOffset levelPlayOpenOccupationsOffset)
		{
			builder.AddOffset(1, levelPlayOpenOccupationsOffset.Value, 0);
		}

		// Token: 0x06019C3A RID: 105530 RVA: 0x003B046C File Offset: 0x003AE66C
		public static VectorOffset CreateLevelPlayOpenOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019C3B RID: 105531 RVA: 0x003B04AC File Offset: 0x003AE6AC
		public static VectorOffset CreateLevelPlayOpenOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C3C RID: 105532 RVA: 0x003B04C6 File Offset: 0x003AE6C6
		public static VectorOffset CreateLevelPlayOpenOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupationData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C3D RID: 105533 RVA: 0x003B04E4 File Offset: 0x003AE6E4
		public static VectorOffset CreateLevelPlayOpenOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupationData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019C3E RID: 105534 RVA: 0x003B04FD File Offset: 0x003AE6FD
		public static void StartLevelPlayOpenOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019C3F RID: 105535 RVA: 0x003B0508 File Offset: 0x003AE708
		public static void AddNodeOccupations(FlatBufferBuilder builder, VectorOffset nodeOccupationsOffset)
		{
			builder.AddOffset(2, nodeOccupationsOffset.Value, 0);
		}

		// Token: 0x06019C40 RID: 105536 RVA: 0x003B0518 File Offset: 0x003AE718
		public static VectorOffset CreateNodeOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019C41 RID: 105537 RVA: 0x003B0558 File Offset: 0x003AE758
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C42 RID: 105538 RVA: 0x003B0572 File Offset: 0x003AE772
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupations>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C43 RID: 105539 RVA: 0x003B0590 File Offset: 0x003AE790
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupations>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019C44 RID: 105540 RVA: 0x003B05A9 File Offset: 0x003AE7A9
		public static void StartNodeOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019C45 RID: 105541 RVA: 0x003B05B4 File Offset: 0x003AE7B4
		public static Offset<ILevelPlayAllRefOccupations> EndILevelPlayAllRefOccupations(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayAllRefOccupations>(builder.EndTable());
		}

		// Token: 0x06019C46 RID: 105542 RVA: 0x003B05C4 File Offset: 0x003AE7C4
		public ILevelPlayAllRefOccupationsT UnPack()
		{
			ILevelPlayAllRefOccupationsT levelPlayAllRefOccupationsT = new ILevelPlayAllRefOccupationsT();
			this.UnPackTo(levelPlayAllRefOccupationsT);
			return levelPlayAllRefOccupationsT;
		}

		// Token: 0x06019C47 RID: 105543 RVA: 0x003B05E0 File Offset: 0x003AE7E0
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

		// Token: 0x06019C48 RID: 105544 RVA: 0x003B06A0 File Offset: 0x003AE8A0
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

		// Token: 0x0400C1D1 RID: 49617
		private Table __p;
	}
}
