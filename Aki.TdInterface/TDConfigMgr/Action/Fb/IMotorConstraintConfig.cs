using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA1 RID: 10913
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorConstraintConfig
	{
		// Token: 0x0600EFA9 RID: 61353 RVA: 0x0022D512 File Offset: 0x0022B712
		[NullableContext(1)]
		public static IMotorConstraintConfig Create(IMotorConstraintConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorConstraintConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C29 RID: 19497
		// (get) Token: 0x0600EFAA RID: 61354 RVA: 0x0022D534 File Offset: 0x0022B734
		public virtual List<EPlayerInputConstraintType> DisableInput
		{
			get
			{
				if (this._DisableInputInited)
				{
					return this._DisableInputCache;
				}
				this._DisableInputInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int disableInputLength = this.Instance.DisableInputLength;
				this._DisableInputCache = new List<EPlayerInputConstraintType>(disableInputLength);
				for (int i = 0; i < disableInputLength; i++)
				{
					this._DisableInputCache.Add((EPlayerInputConstraintType)this.Instance.DisableInput(i));
				}
				return this._DisableInputCache;
			}
		}

		// Token: 0x040083D1 RID: 33745
		private IMotorConstraintConfig Instance;

		// Token: 0x040083D2 RID: 33746
		private List<EPlayerInputConstraintType> _DisableInputCache;

		// Token: 0x040083D3 RID: 33747
		private bool _DisableInputInited;
	}
}
