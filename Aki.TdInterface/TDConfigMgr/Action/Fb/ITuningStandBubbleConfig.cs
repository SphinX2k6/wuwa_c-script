using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002877 RID: 10359
	[NullableContext(1)]
	[Nullable(0)]
	public class ITuningStandBubbleConfig
	{
		// Token: 0x0600E581 RID: 58753 RVA: 0x0021BD9D File Offset: 0x00219F9D
		public static ITuningStandBubbleConfig Create(ITuningStandBubbleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITuningStandBubbleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004655 RID: 18005
		// (get) Token: 0x0600E582 RID: 58754 RVA: 0x0021BDBC File Offset: 0x00219FBC
		public virtual ETuningStandBubbleTriggerType TriggerType
		{
			get
			{
				return (ETuningStandBubbleTriggerType)this.Instance.TriggerType;
			}
		}

		// Token: 0x17004656 RID: 18006
		// (get) Token: 0x0600E583 RID: 58755 RVA: 0x0021BDC9 File Offset: 0x00219FC9
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				this._FlowCache = PlayFlow.Create(this.Instance.Flow);
				return this._FlowCache;
			}
		}

		// Token: 0x04007EE7 RID: 32487
		private ITuningStandBubbleConfig Instance;

		// Token: 0x04007EE8 RID: 32488
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x04007EE9 RID: 32489
		private bool _FlowInited;
	}
}
