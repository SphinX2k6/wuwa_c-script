using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02003F14 RID: 16148
	[NullableContext(2)]
	[Nullable(0)]
	public class QtaCustomizationContext : QtaContextBase
	{
		// Token: 0x06028F4D RID: 167757 RVA: 0x00B7E87D File Offset: 0x00B7CA7D
		public QtaCustomizationContext()
		{
			this.Type = new EQtaContextType?(EQtaContextType.Customization);
		}

		// Token: 0x170052FF RID: 21247
		// (get) Token: 0x06028F4E RID: 167758 RVA: 0x00B7E891 File Offset: 0x00B7CA91
		public bool IsInited
		{
			get
			{
				return this.Inited;
			}
		}

		// Token: 0x17005300 RID: 21248
		// (get) Token: 0x06028F4F RID: 167759 RVA: 0x00B7E899 File Offset: 0x00B7CA99
		public QtaCustomizationBaseLogic QtaCustomizationLogic
		{
			get
			{
				if (this.QtaCzLogic == null)
				{
					return null;
				}
				return this.QtaCzLogic;
			}
		}

		// Token: 0x06028F50 RID: 167760 RVA: 0x00B7E8AB File Offset: 0x00B7CAAB
		[NullableContext(1)]
		protected override void OnSetConfig(SQta config)
		{
			this.QtaConfig = config;
		}

		// Token: 0x06028F51 RID: 167761 RVA: 0x00B7E8B4 File Offset: 0x00B7CAB4
		public override void OnResourceReady()
		{
			SQta qtaConfig = this.QtaConfig;
			if (qtaConfig == null)
			{
				QtaLog.Error(this, "Qta定制型：缺少配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				QtaController.Instance.StopCurrentQta();
				return;
			}
			if (qtaConfig.BaseConfig.QtaType != EQtaType.定制型)
			{
				QtaLog.Error(this, "Qta定制型：传入的类型不正确", default(ReadOnlySpan<ValueTuple<string, object>>));
				QtaController.Instance.StopCurrentQta();
				return;
			}
			TSoftObjectPtr<BP_QtaCustomizationBase_C> daConfig = qtaConfig.BaseConfig.CustomizationConfig.DaConfig;
			if (!daConfig.IsValid())
			{
				QtaLog.Error(this, "Qta定制型：缺少DA配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				QtaController.Instance.StopCurrentQta();
				return;
			}
			BP_QtaCustomizationBase_C loadedAsset = ResourceSystem.Instance.GetLoadedAsset<BP_QtaCustomizationBase_C>(daConfig.ToAssetPathName());
			if (loadedAsset == null)
			{
				string message = "Qta定制型：DA未加载或类型不正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("", daConfig.ToAssetPathName());
				QtaLog.Error(this, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				QtaController.Instance.StopCurrentQta();
				return;
			}
			if (loadedAsset is BP_QtaCustomization_LimitedHold_C)
			{
				this.QtaCzLogic = new QtaCustomizationLimitedHoldLogic();
			}
			else if (loadedAsset != null)
			{
				this.QtaCzLogic = new QtaCustomizationNull();
			}
			if (this.QtaCzLogic == null)
			{
				QtaLog.Error(this, "Qta定制型：未正确初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				QtaController.Instance.StopCurrentQta();
				return;
			}
			this.QtaCzLogic.OnSetConfig(this, qtaConfig, loadedAsset);
			this.QtaCzLogic.OnQtaStart();
			this.Inited = true;
			QtaLog.Info(this, "Qta定制型：成功初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06028F52 RID: 167762 RVA: 0x00B7EA25 File Offset: 0x00B7CC25
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		protected override List<string> OnGetActions()
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			if (qtaCzLogic == null)
			{
				return null;
			}
			return qtaCzLogic.OnGetActions();
		}

		// Token: 0x06028F53 RID: 167763 RVA: 0x00B7EA38 File Offset: 0x00B7CC38
		protected override void OnQtaResponse(bool press)
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			if (qtaCzLogic == null)
			{
				return;
			}
			qtaCzLogic.OnQtaResponse(press);
		}

		// Token: 0x06028F54 RID: 167764 RVA: 0x00B7EA4B File Offset: 0x00B7CC4B
		protected override void OnUpdateTime(float delta)
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			if (qtaCzLogic == null)
			{
				return;
			}
			qtaCzLogic.OnUpdateTime(delta);
		}

		// Token: 0x06028F55 RID: 167765 RVA: 0x00B7EA5E File Offset: 0x00B7CC5E
		public override float GetProgress()
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			if (qtaCzLogic == null)
			{
				return 0f;
			}
			return qtaCzLogic.GetProgress();
		}

		// Token: 0x06028F56 RID: 167766 RVA: 0x00B7EA75 File Offset: 0x00B7CC75
		protected override bool CheckQtaCanEnd()
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			return qtaCzLogic != null && qtaCzLogic.CheckQtaCanEnd();
		}

		// Token: 0x06028F57 RID: 167767 RVA: 0x00B7EA88 File Offset: 0x00B7CC88
		public override void OnPreEndQta()
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			if (qtaCzLogic == null)
			{
				return;
			}
			qtaCzLogic.OnPreEndQta();
		}

		// Token: 0x06028F58 RID: 167768 RVA: 0x00B7EA9A File Offset: 0x00B7CC9A
		protected override void OnQtaResult(EQtaResult qtaResult)
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			if (qtaCzLogic == null)
			{
				return;
			}
			qtaCzLogic.OnQtaEnd(qtaResult == EQtaResult.Success);
		}

		// Token: 0x04016435 RID: 91189
		private SQta QtaConfig;

		// Token: 0x04016436 RID: 91190
		private QtaCustomizationBaseLogic QtaCzLogic;

		// Token: 0x04016437 RID: 91191
		private bool Inited;
	}
}
