using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D52 RID: 3410
	public class ITurntableControlType
	{
		// Token: 0x06004DAA RID: 19882 RVA: 0x000C1E59 File Offset: 0x000C0059
		public static ITurntableControlType Create(ITurntableControlType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITurntableControlType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06004DAB RID: 19883 RVA: 0x000C1E78 File Offset: 0x000C0078
		public virtual EControllerType Type
		{
			get
			{
				return (EControllerType)this.Instance.Type;
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06004DAC RID: 19884 RVA: 0x000C1E85 File Offset: 0x000C0085
		public virtual int RotationSpeed
		{
			get
			{
				return this.Instance.RotationSpeed;
			}
		}

		// Token: 0x04002C1B RID: 11291
		private ITurntableControlType Instance;
	}
}
