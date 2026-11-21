using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006491 RID: 25745
	public struct IReignsEnding : IFlatbufferObject
	{
		// Token: 0x1700BDF3 RID: 48627
		// (get) Token: 0x0602BC17 RID: 179223 RVA: 0x005F3EFE File Offset: 0x005F20FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BC18 RID: 179224 RVA: 0x005F3F0B File Offset: 0x005F210B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BC19 RID: 179225 RVA: 0x005F3F14 File Offset: 0x005F2114
		public static IReignsEnding GetRootAsIReignsEnding(ByteBuffer _bb)
		{
			return IReignsEnding.GetRootAsIReignsEnding(_bb, default(IReignsEnding));
		}

		// Token: 0x0602BC1A RID: 179226 RVA: 0x005F3F30 File Offset: 0x005F2130
		public static IReignsEnding GetRootAsIReignsEnding(ByteBuffer _bb, IReignsEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BC1B RID: 179227 RVA: 0x005F3F4D File Offset: 0x005F214D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BC1C RID: 179228 RVA: 0x005F3F5C File Offset: 0x005F215C
		public IReignsEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDF4 RID: 48628
		// (get) Token: 0x0602BC1D RID: 179229 RVA: 0x005F3F6C File Offset: 0x005F216C
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BDF5 RID: 48629
		// (get) Token: 0x0602BC1E RID: 179230 RVA: 0x005F3FAC File Offset: 0x005F21AC
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

		// Token: 0x1700BDF6 RID: 48630
		// (get) Token: 0x0602BC1F RID: 179231 RVA: 0x005F400C File Offset: 0x005F220C
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

		// Token: 0x0602BC20 RID: 179232 RVA: 0x005F4048 File Offset: 0x005F2248
		public int CardIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BDF7 RID: 48631
		// (get) Token: 0x0602BC21 RID: 179233 RVA: 0x005F4088 File Offset: 0x005F2288
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

		// Token: 0x0602BC22 RID: 179234 RVA: 0x005F40B4 File Offset: 0x005F22B4
		public Span<int> GetCardIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602BC23 RID: 179235 RVA: 0x005F40C4 File Offset: 0x005F22C4
		public int[] GetCardIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0602BC24 RID: 179236 RVA: 0x005F40D3 File Offset: 0x005F22D3
		public static Offset<IReignsEnding> CreateIReignsEnding(FlatBufferBuilder builder, bool IsSuccess = false, Offset<IReignsEndingCondition> ConditionsOffset = default(Offset<IReignsEndingCondition>), int CardId = 0, VectorOffset CardIdsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IReignsEnding.AddCardIds(builder, CardIdsOffset);
			IReignsEnding.AddCardId(builder, CardId);
			IReignsEnding.AddConditions(builder, ConditionsOffset);
			IReignsEnding.AddIsSuccess(builder, IsSuccess);
			return IReignsEnding.EndIReignsEnding(builder);
		}

		// Token: 0x0602BC25 RID: 179237 RVA: 0x005F40FF File Offset: 0x005F22FF
		public static void StartIReignsEnding(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602BC26 RID: 179238 RVA: 0x005F4108 File Offset: 0x005F2308
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x0602BC27 RID: 179239 RVA: 0x005F4113 File Offset: 0x005F2313
		public static void AddConditions(FlatBufferBuilder builder, Offset<IReignsEndingCondition> conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0602BC28 RID: 179240 RVA: 0x005F4123 File Offset: 0x005F2323
		public static void AddCardId(FlatBufferBuilder builder, int cardId)
		{
			builder.AddInt(2, cardId, 0);
		}

		// Token: 0x0602BC29 RID: 179241 RVA: 0x005F412E File Offset: 0x005F232E
		public static void AddCardIds(FlatBufferBuilder builder, VectorOffset cardIdsOffset)
		{
			builder.AddOffset(3, cardIdsOffset.Value, 0);
		}

		// Token: 0x0602BC2A RID: 179242 RVA: 0x005F4140 File Offset: 0x005F2340
		public static VectorOffset CreateCardIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BC2B RID: 179243 RVA: 0x005F4177 File Offset: 0x005F2377
		public static VectorOffset CreateCardIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BC2C RID: 179244 RVA: 0x005F4191 File Offset: 0x005F2391
		public static VectorOffset CreateCardIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BC2D RID: 179245 RVA: 0x005F41AF File Offset: 0x005F23AF
		public static VectorOffset CreateCardIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BC2E RID: 179246 RVA: 0x005F41C8 File Offset: 0x005F23C8
		public static void StartCardIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BC2F RID: 179247 RVA: 0x005F41D3 File Offset: 0x005F23D3
		public static Offset<IReignsEnding> EndIReignsEnding(FlatBufferBuilder builder)
		{
			return new Offset<IReignsEnding>(builder.EndTable());
		}

		// Token: 0x0602BC30 RID: 179248 RVA: 0x005F41E0 File Offset: 0x005F23E0
		public IReignsEndingT UnPack()
		{
			IReignsEndingT reignsEndingT = new IReignsEndingT();
			this.UnPackTo(reignsEndingT);
			return reignsEndingT;
		}

		// Token: 0x0602BC31 RID: 179249 RVA: 0x005F41FC File Offset: 0x005F23FC
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

		// Token: 0x0602BC32 RID: 179250 RVA: 0x005F4280 File Offset: 0x005F2480
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

		// Token: 0x040105B6 RID: 66998
		private Table __p;
	}
}
