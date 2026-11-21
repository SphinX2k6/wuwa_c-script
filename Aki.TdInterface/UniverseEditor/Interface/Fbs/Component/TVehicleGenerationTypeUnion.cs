using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006307 RID: 25351
	public class TVehicleGenerationTypeUnion
	{
		// Token: 0x1700BBC6 RID: 48070
		// (get) Token: 0x0602B0FB RID: 176379 RVA: 0x005DEB42 File Offset: 0x005DCD42
		// (set) Token: 0x0602B0FC RID: 176380 RVA: 0x005DEB4A File Offset: 0x005DCD4A
		public TVehicleGenerationType Type { get; set; }

		// Token: 0x1700BBC7 RID: 48071
		// (get) Token: 0x0602B0FD RID: 176381 RVA: 0x005DEB53 File Offset: 0x005DCD53
		// (set) Token: 0x0602B0FE RID: 176382 RVA: 0x005DEB5B File Offset: 0x005DCD5B
		public object Value { get; set; }

		// Token: 0x0602B0FF RID: 176383 RVA: 0x005DEB64 File Offset: 0x005DCD64
		public TVehicleGenerationTypeUnion()
		{
			this.Type = TVehicleGenerationType.NONE;
			this.Value = null;
		}

		// Token: 0x0602B100 RID: 176384 RVA: 0x005DEB7A File Offset: 0x005DCD7A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B101 RID: 176385 RVA: 0x005DEB8C File Offset: 0x005DCD8C
		public IVehicleGenerateByVehicleEntityTemplateT AsIVehicleGenerateByVehicleEntityTemplate()
		{
			return this.As<IVehicleGenerateByVehicleEntityTemplateT>();
		}

		// Token: 0x0602B102 RID: 176386 RVA: 0x005DEB94 File Offset: 0x005DCD94
		public static TVehicleGenerationTypeUnion FromIVehicleGenerateByVehicleEntityTemplate(IVehicleGenerateByVehicleEntityTemplateT _ivehiclegeneratebyvehicleentitytemplate)
		{
			return new TVehicleGenerationTypeUnion
			{
				Type = TVehicleGenerationType.IVehicleGenerateByVehicleEntityTemplate,
				Value = _ivehiclegeneratebyvehicleentitytemplate
			};
		}

		// Token: 0x0602B103 RID: 176387 RVA: 0x005DEBA9 File Offset: 0x005DCDA9
		public IVehicleGenerateByVehicleTeamTemplateT AsIVehicleGenerateByVehicleTeamTemplate()
		{
			return this.As<IVehicleGenerateByVehicleTeamTemplateT>();
		}

		// Token: 0x0602B104 RID: 176388 RVA: 0x005DEBB1 File Offset: 0x005DCDB1
		public static TVehicleGenerationTypeUnion FromIVehicleGenerateByVehicleTeamTemplate(IVehicleGenerateByVehicleTeamTemplateT _ivehiclegeneratebyvehicleteamtemplate)
		{
			return new TVehicleGenerationTypeUnion
			{
				Type = TVehicleGenerationType.IVehicleGenerateByVehicleTeamTemplate,
				Value = _ivehiclegeneratebyvehicleteamtemplate
			};
		}

		// Token: 0x0602B105 RID: 176389 RVA: 0x005DEBC8 File Offset: 0x005DCDC8
		public static int Pack(FlatBufferBuilder builder, TVehicleGenerationTypeUnion _o)
		{
			TVehicleGenerationType type = _o.Type;
			if (type == TVehicleGenerationType.IVehicleGenerateByVehicleEntityTemplate)
			{
				return IVehicleGenerateByVehicleEntityTemplate.Pack(builder, _o.AsIVehicleGenerateByVehicleEntityTemplate()).Value;
			}
			if (type != TVehicleGenerationType.IVehicleGenerateByVehicleTeamTemplate)
			{
				return 0;
			}
			return IVehicleGenerateByVehicleTeamTemplate.Pack(builder, _o.AsIVehicleGenerateByVehicleTeamTemplate()).Value;
		}
	}
}
