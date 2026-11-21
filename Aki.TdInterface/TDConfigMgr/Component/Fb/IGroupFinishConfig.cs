using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C74 RID: 3188
	public class IGroupFinishConfig
	{
		// Token: 0x060048CB RID: 18635 RVA: 0x000B7E61 File Offset: 0x000B6061
		public static IGroupFinishConfig Create(IGroupFinishConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupFinishConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x060048CC RID: 18636 RVA: 0x000B7E80 File Offset: 0x000B6080
		public virtual EGroupFinishConfig Type
		{
			get
			{
				return (EGroupFinishConfig)this.Instance.Type;
			}
		}

		// Token: 0x040028ED RID: 10477
		private IGroupFinishConfig Instance;
	}
}
