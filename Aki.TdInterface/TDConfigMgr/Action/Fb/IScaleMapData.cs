using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BD3 RID: 11219
	public class IScaleMapData
	{
		// Token: 0x0600F73B RID: 63291 RVA: 0x0023FE21 File Offset: 0x0023E021
		public static IScaleMapData Create(IScaleMapData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScaleMapData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C43 RID: 19523
		// (get) Token: 0x0600F73C RID: 63292 RVA: 0x0023FE40 File Offset: 0x0023E040
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17004C44 RID: 19524
		// (get) Token: 0x0600F73D RID: 63293 RVA: 0x0023FE4D File Offset: 0x0023E04D
		public virtual float Scale
		{
			get
			{
				return this.Instance.Scale;
			}
		}

		// Token: 0x04008761 RID: 34657
		private IScaleMapData Instance;
	}
}
