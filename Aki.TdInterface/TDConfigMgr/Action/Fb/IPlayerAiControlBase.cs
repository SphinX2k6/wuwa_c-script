using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C36 RID: 11318
	public class IPlayerAiControlBase
	{
		// Token: 0x0600F909 RID: 63753 RVA: 0x00243162 File Offset: 0x00241362
		public static IPlayerAiControlBase Create(IPlayerAiControlBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerAiControlBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D4B RID: 19787
		// (get) Token: 0x0600F90A RID: 63754 RVA: 0x00243181 File Offset: 0x00241381
		public virtual EPlayerAiControlType Type
		{
			get
			{
				return (EPlayerAiControlType)this.Instance.Type;
			}
		}

		// Token: 0x04008822 RID: 34850
		private IPlayerAiControlBase Instance;
	}
}
