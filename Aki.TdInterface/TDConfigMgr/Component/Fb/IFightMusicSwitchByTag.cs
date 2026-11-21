using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B66 RID: 2918
	public class IFightMusicSwitchByTag
	{
		// Token: 0x06004296 RID: 17046 RVA: 0x000A916D File Offset: 0x000A736D
		public static IFightMusicSwitchByTag Create(IFightMusicSwitchByTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFightMusicSwitchByTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06004297 RID: 17047 RVA: 0x000A918C File Offset: 0x000A738C
		public virtual string FightMusic
		{
			get
			{
				return this.Instance.FightMusic;
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06004298 RID: 17048 RVA: 0x000A9199 File Offset: 0x000A7399
		[Nullable(2)]
		public virtual string ActivateTag
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.ActivateTag;
			}
		}

		// Token: 0x040024E1 RID: 9441
		private IFightMusicSwitchByTag Instance;
	}
}
