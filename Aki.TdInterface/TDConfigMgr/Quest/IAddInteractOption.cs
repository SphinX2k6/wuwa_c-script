using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FCE RID: 4046
	public class IAddInteractOption
	{
		// Token: 0x0600588E RID: 22670 RVA: 0x000D8A9C File Offset: 0x000D6C9C
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

		// Token: 0x0600588F RID: 22671 RVA: 0x000D8AD4 File Offset: 0x000D6CD4
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

		// Token: 0x06005890 RID: 22672 RVA: 0x000D8AE7 File Offset: 0x000D6CE7
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

		// Token: 0x06005891 RID: 22673 RVA: 0x000D8AFC File Offset: 0x000D6CFC
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

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06005892 RID: 22674 RVA: 0x000D8B4C File Offset: 0x000D6D4C
		// (set) Token: 0x06005893 RID: 22675 RVA: 0x000D8BAD File Offset: 0x000D6DAD
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

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06005894 RID: 22676 RVA: 0x000D8BC2 File Offset: 0x000D6DC2
		// (set) Token: 0x06005895 RID: 22677 RVA: 0x000D8BED File Offset: 0x000D6DED
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

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06005896 RID: 22678 RVA: 0x000D8BFC File Offset: 0x000D6DFC
		// (set) Token: 0x06005897 RID: 22679 RVA: 0x000D8C36 File Offset: 0x000D6E36
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

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x06005898 RID: 22680 RVA: 0x000D8C44 File Offset: 0x000D6E44
		// (set) Token: 0x06005899 RID: 22681 RVA: 0x000D8C7E File Offset: 0x000D6E7E
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

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x0600589A RID: 22682 RVA: 0x000D8C8C File Offset: 0x000D6E8C
		// (set) Token: 0x0600589B RID: 22683 RVA: 0x000D8CB3 File Offset: 0x000D6EB3
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

		// Token: 0x04003569 RID: 13673
		[Nullable(2)]
		protected IAddInteractOption FbInstance;

		// Token: 0x0400356A RID: 13674
		[Nullable(2)]
		protected IAddInteractOption_SetValue PocoInterface;

		// Token: 0x0400356B RID: 13675
		private IInteractOption _OptionCache;

		// Token: 0x0400356C RID: 13676
		private bool _OptionInited;
	}
}
