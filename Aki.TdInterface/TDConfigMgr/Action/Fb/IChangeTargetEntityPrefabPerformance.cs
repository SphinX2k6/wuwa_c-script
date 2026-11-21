using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C3B RID: 11323
	public class IChangeTargetEntityPrefabPerformance : ChangeEntityPrefabPerformance
	{
		// Token: 0x0600F91F RID: 63775 RVA: 0x0024338D File Offset: 0x0024158D
		public static IChangeTargetEntityPrefabPerformance Create(IChangeTargetEntityPrefabPerformance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeTargetEntityPrefabPerformance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D57 RID: 19799
		// (get) Token: 0x0600F920 RID: 63776 RVA: 0x002433AC File Offset: 0x002415AC
		public override EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004D58 RID: 19800
		// (get) Token: 0x0600F921 RID: 63777 RVA: 0x002433B9 File Offset: 0x002415B9
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004D59 RID: 19801
		// (get) Token: 0x0600F922 RID: 63778 RVA: 0x002433C6 File Offset: 0x002415C6
		public virtual string PerformanceTag
		{
			get
			{
				return this.Instance.PerformanceTag;
			}
		}

		// Token: 0x04008833 RID: 34867
		private IChangeTargetEntityPrefabPerformance Instance;
	}
}
