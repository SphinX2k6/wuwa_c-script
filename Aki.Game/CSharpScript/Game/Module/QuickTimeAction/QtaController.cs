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
	// Token: 0x02004F2D RID: 20269
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class QtaController : ControllerBase
	{
		// Token: 0x06033FEF RID: 212975 RVA: 0x00C30E54 File Offset: 0x00C2F054
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<int?>(EEventName.CommonQteStart, new Action<int?>(this.OnCommonQteStart));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			return true;
		}

		// Token: 0x06033FF0 RID: 212976 RVA: 0x00C30E8F File Offset: 0x00C2F08F
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.CommonQteStart, new Action<int?>(this.OnCommonQteStart));
			EventSystem.Instance.Remove(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			return true;
		}

		// Token: 0x06033FF1 RID: 212977 RVA: 0x00C30ECA File Offset: 0x00C2F0CA
		protected override bool OnLeaveLevel()
		{
			this.ClearAll();
			return true;
		}

		// Token: 0x06033FF2 RID: 212978 RVA: 0x00C30ED3 File Offset: 0x00C2F0D3
		protected override bool OnChangeMode()
		{
			this.ClearAll();
			return true;
		}

		// Token: 0x06033FF3 RID: 212979 RVA: 0x00C30EDC File Offset: 0x00C2F0DC
		private void OnCommonQteStart(int? handleId)
		{
			if (this.IsInQta())
			{
				this.StopCurrentQta();
			}
		}

		// Token: 0x06033FF4 RID: 212980 RVA: 0x00C30EEC File Offset: 0x00C2F0EC
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

		// Token: 0x06033FF5 RID: 212981 RVA: 0x00C30F44 File Offset: 0x00C2F144
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

		// Token: 0x06033FF6 RID: 212982 RVA: 0x00C30F9C File Offset: 0x00C2F19C
		private void ClearAll()
		{
			if (this.IsInQta())
			{
				this.ResetQtaTimeDilation();
			}
			this.ClearQta();
		}

		// Token: 0x06033FF7 RID: 212983 RVA: 0x00C30FB4 File Offset: 0x00C2F1B4
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

		// Token: 0x06033FF8 RID: 212984 RVA: 0x00C31178 File Offset: 0x00C2F378
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

		// Token: 0x06033FF9 RID: 212985 RVA: 0x00C312F0 File Offset: 0x00C2F4F0
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

		// Token: 0x06033FFA RID: 212986 RVA: 0x00C3137C File Offset: 0x00C2F57C
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

		// Token: 0x06033FFB RID: 212987 RVA: 0x00C313D0 File Offset: 0x00C2F5D0
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

		// Token: 0x06033FFC RID: 212988 RVA: 0x00C31423 File Offset: 0x00C2F623
		public int GetCurrentQtaHandleId()
		{
			if (this.Context != null)
			{
				return this.Context.HandleId;
			}
			return -1;
		}

		// Token: 0x06033FFD RID: 212989 RVA: 0x00C3143C File Offset: 0x00C2F63C
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

		// Token: 0x06033FFE RID: 212990 RVA: 0x00C314A0 File Offset: 0x00C2F6A0
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

		// Token: 0x06033FFF RID: 212991 RVA: 0x00C314E9 File Offset: 0x00C2F6E9
		public void StopQtaByResult(EQtaResult result)
		{
			if (this.Context == null)
			{
				return;
			}
			this.Context.SetQtaResult(result);
			this.OnQtaEnd(false);
		}

		// Token: 0x06034000 RID: 212992 RVA: 0x00C31507 File Offset: 0x00C2F707
		public void StopCurrentQta()
		{
			if (this.Context != null)
			{
				this.OnQtaEnd(false);
			}
		}

		// Token: 0x06034001 RID: 212993 RVA: 0x00C31518 File Offset: 0x00C2F718
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

		// Token: 0x06034002 RID: 212994 RVA: 0x00C3195C File Offset: 0x00C2FB5C
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

		// Token: 0x06034003 RID: 212995 RVA: 0x00C31998 File Offset: 0x00C2FB98
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

		// Token: 0x06034004 RID: 212996 RVA: 0x00C319FE File Offset: 0x00C2FBFE
		public bool IsInQta()
		{
			return this.IsInQtaInner;
		}

		// Token: 0x06034005 RID: 212997 RVA: 0x00C31A06 File Offset: 0x00C2FC06
		public bool IsPreloading()
		{
			return this.IsPreloadingQta;
		}

		// Token: 0x06034006 RID: 212998 RVA: 0x00C31A0E File Offset: 0x00C2FC0E
		public void PlayEffect(EQtaPromptType promptType, int qtaHandle)
		{
			this.QtaPromptPlayer.PlayEffect(promptType, qtaHandle);
		}

		// Token: 0x06034007 RID: 212999 RVA: 0x00C31A1D File Offset: 0x00C2FC1D
		public void StopEffect(int qtaHandle)
		{
			this.QtaPromptPlayer.StopEffect(qtaHandle);
		}

		// Token: 0x06034008 RID: 213000 RVA: 0x00C31A2C File Offset: 0x00C2FC2C
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

		// Token: 0x06034009 RID: 213001 RVA: 0x00C31A74 File Offset: 0x00C2FC74
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

		// Token: 0x0603400A RID: 213002 RVA: 0x00C31ACB File Offset: 0x00C2FCCB
		private void RemoveExpiredTimer()
		{
			if (this.ExpiredTimer != null)
			{
				TimerSystem.Instance.Remove(this.ExpiredTimer);
			}
			this.ExpiredTimer = null;
		}

		// Token: 0x0603400B RID: 213003 RVA: 0x00C31AF0 File Offset: 0x00C2FCF0
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

		// Token: 0x0603400C RID: 213004 RVA: 0x00C31B5B File Offset: 0x00C2FD5B
		public void ResetQtaTimeDilation()
		{
			if (!this.IsSetQtaTimeDilation)
			{
				return;
			}
			this.IsSetQtaTimeDilation = false;
			GameModeController.Instance.SetTimeDilation(1f, ETimeDilationType.Default);
		}

		// Token: 0x0603400D RID: 213005 RVA: 0x00C31B80 File Offset: 0x00C2FD80
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

		// Token: 0x0603400E RID: 213006 RVA: 0x00C31BD4 File Offset: 0x00C2FDD4
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

		// Token: 0x0603400F RID: 213007 RVA: 0x00C31C54 File Offset: 0x00C2FE54
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

		// Token: 0x06034010 RID: 213008 RVA: 0x00C31CB4 File Offset: 0x00C2FEB4
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

		// Token: 0x06034011 RID: 213009 RVA: 0x00C31D28 File Offset: 0x00C2FF28
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

		// Token: 0x17007F44 RID: 32580
		// (get) Token: 0x06034012 RID: 213010 RVA: 0x00C31D8F File Offset: 0x00C2FF8F
		public static QtaController Instance
		{
			get
			{
				return QtaController._Instance;
			}
		}

		// Token: 0x06034013 RID: 213011 RVA: 0x00C31D96 File Offset: 0x00C2FF96
		public static QtaController GetOrCreateInstance()
		{
			if (QtaController._Instance == null)
			{
				QtaController.CreateInstance();
			}
			return QtaController._Instance;
		}

		// Token: 0x06034014 RID: 213012 RVA: 0x00C31DAA File Offset: 0x00C2FFAA
		public static bool CreateInstance()
		{
			if (QtaController._Instance != null)
			{
				return true;
			}
			QtaController._Instance = new QtaController();
			return true;
		}

		// Token: 0x06034015 RID: 213013 RVA: 0x00C31DC0 File Offset: 0x00C2FFC0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034016 RID: 213014 RVA: 0x00C31DC2 File Offset: 0x00C2FFC2
		public static void ResetStaticDefaultValue()
		{
			QtaController._Instance = null;
		}

		// Token: 0x06034017 RID: 213015 RVA: 0x00C31DCA File Offset: 0x00C2FFCA
		static QtaController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QtaController.CreateStaticDefaultValue), new Action(QtaController.ResetStaticDefaultValue));
		}

		// Token: 0x06034018 RID: 213016 RVA: 0x00C31DE9 File Offset: 0x00C2FFE9
		public QtaController()
		{
			Dictionary<string, Type> dictionary = new Dictionary<string, Type>();
			dictionary["UiItem_CircularLimitedLongPress"] = typeof(QtaCustomizationLimitedHoldItem);
			this.defQtaItemClasses = dictionary;
			this.QtaItemMap = new Dictionary<int, QtaItemBase>();
			this.QtaPromptPlayer = new QtaPromptPlayer();
			base..ctor();
		}

		// Token: 0x0401B9D2 RID: 113106
		private const int EXTRA_EXPIRED_TIME = 5000;

		// Token: 0x0401B9D3 RID: 113107
		private const int MAX_EXPIRED_TIME = 60000;

		// Token: 0x0401B9D4 RID: 113108
		private readonly Dictionary<string, Type> defQtaItemClasses;

		// Token: 0x0401B9D5 RID: 113109
		[Nullable(2)]
		private QtaContextBase Context;

		// Token: 0x0401B9D6 RID: 113110
		private bool IsInQtaInner;

		// Token: 0x0401B9D7 RID: 113111
		[Nullable(2)]
		private TimerHandle ExpiredTimer;

		// Token: 0x0401B9D8 RID: 113112
		private bool IsPreloadingQta;

		// Token: 0x0401B9D9 RID: 113113
		private readonly Dictionary<int, QtaItemBase> QtaItemMap;

		// Token: 0x0401B9DA RID: 113114
		private EUiViewName? FightInputBlockViewName;

		// Token: 0x0401B9DB RID: 113115
		private bool IsSetQtaTimeDilation;

		// Token: 0x0401B9DC RID: 113116
		private readonly QtaPromptPlayer QtaPromptPlayer;

		// Token: 0x0401B9DD RID: 113117
		[Nullable(2)]
		private static QtaController _Instance;
	}
}
