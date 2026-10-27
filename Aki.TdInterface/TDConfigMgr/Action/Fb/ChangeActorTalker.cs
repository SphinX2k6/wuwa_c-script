using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200288E RID: 10382
	public class ChangeActorTalker : ActionParams
	{
		// Token: 0x0600E5F2 RID: 58866 RVA: 0x0021CC2E File Offset: 0x0021AE2E
		[NullableContext(1)]
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

		// Token: 0x17004698 RID: 18072
		// (get) Token: 0x0600E5F3 RID: 58867 RVA: 0x0021CC4D File Offset: 0x0021AE4D
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17004699 RID: 18073
		// (get) Token: 0x0600E5F4 RID: 58868 RVA: 0x0021CC5A File Offset: 0x0021AE5A
		public virtual int Talker
		{
			get
			{
				return this.Instance.Talker;
			}
		}

		// Token: 0x04007F20 RID: 32544
		private IChangeActorTalker Instance;
	}
}
