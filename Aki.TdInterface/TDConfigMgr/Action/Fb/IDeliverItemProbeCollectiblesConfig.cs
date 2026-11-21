using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002929 RID: 10537
	public class IDeliverItemProbeCollectiblesConfig
	{
		// Token: 0x0600EA22 RID: 59938 RVA: 0x00228D19 File Offset: 0x00226F19
		public static IDeliverItemProbeCollectiblesConfig Create(IDeliverItemProbeCollectiblesConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeliverItemProbeCollectiblesConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700447E RID: 17534
		// (get) Token: 0x0600EA23 RID: 59939 RVA: 0x00228D38 File Offset: 0x00226F38
		public virtual IHandInItemViewStyle ViewStyle
		{
			get
			{
				if (this._ViewStyleInited)
				{
					return this._ViewStyleCache;
				}
				this._ViewStyleInited = true;
				this._ViewStyleCache = IHandInItemViewStyle.Create(this.Instance.ViewStyle);
				return this._ViewStyleCache;
			}
		}

		// Token: 0x1700447F RID: 17535
		// (get) Token: 0x0600EA24 RID: 59940 RVA: 0x00228D6C File Offset: 0x00226F6C
		public virtual int CollectiblesDetectionId
		{
			get
			{
				return this.Instance.CollectiblesDetectionId;
			}
		}

		// Token: 0x0400810B RID: 33035
		private IDeliverItemProbeCollectiblesConfig Instance;

		// Token: 0x0400810C RID: 33036
		[Nullable(2)]
		private IHandInItemViewStyle _ViewStyleCache;

		// Token: 0x0400810D RID: 33037
		private bool _ViewStyleInited;
	}
}
