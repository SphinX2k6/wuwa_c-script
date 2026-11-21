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
	// Token: 0x02003F0D RID: 16141
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaCustomizationNull : QtaCustomizationBaseLogic
	{
		// Token: 0x06028EF8 RID: 167672 RVA: 0x00B7D6B4 File Offset: 0x00B7B8B4
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

		// Token: 0x06028EF9 RID: 167673 RVA: 0x00B7D7A0 File Offset: 0x00B7B9A0
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

		// Token: 0x06028EFA RID: 167674 RVA: 0x00B7D818 File Offset: 0x00B7BA18
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

		// Token: 0x06028EFB RID: 167675 RVA: 0x00B7D898 File Offset: 0x00B7BA98
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

		// Token: 0x06028EFC RID: 167676 RVA: 0x00B7D918 File Offset: 0x00B7BB18
		private void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
		{
			if (this.QtaContext != null && this.QtaContext.IsActive() && this.QtaContext.IsPending())
			{
				this.QtaContext.QtaResponse(actionType == InputDistributeDefine.EActionType.Press);
			}
		}

		// Token: 0x06028EFD RID: 167677 RVA: 0x00B7D94B File Offset: 0x00B7BB4B
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> OnGetActions()
		{
			return this.Actions;
		}

		// Token: 0x06028EFE RID: 167678 RVA: 0x00B7D953 File Offset: 0x00B7BB53
		public override void OnQtaResponse(bool press = true)
		{
			if (press)
			{
				this.OnResponseStart();
				return;
			}
			this.OnResponseEnd();
		}

		// Token: 0x06028EFF RID: 167679 RVA: 0x00B7D968 File Offset: 0x00B7BB68
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

		// Token: 0x06028F00 RID: 167680 RVA: 0x00B7D9D1 File Offset: 0x00B7BBD1
		private void OnResponseEnd()
		{
			if (this.QtaContext != null)
			{
				QtaController.Instance.PlayEffect(EQtaPromptType.抬起提示, this.QtaContext.HandleId);
				this.CheckCanEnd();
			}
		}

		// Token: 0x06028F01 RID: 167681 RVA: 0x00B7D9F8 File Offset: 0x00B7BBF8
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

		// Token: 0x06028F02 RID: 167682 RVA: 0x00B7DA5B File Offset: 0x00B7BC5B
		public override float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06028F03 RID: 167683 RVA: 0x00B7DA62 File Offset: 0x00B7BC62
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

		// Token: 0x06028F04 RID: 167684 RVA: 0x00B7DA95 File Offset: 0x00B7BC95
		protected override bool CheckIsValid()
		{
			return false;
		}

		// Token: 0x06028F05 RID: 167685 RVA: 0x00B7DA98 File Offset: 0x00B7BC98
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

		// Token: 0x06028F06 RID: 167686 RVA: 0x00B7DAEC File Offset: 0x00B7BCEC
		private bool CheckCanEndInner()
		{
			return false;
		}

		// Token: 0x06028F07 RID: 167687 RVA: 0x00B7DAEF File Offset: 0x00B7BCEF
		public override void OnQtaEnd(bool success = false)
		{
			if (this.TimeoutHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimeoutHandle);
				this.TimeoutHandle = null;
			}
			this.UnbindAction();
		}

		// Token: 0x04016406 RID: 91142
		private readonly List<string> Actions = new List<string>();

		// Token: 0x04016407 RID: 91143
		[Nullable(2)]
		private TimerHandle TimeoutHandle;

		// Token: 0x04016408 RID: 91144
		private bool HasBindAction;
	}
}
