using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002609 RID: 9737
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractActions : IInteractType
	{
		// Token: 0x0600DAAC RID: 55980 RVA: 0x00209449 File Offset: 0x00207649
		public static IInteractActions Create(IInteractActions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractActions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700405C RID: 16476
		// (get) Token: 0x0600DAAD RID: 55981 RVA: 0x00209468 File Offset: 0x00207668
		public override EInteractOption Type
		{
			get
			{
				return (EInteractOption)this.Instance.Type;
			}
		}

		// Token: 0x1700405D RID: 16477
		// (get) Token: 0x0600DAAE RID: 55982 RVA: 0x00209478 File Offset: 0x00207678
		public virtual List<ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x04007977 RID: 31095
		private IInteractActions Instance;

		// Token: 0x04007978 RID: 31096
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007979 RID: 31097
		private bool _ActionsInited;
	}
}
