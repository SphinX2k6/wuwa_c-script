using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001468 RID: 5224
	public class ITetrisPlayModeNormal : ITetrisPlayModeBase
	{
		// Token: 0x060076E2 RID: 30434 RVA: 0x0011C364 File Offset: 0x0011A564
		[NullableContext(1)]
		public static ITetrisPlayModeNormal Create(ITetrisPlayModeNormal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeNormal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x060076E3 RID: 30435 RVA: 0x0011C383 File Offset: 0x0011A583
		public override ETetrisPlayMode Type
		{
			get
			{
				return (ETetrisPlayMode)this.Instance.Type;
			}
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x060076E4 RID: 30436 RVA: 0x0011C390 File Offset: 0x0011A590
		public virtual int Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x0400451E RID: 17694
		private ITetrisPlayModeNormal Instance;
	}
}
