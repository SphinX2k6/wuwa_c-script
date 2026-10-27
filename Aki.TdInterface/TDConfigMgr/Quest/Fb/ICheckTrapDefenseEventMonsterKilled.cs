using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013DB RID: 5083
	public class ICheckTrapDefenseEventMonsterKilled : ICheckTrapDefenseEventBase
	{
		// Token: 0x060073F3 RID: 29683 RVA: 0x00115E22 File Offset: 0x00114022
		[NullableContext(1)]
		public static ICheckTrapDefenseEventMonsterKilled Create(ICheckTrapDefenseEventMonsterKilled? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckTrapDefenseEventMonsterKilled
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x060073F4 RID: 29684 RVA: 0x00115E41 File Offset: 0x00114041
		public override ECheckTrapDefenseEvent Type
		{
			get
			{
				return (ECheckTrapDefenseEvent)this.Instance.Type;
			}
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x060073F5 RID: 29685 RVA: 0x00115E4E File Offset: 0x0011404E
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x0400431F RID: 17183
		private ICheckTrapDefenseEventMonsterKilled Instance;
	}
}
