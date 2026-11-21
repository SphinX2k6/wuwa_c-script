using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D95 RID: 11669
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorConstraintConfig
	{
		// Token: 0x0600FE5F RID: 65119 RVA: 0x0024B21E File Offset: 0x0024941E
		[NullableContext(0)]
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

		// Token: 0x17004FE3 RID: 20451
		// (get) Token: 0x0600FE60 RID: 65120 RVA: 0x0024B240 File Offset: 0x00249440
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

		// Token: 0x04008AD5 RID: 35541
		private IMotorConstraintConfig Instance;

		// Token: 0x04008AD6 RID: 35542
		private List<EPlayerInputConstraintType> _DisableInputCache;

		// Token: 0x04008AD7 RID: 35543
		private bool _DisableInputInited;
	}
}
