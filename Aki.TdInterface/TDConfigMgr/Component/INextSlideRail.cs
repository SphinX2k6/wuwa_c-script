using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000546 RID: 1350
	[NullableContext(1)]
	[Nullable(0)]
	public class INextSlideRail
	{
		// Token: 0x06001B98 RID: 7064 RVA: 0x0004FAB0 File Offset: 0x0004DCB0
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

		// Token: 0x06001B99 RID: 7065 RVA: 0x0004FAE8 File Offset: 0x0004DCE8
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

		// Token: 0x06001B9A RID: 7066 RVA: 0x0004FAFB File Offset: 0x0004DCFB
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

		// Token: 0x06001B9B RID: 7067 RVA: 0x0004FB0E File Offset: 0x0004DD0E
		public INextSlideRail_SetValue ToSetValue()
		{
			return new INextSlideRail_SetValue
			{
				TriggerKey = this.TriggerKey,
				TargetRailEntityId = this.TargetRailEntityId,
				IsFallbackRail = this.IsFallbackRail
			};
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x0004FB39 File Offset: 0x0004DD39
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0004FB64 File Offset: 0x0004DD64
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

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x0004FB72 File Offset: 0x0004DD72
		// (set) Token: 0x06001B9F RID: 7071 RVA: 0x0004FB9D File Offset: 0x0004DD9D
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

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0004FBAC File Offset: 0x0004DDAC
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x0004FBE6 File Offset: 0x0004DDE6
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

		// Token: 0x040013D8 RID: 5080
		[Nullable(2)]
		protected INextSlideRail FbInstance;

		// Token: 0x040013D9 RID: 5081
		[Nullable(2)]
		protected INextSlideRail_SetValue PocoInterface;
	}
}
