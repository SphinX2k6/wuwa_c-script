using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005285 RID: 21125
	public struct IFlowerPollutionSplineConfig : IFlatbufferObject
	{
		// Token: 0x17009ADD RID: 39645
		// (get) Token: 0x06022687 RID: 140935 RVA: 0x004C519E File Offset: 0x004C339E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022688 RID: 140936 RVA: 0x004C51AB File Offset: 0x004C33AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022689 RID: 140937 RVA: 0x004C51B4 File Offset: 0x004C33B4
		public static IFlowerPollutionSplineConfig GetRootAsIFlowerPollutionSplineConfig(ByteBuffer _bb)
		{
			return IFlowerPollutionSplineConfig.GetRootAsIFlowerPollutionSplineConfig(_bb, default(IFlowerPollutionSplineConfig));
		}

		// Token: 0x0602268A RID: 140938 RVA: 0x004C51D0 File Offset: 0x004C33D0
		public static IFlowerPollutionSplineConfig GetRootAsIFlowerPollutionSplineConfig(ByteBuffer _bb, IFlowerPollutionSplineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602268B RID: 140939 RVA: 0x004C51ED File Offset: 0x004C33ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602268C RID: 140940 RVA: 0x004C51FC File Offset: 0x004C33FC
		public IFlowerPollutionSplineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602268D RID: 140941 RVA: 0x004C520C File Offset: 0x004C340C
		public int SplineEntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009ADE RID: 39646
		// (get) Token: 0x0602268E RID: 140942 RVA: 0x004C524C File Offset: 0x004C344C
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

		// Token: 0x0602268F RID: 140943 RVA: 0x004C5277 File Offset: 0x004C3477
		public Span<int> GetSplineEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06022690 RID: 140944 RVA: 0x004C5286 File Offset: 0x004C3486
		public int[] GetSplineEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06022691 RID: 140945 RVA: 0x004C5294 File Offset: 0x004C3494
		public static Offset<IFlowerPollutionSplineConfig> CreateIFlowerPollutionSplineConfig(FlatBufferBuilder builder, VectorOffset SplineEntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IFlowerPollutionSplineConfig.AddSplineEntityIds(builder, SplineEntityIdsOffset);
			return IFlowerPollutionSplineConfig.EndIFlowerPollutionSplineConfig(builder);
		}

		// Token: 0x06022692 RID: 140946 RVA: 0x004C52AA File Offset: 0x004C34AA
		public static void StartIFlowerPollutionSplineConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022693 RID: 140947 RVA: 0x004C52B3 File Offset: 0x004C34B3
		public static void AddSplineEntityIds(FlatBufferBuilder builder, VectorOffset splineEntityIdsOffset)
		{
			builder.AddOffset(0, splineEntityIdsOffset.Value, 0);
		}

		// Token: 0x06022694 RID: 140948 RVA: 0x004C52C4 File Offset: 0x004C34C4
		public static VectorOffset CreateSplineEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022695 RID: 140949 RVA: 0x004C52FB File Offset: 0x004C34FB
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022696 RID: 140950 RVA: 0x004C5315 File Offset: 0x004C3515
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022697 RID: 140951 RVA: 0x004C5333 File Offset: 0x004C3533
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022698 RID: 140952 RVA: 0x004C534C File Offset: 0x004C354C
		public static void StartSplineEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022699 RID: 140953 RVA: 0x004C5357 File Offset: 0x004C3557
		public static Offset<IFlowerPollutionSplineConfig> EndIFlowerPollutionSplineConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlowerPollutionSplineConfig>(builder.EndTable());
		}

		// Token: 0x0602269A RID: 140954 RVA: 0x004C5364 File Offset: 0x004C3564
		public IFlowerPollutionSplineConfigT UnPack()
		{
			IFlowerPollutionSplineConfigT flowerPollutionSplineConfigT = new IFlowerPollutionSplineConfigT();
			this.UnPackTo(flowerPollutionSplineConfigT);
			return flowerPollutionSplineConfigT;
		}

		// Token: 0x0602269B RID: 140955 RVA: 0x004C5380 File Offset: 0x004C3580
		public void UnPackTo(IFlowerPollutionSplineConfigT _o)
		{
			_o.SplineEntityIds = new List<int>();
			for (int i = 0; i < this.SplineEntityIdsLength; i++)
			{
				_o.SplineEntityIds.Add(this.SplineEntityIds(i));
			}
		}

		// Token: 0x0602269C RID: 140956 RVA: 0x004C53BC File Offset: 0x004C35BC
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

		// Token: 0x0400E3EC RID: 58348
		private Table __p;
	}
}
