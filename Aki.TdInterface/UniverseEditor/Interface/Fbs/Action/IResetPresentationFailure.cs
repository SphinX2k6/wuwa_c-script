using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EAC RID: 28332
	public struct IResetPresentationFailure : IFlatbufferObject
	{
		// Token: 0x1700D2EA RID: 53994
		// (get) Token: 0x06032123 RID: 205091 RVA: 0x006C561C File Offset: 0x006C381C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032124 RID: 205092 RVA: 0x006C5629 File Offset: 0x006C3829
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032125 RID: 205093 RVA: 0x006C5630 File Offset: 0x006C3830
		public static IResetPresentationFailure GetRootAsIResetPresentationFailure(ByteBuffer _bb)
		{
			return IResetPresentationFailure.GetRootAsIResetPresentationFailure(_bb, default(IResetPresentationFailure));
		}

		// Token: 0x06032126 RID: 205094 RVA: 0x006C564C File Offset: 0x006C384C
		public static IResetPresentationFailure GetRootAsIResetPresentationFailure(ByteBuffer _bb, IResetPresentationFailure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032127 RID: 205095 RVA: 0x006C5669 File Offset: 0x006C3869
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032128 RID: 205096 RVA: 0x006C5678 File Offset: 0x006C3878
		public IResetPresentationFailure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2EB RID: 53995
		// (get) Token: 0x06032129 RID: 205097 RVA: 0x006C5688 File Offset: 0x006C3888
		public EResetPresentationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPresentationType.Failure;
				}
				return (EResetPresentationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D2EC RID: 53996
		// (get) Token: 0x0603212A RID: 205098 RVA: 0x006C56C4 File Offset: 0x006C38C4
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603212B RID: 205099 RVA: 0x006C5704 File Offset: 0x006C3904
		public int GamePlayCues(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D2ED RID: 53997
		// (get) Token: 0x0603212C RID: 205100 RVA: 0x006C5744 File Offset: 0x006C3944
		public int GamePlayCuesLength
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

		// Token: 0x0603212D RID: 205101 RVA: 0x006C576F File Offset: 0x006C396F
		public Span<int> GetGamePlayCuesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0603212E RID: 205102 RVA: 0x006C577E File Offset: 0x006C397E
		public int[] GetGamePlayCuesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0603212F RID: 205103 RVA: 0x006C578C File Offset: 0x006C398C
		public static Offset<IResetPresentationFailure> CreateIResetPresentationFailure(FlatBufferBuilder builder, EResetPresentationType Type = EResetPresentationType.Failure, float Duration = 0f, VectorOffset GamePlayCuesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IResetPresentationFailure.AddGamePlayCues(builder, GamePlayCuesOffset);
			IResetPresentationFailure.AddDuration(builder, Duration);
			IResetPresentationFailure.AddType(builder, Type);
			return IResetPresentationFailure.EndIResetPresentationFailure(builder);
		}

		// Token: 0x06032130 RID: 205104 RVA: 0x006C57B0 File Offset: 0x006C39B0
		public static void StartIResetPresentationFailure(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032131 RID: 205105 RVA: 0x006C57B9 File Offset: 0x006C39B9
		public static void AddType(FlatBufferBuilder builder, EResetPresentationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032132 RID: 205106 RVA: 0x006C57C4 File Offset: 0x006C39C4
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x06032133 RID: 205107 RVA: 0x006C57D7 File Offset: 0x006C39D7
		public static void AddGamePlayCues(FlatBufferBuilder builder, VectorOffset gamePlayCuesOffset)
		{
			builder.AddOffset(2, gamePlayCuesOffset.Value, 0);
		}

		// Token: 0x06032134 RID: 205108 RVA: 0x006C57E8 File Offset: 0x006C39E8
		public static VectorOffset CreateGamePlayCuesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032135 RID: 205109 RVA: 0x006C581F File Offset: 0x006C3A1F
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032136 RID: 205110 RVA: 0x006C5839 File Offset: 0x006C3A39
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032137 RID: 205111 RVA: 0x006C5857 File Offset: 0x006C3A57
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032138 RID: 205112 RVA: 0x006C5870 File Offset: 0x006C3A70
		public static void StartGamePlayCuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032139 RID: 205113 RVA: 0x006C587B File Offset: 0x006C3A7B
		public static Offset<IResetPresentationFailure> EndIResetPresentationFailure(FlatBufferBuilder builder)
		{
			return new Offset<IResetPresentationFailure>(builder.EndTable());
		}

		// Token: 0x0603213A RID: 205114 RVA: 0x006C5888 File Offset: 0x006C3A88
		public IResetPresentationFailureT UnPack()
		{
			IResetPresentationFailureT resetPresentationFailureT = new IResetPresentationFailureT();
			this.UnPackTo(resetPresentationFailureT);
			return resetPresentationFailureT;
		}

		// Token: 0x0603213B RID: 205115 RVA: 0x006C58A4 File Offset: 0x006C3AA4
		public void UnPackTo(IResetPresentationFailureT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
			_o.GamePlayCues = new List<int>();
			for (int i = 0; i < this.GamePlayCuesLength; i++)
			{
				_o.GamePlayCues.Add(this.GamePlayCues(i));
			}
		}

		// Token: 0x0603213C RID: 205116 RVA: 0x006C58F8 File Offset: 0x006C3AF8
		public static Offset<IResetPresentationFailure> Pack(FlatBufferBuilder builder, IResetPresentationFailureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPresentationFailure>);
			}
			VectorOffset gamePlayCuesOffset = default(VectorOffset);
			if (_o.GamePlayCues != null)
			{
				int[] data = _o.GamePlayCues.ToArray();
				gamePlayCuesOffset = IResetPresentationFailure.CreateGamePlayCuesVector(builder, data);
			}
			return IResetPresentationFailure.CreateIResetPresentationFailure(builder, _o.Type, _o.Duration, gamePlayCuesOffset);
		}

		// Token: 0x040118A1 RID: 71841
		private Table __p;
	}
}
