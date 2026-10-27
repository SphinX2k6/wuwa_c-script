using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002989 RID: 10633
	[NullableContext(1)]
	[Nullable(0)]
	public class IAudioState
	{
		// Token: 0x0600EB7C RID: 60284 RVA: 0x00227188 File Offset: 0x00225388
		public static IAudioState Create(IAudioState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A2C RID: 18988
		// (get) Token: 0x0600EB7D RID: 60285 RVA: 0x002271A7 File Offset: 0x002253A7
		public virtual string Group
		{
			get
			{
				return this.Instance.Group;
			}
		}

		// Token: 0x17004A2D RID: 18989
		// (get) Token: 0x0600EB7E RID: 60286 RVA: 0x002271B4 File Offset: 0x002253B4
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x040081B1 RID: 33201
		private IAudioState Instance;
	}
}
