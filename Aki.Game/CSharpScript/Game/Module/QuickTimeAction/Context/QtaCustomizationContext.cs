using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02004F4B RID: 20299
	[NullableContext(2)]
	[Nullable(0)]
	public class QtaCustomizationContext : QtaContextBase
	{
		// Token: 0x060340DF RID: 213215 RVA: 0x00C350DD File Offset: 0x00C332DD
		public QtaCustomizationContext()
		{
			this.Type = new EQtaContextType?(EQtaContextType.Customization);
		}

		// Token: 0x17007F4F RID: 32591
		// (get) Token: 0x060340E0 RID: 213216 RVA: 0x00C350F1 File Offset: 0x00C332F1
		public bool IsInited
		{
			get
			{
				return this.Inited;
			}
		}

		// Token: 0x17007F50 RID: 32592
		// (get) Token: 0x060340E1 RID: 213217 RVA: 0x00C350F9 File Offset: 0x00C332F9
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

		// Token: 0x060340E2 RID: 213218 RVA: 0x00C3510B File Offset: 0x00C3330B
		[NullableContext(1)]
		protected override void OnSetConfig(SQta config)
		{
			this.QtaConfig = config;
		}

		// Token: 0x060340E3 RID: 213219 RVA: 0x00C35114 File Offset: 0x00C33314
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

		// Token: 0x060340E4 RID: 213220 RVA: 0x00C35285 File Offset: 0x00C33485
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

		// Token: 0x060340E5 RID: 213221 RVA: 0x00C35298 File Offset: 0x00C33498
		protected override void OnQtaResponse(bool press)
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			if (qtaCzLogic == null)
			{
				return;
			}
			qtaCzLogic.OnQtaResponse(press);
		}

		// Token: 0x060340E6 RID: 213222 RVA: 0x00C352AB File Offset: 0x00C334AB
		protected override void OnUpdateTime(float delta)
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			if (qtaCzLogic == null)
			{
				return;
			}
			qtaCzLogic.OnUpdateTime(delta);
		}

		// Token: 0x060340E7 RID: 213223 RVA: 0x00C352BE File Offset: 0x00C334BE
		public override float GetProgress()
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			if (qtaCzLogic == null)
			{
				return 0f;
			}
			return qtaCzLogic.GetProgress();
		}

		// Token: 0x060340E8 RID: 213224 RVA: 0x00C352D5 File Offset: 0x00C334D5
		protected override bool CheckQtaCanEnd()
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			return qtaCzLogic != null && qtaCzLogic.CheckQtaCanEnd();
		}

		// Token: 0x060340E9 RID: 213225 RVA: 0x00C352E8 File Offset: 0x00C334E8
		public override void OnPreEndQta()
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			if (qtaCzLogic == null)
			{
				return;
			}
			qtaCzLogic.OnPreEndQta();
		}

		// Token: 0x060340EA RID: 213226 RVA: 0x00C352FA File Offset: 0x00C334FA
		protected override void OnQtaResult(EQtaResult qtaResult)
		{
			QtaCustomizationBaseLogic qtaCzLogic = this.QtaCzLogic;
			if (qtaCzLogic == null)
			{
				return;
			}
			qtaCzLogic.OnQtaEnd(qtaResult == EQtaResult.Success);
		}

		// Token: 0x0401BA60 RID: 113248
		private SQta QtaConfig;

		// Token: 0x0401BA61 RID: 113249
		private QtaCustomizationBaseLogic QtaCzLogic;

		// Token: 0x0401BA62 RID: 113250
		private bool Inited;
	}
}
