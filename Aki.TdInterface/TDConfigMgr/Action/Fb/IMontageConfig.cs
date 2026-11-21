using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B5D RID: 11101
	public class IMontageConfig
	{
		// Token: 0x0600F40F RID: 62479 RVA: 0x00239A4F File Offset: 0x00237C4F
		public static IMontageConfig Create(IMontageConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A03 RID: 18947
		// (get) Token: 0x0600F410 RID: 62480 RVA: 0x00239A6E File Offset: 0x00237C6E
		public virtual EMontageConfigType Type
		{
			get
			{
				return (EMontageConfigType)this.Instance.Type;
			}
		}

		// Token: 0x040085D7 RID: 34263
		private IMontageConfig Instance;
	}
}
