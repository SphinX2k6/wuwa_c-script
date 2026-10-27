using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002956 RID: 10582
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeTargetEntityPrefabPerformance : ChangeEntityPrefabPerformance
	{
		// Token: 0x0600EAA9 RID: 60073 RVA: 0x00225CD5 File Offset: 0x00223ED5
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

		// Token: 0x170049BF RID: 18879
		// (get) Token: 0x0600EAAA RID: 60074 RVA: 0x00225CF4 File Offset: 0x00223EF4
		public override EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x170049C0 RID: 18880
		// (get) Token: 0x0600EAAB RID: 60075 RVA: 0x00225D01 File Offset: 0x00223F01
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170049C1 RID: 18881
		// (get) Token: 0x0600EAAC RID: 60076 RVA: 0x00225D0E File Offset: 0x00223F0E
		public virtual string PerformanceTag
		{
			get
			{
				return this.Instance.PerformanceTag;
			}
		}

		// Token: 0x04008152 RID: 33106
		private IChangeTargetEntityPrefabPerformance Instance;
	}
}
