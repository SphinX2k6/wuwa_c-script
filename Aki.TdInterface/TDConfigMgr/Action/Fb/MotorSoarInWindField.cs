using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB0 RID: 10928
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorSoarInWindField : ActionParams
	{
		// Token: 0x0600EFE8 RID: 61416 RVA: 0x0022DBF2 File Offset: 0x0022BDF2
		public static MotorSoarInWindField Create(IMotorSoarInWindField? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MotorSoarInWindField
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C4A RID: 19530
		// (get) Token: 0x0600EFE9 RID: 61417 RVA: 0x0022DC11 File Offset: 0x0022BE11
		public virtual IMotorSoarInWindFieldControlType ControlType
		{
			get
			{
				if (this._ControlTypeInited)
				{
					return this._ControlTypeCache;
				}
				this._ControlTypeInited = true;
				this._ControlTypeCache = ActionReadHelper.ReadMotorSoarInWindField_ControlType(this.Instance);
				return this._ControlTypeCache;
			}
		}

		// Token: 0x040083FA RID: 33786
		private IMotorSoarInWindField Instance;

		// Token: 0x040083FB RID: 33787
		private IMotorSoarInWindFieldControlType _ControlTypeCache;

		// Token: 0x040083FC RID: 33788
		private bool _ControlTypeInited;
	}
}
