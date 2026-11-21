using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A74 RID: 10868
	public class ISubScreen : IScreenType
	{
		// Token: 0x0600EFE1 RID: 61409 RVA: 0x00232829 File Offset: 0x00230A29
		public static ISubScreen Create(ISubScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047A7 RID: 18343
		// (get) Token: 0x0600EFE2 RID: 61410 RVA: 0x00232848 File Offset: 0x00230A48
		public override EScreenType Type
		{
			get
			{
				return (EScreenType)this.Instance.Type;
			}
		}

		// Token: 0x170047A8 RID: 18344
		// (get) Token: 0x0600EFE3 RID: 61411 RVA: 0x00232855 File Offset: 0x00230A55
		public virtual string SubScreenKey
		{
			get
			{
				return this.Instance.SubScreenKey;
			}
		}

		// Token: 0x040083E4 RID: 33764
		private ISubScreen Instance;
	}
}
