using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200140E RID: 5134
	public class IUseWeatherSwitchConditionBase
	{
		// Token: 0x060074BE RID: 29886 RVA: 0x001171FC File Offset: 0x001153FC
		[NullableContext(1)]
		public static IUseWeatherSwitchConditionBase Create(IUseWeatherSwitchConditionBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x060074BF RID: 29887 RVA: 0x0011721B File Offset: 0x0011541B
		public virtual EUseWeatherSwitchCheckType Type
		{
			get
			{
				return (EUseWeatherSwitchCheckType)this.Instance.Type;
			}
		}

		// Token: 0x04004398 RID: 17304
		private IUseWeatherSwitchConditionBase Instance;
	}
}
