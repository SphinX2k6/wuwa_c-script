using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B13 RID: 11027
	public class IDollGrabShowcase : IUiGame
	{
		// Token: 0x0600F296 RID: 62102 RVA: 0x00236E31 File Offset: 0x00235031
		public static IDollGrabShowcase Create(IDollGrabShowcase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabShowcase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700491E RID: 18718
		// (get) Token: 0x0600F297 RID: 62103 RVA: 0x00236E50 File Offset: 0x00235050
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700491F RID: 18719
		// (get) Token: 0x0600F298 RID: 62104 RVA: 0x00236E5D File Offset: 0x0023505D
		public virtual int ShowcaseEntityId
		{
			get
			{
				return this.Instance.ShowcaseEntityId;
			}
		}

		// Token: 0x04008523 RID: 34083
		private IDollGrabShowcase Instance;
	}
}
