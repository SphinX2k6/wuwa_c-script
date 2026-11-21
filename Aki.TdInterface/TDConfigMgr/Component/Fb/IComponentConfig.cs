using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B1B RID: 2843
	public class IComponentConfig
	{
		// Token: 0x060040FA RID: 16634 RVA: 0x000A5D96 File Offset: 0x000A3F96
		public static IComponentConfig Create(IComponentConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IComponentConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x000A5DB8 File Offset: 0x000A3FB8
		public virtual List<EAction> BaseActions
		{
			get
			{
				if (this._BaseActionsInited)
				{
					return this._BaseActionsCache;
				}
				this._BaseActionsInited = true;
				int baseActionsLength = this.Instance.BaseActionsLength;
				this._BaseActionsCache = new List<EAction>(baseActionsLength);
				for (int i = 0; i < baseActionsLength; i++)
				{
					this._BaseActionsCache.Add((EAction)this.Instance.BaseActions(i));
				}
				return this._BaseActionsCache;
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060040FC RID: 16636 RVA: 0x000A5E1C File Offset: 0x000A401C
		public virtual string ActionsByComponent
		{
			get
			{
				return this.Instance.ActionsByComponent;
			}
		}

		// Token: 0x04002404 RID: 9220
		private IComponentConfig Instance;

		// Token: 0x04002405 RID: 9221
		private List<EAction> _BaseActionsCache;

		// Token: 0x04002406 RID: 9222
		private bool _BaseActionsInited;
	}
}
