using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057EA RID: 22506
	public struct IFlowerPollutionPointLightConfig : IFlatbufferObject
	{
		// Token: 0x1700A2D6 RID: 41686
		// (get) Token: 0x060245FD RID: 148989 RVA: 0x004FF82F File Offset: 0x004FDA2F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060245FE RID: 148990 RVA: 0x004FF83C File Offset: 0x004FDA3C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060245FF RID: 148991 RVA: 0x004FF844 File Offset: 0x004FDA44
		public static IFlowerPollutionPointLightConfig GetRootAsIFlowerPollutionPointLightConfig(ByteBuffer _bb)
		{
			return IFlowerPollutionPointLightConfig.GetRootAsIFlowerPollutionPointLightConfig(_bb, default(IFlowerPollutionPointLightConfig));
		}

		// Token: 0x06024600 RID: 148992 RVA: 0x004FF860 File Offset: 0x004FDA60
		public static IFlowerPollutionPointLightConfig GetRootAsIFlowerPollutionPointLightConfig(ByteBuffer _bb, IFlowerPollutionPointLightConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024601 RID: 148993 RVA: 0x004FF87D File Offset: 0x004FDA7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024602 RID: 148994 RVA: 0x004FF88C File Offset: 0x004FDA8C
		public IFlowerPollutionPointLightConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06024603 RID: 148995 RVA: 0x004FF89C File Offset: 0x004FDA9C
		public int PointLightEntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A2D7 RID: 41687
		// (get) Token: 0x06024604 RID: 148996 RVA: 0x004FF8DC File Offset: 0x004FDADC
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

		// Token: 0x06024605 RID: 148997 RVA: 0x004FF907 File Offset: 0x004FDB07
		public Span<int> GetPointLightEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06024606 RID: 148998 RVA: 0x004FF916 File Offset: 0x004FDB16
		public int[] GetPointLightEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06024607 RID: 148999 RVA: 0x004FF924 File Offset: 0x004FDB24
		public IPointLightOperations? PointLightConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPointLightOperations?(default(IPointLightOperations).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2D8 RID: 41688
		// (get) Token: 0x06024608 RID: 149000 RVA: 0x004FF984 File Offset: 0x004FDB84
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

		// Token: 0x06024609 RID: 149001 RVA: 0x004FF9AF File Offset: 0x004FDBAF
		public static Offset<IFlowerPollutionPointLightConfig> CreateIFlowerPollutionPointLightConfig(FlatBufferBuilder builder, VectorOffset PointLightEntityIdsOffset = default(VectorOffset), VectorOffset PointLightConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFlowerPollutionPointLightConfig.AddPointLightConfig(builder, PointLightConfigOffset);
			IFlowerPollutionPointLightConfig.AddPointLightEntityIds(builder, PointLightEntityIdsOffset);
			return IFlowerPollutionPointLightConfig.EndIFlowerPollutionPointLightConfig(builder);
		}

		// Token: 0x0602460A RID: 149002 RVA: 0x004FF9CC File Offset: 0x004FDBCC
		public static void StartIFlowerPollutionPointLightConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602460B RID: 149003 RVA: 0x004FF9D5 File Offset: 0x004FDBD5
		public static void AddPointLightEntityIds(FlatBufferBuilder builder, VectorOffset pointLightEntityIdsOffset)
		{
			builder.AddOffset(0, pointLightEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602460C RID: 149004 RVA: 0x004FF9E8 File Offset: 0x004FDBE8
		public static VectorOffset CreatePointLightEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602460D RID: 149005 RVA: 0x004FFA1F File Offset: 0x004FDC1F
		public static VectorOffset CreatePointLightEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602460E RID: 149006 RVA: 0x004FFA39 File Offset: 0x004FDC39
		public static VectorOffset CreatePointLightEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602460F RID: 149007 RVA: 0x004FFA57 File Offset: 0x004FDC57
		public static VectorOffset CreatePointLightEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024610 RID: 149008 RVA: 0x004FFA70 File Offset: 0x004FDC70
		public static void StartPointLightEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024611 RID: 149009 RVA: 0x004FFA7B File Offset: 0x004FDC7B
		public static void AddPointLightConfig(FlatBufferBuilder builder, VectorOffset pointLightConfigOffset)
		{
			builder.AddOffset(1, pointLightConfigOffset.Value, 0);
		}

		// Token: 0x06024612 RID: 149010 RVA: 0x004FFA8C File Offset: 0x004FDC8C
		public static VectorOffset CreatePointLightConfigVector(FlatBufferBuilder builder, Offset<IPointLightOperations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024613 RID: 149011 RVA: 0x004FFACC File Offset: 0x004FDCCC
		public static VectorOffset CreatePointLightConfigVectorBlock(FlatBufferBuilder builder, Offset<IPointLightOperations>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPointLightOperations>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024614 RID: 149012 RVA: 0x004FFAE6 File Offset: 0x004FDCE6
		public static VectorOffset CreatePointLightConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPointLightOperations>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPointLightOperations>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024615 RID: 149013 RVA: 0x004FFB04 File Offset: 0x004FDD04
		public static VectorOffset CreatePointLightConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPointLightOperations>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024616 RID: 149014 RVA: 0x004FFB1D File Offset: 0x004FDD1D
		public static void StartPointLightConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024617 RID: 149015 RVA: 0x004FFB28 File Offset: 0x004FDD28
		public static Offset<IFlowerPollutionPointLightConfig> EndIFlowerPollutionPointLightConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlowerPollutionPointLightConfig>(builder.EndTable());
		}

		// Token: 0x06024618 RID: 149016 RVA: 0x004FFB38 File Offset: 0x004FDD38
		public IFlowerPollutionPointLightConfigT UnPack()
		{
			IFlowerPollutionPointLightConfigT flowerPollutionPointLightConfigT = new IFlowerPollutionPointLightConfigT();
			this.UnPackTo(flowerPollutionPointLightConfigT);
			return flowerPollutionPointLightConfigT;
		}

		// Token: 0x06024619 RID: 149017 RVA: 0x004FFB54 File Offset: 0x004FDD54
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

		// Token: 0x0602461A RID: 149018 RVA: 0x004FFBE4 File Offset: 0x004FDDE4
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

		// Token: 0x0400EFF0 RID: 61424
		private Table __p;
	}
}
