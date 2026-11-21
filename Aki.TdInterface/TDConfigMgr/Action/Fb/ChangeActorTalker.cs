using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B63 RID: 11107
	public class ChangeActorTalker : ActionParams
	{
		// Token: 0x0600F421 RID: 62497 RVA: 0x00239BAE File Offset: 0x00237DAE
		public static ChangeActorTalker Create(IChangeActorTalker? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeActorTalker
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A09 RID: 18953
		// (get) Token: 0x0600F422 RID: 62498 RVA: 0x00239BCD File Offset: 0x00237DCD
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17004A0A RID: 18954
		// (get) Token: 0x0600F423 RID: 62499 RVA: 0x00239BDA File Offset: 0x00237DDA
		public virtual int Talker
		{
			get
			{
				return this.Instance.Talker;
			}
		}

		// Token: 0x040085DF RID: 34271
		private IChangeActorTalker Instance;
	}
}
