using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F05 RID: 3845
	public class IWuWaGoPullRod : IWuWaGoEntityBase
	{
		// Token: 0x0600567D RID: 22141 RVA: 0x000D4379 File Offset: 0x000D2579
		public static IWuWaGoPullRod Create(IWuWaGoPullRod? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoPullRod
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x0600567E RID: 22142 RVA: 0x000D4398 File Offset: 0x000D2598
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x0600567F RID: 22143 RVA: 0x000D43A8 File Offset: 0x000D25A8
		public virtual List<IWuWaGoInteractStateAction> InteractConfig
		{
			get
			{
				if (this._InteractConfigInited)
				{
					return this._InteractConfigCache;
				}
				this._InteractConfigInited = true;
				int interactConfigLength = this.Instance.InteractConfigLength;
				this._InteractConfigCache = new List<IWuWaGoInteractStateAction>(interactConfigLength);
				for (int i = 0; i < interactConfigLength; i++)
				{
					this._InteractConfigCache.Add(IWuWaGoInteractStateAction.Create(this.Instance.InteractConfig(i)));
				}
				return this._InteractConfigCache;
			}
		}

		// Token: 0x0400319A RID: 12698
		private IWuWaGoPullRod Instance;

		// Token: 0x0400319B RID: 12699
		private List<IWuWaGoInteractStateAction> _InteractConfigCache;

		// Token: 0x0400319C RID: 12700
		private bool _InteractConfigInited;
	}
}
