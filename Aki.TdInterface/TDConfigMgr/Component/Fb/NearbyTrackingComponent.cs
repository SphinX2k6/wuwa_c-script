using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF4 RID: 3060
	[NullableContext(1)]
	[Nullable(0)]
	public class NearbyTrackingComponent : IComponentBase
	{
		// Token: 0x0600464B RID: 17995 RVA: 0x000B197C File Offset: 0x000AFB7C
		public static NearbyTrackingComponent Create(INearbyTrackingComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NearbyTrackingComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600464C RID: 17996 RVA: 0x000B199C File Offset: 0x000AFB9C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x0600464D RID: 17997 RVA: 0x000B19D4 File Offset: 0x000AFBD4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x0600464E RID: 17998 RVA: 0x000B19EA File Offset: 0x000AFBEA
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x0600464F RID: 17999 RVA: 0x000B19F8 File Offset: 0x000AFBF8
		public virtual bool? IsEnableWhileUnlock
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsEnableWhileUnlock);
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06004650 RID: 18000 RVA: 0x000B1A30 File Offset: 0x000AFC30
		public virtual bool? IsEnbaleWhileHoming
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsEnbaleWhileHoming);
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06004651 RID: 18001 RVA: 0x000B1A66 File Offset: 0x000AFC66
		public virtual INearbyTracking TrackingType
		{
			get
			{
				if (this._TrackingTypeInited)
				{
					return this._TrackingTypeCache;
				}
				this._TrackingTypeInited = true;
				this._TrackingTypeCache = ComponentReadHelper.ReadNearbyTrackingComponent_TrackingType(this.Instance);
				return this._TrackingTypeCache;
			}
		}

		// Token: 0x04002805 RID: 10245
		private INearbyTrackingComponent Instance;

		// Token: 0x04002806 RID: 10246
		private INearbyTracking _TrackingTypeCache;

		// Token: 0x04002807 RID: 10247
		private bool _TrackingTypeInited;
	}
}
