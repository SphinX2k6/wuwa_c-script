using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D8A RID: 3466
	[NullableContext(1)]
	[Nullable(0)]
	public class IChildStateChangedConfig
	{
		// Token: 0x06004ED2 RID: 20178 RVA: 0x000C36D9 File Offset: 0x000C18D9
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

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x06004ED3 RID: 20179 RVA: 0x000C36F8 File Offset: 0x000C18F8
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x06004ED4 RID: 20180 RVA: 0x000C3705 File Offset: 0x000C1905
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

		// Token: 0x04002D41 RID: 11585
		private IChildStateChangedConfig Instance;

		// Token: 0x04002D42 RID: 11586
		[Nullable(2)]
		private IDelayChangeState _DelayChangeStateCache;

		// Token: 0x04002D43 RID: 11587
		private bool _DelayChangeStateInited;
	}
}
