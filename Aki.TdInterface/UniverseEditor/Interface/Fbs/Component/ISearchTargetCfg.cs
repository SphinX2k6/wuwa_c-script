using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F04 RID: 24324
	public struct ISearchTargetCfg : IFlatbufferObject
	{
		// Token: 0x1700B3E2 RID: 46050
		// (get) Token: 0x06028D04 RID: 167172 RVA: 0x00593EAC File Offset: 0x005920AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D05 RID: 167173 RVA: 0x00593EB9 File Offset: 0x005920B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028D06 RID: 167174 RVA: 0x00593EC0 File Offset: 0x005920C0
		public static ISearchTargetCfg GetRootAsISearchTargetCfg(ByteBuffer _bb)
		{
			return ISearchTargetCfg.GetRootAsISearchTargetCfg(_bb, default(ISearchTargetCfg));
		}

		// Token: 0x06028D07 RID: 167175 RVA: 0x00593EDC File Offset: 0x005920DC
		public static ISearchTargetCfg GetRootAsISearchTargetCfg(ByteBuffer _bb, ISearchTargetCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028D08 RID: 167176 RVA: 0x00593EF9 File Offset: 0x005920F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028D09 RID: 167177 RVA: 0x00593F08 File Offset: 0x00592108
		public ISearchTargetCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06028D0A RID: 167178 RVA: 0x00593F18 File Offset: 0x00592118
		public IEntityAngleWeight? AngleWeight(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityAngleWeight?(default(IEntityAngleWeight).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B3E3 RID: 46051
		// (get) Token: 0x06028D0B RID: 167179 RVA: 0x00593F78 File Offset: 0x00592178
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

		// Token: 0x06028D0C RID: 167180 RVA: 0x00593FA4 File Offset: 0x005921A4
		public IEntityCategoryWeight? LockConditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityCategoryWeight?(default(IEntityCategoryWeight).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B3E4 RID: 46052
		// (get) Token: 0x06028D0D RID: 167181 RVA: 0x00594004 File Offset: 0x00592204
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

		// Token: 0x1700B3E5 RID: 46053
		// (get) Token: 0x06028D0E RID: 167182 RVA: 0x00594030 File Offset: 0x00592230
		public bool IgnoreDistanceWeight
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B3E6 RID: 46054
		// (get) Token: 0x06028D0F RID: 167183 RVA: 0x00594070 File Offset: 0x00592270
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

		// Token: 0x06028D10 RID: 167184 RVA: 0x005940AD File Offset: 0x005922AD
		public static Offset<ISearchTargetCfg> CreateISearchTargetCfg(FlatBufferBuilder builder, VectorOffset AngleWeightOffset = default(VectorOffset), VectorOffset LockConditionsOffset = default(VectorOffset), bool IgnoreDistanceWeight = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISearchTargetCfg.AddLockConditions(builder, LockConditionsOffset);
			ISearchTargetCfg.AddAngleWeight(builder, AngleWeightOffset);
			ISearchTargetCfg.AddNullMask(builder, NullMask);
			ISearchTargetCfg.AddIgnoreDistanceWeight(builder, IgnoreDistanceWeight);
			return ISearchTargetCfg.EndISearchTargetCfg(builder);
		}

		// Token: 0x06028D11 RID: 167185 RVA: 0x005940D9 File Offset: 0x005922D9
		public static void StartISearchTargetCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028D12 RID: 167186 RVA: 0x005940E2 File Offset: 0x005922E2
		public static void AddAngleWeight(FlatBufferBuilder builder, VectorOffset angleWeightOffset)
		{
			builder.AddOffset(0, angleWeightOffset.Value, 0);
		}

		// Token: 0x06028D13 RID: 167187 RVA: 0x005940F4 File Offset: 0x005922F4
		public static VectorOffset CreateAngleWeightVector(FlatBufferBuilder builder, Offset<IEntityAngleWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028D14 RID: 167188 RVA: 0x00594134 File Offset: 0x00592334
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, Offset<IEntityAngleWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityAngleWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028D15 RID: 167189 RVA: 0x0059414E File Offset: 0x0059234E
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityAngleWeight>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityAngleWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028D16 RID: 167190 RVA: 0x0059416C File Offset: 0x0059236C
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityAngleWeight>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028D17 RID: 167191 RVA: 0x00594185 File Offset: 0x00592385
		public static void StartAngleWeightVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028D18 RID: 167192 RVA: 0x00594190 File Offset: 0x00592390
		public static void AddLockConditions(FlatBufferBuilder builder, VectorOffset lockConditionsOffset)
		{
			builder.AddOffset(1, lockConditionsOffset.Value, 0);
		}

		// Token: 0x06028D19 RID: 167193 RVA: 0x005941A0 File Offset: 0x005923A0
		public static VectorOffset CreateLockConditionsVector(FlatBufferBuilder builder, Offset<IEntityCategoryWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028D1A RID: 167194 RVA: 0x005941E0 File Offset: 0x005923E0
		public static VectorOffset CreateLockConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityCategoryWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityCategoryWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028D1B RID: 167195 RVA: 0x005941FA File Offset: 0x005923FA
		public static VectorOffset CreateLockConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityCategoryWeight>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityCategoryWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028D1C RID: 167196 RVA: 0x00594218 File Offset: 0x00592418
		public static VectorOffset CreateLockConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityCategoryWeight>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028D1D RID: 167197 RVA: 0x00594231 File Offset: 0x00592431
		public static void StartLockConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028D1E RID: 167198 RVA: 0x0059423C File Offset: 0x0059243C
		public static void AddIgnoreDistanceWeight(FlatBufferBuilder builder, bool ignoreDistanceWeight)
		{
			builder.AddBool(2, ignoreDistanceWeight, false);
		}

		// Token: 0x06028D1F RID: 167199 RVA: 0x00594247 File Offset: 0x00592447
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06028D20 RID: 167200 RVA: 0x00594252 File Offset: 0x00592452
		public static Offset<ISearchTargetCfg> EndISearchTargetCfg(FlatBufferBuilder builder)
		{
			return new Offset<ISearchTargetCfg>(builder.EndTable());
		}

		// Token: 0x06028D21 RID: 167201 RVA: 0x00594260 File Offset: 0x00592460
		public ISearchTargetCfgT UnPack()
		{
			ISearchTargetCfgT searchTargetCfgT = new ISearchTargetCfgT();
			this.UnPackTo(searchTargetCfgT);
			return searchTargetCfgT;
		}

		// Token: 0x06028D22 RID: 167202 RVA: 0x0059427C File Offset: 0x0059247C
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

		// Token: 0x06028D23 RID: 167203 RVA: 0x00594348 File Offset: 0x00592548
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

		// Token: 0x0400FB87 RID: 64391
		private Table __p;
	}
}
