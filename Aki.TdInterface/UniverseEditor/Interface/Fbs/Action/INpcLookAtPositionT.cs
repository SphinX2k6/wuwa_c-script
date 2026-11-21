using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007335 RID: 29493
	public class INpcLookAtPositionT
	{
		// Token: 0x1700D82A RID: 55338
		// (get) Token: 0x060336F6 RID: 210678 RVA: 0x006EF1D7 File Offset: 0x006ED3D7
		// (set) Token: 0x060336F7 RID: 210679 RVA: 0x006EF1DF File Offset: 0x006ED3DF
		public ECommonTargetType Type { get; set; }

		// Token: 0x1700D82B RID: 55339
		// (get) Token: 0x060336F8 RID: 210680 RVA: 0x006EF1E8 File Offset: 0x006ED3E8
		// (set) Token: 0x060336F9 RID: 210681 RVA: 0x006EF1F0 File Offset: 0x006ED3F0
		public IVectorInfoT Position { get; set; }

		// Token: 0x060336FA RID: 210682 RVA: 0x006EF1F9 File Offset: 0x006ED3F9
		public INpcLookAtPositionT()
		{
			this.Type = ECommonTargetType.Player;
			this.Position = null;
		}
	}
}
