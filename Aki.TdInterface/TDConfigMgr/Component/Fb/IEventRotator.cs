using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A61 RID: 2657
	[NullableContext(1)]
	[Nullable(0)]
	public class IEventRotator
	{
		// Token: 0x06003D31 RID: 15665 RVA: 0x0009D3D5 File Offset: 0x0009B5D5
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

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06003D32 RID: 15666 RVA: 0x0009D3F4 File Offset: 0x0009B5F4
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

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06003D33 RID: 15667 RVA: 0x0009D460 File Offset: 0x0009B660
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

		// Token: 0x04002214 RID: 8724
		private IEventRotator Instance;

		// Token: 0x04002215 RID: 8725
		private List<ActionInfo> _StartActionsCache;

		// Token: 0x04002216 RID: 8726
		private bool _StartActionsInited;

		// Token: 0x04002217 RID: 8727
		private List<ActionInfo> _EndActionsCache;

		// Token: 0x04002218 RID: 8728
		private bool _EndActionsInited;
	}
}
