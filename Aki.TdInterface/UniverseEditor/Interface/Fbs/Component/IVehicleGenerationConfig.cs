using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006130 RID: 24880
	public struct IVehicleGenerationConfig : IFlatbufferObject
	{
		// Token: 0x1700B94D RID: 47437
		// (get) Token: 0x0602A356 RID: 172886 RVA: 0x005C29DC File Offset: 0x005C0BDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A357 RID: 172887 RVA: 0x005C29E9 File Offset: 0x005C0BE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A358 RID: 172888 RVA: 0x005C29F0 File Offset: 0x005C0BF0
		public static IVehicleGenerationConfig GetRootAsIVehicleGenerationConfig(ByteBuffer _bb)
		{
			return IVehicleGenerationConfig.GetRootAsIVehicleGenerationConfig(_bb, default(IVehicleGenerationConfig));
		}

		// Token: 0x0602A359 RID: 172889 RVA: 0x005C2A0C File Offset: 0x005C0C0C
		public static IVehicleGenerationConfig GetRootAsIVehicleGenerationConfig(ByteBuffer _bb, IVehicleGenerationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A35A RID: 172890 RVA: 0x005C2A29 File Offset: 0x005C0C29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A35B RID: 172891 RVA: 0x005C2A38 File Offset: 0x005C0C38
		public IVehicleGenerationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B94E RID: 47438
		// (get) Token: 0x0602A35C RID: 172892 RVA: 0x005C2A48 File Offset: 0x005C0C48
		public float Range
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A35D RID: 172893 RVA: 0x005C2A88 File Offset: 0x005C0C88
		public ISplineWayPoint? Destinations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISplineWayPoint?(default(ISplineWayPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B94F RID: 47439
		// (get) Token: 0x0602A35E RID: 172894 RVA: 0x005C2AE8 File Offset: 0x005C0CE8
		public int DestinationsLength
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

		// Token: 0x0602A35F RID: 172895 RVA: 0x005C2B14 File Offset: 0x005C0D14
		public TVehicleGenerationType VehicleConfigType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TVehicleGenerationType.NONE;
			}
			return (TVehicleGenerationType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B950 RID: 47440
		// (get) Token: 0x0602A360 RID: 172896 RVA: 0x005C2B54 File Offset: 0x005C0D54
		public int VehicleConfigTypeLength
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

		// Token: 0x0602A361 RID: 172897 RVA: 0x005C2B7F File Offset: 0x005C0D7F
		public Span<TVehicleGenerationType> GetVehicleConfigTypeBytes()
		{
			return this.__p.__vector_as_span<TVehicleGenerationType>(8, 1);
		}

		// Token: 0x0602A362 RID: 172898 RVA: 0x005C2B90 File Offset: 0x005C0D90
		public TVehicleGenerationType[] GetVehicleConfigTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TVehicleGenerationType[] array = new TVehicleGenerationType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TVehicleGenerationType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602A363 RID: 172899 RVA: 0x005C2BFC File Offset: 0x005C0DFC
		public TTable? VehicleConfig<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B951 RID: 47441
		// (get) Token: 0x0602A364 RID: 172900 RVA: 0x005C2C44 File Offset: 0x005C0E44
		public int VehicleConfigLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B952 RID: 47442
		// (get) Token: 0x0602A365 RID: 172901 RVA: 0x005C2C70 File Offset: 0x005C0E70
		public float Cd
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B953 RID: 47443
		// (get) Token: 0x0602A366 RID: 172902 RVA: 0x005C2CB4 File Offset: 0x005C0EB4
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602A367 RID: 172903 RVA: 0x005C2D12 File Offset: 0x005C0F12
		public static Offset<IVehicleGenerationConfig> CreateIVehicleGenerationConfig(FlatBufferBuilder builder, float Range = 0f, VectorOffset DestinationsOffset = default(VectorOffset), VectorOffset VehicleConfig_typeOffset = default(VectorOffset), VectorOffset VehicleConfigOffset = default(VectorOffset), float Cd = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(6);
			IVehicleGenerationConfig.AddOffset(builder, OffsetOffset);
			IVehicleGenerationConfig.AddCd(builder, Cd);
			IVehicleGenerationConfig.AddVehicleConfig(builder, VehicleConfigOffset);
			IVehicleGenerationConfig.AddVehicleConfigType(builder, VehicleConfig_typeOffset);
			IVehicleGenerationConfig.AddDestinations(builder, DestinationsOffset);
			IVehicleGenerationConfig.AddRange(builder, Range);
			return IVehicleGenerationConfig.EndIVehicleGenerationConfig(builder);
		}

		// Token: 0x0602A368 RID: 172904 RVA: 0x005C2D4E File Offset: 0x005C0F4E
		public static void StartIVehicleGenerationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602A369 RID: 172905 RVA: 0x005C2D57 File Offset: 0x005C0F57
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(0, range, 0.0);
		}

		// Token: 0x0602A36A RID: 172906 RVA: 0x005C2D6A File Offset: 0x005C0F6A
		public static void AddDestinations(FlatBufferBuilder builder, VectorOffset destinationsOffset)
		{
			builder.AddOffset(1, destinationsOffset.Value, 0);
		}

		// Token: 0x0602A36B RID: 172907 RVA: 0x005C2D7C File Offset: 0x005C0F7C
		public static VectorOffset CreateDestinationsVector(FlatBufferBuilder builder, Offset<ISplineWayPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A36C RID: 172908 RVA: 0x005C2DBC File Offset: 0x005C0FBC
		public static VectorOffset CreateDestinationsVectorBlock(FlatBufferBuilder builder, Offset<ISplineWayPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISplineWayPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A36D RID: 172909 RVA: 0x005C2DD6 File Offset: 0x005C0FD6
		public static VectorOffset CreateDestinationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISplineWayPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISplineWayPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A36E RID: 172910 RVA: 0x005C2DF4 File Offset: 0x005C0FF4
		public static VectorOffset CreateDestinationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISplineWayPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A36F RID: 172911 RVA: 0x005C2E0D File Offset: 0x005C100D
		public static void StartDestinationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A370 RID: 172912 RVA: 0x005C2E18 File Offset: 0x005C1018
		public static void AddVehicleConfigType(FlatBufferBuilder builder, VectorOffset vehicleConfigTypeOffset)
		{
			builder.AddOffset(2, vehicleConfigTypeOffset.Value, 0);
		}

		// Token: 0x0602A371 RID: 172913 RVA: 0x005C2E28 File Offset: 0x005C1028
		public static VectorOffset CreateVehicleConfigTypeVector(FlatBufferBuilder builder, TVehicleGenerationType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A372 RID: 172914 RVA: 0x005C2E5F File Offset: 0x005C105F
		public static VectorOffset CreateVehicleConfigTypeVectorBlock(FlatBufferBuilder builder, TVehicleGenerationType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVehicleGenerationType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A373 RID: 172915 RVA: 0x005C2E79 File Offset: 0x005C1079
		public static VectorOffset CreateVehicleConfigTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVehicleGenerationType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVehicleGenerationType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A374 RID: 172916 RVA: 0x005C2E97 File Offset: 0x005C1097
		public static VectorOffset CreateVehicleConfigTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVehicleGenerationType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A375 RID: 172917 RVA: 0x005C2EB0 File Offset: 0x005C10B0
		public static void StartVehicleConfigTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602A376 RID: 172918 RVA: 0x005C2EBB File Offset: 0x005C10BB
		public static void AddVehicleConfig(FlatBufferBuilder builder, VectorOffset vehicleConfigOffset)
		{
			builder.AddOffset(3, vehicleConfigOffset.Value, 0);
		}

		// Token: 0x0602A377 RID: 172919 RVA: 0x005C2ECC File Offset: 0x005C10CC
		public static VectorOffset CreateVehicleConfigVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A378 RID: 172920 RVA: 0x005C2F03 File Offset: 0x005C1103
		public static VectorOffset CreateVehicleConfigVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A379 RID: 172921 RVA: 0x005C2F1D File Offset: 0x005C111D
		public static VectorOffset CreateVehicleConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A37A RID: 172922 RVA: 0x005C2F3B File Offset: 0x005C113B
		public static VectorOffset CreateVehicleConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A37B RID: 172923 RVA: 0x005C2F54 File Offset: 0x005C1154
		public static void StartVehicleConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A37C RID: 172924 RVA: 0x005C2F5F File Offset: 0x005C115F
		public static void AddCd(FlatBufferBuilder builder, float cd)
		{
			builder.AddFloat(4, cd, 0.0);
		}

		// Token: 0x0602A37D RID: 172925 RVA: 0x005C2F72 File Offset: 0x005C1172
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(5, offsetOffset.Value, 0);
		}

		// Token: 0x0602A37E RID: 172926 RVA: 0x005C2F82 File Offset: 0x005C1182
		public static Offset<IVehicleGenerationConfig> EndIVehicleGenerationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleGenerationConfig>(builder.EndTable());
		}

		// Token: 0x0602A37F RID: 172927 RVA: 0x005C2F90 File Offset: 0x005C1190
		public IVehicleGenerationConfigT UnPack()
		{
			IVehicleGenerationConfigT vehicleGenerationConfigT = new IVehicleGenerationConfigT();
			this.UnPackTo(vehicleGenerationConfigT);
			return vehicleGenerationConfigT;
		}

		// Token: 0x0602A380 RID: 172928 RVA: 0x005C2FAC File Offset: 0x005C11AC
		public void UnPackTo(IVehicleGenerationConfigT _o)
		{
			_o.Range = this.Range;
			_o.Destinations = new List<ISplineWayPointT>();
			for (int i = 0; i < this.DestinationsLength; i++)
			{
				_o.Destinations.Add((this.Destinations(i) != null) ? this.Destinations(i).Value.UnPack() : null);
			}
			_o.VehicleConfig = new List<TVehicleGenerationTypeUnion>();
			for (int j = 0; j < this.VehicleConfigLength; j++)
			{
				TVehicleGenerationTypeUnion tvehicleGenerationTypeUnion = new TVehicleGenerationTypeUnion();
				tvehicleGenerationTypeUnion.Type = this.VehicleConfigType(j);
				TVehicleGenerationType tvehicleGenerationType = this.VehicleConfigType(j);
				if (tvehicleGenerationType != TVehicleGenerationType.IVehicleGenerateByVehicleEntityTemplate)
				{
					if (tvehicleGenerationType == TVehicleGenerationType.IVehicleGenerateByVehicleTeamTemplate)
					{
						tvehicleGenerationTypeUnion.Value = ((this.VehicleConfig<IVehicleGenerateByVehicleTeamTemplate>(j) != null) ? this.VehicleConfig<IVehicleGenerateByVehicleTeamTemplate>(j).Value.UnPack() : null);
					}
				}
				else
				{
					tvehicleGenerationTypeUnion.Value = ((this.VehicleConfig<IVehicleGenerateByVehicleEntityTemplate>(j) != null) ? this.VehicleConfig<IVehicleGenerateByVehicleEntityTemplate>(j).Value.UnPack() : null);
				}
				_o.VehicleConfig.Add(tvehicleGenerationTypeUnion);
			}
			_o.Cd = this.Cd;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x0602A381 RID: 172929 RVA: 0x005C311C File Offset: 0x005C131C
		public static Offset<IVehicleGenerationConfig> Pack(FlatBufferBuilder builder, IVehicleGenerationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleGenerationConfig>);
			}
			VectorOffset destinationsOffset = default(VectorOffset);
			if (_o.Destinations != null)
			{
				Offset<ISplineWayPoint>[] array = new Offset<ISplineWayPoint>[_o.Destinations.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISplineWayPoint.Pack(builder, _o.Destinations[i]);
				}
				destinationsOffset = IVehicleGenerationConfig.CreateDestinationsVector(builder, array);
			}
			VectorOffset vehicleConfig_typeOffset = default(VectorOffset);
			if (_o.VehicleConfig != null)
			{
				TVehicleGenerationType[] array2 = new TVehicleGenerationType[_o.VehicleConfig.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = _o.VehicleConfig[j].Type;
				}
				vehicleConfig_typeOffset = IVehicleGenerationConfig.CreateVehicleConfigTypeVector(builder, array2);
			}
			VectorOffset vehicleConfigOffset = default(VectorOffset);
			if (_o.VehicleConfig != null)
			{
				int[] array3 = new int[_o.VehicleConfig.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = TVehicleGenerationTypeUnion.Pack(builder, _o.VehicleConfig[k]);
				}
				vehicleConfigOffset = IVehicleGenerationConfig.CreateVehicleConfigVector(builder, array3);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IVehicleGenerationConfig.CreateIVehicleGenerationConfig(builder, _o.Range, destinationsOffset, vehicleConfig_typeOffset, vehicleConfigOffset, _o.Cd, offsetOffset);
		}

		// Token: 0x0400FF38 RID: 65336
		private Table __p;
	}
}
