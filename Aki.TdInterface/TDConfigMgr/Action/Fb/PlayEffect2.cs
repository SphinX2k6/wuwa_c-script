using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A4 RID: 10404
	public class PlayEffect2 : ActionParams
	{
		// Token: 0x0600E7CE RID: 59342 RVA: 0x002247C6 File Offset: 0x002229C6
		public static PlayEffect2 Create(IPlayEffect2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayEffect2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004334 RID: 17204
		// (get) Token: 0x0600E7CF RID: 59343 RVA: 0x002247E5 File Offset: 0x002229E5
		public virtual EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004335 RID: 17205
		// (get) Token: 0x0600E7D0 RID: 59344 RVA: 0x002247F2 File Offset: 0x002229F2
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x04007FAE RID: 32686
		private IPlayEffect2 Instance;
	}
}
