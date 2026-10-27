using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D85 RID: 3461
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientConditionListenerComponent : IComponentBase
	{
		// Token: 0x06004EBD RID: 20157 RVA: 0x000C33B6 File Offset: 0x000C15B6
		public static ClientConditionListenerComponent Create(IClientConditionListenerComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientConditionListenerComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06004EBE RID: 20158 RVA: 0x000C33D8 File Offset: 0x000C15D8
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06004EBF RID: 20159 RVA: 0x000C3410 File Offset: 0x000C1610
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x06004EC0 RID: 20160 RVA: 0x000C3428 File Offset: 0x000C1628
		public virtual List<IClientConditionListener> Listeners
		{
			get
			{
				if (this._ListenersInited)
				{
					return this._ListenersCache;
				}
				this._ListenersInited = true;
				int listenersLength = this.Instance.ListenersLength;
				this._ListenersCache = new List<IClientConditionListener>(listenersLength);
				for (int i = 0; i < listenersLength; i++)
				{
					this._ListenersCache.Add(IClientConditionListener.Create(this.Instance.Listeners(i)));
				}
				return this._ListenersCache;
			}
		}

		// Token: 0x04002D30 RID: 11568
		private IClientConditionListenerComponent Instance;

		// Token: 0x04002D31 RID: 11569
		private List<IClientConditionListener> _ListenersCache;

		// Token: 0x04002D32 RID: 11570
		private bool _ListenersInited;
	}
}
