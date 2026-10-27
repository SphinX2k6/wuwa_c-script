using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FD6 RID: 20438
	public struct ICompassTracking : IFlatbufferObject
	{
		// Token: 0x1700940F RID: 37903
		// (get) Token: 0x060208D5 RID: 133333 RVA: 0x00486E6E File Offset: 0x0048506E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060208D6 RID: 133334 RVA: 0x00486E7B File Offset: 0x0048507B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060208D7 RID: 133335 RVA: 0x00486E84 File Offset: 0x00485084
		public static ICompassTracking GetRootAsICompassTracking(ByteBuffer _bb)
		{
			return ICompassTracking.GetRootAsICompassTracking(_bb, default(ICompassTracking));
		}

		// Token: 0x060208D8 RID: 133336 RVA: 0x00486EA0 File Offset: 0x004850A0
		public static ICompassTracking GetRootAsICompassTracking(ByteBuffer _bb, ICompassTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060208D9 RID: 133337 RVA: 0x00486EBD File Offset: 0x004850BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060208DA RID: 133338 RVA: 0x00486ECC File Offset: 0x004850CC
		public ICompassTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009410 RID: 37904
		// (get) Token: 0x060208DB RID: 133339 RVA: 0x00486EDC File Offset: 0x004850DC
		public ENearbyTrackingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENearbyTrackingType.Icon;
				}
				return (ENearbyTrackingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009411 RID: 37905
		// (get) Token: 0x060208DC RID: 133340 RVA: 0x00486F18 File Offset: 0x00485118
		public int ShowRange
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

		// Token: 0x17009412 RID: 37906
		// (get) Token: 0x060208DD RID: 133341 RVA: 0x00486F54 File Offset: 0x00485154
		public int HideRange
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009413 RID: 37907
		// (get) Token: 0x060208DE RID: 133342 RVA: 0x00486F90 File Offset: 0x00485190
		public IIconNearByTrackingConfig? IconTrackingConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IIconNearByTrackingConfig?(default(IIconNearByTrackingConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060208DF RID: 133343 RVA: 0x00486FF0 File Offset: 0x004851F0
		public EVehicleType VehicleTypes(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return EVehicleType.Gongduola;
			}
			return (EVehicleType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009414 RID: 37908
		// (get) Token: 0x060208E0 RID: 133344 RVA: 0x00487030 File Offset: 0x00485230
		public int VehicleTypesLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060208E1 RID: 133345 RVA: 0x0048705C File Offset: 0x0048525C
		public Span<EVehicleType> GetVehicleTypesBytes()
		{
			return this.__p.__vector_as_span<EVehicleType>(12, 1);
		}

		// Token: 0x060208E2 RID: 133346 RVA: 0x0048706C File Offset: 0x0048526C
		public EVehicleType[] GetVehicleTypesArray()
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EVehicleType[] array = new EVehicleType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EVehicleType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x17009415 RID: 37909
		// (get) Token: 0x060208E3 RID: 133347 RVA: 0x004870D8 File Offset: 0x004852D8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060208E4 RID: 133348 RVA: 0x00487115 File Offset: 0x00485315
		public static Offset<ICompassTracking> CreateICompassTracking(FlatBufferBuilder builder, ENearbyTrackingType Type = ENearbyTrackingType.Icon, int ShowRange = 0, int HideRange = 0, Offset<IIconNearByTrackingConfig> IconTrackingConfigOffset = default(Offset<IIconNearByTrackingConfig>), VectorOffset VehicleTypesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			ICompassTracking.AddVehicleTypes(builder, VehicleTypesOffset);
			ICompassTracking.AddIconTrackingConfig(builder, IconTrackingConfigOffset);
			ICompassTracking.AddHideRange(builder, HideRange);
			ICompassTracking.AddShowRange(builder, ShowRange);
			ICompassTracking.AddNullMask(builder, NullMask);
			ICompassTracking.AddType(builder, Type);
			return ICompassTracking.EndICompassTracking(builder);
		}

		// Token: 0x060208E5 RID: 133349 RVA: 0x00487151 File Offset: 0x00485351
		public static void StartICompassTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060208E6 RID: 133350 RVA: 0x0048715A File Offset: 0x0048535A
		public static void AddType(FlatBufferBuilder builder, ENearbyTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060208E7 RID: 133351 RVA: 0x00487165 File Offset: 0x00485365
		public static void AddShowRange(FlatBufferBuilder builder, int showRange)
		{
			builder.AddInt(1, showRange, 0);
		}

		// Token: 0x060208E8 RID: 133352 RVA: 0x00487170 File Offset: 0x00485370
		public static void AddHideRange(FlatBufferBuilder builder, int hideRange)
		{
			builder.AddInt(2, hideRange, 0);
		}

		// Token: 0x060208E9 RID: 133353 RVA: 0x0048717B File Offset: 0x0048537B
		public static void AddIconTrackingConfig(FlatBufferBuilder builder, Offset<IIconNearByTrackingConfig> iconTrackingConfigOffset)
		{
			builder.AddOffset(3, iconTrackingConfigOffset.Value, 0);
		}

		// Token: 0x060208EA RID: 133354 RVA: 0x0048718B File Offset: 0x0048538B
		public static void AddVehicleTypes(FlatBufferBuilder builder, VectorOffset vehicleTypesOffset)
		{
			builder.AddOffset(4, vehicleTypesOffset.Value, 0);
		}

		// Token: 0x060208EB RID: 133355 RVA: 0x0048719C File Offset: 0x0048539C
		public static VectorOffset CreateVehicleTypesVector(FlatBufferBuilder builder, EVehicleType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060208EC RID: 133356 RVA: 0x004871D3 File Offset: 0x004853D3
		public static VectorOffset CreateVehicleTypesVectorBlock(FlatBufferBuilder builder, EVehicleType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EVehicleType>(data);
			return builder.EndVector();
		}

		// Token: 0x060208ED RID: 133357 RVA: 0x004871ED File Offset: 0x004853ED
		public static VectorOffset CreateVehicleTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<EVehicleType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EVehicleType>(data);
			return builder.EndVector();
		}

		// Token: 0x060208EE RID: 133358 RVA: 0x0048720B File Offset: 0x0048540B
		public static VectorOffset CreateVehicleTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EVehicleType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060208EF RID: 133359 RVA: 0x00487224 File Offset: 0x00485424
		public static void StartVehicleTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060208F0 RID: 133360 RVA: 0x0048722F File Offset: 0x0048542F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060208F1 RID: 133361 RVA: 0x0048723A File Offset: 0x0048543A
		public static Offset<ICompassTracking> EndICompassTracking(FlatBufferBuilder builder)
		{
			return new Offset<ICompassTracking>(builder.EndTable());
		}

		// Token: 0x060208F2 RID: 133362 RVA: 0x00487248 File Offset: 0x00485448
		public ICompassTrackingT UnPack()
		{
			ICompassTrackingT compassTrackingT = new ICompassTrackingT();
			this.UnPackTo(compassTrackingT);
			return compassTrackingT;
		}

		// Token: 0x060208F3 RID: 133363 RVA: 0x00487264 File Offset: 0x00485464
		public void UnPackTo(ICompassTrackingT _o)
		{
			_o.Type = this.Type;
			_o.ShowRange = this.ShowRange;
			_o.HideRange = this.HideRange;
			_o.IconTrackingConfig = ((this.IconTrackingConfig != null) ? this.IconTrackingConfig.Value.UnPack() : null);
			_o.VehicleTypes = new List<EVehicleType>();
			for (int i = 0; i < this.VehicleTypesLength; i++)
			{
				_o.VehicleTypes.Add(this.VehicleTypes(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060208F4 RID: 133364 RVA: 0x00487300 File Offset: 0x00485500
		public static Offset<ICompassTracking> Pack(FlatBufferBuilder builder, ICompassTrackingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompassTracking>);
			}
			Offset<IIconNearByTrackingConfig> iconTrackingConfigOffset = (_o.IconTrackingConfig == null) ? default(Offset<IIconNearByTrackingConfig>) : IIconNearByTrackingConfig.Pack(builder, _o.IconTrackingConfig);
			VectorOffset vehicleTypesOffset = default(VectorOffset);
			if (_o.VehicleTypes != null)
			{
				EVehicleType[] data = _o.VehicleTypes.ToArray();
				vehicleTypesOffset = ICompassTracking.CreateVehicleTypesVector(builder, data);
			}
			return ICompassTracking.CreateICompassTracking(builder, _o.Type, _o.ShowRange, _o.HideRange, iconTrackingConfigOffset, vehicleTypesOffset, _o.NullMask);
		}

		// Token: 0x0400DEC1 RID: 57025
		private Table __p;
	}
}
