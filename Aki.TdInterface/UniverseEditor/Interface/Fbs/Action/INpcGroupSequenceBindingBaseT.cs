using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200730B RID: 29451
	public class INpcGroupSequenceBindingBaseT
	{
		// Token: 0x1700D7EA RID: 55274
		// (get) Token: 0x060335BF RID: 210367 RVA: 0x006ED072 File Offset: 0x006EB272
		// (set) Token: 0x060335C0 RID: 210368 RVA: 0x006ED07A File Offset: 0x006EB27A
		public ENpcGroupSequenceBindingType Type { get; set; }

		// Token: 0x060335C1 RID: 210369 RVA: 0x006ED083 File Offset: 0x006EB283
		public INpcGroupSequenceBindingBaseT()
		{
			this.Type = ENpcGroupSequenceBindingType.StaticEntity;
		}
	}
}
