using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200287C RID: 10364
	public class IUiStyleGiantSubtitleOfLevelD : IUiStyleBaseOfLevelD
	{
		// Token: 0x0600E700 RID: 59136 RVA: 0x00222DF7 File Offset: 0x00220FF7
		public static IUiStyleGiantSubtitleOfLevelD Create(IUiStyleGiantSubtitleOfLevelD? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiStyleGiantSubtitleOfLevelD
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042B6 RID: 17078
		// (get) Token: 0x0600E701 RID: 59137 RVA: 0x00222E16 File Offset: 0x00221016
		public override EUiStyleTypeOfLevelD Type
		{
			get
			{
				return (EUiStyleTypeOfLevelD)this.Instance.Type;
			}
		}

		// Token: 0x170042B7 RID: 17079
		// (get) Token: 0x0600E702 RID: 59138 RVA: 0x00222E23 File Offset: 0x00221023
		public virtual EGiantSubtitleStyle Style
		{
			get
			{
				return (EGiantSubtitleStyle)this.Instance.Style;
			}
		}

		// Token: 0x04007F30 RID: 32560
		private IUiStyleGiantSubtitleOfLevelD Instance;
	}
}
