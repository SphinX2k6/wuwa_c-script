using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015EA RID: 5610
	public class AddFlowInteractOption : ActionParams
	{
		// Token: 0x06007E8F RID: 32399 RVA: 0x0012E188 File Offset: 0x0012C388
		private AddFlowInteractOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AddFlowInteractOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AddFlowInteractOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AddFlowInteractOption_SetValue());
			}
			return result;
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x0012E1C0 File Offset: 0x0012C3C0
		public static AddFlowInteractOption Create([Nullable(2)] AddFlowInteractOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddFlowInteractOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E91 RID: 32401 RVA: 0x0012E1D3 File Offset: 0x0012C3D3
		public static AddFlowInteractOption CreateFromSetValue([Nullable(2)] AddFlowInteractOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AddFlowInteractOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x0012E1E6 File Offset: 0x0012C3E6
		public AddFlowInteractOption_SetValue ToSetValue()
		{
			return new AddFlowInteractOption_SetValue
			{
				Option = this.Option,
				EntityId = this.EntityId,
				DelayRemoveByQuestEnd = this.DelayRemoveByQuestEnd,
				InteractToken = this.InteractToken
			};
		}

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x06007E93 RID: 32403 RVA: 0x0012E220 File Offset: 0x0012C420
		// (set) Token: 0x06007E94 RID: 32404 RVA: 0x0012E281 File Offset: 0x0012C481
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
					AddFlowInteractOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x06007E95 RID: 32405 RVA: 0x0012E296 File Offset: 0x0012C496
		// (set) Token: 0x06007E96 RID: 32406 RVA: 0x0012E2C1 File Offset: 0x0012C4C1
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

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x06007E97 RID: 32407 RVA: 0x0012E2D0 File Offset: 0x0012C4D0
		// (set) Token: 0x06007E98 RID: 32408 RVA: 0x0012E30A File Offset: 0x0012C50A
		public virtual bool? DelayRemoveByQuestEnd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayRemoveByQuestEnd;
				}
				AddFlowInteractOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayRemoveByQuestEnd;
			}
			set
			{
				this.GetOrCreatePoco().DelayRemoveByQuestEnd = value;
			}
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x06007E99 RID: 32409 RVA: 0x0012E318 File Offset: 0x0012C518
		// (set) Token: 0x06007E9A RID: 32410 RVA: 0x0012E33F File Offset: 0x0012C53F
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
				AddFlowInteractOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400493C RID: 18748
		[Nullable(2)]
		protected new AddFlowInteractOption FbInstance;

		// Token: 0x0400493D RID: 18749
		[Nullable(2)]
		protected AddFlowInteractOption_SetValue PocoInterface;

		// Token: 0x0400493E RID: 18750
		private IInteractOption _OptionCache;

		// Token: 0x0400493F RID: 18751
		private bool _OptionInited;
	}
}
