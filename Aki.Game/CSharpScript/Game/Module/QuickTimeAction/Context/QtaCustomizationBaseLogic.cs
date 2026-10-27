using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02004F42 RID: 20290
	[NullableContext(2)]
	[Nullable(0)]
	public class QtaCustomizationBaseLogic
	{
		// Token: 0x06034069 RID: 213097 RVA: 0x00C3358C File Offset: 0x00C3178C
		[NullableContext(1)]
		public virtual void OnSetConfig(QtaCustomizationContext qtaContext, SQta qtaConfig, BP_QtaCustomizationBase_C daConfig)
		{
		}

		// Token: 0x0603406A RID: 213098 RVA: 0x00C3358E File Offset: 0x00C3178E
		public virtual void OnQtaStart()
		{
		}

		// Token: 0x0603406B RID: 213099 RVA: 0x00C33590 File Offset: 0x00C31790
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> OnGetActions()
		{
			return null;
		}

		// Token: 0x0603406C RID: 213100 RVA: 0x00C33593 File Offset: 0x00C31793
		public virtual float GetProgress()
		{
			return 0f;
		}

		// Token: 0x0603406D RID: 213101 RVA: 0x00C3359A File Offset: 0x00C3179A
		public virtual float GetBgProgress(int index = 0)
		{
			return 0f;
		}

		// Token: 0x0603406E RID: 213102 RVA: 0x00C335A1 File Offset: 0x00C317A1
		public virtual void OnQtaResponse(bool press = true)
		{
		}

		// Token: 0x0603406F RID: 213103 RVA: 0x00C335A3 File Offset: 0x00C317A3
		public virtual void OnUpdateTime(float delta)
		{
		}

		// Token: 0x06034070 RID: 213104 RVA: 0x00C335A5 File Offset: 0x00C317A5
		public virtual bool CheckQtaCanEnd()
		{
			return false;
		}

		// Token: 0x06034071 RID: 213105 RVA: 0x00C335A8 File Offset: 0x00C317A8
		protected virtual bool CheckIsValid()
		{
			return false;
		}

		// Token: 0x06034072 RID: 213106 RVA: 0x00C335AC File Offset: 0x00C317AC
		public virtual void OnPreEndQta()
		{
			if (this.QtaContext == null)
			{
				return;
			}
			if (this.QtaContext.IsEnd())
			{
				return;
			}
			if (this.QtaContext.HasResult())
			{
				this.QtaContext.SetQtaResult(this.QtaContext.PendingResultType);
				return;
			}
			this.QtaContext.SetQtaResult(this.CheckIsValid() ? EQtaResult.Success : EQtaResult.Fail);
		}

		// Token: 0x06034073 RID: 213107 RVA: 0x00C3360B File Offset: 0x00C3180B
		public virtual void OnQtaEnd(bool success = false)
		{
		}

		// Token: 0x0401BA20 RID: 113184
		protected SQta QtaConfig;

		// Token: 0x0401BA21 RID: 113185
		protected QtaCustomizationContext QtaContext;

		// Token: 0x0401BA22 RID: 113186
		protected float PassTime;
	}
}
