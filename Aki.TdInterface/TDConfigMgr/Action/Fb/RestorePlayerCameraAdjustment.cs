using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C1 RID: 10433
	[NullableContext(2)]
	[Nullable(0)]
	public class RestorePlayerCameraAdjustment : ActionParams
	{
		// Token: 0x0600E7D1 RID: 59345 RVA: 0x00220999 File Offset: 0x0021EB99
		[NullableContext(1)]
		public static RestorePlayerCameraAdjustment Create(IRestorePlayerCameraAdjustment? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RestorePlayerCameraAdjustment
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004811 RID: 18449
		// (get) Token: 0x0600E7D2 RID: 59346 RVA: 0x002209B8 File Offset: 0x0021EBB8
		public virtual IResetFocusConfig ResetFocus
		{
			get
			{
				if (this._ResetFocusInited)
				{
					return this._ResetFocusCache;
				}
				this._ResetFocusInited = true;
				this._ResetFocusCache = IResetFocusConfig.Create(this.Instance.ResetFocus);
				return this._ResetFocusCache;
			}
		}

		// Token: 0x17004812 RID: 18450
		// (get) Token: 0x0600E7D3 RID: 59347 RVA: 0x002209EC File Offset: 0x0021EBEC
		public virtual string SubScreenKey
		{
			get
			{
				return this.Instance.SubScreenKey;
			}
		}

		// Token: 0x04008027 RID: 32807
		private IRestorePlayerCameraAdjustment Instance;

		// Token: 0x04008028 RID: 32808
		private IResetFocusConfig _ResetFocusCache;

		// Token: 0x04008029 RID: 32809
		private bool _ResetFocusInited;
	}
}
