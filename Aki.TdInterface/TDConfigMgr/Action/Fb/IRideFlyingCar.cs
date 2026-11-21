using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B39 RID: 11065
	public class IRideFlyingCar : IUiGame
	{
		// Token: 0x0600F35C RID: 62300 RVA: 0x002384AF File Offset: 0x002366AF
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

		// Token: 0x17004998 RID: 18840
		// (get) Token: 0x0600F35D RID: 62301 RVA: 0x002384CE File Offset: 0x002366CE
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004999 RID: 18841
		// (get) Token: 0x0600F35E RID: 62302 RVA: 0x002384DC File Offset: 0x002366DC
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

		// Token: 0x1700499A RID: 18842
		// (get) Token: 0x0600F35F RID: 62303 RVA: 0x00238514 File Offset: 0x00236714
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

		// Token: 0x04008585 RID: 34181
		private IRideFlyingCar Instance;
	}
}
