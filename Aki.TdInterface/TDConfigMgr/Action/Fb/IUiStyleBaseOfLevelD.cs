using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200287B RID: 10363
	public class IUiStyleBaseOfLevelD
	{
		// Token: 0x0600E6FD RID: 59133 RVA: 0x00222DC3 File Offset: 0x00220FC3
		public static IUiStyleBaseOfLevelD Create(IUiStyleBaseOfLevelD? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiStyleBaseOfLevelD
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042B5 RID: 17077
		// (get) Token: 0x0600E6FE RID: 59134 RVA: 0x00222DE2 File Offset: 0x00220FE2
		public virtual EUiStyleTypeOfLevelD Type
		{
			get
			{
				return (EUiStyleTypeOfLevelD)this.Instance.Type;
			}
		}

		// Token: 0x04007F2F RID: 32559
		private IUiStyleBaseOfLevelD Instance;
	}
}
