using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002866 RID: 10342
	public class IRideFlyingCar : IUiGame
	{
		// Token: 0x0600E537 RID: 58679 RVA: 0x0021B64B File Offset: 0x0021984B
		[NullableContext(1)]
		public static IRideFlyingCar Create(IRideFlyingCar? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRideFlyingCar
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700462D RID: 17965
		// (get) Token: 0x0600E538 RID: 58680 RVA: 0x0021B66A File Offset: 0x0021986A
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700462E RID: 17966
		// (get) Token: 0x0600E539 RID: 58681 RVA: 0x0021B678 File Offset: 0x00219878
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

		// Token: 0x1700462F RID: 17967
		// (get) Token: 0x0600E53A RID: 58682 RVA: 0x0021B6B0 File Offset: 0x002198B0
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

		// Token: 0x04007EC8 RID: 32456
		private IRideFlyingCar Instance;
	}
}
