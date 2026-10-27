using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001432 RID: 5170
	public class ISneakPlayCondition
	{
		// Token: 0x06007592 RID: 30098 RVA: 0x00118E05 File Offset: 0x00117005
		[NullableContext(1)]
		public static ISneakPlayCondition Create(ISneakPlayCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISneakPlayCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x06007593 RID: 30099 RVA: 0x00118E24 File Offset: 0x00117024
		public virtual int Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x04004420 RID: 17440
		private ISneakPlayCondition Instance;
	}
}
