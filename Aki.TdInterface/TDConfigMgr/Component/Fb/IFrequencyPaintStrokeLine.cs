using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F4C RID: 3916
	public class IFrequencyPaintStrokeLine : IFrequencyPaintLineBase
	{
		// Token: 0x060057DB RID: 22491 RVA: 0x000D6F80 File Offset: 0x000D5180
		public static IFrequencyPaintStrokeLine Create(IFrequencyPaintStrokeLine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintStrokeLine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x060057DC RID: 22492 RVA: 0x000D6F9F File Offset: 0x000D519F
		public override EFrequencyPaintLineType Type
		{
			get
			{
				return (EFrequencyPaintLineType)this.Instance.Type;
			}
		}

		// Token: 0x0400326F RID: 12911
		private IFrequencyPaintStrokeLine Instance;
	}
}
