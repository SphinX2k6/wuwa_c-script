using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B1A RID: 23322
	public struct IVehicleGenerationConfig : IFlatbufferObject
	{
		// Token: 0x1700B005 RID: 45061
		// (get) Token: 0x06027D92 RID: 163218 RVA: 0x0057AF88 File Offset: 0x00579188
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027D93 RID: 163219 RVA: 0x0057AF95 File Offset: 0x00579195
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027D94 RID: 163220 RVA: 0x0057AF9C File Offset: 0x0057919C
		public static IVehicleGenerationConfig GetRootAsIVehicleGenerationConfig(ByteBuffer _bb)
		{
			return IVehicleGenerationConfig.GetRootAsIVehicleGenerationConfig(_bb, default(IVehicleGenerationConfig));
		}

		// Token: 0x06027D95 RID: 163221 RVA: 0x0057AFB8 File Offset: 0x005791B8
		public static IVehicleGenerationConfig GetRootAsIVehicleGenerationConfig(ByteBuffer _bb, IVehicleGenerationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027D96 RID: 163222 RVA: 0x0057AFD5 File Offset: 0x005791D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027D97 RID: 163223 RVA: 0x0057AFE4 File Offset: 0x005791E4
		public IVehicleGenerationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B006 RID: 45062
		// (get) Token: 0x06027D98 RID: 163224 RVA: 0x0057AFF4 File Offset: 0x005791F4
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

		// Token: 0x06027D99 RID: 163225 RVA: 0x0057B034 File Offset: 0x00579234
		public ISplineWayPoint? Destinations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISplineWayPoint?(default(ISplineWayPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B007 RID: 45063
		// (get) Token: 0x06027D9A RID: 163226 RVA: 0x0057B094 File Offset: 0x00579294
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

		// Token: 0x06027D9B RID: 163227 RVA: 0x0057B0C0 File Offset: 0x005792C0
		public TVehicleGenerationType VehicleConfigType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TVehicleGenerationType.NONE;
			}
			return (TVehicleGenerationType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B008 RID: 45064
		// (get) Token: 0x06027D9C RID: 163228 RVA: 0x0057B100 File Offset: 0x00579300
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

		// Token: 0x06027D9D RID: 163229 RVA: 0x0057B12B File Offset: 0x0057932B
		public Span<TVehicleGenerationType> GetVehicleConfigTypeBytes()
		{
			return this.__p.__vector_as_span<TVehicleGenerationType>(8, 1);
		}

		// Token: 0x06027D9E RID: 163230 RVA: 0x0057B13C File Offset: 0x0057933C
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

		// Token: 0x06027D9F RID: 163231 RVA: 0x0057B1A8 File Offset: 0x005793A8
		public TTable? VehicleConfig<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B009 RID: 45065
		// (get) Token: 0x06027DA0 RID: 163232 RVA: 0x0057B1F0 File Offset: 0x005793F0
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

		// Token: 0x1700B00A RID: 45066
		// (get) Token: 0x06027DA1 RID: 163233 RVA: 0x0057B21C File Offset: 0x0057941C
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

		// Token: 0x1700B00B RID: 45067
		// (get) Token: 0x06027DA2 RID: 163234 RVA: 0x0057B260 File Offset: 0x00579460
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

		// Token: 0x06027DA3 RID: 163235 RVA: 0x0057B2BE File Offset: 0x005794BE
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

		// Token: 0x06027DA4 RID: 163236 RVA: 0x0057B2FA File Offset: 0x005794FA
		public static void StartIVehicleGenerationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06027DA5 RID: 163237 RVA: 0x0057B303 File Offset: 0x00579503
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(0, range, 0.0);
		}

		// Token: 0x06027DA6 RID: 163238 RVA: 0x0057B316 File Offset: 0x00579516
		public static void AddDestinations(FlatBufferBuilder builder, VectorOffset destinationsOffset)
		{
			builder.AddOffset(1, destinationsOffset.Value, 0);
		}

		// Token: 0x06027DA7 RID: 163239 RVA: 0x0057B328 File Offset: 0x00579528
		public static VectorOffset CreateDestinationsVector(FlatBufferBuilder builder, Offset<ISplineWayPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027DA8 RID: 163240 RVA: 0x0057B368 File Offset: 0x00579568
		public static VectorOffset CreateDestinationsVectorBlock(FlatBufferBuilder builder, Offset<ISplineWayPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISplineWayPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027DA9 RID: 163241 RVA: 0x0057B382 File Offset: 0x00579582
		public static VectorOffset CreateDestinationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISplineWayPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISplineWayPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027DAA RID: 163242 RVA: 0x0057B3A0 File Offset: 0x005795A0
		public static VectorOffset CreateDestinationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISplineWayPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027DAB RID: 163243 RVA: 0x0057B3B9 File Offset: 0x005795B9
		public static void StartDestinationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027DAC RID: 163244 RVA: 0x0057B3C4 File Offset: 0x005795C4
		public static void AddVehicleConfigType(FlatBufferBuilder builder, VectorOffset vehicleConfigTypeOffset)
		{
			builder.AddOffset(2, vehicleConfigTypeOffset.Value, 0);
		}

		// Token: 0x06027DAD RID: 163245 RVA: 0x0057B3D4 File Offset: 0x005795D4
		public static VectorOffset CreateVehicleConfigTypeVector(FlatBufferBuilder builder, TVehicleGenerationType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027DAE RID: 163246 RVA: 0x0057B40B File Offset: 0x0057960B
		public static VectorOffset CreateVehicleConfigTypeVectorBlock(FlatBufferBuilder builder, TVehicleGenerationType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVehicleGenerationType>(data);
			return builder.EndVector();
		}

		// Token: 0x06027DAF RID: 163247 RVA: 0x0057B425 File Offset: 0x00579625
		public static VectorOffset CreateVehicleConfigTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVehicleGenerationType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVehicleGenerationType>(data);
			return builder.EndVector();
		}

		// Token: 0x06027DB0 RID: 163248 RVA: 0x0057B443 File Offset: 0x00579643
		public static VectorOffset CreateVehicleConfigTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVehicleGenerationType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027DB1 RID: 163249 RVA: 0x0057B45C File Offset: 0x0057965C
		public static void StartVehicleConfigTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06027DB2 RID: 163250 RVA: 0x0057B467 File Offset: 0x00579667
		public static void AddVehicleConfig(FlatBufferBuilder builder, VectorOffset vehicleConfigOffset)
		{
			builder.AddOffset(3, vehicleConfigOffset.Value, 0);
		}

		// Token: 0x06027DB3 RID: 163251 RVA: 0x0057B478 File Offset: 0x00579678
		public static VectorOffset CreateVehicleConfigVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027DB4 RID: 163252 RVA: 0x0057B4AF File Offset: 0x005796AF
		public static VectorOffset CreateVehicleConfigVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027DB5 RID: 163253 RVA: 0x0057B4C9 File Offset: 0x005796C9
		public static VectorOffset CreateVehicleConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027DB6 RID: 163254 RVA: 0x0057B4E7 File Offset: 0x005796E7
		public static VectorOffset CreateVehicleConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027DB7 RID: 163255 RVA: 0x0057B500 File Offset: 0x00579700
		public static void StartVehicleConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027DB8 RID: 163256 RVA: 0x0057B50B File Offset: 0x0057970B
		public static void AddCd(FlatBufferBuilder builder, float cd)
		{
			builder.AddFloat(4, cd, 0.0);
		}

		// Token: 0x06027DB9 RID: 163257 RVA: 0x0057B51E File Offset: 0x0057971E
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(5, offsetOffset.Value, 0);
		}

		// Token: 0x06027DBA RID: 163258 RVA: 0x0057B52E File Offset: 0x0057972E
		public static Offset<IVehicleGenerationConfig> EndIVehicleGenerationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleGenerationConfig>(builder.EndTable());
		}

		// Token: 0x06027DBB RID: 163259 RVA: 0x0057B53C File Offset: 0x0057973C
		public IVehicleGenerationConfigT UnPack()
		{
			IVehicleGenerationConfigT vehicleGenerationConfigT = new IVehicleGenerationConfigT();
			this.UnPackTo(vehicleGenerationConfigT);
			return vehicleGenerationConfigT;
		}

		// Token: 0x06027DBC RID: 163260 RVA: 0x0057B558 File Offset: 0x00579758
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

		// Token: 0x06027DBD RID: 163261 RVA: 0x0057B6C8 File Offset: 0x005798C8
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

		// Token: 0x0400F232 RID: 62002
		private Table __p;
	}
}
