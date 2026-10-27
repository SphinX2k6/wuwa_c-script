using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A6E RID: 10862
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcLookAtConfig
	{
		// Token: 0x0600EEDB RID: 61147 RVA: 0x0022BFBE File Offset: 0x0022A1BE
		public static INpcLookAtConfig Create(INpcLookAtConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcLookAtConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BC1 RID: 19393
		// (get) Token: 0x0600EEDC RID: 61148 RVA: 0x0022BFDD File Offset: 0x0022A1DD
		public virtual INpcLookAtTypeBase Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadINpcLookAtConfig_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17004BC2 RID: 19394
		// (get) Token: 0x0600EEDD RID: 61149 RVA: 0x0022C00C File Offset: 0x0022A20C
		public virtual bool? IsKeepOverAngle
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsKeepOverAngle);
			}
		}

		// Token: 0x17004BC3 RID: 19395
		// (get) Token: 0x0600EEDE RID: 61150 RVA: 0x0022C042 File Offset: 0x0022A242
		public virtual float MaxDistance
		{
			get
			{
				return this.Instance.MaxDistance;
			}
		}

		// Token: 0x17004BC4 RID: 19396
		// (get) Token: 0x0600EEDF RID: 61151 RVA: 0x0022C04F File Offset: 0x0022A24F
		public virtual float MaxAngle
		{
			get
			{
				return this.Instance.MaxAngle;
			}
		}

		// Token: 0x04008366 RID: 33638
		private INpcLookAtConfig Instance;

		// Token: 0x04008367 RID: 33639
		private INpcLookAtTypeBase _TargetCache;

		// Token: 0x04008368 RID: 33640
		private bool _TargetInited;
	}
}
