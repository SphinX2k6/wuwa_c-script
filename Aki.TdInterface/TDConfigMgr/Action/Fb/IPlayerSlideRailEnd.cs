using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D05 RID: 11525
	public class IPlayerSlideRailEnd : ISlideRailEndType
	{
		// Token: 0x0600FC2C RID: 64556 RVA: 0x00247A46 File Offset: 0x00245C46
		public static IPlayerSlideRailEnd Create(IPlayerSlideRailEnd? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerSlideRailEnd
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004ED0 RID: 20176
		// (get) Token: 0x0600FC2D RID: 64557 RVA: 0x00247A65 File Offset: 0x00245C65
		public override ESlideRailEndType Type
		{
			get
			{
				return (ESlideRailEndType)this.Instance.Type;
			}
		}

		// Token: 0x040089B7 RID: 35255
		private IPlayerSlideRailEnd Instance;
	}
}
