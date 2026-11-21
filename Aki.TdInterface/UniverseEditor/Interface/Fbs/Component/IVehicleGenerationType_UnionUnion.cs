using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006137 RID: 24887
	public class IVehicleGenerationType_UnionUnion
	{
		// Token: 0x1700B960 RID: 47456
		// (get) Token: 0x0602A3A8 RID: 172968 RVA: 0x005C3628 File Offset: 0x005C1828
		// (set) Token: 0x0602A3A9 RID: 172969 RVA: 0x005C3630 File Offset: 0x005C1830
		public IVehicleGenerationType_Union Type { get; set; }

		// Token: 0x1700B961 RID: 47457
		// (get) Token: 0x0602A3AA RID: 172970 RVA: 0x005C3639 File Offset: 0x005C1839
		// (set) Token: 0x0602A3AB RID: 172971 RVA: 0x005C3641 File Offset: 0x005C1841
		public object Value { get; set; }

		// Token: 0x0602A3AC RID: 172972 RVA: 0x005C364A File Offset: 0x005C184A
		public IVehicleGenerationType_UnionUnion()
		{
			this.Type = IVehicleGenerationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A3AD RID: 172973 RVA: 0x005C3660 File Offset: 0x005C1860
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A3AE RID: 172974 RVA: 0x005C3672 File Offset: 0x005C1872
		public IVehicleGenerationTypeT AsIVehicleGenerationType()
		{
			return this.As<IVehicleGenerationTypeT>();
		}

		// Token: 0x0602A3AF RID: 172975 RVA: 0x005C367A File Offset: 0x005C187A
		public static IVehicleGenerationType_UnionUnion FromIVehicleGenerationType(IVehicleGenerationTypeT _ivehiclegenerationtype)
		{
			return new IVehicleGenerationType_UnionUnion
			{
				Type = IVehicleGenerationType_Union.IVehicleGenerationType,
				Value = _ivehiclegenerationtype
			};
		}

		// Token: 0x0602A3B0 RID: 172976 RVA: 0x005C368F File Offset: 0x005C188F
		public IVehicleGenerateByVehicleEntityTemplateT AsIVehicleGenerateByVehicleEntityTemplate()
		{
			return this.As<IVehicleGenerateByVehicleEntityTemplateT>();
		}

		// Token: 0x0602A3B1 RID: 172977 RVA: 0x005C3697 File Offset: 0x005C1897
		public static IVehicleGenerationType_UnionUnion FromIVehicleGenerateByVehicleEntityTemplate(IVehicleGenerateByVehicleEntityTemplateT _ivehiclegeneratebyvehicleentitytemplate)
		{
			return new IVehicleGenerationType_UnionUnion
			{
				Type = IVehicleGenerationType_Union.IVehicleGenerateByVehicleEntityTemplate,
				Value = _ivehiclegeneratebyvehicleentitytemplate
			};
		}

		// Token: 0x0602A3B2 RID: 172978 RVA: 0x005C36AC File Offset: 0x005C18AC
		public IVehicleGenerateByVehicleTeamTemplateT AsIVehicleGenerateByVehicleTeamTemplate()
		{
			return this.As<IVehicleGenerateByVehicleTeamTemplateT>();
		}

		// Token: 0x0602A3B3 RID: 172979 RVA: 0x005C36B4 File Offset: 0x005C18B4
		public static IVehicleGenerationType_UnionUnion FromIVehicleGenerateByVehicleTeamTemplate(IVehicleGenerateByVehicleTeamTemplateT _ivehiclegeneratebyvehicleteamtemplate)
		{
			return new IVehicleGenerationType_UnionUnion
			{
				Type = IVehicleGenerationType_Union.IVehicleGenerateByVehicleTeamTemplate,
				Value = _ivehiclegeneratebyvehicleteamtemplate
			};
		}

		// Token: 0x0602A3B4 RID: 172980 RVA: 0x005C36CC File Offset: 0x005C18CC
		public static int Pack(FlatBufferBuilder builder, IVehicleGenerationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVehicleGenerationType_Union.IVehicleGenerationType:
				return IVehicleGenerationType.Pack(builder, _o.AsIVehicleGenerationType()).Value;
			case IVehicleGenerationType_Union.IVehicleGenerateByVehicleEntityTemplate:
				return IVehicleGenerateByVehicleEntityTemplate.Pack(builder, _o.AsIVehicleGenerateByVehicleEntityTemplate()).Value;
			case IVehicleGenerationType_Union.IVehicleGenerateByVehicleTeamTemplate:
				return IVehicleGenerateByVehicleTeamTemplate.Pack(builder, _o.AsIVehicleGenerateByVehicleTeamTemplate()).Value;
			default:
				return 0;
			}
		}
	}
}
