using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B21 RID: 23329
	public class IVehicleGenerationType_UnionUnion
	{
		// Token: 0x1700B018 RID: 45080
		// (get) Token: 0x06027DE4 RID: 163300 RVA: 0x0057BBD4 File Offset: 0x00579DD4
		// (set) Token: 0x06027DE5 RID: 163301 RVA: 0x0057BBDC File Offset: 0x00579DDC
		public IVehicleGenerationType_Union Type { get; set; }

		// Token: 0x1700B019 RID: 45081
		// (get) Token: 0x06027DE6 RID: 163302 RVA: 0x0057BBE5 File Offset: 0x00579DE5
		// (set) Token: 0x06027DE7 RID: 163303 RVA: 0x0057BBED File Offset: 0x00579DED
		public object Value { get; set; }

		// Token: 0x06027DE8 RID: 163304 RVA: 0x0057BBF6 File Offset: 0x00579DF6
		public IVehicleGenerationType_UnionUnion()
		{
			this.Type = IVehicleGenerationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027DE9 RID: 163305 RVA: 0x0057BC0C File Offset: 0x00579E0C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027DEA RID: 163306 RVA: 0x0057BC1E File Offset: 0x00579E1E
		public IVehicleGenerationTypeT AsIVehicleGenerationType()
		{
			return this.As<IVehicleGenerationTypeT>();
		}

		// Token: 0x06027DEB RID: 163307 RVA: 0x0057BC26 File Offset: 0x00579E26
		public static IVehicleGenerationType_UnionUnion FromIVehicleGenerationType(IVehicleGenerationTypeT _ivehiclegenerationtype)
		{
			return new IVehicleGenerationType_UnionUnion
			{
				Type = IVehicleGenerationType_Union.IVehicleGenerationType,
				Value = _ivehiclegenerationtype
			};
		}

		// Token: 0x06027DEC RID: 163308 RVA: 0x0057BC3B File Offset: 0x00579E3B
		public IVehicleGenerateByVehicleEntityTemplateT AsIVehicleGenerateByVehicleEntityTemplate()
		{
			return this.As<IVehicleGenerateByVehicleEntityTemplateT>();
		}

		// Token: 0x06027DED RID: 163309 RVA: 0x0057BC43 File Offset: 0x00579E43
		public static IVehicleGenerationType_UnionUnion FromIVehicleGenerateByVehicleEntityTemplate(IVehicleGenerateByVehicleEntityTemplateT _ivehiclegeneratebyvehicleentitytemplate)
		{
			return new IVehicleGenerationType_UnionUnion
			{
				Type = IVehicleGenerationType_Union.IVehicleGenerateByVehicleEntityTemplate,
				Value = _ivehiclegeneratebyvehicleentitytemplate
			};
		}

		// Token: 0x06027DEE RID: 163310 RVA: 0x0057BC58 File Offset: 0x00579E58
		public IVehicleGenerateByVehicleTeamTemplateT AsIVehicleGenerateByVehicleTeamTemplate()
		{
			return this.As<IVehicleGenerateByVehicleTeamTemplateT>();
		}

		// Token: 0x06027DEF RID: 163311 RVA: 0x0057BC60 File Offset: 0x00579E60
		public static IVehicleGenerationType_UnionUnion FromIVehicleGenerateByVehicleTeamTemplate(IVehicleGenerateByVehicleTeamTemplateT _ivehiclegeneratebyvehicleteamtemplate)
		{
			return new IVehicleGenerationType_UnionUnion
			{
				Type = IVehicleGenerationType_Union.IVehicleGenerateByVehicleTeamTemplate,
				Value = _ivehiclegeneratebyvehicleteamtemplate
			};
		}

		// Token: 0x06027DF0 RID: 163312 RVA: 0x0057BC78 File Offset: 0x00579E78
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
