using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D62 RID: 11618
	public class INpcLookAtConfig
	{
		// Token: 0x0600FD91 RID: 64913 RVA: 0x00249CCA File Offset: 0x00247ECA
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

		// Token: 0x17004F7B RID: 20347
		// (get) Token: 0x0600FD92 RID: 64914 RVA: 0x00249CE9 File Offset: 0x00247EE9
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

		// Token: 0x17004F7C RID: 20348
		// (get) Token: 0x0600FD93 RID: 64915 RVA: 0x00249D18 File Offset: 0x00247F18
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

		// Token: 0x17004F7D RID: 20349
		// (get) Token: 0x0600FD94 RID: 64916 RVA: 0x00249D4E File Offset: 0x00247F4E
		public virtual float MaxDistance
		{
			get
			{
				return this.Instance.MaxDistance;
			}
		}

		// Token: 0x17004F7E RID: 20350
		// (get) Token: 0x0600FD95 RID: 64917 RVA: 0x00249D5B File Offset: 0x00247F5B
		public virtual float MaxAngle
		{
			get
			{
				return this.Instance.MaxAngle;
			}
		}

		// Token: 0x04008A6A RID: 35434
		private INpcLookAtConfig Instance;

		// Token: 0x04008A6B RID: 35435
		private INpcLookAtTypeBase _TargetCache;

		// Token: 0x04008A6C RID: 35436
		private bool _TargetInited;
	}
}
