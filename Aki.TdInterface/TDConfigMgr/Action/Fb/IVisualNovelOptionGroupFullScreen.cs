using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002841 RID: 10305
	public class IVisualNovelOptionGroupFullScreen : IVisualNovelOptionGroupConfigBase
	{
		// Token: 0x0600E548 RID: 58696 RVA: 0x0021DDB2 File Offset: 0x0021BFB2
		public static IVisualNovelOptionGroupFullScreen Create(IVisualNovelOptionGroupFullScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupFullScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004174 RID: 16756
		// (get) Token: 0x0600E549 RID: 58697 RVA: 0x0021DDD1 File Offset: 0x0021BFD1
		public override EVisualNovelOptionGroupType Type
		{
			get
			{
				return (EVisualNovelOptionGroupType)this.Instance.Type;
			}
		}

		// Token: 0x04007DC9 RID: 32201
		private IVisualNovelOptionGroupFullScreen Instance;
	}
}
