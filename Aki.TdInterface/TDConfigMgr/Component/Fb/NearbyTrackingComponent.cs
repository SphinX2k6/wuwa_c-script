using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC4 RID: 3268
	public class NearbyTrackingComponent : IComponentBase
	{
		// Token: 0x06004AAE RID: 19118 RVA: 0x000BBB46 File Offset: 0x000B9D46
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

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06004AAF RID: 19119 RVA: 0x000BBB68 File Offset: 0x000B9D68
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

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06004AB0 RID: 19120 RVA: 0x000BBBA0 File Offset: 0x000B9DA0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06004AB1 RID: 19121 RVA: 0x000BBBB6 File Offset: 0x000B9DB6
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06004AB2 RID: 19122 RVA: 0x000BBBC4 File Offset: 0x000B9DC4
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

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06004AB3 RID: 19123 RVA: 0x000BBBFC File Offset: 0x000B9DFC
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

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06004AB4 RID: 19124 RVA: 0x000BBC32 File Offset: 0x000B9E32
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

		// Token: 0x04002A51 RID: 10833
		private INearbyTrackingComponent Instance;

		// Token: 0x04002A52 RID: 10834
		private INearbyTracking _TrackingTypeCache;

		// Token: 0x04002A53 RID: 10835
		private bool _TrackingTypeInited;
	}
}
