using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Qte;
using AkiClient.Game.Aki.Data.QuickTimeAction;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.QuickTimeAction.Context;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02003EF6 RID: 16118
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class QtaController : ControllerBase
	{
		// Token: 0x06028E5D RID: 167517 RVA: 0x00B7A5F4 File Offset: 0x00B787F4
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<int?>(EEventName.CommonQteStart, new Action<int?>(this.OnCommonQteStart));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			return true;
		}

		// Token: 0x06028E5E RID: 167518 RVA: 0x00B7A62F File Offset: 0x00B7882F
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.CommonQteStart, new Action<int?>(this.OnCommonQteStart));
			EventSystem.Instance.Remove(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			return true;
		}

		// Token: 0x06028E5F RID: 167519 RVA: 0x00B7A66A File Offset: 0x00B7886A
		protected override bool OnLeaveLevel()
		{
			this.ClearAll();
			return true;
		}

		// Token: 0x06028E60 RID: 167520 RVA: 0x00B7A673 File Offset: 0x00B78873
		protected override bool OnChangeMode()
		{
			this.ClearAll();
			return true;
		}

		// Token: 0x06028E61 RID: 167521 RVA: 0x00B7A67C File Offset: 0x00B7887C
		private void OnCommonQteStart(int? handleId)
		{
			if (this.IsInQta())
			{
				this.StopCurrentQta();
			}
		}

		// Token: 0x06028E62 RID: 167522 RVA: 0x00B7A68C File Offset: 0x00B7888C
		[NullableContext(2)]
		private void OnTeleportComplete(TeleportContext _)
		{
			if (this.IsInQta())
			{
				QtaContextBase context = this.Context;
				if (context != null && context.IsActive())
				{
					QtaContextBase context2 = this.Context;
					if (context2 != null && context2.IsPending())
					{
						this.SetQtaTimeDilation(this.Context.Config.BaseConfig.TimeDilation);
					}
				}
			}
		}

		// Token: 0x06028E63 RID: 167523 RVA: 0x00B7A6E4 File Offset: 0x00B788E4
		public void RecoverTimeDilationAfterTeleport()
		{
			if (this.IsInQta())
			{
				QtaContextBase context = this.Context;
				if (context != null && context.IsActive())
				{
					QtaContextBase context2 = this.Context;
					if (context2 != null && context2.IsPending())
					{
						this.SetQtaTimeDilation(this.Context.Config.BaseConfig.TimeDilation);
					}
				}
			}
		}

		// Token: 0x06028E64 RID: 167524 RVA: 0x00B7A73C File Offset: 0x00B7893C
		private void ClearAll()
		{
			if (this.IsInQta())
			{
				this.ResetQtaTimeDilation();
			}
			this.ClearQta();
		}

		// Token: 0x06028E65 RID: 167525 RVA: 0x00B7A754 File Offset: 0x00B78954
		[NullableContext(2)]
		public QtaContextBase StartQta(int qtaId, TQtaCallback onResult = null, EQtaSource source = EQtaSource.Battle, IQtaExtraParams extraParams = null)
		{
			string text = null;
			if (this.IsInQta())
			{
				SQta qtaConfig = QtaModel.Instance.GetQtaConfig(qtaId);
				int num = (qtaConfig != null) ? qtaConfig.Priority : 0;
				QtaContextBase context = this.Context;
				int num2 = (context != null) ? context.QtaPriority : 0;
				if (num > num2 && this.Context != null)
				{
					this.StopCurrentQta();
				}
				else if (num < num2 && this.Context != null)
				{
					text = "当前存在优先级更高的执行中的Qta, 无法开始新的Qta";
				}
				else
				{
					text = "当前存在执行中的Qta, 无法开始新的Qta";
				}
			}
			else if (this.IsPreloadingQta)
			{
				text = "Qta预加载中, 无法开始新的Qta";
			}
			if (!string.IsNullOrEmpty(text))
			{
				QtaLog.Info(this.Context, text, default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				SQta qtaConfig2 = QtaModel.Instance.GetQtaConfig(qtaId);
				if (qtaConfig2 != null && qtaConfig2.AutonomousOnly)
				{
					CharacterActorComponent characterActorComponent;
					if (extraParams == null)
					{
						characterActorComponent = null;
					}
					else
					{
						EntityHandle entityHandle = extraParams.EntityHandle;
						if (entityHandle == null)
						{
							characterActorComponent = null;
						}
						else
						{
							WorldEntity entity = entityHandle.Entity;
							characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
						}
					}
					CharacterActorComponent characterActorComponent2 = characterActorComponent;
					if (characterActorComponent2 != null && !characterActorComponent2.IsMyRoleAndCtrlByMe())
					{
						QtaContextBase context2 = this.Context;
						string message = "Qta开始失败, 配置了仅主控端可执行";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("qtaId", qtaId);
						QtaLog.Info(context2, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return null;
					}
				}
			}
			BaseSkillComponent baseSkillComponent;
			if (extraParams == null)
			{
				baseSkillComponent = null;
			}
			else
			{
				EntityHandle entityHandle2 = extraParams.EntityHandle;
				if (entityHandle2 == null)
				{
					baseSkillComponent = null;
				}
				else
				{
					WorldEntity entity2 = entityHandle2.Entity;
					baseSkillComponent = ((entity2 != null) ? entity2.GetComponent<BaseSkillComponent>() : null);
				}
			}
			BaseSkillComponent baseSkillComponent2 = baseSkillComponent;
			if (baseSkillComponent2 != null)
			{
				if (extraParams.FromSkill != null)
				{
					int? fromSkill = extraParams.FromSkill;
					int num3 = 0;
					if (!(fromSkill.GetValueOrDefault() == num3 & fromSkill != null))
					{
						goto IL_195;
					}
				}
				Skill currentSkill = baseSkillComponent2.CurrentSkill;
				extraParams.FromSkill = new int?((currentSkill != null) ? currentSkill.SkillId : 0);
			}
			IL_195:
			QtaContextBase qtaContextBase = QtaModel.Instance.CreateQtaContext(qtaId, onResult, source, extraParams);
			if (qtaContextBase == null)
			{
				return null;
			}
			if (this.StartQtaInternal(qtaContextBase))
			{
				return qtaContextBase;
			}
			return null;
		}

		// Token: 0x06028E66 RID: 167526 RVA: 0x00B7A918 File Offset: 0x00B78B18
		private unsafe bool StartQtaInternal(QtaContextBase context)
		{
			QtaLog.Info(context, "Qta开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			QtaModel.Instance.SetCurrentQta(context);
			int qtaId = context.QtaId;
			this.IsInQtaInner = true;
			this.Context = context;
			this.QtaPromptPlayer.SetQtaContext(context);
			string itemName = QtaModel.Instance.GetQtaItemName(qtaId);
			SQta config = context.Config;
			if (config != null)
			{
				if (config.BaseConfig.IsBlockFightInput)
				{
					this.AddFightInputBlock(EUiViewName.QtaView);
				}
				this.QtaPromptPlayer.PlayEffect(EQtaPromptType.Qta开始, context.HandleId);
				this.QtaPromptPlayer.StartUiEffect(config.BaseConfig);
				this.SetQtaTimeDilation(config.BaseConfig.TimeDilation);
			}
			InputManager.Instance.PauseImmersiveMouseMode(EImmersiveMouseModeReason.Qta, true, true, false);
			EventSystem.Instance.Emit<int>(EEventName.QtaStart, this.Context.HandleId);
			int num = 1;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int index = 0;
			*span[index] = qtaId;
			this.PreloadQtaRes(list, context.HandleId, false).ContinueWith(delegate(bool success)
			{
				bool flag;
				if (this.IsInQtaInner)
				{
					QtaContextBase context2 = this.Context;
					int? num2 = (context2 != null) ? new int?(context2.HandleId) : null;
					int handleId = context.HandleId;
					flag = (num2.GetValueOrDefault() == handleId & num2 != null);
				}
				else
				{
					flag = false;
				}
				bool flag2 = flag;
				if (!flag2)
				{
					QtaContextBase context3 = context;
					string message = "Qta预加载完成后, Qta已结束或已过期";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsInQta", this.IsInQtaInner);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isQtaValid", flag2);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("itemName", itemName ?? string.Empty);
					QtaLog.Info(context3, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					QtaItemBase valueOrDefault = this.QtaItemMap.GetValueOrDefault(qtaId);
					if (valueOrDefault != null && !valueOrDefault.IsDestroyOrDestroying)
					{
						valueOrDefault.Destroy(null);
					}
					this.QtaItemMap.Remove(qtaId);
					QtaModel.Instance.ClearPreloadCache(new int?(qtaId));
					return;
				}
				if (success)
				{
					QtaItemBase valueOrDefault2 = this.QtaItemMap.GetValueOrDefault(qtaId);
					if (valueOrDefault2 != null)
					{
						context.Resource = QtaModel.Instance.GetQtaPromptObj(qtaId);
						context.UiActor = valueOrDefault2.GetRootActor();
						context.OnResourceReady();
						valueOrDefault2.SetQtaContext(context);
						valueOrDefault2.PlayQtaStart();
						context.OnQtaReady();
						this.QtaPromptPlayer.PlayEffect(EQtaPromptType.Qta开始, context.HandleId);
						return;
					}
					if (context.IsQtaView())
					{
						context.Resource = QtaModel.Instance.GetQtaPromptObj(qtaId);
						context.OnResourceReady();
						context.OnQtaReady();
						this.QtaPromptPlayer.PlayEffect(EQtaPromptType.Qta开始, context.HandleId);
						return;
					}
					if (context.IsNoUi())
					{
						context.Resource = QtaModel.Instance.GetQtaPromptObj(qtaId);
						context.OnResourceReady();
						context.OnQtaReady();
						this.QtaPromptPlayer.PlayEffect(EQtaPromptType.Qta开始, context.HandleId);
						return;
					}
				}
				QtaContextBase context4 = context;
				string message2 = "Qta加载失败, 停止当前Qta";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ItemName", itemName ?? string.Empty);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Success", success);
				QtaLog.Info(context4, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				this.OnQtaEnd(false);
			});
			return true;
		}

		// Token: 0x06028E67 RID: 167527 RVA: 0x00B7AA90 File Offset: 0x00B78C90
		public void SetExpiredTimer(QtaContextBase context)
		{
			this.RemoveExpiredTimer();
			int currentValue = (int)Math.Floor((double)(context.IsPermanent ? 60000f : (context.Duration + 5000f)));
			this.ExpiredTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				if (context.IsSuccess())
				{
					context.SetQtaResult(EQtaResult.Fail);
					return;
				}
				this.OnQtaEnd(false);
			}, (float)MathUtils.Instance.Clamp(currentValue, 20, 180000), null, null, true, 1f);
		}

		// Token: 0x06028E68 RID: 167528 RVA: 0x00B7AB1C File Offset: 0x00B78D1C
		public void EnableExternalConditionMet(int qtaHandle, EQtaExternalReason reason)
		{
			QtaContextBase context = this.Context;
			int? num = (context != null) ? new int?(context.HandleId) : null;
			if (!(qtaHandle == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			QtaContextBase context2 = this.Context;
			if (context2 == null)
			{
				return;
			}
			context2.EnableExternalConditionMet(reason);
		}

		// Token: 0x06028E69 RID: 167529 RVA: 0x00B7AB70 File Offset: 0x00B78D70
		public void OnExternalConditionMet(int qtaHandle, EQtaExternalReason reason)
		{
			QtaContextBase context = this.Context;
			int? num = (context != null) ? new int?(context.HandleId) : null;
			if (!(qtaHandle == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			QtaContextBase context2 = this.Context;
			if (context2 == null)
			{
				return;
			}
			context2.OnExternalConditionMet(reason);
		}

		// Token: 0x06028E6A RID: 167530 RVA: 0x00B7ABC3 File Offset: 0x00B78DC3
		public int GetCurrentQtaHandleId()
		{
			if (this.Context != null)
			{
				return this.Context.HandleId;
			}
			return -1;
		}

		// Token: 0x06028E6B RID: 167531 RVA: 0x00B7ABDC File Offset: 0x00B78DDC
		public void ResolveQta(int qtaHandle)
		{
			QtaContextBase context = this.Context;
			int? num = (context != null) ? new int?(context.HandleId) : null;
			if (!(qtaHandle == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			QtaContextBase context2 = this.Context;
			if (context2 != null)
			{
				context2.OnPreEndQta();
			}
			if (this.Context != null)
			{
				this.OnQtaEnd(false);
			}
		}

		// Token: 0x06028E6C RID: 167532 RVA: 0x00B7AC40 File Offset: 0x00B78E40
		public void StopQta(int qtaHandle, bool ignoreResultAction = false)
		{
			QtaContextBase context = this.Context;
			int? num = (context != null) ? new int?(context.HandleId) : null;
			if (!(qtaHandle == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.OnQtaEnd(ignoreResultAction);
		}

		// Token: 0x06028E6D RID: 167533 RVA: 0x00B7AC89 File Offset: 0x00B78E89
		public void StopQtaByResult(EQtaResult result)
		{
			if (this.Context == null)
			{
				return;
			}
			this.Context.SetQtaResult(result);
			this.OnQtaEnd(false);
		}

		// Token: 0x06028E6E RID: 167534 RVA: 0x00B7ACA7 File Offset: 0x00B78EA7
		public void StopCurrentQta()
		{
			if (this.Context != null)
			{
				this.OnQtaEnd(false);
			}
		}

		// Token: 0x06028E6F RID: 167535 RVA: 0x00B7ACB8 File Offset: 0x00B78EB8
		private unsafe void OnQtaEnd(bool ignoreResultAction = false)
		{
			QtaContextBase context = this.Context;
			string message = "Qta结束";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ig", ignoreResultAction);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "state";
			QtaContextBase context2 = this.Context;
			ptr = new ValueTuple<string, object>(item, (context2 != null) ? new EQtaState?(context2.State) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item2 = "result";
			QtaContextBase context3 = this.Context;
			ptr2 = new ValueTuple<string, object>(item2, (context3 != null) ? new EQtaResult?(context3.ResultType) : null);
			ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item3 = "pendingResult";
			QtaContextBase context4 = this.Context;
			ptr3 = new ValueTuple<string, object>(item3, (context4 != null) ? new EQtaResult?(context4.PendingResultType) : null);
			QtaLog.Info(context, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			this.ResetQtaTimeDilation();
			QtaContextBase context5 = this.Context;
			if (context5 != null && context5.QtaViewName != null)
			{
				EUiViewName value = this.Context.QtaViewName.Value;
				if (UiManager.Instance.IsViewShow(value))
				{
					UiManager.Instance.CloseView(value, null);
				}
			}
			QtaContextBase context6 = this.Context;
			SQta sqta = (context6 != null) ? context6.GetConfig() : null;
			if (sqta != null && sqta.HandleFailWhenInvalidStop && this.Context != null && !this.Context.IsEnd())
			{
				this.Context.ForceEnd();
			}
			if (sqta != null && sqta.EndSkillWhenDeactive)
			{
				QtaContextBase context7 = this.Context;
				if (context7 != null && context7.ResultType == EQtaResult.DeactiveConditionMet)
				{
					QtaContextBase context8 = this.Context;
					IQtaExtraParams qtaExtraParams = (context8 != null) ? context8.ExtraParams : null;
					int? num = (qtaExtraParams != null) ? qtaExtraParams.FromSkill : null;
					if (num != null && num.GetValueOrDefault() != 0)
					{
						EntityHandle entityHandle = qtaExtraParams.EntityHandle;
						if (entityHandle != null)
						{
							WorldEntity entity = entityHandle.Entity;
							if (entity != null)
							{
								BaseSkillComponent component = entity.GetComponent<BaseSkillComponent>();
								if (component != null)
								{
									component.EndSkill(qtaExtraParams.FromSkill.Value, "Qta:结束源技能, 原因是失活");
								}
							}
						}
					}
				}
			}
			if (sqta != null && this.Context.IsEnd() && !ignoreResultAction)
			{
				EQtaResult resultType = this.Context.ResultType;
				this.QtaPromptPlayer.PlayEffectByResult(resultType, this.Context.HandleId);
				IQtaExtraParams extraParams = this.Context.ExtraParams;
				SQta config = this.Context.Config;
				if (config != null && config.EndActiveSkill && ((extraParams != null) ? extraParams.FromSkill : null).GetValueOrDefault() != 0)
				{
					EntityHandle entityHandle2 = extraParams.EntityHandle;
					BaseSkillComponent baseSkillComponent;
					if (entityHandle2 == null)
					{
						baseSkillComponent = null;
					}
					else
					{
						WorldEntity entity2 = entityHandle2.Entity;
						baseSkillComponent = ((entity2 != null) ? entity2.GetComponent<BaseSkillComponent>() : null);
					}
					BaseSkillComponent baseSkillComponent2 = baseSkillComponent;
					if (baseSkillComponent2 != null)
					{
						baseSkillComponent2.EndSkill(extraParams.FromSkill.Value, "Qta:结束掉激活Qta时的技能");
					}
				}
				TArray<SBattleQteAction> resultActions = this.Context.GetResultActions(resultType);
				if (resultActions != null)
				{
					bool flag;
					if (extraParams == null)
					{
						flag = (null != null);
					}
					else
					{
						EntityHandle entityHandle3 = extraParams.EntityHandle;
						flag = (((entityHandle3 != null) ? entityHandle3.Entity : null) != null);
					}
					if (flag)
					{
						QtaContextBase context9 = this.Context;
						string message2 = "Qta结束动作";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ret", resultType);
						QtaLog.Info(context9, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
						defaultInterpolatedStringHandler.AppendLiteral("Qta结束时执行的动作 qtaId:");
						QtaContextBase context10 = this.Context;
						defaultInterpolatedStringHandler.AppendFormatted<int?>((context10 != null) ? new int?(context10.QtaId) : null);
						defaultInterpolatedStringHandler.AppendLiteral(" ret:");
						QtaContextBase context11 = this.Context;
						defaultInterpolatedStringHandler.AppendFormatted<EQtaResult?>((context11 != null) ? new EQtaResult?(context11.ResultType) : null);
						string tips = defaultInterpolatedStringHandler.ToStringAndClear();
						BattleQteContext.HandleActionTest(resultActions, extraParams.EntityHandle.Entity, extraParams.MessageId, tips);
					}
				}
			}
			QtaContextBase context12 = this.Context;
			InputManager.Instance.ResumeImmersiveMouseMode(EImmersiveMouseModeReason.Qta);
			QtaModel.Instance.ClearQtaHandleId(null);
			this.ClearQta();
			EventSystem.Instance.Emit<int?>(EEventName.QtaEnd, (context12 != null) ? new int?(context12.HandleId) : null);
		}

		// Token: 0x06028E70 RID: 167536 RVA: 0x00B7B0FC File Offset: 0x00B792FC
		public void PauseQta(int handleId)
		{
			if (this.Context == null || handleId != this.Context.HandleId)
			{
				return;
			}
			if (this.ExpiredTimer != null && !this.ExpiredTimer.IsPause())
			{
				this.ExpiredTimer.Pause();
			}
		}

		// Token: 0x06028E71 RID: 167537 RVA: 0x00B7B138 File Offset: 0x00B79338
		public void ResumeQta(int handleId)
		{
			if (this.Context == null || handleId != this.Context.HandleId)
			{
				return;
			}
			if (this.ExpiredTimer != null && this.ExpiredTimer.IsPause())
			{
				this.ExpiredTimer.Resume();
			}
			this.SetQtaTimeDilation(this.Context.Config.BaseConfig.TimeDilation);
			this.ResumeFightInputBlock();
		}

		// Token: 0x06028E72 RID: 167538 RVA: 0x00B7B19E File Offset: 0x00B7939E
		public bool IsInQta()
		{
			return this.IsInQtaInner;
		}

		// Token: 0x06028E73 RID: 167539 RVA: 0x00B7B1A6 File Offset: 0x00B793A6
		public bool IsPreloading()
		{
			return this.IsPreloadingQta;
		}

		// Token: 0x06028E74 RID: 167540 RVA: 0x00B7B1AE File Offset: 0x00B793AE
		public void PlayEffect(EQtaPromptType promptType, int qtaHandle)
		{
			this.QtaPromptPlayer.PlayEffect(promptType, qtaHandle);
		}

		// Token: 0x06028E75 RID: 167541 RVA: 0x00B7B1BD File Offset: 0x00B793BD
		public void StopEffect(int qtaHandle)
		{
			this.QtaPromptPlayer.StopEffect(qtaHandle);
		}

		// Token: 0x06028E76 RID: 167542 RVA: 0x00B7B1CC File Offset: 0x00B793CC
		public void OnQtaMoment(int handleId, EQtaMomentName moment)
		{
			if (this.Context == null || handleId != this.Context.HandleId)
			{
				return;
			}
			QtaItemBase valueOrDefault = this.QtaItemMap.GetValueOrDefault(this.Context.QtaId);
			if (valueOrDefault != null)
			{
				valueOrDefault.OnQtaMoment(moment);
			}
		}

		// Token: 0x06028E77 RID: 167543 RVA: 0x00B7B214 File Offset: 0x00B79414
		public void ClearQta()
		{
			this.RemoveFightInputBlock();
			this.RemoveExpiredTimer();
			this.QtaPromptPlayer.RemoveEffect();
			this.IsInQtaInner = false;
			this.IsPreloadingQta = false;
			this.IsSetQtaTimeDilation = false;
			QtaContextBase context = this.Context;
			if (context != null)
			{
				context.Clear();
			}
			this.Context = null;
			this.ClearPreloadQtaRes();
		}

		// Token: 0x06028E78 RID: 167544 RVA: 0x00B7B26B File Offset: 0x00B7946B
		private void RemoveExpiredTimer()
		{
			if (this.ExpiredTimer != null)
			{
				TimerSystem.Instance.Remove(this.ExpiredTimer);
			}
			this.ExpiredTimer = null;
		}

		// Token: 0x06028E79 RID: 167545 RVA: 0x00B7B290 File Offset: 0x00B79490
		public void SetQtaTimeDilation(float timeDilation)
		{
			if (!this.IsInQta())
			{
				return;
			}
			GameModeModel instance = GameModeModel.Instance;
			if (instance != null && instance.IsMulti)
			{
				return;
			}
			if (timeDilation == 0f)
			{
				return;
			}
			TeleportModel instance2 = TeleportModel.Instance;
			if (instance2 != null && instance2.IsTeleport)
			{
				return;
			}
			if (Time.Instance.TimeDilation != 0f)
			{
				this.IsSetQtaTimeDilation = true;
				GameModeController.Instance.SetTimeDilation(timeDilation, ETimeDilationType.Default);
			}
		}

		// Token: 0x06028E7A RID: 167546 RVA: 0x00B7B2FB File Offset: 0x00B794FB
		public void ResetQtaTimeDilation()
		{
			if (!this.IsSetQtaTimeDilation)
			{
				return;
			}
			this.IsSetQtaTimeDilation = false;
			GameModeController.Instance.SetTimeDilation(1f, ETimeDilationType.Default);
		}

		// Token: 0x06028E7B RID: 167547 RVA: 0x00B7B320 File Offset: 0x00B79520
		[NullableContext(0)]
		private UniTask<bool> PreloadQtaRes([Nullable(1)] List<int> qtaIdList, int preloadHandle = -1, bool isGroupQta = false)
		{
			QtaController.<PreloadQtaRes>d__41 <PreloadQtaRes>d__;
			<PreloadQtaRes>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PreloadQtaRes>d__.<>4__this = this;
			<PreloadQtaRes>d__.qtaIdList = qtaIdList;
			<PreloadQtaRes>d__.preloadHandle = preloadHandle;
			<PreloadQtaRes>d__.<>1__state = -1;
			<PreloadQtaRes>d__.<>t__builder.Start<QtaController.<PreloadQtaRes>d__41>(ref <PreloadQtaRes>d__);
			return <PreloadQtaRes>d__.<>t__builder.Task;
		}

		// Token: 0x06028E7C RID: 167548 RVA: 0x00B7B374 File Offset: 0x00B79574
		public void ClearPreloadQtaRes()
		{
			foreach (QtaItemBase qtaItemBase in this.QtaItemMap.Values)
			{
				if (!qtaItemBase.IsDestroyOrDestroying)
				{
					qtaItemBase.Destroy(null);
				}
			}
			this.QtaItemMap.Clear();
			QtaModel.Instance.ClearPreloadCache(null);
		}

		// Token: 0x06028E7D RID: 167549 RVA: 0x00B7B3F4 File Offset: 0x00B795F4
		private void AddFightInputBlock(EUiViewName viewName)
		{
			if (this.FightInputBlockViewName != null)
			{
				return;
			}
			this.FightInputBlockViewName = new EUiViewName?(viewName);
			InputDistributeModel instance = InputDistributeModel.Instance;
			if (instance != null)
			{
				instance.PreventIgnoredActionRelease(true, viewName);
			}
			InputDistributeModel instance2 = InputDistributeModel.Instance;
			if (instance2 != null)
			{
				instance2.AddNotAllowFightInputViewName(viewName);
			}
			EventSystem.Instance.Emit(EEventName.OnAddNotAllowFightInputViewName);
		}

		// Token: 0x06028E7E RID: 167550 RVA: 0x00B7B454 File Offset: 0x00B79654
		private void RemoveFightInputBlock()
		{
			if (this.FightInputBlockViewName == null)
			{
				return;
			}
			InputDistributeModel instance = InputDistributeModel.Instance;
			if (instance != null)
			{
				instance.PreventIgnoredActionRelease(false, this.FightInputBlockViewName.Value);
			}
			InputDistributeModel instance2 = InputDistributeModel.Instance;
			if (instance2 != null)
			{
				instance2.RemoveNotAllowFightInputViewName(this.FightInputBlockViewName.Value);
			}
			EventSystem.Instance.Emit(EEventName.OnRemoveNotAllowFightInputViewName);
			this.FightInputBlockViewName = null;
		}

		// Token: 0x06028E7F RID: 167551 RVA: 0x00B7B4C8 File Offset: 0x00B796C8
		private void ResumeFightInputBlock()
		{
			if (this.FightInputBlockViewName == null)
			{
				return;
			}
			InputDistributeModel instance = InputDistributeModel.Instance;
			if (instance == null || !instance.HasNotAllowFightInputViewIsOpen(this.FightInputBlockViewName.Value))
			{
				InputDistributeModel instance2 = InputDistributeModel.Instance;
				if (instance2 != null)
				{
					instance2.AddNotAllowFightInputViewName(this.FightInputBlockViewName.Value);
				}
				EventSystem.Instance.Emit(EEventName.OnAddNotAllowFightInputViewName);
			}
		}

		// Token: 0x170052F4 RID: 21236
		// (get) Token: 0x06028E80 RID: 167552 RVA: 0x00B7B52F File Offset: 0x00B7972F
		public static QtaController Instance
		{
			get
			{
				return QtaController._Instance;
			}
		}

		// Token: 0x06028E81 RID: 167553 RVA: 0x00B7B536 File Offset: 0x00B79736
		public static QtaController GetOrCreateInstance()
		{
			if (QtaController._Instance == null)
			{
				QtaController.CreateInstance();
			}
			return QtaController._Instance;
		}

		// Token: 0x06028E82 RID: 167554 RVA: 0x00B7B54A File Offset: 0x00B7974A
		public static bool CreateInstance()
		{
			if (QtaController._Instance != null)
			{
				return true;
			}
			QtaController._Instance = new QtaController();
			return true;
		}

		// Token: 0x06028E83 RID: 167555 RVA: 0x00B7B560 File Offset: 0x00B79760
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028E84 RID: 167556 RVA: 0x00B7B562 File Offset: 0x00B79762
		public static void ResetStaticDefaultValue()
		{
			QtaController._Instance = null;
		}

		// Token: 0x06028E85 RID: 167557 RVA: 0x00B7B56A File Offset: 0x00B7976A
		static QtaController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QtaController.CreateStaticDefaultValue), new Action(QtaController.ResetStaticDefaultValue));
		}

		// Token: 0x06028E86 RID: 167558 RVA: 0x00B7B589 File Offset: 0x00B79789
		public QtaController()
		{
			Dictionary<string, Type> dictionary = new Dictionary<string, Type>();
			dictionary["UiItem_CircularLimitedLongPress"] = typeof(QtaCustomizationLimitedHoldItem);
			this.defQtaItemClasses = dictionary;
			this.QtaItemMap = new Dictionary<int, QtaItemBase>();
			this.QtaPromptPlayer = new QtaPromptPlayer();
			base..ctor();
		}

		// Token: 0x040163A7 RID: 91047
		private const int EXTRA_EXPIRED_TIME = 5000;

		// Token: 0x040163A8 RID: 91048
		private const int MAX_EXPIRED_TIME = 60000;

		// Token: 0x040163A9 RID: 91049
		private readonly Dictionary<string, Type> defQtaItemClasses;

		// Token: 0x040163AA RID: 91050
		[Nullable(2)]
		private QtaContextBase Context;

		// Token: 0x040163AB RID: 91051
		private bool IsInQtaInner;

		// Token: 0x040163AC RID: 91052
		[Nullable(2)]
		private TimerHandle ExpiredTimer;

		// Token: 0x040163AD RID: 91053
		private bool IsPreloadingQta;

		// Token: 0x040163AE RID: 91054
		private readonly Dictionary<int, QtaItemBase> QtaItemMap;

		// Token: 0x040163AF RID: 91055
		private EUiViewName? FightInputBlockViewName;

		// Token: 0x040163B0 RID: 91056
		private bool IsSetQtaTimeDilation;

		// Token: 0x040163B1 RID: 91057
		private readonly QtaPromptPlayer QtaPromptPlayer;

		// Token: 0x040163B2 RID: 91058
		[Nullable(2)]
		private static QtaController _Instance;
	}
}
