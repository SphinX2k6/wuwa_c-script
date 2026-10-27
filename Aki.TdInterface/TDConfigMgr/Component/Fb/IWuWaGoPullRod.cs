using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E09 RID: 3593
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoPullRod : IWuWaGoEntityBase
	{
		// Token: 0x06005156 RID: 20822 RVA: 0x000C8AB1 File Offset: 0x000C6CB1
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

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06005157 RID: 20823 RVA: 0x000C8AD0 File Offset: 0x000C6CD0
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06005158 RID: 20824 RVA: 0x000C8AE0 File Offset: 0x000C6CE0
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

		// Token: 0x04002ED2 RID: 11986
		private IWuWaGoPullRod Instance;

		// Token: 0x04002ED3 RID: 11987
		private List<IWuWaGoInteractStateAction> _InteractConfigCache;

		// Token: 0x04002ED4 RID: 11988
		private bool _InteractConfigInited;
	}
}
