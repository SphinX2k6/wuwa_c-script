using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200481E RID: 18462
	public struct IQuestAllRefOccupations : IFlatbufferObject
	{
		// Token: 0x170080D6 RID: 32982
		// (get) Token: 0x0601B529 RID: 111913 RVA: 0x003DEECE File Offset: 0x003DD0CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B52A RID: 111914 RVA: 0x003DEEDB File Offset: 0x003DD0DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B52B RID: 111915 RVA: 0x003DEEE4 File Offset: 0x003DD0E4
		public static IQuestAllRefOccupations GetRootAsIQuestAllRefOccupations(ByteBuffer _bb)
		{
			return IQuestAllRefOccupations.GetRootAsIQuestAllRefOccupations(_bb, default(IQuestAllRefOccupations));
		}

		// Token: 0x0601B52C RID: 111916 RVA: 0x003DEF00 File Offset: 0x003DD100
		public static IQuestAllRefOccupations GetRootAsIQuestAllRefOccupations(ByteBuffer _bb, IQuestAllRefOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B52D RID: 111917 RVA: 0x003DEF1D File Offset: 0x003DD11D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B52E RID: 111918 RVA: 0x003DEF2C File Offset: 0x003DD12C
		public IQuestAllRefOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080D7 RID: 32983
		// (get) Token: 0x0601B52F RID: 111919 RVA: 0x003DEF3C File Offset: 0x003DD13C
		public int QuestId
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

		// Token: 0x0601B530 RID: 111920 RVA: 0x003DEF78 File Offset: 0x003DD178
		public INodeRefOccupationData? QuestActiveOccupations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupationData?(default(INodeRefOccupationData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170080D8 RID: 32984
		// (get) Token: 0x0601B531 RID: 111921 RVA: 0x003DEFD8 File Offset: 0x003DD1D8
		public int QuestActiveOccupationsLength
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

		// Token: 0x0601B532 RID: 111922 RVA: 0x003DF004 File Offset: 0x003DD204
		public INodeRefOccupationData? QuestAcceptOccupations(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupationData?(default(INodeRefOccupationData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170080D9 RID: 32985
		// (get) Token: 0x0601B533 RID: 111923 RVA: 0x003DF064 File Offset: 0x003DD264
		public int QuestAcceptOccupationsLength
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

		// Token: 0x0601B534 RID: 111924 RVA: 0x003DF090 File Offset: 0x003DD290
		public INodeRefOccupations? NodeOccupations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupations?(default(INodeRefOccupations).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170080DA RID: 32986
		// (get) Token: 0x0601B535 RID: 111925 RVA: 0x003DF0F4 File Offset: 0x003DD2F4
		public int NodeOccupationsLength
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

		// Token: 0x0601B536 RID: 111926 RVA: 0x003DF120 File Offset: 0x003DD320
		public static Offset<IQuestAllRefOccupations> CreateIQuestAllRefOccupations(FlatBufferBuilder builder, int QuestId = 0, VectorOffset QuestActiveOccupationsOffset = default(VectorOffset), VectorOffset QuestAcceptOccupationsOffset = default(VectorOffset), VectorOffset NodeOccupationsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IQuestAllRefOccupations.AddNodeOccupations(builder, NodeOccupationsOffset);
			IQuestAllRefOccupations.AddQuestAcceptOccupations(builder, QuestAcceptOccupationsOffset);
			IQuestAllRefOccupations.AddQuestActiveOccupations(builder, QuestActiveOccupationsOffset);
			IQuestAllRefOccupations.AddQuestId(builder, QuestId);
			return IQuestAllRefOccupations.EndIQuestAllRefOccupations(builder);
		}

		// Token: 0x0601B537 RID: 111927 RVA: 0x003DF14C File Offset: 0x003DD34C
		public static void StartIQuestAllRefOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B538 RID: 111928 RVA: 0x003DF155 File Offset: 0x003DD355
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(0, questId, 0);
		}

		// Token: 0x0601B539 RID: 111929 RVA: 0x003DF160 File Offset: 0x003DD360
		public static void AddQuestActiveOccupations(FlatBufferBuilder builder, VectorOffset questActiveOccupationsOffset)
		{
			builder.AddOffset(1, questActiveOccupationsOffset.Value, 0);
		}

		// Token: 0x0601B53A RID: 111930 RVA: 0x003DF170 File Offset: 0x003DD370
		public static VectorOffset CreateQuestActiveOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B53B RID: 111931 RVA: 0x003DF1B0 File Offset: 0x003DD3B0
		public static VectorOffset CreateQuestActiveOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B53C RID: 111932 RVA: 0x003DF1CA File Offset: 0x003DD3CA
		public static VectorOffset CreateQuestActiveOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupationData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B53D RID: 111933 RVA: 0x003DF1E8 File Offset: 0x003DD3E8
		public static VectorOffset CreateQuestActiveOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupationData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B53E RID: 111934 RVA: 0x003DF201 File Offset: 0x003DD401
		public static void StartQuestActiveOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B53F RID: 111935 RVA: 0x003DF20C File Offset: 0x003DD40C
		public static void AddQuestAcceptOccupations(FlatBufferBuilder builder, VectorOffset questAcceptOccupationsOffset)
		{
			builder.AddOffset(2, questAcceptOccupationsOffset.Value, 0);
		}

		// Token: 0x0601B540 RID: 111936 RVA: 0x003DF21C File Offset: 0x003DD41C
		public static VectorOffset CreateQuestAcceptOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B541 RID: 111937 RVA: 0x003DF25C File Offset: 0x003DD45C
		public static VectorOffset CreateQuestAcceptOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B542 RID: 111938 RVA: 0x003DF276 File Offset: 0x003DD476
		public static VectorOffset CreateQuestAcceptOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupationData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B543 RID: 111939 RVA: 0x003DF294 File Offset: 0x003DD494
		public static VectorOffset CreateQuestAcceptOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupationData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B544 RID: 111940 RVA: 0x003DF2AD File Offset: 0x003DD4AD
		public static void StartQuestAcceptOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B545 RID: 111941 RVA: 0x003DF2B8 File Offset: 0x003DD4B8
		public static void AddNodeOccupations(FlatBufferBuilder builder, VectorOffset nodeOccupationsOffset)
		{
			builder.AddOffset(3, nodeOccupationsOffset.Value, 0);
		}

		// Token: 0x0601B546 RID: 111942 RVA: 0x003DF2C8 File Offset: 0x003DD4C8
		public static VectorOffset CreateNodeOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B547 RID: 111943 RVA: 0x003DF308 File Offset: 0x003DD508
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B548 RID: 111944 RVA: 0x003DF322 File Offset: 0x003DD522
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupations>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B549 RID: 111945 RVA: 0x003DF340 File Offset: 0x003DD540
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupations>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B54A RID: 111946 RVA: 0x003DF359 File Offset: 0x003DD559
		public static void StartNodeOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B54B RID: 111947 RVA: 0x003DF364 File Offset: 0x003DD564
		public static Offset<IQuestAllRefOccupations> EndIQuestAllRefOccupations(FlatBufferBuilder builder)
		{
			return new Offset<IQuestAllRefOccupations>(builder.EndTable());
		}

		// Token: 0x0601B54C RID: 111948 RVA: 0x003DF374 File Offset: 0x003DD574
		public IQuestAllRefOccupationsT UnPack()
		{
			IQuestAllRefOccupationsT questAllRefOccupationsT = new IQuestAllRefOccupationsT();
			this.UnPackTo(questAllRefOccupationsT);
			return questAllRefOccupationsT;
		}

		// Token: 0x0601B54D RID: 111949 RVA: 0x003DF390 File Offset: 0x003DD590
		public void UnPackTo(IQuestAllRefOccupationsT _o)
		{
			_o.QuestId = this.QuestId;
			_o.QuestActiveOccupations = new List<INodeRefOccupationDataT>();
			for (int i = 0; i < this.QuestActiveOccupationsLength; i++)
			{
				_o.QuestActiveOccupations.Add((this.QuestActiveOccupations(i) != null) ? this.QuestActiveOccupations(i).Value.UnPack() : null);
			}
			_o.QuestAcceptOccupations = new List<INodeRefOccupationDataT>();
			for (int j = 0; j < this.QuestAcceptOccupationsLength; j++)
			{
				_o.QuestAcceptOccupations.Add((this.QuestAcceptOccupations(j) != null) ? this.QuestAcceptOccupations(j).Value.UnPack() : null);
			}
			_o.NodeOccupations = new List<INodeRefOccupationsT>();
			for (int k = 0; k < this.NodeOccupationsLength; k++)
			{
				_o.NodeOccupations.Add((this.NodeOccupations(k) != null) ? this.NodeOccupations(k).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B54E RID: 111950 RVA: 0x003DF4A8 File Offset: 0x003DD6A8
		public static Offset<IQuestAllRefOccupations> Pack(FlatBufferBuilder builder, IQuestAllRefOccupationsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestAllRefOccupations>);
			}
			VectorOffset questActiveOccupationsOffset = default(VectorOffset);
			if (_o.QuestActiveOccupations != null)
			{
				Offset<INodeRefOccupationData>[] array = new Offset<INodeRefOccupationData>[_o.QuestActiveOccupations.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INodeRefOccupationData.Pack(builder, _o.QuestActiveOccupations[i]);
				}
				questActiveOccupationsOffset = IQuestAllRefOccupations.CreateQuestActiveOccupationsVector(builder, array);
			}
			VectorOffset questAcceptOccupationsOffset = default(VectorOffset);
			if (_o.QuestAcceptOccupations != null)
			{
				Offset<INodeRefOccupationData>[] array2 = new Offset<INodeRefOccupationData>[_o.QuestAcceptOccupations.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = INodeRefOccupationData.Pack(builder, _o.QuestAcceptOccupations[j]);
				}
				questAcceptOccupationsOffset = IQuestAllRefOccupations.CreateQuestAcceptOccupationsVector(builder, array2);
			}
			VectorOffset nodeOccupationsOffset = default(VectorOffset);
			if (_o.NodeOccupations != null)
			{
				Offset<INodeRefOccupations>[] array3 = new Offset<INodeRefOccupations>[_o.NodeOccupations.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = INodeRefOccupations.Pack(builder, _o.NodeOccupations[k]);
				}
				nodeOccupationsOffset = IQuestAllRefOccupations.CreateNodeOccupationsVector(builder, array3);
			}
			return IQuestAllRefOccupations.CreateIQuestAllRefOccupations(builder, _o.QuestId, questActiveOccupationsOffset, questAcceptOccupationsOffset, nodeOccupationsOffset);
		}

		// Token: 0x0400CC24 RID: 52260
		private Table __p;
	}
}
