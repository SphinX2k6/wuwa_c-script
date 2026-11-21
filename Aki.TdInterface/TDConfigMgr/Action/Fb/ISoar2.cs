using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB5 RID: 10933
	public class ISoar2 : ILeisureInteractType
	{
		// Token: 0x0600F10E RID: 61710 RVA: 0x00234AEC File Offset: 0x00232CEC
		public static ISoar2 Create(ISoar2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISoar2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004852 RID: 18514
		// (get) Token: 0x0600F10F RID: 61711 RVA: 0x00234B0B File Offset: 0x00232D0B
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008481 RID: 33921
		private ISoar2 Instance;
	}
}
