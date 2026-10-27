using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200017B RID: 379
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowTrackComponent : IComponentBase
	{
		// Token: 0x06000520 RID: 1312 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
		private FollowTrackComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FollowTrackComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FollowTrackComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FollowTrackComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001FD28 File Offset: 0x0001DF28
		public static FollowTrackComponent Create([Nullable(2)] FollowTrackComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FollowTrackComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001FD3B File Offset: 0x0001DF3B
		public static FollowTrackComponent CreateFromSetValue([Nullable(2)] FollowTrackComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FollowTrackComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001FD50 File Offset: 0x0001DF50
		public new FollowTrackComponent_SetValue ToSetValue()
		{
			return new FollowTrackComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Range = this.Range,
				SplineEntityId = this.SplineEntityId,
				EndType = this.EndType
			};
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x0001FDDA File Offset: 0x0001DFDA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				FollowTrackComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x0001FE12 File Offset: 0x0001E012
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0001FE20 File Offset: 0x0001E020
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x0001FE4F File Offset: 0x0001E04F
		public virtual float Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0001FE5D File Offset: 0x0001E05D
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x0001FE88 File Offset: 0x0001E088
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0001FE96 File Offset: 0x0001E096
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x0001FEBD File Offset: 0x0001E0BD
		public virtual IFollowTrackEndType EndType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndType;
				}
				FollowTrackComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndType;
			}
			set
			{
				this.GetOrCreatePoco().EndType = value;
			}
		}

		// Token: 0x0400073F RID: 1855
		[Nullable(2)]
		protected new FollowTrackComponent FbInstance;

		// Token: 0x04000740 RID: 1856
		[Nullable(2)]
		protected new FollowTrackComponent_SetValue PocoInterface;
	}
}
