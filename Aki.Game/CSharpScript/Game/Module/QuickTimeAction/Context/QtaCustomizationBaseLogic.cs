using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02003F0B RID: 16139
	[NullableContext(2)]
	[Nullable(0)]
	public class QtaCustomizationBaseLogic
	{
		// Token: 0x06028ED7 RID: 167639 RVA: 0x00B7CD2C File Offset: 0x00B7AF2C
		[NullableContext(1)]
		public virtual void OnSetConfig(QtaCustomizationContext qtaContext, SQta qtaConfig, BP_QtaCustomizationBase_C daConfig)
		{
		}

		// Token: 0x06028ED8 RID: 167640 RVA: 0x00B7CD2E File Offset: 0x00B7AF2E
		public virtual void OnQtaStart()
		{
		}

		// Token: 0x06028ED9 RID: 167641 RVA: 0x00B7CD30 File Offset: 0x00B7AF30
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> OnGetActions()
		{
			return null;
		}

		// Token: 0x06028EDA RID: 167642 RVA: 0x00B7CD33 File Offset: 0x00B7AF33
		public virtual float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06028EDB RID: 167643 RVA: 0x00B7CD3A File Offset: 0x00B7AF3A
		public virtual float GetBgProgress(int index = 0)
		{
			return 0f;
		}

		// Token: 0x06028EDC RID: 167644 RVA: 0x00B7CD41 File Offset: 0x00B7AF41
		public virtual void OnQtaResponse(bool press = true)
		{
		}

		// Token: 0x06028EDD RID: 167645 RVA: 0x00B7CD43 File Offset: 0x00B7AF43
		public virtual void OnUpdateTime(float delta)
		{
		}

		// Token: 0x06028EDE RID: 167646 RVA: 0x00B7CD45 File Offset: 0x00B7AF45
		public virtual bool CheckQtaCanEnd()
		{
			return false;
		}

		// Token: 0x06028EDF RID: 167647 RVA: 0x00B7CD48 File Offset: 0x00B7AF48
		protected virtual bool CheckIsValid()
		{
			return false;
		}

		// Token: 0x06028EE0 RID: 167648 RVA: 0x00B7CD4C File Offset: 0x00B7AF4C
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

		// Token: 0x06028EE1 RID: 167649 RVA: 0x00B7CDAB File Offset: 0x00B7AFAB
		public virtual void OnQtaEnd(bool success = false)
		{
		}

		// Token: 0x040163F5 RID: 91125
		protected SQta QtaConfig;

		// Token: 0x040163F6 RID: 91126
		protected QtaCustomizationContext QtaContext;

		// Token: 0x040163F7 RID: 91127
		protected float PassTime;
	}
}
