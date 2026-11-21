using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B56 RID: 11094
	public class IEnableRideFlyingCarUiGameplay : IToggleRideFlyingCarUiGameplayConfig
	{
		// Token: 0x0600F3DF RID: 62431 RVA: 0x00239227 File Offset: 0x00237427
		public static IEnableRideFlyingCarUiGameplay Create(IEnableRideFlyingCarUiGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableRideFlyingCarUiGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E1 RID: 18913
		// (get) Token: 0x0600F3E0 RID: 62432 RVA: 0x00239246 File Offset: 0x00237446
		public override EToggleRideFlyingCarUiGameplayType Type
		{
			get
			{
				return (EToggleRideFlyingCarUiGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049E2 RID: 18914
		// (get) Token: 0x0600F3E1 RID: 62433 RVA: 0x00239254 File Offset: 0x00237454
		public virtual int? FirstPersonCameraTag
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FirstPersonCameraTag);
			}
		}

		// Token: 0x170049E3 RID: 18915
		// (get) Token: 0x0600F3E2 RID: 62434 RVA: 0x0023928C File Offset: 0x0023748C
		public virtual int? ThirdPersonCameraTag
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ThirdPersonCameraTag);
			}
		}

		// Token: 0x040085C2 RID: 34242
		private IEnableRideFlyingCarUiGameplay Instance;
	}
}
