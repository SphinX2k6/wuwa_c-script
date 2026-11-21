using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063C8 RID: 25544
	public struct IDynamicSummonGongduolaConfig : IFlatbufferObject
	{
		// Token: 0x1700BCBD RID: 48317
		// (get) Token: 0x0602B622 RID: 177698 RVA: 0x005E99F0 File Offset: 0x005E7BF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B623 RID: 177699 RVA: 0x005E99FD File Offset: 0x005E7BFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B624 RID: 177700 RVA: 0x005E9A04 File Offset: 0x005E7C04
		public static IDynamicSummonGongduolaConfig GetRootAsIDynamicSummonGongduolaConfig(ByteBuffer _bb)
		{
			return IDynamicSummonGongduolaConfig.GetRootAsIDynamicSummonGongduolaConfig(_bb, default(IDynamicSummonGongduolaConfig));
		}

		// Token: 0x0602B625 RID: 177701 RVA: 0x005E9A20 File Offset: 0x005E7C20
		public static IDynamicSummonGongduolaConfig GetRootAsIDynamicSummonGongduolaConfig(ByteBuffer _bb, IDynamicSummonGongduolaConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B626 RID: 177702 RVA: 0x005E9A3D File Offset: 0x005E7C3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B627 RID: 177703 RVA: 0x005E9A4C File Offset: 0x005E7C4C
		public IDynamicSummonGongduolaConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCBE RID: 48318
		// (get) Token: 0x0602B628 RID: 177704 RVA: 0x005E9A5C File Offset: 0x005E7C5C
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

		// Token: 0x1700BCBF RID: 48319
		// (get) Token: 0x0602B629 RID: 177705 RVA: 0x005E9A98 File Offset: 0x005E7C98
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

		// Token: 0x0602B62A RID: 177706 RVA: 0x005E9AD4 File Offset: 0x005E7CD4
		public IDynamicSummonGongduolaPoint? SummonPoints(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicSummonGongduolaPoint?(default(IDynamicSummonGongduolaPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BCC0 RID: 48320
		// (get) Token: 0x0602B62B RID: 177707 RVA: 0x005E9B34 File Offset: 0x005E7D34
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

		// Token: 0x0602B62C RID: 177708 RVA: 0x005E9B5F File Offset: 0x005E7D5F
		public static Offset<IDynamicSummonGongduolaConfig> CreateIDynamicSummonGongduolaConfig(FlatBufferBuilder builder, int LevelId = 0, int Radius = 0, VectorOffset SummonPointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IDynamicSummonGongduolaConfig.AddSummonPoints(builder, SummonPointsOffset);
			IDynamicSummonGongduolaConfig.AddRadius(builder, Radius);
			IDynamicSummonGongduolaConfig.AddLevelId(builder, LevelId);
			return IDynamicSummonGongduolaConfig.EndIDynamicSummonGongduolaConfig(builder);
		}

		// Token: 0x0602B62D RID: 177709 RVA: 0x005E9B83 File Offset: 0x005E7D83
		public static void StartIDynamicSummonGongduolaConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B62E RID: 177710 RVA: 0x005E9B8C File Offset: 0x005E7D8C
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0602B62F RID: 177711 RVA: 0x005E9B97 File Offset: 0x005E7D97
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x0602B630 RID: 177712 RVA: 0x005E9BA2 File Offset: 0x005E7DA2
		public static void AddSummonPoints(FlatBufferBuilder builder, VectorOffset summonPointsOffset)
		{
			builder.AddOffset(2, summonPointsOffset.Value, 0);
		}

		// Token: 0x0602B631 RID: 177713 RVA: 0x005E9BB4 File Offset: 0x005E7DB4
		public static VectorOffset CreateSummonPointsVector(FlatBufferBuilder builder, Offset<IDynamicSummonGongduolaPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B632 RID: 177714 RVA: 0x005E9BF4 File Offset: 0x005E7DF4
		public static VectorOffset CreateSummonPointsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicSummonGongduolaPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicSummonGongduolaPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B633 RID: 177715 RVA: 0x005E9C0E File Offset: 0x005E7E0E
		public static VectorOffset CreateSummonPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicSummonGongduolaPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicSummonGongduolaPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B634 RID: 177716 RVA: 0x005E9C2C File Offset: 0x005E7E2C
		public static VectorOffset CreateSummonPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicSummonGongduolaPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B635 RID: 177717 RVA: 0x005E9C45 File Offset: 0x005E7E45
		public static void StartSummonPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B636 RID: 177718 RVA: 0x005E9C50 File Offset: 0x005E7E50
		public static Offset<IDynamicSummonGongduolaConfig> EndIDynamicSummonGongduolaConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSummonGongduolaConfig>(builder.EndTable());
		}

		// Token: 0x0602B637 RID: 177719 RVA: 0x005E9C60 File Offset: 0x005E7E60
		public IDynamicSummonGongduolaConfigT UnPack()
		{
			IDynamicSummonGongduolaConfigT dynamicSummonGongduolaConfigT = new IDynamicSummonGongduolaConfigT();
			this.UnPackTo(dynamicSummonGongduolaConfigT);
			return dynamicSummonGongduolaConfigT;
		}

		// Token: 0x0602B638 RID: 177720 RVA: 0x005E9C7C File Offset: 0x005E7E7C
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

		// Token: 0x0602B639 RID: 177721 RVA: 0x005E9CF4 File Offset: 0x005E7EF4
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

		// Token: 0x040104B7 RID: 66743
		private Table __p;
	}
}
