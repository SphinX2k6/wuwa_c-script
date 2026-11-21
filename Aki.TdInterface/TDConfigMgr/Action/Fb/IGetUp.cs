using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB7 RID: 10935
	public class IGetUp : ILeisureInteractType
	{
		// Token: 0x0600F114 RID: 61716 RVA: 0x00234B54 File Offset: 0x00232D54
		public static IGetUp Create(IGetUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGetUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004854 RID: 18516
		// (get) Token: 0x0600F115 RID: 61717 RVA: 0x00234B73 File Offset: 0x00232D73
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008483 RID: 33923
		private IGetUp Instance;
	}
}
