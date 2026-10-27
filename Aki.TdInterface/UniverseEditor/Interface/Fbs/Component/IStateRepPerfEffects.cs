using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B3 RID: 22963
	public struct IStateRepPerfEffects : IFlatbufferObject
	{
		// Token: 0x1700AC50 RID: 44112
		// (get) Token: 0x06026E6C RID: 159340 RVA: 0x0055A40A File Offset: 0x0055860A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026E6D RID: 159341 RVA: 0x0055A417 File Offset: 0x00558617
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026E6E RID: 159342 RVA: 0x0055A420 File Offset: 0x00558620
		public static IStateRepPerfEffects GetRootAsIStateRepPerfEffects(ByteBuffer _bb)
		{
			return IStateRepPerfEffects.GetRootAsIStateRepPerfEffects(_bb, default(IStateRepPerfEffects));
		}

		// Token: 0x06026E6F RID: 159343 RVA: 0x0055A43C File Offset: 0x0055863C
		public static IStateRepPerfEffects GetRootAsIStateRepPerfEffects(ByteBuffer _bb, IStateRepPerfEffects obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026E70 RID: 159344 RVA: 0x0055A459 File Offset: 0x00558659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026E71 RID: 159345 RVA: 0x0055A468 File Offset: 0x00558668
		public IStateRepPerfEffects __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC51 RID: 44113
		// (get) Token: 0x06026E72 RID: 159346 RVA: 0x0055A478 File Offset: 0x00558678
		public EStateRepPerfType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStateRepPerfType.SkillId;
				}
				return (EStateRepPerfType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026E73 RID: 159347 RVA: 0x0055A4B4 File Offset: 0x005586B4
		public int GamePlayCues(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AC52 RID: 44114
		// (get) Token: 0x06026E74 RID: 159348 RVA: 0x0055A4F4 File Offset: 0x005586F4
		public int GamePlayCuesLength
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

		// Token: 0x06026E75 RID: 159349 RVA: 0x0055A51F File Offset: 0x0055871F
		public Span<int> GetGamePlayCuesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06026E76 RID: 159350 RVA: 0x0055A52E File Offset: 0x0055872E
		public int[] GetGamePlayCuesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06026E77 RID: 159351 RVA: 0x0055A53C File Offset: 0x0055873C
		public static Offset<IStateRepPerfEffects> CreateIStateRepPerfEffects(FlatBufferBuilder builder, EStateRepPerfType Type = EStateRepPerfType.SkillId, VectorOffset GamePlayCuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IStateRepPerfEffects.AddGamePlayCues(builder, GamePlayCuesOffset);
			IStateRepPerfEffects.AddType(builder, Type);
			return IStateRepPerfEffects.EndIStateRepPerfEffects(builder);
		}

		// Token: 0x06026E78 RID: 159352 RVA: 0x0055A559 File Offset: 0x00558759
		public static void StartIStateRepPerfEffects(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026E79 RID: 159353 RVA: 0x0055A562 File Offset: 0x00558762
		public static void AddType(FlatBufferBuilder builder, EStateRepPerfType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026E7A RID: 159354 RVA: 0x0055A56D File Offset: 0x0055876D
		public static void AddGamePlayCues(FlatBufferBuilder builder, VectorOffset gamePlayCuesOffset)
		{
			builder.AddOffset(1, gamePlayCuesOffset.Value, 0);
		}

		// Token: 0x06026E7B RID: 159355 RVA: 0x0055A580 File Offset: 0x00558780
		public static VectorOffset CreateGamePlayCuesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026E7C RID: 159356 RVA: 0x0055A5B7 File Offset: 0x005587B7
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026E7D RID: 159357 RVA: 0x0055A5D1 File Offset: 0x005587D1
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026E7E RID: 159358 RVA: 0x0055A5EF File Offset: 0x005587EF
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026E7F RID: 159359 RVA: 0x0055A608 File Offset: 0x00558808
		public static void StartGamePlayCuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026E80 RID: 159360 RVA: 0x0055A613 File Offset: 0x00558813
		public static Offset<IStateRepPerfEffects> EndIStateRepPerfEffects(FlatBufferBuilder builder)
		{
			return new Offset<IStateRepPerfEffects>(builder.EndTable());
		}

		// Token: 0x06026E81 RID: 159361 RVA: 0x0055A620 File Offset: 0x00558820
		public IStateRepPerfEffectsT UnPack()
		{
			IStateRepPerfEffectsT stateRepPerfEffectsT = new IStateRepPerfEffectsT();
			this.UnPackTo(stateRepPerfEffectsT);
			return stateRepPerfEffectsT;
		}

		// Token: 0x06026E82 RID: 159362 RVA: 0x0055A63C File Offset: 0x0055883C
		public void UnPackTo(IStateRepPerfEffectsT _o)
		{
			_o.Type = this.Type;
			_o.GamePlayCues = new List<int>();
			for (int i = 0; i < this.GamePlayCuesLength; i++)
			{
				_o.GamePlayCues.Add(this.GamePlayCues(i));
			}
		}

		// Token: 0x06026E83 RID: 159363 RVA: 0x0055A684 File Offset: 0x00558884
		public static Offset<IStateRepPerfEffects> Pack(FlatBufferBuilder builder, IStateRepPerfEffectsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateRepPerfEffects>);
			}
			VectorOffset gamePlayCuesOffset = default(VectorOffset);
			if (_o.GamePlayCues != null)
			{
				int[] data = _o.GamePlayCues.ToArray();
				gamePlayCuesOffset = IStateRepPerfEffects.CreateGamePlayCuesVector(builder, data);
			}
			return IStateRepPerfEffects.CreateIStateRepPerfEffects(builder, _o.Type, gamePlayCuesOffset);
		}

		// Token: 0x0400EFC6 RID: 61382
		private Table __p;
	}
}
