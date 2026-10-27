using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Debug;
using AkiClient.Game.Aki.Character.BaseCharacter;
using Google.Protobuf;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02005BB0 RID: 23472
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillMessageController : ControllerBase
	{
		// Token: 0x0603B5CC RID: 243148 RVA: 0x00E28975 File Offset: 0x00E26B75
		public void AddSkillMessageId(long message)
		{
			this.SkillCombatMessageSet.Add(message);
		}

		// Token: 0x0603B5CD RID: 243149 RVA: 0x00E28984 File Offset: 0x00E26B84
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.DebugFightErrInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.GetDebugFightErrInfo));
			return true;
		}

		// Token: 0x0603B5CE RID: 243150 RVA: 0x00E289A3 File Offset: 0x00E26BA3
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.DebugFightErrInfoNotify);
			this.SkillCombatMessageSet.Clear();
			return true;
		}

		// Token: 0x0603B5CF RID: 243151 RVA: 0x00E289C4 File Offset: 0x00E26BC4
		[NullableContext(2)]
		[CombatPreprocess(ENotifyMessageId.UseSkillNotify)]
		public static bool PreUseSkillNotify(Entity entity, [Nullable(1)] UseSkillNotify notify, CombatCommon combatCommon = null)
		{
			CharacterFightStateComponent characterFightStateComponent = (entity != null) ? entity.GetComponent<CharacterFightStateComponent>() : null;
			if (characterFightStateComponent != null)
			{
				CharacterFightStateComponent characterFightStateComponent2 = characterFightStateComponent;
				UseSkillInformation useSkillInfo = notify.UseSkillInfo;
				if (!characterFightStateComponent2.PreSwitchRemoteFightState((useSkillInfo != null) ? useSkillInfo.FightState : 0))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603B5D0 RID: 243152 RVA: 0x00E28A00 File Offset: 0x00E26C00
		[NullableContext(2)]
		[CombatListen(ENotifyMessageId.UseSkillNotify, true, true)]
		public static void UseSkillNotify(Entity entity, UseSkillNotify data, CombatCommon combatCommon = null)
		{
			if (entity == null || data == null || data.UseSkillInfo == null || data.UseSkillInfo.SkillId == 0L)
			{
				Log.Instance.Error(ELogModule.MultiplayerCombat, ELogAuthor.WCL, "[CreatureController.UseSkillNotify] 服务器返回参数有误。", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			long messageId = combatCommon.MessageId;
			BaseSkillComponent component = entity.GetComponent<BaseSkillComponent>();
			long targetId = data.UseSkillInfo.TargetId;
			if (component != null && component.SimulatedBeginSkill((int)data.UseSkillInfo.SkillId, targetId, data.UseSkillInfo.IsSpecialSkill, (float)data.UseSkillInfo.Duration * 0.001f, messageId))
			{
				SkillMessageController.Instance.SkillCombatMessageSet.Add(messageId);
			}
		}

		// Token: 0x0603B5D1 RID: 243153 RVA: 0x00E28AAC File Offset: 0x00E26CAC
		[NullableContext(2)]
		[CombatListen(ENotifyMessageId.SkillNotify, true, true)]
		public static void SkillNotify(Entity entity, [Nullable(1)] SkillNotify data, CombatCommon combatCommon = null)
		{
			BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
			if (baseSkillComponent == null)
			{
				Log.Instance.Error(ELogModule.MultiplayerCombat, ELogAuthor.WCL, "[CreatureController.SkillNotify] 不存在skillComponent。", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			long preMessageId = combatCommon.PreMessageId;
			if (!SkillMessageController.Instance.SkillCombatMessageSet.Contains(preMessageId))
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
				string message = "技能释放未被确认，拒绝其后续行为";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("技能Id", data.UseSkillInfo.SkillId);
				instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (data.SkillNodeInfos.SubProtocol == 1)
			{
				long messageId = combatCommon.MessageId;
				baseSkillComponent.SimulatePlayMontage((int)data.UseSkillInfo.SkillId, data.SkillNodeInfos.MontageIndex, data.SkillNodeInfos.SpeedRatio, data.SkillNodeInfos.StartSection, data.SkillNodeInfos.StartTimeSeconds, messageId);
			}
		}

		// Token: 0x0603B5D2 RID: 243154 RVA: 0x00E28B90 File Offset: 0x00E26D90
		[NullableContext(2)]
		[CombatListen(ENotifyMessageId.EndSkillNotify, true, true)]
		public static void EndSkillNotify(Entity entity, EndSkillNotify data, CombatCommon combatCommon = null)
		{
			if (data.UseSkillInfo == null)
			{
				Log.Instance.Error(ELogModule.World, ELogAuthor.LFJW, "[CreatureController.EndSkillNotify] 服务器返回参数有误。", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			long preMessageId = combatCommon.PreMessageId;
			SkillMessageController.Instance.SkillCombatMessageSet.Remove(preMessageId);
			BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
			if (baseSkillComponent == null)
			{
				return;
			}
			baseSkillComponent.SimulateEndSkill((int)data.UseSkillInfo.SkillId);
		}

		// Token: 0x0603B5D3 RID: 243155 RVA: 0x00E28BFC File Offset: 0x00E26DFC
		public bool UseSkillRequest(Entity entity, Skill skill, int targetId)
		{
			BaseSkillComponent skillComp = entity.GetComponent<BaseSkillComponent>();
			if (skillComp == null)
			{
				return false;
			}
			int skillId = skill.SkillId;
			SSkillInfo skillInfo = skill.SkillInfo;
			bool isSpecialSkill = skillInfo != null && skillInfo.AutonomouslyBySimulate;
			SSkillInfo skillInfo2 = skill.SkillInfo;
			float num = (skillInfo2 != null) ? skillInfo2.MoveControllerTime : 0f;
			int interruptLevel = skill.InterruptLevel;
			long? preContextId = skill.PreContextId;
			long? combatMessageId = skill.CombatMessageId;
			UseSkillRequest useSkillRequest = new UseSkillRequest();
			useSkillRequest.UseSkillInfo = new UseSkillInformation
			{
				SkillId = (long)skillId,
				TargetId = CreatureModel.Instance.GetCreatureDataId(targetId),
				TimeStamp = (float)Time.Instance.NowSeconds,
				IsSpecialSkill = isSpecialSkill,
				Duration = (int)(num * 1000f),
				SkillInterruptLevel = interruptLevel
			};
			ISkillBattleContext battleContext = skill.BattleContext;
			if (((battleContext != null) ? battleContext.BattleFlags : null) != null)
			{
				foreach (string tagName in skill.BattleContext.BattleFlags)
				{
					int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
					useSkillRequest.BattleFlags.Add(tagIdByName);
				}
			}
			int fightStateHandle = skill.FightStateHandle;
			if (fightStateHandle != 0)
			{
				UseSkillInformation useSkillInfo = useSkillRequest.UseSkillInfo;
				CharacterFightStateComponent fightStateComp = skillComp.FightStateComp;
				useSkillInfo.FightState = ((fightStateComp != null) ? fightStateComp.GetFightState() : 0);
			}
			CombatNet.Instance.Call(ERequestMessageId.UseSkillRequest, entity, useSkillRequest, delegate(IMessage msg)
			{
				UseSkillResponse useSkillResponse = (UseSkillResponse)msg;
				if (entity.IsEnd)
				{
					return;
				}
				if (useSkillResponse != null && useSkillResponse.ErrorCode == ErrorCode.Success)
				{
					if (fightStateHandle != 0)
					{
						BaseSkillComponent skillComp;
						CharacterFightStateComponent fightStateComp2 = skillComp.FightStateComp;
						if (fightStateComp2 == null)
						{
							return;
						}
						fightStateComp2.ConfirmState(fightStateHandle);
						return;
					}
				}
				else
				{
					CombatLog instance = CombatLog.Instance;
					CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
					Entity entity2 = entity;
					string message = "技能释放服务器拒绝，技能终止";
					string item = "技能Id";
					long? num2;
					if (useSkillResponse == null)
					{
						num2 = null;
					}
					else
					{
						UseSkillInformation useSkillInfo2 = useSkillResponse.UseSkillInfo;
						num2 = ((useSkillInfo2 != null) ? new long?(useSkillInfo2.SkillId) : null);
					}
					long? num3 = num2;
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, num3.GetValueOrDefault());
					instance.Info(flag, entity2, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					BaseSkillComponent skillComp = skillComp;
					long? num4;
					if (useSkillResponse == null)
					{
						num4 = null;
					}
					else
					{
						UseSkillInformation useSkillInfo3 = useSkillResponse.UseSkillInfo;
						num4 = ((useSkillInfo3 != null) ? new long?(useSkillInfo3.SkillId) : null);
					}
					num3 = num4;
					skillComp.EndSkill((int)num3.GetValueOrDefault(), "SkillMessageController.UseSkillRequest");
				}
			}, preContextId, combatMessageId, null, null);
			return true;
		}

		// Token: 0x0603B5D4 RID: 243156 RVA: 0x00E28DB8 File Offset: 0x00E26FB8
		public bool EndSkillRequest(Entity entity, int skillId, EndSkillInfo endSkillInfo)
		{
			if (entity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MultiplayerCombat;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "[CreatureController.EndSkillRequest] entityId无效。";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			EndSkillPush message2 = new EndSkillPush
			{
				UseSkillInfo = new UseSkillInformation
				{
					SkillId = (long)skillId,
					TimeStamp = (float)Time.Instance.NowSeconds
				},
				Reason = endSkillInfo.Reason,
				InterruptSkillInfo = new InterruptSkillInfo
				{
					EntityId = endSkillInfo.EntityId,
					SkillId = (long)endSkillInfo.SkillId,
					BulletId = endSkillInfo.BulletId
				}
			};
			CombatNet.Instance.Send(EPushMessageId.EndSkillPush, entity, message2, null, null, null);
			return true;
		}

		// Token: 0x0603B5D5 RID: 243157 RVA: 0x00E28E88 File Offset: 0x00E27088
		public unsafe void MontageRequest(Entity entity, int subProtocol, int skillId, long targetId, int montageIndex, float speedRatio = 1f, string startSection = "", float startTimeSeconds = 0f, long? preCombatMessageId = null, long? combatMessageId = null)
		{
			UseSkillInformation useSkillInfo = new UseSkillInformation
			{
				SkillId = (long)skillId,
				TargetId = targetId,
				TimeStamp = (float)Time.Instance.NowSeconds
			};
			SkillNodeInfo skillNodeInfos = new SkillNodeInfo
			{
				SubProtocol = subProtocol,
				MontageIndex = montageIndex,
				SpeedRatio = speedRatio,
				StartSection = startSection,
				StartTimeSeconds = startTimeSeconds
			};
			SkillRequest data = new SkillRequest
			{
				UseSkillInfo = useSkillInfo,
				SkillNodeInfos = skillNodeInfos
			};
			CombatNet.Instance.Call(ERequestMessageId.SkillRequest, entity, data, delegate(IMessage msg)
			{
				SkillResponse skillResponse = (SkillResponse)msg;
				if (entity.IsEnd)
				{
					return;
				}
				ErrorCode errorCode = skillResponse.ErrorCode;
				if (errorCode != ErrorCode.Success && errorCode != ErrorCode.ErrCombatSkillGahandleGetEntityFailed)
				{
					CombatLog instance = CombatLog.Instance;
					CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
					Entity entity2 = entity;
					string message = "播放蒙太奇请求失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能Id", skillId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ErrorCode", skillResponse.ErrorCode);
					instance.Error(flag, entity2, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}, preCombatMessageId, combatMessageId, null, null);
		}

		// Token: 0x0603B5D6 RID: 243158 RVA: 0x00E28F54 File Offset: 0x00E27154
		public void AnimNotifyRequest(Entity entity, int skillId, int montageIndex, int animNotifyIndex, long? preCombatMessageId = null, long? combatMessageId = null)
		{
			ANStartPush message = new ANStartPush
			{
				AnIndex = animNotifyIndex,
				MontageIndex = montageIndex,
				SkillId = (long)skillId
			};
			CombatNet.Instance.Send(EPushMessageId.ANStartPush, entity, message, preCombatMessageId, combatMessageId, null);
		}

		// Token: 0x0603B5D7 RID: 243159 RVA: 0x00E28FA0 File Offset: 0x00E271A0
		public unsafe long PassiveSkillAddRequest(Entity entity, long skillId, long? preCombatMessageId = null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			string message = "添加被动Request";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("被动技能Id", skillId);
			instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			PassiveSkillAddPush passiveSkillAddPush = new PassiveSkillAddPush();
			passiveSkillAddPush.PassiveSkillId = skillId;
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			passiveSkillAddPush.TargetEntityId = ((component != null) ? component.GetCreatureDataId() : 0L);
			PassiveSkillAddPush message2 = passiveSkillAddPush;
			long num = CombatMessageModel.Instance.GenMessageId();
			long? num2 = preCombatMessageId;
			long num3 = 0L;
			if (num2.GetValueOrDefault() == num3 & num2 != null)
			{
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Message;
				string message3 = "请求服务器添加被动技能时，发送的PreMessageId无效";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entity", ((entity != null) ? entity.GetType().Name : null) ?? "null");
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skillId", skillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("preCombatMessageId", preCombatMessageId.GetValueOrDefault());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("combatMessageId", num);
				instance2.Error(flag2, entity, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			CombatNet.Instance.Send(EPushMessageId.PassiveSkillAddPush, entity, message2, preCombatMessageId, new long?(num), null);
			return num;
		}

		// Token: 0x0603B5D8 RID: 243160 RVA: 0x00E290FC File Offset: 0x00E272FC
		public void PassiveSkillRemoveRequest(Entity entity, long skillId, long? preCombatMessageId = null, long? combatMessageId = null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			string message = "移除被动Request";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("被动技能Id", skillId);
			instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			PassiveSkillRemovePush passiveSkillRemovePush = new PassiveSkillRemovePush();
			passiveSkillRemovePush.PassiveSkillId = skillId;
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			passiveSkillRemovePush.TargetEntityId = ((component != null) ? component.GetCreatureDataId() : 0L);
			PassiveSkillRemovePush message2 = passiveSkillRemovePush;
			CombatNet.Instance.Send(EPushMessageId.PassiveSkillRemovePush, entity, message2, preCombatMessageId, combatMessageId, null);
		}

		// Token: 0x0603B5D9 RID: 243161 RVA: 0x00E29178 File Offset: 0x00E27378
		[NullableContext(2)]
		private void GetDebugFightErrInfo(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			DebugFightErrInfoNotify debugFightErrInfoNotify = (DebugFightErrInfoNotify)msg;
			ErrorCode errorCode = debugFightErrInfoNotify.ErrorCode;
			if (errorCode <= ErrorCode.ErrNoBuffConf)
			{
				if (errorCode == ErrorCode.ErrContextCheckFail)
				{
					this.PrintDebugFightErrInfo("技能上下文校验报错", debugFightErrInfoNotify.ExtraInfo ?? "");
					return;
				}
				switch (errorCode)
				{
				case ErrorCode.ErrMontageConfigNotFound:
					this.PrintDebugFightErrInfo("蒙太奇配置未找到", debugFightErrInfoNotify.ExtraInfo ?? "");
					return;
				case ErrorCode.ErrAnconfigNotFound:
					this.PrintDebugFightErrInfo("AN配置未找到", debugFightErrInfoNotify.ExtraInfo ?? "");
					return;
				case ErrorCode.ErrBulletConfigNotFound:
					this.PrintDebugFightErrInfo("子弹配置未找到", debugFightErrInfoNotify.ExtraInfo ?? "");
					return;
				default:
					if (errorCode == ErrorCode.ErrNoBuffConf)
					{
						this.PrintDebugFightErrInfo("BUFF配置未找到", debugFightErrInfoNotify.ExtraInfo ?? "");
						return;
					}
					break;
				}
			}
			else
			{
				if (errorCode == ErrorCode.ErrConfSkillNotExist)
				{
					this.PrintDebugFightErrInfo("技能配置未找到", debugFightErrInfoNotify.ExtraInfo ?? "");
					return;
				}
				if (errorCode == ErrorCode.ErrSkillCd)
				{
					this.PrintDebugFightErrInfo("技能CD中", debugFightErrInfoNotify.ExtraInfo ?? "");
					return;
				}
				if (errorCode == ErrorCode.ErrPlayMontageButNoSkill)
				{
					this.PrintDebugFightErrInfo("蒙太奇对应的技能未释放成功", debugFightErrInfoNotify.ExtraInfo ?? "");
					return;
				}
			}
			this.PrintDebugFightErrInfo("未支持的ErrorCode", debugFightErrInfoNotify.ExtraInfo ?? "");
		}

		// Token: 0x0603B5DA RID: 243162 RVA: 0x00E292DC File Offset: 0x00E274DC
		private void PrintDebugFightErrInfo(string reason, string info)
		{
			if (this.ClosePrintDebugFightErrInfo)
			{
				return;
			}
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Message;
			Entity entity = null;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("info", info);
			instance.Error(flag, entity, reason, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x17008CFA RID: 36090
		// (get) Token: 0x0603B5DB RID: 243163 RVA: 0x00E29314 File Offset: 0x00E27514
		public static SkillMessageController Instance
		{
			get
			{
				return SkillMessageController._Instance;
			}
		}

		// Token: 0x0603B5DC RID: 243164 RVA: 0x00E2931B File Offset: 0x00E2751B
		public static SkillMessageController GetOrCreateInstance()
		{
			if (SkillMessageController._Instance == null)
			{
				SkillMessageController.CreateInstance();
			}
			return SkillMessageController._Instance;
		}

		// Token: 0x0603B5DD RID: 243165 RVA: 0x00E2932F File Offset: 0x00E2752F
		public static bool CreateInstance()
		{
			if (SkillMessageController._Instance != null)
			{
				return true;
			}
			SkillMessageController._Instance = new SkillMessageController();
			return true;
		}

		// Token: 0x0603B5DE RID: 243166 RVA: 0x00E29345 File Offset: 0x00E27545
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B5DF RID: 243167 RVA: 0x00E29347 File Offset: 0x00E27547
		public static void ResetStaticDefaultValue()
		{
			SkillMessageController._Instance = null;
		}

		// Token: 0x0603B5E0 RID: 243168 RVA: 0x00E2934F File Offset: 0x00E2754F
		static SkillMessageController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkillMessageController.CreateStaticDefaultValue), new Action(SkillMessageController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EEFE RID: 126718
		private const int SKILL_PLAY_MONTAGE = 1;

		// Token: 0x0401EEFF RID: 126719
		public bool CloseMonsterServerLogic;

		// Token: 0x0401EF00 RID: 126720
		public bool ClosePrintDebugFightErrInfo = true;

		// Token: 0x0401EF01 RID: 126721
		private readonly HashSet<long> SkillCombatMessageSet = new HashSet<long>();

		// Token: 0x0401EF02 RID: 126722
		[Nullable(2)]
		private static SkillMessageController _Instance;
	}
}
