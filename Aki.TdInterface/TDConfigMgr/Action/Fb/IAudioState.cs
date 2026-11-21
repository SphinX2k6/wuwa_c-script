using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C6F RID: 11375
	public class IAudioState
	{
		// Token: 0x0600F9F7 RID: 63991 RVA: 0x002448E0 File Offset: 0x00242AE0
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

		// Token: 0x17004DC7 RID: 19911
		// (get) Token: 0x0600F9F8 RID: 63992 RVA: 0x002448FF File Offset: 0x00242AFF
		public virtual string Group
		{
			get
			{
				return this.Instance.Group;
			}
		}

		// Token: 0x17004DC8 RID: 19912
		// (get) Token: 0x0600F9F9 RID: 63993 RVA: 0x0024490C File Offset: 0x00242B0C
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04008895 RID: 34965
		private IAudioState Instance;
	}
}
