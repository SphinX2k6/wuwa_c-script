using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E79 RID: 3705
	public class IQteCallback
	{
		// Token: 0x060053B5 RID: 21429 RVA: 0x000CE686 File Offset: 0x000CC886
		public static IQteCallback Create(IQteCallback? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQteCallback
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x060053B6 RID: 21430 RVA: 0x000CE6A8 File Offset: 0x000CC8A8
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

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x060053B7 RID: 21431 RVA: 0x000CE711 File Offset: 0x000CC911
		[Nullable(2)]
		public virtual string SendSelfEvent
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SendSelfEvent;
			}
		}

		// Token: 0x04002FDE RID: 12254
		private IQteCallback Instance;

		// Token: 0x04002FDF RID: 12255
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002FE0 RID: 12256
		private bool _ActionsInited;
	}
}
