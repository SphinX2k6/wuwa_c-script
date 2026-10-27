using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C7A RID: 3194
	[NullableContext(1)]
	[Nullable(0)]
	public class ConditionListenerComponent : IComponentBase
	{
		// Token: 0x0600492E RID: 18734 RVA: 0x000B7AA6 File Offset: 0x000B5CA6
		public static ConditionListenerComponent Create(IConditionListenerComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ConditionListenerComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x0600492F RID: 18735 RVA: 0x000B7AC8 File Offset: 0x000B5CC8
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

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06004930 RID: 18736 RVA: 0x000B7B00 File Offset: 0x000B5D00
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06004931 RID: 18737 RVA: 0x000B7B18 File Offset: 0x000B5D18
		public virtual List<ICondtionListener> Listeners
		{
			get
			{
				if (this._ListenersInited)
				{
					return this._ListenersCache;
				}
				this._ListenersInited = true;
				int listenersLength = this.Instance.ListenersLength;
				this._ListenersCache = new List<ICondtionListener>(listenersLength);
				for (int i = 0; i < listenersLength; i++)
				{
					this._ListenersCache.Add(ICondtionListener.Create(this.Instance.Listeners(i)));
				}
				return this._ListenersCache;
			}
		}

		// Token: 0x040029C1 RID: 10689
		private IConditionListenerComponent Instance;

		// Token: 0x040029C2 RID: 10690
		private List<ICondtionListener> _ListenersCache;

		// Token: 0x040029C3 RID: 10691
		private bool _ListenersInited;
	}
}
