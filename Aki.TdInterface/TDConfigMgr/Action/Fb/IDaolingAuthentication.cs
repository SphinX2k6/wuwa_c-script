using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B3E RID: 11070
	public class IDaolingAuthentication : IUiGame
	{
		// Token: 0x0600F36F RID: 62319 RVA: 0x0023863C File Offset: 0x0023683C
		public static IDaolingAuthentication Create(IDaolingAuthentication? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDaolingAuthentication
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A1 RID: 18849
		// (get) Token: 0x0600F370 RID: 62320 RVA: 0x0023865B File Offset: 0x0023685B
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x0400858A RID: 34186
		private IDaolingAuthentication Instance;
	}
}
