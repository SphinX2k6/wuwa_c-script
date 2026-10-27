using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ABA RID: 10938
	[NullableContext(2)]
	[Nullable(0)]
	public class IDeadEyeEffectConfig
	{
		// Token: 0x0600F00C RID: 61452 RVA: 0x0022DEBD File Offset: 0x0022C0BD
		[NullableContext(1)]
		public static IDeadEyeEffectConfig Create(IDeadEyeEffectConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadEyeEffectConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C5A RID: 19546
		// (get) Token: 0x0600F00D RID: 61453 RVA: 0x0022DEDC File Offset: 0x0022C0DC
		[Nullable(1)]
		public virtual string FilterEffect
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.FilterEffect;
			}
		}

		// Token: 0x17004C5B RID: 19547
		// (get) Token: 0x0600F00E RID: 61454 RVA: 0x0022DEE9 File Offset: 0x0022C0E9
		public virtual string TargetIdleMaterialDa
		{
			get
			{
				return this.Instance.TargetIdleMaterialDa;
			}
		}

		// Token: 0x17004C5C RID: 19548
		// (get) Token: 0x0600F00F RID: 61455 RVA: 0x0022DEF6 File Offset: 0x0022C0F6
		public virtual string TargetLockedMaterialDa
		{
			get
			{
				return this.Instance.TargetLockedMaterialDa;
			}
		}

		// Token: 0x04008408 RID: 33800
		private IDeadEyeEffectConfig Instance;
	}
}
