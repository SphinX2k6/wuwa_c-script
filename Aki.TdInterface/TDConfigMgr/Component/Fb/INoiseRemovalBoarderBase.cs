using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F44 RID: 3908
	public class INoiseRemovalBoarderBase
	{
		// Token: 0x060057B9 RID: 22457 RVA: 0x000D6C2F File Offset: 0x000D4E2F
		public static INoiseRemovalBoarderBase Create(INoiseRemovalBoarderBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INoiseRemovalBoarderBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x060057BA RID: 22458 RVA: 0x000D6C4E File Offset: 0x000D4E4E
		public virtual ENoiseRemovalBoarderShape Type
		{
			get
			{
				return (ENoiseRemovalBoarderShape)this.Instance.Type;
			}
		}

		// Token: 0x0400325F RID: 12895
		private INoiseRemovalBoarderBase Instance;
	}
}
