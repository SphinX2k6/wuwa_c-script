using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002953 RID: 10579
	public class ITeleportTransitionWithEffect : ITeleportTransitionType
	{
		// Token: 0x0600EAE0 RID: 60128 RVA: 0x0022A2A2 File Offset: 0x002284A2
		public static ITeleportTransitionWithEffect Create(ITeleportTransitionWithEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044E8 RID: 17640
		// (get) Token: 0x0600EAE1 RID: 60129 RVA: 0x0022A2C1 File Offset: 0x002284C1
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170044E9 RID: 17641
		// (get) Token: 0x0600EAE2 RID: 60130 RVA: 0x0022A2CE File Offset: 0x002284CE
		public virtual string EffectDaPath
		{
			get
			{
				return this.Instance.EffectDaPath;
			}
		}

		// Token: 0x04008165 RID: 33125
		private ITeleportTransitionWithEffect Instance;
	}
}
