using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065A7 RID: 26023
	public class IDestroySummonedEntitiesType_UnionUnion
	{
		// Token: 0x1700C13C RID: 49468
		// (get) Token: 0x0602D23D RID: 184893 RVA: 0x00630CDD File Offset: 0x0062EEDD
		// (set) Token: 0x0602D23E RID: 184894 RVA: 0x00630CE5 File Offset: 0x0062EEE5
		public IDestroySummonedEntitiesType_Union Type { get; set; }

		// Token: 0x1700C13D RID: 49469
		// (get) Token: 0x0602D23F RID: 184895 RVA: 0x00630CEE File Offset: 0x0062EEEE
		// (set) Token: 0x0602D240 RID: 184896 RVA: 0x00630CF6 File Offset: 0x0062EEF6
		public object Value { get; set; }

		// Token: 0x0602D241 RID: 184897 RVA: 0x00630CFF File Offset: 0x0062EEFF
		public IDestroySummonedEntitiesType_UnionUnion()
		{
			this.Type = IDestroySummonedEntitiesType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D242 RID: 184898 RVA: 0x00630D15 File Offset: 0x0062EF15
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D243 RID: 184899 RVA: 0x00630D27 File Offset: 0x0062EF27
		public IDestroySummonedEntitiesTypeT AsIDestroySummonedEntitiesType()
		{
			return this.As<IDestroySummonedEntitiesTypeT>();
		}

		// Token: 0x0602D244 RID: 184900 RVA: 0x00630D2F File Offset: 0x0062EF2F
		public static IDestroySummonedEntitiesType_UnionUnion FromIDestroySummonedEntitiesType(IDestroySummonedEntitiesTypeT _idestroysummonedentitiestype)
		{
			return new IDestroySummonedEntitiesType_UnionUnion
			{
				Type = IDestroySummonedEntitiesType_Union.IDestroySummonedEntitiesType,
				Value = _idestroysummonedentitiestype
			};
		}

		// Token: 0x0602D245 RID: 184901 RVA: 0x00630D44 File Offset: 0x0062EF44
		public IDestroySummonedVehicleT AsIDestroySummonedVehicle()
		{
			return this.As<IDestroySummonedVehicleT>();
		}

		// Token: 0x0602D246 RID: 184902 RVA: 0x00630D4C File Offset: 0x0062EF4C
		public static IDestroySummonedEntitiesType_UnionUnion FromIDestroySummonedVehicle(IDestroySummonedVehicleT _idestroysummonedvehicle)
		{
			return new IDestroySummonedEntitiesType_UnionUnion
			{
				Type = IDestroySummonedEntitiesType_Union.IDestroySummonedVehicle,
				Value = _idestroysummonedvehicle
			};
		}

		// Token: 0x0602D247 RID: 184903 RVA: 0x00630D64 File Offset: 0x0062EF64
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
