using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062CC RID: 25292
	public struct IChangeAnimalEmotionBubble : IFlatbufferObject
	{
		// Token: 0x1700BCCA RID: 48330
		// (get) Token: 0x0602BB63 RID: 179043 RVA: 0x00603EDE File Offset: 0x006020DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB64 RID: 179044 RVA: 0x00603EEB File Offset: 0x006020EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB65 RID: 179045 RVA: 0x00603EF4 File Offset: 0x006020F4
		public static IChangeAnimalEmotionBubble GetRootAsIChangeAnimalEmotionBubble(ByteBuffer _bb)
		{
			return IChangeAnimalEmotionBubble.GetRootAsIChangeAnimalEmotionBubble(_bb, default(IChangeAnimalEmotionBubble));
		}

		// Token: 0x0602BB66 RID: 179046 RVA: 0x00603F10 File Offset: 0x00602110
		public static IChangeAnimalEmotionBubble GetRootAsIChangeAnimalEmotionBubble(ByteBuffer _bb, IChangeAnimalEmotionBubble obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB67 RID: 179047 RVA: 0x00603F2D File Offset: 0x0060212D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB68 RID: 179048 RVA: 0x00603F3C File Offset: 0x0060213C
		public IChangeAnimalEmotionBubble __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCCB RID: 48331
		// (get) Token: 0x0602BB69 RID: 179049 RVA: 0x00603F4C File Offset: 0x0060214C
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

		// Token: 0x0602BB6A RID: 179050 RVA: 0x00603F88 File Offset: 0x00602188
		public int AnimalEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BCCC RID: 48332
		// (get) Token: 0x0602BB6B RID: 179051 RVA: 0x00603FC8 File Offset: 0x006021C8
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

		// Token: 0x0602BB6C RID: 179052 RVA: 0x00603FF3 File Offset: 0x006021F3
		public Span<int> GetAnimalEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602BB6D RID: 179053 RVA: 0x00604002 File Offset: 0x00602202
		public int[] GetAnimalEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700BCCD RID: 48333
		// (get) Token: 0x0602BB6E RID: 179054 RVA: 0x00604010 File Offset: 0x00602210
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

		// Token: 0x0602BB6F RID: 179055 RVA: 0x00604047 File Offset: 0x00602247
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602BB70 RID: 179056 RVA: 0x00604056 File Offset: 0x00602256
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700BCCE RID: 48334
		// (get) Token: 0x0602BB71 RID: 179057 RVA: 0x00604064 File Offset: 0x00602264
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

		// Token: 0x0602BB72 RID: 179058 RVA: 0x0060409C File Offset: 0x0060229C
		public Span<byte> GetEmotionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602BB73 RID: 179059 RVA: 0x006040AC File Offset: 0x006022AC
		public byte[] GetEmotionNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0602BB74 RID: 179060 RVA: 0x006040BB File Offset: 0x006022BB
		public static Offset<IChangeAnimalEmotionBubble> CreateIChangeAnimalEmotionBubble(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, VectorOffset AnimalEntityIdsOffset = default(VectorOffset), StringOffset MontagePathOffset = default(StringOffset), StringOffset EmotionNameOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IChangeAnimalEmotionBubble.AddEmotionName(builder, EmotionNameOffset);
			IChangeAnimalEmotionBubble.AddMontagePath(builder, MontagePathOffset);
			IChangeAnimalEmotionBubble.AddAnimalEntityIds(builder, AnimalEntityIdsOffset);
			IChangeAnimalEmotionBubble.AddType(builder, Type);
			return IChangeAnimalEmotionBubble.EndIChangeAnimalEmotionBubble(builder);
		}

		// Token: 0x0602BB75 RID: 179061 RVA: 0x006040E7 File Offset: 0x006022E7
		public static void StartIChangeAnimalEmotionBubble(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602BB76 RID: 179062 RVA: 0x006040F0 File Offset: 0x006022F0
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BB77 RID: 179063 RVA: 0x006040FB File Offset: 0x006022FB
		public static void AddAnimalEntityIds(FlatBufferBuilder builder, VectorOffset animalEntityIdsOffset)
		{
			builder.AddOffset(1, animalEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602BB78 RID: 179064 RVA: 0x0060410C File Offset: 0x0060230C
		public static VectorOffset CreateAnimalEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BB79 RID: 179065 RVA: 0x00604143 File Offset: 0x00602343
		public static VectorOffset CreateAnimalEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BB7A RID: 179066 RVA: 0x0060415D File Offset: 0x0060235D
		public static VectorOffset CreateAnimalEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BB7B RID: 179067 RVA: 0x0060417B File Offset: 0x0060237B
		public static VectorOffset CreateAnimalEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BB7C RID: 179068 RVA: 0x00604194 File Offset: 0x00602394
		public static void StartAnimalEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BB7D RID: 179069 RVA: 0x0060419F File Offset: 0x0060239F
		public static void AddMontagePath(FlatBufferBuilder builder, StringOffset montagePathOffset)
		{
			builder.AddOffset(2, montagePathOffset.Value, 0);
		}

		// Token: 0x0602BB7E RID: 179070 RVA: 0x006041AF File Offset: 0x006023AF
		public static void AddEmotionName(FlatBufferBuilder builder, StringOffset emotionNameOffset)
		{
			builder.AddOffset(3, emotionNameOffset.Value, 0);
		}

		// Token: 0x0602BB7F RID: 179071 RVA: 0x006041BF File Offset: 0x006023BF
		public static Offset<IChangeAnimalEmotionBubble> EndIChangeAnimalEmotionBubble(FlatBufferBuilder builder)
		{
			return new Offset<IChangeAnimalEmotionBubble>(builder.EndTable());
		}

		// Token: 0x0602BB80 RID: 179072 RVA: 0x006041CC File Offset: 0x006023CC
		public IChangeAnimalEmotionBubbleT UnPack()
		{
			IChangeAnimalEmotionBubbleT changeAnimalEmotionBubbleT = new IChangeAnimalEmotionBubbleT();
			this.UnPackTo(changeAnimalEmotionBubbleT);
			return changeAnimalEmotionBubbleT;
		}

		// Token: 0x0602BB81 RID: 179073 RVA: 0x006041E8 File Offset: 0x006023E8
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

		// Token: 0x0602BB82 RID: 179074 RVA: 0x00604248 File Offset: 0x00602448
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

		// Token: 0x04010872 RID: 67698
		private Table __p;
	}
}
