using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001491 RID: 5265
	[NullableContext(1)]
	[Nullable(0)]
	public class AddFlowInteractOption : ActionParams
	{
		// Token: 0x060077C2 RID: 30658 RVA: 0x0011F53C File Offset: 0x0011D73C
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

		// Token: 0x060077C3 RID: 30659 RVA: 0x0011F574 File Offset: 0x0011D774
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

		// Token: 0x060077C4 RID: 30660 RVA: 0x0011F587 File Offset: 0x0011D787
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

		// Token: 0x060077C5 RID: 30661 RVA: 0x0011F59A File Offset: 0x0011D79A
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

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x060077C6 RID: 30662 RVA: 0x0011F5D4 File Offset: 0x0011D7D4
		// (set) Token: 0x060077C7 RID: 30663 RVA: 0x0011F635 File Offset: 0x0011D835
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

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x060077C8 RID: 30664 RVA: 0x0011F64A File Offset: 0x0011D84A
		// (set) Token: 0x060077C9 RID: 30665 RVA: 0x0011F675 File Offset: 0x0011D875
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

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x060077CA RID: 30666 RVA: 0x0011F684 File Offset: 0x0011D884
		// (set) Token: 0x060077CB RID: 30667 RVA: 0x0011F6BE File Offset: 0x0011D8BE
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

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x060077CC RID: 30668 RVA: 0x0011F6CC File Offset: 0x0011D8CC
		// (set) Token: 0x060077CD RID: 30669 RVA: 0x0011F6F3 File Offset: 0x0011D8F3
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

		// Token: 0x040045A1 RID: 17825
		[Nullable(2)]
		protected new AddFlowInteractOption FbInstance;

		// Token: 0x040045A2 RID: 17826
		[Nullable(2)]
		protected AddFlowInteractOption_SetValue PocoInterface;

		// Token: 0x040045A3 RID: 17827
		private IInteractOption _OptionCache;

		// Token: 0x040045A4 RID: 17828
		private bool _OptionInited;
	}
}
