using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002955 RID: 10581
	public class ITeleportTransitionWithFadeInScreen : ITeleportTransitionType
	{
		// Token: 0x0600EAE8 RID: 60136 RVA: 0x0022A34B File Offset: 0x0022854B
		public static ITeleportTransitionWithFadeInScreen Create(ITeleportTransitionWithFadeInScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithFadeInScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044EC RID: 17644
		// (get) Token: 0x0600EAE9 RID: 60137 RVA: 0x0022A36A File Offset: 0x0022856A
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170044ED RID: 17645
		// (get) Token: 0x0600EAEA RID: 60138 RVA: 0x0022A378 File Offset: 0x00228578
		public virtual EFadeInScreenShowType? ScreenType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EFadeInScreenShowType?((EFadeInScreenShowType)this.Instance.ScreenType);
			}
		}

		// Token: 0x04008169 RID: 33129
		private ITeleportTransitionWithFadeInScreen Instance;
	}
}
