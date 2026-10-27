using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002692 RID: 9874
	public class ITeleportTransitionWithFadeInScreen : ITeleportTransitionType
	{
		// Token: 0x0600DD11 RID: 56593 RVA: 0x0020DBAB File Offset: 0x0020BDAB
		[NullableContext(1)]
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

		// Token: 0x170041AF RID: 16815
		// (get) Token: 0x0600DD12 RID: 56594 RVA: 0x0020DBCA File Offset: 0x0020BDCA
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170041B0 RID: 16816
		// (get) Token: 0x0600DD13 RID: 56595 RVA: 0x0020DBD8 File Offset: 0x0020BDD8
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

		// Token: 0x04007ACC RID: 31436
		private ITeleportTransitionWithFadeInScreen Instance;
	}
}
