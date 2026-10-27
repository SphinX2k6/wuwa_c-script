using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A75 RID: 10869
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckFlowLookAt : IOverrideLookAtType
	{
		// Token: 0x0600EEF7 RID: 61175 RVA: 0x0022C29C File Offset: 0x0022A49C
		public static ICheckFlowLookAt Create(ICheckFlowLookAt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BCF RID: 19407
		// (get) Token: 0x0600EEF8 RID: 61176 RVA: 0x0022C2BB File Offset: 0x0022A4BB
		public override EOverrideLookAtType Type
		{
			get
			{
				return (EOverrideLookAtType)this.Instance.Type;
			}
		}

		// Token: 0x17004BD0 RID: 19408
		// (get) Token: 0x0600EEF9 RID: 61177 RVA: 0x0022C2C8 File Offset: 0x0022A4C8
		public virtual List<ICheckFlowLookAtConfig> CheckFlowLookAtConfigs
		{
			get
			{
				if (this._CheckFlowLookAtConfigsInited)
				{
					return this._CheckFlowLookAtConfigsCache;
				}
				this._CheckFlowLookAtConfigsInited = true;
				int checkFlowLookAtConfigsLength = this.Instance.CheckFlowLookAtConfigsLength;
				this._CheckFlowLookAtConfigsCache = new List<ICheckFlowLookAtConfig>(checkFlowLookAtConfigsLength);
				for (int i = 0; i < checkFlowLookAtConfigsLength; i++)
				{
					this._CheckFlowLookAtConfigsCache.Add(ICheckFlowLookAtConfig.Create(this.Instance.CheckFlowLookAtConfigs(i)));
				}
				return this._CheckFlowLookAtConfigsCache;
			}
		}

		// Token: 0x04008377 RID: 33655
		private ICheckFlowLookAt Instance;

		// Token: 0x04008378 RID: 33656
		private List<ICheckFlowLookAtConfig> _CheckFlowLookAtConfigsCache;

		// Token: 0x04008379 RID: 33657
		private bool _CheckFlowLookAtConfigsInited;
	}
}
