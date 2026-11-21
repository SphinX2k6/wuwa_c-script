using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047FD RID: 18429
	public struct IExportAllRefOccupations : IFlatbufferObject
	{
		// Token: 0x17008088 RID: 32904
		// (get) Token: 0x0601B397 RID: 111511 RVA: 0x003DB72E File Offset: 0x003D992E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B398 RID: 111512 RVA: 0x003DB73B File Offset: 0x003D993B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B399 RID: 111513 RVA: 0x003DB744 File Offset: 0x003D9944
		public static IExportAllRefOccupations GetRootAsIExportAllRefOccupations(ByteBuffer _bb)
		{
			return IExportAllRefOccupations.GetRootAsIExportAllRefOccupations(_bb, default(IExportAllRefOccupations));
		}

		// Token: 0x0601B39A RID: 111514 RVA: 0x003DB760 File Offset: 0x003D9960
		public static IExportAllRefOccupations GetRootAsIExportAllRefOccupations(ByteBuffer _bb, IExportAllRefOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B39B RID: 111515 RVA: 0x003DB77D File Offset: 0x003D997D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B39C RID: 111516 RVA: 0x003DB78C File Offset: 0x003D998C
		public IExportAllRefOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601B39D RID: 111517 RVA: 0x003DB79C File Offset: 0x003D999C
		public IQuestAllRefOccupations? Quest(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IQuestAllRefOccupations?(default(IQuestAllRefOccupations).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008089 RID: 32905
		// (get) Token: 0x0601B39E RID: 111518 RVA: 0x003DB7FC File Offset: 0x003D99FC
		public int QuestLength
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

		// Token: 0x0601B39F RID: 111519 RVA: 0x003DB828 File Offset: 0x003D9A28
		public ILevelPlayAllRefOccupations? LevelPlay(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILevelPlayAllRefOccupations?(default(ILevelPlayAllRefOccupations).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700808A RID: 32906
		// (get) Token: 0x0601B3A0 RID: 111520 RVA: 0x003DB888 File Offset: 0x003D9A88
		public int LevelPlayLength
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

		// Token: 0x0601B3A1 RID: 111521 RVA: 0x003DB8B3 File Offset: 0x003D9AB3
		public static Offset<IExportAllRefOccupations> CreateIExportAllRefOccupations(FlatBufferBuilder builder, VectorOffset QuestOffset = default(VectorOffset), VectorOffset LevelPlayOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IExportAllRefOccupations.AddLevelPlay(builder, LevelPlayOffset);
			IExportAllRefOccupations.AddQuest(builder, QuestOffset);
			return IExportAllRefOccupations.EndIExportAllRefOccupations(builder);
		}

		// Token: 0x0601B3A2 RID: 111522 RVA: 0x003DB8D0 File Offset: 0x003D9AD0
		public static void StartIExportAllRefOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B3A3 RID: 111523 RVA: 0x003DB8D9 File Offset: 0x003D9AD9
		public static void AddQuest(FlatBufferBuilder builder, VectorOffset questOffset)
		{
			builder.AddOffset(0, questOffset.Value, 0);
		}

		// Token: 0x0601B3A4 RID: 111524 RVA: 0x003DB8EC File Offset: 0x003D9AEC
		public static VectorOffset CreateQuestVector(FlatBufferBuilder builder, Offset<IQuestAllRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B3A5 RID: 111525 RVA: 0x003DB92C File Offset: 0x003D9B2C
		public static VectorOffset CreateQuestVectorBlock(FlatBufferBuilder builder, Offset<IQuestAllRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQuestAllRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B3A6 RID: 111526 RVA: 0x003DB946 File Offset: 0x003D9B46
		public static VectorOffset CreateQuestVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQuestAllRefOccupations>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQuestAllRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B3A7 RID: 111527 RVA: 0x003DB964 File Offset: 0x003D9B64
		public static VectorOffset CreateQuestVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQuestAllRefOccupations>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B3A8 RID: 111528 RVA: 0x003DB97D File Offset: 0x003D9B7D
		public static void StartQuestVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B3A9 RID: 111529 RVA: 0x003DB988 File Offset: 0x003D9B88
		public static void AddLevelPlay(FlatBufferBuilder builder, VectorOffset levelPlayOffset)
		{
			builder.AddOffset(1, levelPlayOffset.Value, 0);
		}

		// Token: 0x0601B3AA RID: 111530 RVA: 0x003DB998 File Offset: 0x003D9B98
		public static VectorOffset CreateLevelPlayVector(FlatBufferBuilder builder, Offset<ILevelPlayAllRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B3AB RID: 111531 RVA: 0x003DB9D8 File Offset: 0x003D9BD8
		public static VectorOffset CreateLevelPlayVectorBlock(FlatBufferBuilder builder, Offset<ILevelPlayAllRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelPlayAllRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B3AC RID: 111532 RVA: 0x003DB9F2 File Offset: 0x003D9BF2
		public static VectorOffset CreateLevelPlayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelPlayAllRefOccupations>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelPlayAllRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B3AD RID: 111533 RVA: 0x003DBA10 File Offset: 0x003D9C10
		public static VectorOffset CreateLevelPlayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelPlayAllRefOccupations>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B3AE RID: 111534 RVA: 0x003DBA29 File Offset: 0x003D9C29
		public static void StartLevelPlayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B3AF RID: 111535 RVA: 0x003DBA34 File Offset: 0x003D9C34
		public static Offset<IExportAllRefOccupations> EndIExportAllRefOccupations(FlatBufferBuilder builder)
		{
			return new Offset<IExportAllRefOccupations>(builder.EndTable());
		}

		// Token: 0x0601B3B0 RID: 111536 RVA: 0x003DBA44 File Offset: 0x003D9C44
		public IExportAllRefOccupationsT UnPack()
		{
			IExportAllRefOccupationsT exportAllRefOccupationsT = new IExportAllRefOccupationsT();
			this.UnPackTo(exportAllRefOccupationsT);
			return exportAllRefOccupationsT;
		}

		// Token: 0x0601B3B1 RID: 111537 RVA: 0x003DBA60 File Offset: 0x003D9C60
		public void UnPackTo(IExportAllRefOccupationsT _o)
		{
			_o.Quest = new List<IQuestAllRefOccupationsT>();
			for (int i = 0; i < this.QuestLength; i++)
			{
				_o.Quest.Add((this.Quest(i) != null) ? this.Quest(i).Value.UnPack() : null);
			}
			_o.LevelPlay = new List<ILevelPlayAllRefOccupationsT>();
			for (int j = 0; j < this.LevelPlayLength; j++)
			{
				_o.LevelPlay.Add((this.LevelPlay(j) != null) ? this.LevelPlay(j).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B3B2 RID: 111538 RVA: 0x003DBB14 File Offset: 0x003D9D14
		public static Offset<IExportAllRefOccupations> Pack(FlatBufferBuilder builder, IExportAllRefOccupationsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExportAllRefOccupations>);
			}
			VectorOffset questOffset = default(VectorOffset);
			if (_o.Quest != null)
			{
				Offset<IQuestAllRefOccupations>[] array = new Offset<IQuestAllRefOccupations>[_o.Quest.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IQuestAllRefOccupations.Pack(builder, _o.Quest[i]);
				}
				questOffset = IExportAllRefOccupations.CreateQuestVector(builder, array);
			}
			VectorOffset levelPlayOffset = default(VectorOffset);
			if (_o.LevelPlay != null)
			{
				Offset<ILevelPlayAllRefOccupations>[] array2 = new Offset<ILevelPlayAllRefOccupations>[_o.LevelPlay.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ILevelPlayAllRefOccupations.Pack(builder, _o.LevelPlay[j]);
				}
				levelPlayOffset = IExportAllRefOccupations.CreateLevelPlayVector(builder, array2);
			}
			return IExportAllRefOccupations.CreateIExportAllRefOccupations(builder, questOffset, levelPlayOffset);
		}

		// Token: 0x0400CBED RID: 52205
		private Table __p;
	}
}
