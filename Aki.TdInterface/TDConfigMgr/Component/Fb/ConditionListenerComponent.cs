using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D59 RID: 3417
	public class ConditionListenerComponent : IComponentBase
	{
		// Token: 0x06004DCD RID: 19917 RVA: 0x000C22AA File Offset: 0x000C04AA
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

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06004DCE RID: 19918 RVA: 0x000C22CC File Offset: 0x000C04CC
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

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06004DCF RID: 19919 RVA: 0x000C2304 File Offset: 0x000C0504
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06004DD0 RID: 19920 RVA: 0x000C231C File Offset: 0x000C051C
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

		// Token: 0x04002C2E RID: 11310
		private IConditionListenerComponent Instance;

		// Token: 0x04002C2F RID: 11311
		private List<ICondtionListener> _ListenersCache;

		// Token: 0x04002C30 RID: 11312
		private bool _ListenersInited;
	}
}
