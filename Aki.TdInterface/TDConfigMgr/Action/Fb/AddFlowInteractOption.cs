using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200261B RID: 9755
	[NullableContext(1)]
	[Nullable(0)]
	public class AddFlowInteractOption : ActionParams
	{
		// Token: 0x0600DB06 RID: 56070 RVA: 0x00209FEE File Offset: 0x002081EE
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

		// Token: 0x17004092 RID: 16530
		// (get) Token: 0x0600DB07 RID: 56071 RVA: 0x0020A00D File Offset: 0x0020820D
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

		// Token: 0x17004093 RID: 16531
		// (get) Token: 0x0600DB08 RID: 56072 RVA: 0x0020A041 File Offset: 0x00208241
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004094 RID: 16532
		// (get) Token: 0x0600DB09 RID: 56073 RVA: 0x0020A050 File Offset: 0x00208250
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

		// Token: 0x17004095 RID: 16533
		// (get) Token: 0x0600DB0A RID: 56074 RVA: 0x0020A086 File Offset: 0x00208286
		[Nullable(2)]
		public virtual string InteractToken
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.InteractToken;
			}
		}

		// Token: 0x040079B1 RID: 31153
		private IAddFlowInteractOption Instance;

		// Token: 0x040079B2 RID: 31154
		[Nullable(2)]
		private IInteractOption _OptionCache;

		// Token: 0x040079B3 RID: 31155
		private bool _OptionInited;
	}
}
