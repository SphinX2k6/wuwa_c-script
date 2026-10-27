using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A1B RID: 10779
	public class IStartSlidePerformType
	{
		// Token: 0x0600ED9F RID: 60831 RVA: 0x0022A18D File Offset: 0x0022838D
		[NullableContext(1)]
		public static IStartSlidePerformType Create(IStartSlidePerformType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStartSlidePerformType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B2B RID: 19243
		// (get) Token: 0x0600EDA0 RID: 60832 RVA: 0x0022A1AC File Offset: 0x002283AC
		public virtual ESlidePerformType Type
		{
			get
			{
				return (ESlidePerformType)this.Instance.Type;
			}
		}

		// Token: 0x040082CB RID: 33483
		private IStartSlidePerformType Instance;
	}
}
