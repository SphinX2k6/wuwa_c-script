using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028AB RID: 10411
	public class IPlayDissolveEffectInActorPosConfig
	{
		// Token: 0x0600E7F1 RID: 59377 RVA: 0x00224ACD File Offset: 0x00222CCD
		public static IPlayDissolveEffectInActorPosConfig Create(IPlayDissolveEffectInActorPosConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayDissolveEffectInActorPosConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004349 RID: 17225
		// (get) Token: 0x0600E7F2 RID: 59378 RVA: 0x00224AEC File Offset: 0x00222CEC
		public virtual EAspectRatio AspectRatio
		{
			get
			{
				return (EAspectRatio)this.Instance.AspectRatio;
			}
		}

		// Token: 0x04007FBB RID: 32699
		private IPlayDissolveEffectInActorPosConfig Instance;
	}
}
