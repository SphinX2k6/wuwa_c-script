using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001482 RID: 5250
	[NullableContext(2)]
	[Nullable(0)]
	public class ActionInfo
	{
		// Token: 0x06007775 RID: 30581 RVA: 0x0011EC68 File Offset: 0x0011CE68
		[NullableContext(1)]
		private ActionInfo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ActionInfo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ActionInfo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ActionInfo_SetValue());
			}
			return result;
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x0011ECA0 File Offset: 0x0011CEA0
		[NullableContext(1)]
		public static ActionInfo Create([Nullable(2)] ActionInfo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActionInfo
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x0011ECB3 File Offset: 0x0011CEB3
		[NullableContext(1)]
		public static ActionInfo CreateFromSetValue([Nullable(2)] ActionInfo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ActionInfo
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x0011ECC8 File Offset: 0x0011CEC8
		[NullableContext(1)]
		public ActionInfo_SetValue ToSetValue()
		{
			return new ActionInfo_SetValue
			{
				Name = this.Name,
				Async = this.Async,
				Params = this.Params,
				ActionId = this.ActionId,
				Disabled = this.Disabled,
				ActionGuid = this.ActionGuid,
				Timeout = this.Timeout,
				EdLocalDisabled = this.EdLocalDisabled,
				EdNote = this.EdNote
			};
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x06007779 RID: 30585 RVA: 0x0011ED46 File Offset: 0x0011CF46
		// (set) Token: 0x0600777A RID: 30586 RVA: 0x0011ED71 File Offset: 0x0011CF71
		public virtual EAction Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return EAction.Undefined;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x0600777B RID: 30587 RVA: 0x0011ED80 File Offset: 0x0011CF80
		// (set) Token: 0x0600777C RID: 30588 RVA: 0x0011EDBA File Offset: 0x0011CFBA
		public virtual bool? Async
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Async;
				}
				ActionInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Async;
			}
			set
			{
				this.GetOrCreatePoco().Async = value;
			}
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x0600777D RID: 30589 RVA: 0x0011EDC8 File Offset: 0x0011CFC8
		// (set) Token: 0x0600777E RID: 30590 RVA: 0x0011EDEF File Offset: 0x0011CFEF
		[Nullable(1)]
		public virtual ActionParams Params
		{
			[NullableContext(1)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Params;
				}
				ActionInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Params;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().Params = value;
			}
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x0600777F RID: 30591 RVA: 0x0011EE00 File Offset: 0x0011D000
		// (set) Token: 0x06007780 RID: 30592 RVA: 0x0011EE3A File Offset: 0x0011D03A
		public virtual int? ActionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActionId;
				}
				ActionInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ActionId;
			}
			set
			{
				this.GetOrCreatePoco().ActionId = value;
			}
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x06007781 RID: 30593 RVA: 0x0011EE48 File Offset: 0x0011D048
		// (set) Token: 0x06007782 RID: 30594 RVA: 0x0011EE82 File Offset: 0x0011D082
		public virtual bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ActionInfo_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x06007783 RID: 30595 RVA: 0x0011EE90 File Offset: 0x0011D090
		// (set) Token: 0x06007784 RID: 30596 RVA: 0x0011EEB7 File Offset: 0x0011D0B7
		public virtual string ActionGuid
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActionGuid;
				}
				ActionInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ActionGuid;
			}
			set
			{
				this.GetOrCreatePoco().ActionGuid = value;
			}
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x06007785 RID: 30597 RVA: 0x0011EEC8 File Offset: 0x0011D0C8
		// (set) Token: 0x06007786 RID: 30598 RVA: 0x0011EF02 File Offset: 0x0011D102
		public virtual float? Timeout
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Timeout;
				}
				ActionInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Timeout;
			}
			set
			{
				this.GetOrCreatePoco().Timeout = value;
			}
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x06007787 RID: 30599 RVA: 0x0011EF10 File Offset: 0x0011D110
		// (set) Token: 0x06007788 RID: 30600 RVA: 0x0011EF3A File Offset: 0x0011D13A
		public virtual bool? EdLocalDisabled
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdLocalDisabled;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdLocalDisabled = value;
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x06007789 RID: 30601 RVA: 0x0011EF48 File Offset: 0x0011D148
		// (set) Token: 0x0600778A RID: 30602 RVA: 0x0011EF5F File Offset: 0x0011D15F
		public virtual string EdNote
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdNote;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdNote = value;
			}
		}

		// Token: 0x04004581 RID: 17793
		protected ActionInfo FbInstance;

		// Token: 0x04004582 RID: 17794
		protected ActionInfo_SetValue PocoInterface;
	}
}
