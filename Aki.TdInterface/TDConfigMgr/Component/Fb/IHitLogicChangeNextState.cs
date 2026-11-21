using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C53 RID: 3155
	public class IHitLogicChangeNextState : IHitLogicType
	{
		// Token: 0x06004836 RID: 18486 RVA: 0x000B6C0A File Offset: 0x000B4E0A
		public static IHitLogicChangeNextState Create(IHitLogicChangeNextState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeNextState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x000B6C29 File Offset: 0x000B4E29
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x0400288C RID: 10380
		private IHitLogicChangeNextState Instance;
	}
}
