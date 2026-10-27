using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200139B RID: 5019
	public class IRogueAbilitySelect : IShowUi
	{
		// Token: 0x060072BF RID: 29375 RVA: 0x00113C0E File Offset: 0x00111E0E
		[NullableContext(1)]
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

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x060072C0 RID: 29376 RVA: 0x00113C2D File Offset: 0x00111E2D
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x060072C1 RID: 29377 RVA: 0x00113C3A File Offset: 0x00111E3A
		public virtual ERogueAbilityType AbilityType
		{
			get
			{
				return (ERogueAbilityType)this.Instance.AbilityType;
			}
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x060072C2 RID: 29378 RVA: 0x00113C47 File Offset: 0x00111E47
		public virtual int BindId
		{
			get
			{
				return this.Instance.BindId;
			}
		}

		// Token: 0x04004259 RID: 16985
		private IRogueAbilitySelect Instance;
	}
}
