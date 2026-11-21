using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B4D RID: 2893
	public class IInteractScreenDetectShapeBase
	{
		// Token: 0x0600420F RID: 16911 RVA: 0x000A7E6E File Offset: 0x000A606E
		public static IInteractScreenDetectShapeBase Create(IInteractScreenDetectShapeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractScreenDetectShapeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06004210 RID: 16912 RVA: 0x000A7E8D File Offset: 0x000A608D
		public virtual EInteractScreenDetectShape Type
		{
			get
			{
				return (EInteractScreenDetectShape)this.Instance.Type;
			}
		}

		// Token: 0x0400248E RID: 9358
		private IInteractScreenDetectShapeBase Instance;
	}
}
