using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005535 RID: 21813
	public struct ICompassTracking : IFlatbufferObject
	{
		// Token: 0x17009BF0 RID: 39920
		// (get) Token: 0x060227F1 RID: 141297 RVA: 0x004C082E File Offset: 0x004BEA2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060227F2 RID: 141298 RVA: 0x004C083B File Offset: 0x004BEA3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060227F3 RID: 141299 RVA: 0x004C0844 File Offset: 0x004BEA44
		public static ICompassTracking GetRootAsICompassTracking(ByteBuffer _bb)
		{
			return ICompassTracking.GetRootAsICompassTracking(_bb, default(ICompassTracking));
		}

		// Token: 0x060227F4 RID: 141300 RVA: 0x004C0860 File Offset: 0x004BEA60
		public static ICompassTracking GetRootAsICompassTracking(ByteBuffer _bb, ICompassTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060227F5 RID: 141301 RVA: 0x004C087D File Offset: 0x004BEA7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060227F6 RID: 141302 RVA: 0x004C088C File Offset: 0x004BEA8C
		public ICompassTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BF1 RID: 39921
		// (get) Token: 0x060227F7 RID: 141303 RVA: 0x004C089C File Offset: 0x004BEA9C
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

		// Token: 0x17009BF2 RID: 39922
		// (get) Token: 0x060227F8 RID: 141304 RVA: 0x004C08D8 File Offset: 0x004BEAD8
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

		// Token: 0x17009BF3 RID: 39923
		// (get) Token: 0x060227F9 RID: 141305 RVA: 0x004C0914 File Offset: 0x004BEB14
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

		// Token: 0x17009BF4 RID: 39924
		// (get) Token: 0x060227FA RID: 141306 RVA: 0x004C0950 File Offset: 0x004BEB50
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

		// Token: 0x060227FB RID: 141307 RVA: 0x004C09B0 File Offset: 0x004BEBB0
		public EVehicleType VehicleTypes(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return EVehicleType.Gongduola;
			}
			return (EVehicleType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009BF5 RID: 39925
		// (get) Token: 0x060227FC RID: 141308 RVA: 0x004C09F0 File Offset: 0x004BEBF0
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

		// Token: 0x060227FD RID: 141309 RVA: 0x004C0A1C File Offset: 0x004BEC1C
		public Span<EVehicleType> GetVehicleTypesBytes()
		{
			return this.__p.__vector_as_span<EVehicleType>(12, 1);
		}

		// Token: 0x060227FE RID: 141310 RVA: 0x004C0A2C File Offset: 0x004BEC2C
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

		// Token: 0x17009BF6 RID: 39926
		// (get) Token: 0x060227FF RID: 141311 RVA: 0x004C0A98 File Offset: 0x004BEC98
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

		// Token: 0x06022800 RID: 141312 RVA: 0x004C0AD5 File Offset: 0x004BECD5
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

		// Token: 0x06022801 RID: 141313 RVA: 0x004C0B11 File Offset: 0x004BED11
		public static void StartICompassTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06022802 RID: 141314 RVA: 0x004C0B1A File Offset: 0x004BED1A
		public static void AddType(FlatBufferBuilder builder, ENearbyTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022803 RID: 141315 RVA: 0x004C0B25 File Offset: 0x004BED25
		public static void AddShowRange(FlatBufferBuilder builder, int showRange)
		{
			builder.AddInt(1, showRange, 0);
		}

		// Token: 0x06022804 RID: 141316 RVA: 0x004C0B30 File Offset: 0x004BED30
		public static void AddHideRange(FlatBufferBuilder builder, int hideRange)
		{
			builder.AddInt(2, hideRange, 0);
		}

		// Token: 0x06022805 RID: 141317 RVA: 0x004C0B3B File Offset: 0x004BED3B
		public static void AddIconTrackingConfig(FlatBufferBuilder builder, Offset<IIconNearByTrackingConfig> iconTrackingConfigOffset)
		{
			builder.AddOffset(3, iconTrackingConfigOffset.Value, 0);
		}

		// Token: 0x06022806 RID: 141318 RVA: 0x004C0B4B File Offset: 0x004BED4B
		public static void AddVehicleTypes(FlatBufferBuilder builder, VectorOffset vehicleTypesOffset)
		{
			builder.AddOffset(4, vehicleTypesOffset.Value, 0);
		}

		// Token: 0x06022807 RID: 141319 RVA: 0x004C0B5C File Offset: 0x004BED5C
		public static VectorOffset CreateVehicleTypesVector(FlatBufferBuilder builder, EVehicleType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022808 RID: 141320 RVA: 0x004C0B93 File Offset: 0x004BED93
		public static VectorOffset CreateVehicleTypesVectorBlock(FlatBufferBuilder builder, EVehicleType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EVehicleType>(data);
			return builder.EndVector();
		}

		// Token: 0x06022809 RID: 141321 RVA: 0x004C0BAD File Offset: 0x004BEDAD
		public static VectorOffset CreateVehicleTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<EVehicleType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EVehicleType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602280A RID: 141322 RVA: 0x004C0BCB File Offset: 0x004BEDCB
		public static VectorOffset CreateVehicleTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EVehicleType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602280B RID: 141323 RVA: 0x004C0BE4 File Offset: 0x004BEDE4
		public static void StartVehicleTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602280C RID: 141324 RVA: 0x004C0BEF File Offset: 0x004BEDEF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602280D RID: 141325 RVA: 0x004C0BFA File Offset: 0x004BEDFA
		public static Offset<ICompassTracking> EndICompassTracking(FlatBufferBuilder builder)
		{
			return new Offset<ICompassTracking>(builder.EndTable());
		}

		// Token: 0x0602280E RID: 141326 RVA: 0x004C0C08 File Offset: 0x004BEE08
		public ICompassTrackingT UnPack()
		{
			ICompassTrackingT compassTrackingT = new ICompassTrackingT();
			this.UnPackTo(compassTrackingT);
			return compassTrackingT;
		}

		// Token: 0x0602280F RID: 141327 RVA: 0x004C0C24 File Offset: 0x004BEE24
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

		// Token: 0x06022810 RID: 141328 RVA: 0x004C0CC0 File Offset: 0x004BEEC0
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

		// Token: 0x0400EAB5 RID: 60085
		private Table __p;
	}
}
