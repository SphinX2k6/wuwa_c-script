using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028DB RID: 10459
	public class AddFlowInteractOption : ActionParams
	{
		// Token: 0x0600E8D4 RID: 59604 RVA: 0x002267BA File Offset: 0x002249BA
		public static AddFlowInteractOption Create(IAddFlowInteractOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddFlowInteractOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043CC RID: 17356
		// (get) Token: 0x0600E8D5 RID: 59605 RVA: 0x002267D9 File Offset: 0x002249D9
		public virtual IInteractOption Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = IInteractOption.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x170043CD RID: 17357
		// (get) Token: 0x0600E8D6 RID: 59606 RVA: 0x0022680D File Offset: 0x00224A0D
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170043CE RID: 17358
		// (get) Token: 0x0600E8D7 RID: 59607 RVA: 0x0022681C File Offset: 0x00224A1C
		public virtual bool? DelayRemoveByQuestEnd
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DelayRemoveByQuestEnd);
			}
		}

		// Token: 0x170043CF RID: 17359
		// (get) Token: 0x0600E8D8 RID: 59608 RVA: 0x00226852 File Offset: 0x00224A52
		[Nullable(2)]
		public virtual string InteractToken
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.InteractToken;
			}
		}

		// Token: 0x0400804D RID: 32845
		private IAddFlowInteractOption Instance;

		// Token: 0x0400804E RID: 32846
		[Nullable(2)]
		private IInteractOption _OptionCache;

		// Token: 0x0400804F RID: 32847
		private bool _OptionInited;
	}
}
