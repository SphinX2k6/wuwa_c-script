using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DC RID: 10716
	public class IBubbleCylinderConfig
	{
		// Token: 0x0600ED17 RID: 60695 RVA: 0x0022DC49 File Offset: 0x0022BE49
		public static IBubbleCylinderConfig Create(IBubbleCylinderConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleCylinderConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700460D RID: 17933
		// (get) Token: 0x0600ED18 RID: 60696 RVA: 0x0022DC68 File Offset: 0x0022BE68
		public virtual float Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x1700460E RID: 17934
		// (get) Token: 0x0600ED19 RID: 60697 RVA: 0x0022DC75 File Offset: 0x0022BE75
		public virtual float Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x0400827C RID: 33404
		private IBubbleCylinderConfig Instance;
	}
}
