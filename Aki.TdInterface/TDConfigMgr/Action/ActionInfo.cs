using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015DB RID: 5595
	public class ActionInfo
	{
		// Token: 0x06007E42 RID: 32322 RVA: 0x0012D8B4 File Offset: 0x0012BAB4
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

		// Token: 0x06007E43 RID: 32323 RVA: 0x0012D8EC File Offset: 0x0012BAEC
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

		// Token: 0x06007E44 RID: 32324 RVA: 0x0012D8FF File Offset: 0x0012BAFF
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

		// Token: 0x06007E45 RID: 32325 RVA: 0x0012D914 File Offset: 0x0012BB14
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

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x06007E46 RID: 32326 RVA: 0x0012D992 File Offset: 0x0012BB92
		// (set) Token: 0x06007E47 RID: 32327 RVA: 0x0012D9BD File Offset: 0x0012BBBD
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

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x06007E48 RID: 32328 RVA: 0x0012D9CC File Offset: 0x0012BBCC
		// (set) Token: 0x06007E49 RID: 32329 RVA: 0x0012DA06 File Offset: 0x0012BC06
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

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x06007E4A RID: 32330 RVA: 0x0012DA14 File Offset: 0x0012BC14
		// (set) Token: 0x06007E4B RID: 32331 RVA: 0x0012DA3B File Offset: 0x0012BC3B
		public virtual ActionParams Params
		{
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
			set
			{
				this.GetOrCreatePoco().Params = value;
			}
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x06007E4C RID: 32332 RVA: 0x0012DA4C File Offset: 0x0012BC4C
		// (set) Token: 0x06007E4D RID: 32333 RVA: 0x0012DA86 File Offset: 0x0012BC86
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

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x06007E4E RID: 32334 RVA: 0x0012DA94 File Offset: 0x0012BC94
		// (set) Token: 0x06007E4F RID: 32335 RVA: 0x0012DACE File Offset: 0x0012BCCE
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

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x06007E50 RID: 32336 RVA: 0x0012DADC File Offset: 0x0012BCDC
		// (set) Token: 0x06007E51 RID: 32337 RVA: 0x0012DB03 File Offset: 0x0012BD03
		[Nullable(2)]
		public virtual string ActionGuid
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ActionGuid = value;
			}
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x06007E52 RID: 32338 RVA: 0x0012DB14 File Offset: 0x0012BD14
		// (set) Token: 0x06007E53 RID: 32339 RVA: 0x0012DB4E File Offset: 0x0012BD4E
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

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x06007E54 RID: 32340 RVA: 0x0012DB5C File Offset: 0x0012BD5C
		// (set) Token: 0x06007E55 RID: 32341 RVA: 0x0012DB86 File Offset: 0x0012BD86
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

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x06007E56 RID: 32342 RVA: 0x0012DB94 File Offset: 0x0012BD94
		// (set) Token: 0x06007E57 RID: 32343 RVA: 0x0012DBAB File Offset: 0x0012BDAB
		[Nullable(2)]
		public virtual string EdNote
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdNote;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdNote = value;
			}
		}

		// Token: 0x0400491C RID: 18716
		[Nullable(2)]
		protected ActionInfo FbInstance;

		// Token: 0x0400491D RID: 18717
		[Nullable(2)]
		protected ActionInfo_SetValue PocoInterface;
	}
}
