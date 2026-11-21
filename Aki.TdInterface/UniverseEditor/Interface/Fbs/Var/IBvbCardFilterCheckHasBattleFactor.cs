using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E08 RID: 15880
	public struct IBvbCardFilterCheckHasBattleFactor : IFlatbufferObject
	{
		// Token: 0x17006B3E RID: 27454
		// (get) Token: 0x06015569 RID: 87401 RVA: 0x003154BA File Offset: 0x003136BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601556A RID: 87402 RVA: 0x003154C7 File Offset: 0x003136C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601556B RID: 87403 RVA: 0x003154D0 File Offset: 0x003136D0
		public static IBvbCardFilterCheckHasBattleFactor GetRootAsIBvbCardFilterCheckHasBattleFactor(ByteBuffer _bb)
		{
			return IBvbCardFilterCheckHasBattleFactor.GetRootAsIBvbCardFilterCheckHasBattleFactor(_bb, default(IBvbCardFilterCheckHasBattleFactor));
		}

		// Token: 0x0601556C RID: 87404 RVA: 0x003154EC File Offset: 0x003136EC
		public static IBvbCardFilterCheckHasBattleFactor GetRootAsIBvbCardFilterCheckHasBattleFactor(ByteBuffer _bb, IBvbCardFilterCheckHasBattleFactor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601556D RID: 87405 RVA: 0x00315509 File Offset: 0x00313709
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601556E RID: 87406 RVA: 0x00315518 File Offset: 0x00313718
		public IBvbCardFilterCheckHasBattleFactor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B3F RID: 27455
		// (get) Token: 0x0601556F RID: 87407 RVA: 0x00315528 File Offset: 0x00313728
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

		// Token: 0x06015570 RID: 87408 RVA: 0x00315564 File Offset: 0x00313764
		public int BattleFactorList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006B40 RID: 27456
		// (get) Token: 0x06015571 RID: 87409 RVA: 0x003155A4 File Offset: 0x003137A4
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

		// Token: 0x06015572 RID: 87410 RVA: 0x003155CF File Offset: 0x003137CF
		public Span<int> GetBattleFactorListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06015573 RID: 87411 RVA: 0x003155DE File Offset: 0x003137DE
		public int[] GetBattleFactorListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06015574 RID: 87412 RVA: 0x003155EC File Offset: 0x003137EC
		public static Offset<IBvbCardFilterCheckHasBattleFactor> CreateIBvbCardFilterCheckHasBattleFactor(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, VectorOffset BattleFactorListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IBvbCardFilterCheckHasBattleFactor.AddBattleFactorList(builder, BattleFactorListOffset);
			IBvbCardFilterCheckHasBattleFactor.AddType(builder, Type);
			return IBvbCardFilterCheckHasBattleFactor.EndIBvbCardFilterCheckHasBattleFactor(builder);
		}

		// Token: 0x06015575 RID: 87413 RVA: 0x00315609 File Offset: 0x00313809
		public static void StartIBvbCardFilterCheckHasBattleFactor(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015576 RID: 87414 RVA: 0x00315612 File Offset: 0x00313812
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015577 RID: 87415 RVA: 0x0031561D File Offset: 0x0031381D
		public static void AddBattleFactorList(FlatBufferBuilder builder, VectorOffset battleFactorListOffset)
		{
			builder.AddOffset(1, battleFactorListOffset.Value, 0);
		}

		// Token: 0x06015578 RID: 87416 RVA: 0x00315630 File Offset: 0x00313830
		public static VectorOffset CreateBattleFactorListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015579 RID: 87417 RVA: 0x00315667 File Offset: 0x00313867
		public static VectorOffset CreateBattleFactorListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601557A RID: 87418 RVA: 0x00315681 File Offset: 0x00313881
		public static VectorOffset CreateBattleFactorListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601557B RID: 87419 RVA: 0x0031569F File Offset: 0x0031389F
		public static VectorOffset CreateBattleFactorListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601557C RID: 87420 RVA: 0x003156B8 File Offset: 0x003138B8
		public static void StartBattleFactorListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601557D RID: 87421 RVA: 0x003156C3 File Offset: 0x003138C3
		public static Offset<IBvbCardFilterCheckHasBattleFactor> EndIBvbCardFilterCheckHasBattleFactor(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCheckHasBattleFactor>(builder.EndTable());
		}

		// Token: 0x0601557E RID: 87422 RVA: 0x003156D0 File Offset: 0x003138D0
		public IBvbCardFilterCheckHasBattleFactorT UnPack()
		{
			IBvbCardFilterCheckHasBattleFactorT bvbCardFilterCheckHasBattleFactorT = new IBvbCardFilterCheckHasBattleFactorT();
			this.UnPackTo(bvbCardFilterCheckHasBattleFactorT);
			return bvbCardFilterCheckHasBattleFactorT;
		}

		// Token: 0x0601557F RID: 87423 RVA: 0x003156EC File Offset: 0x003138EC
		public void UnPackTo(IBvbCardFilterCheckHasBattleFactorT _o)
		{
			_o.Type = this.Type;
			_o.BattleFactorList = new List<int>();
			for (int i = 0; i < this.BattleFactorListLength; i++)
			{
				_o.BattleFactorList.Add(this.BattleFactorList(i));
			}
		}

		// Token: 0x06015580 RID: 87424 RVA: 0x00315734 File Offset: 0x00313934
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

		// Token: 0x0400B7CE RID: 47054
		private Table __p;
	}
}
