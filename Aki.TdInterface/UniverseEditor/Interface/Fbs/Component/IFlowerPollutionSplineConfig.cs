using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057ED RID: 22509
	public struct IFlowerPollutionSplineConfig : IFlatbufferObject
	{
		// Token: 0x1700A2DB RID: 41691
		// (get) Token: 0x06024621 RID: 149025 RVA: 0x004FFD0E File Offset: 0x004FDF0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024622 RID: 149026 RVA: 0x004FFD1B File Offset: 0x004FDF1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024623 RID: 149027 RVA: 0x004FFD24 File Offset: 0x004FDF24
		public static IFlowerPollutionSplineConfig GetRootAsIFlowerPollutionSplineConfig(ByteBuffer _bb)
		{
			return IFlowerPollutionSplineConfig.GetRootAsIFlowerPollutionSplineConfig(_bb, default(IFlowerPollutionSplineConfig));
		}

		// Token: 0x06024624 RID: 149028 RVA: 0x004FFD40 File Offset: 0x004FDF40
		public static IFlowerPollutionSplineConfig GetRootAsIFlowerPollutionSplineConfig(ByteBuffer _bb, IFlowerPollutionSplineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024625 RID: 149029 RVA: 0x004FFD5D File Offset: 0x004FDF5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024626 RID: 149030 RVA: 0x004FFD6C File Offset: 0x004FDF6C
		public IFlowerPollutionSplineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06024627 RID: 149031 RVA: 0x004FFD7C File Offset: 0x004FDF7C
		public int SplineEntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A2DC RID: 41692
		// (get) Token: 0x06024628 RID: 149032 RVA: 0x004FFDBC File Offset: 0x004FDFBC
		public int SplineEntityIdsLength
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

		// Token: 0x06024629 RID: 149033 RVA: 0x004FFDE7 File Offset: 0x004FDFE7
		public Span<int> GetSplineEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602462A RID: 149034 RVA: 0x004FFDF6 File Offset: 0x004FDFF6
		public int[] GetSplineEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602462B RID: 149035 RVA: 0x004FFE04 File Offset: 0x004FE004
		public static Offset<IFlowerPollutionSplineConfig> CreateIFlowerPollutionSplineConfig(FlatBufferBuilder builder, VectorOffset SplineEntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IFlowerPollutionSplineConfig.AddSplineEntityIds(builder, SplineEntityIdsOffset);
			return IFlowerPollutionSplineConfig.EndIFlowerPollutionSplineConfig(builder);
		}

		// Token: 0x0602462C RID: 149036 RVA: 0x004FFE1A File Offset: 0x004FE01A
		public static void StartIFlowerPollutionSplineConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602462D RID: 149037 RVA: 0x004FFE23 File Offset: 0x004FE023
		public static void AddSplineEntityIds(FlatBufferBuilder builder, VectorOffset splineEntityIdsOffset)
		{
			builder.AddOffset(0, splineEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602462E RID: 149038 RVA: 0x004FFE34 File Offset: 0x004FE034
		public static VectorOffset CreateSplineEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602462F RID: 149039 RVA: 0x004FFE6B File Offset: 0x004FE06B
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024630 RID: 149040 RVA: 0x004FFE85 File Offset: 0x004FE085
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024631 RID: 149041 RVA: 0x004FFEA3 File Offset: 0x004FE0A3
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024632 RID: 149042 RVA: 0x004FFEBC File Offset: 0x004FE0BC
		public static void StartSplineEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024633 RID: 149043 RVA: 0x004FFEC7 File Offset: 0x004FE0C7
		public static Offset<IFlowerPollutionSplineConfig> EndIFlowerPollutionSplineConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlowerPollutionSplineConfig>(builder.EndTable());
		}

		// Token: 0x06024634 RID: 149044 RVA: 0x004FFED4 File Offset: 0x004FE0D4
		public IFlowerPollutionSplineConfigT UnPack()
		{
			IFlowerPollutionSplineConfigT flowerPollutionSplineConfigT = new IFlowerPollutionSplineConfigT();
			this.UnPackTo(flowerPollutionSplineConfigT);
			return flowerPollutionSplineConfigT;
		}

		// Token: 0x06024635 RID: 149045 RVA: 0x004FFEF0 File Offset: 0x004FE0F0
		public void UnPackTo(IFlowerPollutionSplineConfigT _o)
		{
			_o.SplineEntityIds = new List<int>();
			for (int i = 0; i < this.SplineEntityIdsLength; i++)
			{
				_o.SplineEntityIds.Add(this.SplineEntityIds(i));
			}
		}

		// Token: 0x06024636 RID: 149046 RVA: 0x004FFF2C File Offset: 0x004FE12C
		public static Offset<IFlowerPollutionSplineConfig> Pack(FlatBufferBuilder builder, IFlowerPollutionSplineConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowerPollutionSplineConfig>);
			}
			VectorOffset splineEntityIdsOffset = default(VectorOffset);
			if (_o.SplineEntityIds != null)
			{
				int[] data = _o.SplineEntityIds.ToArray();
				splineEntityIdsOffset = IFlowerPollutionSplineConfig.CreateSplineEntityIdsVector(builder, data);
			}
			return IFlowerPollutionSplineConfig.CreateIFlowerPollutionSplineConfig(builder, splineEntityIdsOffset);
		}

		// Token: 0x0400EFF3 RID: 61427
		private Table __p;
	}
}
