using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F49 RID: 3913
	public class IFrequencyPaintStraightLine : IFrequencyPaintLineBase
	{
		// Token: 0x060057D0 RID: 22480 RVA: 0x000D6ECA File Offset: 0x000D50CA
		public static IFrequencyPaintStraightLine Create(IFrequencyPaintStraightLine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintStraightLine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x060057D1 RID: 22481 RVA: 0x000D6EE9 File Offset: 0x000D50E9
		public override EFrequencyPaintLineType Type
		{
			get
			{
				return (EFrequencyPaintLineType)this.Instance.Type;
			}
		}

		// Token: 0x0400326C RID: 12908
		private IFrequencyPaintStraightLine Instance;
	}
}
