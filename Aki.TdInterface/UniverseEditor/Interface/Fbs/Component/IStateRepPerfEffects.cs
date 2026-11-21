using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FC0 RID: 24512
	public struct IStateRepPerfEffects : IFlatbufferObject
	{
		// Token: 0x1700B584 RID: 46468
		// (get) Token: 0x060293D6 RID: 168918 RVA: 0x005A1076 File Offset: 0x0059F276
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060293D7 RID: 168919 RVA: 0x005A1083 File Offset: 0x0059F283
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060293D8 RID: 168920 RVA: 0x005A108C File Offset: 0x0059F28C
		public static IStateRepPerfEffects GetRootAsIStateRepPerfEffects(ByteBuffer _bb)
		{
			return IStateRepPerfEffects.GetRootAsIStateRepPerfEffects(_bb, default(IStateRepPerfEffects));
		}

		// Token: 0x060293D9 RID: 168921 RVA: 0x005A10A8 File Offset: 0x0059F2A8
		public static IStateRepPerfEffects GetRootAsIStateRepPerfEffects(ByteBuffer _bb, IStateRepPerfEffects obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060293DA RID: 168922 RVA: 0x005A10C5 File Offset: 0x0059F2C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060293DB RID: 168923 RVA: 0x005A10D4 File Offset: 0x0059F2D4
		public IStateRepPerfEffects __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B585 RID: 46469
		// (get) Token: 0x060293DC RID: 168924 RVA: 0x005A10E4 File Offset: 0x0059F2E4
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

		// Token: 0x060293DD RID: 168925 RVA: 0x005A1120 File Offset: 0x0059F320
		public int GamePlayCues(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B586 RID: 46470
		// (get) Token: 0x060293DE RID: 168926 RVA: 0x005A1160 File Offset: 0x0059F360
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

		// Token: 0x060293DF RID: 168927 RVA: 0x005A118B File Offset: 0x0059F38B
		public Span<int> GetGamePlayCuesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060293E0 RID: 168928 RVA: 0x005A119A File Offset: 0x0059F39A
		public int[] GetGamePlayCuesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060293E1 RID: 168929 RVA: 0x005A11A8 File Offset: 0x0059F3A8
		public static Offset<IStateRepPerfEffects> CreateIStateRepPerfEffects(FlatBufferBuilder builder, EStateRepPerfType Type = EStateRepPerfType.SkillId, VectorOffset GamePlayCuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IStateRepPerfEffects.AddGamePlayCues(builder, GamePlayCuesOffset);
			IStateRepPerfEffects.AddType(builder, Type);
			return IStateRepPerfEffects.EndIStateRepPerfEffects(builder);
		}

		// Token: 0x060293E2 RID: 168930 RVA: 0x005A11C5 File Offset: 0x0059F3C5
		public static void StartIStateRepPerfEffects(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060293E3 RID: 168931 RVA: 0x005A11CE File Offset: 0x0059F3CE
		public static void AddType(FlatBufferBuilder builder, EStateRepPerfType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060293E4 RID: 168932 RVA: 0x005A11D9 File Offset: 0x0059F3D9
		public static void AddGamePlayCues(FlatBufferBuilder builder, VectorOffset gamePlayCuesOffset)
		{
			builder.AddOffset(1, gamePlayCuesOffset.Value, 0);
		}

		// Token: 0x060293E5 RID: 168933 RVA: 0x005A11EC File Offset: 0x0059F3EC
		public static VectorOffset CreateGamePlayCuesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060293E6 RID: 168934 RVA: 0x005A1223 File Offset: 0x0059F423
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060293E7 RID: 168935 RVA: 0x005A123D File Offset: 0x0059F43D
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060293E8 RID: 168936 RVA: 0x005A125B File Offset: 0x0059F45B
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060293E9 RID: 168937 RVA: 0x005A1274 File Offset: 0x0059F474
		public static void StartGamePlayCuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060293EA RID: 168938 RVA: 0x005A127F File Offset: 0x0059F47F
		public static Offset<IStateRepPerfEffects> EndIStateRepPerfEffects(FlatBufferBuilder builder)
		{
			return new Offset<IStateRepPerfEffects>(builder.EndTable());
		}

		// Token: 0x060293EB RID: 168939 RVA: 0x005A128C File Offset: 0x0059F48C
		public IStateRepPerfEffectsT UnPack()
		{
			IStateRepPerfEffectsT stateRepPerfEffectsT = new IStateRepPerfEffectsT();
			this.UnPackTo(stateRepPerfEffectsT);
			return stateRepPerfEffectsT;
		}

		// Token: 0x060293EC RID: 168940 RVA: 0x005A12A8 File Offset: 0x0059F4A8
		public void UnPackTo(IStateRepPerfEffectsT _o)
		{
			_o.Type = this.Type;
			_o.GamePlayCues = new List<int>();
			for (int i = 0; i < this.GamePlayCuesLength; i++)
			{
				_o.GamePlayCues.Add(this.GamePlayCues(i));
			}
		}

		// Token: 0x060293ED RID: 168941 RVA: 0x005A12F0 File Offset: 0x0059F4F0
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

		// Token: 0x0400FCBB RID: 64699
		private Table __p;
	}
}
