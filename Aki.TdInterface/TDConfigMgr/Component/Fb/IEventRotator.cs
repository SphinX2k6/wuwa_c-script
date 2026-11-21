using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B2A RID: 2858
	public class IEventRotator
	{
		// Token: 0x06004151 RID: 16721 RVA: 0x000A684D File Offset: 0x000A4A4D
		public static IEventRotator Create(IEventRotator? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEventRotator
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06004152 RID: 16722 RVA: 0x000A686C File Offset: 0x000A4A6C
		public virtual List<ActionInfo> StartActions
		{
			get
			{
				if (this._StartActionsInited)
				{
					return this._StartActionsCache;
				}
				this._StartActionsInited = true;
				int startActionsLength = this.Instance.StartActionsLength;
				this._StartActionsCache = new List<ActionInfo>(startActionsLength);
				for (int i = 0; i < startActionsLength; i++)
				{
					this._StartActionsCache.Add(ActionInfo.Create(this.Instance.StartActions(i)));
				}
				return this._StartActionsCache;
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x000A68D8 File Offset: 0x000A4AD8
		public virtual List<ActionInfo> EndActions
		{
			get
			{
				if (this._EndActionsInited)
				{
					return this._EndActionsCache;
				}
				this._EndActionsInited = true;
				int endActionsLength = this.Instance.EndActionsLength;
				this._EndActionsCache = new List<ActionInfo>(endActionsLength);
				for (int i = 0; i < endActionsLength; i++)
				{
					this._EndActionsCache.Add(ActionInfo.Create(this.Instance.EndActions(i)));
				}
				return this._EndActionsCache;
			}
		}

		// Token: 0x0400242B RID: 9259
		private IEventRotator Instance;

		// Token: 0x0400242C RID: 9260
		private List<ActionInfo> _StartActionsCache;

		// Token: 0x0400242D RID: 9261
		private bool _StartActionsInited;

		// Token: 0x0400242E RID: 9262
		private List<ActionInfo> _EndActionsCache;

		// Token: 0x0400242F RID: 9263
		private bool _EndActionsInited;
	}
}
