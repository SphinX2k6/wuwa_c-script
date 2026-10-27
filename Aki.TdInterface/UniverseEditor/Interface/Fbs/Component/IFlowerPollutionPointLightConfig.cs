using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005282 RID: 21122
	public struct IFlowerPollutionPointLightConfig : IFlatbufferObject
	{
		// Token: 0x17009AD8 RID: 39640
		// (get) Token: 0x06022663 RID: 140899 RVA: 0x004C4CBF File Offset: 0x004C2EBF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022664 RID: 140900 RVA: 0x004C4CCC File Offset: 0x004C2ECC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022665 RID: 140901 RVA: 0x004C4CD4 File Offset: 0x004C2ED4
		public static IFlowerPollutionPointLightConfig GetRootAsIFlowerPollutionPointLightConfig(ByteBuffer _bb)
		{
			return IFlowerPollutionPointLightConfig.GetRootAsIFlowerPollutionPointLightConfig(_bb, default(IFlowerPollutionPointLightConfig));
		}

		// Token: 0x06022666 RID: 140902 RVA: 0x004C4CF0 File Offset: 0x004C2EF0
		public static IFlowerPollutionPointLightConfig GetRootAsIFlowerPollutionPointLightConfig(ByteBuffer _bb, IFlowerPollutionPointLightConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022667 RID: 140903 RVA: 0x004C4D0D File Offset: 0x004C2F0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022668 RID: 140904 RVA: 0x004C4D1C File Offset: 0x004C2F1C
		public IFlowerPollutionPointLightConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06022669 RID: 140905 RVA: 0x004C4D2C File Offset: 0x004C2F2C
		public int PointLightEntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009AD9 RID: 39641
		// (get) Token: 0x0602266A RID: 140906 RVA: 0x004C4D6C File Offset: 0x004C2F6C
		public int PointLightEntityIdsLength
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

		// Token: 0x0602266B RID: 140907 RVA: 0x004C4D97 File Offset: 0x004C2F97
		public Span<int> GetPointLightEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602266C RID: 140908 RVA: 0x004C4DA6 File Offset: 0x004C2FA6
		public int[] GetPointLightEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602266D RID: 140909 RVA: 0x004C4DB4 File Offset: 0x004C2FB4
		public IPointLightOperations? PointLightConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPointLightOperations?(default(IPointLightOperations).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009ADA RID: 39642
		// (get) Token: 0x0602266E RID: 140910 RVA: 0x004C4E14 File Offset: 0x004C3014
		public int PointLightConfigLength
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

		// Token: 0x0602266F RID: 140911 RVA: 0x004C4E3F File Offset: 0x004C303F
		public static Offset<IFlowerPollutionPointLightConfig> CreateIFlowerPollutionPointLightConfig(FlatBufferBuilder builder, VectorOffset PointLightEntityIdsOffset = default(VectorOffset), VectorOffset PointLightConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFlowerPollutionPointLightConfig.AddPointLightConfig(builder, PointLightConfigOffset);
			IFlowerPollutionPointLightConfig.AddPointLightEntityIds(builder, PointLightEntityIdsOffset);
			return IFlowerPollutionPointLightConfig.EndIFlowerPollutionPointLightConfig(builder);
		}

		// Token: 0x06022670 RID: 140912 RVA: 0x004C4E5C File Offset: 0x004C305C
		public static void StartIFlowerPollutionPointLightConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022671 RID: 140913 RVA: 0x004C4E65 File Offset: 0x004C3065
		public static void AddPointLightEntityIds(FlatBufferBuilder builder, VectorOffset pointLightEntityIdsOffset)
		{
			builder.AddOffset(0, pointLightEntityIdsOffset.Value, 0);
		}

		// Token: 0x06022672 RID: 140914 RVA: 0x004C4E78 File Offset: 0x004C3078
		public static VectorOffset CreatePointLightEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022673 RID: 140915 RVA: 0x004C4EAF File Offset: 0x004C30AF
		public static VectorOffset CreatePointLightEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022674 RID: 140916 RVA: 0x004C4EC9 File Offset: 0x004C30C9
		public static VectorOffset CreatePointLightEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022675 RID: 140917 RVA: 0x004C4EE7 File Offset: 0x004C30E7
		public static VectorOffset CreatePointLightEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022676 RID: 140918 RVA: 0x004C4F00 File Offset: 0x004C3100
		public static void StartPointLightEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022677 RID: 140919 RVA: 0x004C4F0B File Offset: 0x004C310B
		public static void AddPointLightConfig(FlatBufferBuilder builder, VectorOffset pointLightConfigOffset)
		{
			builder.AddOffset(1, pointLightConfigOffset.Value, 0);
		}

		// Token: 0x06022678 RID: 140920 RVA: 0x004C4F1C File Offset: 0x004C311C
		public static VectorOffset CreatePointLightConfigVector(FlatBufferBuilder builder, Offset<IPointLightOperations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022679 RID: 140921 RVA: 0x004C4F5C File Offset: 0x004C315C
		public static VectorOffset CreatePointLightConfigVectorBlock(FlatBufferBuilder builder, Offset<IPointLightOperations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPointLightOperations>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602267A RID: 140922 RVA: 0x004C4F76 File Offset: 0x004C3176
		public static VectorOffset CreatePointLightConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPointLightOperations>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPointLightOperations>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602267B RID: 140923 RVA: 0x004C4F94 File Offset: 0x004C3194
		public static VectorOffset CreatePointLightConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPointLightOperations>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602267C RID: 140924 RVA: 0x004C4FAD File Offset: 0x004C31AD
		public static void StartPointLightConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602267D RID: 140925 RVA: 0x004C4FB8 File Offset: 0x004C31B8
		public static Offset<IFlowerPollutionPointLightConfig> EndIFlowerPollutionPointLightConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlowerPollutionPointLightConfig>(builder.EndTable());
		}

		// Token: 0x0602267E RID: 140926 RVA: 0x004C4FC8 File Offset: 0x004C31C8
		public IFlowerPollutionPointLightConfigT UnPack()
		{
			IFlowerPollutionPointLightConfigT flowerPollutionPointLightConfigT = new IFlowerPollutionPointLightConfigT();
			this.UnPackTo(flowerPollutionPointLightConfigT);
			return flowerPollutionPointLightConfigT;
		}

		// Token: 0x0602267F RID: 140927 RVA: 0x004C4FE4 File Offset: 0x004C31E4
		public void UnPackTo(IFlowerPollutionPointLightConfigT _o)
		{
			_o.PointLightEntityIds = new List<int>();
			for (int i = 0; i < this.PointLightEntityIdsLength; i++)
			{
				_o.PointLightEntityIds.Add(this.PointLightEntityIds(i));
			}
			_o.PointLightConfig = new List<IPointLightOperationsT>();
			for (int j = 0; j < this.PointLightConfigLength; j++)
			{
				_o.PointLightConfig.Add((this.PointLightConfig(j) != null) ? this.PointLightConfig(j).Value.UnPack() : null);
			}
		}

		// Token: 0x06022680 RID: 140928 RVA: 0x004C5074 File Offset: 0x004C3274
		public static Offset<IFlowerPollutionPointLightConfig> Pack(FlatBufferBuilder builder, IFlowerPollutionPointLightConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowerPollutionPointLightConfig>);
			}
			VectorOffset pointLightEntityIdsOffset = default(VectorOffset);
			if (_o.PointLightEntityIds != null)
			{
				int[] data = _o.PointLightEntityIds.ToArray();
				pointLightEntityIdsOffset = IFlowerPollutionPointLightConfig.CreatePointLightEntityIdsVector(builder, data);
			}
			VectorOffset pointLightConfigOffset = default(VectorOffset);
			if (_o.PointLightConfig != null)
			{
				Offset<IPointLightOperations>[] array = new Offset<IPointLightOperations>[_o.PointLightConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPointLightOperations.Pack(builder, _o.PointLightConfig[i]);
				}
				pointLightConfigOffset = IFlowerPollutionPointLightConfig.CreatePointLightConfigVector(builder, array);
			}
			return IFlowerPollutionPointLightConfig.CreateIFlowerPollutionPointLightConfig(builder, pointLightEntityIdsOffset, pointLightConfigOffset);
		}

		// Token: 0x0400E3E9 RID: 58345
		private Table __p;
	}
}
