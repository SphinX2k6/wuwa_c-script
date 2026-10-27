using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02006E0D RID: 28173
	[NullableContext(2)]
	[Nullable(0)]
	public class GuaranteeActionBase
	{
		// Token: 0x06044B5B RID: 281435 RVA: 0x010F57BE File Offset: 0x010F39BE
		[NullableContext(1)]
		public void Execute(GuaranteeActionInfo actionInfo, GuaranteeContext context)
		{
			this.ActionInfo = actionInfo;
			this.Context = context;
			this.OnExecute(actionInfo.Params);
		}

		// Token: 0x06044B5C RID: 281436 RVA: 0x010F57DA File Offset: 0x010F39DA
		public void Clear(ActionParams @params = null, GeneralContext instigatorContext = null)
		{
			this.OnClear(@params, instigatorContext);
		}

		// Token: 0x06044B5D RID: 281437 RVA: 0x010F57E4 File Offset: 0x010F39E4
		protected virtual void OnExecute(ActionParams @params = null)
		{
		}

		// Token: 0x06044B5E RID: 281438 RVA: 0x010F57E6 File Offset: 0x010F39E6
		protected virtual void OnClear(ActionParams @params = null, GeneralContext instigatorContext = null)
		{
		}

		// Token: 0x04023BE9 RID: 146409
		public EGuaranteeAction Type;

		// Token: 0x04023BEA RID: 146410
		protected GuaranteeActionInfo ActionInfo;

		// Token: 0x04023BEB RID: 146411
		protected GuaranteeContext Context;
	}
}
