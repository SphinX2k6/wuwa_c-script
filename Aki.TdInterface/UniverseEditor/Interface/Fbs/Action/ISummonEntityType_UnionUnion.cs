using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007236 RID: 29238
	public class ISummonEntityType_UnionUnion
	{
		// Token: 0x1700D8F8 RID: 55544
		// (get) Token: 0x06033DB8 RID: 212408 RVA: 0x006FA345 File Offset: 0x006F8545
		// (set) Token: 0x06033DB9 RID: 212409 RVA: 0x006FA34D File Offset: 0x006F854D
		public ISummonEntityType_Union Type { get; set; }

		// Token: 0x1700D8F9 RID: 55545
		// (get) Token: 0x06033DBA RID: 212410 RVA: 0x006FA356 File Offset: 0x006F8556
		// (set) Token: 0x06033DBB RID: 212411 RVA: 0x006FA35E File Offset: 0x006F855E
		public object Value { get; set; }

		// Token: 0x06033DBC RID: 212412 RVA: 0x006FA367 File Offset: 0x006F8567
		public ISummonEntityType_UnionUnion()
		{
			this.Type = ISummonEntityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033DBD RID: 212413 RVA: 0x006FA37D File Offset: 0x006F857D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033DBE RID: 212414 RVA: 0x006FA38F File Offset: 0x006F858F
		public ISummonEntityTypeT AsISummonEntityType()
		{
			return this.As<ISummonEntityTypeT>();
		}

		// Token: 0x06033DBF RID: 212415 RVA: 0x006FA397 File Offset: 0x006F8597
		public static ISummonEntityType_UnionUnion FromISummonEntityType(ISummonEntityTypeT _isummonentitytype)
		{
			return new ISummonEntityType_UnionUnion
			{
				Type = ISummonEntityType_Union.ISummonEntityType,
				Value = _isummonentitytype
			};
		}

		// Token: 0x06033DC0 RID: 212416 RVA: 0x006FA3AC File Offset: 0x006F85AC
		public ISummonVehicleT AsISummonVehicle()
		{
			return this.As<ISummonVehicleT>();
		}

		// Token: 0x06033DC1 RID: 212417 RVA: 0x006FA3B4 File Offset: 0x006F85B4
		public static ISummonEntityType_UnionUnion FromISummonVehicle(ISummonVehicleT _isummonvehicle)
		{
			return new ISummonEntityType_UnionUnion
			{
				Type = ISummonEntityType_Union.ISummonVehicle,
				Value = _isummonvehicle
			};
		}

		// Token: 0x06033DC2 RID: 212418 RVA: 0x006FA3CC File Offset: 0x006F85CC
		public static int Pack(FlatBufferBuilder builder, ISummonEntityType_UnionUnion _o)
		{
			ISummonEntityType_Union type = _o.Type;
			if (type == ISummonEntityType_Union.ISummonEntityType)
			{
				return ISummonEntityType.Pack(builder, _o.AsISummonEntityType()).Value;
			}
			if (type != ISummonEntityType_Union.ISummonVehicle)
			{
				return 0;
			}
			return ISummonVehicle.Pack(builder, _o.AsISummonVehicle()).Value;
		}
	}
}
