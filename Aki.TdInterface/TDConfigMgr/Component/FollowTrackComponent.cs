using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000190 RID: 400
	public class FollowTrackComponent : IComponentBase
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x00020664 File Offset: 0x0001E864
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

		// Token: 0x06000525 RID: 1317 RVA: 0x0002069C File Offset: 0x0001E89C
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

		// Token: 0x06000526 RID: 1318 RVA: 0x000206AF File Offset: 0x0001E8AF
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

		// Token: 0x06000527 RID: 1319 RVA: 0x000206C4 File Offset: 0x0001E8C4
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

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00020714 File Offset: 0x0001E914
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x0002074E File Offset: 0x0001E94E
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

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0002075C File Offset: 0x0001E95C
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00020786 File Offset: 0x0001E986
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00020794 File Offset: 0x0001E994
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x000207C3 File Offset: 0x0001E9C3
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

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x000207D1 File Offset: 0x0001E9D1
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x000207FC File Offset: 0x0001E9FC
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

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0002080A File Offset: 0x0001EA0A
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00020831 File Offset: 0x0001EA31
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

		// Token: 0x0400078C RID: 1932
		[Nullable(2)]
		protected new FollowTrackComponent FbInstance;

		// Token: 0x0400078D RID: 1933
		[Nullable(2)]
		protected new FollowTrackComponent_SetValue PocoInterface;
	}
}
