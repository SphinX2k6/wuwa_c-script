using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002694 RID: 9876
	public class ITeleportTransitionWithCustomLoading : ITeleportTransitionType
	{
		// Token: 0x0600DD19 RID: 56601 RVA: 0x0020DC57 File Offset: 0x0020BE57
		[NullableContext(1)]
		public static ITeleportTransitionWithCustomLoading Create(ITeleportTransitionWithCustomLoading? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCustomLoading
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041B3 RID: 16819
		// (get) Token: 0x0600DD1A RID: 56602 RVA: 0x0020DC76 File Offset: 0x0020BE76
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170041B4 RID: 16820
		// (get) Token: 0x0600DD1B RID: 56603 RVA: 0x0020DC83 File Offset: 0x0020BE83
		public virtual int ConfigId
		{
			get
			{
				return this.Instance.ConfigId;
			}
		}

		// Token: 0x04007ACE RID: 31438
		private ITeleportTransitionWithCustomLoading Instance;
	}
}
