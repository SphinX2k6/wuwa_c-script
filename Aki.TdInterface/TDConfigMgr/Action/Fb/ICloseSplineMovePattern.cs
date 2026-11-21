using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BBC RID: 11196
	public class ICloseSplineMovePattern
	{
		// Token: 0x0600F6DA RID: 63194 RVA: 0x0023F472 File Offset: 0x0023D672
		public static ICloseSplineMovePattern Create(ICloseSplineMovePattern? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSplineMovePattern
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C10 RID: 19472
		// (get) Token: 0x0600F6DB RID: 63195 RVA: 0x0023F491 File Offset: 0x0023D691
		public virtual ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004C11 RID: 19473
		// (get) Token: 0x0600F6DC RID: 63196 RVA: 0x0023F4A0 File Offset: 0x0023D6A0
		public virtual float? GravitySwitchAngularVelocity
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.GravitySwitchAngularVelocity);
			}
		}

		// Token: 0x04008732 RID: 34610
		private ICloseSplineMovePattern Instance;
	}
}
