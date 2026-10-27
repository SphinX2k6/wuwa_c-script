using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A9C RID: 2716
	[NullableContext(1)]
	[Nullable(0)]
	public class IFightMusicSwitchByTag
	{
		// Token: 0x06003E6D RID: 15981 RVA: 0x0009FBB5 File Offset: 0x0009DDB5
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

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06003E6E RID: 15982 RVA: 0x0009FBD4 File Offset: 0x0009DDD4
		public virtual string FightMusic
		{
			get
			{
				return this.Instance.FightMusic;
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06003E6F RID: 15983 RVA: 0x0009FBE1 File Offset: 0x0009DDE1
		[Nullable(2)]
		public virtual string ActivateTag
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.ActivateTag;
			}
		}

		// Token: 0x040022C5 RID: 8901
		private IFightMusicSwitchByTag Instance;
	}
}
