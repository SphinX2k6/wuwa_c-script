using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D8B RID: 23947
	public struct IDynamicSummonGongduolaConfig : IFlatbufferObject
	{
		// Token: 0x1700B357 RID: 45911
		// (get) Token: 0x06028F98 RID: 167832 RVA: 0x005A0CC0 File Offset: 0x0059EEC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028F99 RID: 167833 RVA: 0x005A0CCD File Offset: 0x0059EECD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028F9A RID: 167834 RVA: 0x005A0CD4 File Offset: 0x0059EED4
		public static IDynamicSummonGongduolaConfig GetRootAsIDynamicSummonGongduolaConfig(ByteBuffer _bb)
		{
			return IDynamicSummonGongduolaConfig.GetRootAsIDynamicSummonGongduolaConfig(_bb, default(IDynamicSummonGongduolaConfig));
		}

		// Token: 0x06028F9B RID: 167835 RVA: 0x005A0CF0 File Offset: 0x0059EEF0
		public static IDynamicSummonGongduolaConfig GetRootAsIDynamicSummonGongduolaConfig(ByteBuffer _bb, IDynamicSummonGongduolaConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028F9C RID: 167836 RVA: 0x005A0D0D File Offset: 0x0059EF0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028F9D RID: 167837 RVA: 0x005A0D1C File Offset: 0x0059EF1C
		public IDynamicSummonGongduolaConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B358 RID: 45912
		// (get) Token: 0x06028F9E RID: 167838 RVA: 0x005A0D2C File Offset: 0x0059EF2C
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B359 RID: 45913
		// (get) Token: 0x06028F9F RID: 167839 RVA: 0x005A0D68 File Offset: 0x0059EF68
		public int Radius
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

		// Token: 0x06028FA0 RID: 167840 RVA: 0x005A0DA4 File Offset: 0x0059EFA4
		public IDynamicSummonGongduolaPoint? SummonPoints(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicSummonGongduolaPoint?(default(IDynamicSummonGongduolaPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B35A RID: 45914
		// (get) Token: 0x06028FA1 RID: 167841 RVA: 0x005A0E04 File Offset: 0x0059F004
		public int SummonPointsLength
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

		// Token: 0x06028FA2 RID: 167842 RVA: 0x005A0E2F File Offset: 0x0059F02F
		public static Offset<IDynamicSummonGongduolaConfig> CreateIDynamicSummonGongduolaConfig(FlatBufferBuilder builder, int LevelId = 0, int Radius = 0, VectorOffset SummonPointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IDynamicSummonGongduolaConfig.AddSummonPoints(builder, SummonPointsOffset);
			IDynamicSummonGongduolaConfig.AddRadius(builder, Radius);
			IDynamicSummonGongduolaConfig.AddLevelId(builder, LevelId);
			return IDynamicSummonGongduolaConfig.EndIDynamicSummonGongduolaConfig(builder);
		}

		// Token: 0x06028FA3 RID: 167843 RVA: 0x005A0E53 File Offset: 0x0059F053
		public static void StartIDynamicSummonGongduolaConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028FA4 RID: 167844 RVA: 0x005A0E5C File Offset: 0x0059F05C
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x06028FA5 RID: 167845 RVA: 0x005A0E67 File Offset: 0x0059F067
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x06028FA6 RID: 167846 RVA: 0x005A0E72 File Offset: 0x0059F072
		public static void AddSummonPoints(FlatBufferBuilder builder, VectorOffset summonPointsOffset)
		{
			builder.AddOffset(2, summonPointsOffset.Value, 0);
		}

		// Token: 0x06028FA7 RID: 167847 RVA: 0x005A0E84 File Offset: 0x0059F084
		public static VectorOffset CreateSummonPointsVector(FlatBufferBuilder builder, Offset<IDynamicSummonGongduolaPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028FA8 RID: 167848 RVA: 0x005A0EC4 File Offset: 0x0059F0C4
		public static VectorOffset CreateSummonPointsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicSummonGongduolaPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicSummonGongduolaPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028FA9 RID: 167849 RVA: 0x005A0EDE File Offset: 0x0059F0DE
		public static VectorOffset CreateSummonPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicSummonGongduolaPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicSummonGongduolaPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028FAA RID: 167850 RVA: 0x005A0EFC File Offset: 0x0059F0FC
		public static VectorOffset CreateSummonPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicSummonGongduolaPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028FAB RID: 167851 RVA: 0x005A0F15 File Offset: 0x0059F115
		public static void StartSummonPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028FAC RID: 167852 RVA: 0x005A0F20 File Offset: 0x0059F120
		public static Offset<IDynamicSummonGongduolaConfig> EndIDynamicSummonGongduolaConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSummonGongduolaConfig>(builder.EndTable());
		}

		// Token: 0x06028FAD RID: 167853 RVA: 0x005A0F30 File Offset: 0x0059F130
		public IDynamicSummonGongduolaConfigT UnPack()
		{
			IDynamicSummonGongduolaConfigT dynamicSummonGongduolaConfigT = new IDynamicSummonGongduolaConfigT();
			this.UnPackTo(dynamicSummonGongduolaConfigT);
			return dynamicSummonGongduolaConfigT;
		}

		// Token: 0x06028FAE RID: 167854 RVA: 0x005A0F4C File Offset: 0x0059F14C
		public void UnPackTo(IDynamicSummonGongduolaConfigT _o)
		{
			_o.LevelId = this.LevelId;
			_o.Radius = this.Radius;
			_o.SummonPoints = new List<IDynamicSummonGongduolaPointT>();
			for (int i = 0; i < this.SummonPointsLength; i++)
			{
				_o.SummonPoints.Add((this.SummonPoints(i) != null) ? this.SummonPoints(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028FAF RID: 167855 RVA: 0x005A0FC4 File Offset: 0x0059F1C4
		public static Offset<IDynamicSummonGongduolaConfig> Pack(FlatBufferBuilder builder, IDynamicSummonGongduolaConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSummonGongduolaConfig>);
			}
			VectorOffset summonPointsOffset = default(VectorOffset);
			if (_o.SummonPoints != null)
			{
				Offset<IDynamicSummonGongduolaPoint>[] array = new Offset<IDynamicSummonGongduolaPoint>[_o.SummonPoints.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDynamicSummonGongduolaPoint.Pack(builder, _o.SummonPoints[i]);
				}
				summonPointsOffset = IDynamicSummonGongduolaConfig.CreateSummonPointsVector(builder, array);
			}
			return IDynamicSummonGongduolaConfig.CreateIDynamicSummonGongduolaConfig(builder, _o.LevelId, _o.Radius, summonPointsOffset);
		}

		// Token: 0x0400F75C RID: 63324
		private Table __p;
	}
}
