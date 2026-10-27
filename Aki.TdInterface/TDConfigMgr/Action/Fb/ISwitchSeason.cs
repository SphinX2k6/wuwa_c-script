using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200289E RID: 10398
	public class ISwitchSeason : IClientSetSeasonStateConfig
	{
		// Token: 0x0600E631 RID: 58929 RVA: 0x0021D3B9 File Offset: 0x0021B5B9
		[NullableContext(1)]
		public static ISwitchSeason Create(ISwitchSeason? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchSeason
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046B7 RID: 18103
		// (get) Token: 0x0600E632 RID: 58930 RVA: 0x0021D3D8 File Offset: 0x0021B5D8
		public override EClientSetSeasonStateType Type
		{
			get
			{
				return (EClientSetSeasonStateType)this.Instance.Type;
			}
		}

		// Token: 0x170046B8 RID: 18104
		// (get) Token: 0x0600E633 RID: 58931 RVA: 0x0021D3E5 File Offset: 0x0021B5E5
		public virtual ESeason Season
		{
			get
			{
				return (ESeason)this.Instance.Season;
			}
		}

		// Token: 0x170046B9 RID: 18105
		// (get) Token: 0x0600E634 RID: 58932 RVA: 0x0021D3F2 File Offset: 0x0021B5F2
		public virtual float TransitionSpeed
		{
			get
			{
				return this.Instance.TransitionSpeed;
			}
		}

		// Token: 0x04007F44 RID: 32580
		private ISwitchSeason Instance;
	}
}
