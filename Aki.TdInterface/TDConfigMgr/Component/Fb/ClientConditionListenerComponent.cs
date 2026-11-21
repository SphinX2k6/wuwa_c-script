using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E81 RID: 3713
	public class ClientConditionListenerComponent : IComponentBase
	{
		// Token: 0x060053E2 RID: 21474 RVA: 0x000CEC06 File Offset: 0x000CCE06
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

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x060053E3 RID: 21475 RVA: 0x000CEC28 File Offset: 0x000CCE28
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

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x000CEC60 File Offset: 0x000CCE60
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x060053E5 RID: 21477 RVA: 0x000CEC78 File Offset: 0x000CCE78
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

		// Token: 0x04002FF6 RID: 12278
		private IClientConditionListenerComponent Instance;

		// Token: 0x04002FF7 RID: 12279
		private List<IClientConditionListener> _ListenersCache;

		// Token: 0x04002FF8 RID: 12280
		private bool _ListenersInited;
	}
}
