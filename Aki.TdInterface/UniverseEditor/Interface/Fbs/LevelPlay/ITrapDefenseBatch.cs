using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045B4 RID: 17844
	public struct ITrapDefenseBatch : IFlatbufferObject
	{
		// Token: 0x17007ED5 RID: 32469
		// (get) Token: 0x0601AFAF RID: 110511 RVA: 0x003D8EBC File Offset: 0x003D70BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AFB0 RID: 110512 RVA: 0x003D8EC9 File Offset: 0x003D70C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AFB1 RID: 110513 RVA: 0x003D8ED0 File Offset: 0x003D70D0
		public static ITrapDefenseBatch GetRootAsITrapDefenseBatch(ByteBuffer _bb)
		{
			return ITrapDefenseBatch.GetRootAsITrapDefenseBatch(_bb, default(ITrapDefenseBatch));
		}

		// Token: 0x0601AFB2 RID: 110514 RVA: 0x003D8EEC File Offset: 0x003D70EC
		public static ITrapDefenseBatch GetRootAsITrapDefenseBatch(ByteBuffer _bb, ITrapDefenseBatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AFB3 RID: 110515 RVA: 0x003D8F09 File Offset: 0x003D7109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AFB4 RID: 110516 RVA: 0x003D8F18 File Offset: 0x003D7118
		public ITrapDefenseBatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601AFB5 RID: 110517 RVA: 0x003D8F28 File Offset: 0x003D7128
		public int Ids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007ED6 RID: 32470
		// (get) Token: 0x0601AFB6 RID: 110518 RVA: 0x003D8F68 File Offset: 0x003D7168
		public int IdsLength
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

		// Token: 0x0601AFB7 RID: 110519 RVA: 0x003D8F93 File Offset: 0x003D7193
		public Span<int> GetIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0601AFB8 RID: 110520 RVA: 0x003D8FA2 File Offset: 0x003D71A2
		public int[] GetIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x17007ED7 RID: 32471
		// (get) Token: 0x0601AFB9 RID: 110521 RVA: 0x003D8FB0 File Offset: 0x003D71B0
		public int RepeatTimes
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AFBA RID: 110522 RVA: 0x003D8FEC File Offset: 0x003D71EC
		public static Offset<ITrapDefenseBatch> CreateITrapDefenseBatch(FlatBufferBuilder builder, VectorOffset IdsOffset = default(VectorOffset), int RepeatTimes = 0)
		{
			builder.StartTable(2);
			ITrapDefenseBatch.AddRepeatTimes(builder, RepeatTimes);
			ITrapDefenseBatch.AddIds(builder, IdsOffset);
			return ITrapDefenseBatch.EndITrapDefenseBatch(builder);
		}

		// Token: 0x0601AFBB RID: 110523 RVA: 0x003D9009 File Offset: 0x003D7209
		public static void StartITrapDefenseBatch(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AFBC RID: 110524 RVA: 0x003D9012 File Offset: 0x003D7212
		public static void AddIds(FlatBufferBuilder builder, VectorOffset idsOffset)
		{
			builder.AddOffset(0, idsOffset.Value, 0);
		}

		// Token: 0x0601AFBD RID: 110525 RVA: 0x003D9024 File Offset: 0x003D7224
		public static VectorOffset CreateIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AFBE RID: 110526 RVA: 0x003D905B File Offset: 0x003D725B
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AFBF RID: 110527 RVA: 0x003D9075 File Offset: 0x003D7275
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AFC0 RID: 110528 RVA: 0x003D9093 File Offset: 0x003D7293
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AFC1 RID: 110529 RVA: 0x003D90AC File Offset: 0x003D72AC
		public static void StartIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AFC2 RID: 110530 RVA: 0x003D90B7 File Offset: 0x003D72B7
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(1, repeatTimes, 0);
		}

		// Token: 0x0601AFC3 RID: 110531 RVA: 0x003D90C2 File Offset: 0x003D72C2
		public static Offset<ITrapDefenseBatch> EndITrapDefenseBatch(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseBatch>(builder.EndTable());
		}

		// Token: 0x0601AFC4 RID: 110532 RVA: 0x003D90D0 File Offset: 0x003D72D0
		public ITrapDefenseBatchT UnPack()
		{
			ITrapDefenseBatchT trapDefenseBatchT = new ITrapDefenseBatchT();
			this.UnPackTo(trapDefenseBatchT);
			return trapDefenseBatchT;
		}

		// Token: 0x0601AFC5 RID: 110533 RVA: 0x003D90EC File Offset: 0x003D72EC
		public void UnPackTo(ITrapDefenseBatchT _o)
		{
			_o.Ids = new List<int>();
			for (int i = 0; i < this.IdsLength; i++)
			{
				_o.Ids.Add(this.Ids(i));
			}
			_o.RepeatTimes = this.RepeatTimes;
		}

		// Token: 0x0601AFC6 RID: 110534 RVA: 0x003D9134 File Offset: 0x003D7334
		public static Offset<ITrapDefenseBatch> Pack(FlatBufferBuilder builder, ITrapDefenseBatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseBatch>);
			}
			VectorOffset idsOffset = default(VectorOffset);
			if (_o.Ids != null)
			{
				int[] data = _o.Ids.ToArray();
				idsOffset = ITrapDefenseBatch.CreateIdsVector(builder, data);
			}
			return ITrapDefenseBatch.CreateITrapDefenseBatch(builder, idsOffset, _o.RepeatTimes);
		}

		// Token: 0x0400C67E RID: 50814
		private Table __p;
	}
}
