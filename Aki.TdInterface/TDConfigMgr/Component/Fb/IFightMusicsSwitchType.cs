using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A9A RID: 2714
	public class IFightMusicsSwitchType
	{
		// Token: 0x06003E66 RID: 15974 RVA: 0x0009FAE2 File Offset: 0x0009DCE2
		[NullableContext(1)]
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

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06003E67 RID: 15975 RVA: 0x0009FB01 File Offset: 0x0009DD01
		public virtual EFightMusicsSwitchType Type
		{
			get
			{
				return (EFightMusicsSwitchType)this.Instance.Type;
			}
		}

		// Token: 0x040022C1 RID: 8897
		private IFightMusicsSwitchType Instance;
	}
}
