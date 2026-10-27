using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043BC RID: 17340
	public struct IQuestAllRefOccupations : IFlatbufferObject
	{
		// Token: 0x17007A9F RID: 31391
		// (get) Token: 0x06019D8E RID: 105870 RVA: 0x003B3238 File Offset: 0x003B1438
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019D8F RID: 105871 RVA: 0x003B3245 File Offset: 0x003B1445
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019D90 RID: 105872 RVA: 0x003B324C File Offset: 0x003B144C
		public static IQuestAllRefOccupations GetRootAsIQuestAllRefOccupations(ByteBuffer _bb)
		{
			return IQuestAllRefOccupations.GetRootAsIQuestAllRefOccupations(_bb, default(IQuestAllRefOccupations));
		}

		// Token: 0x06019D91 RID: 105873 RVA: 0x003B3268 File Offset: 0x003B1468
		public static IQuestAllRefOccupations GetRootAsIQuestAllRefOccupations(ByteBuffer _bb, IQuestAllRefOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019D92 RID: 105874 RVA: 0x003B3285 File Offset: 0x003B1485
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019D93 RID: 105875 RVA: 0x003B3294 File Offset: 0x003B1494
		public IQuestAllRefOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AA0 RID: 31392
		// (get) Token: 0x06019D94 RID: 105876 RVA: 0x003B32A4 File Offset: 0x003B14A4
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

		// Token: 0x06019D95 RID: 105877 RVA: 0x003B32E0 File Offset: 0x003B14E0
		public INodeRefOccupationData? QuestActiveOccupations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupationData?(default(INodeRefOccupationData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007AA1 RID: 31393
		// (get) Token: 0x06019D96 RID: 105878 RVA: 0x003B3340 File Offset: 0x003B1540
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

		// Token: 0x06019D97 RID: 105879 RVA: 0x003B336C File Offset: 0x003B156C
		public INodeRefOccupationData? QuestAcceptOccupations(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupationData?(default(INodeRefOccupationData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007AA2 RID: 31394
		// (get) Token: 0x06019D98 RID: 105880 RVA: 0x003B33CC File Offset: 0x003B15CC
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

		// Token: 0x06019D99 RID: 105881 RVA: 0x003B33F8 File Offset: 0x003B15F8
		public INodeRefOccupations? NodeOccupations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupations?(default(INodeRefOccupations).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007AA3 RID: 31395
		// (get) Token: 0x06019D9A RID: 105882 RVA: 0x003B345C File Offset: 0x003B165C
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

		// Token: 0x06019D9B RID: 105883 RVA: 0x003B3488 File Offset: 0x003B1688
		public static Offset<IQuestAllRefOccupations> CreateIQuestAllRefOccupations(FlatBufferBuilder builder, int QuestId = 0, VectorOffset QuestActiveOccupationsOffset = default(VectorOffset), VectorOffset QuestAcceptOccupationsOffset = default(VectorOffset), VectorOffset NodeOccupationsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IQuestAllRefOccupations.AddNodeOccupations(builder, NodeOccupationsOffset);
			IQuestAllRefOccupations.AddQuestAcceptOccupations(builder, QuestAcceptOccupationsOffset);
			IQuestAllRefOccupations.AddQuestActiveOccupations(builder, QuestActiveOccupationsOffset);
			IQuestAllRefOccupations.AddQuestId(builder, QuestId);
			return IQuestAllRefOccupations.EndIQuestAllRefOccupations(builder);
		}

		// Token: 0x06019D9C RID: 105884 RVA: 0x003B34B4 File Offset: 0x003B16B4
		public static void StartIQuestAllRefOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019D9D RID: 105885 RVA: 0x003B34BD File Offset: 0x003B16BD
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(0, questId, 0);
		}

		// Token: 0x06019D9E RID: 105886 RVA: 0x003B34C8 File Offset: 0x003B16C8
		public static void AddQuestActiveOccupations(FlatBufferBuilder builder, VectorOffset questActiveOccupationsOffset)
		{
			builder.AddOffset(1, questActiveOccupationsOffset.Value, 0);
		}

		// Token: 0x06019D9F RID: 105887 RVA: 0x003B34D8 File Offset: 0x003B16D8
		public static VectorOffset CreateQuestActiveOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019DA0 RID: 105888 RVA: 0x003B3518 File Offset: 0x003B1718
		public static VectorOffset CreateQuestActiveOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DA1 RID: 105889 RVA: 0x003B3532 File Offset: 0x003B1732
		public static VectorOffset CreateQuestActiveOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupationData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DA2 RID: 105890 RVA: 0x003B3550 File Offset: 0x003B1750
		public static VectorOffset CreateQuestActiveOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupationData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019DA3 RID: 105891 RVA: 0x003B3569 File Offset: 0x003B1769
		public static void StartQuestActiveOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019DA4 RID: 105892 RVA: 0x003B3574 File Offset: 0x003B1774
		public static void AddQuestAcceptOccupations(FlatBufferBuilder builder, VectorOffset questAcceptOccupationsOffset)
		{
			builder.AddOffset(2, questAcceptOccupationsOffset.Value, 0);
		}

		// Token: 0x06019DA5 RID: 105893 RVA: 0x003B3584 File Offset: 0x003B1784
		public static VectorOffset CreateQuestAcceptOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019DA6 RID: 105894 RVA: 0x003B35C4 File Offset: 0x003B17C4
		public static VectorOffset CreateQuestAcceptOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DA7 RID: 105895 RVA: 0x003B35DE File Offset: 0x003B17DE
		public static VectorOffset CreateQuestAcceptOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupationData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DA8 RID: 105896 RVA: 0x003B35FC File Offset: 0x003B17FC
		public static VectorOffset CreateQuestAcceptOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupationData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019DA9 RID: 105897 RVA: 0x003B3615 File Offset: 0x003B1815
		public static void StartQuestAcceptOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019DAA RID: 105898 RVA: 0x003B3620 File Offset: 0x003B1820
		public static void AddNodeOccupations(FlatBufferBuilder builder, VectorOffset nodeOccupationsOffset)
		{
			builder.AddOffset(3, nodeOccupationsOffset.Value, 0);
		}

		// Token: 0x06019DAB RID: 105899 RVA: 0x003B3630 File Offset: 0x003B1830
		public static VectorOffset CreateNodeOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019DAC RID: 105900 RVA: 0x003B3670 File Offset: 0x003B1870
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DAD RID: 105901 RVA: 0x003B368A File Offset: 0x003B188A
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupations>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DAE RID: 105902 RVA: 0x003B36A8 File Offset: 0x003B18A8
		public static VectorOffset CreateNodeOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupations>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019DAF RID: 105903 RVA: 0x003B36C1 File Offset: 0x003B18C1
		public static void StartNodeOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019DB0 RID: 105904 RVA: 0x003B36CC File Offset: 0x003B18CC
		public static Offset<IQuestAllRefOccupations> EndIQuestAllRefOccupations(FlatBufferBuilder builder)
		{
			return new Offset<IQuestAllRefOccupations>(builder.EndTable());
		}

		// Token: 0x06019DB1 RID: 105905 RVA: 0x003B36DC File Offset: 0x003B18DC
		public IQuestAllRefOccupationsT UnPack()
		{
			IQuestAllRefOccupationsT questAllRefOccupationsT = new IQuestAllRefOccupationsT();
			this.UnPackTo(questAllRefOccupationsT);
			return questAllRefOccupationsT;
		}

		// Token: 0x06019DB2 RID: 105906 RVA: 0x003B36F8 File Offset: 0x003B18F8
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

		// Token: 0x06019DB3 RID: 105907 RVA: 0x003B3810 File Offset: 0x003B1A10
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

		// Token: 0x0400C203 RID: 49667
		private Table __p;
	}
}
