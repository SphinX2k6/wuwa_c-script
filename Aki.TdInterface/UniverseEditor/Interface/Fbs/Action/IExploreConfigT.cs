using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DBF RID: 28095
	public class IExploreConfigT
	{
		// Token: 0x1700CDF6 RID: 52726
		// (get) Token: 0x060307E3 RID: 198627 RVA: 0x00696216 File Offset: 0x00694416
		// (set) Token: 0x060307E4 RID: 198628 RVA: 0x0069621E File Offset: 0x0069441E
		public EExploreStateType Type { get; set; }

		// Token: 0x060307E5 RID: 198629 RVA: 0x00696227 File Offset: 0x00694427
		public IExploreConfigT()
		{
			this.Type = EExploreStateType.TeleControl;
		}
	}
}
