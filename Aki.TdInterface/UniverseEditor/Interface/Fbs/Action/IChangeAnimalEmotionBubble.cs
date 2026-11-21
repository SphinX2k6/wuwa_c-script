using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200693D RID: 26941
	public struct IChangeAnimalEmotionBubble : IFlatbufferObject
	{
		// Token: 0x1700C654 RID: 50772
		// (get) Token: 0x0602E2CC RID: 189132 RVA: 0x0064EEEA File Offset: 0x0064D0EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E2CD RID: 189133 RVA: 0x0064EEF7 File Offset: 0x0064D0F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E2CE RID: 189134 RVA: 0x0064EF00 File Offset: 0x0064D100
		public static IChangeAnimalEmotionBubble GetRootAsIChangeAnimalEmotionBubble(ByteBuffer _bb)
		{
			return IChangeAnimalEmotionBubble.GetRootAsIChangeAnimalEmotionBubble(_bb, default(IChangeAnimalEmotionBubble));
		}

		// Token: 0x0602E2CF RID: 189135 RVA: 0x0064EF1C File Offset: 0x0064D11C
		public static IChangeAnimalEmotionBubble GetRootAsIChangeAnimalEmotionBubble(ByteBuffer _bb, IChangeAnimalEmotionBubble obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E2D0 RID: 189136 RVA: 0x0064EF39 File Offset: 0x0064D139
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E2D1 RID: 189137 RVA: 0x0064EF48 File Offset: 0x0064D148
		public IChangeAnimalEmotionBubble __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C655 RID: 50773
		// (get) Token: 0x0602E2D2 RID: 189138 RVA: 0x0064EF58 File Offset: 0x0064D158
		public EExecClientBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return (EExecClientBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E2D3 RID: 189139 RVA: 0x0064EF94 File Offset: 0x0064D194
		public int AnimalEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C656 RID: 50774
		// (get) Token: 0x0602E2D4 RID: 189140 RVA: 0x0064EFD4 File Offset: 0x0064D1D4
		public int AnimalEntityIdsLength
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

		// Token: 0x0602E2D5 RID: 189141 RVA: 0x0064EFFF File Offset: 0x0064D1FF
		public Span<int> GetAnimalEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602E2D6 RID: 189142 RVA: 0x0064F00E File Offset: 0x0064D20E
		public int[] GetAnimalEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700C657 RID: 50775
		// (get) Token: 0x0602E2D7 RID: 189143 RVA: 0x0064F01C File Offset: 0x0064D21C
		public string MontagePath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E2D8 RID: 189144 RVA: 0x0064F053 File Offset: 0x0064D253
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602E2D9 RID: 189145 RVA: 0x0064F062 File Offset: 0x0064D262
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C658 RID: 50776
		// (get) Token: 0x0602E2DA RID: 189146 RVA: 0x0064F070 File Offset: 0x0064D270
		public string EmotionName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E2DB RID: 189147 RVA: 0x0064F0A8 File Offset: 0x0064D2A8
		public Span<byte> GetEmotionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602E2DC RID: 189148 RVA: 0x0064F0B8 File Offset: 0x0064D2B8
		public byte[] GetEmotionNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0602E2DD RID: 189149 RVA: 0x0064F0C7 File Offset: 0x0064D2C7
		public static Offset<IChangeAnimalEmotionBubble> CreateIChangeAnimalEmotionBubble(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, VectorOffset AnimalEntityIdsOffset = default(VectorOffset), StringOffset MontagePathOffset = default(StringOffset), StringOffset EmotionNameOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IChangeAnimalEmotionBubble.AddEmotionName(builder, EmotionNameOffset);
			IChangeAnimalEmotionBubble.AddMontagePath(builder, MontagePathOffset);
			IChangeAnimalEmotionBubble.AddAnimalEntityIds(builder, AnimalEntityIdsOffset);
			IChangeAnimalEmotionBubble.AddType(builder, Type);
			return IChangeAnimalEmotionBubble.EndIChangeAnimalEmotionBubble(builder);
		}

		// Token: 0x0602E2DE RID: 189150 RVA: 0x0064F0F3 File Offset: 0x0064D2F3
		public static void StartIChangeAnimalEmotionBubble(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E2DF RID: 189151 RVA: 0x0064F0FC File Offset: 0x0064D2FC
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E2E0 RID: 189152 RVA: 0x0064F107 File Offset: 0x0064D307
		public static void AddAnimalEntityIds(FlatBufferBuilder builder, VectorOffset animalEntityIdsOffset)
		{
			builder.AddOffset(1, animalEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602E2E1 RID: 189153 RVA: 0x0064F118 File Offset: 0x0064D318
		public static VectorOffset CreateAnimalEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E2E2 RID: 189154 RVA: 0x0064F14F File Offset: 0x0064D34F
		public static VectorOffset CreateAnimalEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E2E3 RID: 189155 RVA: 0x0064F169 File Offset: 0x0064D369
		public static VectorOffset CreateAnimalEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E2E4 RID: 189156 RVA: 0x0064F187 File Offset: 0x0064D387
		public static VectorOffset CreateAnimalEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E2E5 RID: 189157 RVA: 0x0064F1A0 File Offset: 0x0064D3A0
		public static void StartAnimalEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E2E6 RID: 189158 RVA: 0x0064F1AB File Offset: 0x0064D3AB
		public static void AddMontagePath(FlatBufferBuilder builder, StringOffset montagePathOffset)
		{
			builder.AddOffset(2, montagePathOffset.Value, 0);
		}

		// Token: 0x0602E2E7 RID: 189159 RVA: 0x0064F1BB File Offset: 0x0064D3BB
		public static void AddEmotionName(FlatBufferBuilder builder, StringOffset emotionNameOffset)
		{
			builder.AddOffset(3, emotionNameOffset.Value, 0);
		}

		// Token: 0x0602E2E8 RID: 189160 RVA: 0x0064F1CB File Offset: 0x0064D3CB
		public static Offset<IChangeAnimalEmotionBubble> EndIChangeAnimalEmotionBubble(FlatBufferBuilder builder)
		{
			return new Offset<IChangeAnimalEmotionBubble>(builder.EndTable());
		}

		// Token: 0x0602E2E9 RID: 189161 RVA: 0x0064F1D8 File Offset: 0x0064D3D8
		public IChangeAnimalEmotionBubbleT UnPack()
		{
			IChangeAnimalEmotionBubbleT changeAnimalEmotionBubbleT = new IChangeAnimalEmotionBubbleT();
			this.UnPackTo(changeAnimalEmotionBubbleT);
			return changeAnimalEmotionBubbleT;
		}

		// Token: 0x0602E2EA RID: 189162 RVA: 0x0064F1F4 File Offset: 0x0064D3F4
		public void UnPackTo(IChangeAnimalEmotionBubbleT _o)
		{
			_o.Type = this.Type;
			_o.AnimalEntityIds = new List<int>();
			for (int i = 0; i < this.AnimalEntityIdsLength; i++)
			{
				_o.AnimalEntityIds.Add(this.AnimalEntityIds(i));
			}
			_o.MontagePath = this.MontagePath;
			_o.EmotionName = this.EmotionName;
		}

		// Token: 0x0602E2EB RID: 189163 RVA: 0x0064F254 File Offset: 0x0064D454
		public static Offset<IChangeAnimalEmotionBubble> Pack(FlatBufferBuilder builder, IChangeAnimalEmotionBubbleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeAnimalEmotionBubble>);
			}
			VectorOffset animalEntityIdsOffset = default(VectorOffset);
			if (_o.AnimalEntityIds != null)
			{
				int[] data = _o.AnimalEntityIds.ToArray();
				animalEntityIdsOffset = IChangeAnimalEmotionBubble.CreateAnimalEntityIdsVector(builder, data);
			}
			StringOffset montagePathOffset = (_o.MontagePath == null) ? default(StringOffset) : builder.CreateString(_o.MontagePath);
			StringOffset emotionNameOffset = (_o.EmotionName == null) ? default(StringOffset) : builder.CreateString(_o.EmotionName);
			return IChangeAnimalEmotionBubble.CreateIChangeAnimalEmotionBubble(builder, _o.Type, animalEntityIdsOffset, montagePathOffset, emotionNameOffset);
		}

		// Token: 0x04011688 RID: 71304
		private Table __p;
	}
}
