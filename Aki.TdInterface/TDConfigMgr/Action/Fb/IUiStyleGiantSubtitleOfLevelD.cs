using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025CD RID: 9677
	public class IUiStyleGiantSubtitleOfLevelD : IUiStyleBaseOfLevelD
	{
		// Token: 0x0600D984 RID: 55684 RVA: 0x00207047 File Offset: 0x00205247
		[NullableContext(1)]
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

		// Token: 0x17003FAC RID: 16300
		// (get) Token: 0x0600D985 RID: 55685 RVA: 0x00207066 File Offset: 0x00205266
		public override EUiStyleTypeOfLevelD Type
		{
			get
			{
				return (EUiStyleTypeOfLevelD)this.Instance.Type;
			}
		}

		// Token: 0x17003FAD RID: 16301
		// (get) Token: 0x0600D986 RID: 55686 RVA: 0x00207073 File Offset: 0x00205273
		public virtual EGiantSubtitleStyle Style
		{
			get
			{
				return (EGiantSubtitleStyle)this.Instance.Style;
			}
		}

		// Token: 0x040078C7 RID: 30919
		private IUiStyleGiantSubtitleOfLevelD Instance;
	}
}
