using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B0 RID: 10416
	public class IRemoveEffectBase
	{
		// Token: 0x0600E80C RID: 59404 RVA: 0x00224E39 File Offset: 0x00223039
		public static IRemoveEffectBase Create(IRemoveEffectBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemoveEffectBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700435A RID: 17242
		// (get) Token: 0x0600E80D RID: 59405 RVA: 0x00224E58 File Offset: 0x00223058
		public virtual EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700435B RID: 17243
		// (get) Token: 0x0600E80E RID: 59406 RVA: 0x00224E65 File Offset: 0x00223065
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x04007FCA RID: 32714
		private IRemoveEffectBase Instance;
	}
}
