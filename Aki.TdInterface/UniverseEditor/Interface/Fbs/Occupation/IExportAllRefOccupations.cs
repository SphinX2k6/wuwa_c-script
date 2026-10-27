using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200439B RID: 17307
	public struct IExportAllRefOccupations : IFlatbufferObject
	{
		// Token: 0x17007A53 RID: 31315
		// (get) Token: 0x06019C09 RID: 105481 RVA: 0x003AFD06 File Offset: 0x003ADF06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019C0A RID: 105482 RVA: 0x003AFD13 File Offset: 0x003ADF13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019C0B RID: 105483 RVA: 0x003AFD1C File Offset: 0x003ADF1C
		public static IExportAllRefOccupations GetRootAsIExportAllRefOccupations(ByteBuffer _bb)
		{
			return IExportAllRefOccupations.GetRootAsIExportAllRefOccupations(_bb, default(IExportAllRefOccupations));
		}

		// Token: 0x06019C0C RID: 105484 RVA: 0x003AFD38 File Offset: 0x003ADF38
		public static IExportAllRefOccupations GetRootAsIExportAllRefOccupations(ByteBuffer _bb, IExportAllRefOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019C0D RID: 105485 RVA: 0x003AFD55 File Offset: 0x003ADF55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019C0E RID: 105486 RVA: 0x003AFD64 File Offset: 0x003ADF64
		public IExportAllRefOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06019C0F RID: 105487 RVA: 0x003AFD74 File Offset: 0x003ADF74
		public IQuestAllRefOccupations? Quest(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IQuestAllRefOccupations?(default(IQuestAllRefOccupations).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007A54 RID: 31316
		// (get) Token: 0x06019C10 RID: 105488 RVA: 0x003AFDD4 File Offset: 0x003ADFD4
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

		// Token: 0x06019C11 RID: 105489 RVA: 0x003AFE00 File Offset: 0x003AE000
		public ILevelPlayAllRefOccupations? LevelPlay(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILevelPlayAllRefOccupations?(default(ILevelPlayAllRefOccupations).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007A55 RID: 31317
		// (get) Token: 0x06019C12 RID: 105490 RVA: 0x003AFE60 File Offset: 0x003AE060
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

		// Token: 0x06019C13 RID: 105491 RVA: 0x003AFE8B File Offset: 0x003AE08B
		public static Offset<IExportAllRefOccupations> CreateIExportAllRefOccupations(FlatBufferBuilder builder, VectorOffset QuestOffset = default(VectorOffset), VectorOffset LevelPlayOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IExportAllRefOccupations.AddLevelPlay(builder, LevelPlayOffset);
			IExportAllRefOccupations.AddQuest(builder, QuestOffset);
			return IExportAllRefOccupations.EndIExportAllRefOccupations(builder);
		}

		// Token: 0x06019C14 RID: 105492 RVA: 0x003AFEA8 File Offset: 0x003AE0A8
		public static void StartIExportAllRefOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019C15 RID: 105493 RVA: 0x003AFEB1 File Offset: 0x003AE0B1
		public static void AddQuest(FlatBufferBuilder builder, VectorOffset questOffset)
		{
			builder.AddOffset(0, questOffset.Value, 0);
		}

		// Token: 0x06019C16 RID: 105494 RVA: 0x003AFEC4 File Offset: 0x003AE0C4
		public static VectorOffset CreateQuestVector(FlatBufferBuilder builder, Offset<IQuestAllRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019C17 RID: 105495 RVA: 0x003AFF04 File Offset: 0x003AE104
		public static VectorOffset CreateQuestVectorBlock(FlatBufferBuilder builder, Offset<IQuestAllRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQuestAllRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C18 RID: 105496 RVA: 0x003AFF1E File Offset: 0x003AE11E
		public static VectorOffset CreateQuestVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQuestAllRefOccupations>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQuestAllRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C19 RID: 105497 RVA: 0x003AFF3C File Offset: 0x003AE13C
		public static VectorOffset CreateQuestVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQuestAllRefOccupations>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019C1A RID: 105498 RVA: 0x003AFF55 File Offset: 0x003AE155
		public static void StartQuestVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019C1B RID: 105499 RVA: 0x003AFF60 File Offset: 0x003AE160
		public static void AddLevelPlay(FlatBufferBuilder builder, VectorOffset levelPlayOffset)
		{
			builder.AddOffset(1, levelPlayOffset.Value, 0);
		}

		// Token: 0x06019C1C RID: 105500 RVA: 0x003AFF70 File Offset: 0x003AE170
		public static VectorOffset CreateLevelPlayVector(FlatBufferBuilder builder, Offset<ILevelPlayAllRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019C1D RID: 105501 RVA: 0x003AFFB0 File Offset: 0x003AE1B0
		public static VectorOffset CreateLevelPlayVectorBlock(FlatBufferBuilder builder, Offset<ILevelPlayAllRefOccupations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelPlayAllRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C1E RID: 105502 RVA: 0x003AFFCA File Offset: 0x003AE1CA
		public static VectorOffset CreateLevelPlayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelPlayAllRefOccupations>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelPlayAllRefOccupations>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C1F RID: 105503 RVA: 0x003AFFE8 File Offset: 0x003AE1E8
		public static VectorOffset CreateLevelPlayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelPlayAllRefOccupations>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019C20 RID: 105504 RVA: 0x003B0001 File Offset: 0x003AE201
		public static void StartLevelPlayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019C21 RID: 105505 RVA: 0x003B000C File Offset: 0x003AE20C
		public static Offset<IExportAllRefOccupations> EndIExportAllRefOccupations(FlatBufferBuilder builder)
		{
			return new Offset<IExportAllRefOccupations>(builder.EndTable());
		}

		// Token: 0x06019C22 RID: 105506 RVA: 0x003B001C File Offset: 0x003AE21C
		public IExportAllRefOccupationsT UnPack()
		{
			IExportAllRefOccupationsT exportAllRefOccupationsT = new IExportAllRefOccupationsT();
			this.UnPackTo(exportAllRefOccupationsT);
			return exportAllRefOccupationsT;
		}

		// Token: 0x06019C23 RID: 105507 RVA: 0x003B0038 File Offset: 0x003AE238
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

		// Token: 0x06019C24 RID: 105508 RVA: 0x003B00EC File Offset: 0x003AE2EC
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

		// Token: 0x0400C1CE RID: 49614
		private Table __p;
	}
}
