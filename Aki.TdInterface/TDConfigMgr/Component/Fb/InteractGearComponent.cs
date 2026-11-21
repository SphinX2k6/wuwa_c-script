using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA4 RID: 3236
	public class InteractGearComponent : IComponentBase
	{
		// Token: 0x06004A00 RID: 18944 RVA: 0x000BA66E File Offset: 0x000B886E
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

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06004A01 RID: 18945 RVA: 0x000BA690 File Offset: 0x000B8890
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

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06004A02 RID: 18946 RVA: 0x000BA6C8 File Offset: 0x000B88C8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06004A03 RID: 18947 RVA: 0x000BA6DE File Offset: 0x000B88DE
		public virtual float NormalPrepareTime
		{
			get
			{
				return this.Instance.NormalPrepareTime;
			}
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06004A04 RID: 18948 RVA: 0x000BA6EB File Offset: 0x000B88EB
		public virtual float ActivePrepareTime
		{
			get
			{
				return this.Instance.ActivePrepareTime;
			}
		}

		// Token: 0x040029F9 RID: 10745
		private IInteractGearComponent Instance;
	}
}
