using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028FF RID: 10495
	public class IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x0600E90B RID: 59659 RVA: 0x00222E58 File Offset: 0x00221058
		[NullableContext(1)]
		public static IModifyActorMaterialParamBySplineProgressConfig Create(IModifyActorMaterialParamBySplineProgressConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048CF RID: 18639
		// (get) Token: 0x0600E90C RID: 59660 RVA: 0x00222E77 File Offset: 0x00221077
		public virtual EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				return (EModifyActorMaterialParamBySplineProgressType)this.Instance.Type;
			}
		}

		// Token: 0x170048D0 RID: 18640
		// (get) Token: 0x0600E90D RID: 59661 RVA: 0x00222E84 File Offset: 0x00221084
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x040080A7 RID: 32935
		private IModifyActorMaterialParamBySplineProgressConfig Instance;
	}
}
