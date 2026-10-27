using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E51 RID: 24145
	public struct IReignsEnding : IFlatbufferObject
	{
		// Token: 0x1700B48A RID: 46218
		// (get) Token: 0x0602957B RID: 169339 RVA: 0x005AB056 File Offset: 0x005A9256
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602957C RID: 169340 RVA: 0x005AB063 File Offset: 0x005A9263
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602957D RID: 169341 RVA: 0x005AB06C File Offset: 0x005A926C
		public static IReignsEnding GetRootAsIReignsEnding(ByteBuffer _bb)
		{
			return IReignsEnding.GetRootAsIReignsEnding(_bb, default(IReignsEnding));
		}

		// Token: 0x0602957E RID: 169342 RVA: 0x005AB088 File Offset: 0x005A9288
		public static IReignsEnding GetRootAsIReignsEnding(ByteBuffer _bb, IReignsEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602957F RID: 169343 RVA: 0x005AB0A5 File Offset: 0x005A92A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029580 RID: 169344 RVA: 0x005AB0B4 File Offset: 0x005A92B4
		public IReignsEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B48B RID: 46219
		// (get) Token: 0x06029581 RID: 169345 RVA: 0x005AB0C4 File Offset: 0x005A92C4
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B48C RID: 46220
		// (get) Token: 0x06029582 RID: 169346 RVA: 0x005AB104 File Offset: 0x005A9304
		public IReignsEndingCondition? Conditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IReignsEndingCondition?(default(IReignsEndingCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B48D RID: 46221
		// (get) Token: 0x06029583 RID: 169347 RVA: 0x005AB164 File Offset: 0x005A9364
		public int CardId
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

		// Token: 0x06029584 RID: 169348 RVA: 0x005AB1A0 File Offset: 0x005A93A0
		public int CardIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B48E RID: 46222
		// (get) Token: 0x06029585 RID: 169349 RVA: 0x005AB1E0 File Offset: 0x005A93E0
		public int CardIdsLength
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

		// Token: 0x06029586 RID: 169350 RVA: 0x005AB20C File Offset: 0x005A940C
		public Span<int> GetCardIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06029587 RID: 169351 RVA: 0x005AB21C File Offset: 0x005A941C
		public int[] GetCardIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06029588 RID: 169352 RVA: 0x005AB22B File Offset: 0x005A942B
		public static Offset<IReignsEnding> CreateIReignsEnding(FlatBufferBuilder builder, bool IsSuccess = false, Offset<IReignsEndingCondition> ConditionsOffset = default(Offset<IReignsEndingCondition>), int CardId = 0, VectorOffset CardIdsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IReignsEnding.AddCardIds(builder, CardIdsOffset);
			IReignsEnding.AddCardId(builder, CardId);
			IReignsEnding.AddConditions(builder, ConditionsOffset);
			IReignsEnding.AddIsSuccess(builder, IsSuccess);
			return IReignsEnding.EndIReignsEnding(builder);
		}

		// Token: 0x06029589 RID: 169353 RVA: 0x005AB257 File Offset: 0x005A9457
		public static void StartIReignsEnding(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602958A RID: 169354 RVA: 0x005AB260 File Offset: 0x005A9460
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x0602958B RID: 169355 RVA: 0x005AB26B File Offset: 0x005A946B
		public static void AddConditions(FlatBufferBuilder builder, Offset<IReignsEndingCondition> conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0602958C RID: 169356 RVA: 0x005AB27B File Offset: 0x005A947B
		public static void AddCardId(FlatBufferBuilder builder, int cardId)
		{
			builder.AddInt(2, cardId, 0);
		}

		// Token: 0x0602958D RID: 169357 RVA: 0x005AB286 File Offset: 0x005A9486
		public static void AddCardIds(FlatBufferBuilder builder, VectorOffset cardIdsOffset)
		{
			builder.AddOffset(3, cardIdsOffset.Value, 0);
		}

		// Token: 0x0602958E RID: 169358 RVA: 0x005AB298 File Offset: 0x005A9498
		public static VectorOffset CreateCardIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602958F RID: 169359 RVA: 0x005AB2CF File Offset: 0x005A94CF
		public static VectorOffset CreateCardIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029590 RID: 169360 RVA: 0x005AB2E9 File Offset: 0x005A94E9
		public static VectorOffset CreateCardIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029591 RID: 169361 RVA: 0x005AB307 File Offset: 0x005A9507
		public static VectorOffset CreateCardIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029592 RID: 169362 RVA: 0x005AB320 File Offset: 0x005A9520
		public static void StartCardIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029593 RID: 169363 RVA: 0x005AB32B File Offset: 0x005A952B
		public static Offset<IReignsEnding> EndIReignsEnding(FlatBufferBuilder builder)
		{
			return new Offset<IReignsEnding>(builder.EndTable());
		}

		// Token: 0x06029594 RID: 169364 RVA: 0x005AB338 File Offset: 0x005A9538
		public IReignsEndingT UnPack()
		{
			IReignsEndingT reignsEndingT = new IReignsEndingT();
			this.UnPackTo(reignsEndingT);
			return reignsEndingT;
		}

		// Token: 0x06029595 RID: 169365 RVA: 0x005AB354 File Offset: 0x005A9554
		public void UnPackTo(IReignsEndingT _o)
		{
			_o.IsSuccess = this.IsSuccess;
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.CardId = this.CardId;
			_o.CardIds = new List<int>();
			for (int i = 0; i < this.CardIdsLength; i++)
			{
				_o.CardIds.Add(this.CardIds(i));
			}
		}

		// Token: 0x06029596 RID: 169366 RVA: 0x005AB3D8 File Offset: 0x005A95D8
		public static Offset<IReignsEnding> Pack(FlatBufferBuilder builder, IReignsEndingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsEnding>);
			}
			Offset<IReignsEndingCondition> conditionsOffset = (_o.Conditions == null) ? default(Offset<IReignsEndingCondition>) : IReignsEndingCondition.Pack(builder, _o.Conditions);
			VectorOffset cardIdsOffset = default(VectorOffset);
			if (_o.CardIds != null)
			{
				int[] data = _o.CardIds.ToArray();
				cardIdsOffset = IReignsEnding.CreateCardIdsVector(builder, data);
			}
			return IReignsEnding.CreateIReignsEnding(builder, _o.IsSuccess, conditionsOffset, _o.CardId, cardIdsOffset);
		}

		// Token: 0x0400F859 RID: 63577
		private Table __p;
	}
}
