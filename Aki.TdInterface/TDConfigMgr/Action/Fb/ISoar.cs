using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB4 RID: 10932
	public class ISoar : ILeisureInteractType
	{
		// Token: 0x0600F10B RID: 61707 RVA: 0x00234AB8 File Offset: 0x00232CB8
		public static ISoar Create(ISoar? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISoar
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004851 RID: 18513
		// (get) Token: 0x0600F10C RID: 61708 RVA: 0x00234AD7 File Offset: 0x00232CD7
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008480 RID: 33920
		private ISoar Instance;
	}
}
