using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007630 RID: 30256
	public struct IResetPresentationFailure : IFlatbufferObject
	{
		// Token: 0x1700DE41 RID: 56897
		// (get) Token: 0x06035163 RID: 217443 RVA: 0x00721350 File Offset: 0x0071F550
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035164 RID: 217444 RVA: 0x0072135D File Offset: 0x0071F55D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035165 RID: 217445 RVA: 0x00721364 File Offset: 0x0071F564
		public static IResetPresentationFailure GetRootAsIResetPresentationFailure(ByteBuffer _bb)
		{
			return IResetPresentationFailure.GetRootAsIResetPresentationFailure(_bb, default(IResetPresentationFailure));
		}

		// Token: 0x06035166 RID: 217446 RVA: 0x00721380 File Offset: 0x0071F580
		public static IResetPresentationFailure GetRootAsIResetPresentationFailure(ByteBuffer _bb, IResetPresentationFailure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035167 RID: 217447 RVA: 0x0072139D File Offset: 0x0071F59D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035168 RID: 217448 RVA: 0x007213AC File Offset: 0x0071F5AC
		public IResetPresentationFailure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE42 RID: 56898
		// (get) Token: 0x06035169 RID: 217449 RVA: 0x007213BC File Offset: 0x0071F5BC
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

		// Token: 0x1700DE43 RID: 56899
		// (get) Token: 0x0603516A RID: 217450 RVA: 0x007213F8 File Offset: 0x0071F5F8
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

		// Token: 0x0603516B RID: 217451 RVA: 0x00721438 File Offset: 0x0071F638
		public int GamePlayCues(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DE44 RID: 56900
		// (get) Token: 0x0603516C RID: 217452 RVA: 0x00721478 File Offset: 0x0071F678
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

		// Token: 0x0603516D RID: 217453 RVA: 0x007214A3 File Offset: 0x0071F6A3
		public Span<int> GetGamePlayCuesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0603516E RID: 217454 RVA: 0x007214B2 File Offset: 0x0071F6B2
		public int[] GetGamePlayCuesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0603516F RID: 217455 RVA: 0x007214C0 File Offset: 0x0071F6C0
		public static Offset<IResetPresentationFailure> CreateIResetPresentationFailure(FlatBufferBuilder builder, EResetPresentationType Type = EResetPresentationType.Failure, float Duration = 0f, VectorOffset GamePlayCuesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IResetPresentationFailure.AddGamePlayCues(builder, GamePlayCuesOffset);
			IResetPresentationFailure.AddDuration(builder, Duration);
			IResetPresentationFailure.AddType(builder, Type);
			return IResetPresentationFailure.EndIResetPresentationFailure(builder);
		}

		// Token: 0x06035170 RID: 217456 RVA: 0x007214E4 File Offset: 0x0071F6E4
		public static void StartIResetPresentationFailure(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035171 RID: 217457 RVA: 0x007214ED File Offset: 0x0071F6ED
		public static void AddType(FlatBufferBuilder builder, EResetPresentationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035172 RID: 217458 RVA: 0x007214F8 File Offset: 0x0071F6F8
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x06035173 RID: 217459 RVA: 0x0072150B File Offset: 0x0071F70B
		public static void AddGamePlayCues(FlatBufferBuilder builder, VectorOffset gamePlayCuesOffset)
		{
			builder.AddOffset(2, gamePlayCuesOffset.Value, 0);
		}

		// Token: 0x06035174 RID: 217460 RVA: 0x0072151C File Offset: 0x0071F71C
		public static VectorOffset CreateGamePlayCuesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035175 RID: 217461 RVA: 0x00721553 File Offset: 0x0071F753
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035176 RID: 217462 RVA: 0x0072156D File Offset: 0x0071F76D
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035177 RID: 217463 RVA: 0x0072158B File Offset: 0x0071F78B
		public static VectorOffset CreateGamePlayCuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035178 RID: 217464 RVA: 0x007215A4 File Offset: 0x0071F7A4
		public static void StartGamePlayCuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035179 RID: 217465 RVA: 0x007215AF File Offset: 0x0071F7AF
		public static Offset<IResetPresentationFailure> EndIResetPresentationFailure(FlatBufferBuilder builder)
		{
			return new Offset<IResetPresentationFailure>(builder.EndTable());
		}

		// Token: 0x0603517A RID: 217466 RVA: 0x007215BC File Offset: 0x0071F7BC
		public IResetPresentationFailureT UnPack()
		{
			IResetPresentationFailureT resetPresentationFailureT = new IResetPresentationFailureT();
			this.UnPackTo(resetPresentationFailureT);
			return resetPresentationFailureT;
		}

		// Token: 0x0603517B RID: 217467 RVA: 0x007215D8 File Offset: 0x0071F7D8
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

		// Token: 0x0603517C RID: 217468 RVA: 0x0072162C File Offset: 0x0071F82C
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

		// Token: 0x04012826 RID: 75814
		private Table __p;
	}
}
