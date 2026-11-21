using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D69 RID: 11625
	public class ICheckFlowLookAt : IOverrideLookAtType
	{
		// Token: 0x0600FDAD RID: 64941 RVA: 0x00249FA8 File Offset: 0x002481A8
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

		// Token: 0x17004F89 RID: 20361
		// (get) Token: 0x0600FDAE RID: 64942 RVA: 0x00249FC7 File Offset: 0x002481C7
		public override EOverrideLookAtType Type
		{
			get
			{
				return (EOverrideLookAtType)this.Instance.Type;
			}
		}

		// Token: 0x17004F8A RID: 20362
		// (get) Token: 0x0600FDAF RID: 64943 RVA: 0x00249FD4 File Offset: 0x002481D4
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

		// Token: 0x04008A7B RID: 35451
		private ICheckFlowLookAt Instance;

		// Token: 0x04008A7C RID: 35452
		private List<ICheckFlowLookAtConfig> _CheckFlowLookAtConfigsCache;

		// Token: 0x04008A7D RID: 35453
		private bool _CheckFlowLookAtConfigsInited;
	}
}
