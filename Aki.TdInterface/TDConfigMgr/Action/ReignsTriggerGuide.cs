using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A3 RID: 9123
	public class ReignsTriggerGuide : ActionParams
	{
		// Token: 0x0600C700 RID: 50944 RVA: 0x001C7E80 File Offset: 0x001C6080
		private ReignsTriggerGuide_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReignsTriggerGuide 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReignsTriggerGuide_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReignsTriggerGuide_SetValue());
			}
			return result;
		}

		// Token: 0x0600C701 RID: 50945 RVA: 0x001C7EB8 File Offset: 0x001C60B8
		public static ReignsTriggerGuide Create([Nullable(2)] ReignsTriggerGuide instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsTriggerGuide
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C702 RID: 50946 RVA: 0x001C7ECB File Offset: 0x001C60CB
		public static ReignsTriggerGuide CreateFromSetValue([Nullable(2)] ReignsTriggerGuide_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReignsTriggerGuide
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C703 RID: 50947 RVA: 0x001C7EDE File Offset: 0x001C60DE
		public ReignsTriggerGuide_SetValue ToSetValue()
		{
			return new ReignsTriggerGuide_SetValue
			{
				GuideId = this.GuideId
			};
		}

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x0600C704 RID: 50948 RVA: 0x001C7EF1 File Offset: 0x001C60F1
		// (set) Token: 0x0600C705 RID: 50949 RVA: 0x001C7F1C File Offset: 0x001C611C
		public virtual int GuideId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GuideId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GuideId;
			}
			set
			{
				this.GetOrCreatePoco().GuideId = value;
			}
		}

		// Token: 0x0400764C RID: 30284
		[Nullable(2)]
		protected new ReignsTriggerGuide FbInstance;

		// Token: 0x0400764D RID: 30285
		[Nullable(2)]
		protected ReignsTriggerGuide_SetValue PocoInterface;
	}
}
