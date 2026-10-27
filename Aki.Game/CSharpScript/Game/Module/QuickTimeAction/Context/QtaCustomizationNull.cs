using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using AkiClient.Game.Aki.Data.QuickTimeAction;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02004F44 RID: 20292
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaCustomizationNull : QtaCustomizationBaseLogic
	{
		// Token: 0x0603408A RID: 213130 RVA: 0x00C33F14 File Offset: 0x00C32114
		public override void OnSetConfig(QtaCustomizationContext qtaContext, SQta qtaConfig, BP_QtaCustomizationBase_C daConfig)
		{
			if (qtaConfig == null || daConfig == null)
			{
				QtaLog.Error(qtaContext, "占位用Qta初始化：缺少配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				QtaController.Instance.StopCurrentQta();
				return;
			}
			if (daConfig == null)
			{
				QtaLog.Error(qtaContext, "占位用Qta初始化：配置的DA类型不正确", default(ReadOnlySpan<ValueTuple<string, object>>));
				QtaController.Instance.StopCurrentQta();
				return;
			}
			this.QtaConfig = qtaConfig;
			this.QtaContext = qtaContext;
			this.Actions.Clear();
			for (int i = 0; i < qtaConfig.BaseConfig.InputConfig.Num(); i++)
			{
				SCommonQteButton scommonQteButton = qtaConfig.BaseConfig.InputConfig.Get(i);
				TEnumAsByte<ECommonQteInputAction>? tenumAsByte = (scommonQteButton != null) ? new TEnumAsByte<ECommonQteInputAction>?(scommonQteButton.Action) : null;
				int index = (int)((tenumAsByte != null) ? tenumAsByte.GetValueOrDefault() : 0);
				if (QtaActionNames.Has(index))
				{
					this.Actions.Add(QtaActionNames.Get(index));
				}
			}
		}

		// Token: 0x0603408B RID: 213131 RVA: 0x00C34000 File Offset: 0x00C32200
		public override void OnQtaStart()
		{
			this.BindAction();
			if (this.QtaConfig.BaseConfig.Duration > 0f)
			{
				this.TimeoutHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					QtaCustomizationContext qtaContext = this.QtaContext;
					if (qtaContext == null)
					{
						return;
					}
					qtaContext.SetQtaResult(EQtaResult.Timeout);
				}, this.QtaConfig.BaseConfig.Duration * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, this.QtaConfig.BaseConfig.TimeDilation);
			}
		}

		// Token: 0x0603408C RID: 213132 RVA: 0x00C34078 File Offset: 0x00C32278
		private void BindAction()
		{
			if (this.HasBindAction)
			{
				return;
			}
			this.HasBindAction = true;
			if (!Info.Instance.IsInTouch())
			{
				foreach (string actionName in this.Actions)
				{
					InputDistributeController.Instance.BindActionIgnoreLimit(actionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
				}
			}
		}

		// Token: 0x0603408D RID: 213133 RVA: 0x00C340F8 File Offset: 0x00C322F8
		private void UnbindAction()
		{
			if (!this.HasBindAction)
			{
				return;
			}
			this.HasBindAction = false;
			if (!Info.Instance.IsInTouch())
			{
				foreach (string actionName in this.Actions)
				{
					InputDistributeController.Instance.UnBindActionIgnoreLimit(actionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
				}
			}
		}

		// Token: 0x0603408E RID: 213134 RVA: 0x00C34178 File Offset: 0x00C32378
		private void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
		{
			if (this.QtaContext != null && this.QtaContext.IsActive() && this.QtaContext.IsPending())
			{
				this.QtaContext.QtaResponse(actionType == InputDistributeDefine.EActionType.Press);
			}
		}

		// Token: 0x0603408F RID: 213135 RVA: 0x00C341AB File Offset: 0x00C323AB
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> OnGetActions()
		{
			return this.Actions;
		}

		// Token: 0x06034090 RID: 213136 RVA: 0x00C341B3 File Offset: 0x00C323B3
		public override void OnQtaResponse(bool press = true)
		{
			if (press)
			{
				this.OnResponseStart();
				return;
			}
			this.OnResponseEnd();
		}

		// Token: 0x06034091 RID: 213137 RVA: 0x00C341C8 File Offset: 0x00C323C8
		private void OnResponseStart()
		{
			if (this.QtaConfig == null || this.QtaContext == null)
			{
				return;
			}
			if (!this.QtaContext.IsPending() && !this.QtaContext.IsPendingSuccess())
			{
				return;
			}
			if (this.QtaContext.IsPending())
			{
				QtaController.Instance.PlayEffect(EQtaPromptType.按下提示, this.QtaContext.HandleId);
			}
			this.CheckCanEnd();
		}

		// Token: 0x06034092 RID: 213138 RVA: 0x00C34231 File Offset: 0x00C32431
		private void OnResponseEnd()
		{
			if (this.QtaContext != null)
			{
				QtaController.Instance.PlayEffect(EQtaPromptType.抬起提示, this.QtaContext.HandleId);
				this.CheckCanEnd();
			}
		}

		// Token: 0x06034093 RID: 213139 RVA: 0x00C34258 File Offset: 0x00C32458
		public override void OnUpdateTime(float delta)
		{
			if (this.QtaContext == null)
			{
				QtaController.Instance.StopCurrentQta();
				return;
			}
			this.PassTime += delta;
			if (this.CheckCanEnd())
			{
				return;
			}
			if (!this.QtaContext.IsPermanent && this.PassTime > this.QtaContext.Duration)
			{
				this.QtaContext.SetQtaResult(EQtaResult.Timeout);
			}
		}

		// Token: 0x06034094 RID: 213140 RVA: 0x00C342BB File Offset: 0x00C324BB
		public override float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06034095 RID: 213141 RVA: 0x00C342C2 File Offset: 0x00C324C2
		private bool CheckCanEnd()
		{
			if (this.QtaContext.State != EQtaState.Pending)
			{
				return true;
			}
			if (this.CheckCanEndInner())
			{
				this.QtaContext.SetQtaResult(this.CheckIsValid() ? EQtaResult.Success : EQtaResult.Fail);
				return true;
			}
			return false;
		}

		// Token: 0x06034096 RID: 213142 RVA: 0x00C342F5 File Offset: 0x00C324F5
		protected override bool CheckIsValid()
		{
			return false;
		}

		// Token: 0x06034097 RID: 213143 RVA: 0x00C342F8 File Offset: 0x00C324F8
		public override void OnPreEndQta()
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
			this.QtaContext.SetQtaResult(EQtaResult.Success);
		}

		// Token: 0x06034098 RID: 213144 RVA: 0x00C3434C File Offset: 0x00C3254C
		private bool CheckCanEndInner()
		{
			return false;
		}

		// Token: 0x06034099 RID: 213145 RVA: 0x00C3434F File Offset: 0x00C3254F
		public override void OnQtaEnd(bool success = false)
		{
			if (this.TimeoutHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimeoutHandle);
				this.TimeoutHandle = null;
			}
			this.UnbindAction();
		}

		// Token: 0x0401BA31 RID: 113201
		private readonly List<string> Actions = new List<string>();

		// Token: 0x0401BA32 RID: 113202
		[Nullable(2)]
		private TimerHandle TimeoutHandle;

		// Token: 0x0401BA33 RID: 113203
		private bool HasBindAction;
	}
}
