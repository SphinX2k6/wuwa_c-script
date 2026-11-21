using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B96 RID: 11158
	[NullableContext(2)]
	[Nullable(0)]
	public class RestorePlayerCameraAdjustment : ActionParams
	{
		// Token: 0x0600F600 RID: 62976 RVA: 0x0023D919 File Offset: 0x0023BB19
		[NullableContext(0)]
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

		// Token: 0x17004B82 RID: 19330
		// (get) Token: 0x0600F601 RID: 62977 RVA: 0x0023D938 File Offset: 0x0023BB38
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

		// Token: 0x17004B83 RID: 19331
		// (get) Token: 0x0600F602 RID: 62978 RVA: 0x0023D96C File Offset: 0x0023BB6C
		public virtual string SubScreenKey
		{
			get
			{
				return this.Instance.SubScreenKey;
			}
		}

		// Token: 0x040086E6 RID: 34534
		private IRestorePlayerCameraAdjustment Instance;

		// Token: 0x040086E7 RID: 34535
		private IResetFocusConfig _ResetFocusCache;

		// Token: 0x040086E8 RID: 34536
		private bool _ResetFocusInited;
	}
}
