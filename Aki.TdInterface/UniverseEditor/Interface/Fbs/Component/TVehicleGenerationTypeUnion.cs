using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD3 RID: 23763
	public class TVehicleGenerationTypeUnion
	{
		// Token: 0x1700B26A RID: 45674
		// (get) Token: 0x06028AA7 RID: 166567 RVA: 0x005962D2 File Offset: 0x005944D2
		// (set) Token: 0x06028AA8 RID: 166568 RVA: 0x005962DA File Offset: 0x005944DA
		public TVehicleGenerationType Type { get; set; }

		// Token: 0x1700B26B RID: 45675
		// (get) Token: 0x06028AA9 RID: 166569 RVA: 0x005962E3 File Offset: 0x005944E3
		// (set) Token: 0x06028AAA RID: 166570 RVA: 0x005962EB File Offset: 0x005944EB
		public object Value { get; set; }

		// Token: 0x06028AAB RID: 166571 RVA: 0x005962F4 File Offset: 0x005944F4
		public TVehicleGenerationTypeUnion()
		{
			this.Type = TVehicleGenerationType.NONE;
			this.Value = null;
		}

		// Token: 0x06028AAC RID: 166572 RVA: 0x0059630A File Offset: 0x0059450A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028AAD RID: 166573 RVA: 0x0059631C File Offset: 0x0059451C
		public IVehicleGenerateByVehicleEntityTemplateT AsIVehicleGenerateByVehicleEntityTemplate()
		{
			return this.As<IVehicleGenerateByVehicleEntityTemplateT>();
		}

		// Token: 0x06028AAE RID: 166574 RVA: 0x00596324 File Offset: 0x00594524
		public static TVehicleGenerationTypeUnion FromIVehicleGenerateByVehicleEntityTemplate(IVehicleGenerateByVehicleEntityTemplateT _ivehiclegeneratebyvehicleentitytemplate)
		{
			return new TVehicleGenerationTypeUnion
			{
				Type = TVehicleGenerationType.IVehicleGenerateByVehicleEntityTemplate,
				Value = _ivehiclegeneratebyvehicleentitytemplate
			};
		}

		// Token: 0x06028AAF RID: 166575 RVA: 0x00596339 File Offset: 0x00594539
		public IVehicleGenerateByVehicleTeamTemplateT AsIVehicleGenerateByVehicleTeamTemplate()
		{
			return this.As<IVehicleGenerateByVehicleTeamTemplateT>();
		}

		// Token: 0x06028AB0 RID: 166576 RVA: 0x00596341 File Offset: 0x00594541
		public static TVehicleGenerationTypeUnion FromIVehicleGenerateByVehicleTeamTemplate(IVehicleGenerateByVehicleTeamTemplateT _ivehiclegeneratebyvehicleteamtemplate)
		{
			return new TVehicleGenerationTypeUnion
			{
				Type = TVehicleGenerationType.IVehicleGenerateByVehicleTeamTemplate,
				Value = _ivehiclegeneratebyvehicleteamtemplate
			};
		}

		// Token: 0x06028AB1 RID: 166577 RVA: 0x00596358 File Offset: 0x00594558
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
