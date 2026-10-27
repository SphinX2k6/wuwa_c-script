using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EB8 RID: 3768
	[NullableContext(1)]
	[Nullable(0)]
	public class IAddInteractOption
	{
		// Token: 0x06005312 RID: 21266 RVA: 0x000CC8F4 File Offset: 0x000CAAF4
		private IAddInteractOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAddInteractOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAddInteractOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAddInteractOption_SetValue());
			}
			return result;
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x000CC92C File Offset: 0x000CAB2C
		public static IAddInteractOption Create([Nullable(2)] IAddInteractOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddInteractOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x000CC93F File Offset: 0x000CAB3F
		public static IAddInteractOption CreateFromSetValue([Nullable(2)] IAddInteractOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAddInteractOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x000CC954 File Offset: 0x000CAB54
		public IAddInteractOption_SetValue ToSetValue()
		{
			return new IAddInteractOption_SetValue
			{
				Option = this.Option,
				EntityId = this.EntityId,
				IsManualFinish = this.IsManualFinish,
				IsManualDelete = this.IsManualDelete,
				InteractToken = this.InteractToken
			};
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06005316 RID: 21270 RVA: 0x000CC9A4 File Offset: 0x000CABA4
		// (set) Token: 0x06005317 RID: 21271 RVA: 0x000CCA05 File Offset: 0x000CAC05
		public virtual IInteractOption Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				if (this.FbInstance != null)
				{
					this._OptionCache = IInteractOption.Create(this.FbInstance.Option);
				}
				else
				{
					IAddInteractOption_SetValue pocoInterface = this.PocoInterface;
					this._OptionCache = ((pocoInterface != null) ? pocoInterface.Option : null);
				}
				return this._OptionCache;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
				this._OptionInited = false;
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06005318 RID: 21272 RVA: 0x000CCA1A File Offset: 0x000CAC1A
		// (set) Token: 0x06005319 RID: 21273 RVA: 0x000CCA45 File Offset: 0x000CAC45
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x0600531A RID: 21274 RVA: 0x000CCA54 File Offset: 0x000CAC54
		// (set) Token: 0x0600531B RID: 21275 RVA: 0x000CCA8E File Offset: 0x000CAC8E
		public virtual bool? IsManualFinish
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsManualFinish;
				}
				IAddInteractOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsManualFinish;
			}
			set
			{
				this.GetOrCreatePoco().IsManualFinish = value;
			}
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x0600531C RID: 21276 RVA: 0x000CCA9C File Offset: 0x000CAC9C
		// (set) Token: 0x0600531D RID: 21277 RVA: 0x000CCAD6 File Offset: 0x000CACD6
		public virtual bool? IsManualDelete
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsManualDelete;
				}
				IAddInteractOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsManualDelete;
			}
			set
			{
				this.GetOrCreatePoco().IsManualDelete = value;
			}
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x0600531E RID: 21278 RVA: 0x000CCAE4 File Offset: 0x000CACE4
		// (set) Token: 0x0600531F RID: 21279 RVA: 0x000CCB0B File Offset: 0x000CAD0B
		[Nullable(2)]
		public virtual string InteractToken
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InteractToken;
				}
				IAddInteractOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InteractToken;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().InteractToken = value;
			}
		}

		// Token: 0x0400325C RID: 12892
		[Nullable(2)]
		protected IAddInteractOption FbInstance;

		// Token: 0x0400325D RID: 12893
		[Nullable(2)]
		protected IAddInteractOption_SetValue PocoInterface;

		// Token: 0x0400325E RID: 12894
		private IInteractOption _OptionCache;

		// Token: 0x0400325F RID: 12895
		private bool _OptionInited;
	}
}
