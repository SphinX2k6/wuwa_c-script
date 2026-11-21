using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E86 RID: 3718
	public class IChildStateChangedConfig
	{
		// Token: 0x060053F7 RID: 21495 RVA: 0x000CEF29 File Offset: 0x000CD129
		public static IChildStateChangedConfig Create(IChildStateChangedConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChildStateChangedConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x060053F8 RID: 21496 RVA: 0x000CEF48 File Offset: 0x000CD148
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x060053F9 RID: 21497 RVA: 0x000CEF55 File Offset: 0x000CD155
		[Nullable(2)]
		public virtual IDelayChangeState DelayChangeState
		{
			[NullableContext(2)]
			get
			{
				if (this._DelayChangeStateInited)
				{
					return this._DelayChangeStateCache;
				}
				this._DelayChangeStateInited = true;
				this._DelayChangeStateCache = IDelayChangeState.Create(this.Instance.DelayChangeState);
				return this._DelayChangeStateCache;
			}
		}

		// Token: 0x04003007 RID: 12295
		private IChildStateChangedConfig Instance;

		// Token: 0x04003008 RID: 12296
		[Nullable(2)]
		private IDelayChangeState _DelayChangeStateCache;

		// Token: 0x04003009 RID: 12297
		private bool _DelayChangeStateInited;
	}
}
