using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C3C RID: 11324
	public class IChangeSelfEntityPrefabPerformance : ChangeEntityPrefabPerformance
	{
		// Token: 0x0600F924 RID: 63780 RVA: 0x002433DB File Offset: 0x002415DB
		public static IChangeSelfEntityPrefabPerformance Create(IChangeSelfEntityPrefabPerformance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeSelfEntityPrefabPerformance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D5A RID: 19802
		// (get) Token: 0x0600F925 RID: 63781 RVA: 0x002433FA File Offset: 0x002415FA
		public override EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004D5B RID: 19803
		// (get) Token: 0x0600F926 RID: 63782 RVA: 0x00243407 File Offset: 0x00241607
		public virtual string PerformanceTag
		{
			get
			{
				return this.Instance.PerformanceTag;
			}
		}

		// Token: 0x04008834 RID: 34868
		private IChangeSelfEntityPrefabPerformance Instance;
	}
}
