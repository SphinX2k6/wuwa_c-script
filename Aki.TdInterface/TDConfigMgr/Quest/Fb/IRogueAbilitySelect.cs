using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014EC RID: 5356
	public class IRogueAbilitySelect : IShowUi
	{
		// Token: 0x06007966 RID: 31078 RVA: 0x001222CA File Offset: 0x001204CA
		public static IRogueAbilitySelect Create(IRogueAbilitySelect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueAbilitySelect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x06007967 RID: 31079 RVA: 0x001222E9 File Offset: 0x001204E9
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x06007968 RID: 31080 RVA: 0x001222F6 File Offset: 0x001204F6
		public virtual ERogueAbilityType AbilityType
		{
			get
			{
				return (ERogueAbilityType)this.Instance.AbilityType;
			}
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x06007969 RID: 31081 RVA: 0x00122303 File Offset: 0x00120503
		public virtual int BindId
		{
			get
			{
				return this.Instance.BindId;
			}
		}

		// Token: 0x040045DA RID: 17882
		private IRogueAbilitySelect Instance;
	}
}
