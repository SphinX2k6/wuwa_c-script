using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005AD RID: 1453
	public class INextSlideRail
	{
		// Token: 0x06001D94 RID: 7572 RVA: 0x0005486C File Offset: 0x00052A6C
		private INextSlideRail_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INextSlideRail 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INextSlideRail_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INextSlideRail_SetValue());
			}
			return result;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x000548A4 File Offset: 0x00052AA4
		public static INextSlideRail Create([Nullable(2)] INextSlideRail instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INextSlideRail
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x000548B7 File Offset: 0x00052AB7
		public static INextSlideRail CreateFromSetValue([Nullable(2)] INextSlideRail_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INextSlideRail
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x000548CA File Offset: 0x00052ACA
		public INextSlideRail_SetValue ToSetValue()
		{
			return new INextSlideRail_SetValue
			{
				TriggerKey = this.TriggerKey,
				TargetRailEntityId = this.TargetRailEntityId,
				IsFallbackRail = this.IsFallbackRail
			};
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x000548F5 File Offset: 0x00052AF5
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x00054920 File Offset: 0x00052B20
		public virtual ETriggerKey TriggerKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerKey;
				}
				if (this.PocoInterface == null)
				{
					return ETriggerKey.Left;
				}
				return this.PocoInterface.TriggerKey;
			}
			set
			{
				this.GetOrCreatePoco().TriggerKey = value;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x0005492E File Offset: 0x00052B2E
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x00054959 File Offset: 0x00052B59
		public virtual int TargetRailEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetRailEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetRailEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TargetRailEntityId = value;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x00054968 File Offset: 0x00052B68
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x000549A2 File Offset: 0x00052BA2
		public virtual bool? IsFallbackRail
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFallbackRail;
				}
				INextSlideRail_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFallbackRail;
			}
			set
			{
				this.GetOrCreatePoco().IsFallbackRail = value;
			}
		}

		// Token: 0x04001542 RID: 5442
		[Nullable(2)]
		protected INextSlideRail FbInstance;

		// Token: 0x04001543 RID: 5443
		[Nullable(2)]
		protected INextSlideRail_SetValue PocoInterface;
	}
}
