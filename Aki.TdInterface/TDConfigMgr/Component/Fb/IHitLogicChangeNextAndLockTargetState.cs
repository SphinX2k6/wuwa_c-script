using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B88 RID: 2952
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicChangeNextAndLockTargetState : IHitLogicType
	{
		// Token: 0x060043E6 RID: 17382 RVA: 0x000ACBE2 File Offset: 0x000AADE2
		public static IHitLogicChangeNextAndLockTargetState Create(IHitLogicChangeNextAndLockTargetState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeNextAndLockTargetState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x000ACC01 File Offset: 0x000AAE01
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x060043E8 RID: 17384 RVA: 0x000ACC0E File Offset: 0x000AAE0E
		public virtual string TargetState
		{
			get
			{
				return this.Instance.TargetState;
			}
		}

		// Token: 0x04002647 RID: 9799
		private IHitLogicChangeNextAndLockTargetState Instance;
	}
}
