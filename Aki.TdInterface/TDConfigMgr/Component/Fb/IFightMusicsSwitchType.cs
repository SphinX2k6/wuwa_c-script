using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B64 RID: 2916
	public class IFightMusicsSwitchType
	{
		// Token: 0x0600428F RID: 17039 RVA: 0x000A909A File Offset: 0x000A729A
		public static IFightMusicsSwitchType Create(IFightMusicsSwitchType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFightMusicsSwitchType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x000A90B9 File Offset: 0x000A72B9
		public virtual EFightMusicsSwitchType Type
		{
			get
			{
				return (EFightMusicsSwitchType)this.Instance.Type;
			}
		}

		// Token: 0x040024DD RID: 9437
		private IFightMusicsSwitchType Instance;
	}
}
