using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F48 RID: 3912
	public class IFrequencyPaintLineBase
	{
		// Token: 0x060057CD RID: 22477 RVA: 0x000D6E96 File Offset: 0x000D5096
		public static IFrequencyPaintLineBase Create(IFrequencyPaintLineBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintLineBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x060057CE RID: 22478 RVA: 0x000D6EB5 File Offset: 0x000D50B5
		public virtual EFrequencyPaintLineType Type
		{
			get
			{
				return (EFrequencyPaintLineType)this.Instance.Type;
			}
		}

		// Token: 0x0400326B RID: 12907
		private IFrequencyPaintLineBase Instance;
	}
}
