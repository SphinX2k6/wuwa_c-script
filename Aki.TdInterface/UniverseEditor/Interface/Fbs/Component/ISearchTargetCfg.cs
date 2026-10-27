using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F7 RID: 22775
	public struct ISearchTargetCfg : IFlatbufferObject
	{
		// Token: 0x1700AAAE RID: 43694
		// (get) Token: 0x0602679A RID: 157594 RVA: 0x0054D240 File Offset: 0x0054B440
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602679B RID: 157595 RVA: 0x0054D24D File Offset: 0x0054B44D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602679C RID: 157596 RVA: 0x0054D254 File Offset: 0x0054B454
		public static ISearchTargetCfg GetRootAsISearchTargetCfg(ByteBuffer _bb)
		{
			return ISearchTargetCfg.GetRootAsISearchTargetCfg(_bb, default(ISearchTargetCfg));
		}

		// Token: 0x0602679D RID: 157597 RVA: 0x0054D270 File Offset: 0x0054B470
		public static ISearchTargetCfg GetRootAsISearchTargetCfg(ByteBuffer _bb, ISearchTargetCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602679E RID: 157598 RVA: 0x0054D28D File Offset: 0x0054B48D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602679F RID: 157599 RVA: 0x0054D29C File Offset: 0x0054B49C
		public ISearchTargetCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060267A0 RID: 157600 RVA: 0x0054D2AC File Offset: 0x0054B4AC
		public IEntityAngleWeight? AngleWeight(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityAngleWeight?(default(IEntityAngleWeight).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AAAF RID: 43695
		// (get) Token: 0x060267A1 RID: 157601 RVA: 0x0054D30C File Offset: 0x0054B50C
		public int AngleWeightLength
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

		// Token: 0x060267A2 RID: 157602 RVA: 0x0054D338 File Offset: 0x0054B538
		public IEntityCategoryWeight? LockConditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityCategoryWeight?(default(IEntityCategoryWeight).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AAB0 RID: 43696
		// (get) Token: 0x060267A3 RID: 157603 RVA: 0x0054D398 File Offset: 0x0054B598
		public int LockConditionsLength
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

		// Token: 0x1700AAB1 RID: 43697
		// (get) Token: 0x060267A4 RID: 157604 RVA: 0x0054D3C4 File Offset: 0x0054B5C4
		public bool IgnoreDistanceWeight
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AAB2 RID: 43698
		// (get) Token: 0x060267A5 RID: 157605 RVA: 0x0054D404 File Offset: 0x0054B604
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060267A6 RID: 157606 RVA: 0x0054D441 File Offset: 0x0054B641
		public static Offset<ISearchTargetCfg> CreateISearchTargetCfg(FlatBufferBuilder builder, VectorOffset AngleWeightOffset = default(VectorOffset), VectorOffset LockConditionsOffset = default(VectorOffset), bool IgnoreDistanceWeight = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISearchTargetCfg.AddLockConditions(builder, LockConditionsOffset);
			ISearchTargetCfg.AddAngleWeight(builder, AngleWeightOffset);
			ISearchTargetCfg.AddNullMask(builder, NullMask);
			ISearchTargetCfg.AddIgnoreDistanceWeight(builder, IgnoreDistanceWeight);
			return ISearchTargetCfg.EndISearchTargetCfg(builder);
		}

		// Token: 0x060267A7 RID: 157607 RVA: 0x0054D46D File Offset: 0x0054B66D
		public static void StartISearchTargetCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060267A8 RID: 157608 RVA: 0x0054D476 File Offset: 0x0054B676
		public static void AddAngleWeight(FlatBufferBuilder builder, VectorOffset angleWeightOffset)
		{
			builder.AddOffset(0, angleWeightOffset.Value, 0);
		}

		// Token: 0x060267A9 RID: 157609 RVA: 0x0054D488 File Offset: 0x0054B688
		public static VectorOffset CreateAngleWeightVector(FlatBufferBuilder builder, Offset<IEntityAngleWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060267AA RID: 157610 RVA: 0x0054D4C8 File Offset: 0x0054B6C8
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, Offset<IEntityAngleWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityAngleWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x060267AB RID: 157611 RVA: 0x0054D4E2 File Offset: 0x0054B6E2
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityAngleWeight>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityAngleWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x060267AC RID: 157612 RVA: 0x0054D500 File Offset: 0x0054B700
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityAngleWeight>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060267AD RID: 157613 RVA: 0x0054D519 File Offset: 0x0054B719
		public static void StartAngleWeightVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060267AE RID: 157614 RVA: 0x0054D524 File Offset: 0x0054B724
		public static void AddLockConditions(FlatBufferBuilder builder, VectorOffset lockConditionsOffset)
		{
			builder.AddOffset(1, lockConditionsOffset.Value, 0);
		}

		// Token: 0x060267AF RID: 157615 RVA: 0x0054D534 File Offset: 0x0054B734
		public static VectorOffset CreateLockConditionsVector(FlatBufferBuilder builder, Offset<IEntityCategoryWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060267B0 RID: 157616 RVA: 0x0054D574 File Offset: 0x0054B774
		public static VectorOffset CreateLockConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityCategoryWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityCategoryWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x060267B1 RID: 157617 RVA: 0x0054D58E File Offset: 0x0054B78E
		public static VectorOffset CreateLockConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityCategoryWeight>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityCategoryWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x060267B2 RID: 157618 RVA: 0x0054D5AC File Offset: 0x0054B7AC
		public static VectorOffset CreateLockConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityCategoryWeight>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060267B3 RID: 157619 RVA: 0x0054D5C5 File Offset: 0x0054B7C5
		public static void StartLockConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060267B4 RID: 157620 RVA: 0x0054D5D0 File Offset: 0x0054B7D0
		public static void AddIgnoreDistanceWeight(FlatBufferBuilder builder, bool ignoreDistanceWeight)
		{
			builder.AddBool(2, ignoreDistanceWeight, false);
		}

		// Token: 0x060267B5 RID: 157621 RVA: 0x0054D5DB File Offset: 0x0054B7DB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060267B6 RID: 157622 RVA: 0x0054D5E6 File Offset: 0x0054B7E6
		public static Offset<ISearchTargetCfg> EndISearchTargetCfg(FlatBufferBuilder builder)
		{
			return new Offset<ISearchTargetCfg>(builder.EndTable());
		}

		// Token: 0x060267B7 RID: 157623 RVA: 0x0054D5F4 File Offset: 0x0054B7F4
		public ISearchTargetCfgT UnPack()
		{
			ISearchTargetCfgT searchTargetCfgT = new ISearchTargetCfgT();
			this.UnPackTo(searchTargetCfgT);
			return searchTargetCfgT;
		}

		// Token: 0x060267B8 RID: 157624 RVA: 0x0054D610 File Offset: 0x0054B810
		public void UnPackTo(ISearchTargetCfgT _o)
		{
			_o.AngleWeight = new List<IEntityAngleWeightT>();
			for (int i = 0; i < this.AngleWeightLength; i++)
			{
				_o.AngleWeight.Add((this.AngleWeight(i) != null) ? this.AngleWeight(i).Value.UnPack() : null);
			}
			_o.LockConditions = new List<IEntityCategoryWeightT>();
			for (int j = 0; j < this.LockConditionsLength; j++)
			{
				_o.LockConditions.Add((this.LockConditions(j) != null) ? this.LockConditions(j).Value.UnPack() : null);
			}
			_o.IgnoreDistanceWeight = this.IgnoreDistanceWeight;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060267B9 RID: 157625 RVA: 0x0054D6DC File Offset: 0x0054B8DC
		public static Offset<ISearchTargetCfg> Pack(FlatBufferBuilder builder, ISearchTargetCfgT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISearchTargetCfg>);
			}
			VectorOffset angleWeightOffset = default(VectorOffset);
			if (_o.AngleWeight != null)
			{
				Offset<IEntityAngleWeight>[] array = new Offset<IEntityAngleWeight>[_o.AngleWeight.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityAngleWeight.Pack(builder, _o.AngleWeight[i]);
				}
				angleWeightOffset = ISearchTargetCfg.CreateAngleWeightVector(builder, array);
			}
			VectorOffset lockConditionsOffset = default(VectorOffset);
			if (_o.LockConditions != null)
			{
				Offset<IEntityCategoryWeight>[] array2 = new Offset<IEntityCategoryWeight>[_o.LockConditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IEntityCategoryWeight.Pack(builder, _o.LockConditions[j]);
				}
				lockConditionsOffset = ISearchTargetCfg.CreateLockConditionsVector(builder, array2);
			}
			return ISearchTargetCfg.CreateISearchTargetCfg(builder, angleWeightOffset, lockConditionsOffset, _o.IgnoreDistanceWeight, _o.NullMask);
		}

		// Token: 0x0400EE92 RID: 61074
		private Table __p;
	}
}
