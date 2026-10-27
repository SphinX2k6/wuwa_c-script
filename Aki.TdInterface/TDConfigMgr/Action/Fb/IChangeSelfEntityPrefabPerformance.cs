using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002957 RID: 10583
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeSelfEntityPrefabPerformance : ChangeEntityPrefabPerformance
	{
		// Token: 0x0600EAAE RID: 60078 RVA: 0x00225D23 File Offset: 0x00223F23
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

		// Token: 0x170049C2 RID: 18882
		// (get) Token: 0x0600EAAF RID: 60079 RVA: 0x00225D42 File Offset: 0x00223F42
		public override EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x170049C3 RID: 18883
		// (get) Token: 0x0600EAB0 RID: 60080 RVA: 0x00225D4F File Offset: 0x00223F4F
		public virtual string PerformanceTag
		{
			get
			{
				return this.Instance.PerformanceTag;
			}
		}

		// Token: 0x04008153 RID: 33107
		private IChangeSelfEntityPrefabPerformance Instance;
	}
}
