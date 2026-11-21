using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02005F8D RID: 24461
	[NullableContext(2)]
	[Nullable(0)]
	public class GuaranteeActionBase
	{
		// Token: 0x0603ACC1 RID: 240833 RVA: 0x0109FB7E File Offset: 0x0109DD7E
		[NullableContext(1)]
		public void Execute(GuaranteeActionInfo actionInfo, GuaranteeContext context)
		{
			this.ActionInfo = actionInfo;
			this.Context = context;
			this.OnExecute(actionInfo.Params);
		}

		// Token: 0x0603ACC2 RID: 240834 RVA: 0x0109FB9A File Offset: 0x0109DD9A
		public void Clear(ActionParams @params = null, GeneralContext instigatorContext = null)
		{
			this.OnClear(@params, instigatorContext);
		}

		// Token: 0x0603ACC3 RID: 240835 RVA: 0x0109FBA4 File Offset: 0x0109DDA4
		protected virtual void OnExecute(ActionParams @params = null)
		{
		}

		// Token: 0x0603ACC4 RID: 240836 RVA: 0x0109FBA6 File Offset: 0x0109DDA6
		protected virtual void OnClear(ActionParams @params = null, GeneralContext instigatorContext = null)
		{
		}

		// Token: 0x0401EE8C RID: 126604
		public EGuaranteeAction Type;

		// Token: 0x0401EE8D RID: 126605
		protected GuaranteeActionInfo ActionInfo;

		// Token: 0x0401EE8E RID: 126606
		protected GuaranteeContext Context;
	}
}
