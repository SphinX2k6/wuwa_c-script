using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200408E RID: 16526
	public struct IRecallEntityGroup : IFlatbufferObject
	{
		// Token: 0x1700749C RID: 29852
		// (get) Token: 0x060180B3 RID: 98483 RVA: 0x00377D53 File Offset: 0x00375F53
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060180B4 RID: 98484 RVA: 0x00377D60 File Offset: 0x00375F60
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060180B5 RID: 98485 RVA: 0x00377D68 File Offset: 0x00375F68
		public static IRecallEntityGroup GetRootAsIRecallEntityGroup(ByteBuffer _bb)
		{
			return IRecallEntityGroup.GetRootAsIRecallEntityGroup(_bb, default(IRecallEntityGroup));
		}

		// Token: 0x060180B6 RID: 98486 RVA: 0x00377D84 File Offset: 0x00375F84
		public static IRecallEntityGroup GetRootAsIRecallEntityGroup(ByteBuffer _bb, IRecallEntityGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060180B7 RID: 98487 RVA: 0x00377DA1 File Offset: 0x00375FA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060180B8 RID: 98488 RVA: 0x00377DB0 File Offset: 0x00375FB0
		public IRecallEntityGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700749D RID: 29853
		// (get) Token: 0x060180B9 RID: 98489 RVA: 0x00377DC0 File Offset: 0x00375FC0
		public int Index
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

		// Token: 0x1700749E RID: 29854
		// (get) Token: 0x060180BA RID: 98490 RVA: 0x00377DFC File Offset: 0x00375FFC
		public string Source
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060180BB RID: 98491 RVA: 0x00377E33 File Offset: 0x00376033
		public Span<byte> GetSourceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060180BC RID: 98492 RVA: 0x00377E42 File Offset: 0x00376042
		public byte[] GetSourceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700749F RID: 29855
		// (get) Token: 0x060180BD RID: 98493 RVA: 0x00377E50 File Offset: 0x00376050
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060180BE RID: 98494 RVA: 0x00377E8C File Offset: 0x0037608C
		public int Entities(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170074A0 RID: 29856
		// (get) Token: 0x060180BF RID: 98495 RVA: 0x00377ECC File Offset: 0x003760CC
		public int EntitiesLength
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

		// Token: 0x060180C0 RID: 98496 RVA: 0x00377EF8 File Offset: 0x003760F8
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060180C1 RID: 98497 RVA: 0x00377F08 File Offset: 0x00376108
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x060180C2 RID: 98498 RVA: 0x00377F17 File Offset: 0x00376117
		public static Offset<IRecallEntityGroup> CreateIRecallEntityGroup(FlatBufferBuilder builder, int Index = 0, StringOffset SourceOffset = default(StringOffset), int LevelId = 0, VectorOffset EntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IRecallEntityGroup.AddEntities(builder, EntitiesOffset);
			IRecallEntityGroup.AddLevelId(builder, LevelId);
			IRecallEntityGroup.AddSource(builder, SourceOffset);
			IRecallEntityGroup.AddIndex(builder, Index);
			return IRecallEntityGroup.EndIRecallEntityGroup(builder);
		}

		// Token: 0x060180C3 RID: 98499 RVA: 0x00377F43 File Offset: 0x00376143
		public static void StartIRecallEntityGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060180C4 RID: 98500 RVA: 0x00377F4C File Offset: 0x0037614C
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		// Token: 0x060180C5 RID: 98501 RVA: 0x00377F57 File Offset: 0x00376157
		public static void AddSource(FlatBufferBuilder builder, StringOffset sourceOffset)
		{
			builder.AddOffset(1, sourceOffset.Value, 0);
		}

		// Token: 0x060180C6 RID: 98502 RVA: 0x00377F67 File Offset: 0x00376167
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(2, levelId, 0);
		}

		// Token: 0x060180C7 RID: 98503 RVA: 0x00377F72 File Offset: 0x00376172
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(3, entitiesOffset.Value, 0);
		}

		// Token: 0x060180C8 RID: 98504 RVA: 0x00377F84 File Offset: 0x00376184
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060180C9 RID: 98505 RVA: 0x00377FBB File Offset: 0x003761BB
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060180CA RID: 98506 RVA: 0x00377FD5 File Offset: 0x003761D5
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060180CB RID: 98507 RVA: 0x00377FF3 File Offset: 0x003761F3
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060180CC RID: 98508 RVA: 0x0037800C File Offset: 0x0037620C
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060180CD RID: 98509 RVA: 0x00378017 File Offset: 0x00376217
		public static Offset<IRecallEntityGroup> EndIRecallEntityGroup(FlatBufferBuilder builder)
		{
			return new Offset<IRecallEntityGroup>(builder.EndTable());
		}

		// Token: 0x060180CE RID: 98510 RVA: 0x00378024 File Offset: 0x00376224
		public IRecallEntityGroupT UnPack()
		{
			IRecallEntityGroupT recallEntityGroupT = new IRecallEntityGroupT();
			this.UnPackTo(recallEntityGroupT);
			return recallEntityGroupT;
		}

		// Token: 0x060180CF RID: 98511 RVA: 0x00378040 File Offset: 0x00376240
		public void UnPackTo(IRecallEntityGroupT _o)
		{
			_o.Index = this.Index;
			_o.Source = this.Source;
			_o.LevelId = this.LevelId;
			_o.Entities = new List<int>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add(this.Entities(i));
			}
		}

		// Token: 0x060180D0 RID: 98512 RVA: 0x003780A0 File Offset: 0x003762A0
		public static Offset<IRecallEntityGroup> Pack(FlatBufferBuilder builder, IRecallEntityGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallEntityGroup>);
			}
			StringOffset sourceOffset = (_o.Source == null) ? default(StringOffset) : builder.CreateString(_o.Source);
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				int[] data = _o.Entities.ToArray();
				entitiesOffset = IRecallEntityGroup.CreateEntitiesVector(builder, data);
			}
			return IRecallEntityGroup.CreateIRecallEntityGroup(builder, _o.Index, sourceOffset, _o.LevelId, entitiesOffset);
		}

		// Token: 0x0400BC17 RID: 48151
		private Table __p;
	}
}
