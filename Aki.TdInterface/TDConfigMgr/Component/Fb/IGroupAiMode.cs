using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E4F RID: 3663
	public class IGroupAiMode
	{
		// Token: 0x060052E9 RID: 21225 RVA: 0x000CCDC7 File Offset: 0x000CAFC7
		public static IGroupAiMode Create(IGroupAiMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x060052EA RID: 21226 RVA: 0x000CCDE6 File Offset: 0x000CAFE6
		public virtual EGroupAiMode Type
		{
			get
			{
				return (EGroupAiMode)this.Instance.Type;
			}
		}

		// Token: 0x04002F5A RID: 12122
		private IGroupAiMode Instance;
	}
}
