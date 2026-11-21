using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C0F RID: 27663
	public class IDestroySummonedEntitiesType_UnionUnion
	{
		// Token: 0x1700CACB RID: 51915
		// (get) Token: 0x0602F9C1 RID: 195009 RVA: 0x0067CEA1 File Offset: 0x0067B0A1
		// (set) Token: 0x0602F9C2 RID: 195010 RVA: 0x0067CEA9 File Offset: 0x0067B0A9
		public IDestroySummonedEntitiesType_Union Type { get; set; }

		// Token: 0x1700CACC RID: 51916
		// (get) Token: 0x0602F9C3 RID: 195011 RVA: 0x0067CEB2 File Offset: 0x0067B0B2
		// (set) Token: 0x0602F9C4 RID: 195012 RVA: 0x0067CEBA File Offset: 0x0067B0BA
		public object Value { get; set; }

		// Token: 0x0602F9C5 RID: 195013 RVA: 0x0067CEC3 File Offset: 0x0067B0C3
		public IDestroySummonedEntitiesType_UnionUnion()
		{
			this.Type = IDestroySummonedEntitiesType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F9C6 RID: 195014 RVA: 0x0067CED9 File Offset: 0x0067B0D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F9C7 RID: 195015 RVA: 0x0067CEEB File Offset: 0x0067B0EB
		public IDestroySummonedEntitiesTypeT AsIDestroySummonedEntitiesType()
		{
			return this.As<IDestroySummonedEntitiesTypeT>();
		}

		// Token: 0x0602F9C8 RID: 195016 RVA: 0x0067CEF3 File Offset: 0x0067B0F3
		public static IDestroySummonedEntitiesType_UnionUnion FromIDestroySummonedEntitiesType(IDestroySummonedEntitiesTypeT _idestroysummonedentitiestype)
		{
			return new IDestroySummonedEntitiesType_UnionUnion
			{
				Type = IDestroySummonedEntitiesType_Union.IDestroySummonedEntitiesType,
				Value = _idestroysummonedentitiestype
			};
		}

		// Token: 0x0602F9C9 RID: 195017 RVA: 0x0067CF08 File Offset: 0x0067B108
		public IDestroySummonedVehicleT AsIDestroySummonedVehicle()
		{
			return this.As<IDestroySummonedVehicleT>();
		}

		// Token: 0x0602F9CA RID: 195018 RVA: 0x0067CF10 File Offset: 0x0067B110
		public static IDestroySummonedEntitiesType_UnionUnion FromIDestroySummonedVehicle(IDestroySummonedVehicleT _idestroysummonedvehicle)
		{
			return new IDestroySummonedEntitiesType_UnionUnion
			{
				Type = IDestroySummonedEntitiesType_Union.IDestroySummonedVehicle,
				Value = _idestroysummonedvehicle
			};
		}

		// Token: 0x0602F9CB RID: 195019 RVA: 0x0067CF28 File Offset: 0x0067B128
		public static int Pack(FlatBufferBuilder builder, IDestroySummonedEntitiesType_UnionUnion _o)
		{
			IDestroySummonedEntitiesType_Union type = _o.Type;
			if (type == IDestroySummonedEntitiesType_Union.IDestroySummonedEntitiesType)
			{
				return IDestroySummonedEntitiesType.Pack(builder, _o.AsIDestroySummonedEntitiesType()).Value;
			}
			if (type != IDestroySummonedEntitiesType_Union.IDestroySummonedVehicle)
			{
				return 0;
			}
			return IDestroySummonedVehicle.Pack(builder, _o.AsIDestroySummonedVehicle()).Value;
		}
	}
}
