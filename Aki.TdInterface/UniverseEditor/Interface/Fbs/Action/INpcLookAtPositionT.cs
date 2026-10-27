using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD1 RID: 27601
	public class INpcLookAtPositionT
	{
		// Token: 0x1700CD1E RID: 52510
		// (get) Token: 0x060307DA RID: 198618 RVA: 0x006958D7 File Offset: 0x00693AD7
		// (set) Token: 0x060307DB RID: 198619 RVA: 0x006958DF File Offset: 0x00693ADF
		public ECommonTargetType Type { get; set; }

		// Token: 0x1700CD1F RID: 52511
		// (get) Token: 0x060307DC RID: 198620 RVA: 0x006958E8 File Offset: 0x00693AE8
		// (set) Token: 0x060307DD RID: 198621 RVA: 0x006958F0 File Offset: 0x00693AF0
		public IVectorInfoT Position { get; set; }

		// Token: 0x060307DE RID: 198622 RVA: 0x006958F9 File Offset: 0x00693AF9
		public INpcLookAtPositionT()
		{
			this.Type = ECommonTargetType.Player;
			this.Position = null;
		}
	}
}
