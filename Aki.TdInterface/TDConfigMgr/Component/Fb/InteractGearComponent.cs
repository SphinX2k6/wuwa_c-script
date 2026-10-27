using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD5 RID: 3029
	public class InteractGearComponent : IComponentBase
	{
		// Token: 0x060045A2 RID: 17826 RVA: 0x000B04F4 File Offset: 0x000AE6F4
		[NullableContext(1)]
		public static InteractGearComponent Create(IInteractGearComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InteractGearComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x000B0514 File Offset: 0x000AE714
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x000B054C File Offset: 0x000AE74C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x060045A5 RID: 17829 RVA: 0x000B0562 File Offset: 0x000AE762
		public virtual float NormalPrepareTime
		{
			get
			{
				return this.Instance.NormalPrepareTime;
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x060045A6 RID: 17830 RVA: 0x000B056F File Offset: 0x000AE76F
		public virtual float ActivePrepareTime
		{
			get
			{
				return this.Instance.ActivePrepareTime;
			}
		}

		// Token: 0x040027AE RID: 10158
		private IInteractGearComponent Instance;
	}
}
