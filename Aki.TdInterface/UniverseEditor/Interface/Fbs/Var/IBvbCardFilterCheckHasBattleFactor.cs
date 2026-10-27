using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A2D RID: 14893
	public struct IBvbCardFilterCheckHasBattleFactor : IFlatbufferObject
	{
		// Token: 0x1700660E RID: 26126
		// (get) Token: 0x0601424D RID: 82509 RVA: 0x002F22CE File Offset: 0x002F04CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601424E RID: 82510 RVA: 0x002F22DB File Offset: 0x002F04DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601424F RID: 82511 RVA: 0x002F22E4 File Offset: 0x002F04E4
		public static IBvbCardFilterCheckHasBattleFactor GetRootAsIBvbCardFilterCheckHasBattleFactor(ByteBuffer _bb)
		{
			return IBvbCardFilterCheckHasBattleFactor.GetRootAsIBvbCardFilterCheckHasBattleFactor(_bb, default(IBvbCardFilterCheckHasBattleFactor));
		}

		// Token: 0x06014250 RID: 82512 RVA: 0x002F2300 File Offset: 0x002F0500
		public static IBvbCardFilterCheckHasBattleFactor GetRootAsIBvbCardFilterCheckHasBattleFactor(ByteBuffer _bb, IBvbCardFilterCheckHasBattleFactor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014251 RID: 82513 RVA: 0x002F231D File Offset: 0x002F051D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014252 RID: 82514 RVA: 0x002F232C File Offset: 0x002F052C
		public IBvbCardFilterCheckHasBattleFactor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700660F RID: 26127
		// (get) Token: 0x06014253 RID: 82515 RVA: 0x002F233C File Offset: 0x002F053C
		public EBvbCardFilterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbCardFilterType.CompareCost;
				}
				return (EBvbCardFilterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014254 RID: 82516 RVA: 0x002F2378 File Offset: 0x002F0578
		public int BattleFactorList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006610 RID: 26128
		// (get) Token: 0x06014255 RID: 82517 RVA: 0x002F23B8 File Offset: 0x002F05B8
		public int BattleFactorListLength
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

		// Token: 0x06014256 RID: 82518 RVA: 0x002F23E3 File Offset: 0x002F05E3
		public Span<int> GetBattleFactorListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06014257 RID: 82519 RVA: 0x002F23F2 File Offset: 0x002F05F2
		public int[] GetBattleFactorListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06014258 RID: 82520 RVA: 0x002F2400 File Offset: 0x002F0600
		public static Offset<IBvbCardFilterCheckHasBattleFactor> CreateIBvbCardFilterCheckHasBattleFactor(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, VectorOffset BattleFactorListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IBvbCardFilterCheckHasBattleFactor.AddBattleFactorList(builder, BattleFactorListOffset);
			IBvbCardFilterCheckHasBattleFactor.AddType(builder, Type);
			return IBvbCardFilterCheckHasBattleFactor.EndIBvbCardFilterCheckHasBattleFactor(builder);
		}

		// Token: 0x06014259 RID: 82521 RVA: 0x002F241D File Offset: 0x002F061D
		public static void StartIBvbCardFilterCheckHasBattleFactor(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601425A RID: 82522 RVA: 0x002F2426 File Offset: 0x002F0626
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601425B RID: 82523 RVA: 0x002F2431 File Offset: 0x002F0631
		public static void AddBattleFactorList(FlatBufferBuilder builder, VectorOffset battleFactorListOffset)
		{
			builder.AddOffset(1, battleFactorListOffset.Value, 0);
		}

		// Token: 0x0601425C RID: 82524 RVA: 0x002F2444 File Offset: 0x002F0644
		public static VectorOffset CreateBattleFactorListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601425D RID: 82525 RVA: 0x002F247B File Offset: 0x002F067B
		public static VectorOffset CreateBattleFactorListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601425E RID: 82526 RVA: 0x002F2495 File Offset: 0x002F0695
		public static VectorOffset CreateBattleFactorListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601425F RID: 82527 RVA: 0x002F24B3 File Offset: 0x002F06B3
		public static VectorOffset CreateBattleFactorListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014260 RID: 82528 RVA: 0x002F24CC File Offset: 0x002F06CC
		public static void StartBattleFactorListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014261 RID: 82529 RVA: 0x002F24D7 File Offset: 0x002F06D7
		public static Offset<IBvbCardFilterCheckHasBattleFactor> EndIBvbCardFilterCheckHasBattleFactor(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCheckHasBattleFactor>(builder.EndTable());
		}

		// Token: 0x06014262 RID: 82530 RVA: 0x002F24E4 File Offset: 0x002F06E4
		public IBvbCardFilterCheckHasBattleFactorT UnPack()
		{
			IBvbCardFilterCheckHasBattleFactorT bvbCardFilterCheckHasBattleFactorT = new IBvbCardFilterCheckHasBattleFactorT();
			this.UnPackTo(bvbCardFilterCheckHasBattleFactorT);
			return bvbCardFilterCheckHasBattleFactorT;
		}

		// Token: 0x06014263 RID: 82531 RVA: 0x002F2500 File Offset: 0x002F0700
		public void UnPackTo(IBvbCardFilterCheckHasBattleFactorT _o)
		{
			_o.Type = this.Type;
			_o.BattleFactorList = new List<int>();
			for (int i = 0; i < this.BattleFactorListLength; i++)
			{
				_o.BattleFactorList.Add(this.BattleFactorList(i));
			}
		}

		// Token: 0x06014264 RID: 82532 RVA: 0x002F2548 File Offset: 0x002F0748
		public static Offset<IBvbCardFilterCheckHasBattleFactor> Pack(FlatBufferBuilder builder, IBvbCardFilterCheckHasBattleFactorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCheckHasBattleFactor>);
			}
			VectorOffset battleFactorListOffset = default(VectorOffset);
			if (_o.BattleFactorList != null)
			{
				int[] data = _o.BattleFactorList.ToArray();
				battleFactorListOffset = IBvbCardFilterCheckHasBattleFactor.CreateBattleFactorListVector(builder, data);
			}
			return IBvbCardFilterCheckHasBattleFactor.CreateIBvbCardFilterCheckHasBattleFactor(builder, _o.Type, battleFactorListOffset);
		}

		// Token: 0x0400AEAC RID: 44716
		private Table __p;
	}
}
