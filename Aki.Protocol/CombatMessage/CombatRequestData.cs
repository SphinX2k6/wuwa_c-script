using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.Ai;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001707 RID: 5895
	public sealed class CombatRequestData : IMessage<CombatRequestData>, IMessage, IEquatable<CombatRequestData>, IDeepCloneable<CombatRequestData>, IBufferMessage
	{
		// Token: 0x0601D856 RID: 120918 RVA: 0x0044CFC9 File Offset: 0x0044B1C9
		[NullableContext(1)]
		public static CombatRequestData Create()
		{
			return new CombatRequestData();
		}

		// Token: 0x17006429 RID: 25641
		// (get) Token: 0x0601D857 RID: 120919 RVA: 0x0044CFD0 File Offset: 0x0044B1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700642A RID: 25642
		// (get) Token: 0x0601D858 RID: 120920 RVA: 0x0044CFD3 File Offset: 0x0044B1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatRequestData.Descriptor;
			}
		}

		// Token: 0x0601D859 RID: 120921 RVA: 0x0044CFDA File Offset: 0x0044B1DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatRequestData()
		{
		}

		// Token: 0x0601D85A RID: 120922 RVA: 0x0044CFE4 File Offset: 0x0044B1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatRequestData(CombatRequestData other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.requestId_ = other.requestId_;
			switch (other.MessageCase)
			{
			case CombatRequestData.MessageOneofCase.CreateBulletRequest:
				this.CreateBulletRequest = other.CreateBulletRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.DestroyBulletRequest:
				this.DestroyBulletRequest = other.DestroyBulletRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.DamageExecuteRequest:
				this.DamageExecuteRequest = other.DamageExecuteRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest:
				this.ApplyGameplayEffectRequest = other.ApplyGameplayEffectRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest:
				this.RemoveGameplayEffectRequest = other.RemoveGameplayEffectRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.HitRequest:
				this.HitRequest = other.HitRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.HitEndRequest:
				this.HitEndRequest = other.HitEndRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.SkillRequest:
				this.SkillRequest = other.SkillRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.UseSkillRequest:
				this.UseSkillRequest = other.UseSkillRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.EndSkillRequest:
				this.EndSkillRequest = other.EndSkillRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.PartUpdateRequest:
				this.PartUpdateRequest = other.PartUpdateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.MaterialRequest:
				this.MaterialRequest = other.MaterialRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.GameplayCueRequest:
				this.GameplayCueRequest = other.GameplayCueRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.EntityIsVisibleRequest:
				this.EntityIsVisibleRequest = other.EntityIsVisibleRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest:
				this.SwitchCharacterStateRequest = other.SwitchCharacterStateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.LogicStateInitRequest:
				this.LogicStateInitRequest = other.LogicStateInitRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.SwitchLogicStateRequest:
				this.SwitchLogicStateRequest = other.SwitchLogicStateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AnimationStateChangedRequest:
				this.AnimationStateChangedRequest = other.AnimationStateChangedRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AnimationStateInitRequest:
				this.AnimationStateInitRequest = other.AnimationStateInitRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest:
				this.ModifyBulletParamsRequest = other.ModifyBulletParamsRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.DrownRequest:
				this.DrownRequest = other.DrownRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.OrderApplyBuffRequest:
				this.OrderApplyBuffRequest = other.OrderApplyBuffRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest:
				this.OrderRemoveBuffRequest = other.OrderRemoveBuffRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ActivateBuffRequest:
				this.ActivateBuffRequest = other.ActivateBuffRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest:
				this.OrderRemoveBuffByTagsRequest = other.OrderRemoveBuffByTagsRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AiInformationRequest:
				this.AiInformationRequest = other.AiInformationRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest:
				this.ToughCalcExtraRatioChangeRequest = other.ToughCalcExtraRatioChangeRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.BattleStateChangeRequest:
				this.BattleStateChangeRequest = other.BattleStateChangeRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest:
				this.AnimationGameplayTagRequest = other.AnimationGameplayTagRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest:
				this.BoneVisibleChangeRequest = other.BoneVisibleChangeRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AiBlackboardsRequest:
				this.AiBlackboardsRequest = other.AiBlackboardsRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AiBlackboardCdRequest:
				this.AiBlackboardCdRequest = other.AiBlackboardCdRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.AiHateRequest:
				this.AiHateRequest = other.AiHateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.MonsterBoomRequest:
				this.MonsterBoomRequest = other.MonsterBoomRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.CaughtRequest:
				this.CaughtRequest = other.CaughtRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest:
				this.EntityStaticHookMoveRequest = other.EntityStaticHookMoveRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ChangeStateRequest:
				this.ChangeStateRequest = other.ChangeStateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest:
				this.ChangeStateConfirmRequest = other.ChangeStateConfirmRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.FsmConditionPassRequest:
				this.FsmConditionPassRequest = other.FsmConditionPassRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.BuffStackCountRequest:
				this.BuffStackCountRequest = other.BuffStackCountRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ANStartRequest:
				this.ANStartRequest = other.ANStartRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.UseSkillFailRequest:
				this.UseSkillFailRequest = other.UseSkillFailRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.EnterViewDirectionRequest:
				this.EnterViewDirectionRequest = other.EnterViewDirectionRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ExitViewDirectionRequest:
				this.ExitViewDirectionRequest = other.ExitViewDirectionRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.PassiveSkillAddRequest:
				this.PassiveSkillAddRequest = other.PassiveSkillAddRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest:
				this.InterruptSkillInDelayRequest = other.InterruptSkillInDelayRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.TriggerExitSkillRequest:
				this.TriggerExitSkillRequest = other.TriggerExitSkillRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ActorVisibleRequest:
				this.ActorVisibleRequest = other.ActorVisibleRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.BuffEffectRequest:
				this.BuffEffectRequest = other.BuffEffectRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.FragileChangeRequest:
				this.FragileChangeRequest = other.FragileChangeRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopRequest:
				this.RTimeStopRequest = other.RTimeStopRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.DrownEndTeleportRequest:
				this.DrownEndTeleportRequest = other.DrownEndTeleportRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.MonsterDrownRequest:
				this.MonsterDrownRequest = other.MonsterDrownRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest:
				this.PassiveSkillRemoveRequest = other.PassiveSkillRemoveRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopInstRequest:
				this.RTimeStopInstRequest = other.RTimeStopInstRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest:
				this.FsmStateBehaviorRequest = other.FsmStateBehaviorRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.FsmPlayMontageRequest:
				this.FsmPlayMontageRequest = other.FsmPlayMontageRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopAnimRequest:
				this.RTimeStopAnimRequest = other.RTimeStopAnimRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.SwitchRoleRequest:
				this.SwitchRoleRequest = other.SwitchRoleRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.GameplayTagRequest:
				this.GameplayTagRequest = other.GameplayTagRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ExecuteQteRequest:
				this.ExecuteQteRequest = other.ExecuteQteRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.CombineEntitiesRequest:
				this.CombineEntitiesRequest = other.CombineEntitiesRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest:
				this.DissolveCombineRelationRequest = other.DissolveCombineRelationRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest:
				this.ClientCurrentRoleReportRequest = other.ClientCurrentRoleReportRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest:
				this.GaSwitchCommonEnemyProCampRequest = other.GaSwitchCommonEnemyProCampRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest:
				this.ChangeSummonEntityStateRequest = other.ChangeSummonEntityStateRequest.Clone();
				break;
			case CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest:
				this.CombatMaxCaseMessageRequest = other.CombatMaxCaseMessageRequest.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D85B RID: 120923 RVA: 0x0044D773 File Offset: 0x0044B973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatRequestData Clone()
		{
			return new CombatRequestData(this);
		}

		// Token: 0x1700642B RID: 25643
		// (get) Token: 0x0601D85C RID: 120924 RVA: 0x0044D77B File Offset: 0x0044B97B
		// (set) Token: 0x0601D85D RID: 120925 RVA: 0x0044D783 File Offset: 0x0044B983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x1700642C RID: 25644
		// (get) Token: 0x0601D85E RID: 120926 RVA: 0x0044D78C File Offset: 0x0044B98C
		// (set) Token: 0x0601D85F RID: 120927 RVA: 0x0044D794 File Offset: 0x0044B994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RequestId
		{
			get
			{
				return this.requestId_;
			}
			set
			{
				this.requestId_ = value;
			}
		}

		// Token: 0x1700642D RID: 25645
		// (get) Token: 0x0601D860 RID: 120928 RVA: 0x0044D79D File Offset: 0x0044B99D
		// (set) Token: 0x0601D861 RID: 120929 RVA: 0x0044D7B5 File Offset: 0x0044B9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletRequest CreateBulletRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.CreateBulletRequest)
				{
					return null;
				}
				return (CreateBulletRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.CreateBulletRequest);
			}
		}

		// Token: 0x1700642E RID: 25646
		// (get) Token: 0x0601D862 RID: 120930 RVA: 0x0044D7CB File Offset: 0x0044B9CB
		// (set) Token: 0x0601D863 RID: 120931 RVA: 0x0044D7E3 File Offset: 0x0044B9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletRequest DestroyBulletRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.DestroyBulletRequest)
				{
					return null;
				}
				return (DestroyBulletRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.DestroyBulletRequest);
			}
		}

		// Token: 0x1700642F RID: 25647
		// (get) Token: 0x0601D864 RID: 120932 RVA: 0x0044D7F9 File Offset: 0x0044B9F9
		// (set) Token: 0x0601D865 RID: 120933 RVA: 0x0044D811 File Offset: 0x0044BA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteRequest DamageExecuteRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.DamageExecuteRequest)
				{
					return null;
				}
				return (DamageExecuteRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.DamageExecuteRequest);
			}
		}

		// Token: 0x17006430 RID: 25648
		// (get) Token: 0x0601D866 RID: 120934 RVA: 0x0044D827 File Offset: 0x0044BA27
		// (set) Token: 0x0601D867 RID: 120935 RVA: 0x0044D83F File Offset: 0x0044BA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectRequest ApplyGameplayEffectRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest)
				{
					return null;
				}
				return (ApplyGameplayEffectRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest);
			}
		}

		// Token: 0x17006431 RID: 25649
		// (get) Token: 0x0601D868 RID: 120936 RVA: 0x0044D855 File Offset: 0x0044BA55
		// (set) Token: 0x0601D869 RID: 120937 RVA: 0x0044D86D File Offset: 0x0044BA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectRequest RemoveGameplayEffectRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest)
				{
					return null;
				}
				return (RemoveGameplayEffectRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest);
			}
		}

		// Token: 0x17006432 RID: 25650
		// (get) Token: 0x0601D86A RID: 120938 RVA: 0x0044D883 File Offset: 0x0044BA83
		// (set) Token: 0x0601D86B RID: 120939 RVA: 0x0044D89B File Offset: 0x0044BA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitRequest HitRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.HitRequest)
				{
					return null;
				}
				return (HitRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.HitRequest);
			}
		}

		// Token: 0x17006433 RID: 25651
		// (get) Token: 0x0601D86C RID: 120940 RVA: 0x0044D8B1 File Offset: 0x0044BAB1
		// (set) Token: 0x0601D86D RID: 120941 RVA: 0x0044D8CA File Offset: 0x0044BACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndRequest HitEndRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.HitEndRequest)
				{
					return null;
				}
				return (HitEndRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.HitEndRequest);
			}
		}

		// Token: 0x17006434 RID: 25652
		// (get) Token: 0x0601D86E RID: 120942 RVA: 0x0044D8E1 File Offset: 0x0044BAE1
		// (set) Token: 0x0601D86F RID: 120943 RVA: 0x0044D8FA File Offset: 0x0044BAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillRequest SkillRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.SkillRequest)
				{
					return null;
				}
				return (SkillRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.SkillRequest);
			}
		}

		// Token: 0x17006435 RID: 25653
		// (get) Token: 0x0601D870 RID: 120944 RVA: 0x0044D911 File Offset: 0x0044BB11
		// (set) Token: 0x0601D871 RID: 120945 RVA: 0x0044D92A File Offset: 0x0044BB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillRequest UseSkillRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.UseSkillRequest)
				{
					return null;
				}
				return (UseSkillRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.UseSkillRequest);
			}
		}

		// Token: 0x17006436 RID: 25654
		// (get) Token: 0x0601D872 RID: 120946 RVA: 0x0044D941 File Offset: 0x0044BB41
		// (set) Token: 0x0601D873 RID: 120947 RVA: 0x0044D95A File Offset: 0x0044BB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillRequest EndSkillRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.EndSkillRequest)
				{
					return null;
				}
				return (EndSkillRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.EndSkillRequest);
			}
		}

		// Token: 0x17006437 RID: 25655
		// (get) Token: 0x0601D874 RID: 120948 RVA: 0x0044D971 File Offset: 0x0044BB71
		// (set) Token: 0x0601D875 RID: 120949 RVA: 0x0044D98A File Offset: 0x0044BB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateRequest PartUpdateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.PartUpdateRequest)
				{
					return null;
				}
				return (PartUpdateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.PartUpdateRequest);
			}
		}

		// Token: 0x17006438 RID: 25656
		// (get) Token: 0x0601D876 RID: 120950 RVA: 0x0044D9A1 File Offset: 0x0044BBA1
		// (set) Token: 0x0601D877 RID: 120951 RVA: 0x0044D9BA File Offset: 0x0044BBBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialRequest MaterialRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.MaterialRequest)
				{
					return null;
				}
				return (MaterialRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.MaterialRequest);
			}
		}

		// Token: 0x17006439 RID: 25657
		// (get) Token: 0x0601D878 RID: 120952 RVA: 0x0044D9D1 File Offset: 0x0044BBD1
		// (set) Token: 0x0601D879 RID: 120953 RVA: 0x0044D9EA File Offset: 0x0044BBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueRequest GameplayCueRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.GameplayCueRequest)
				{
					return null;
				}
				return (GameplayCueRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.GameplayCueRequest);
			}
		}

		// Token: 0x1700643A RID: 25658
		// (get) Token: 0x0601D87A RID: 120954 RVA: 0x0044DA01 File Offset: 0x0044BC01
		// (set) Token: 0x0601D87B RID: 120955 RVA: 0x0044DA1A File Offset: 0x0044BC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleRequest EntityIsVisibleRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.EntityIsVisibleRequest)
				{
					return null;
				}
				return (EntityIsVisibleRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.EntityIsVisibleRequest);
			}
		}

		// Token: 0x1700643B RID: 25659
		// (get) Token: 0x0601D87C RID: 120956 RVA: 0x0044DA31 File Offset: 0x0044BC31
		// (set) Token: 0x0601D87D RID: 120957 RVA: 0x0044DA4A File Offset: 0x0044BC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateRequest SwitchCharacterStateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest)
				{
					return null;
				}
				return (SwitchCharacterStateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest);
			}
		}

		// Token: 0x1700643C RID: 25660
		// (get) Token: 0x0601D87E RID: 120958 RVA: 0x0044DA61 File Offset: 0x0044BC61
		// (set) Token: 0x0601D87F RID: 120959 RVA: 0x0044DA7A File Offset: 0x0044BC7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitRequest LogicStateInitRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.LogicStateInitRequest)
				{
					return null;
				}
				return (LogicStateInitRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.LogicStateInitRequest);
			}
		}

		// Token: 0x1700643D RID: 25661
		// (get) Token: 0x0601D880 RID: 120960 RVA: 0x0044DA91 File Offset: 0x0044BC91
		// (set) Token: 0x0601D881 RID: 120961 RVA: 0x0044DAAA File Offset: 0x0044BCAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateRequest SwitchLogicStateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.SwitchLogicStateRequest)
				{
					return null;
				}
				return (SwitchLogicStateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.SwitchLogicStateRequest);
			}
		}

		// Token: 0x1700643E RID: 25662
		// (get) Token: 0x0601D882 RID: 120962 RVA: 0x0044DAC1 File Offset: 0x0044BCC1
		// (set) Token: 0x0601D883 RID: 120963 RVA: 0x0044DADA File Offset: 0x0044BCDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedRequest AnimationStateChangedRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AnimationStateChangedRequest)
				{
					return null;
				}
				return (AnimationStateChangedRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AnimationStateChangedRequest);
			}
		}

		// Token: 0x1700643F RID: 25663
		// (get) Token: 0x0601D884 RID: 120964 RVA: 0x0044DAF1 File Offset: 0x0044BCF1
		// (set) Token: 0x0601D885 RID: 120965 RVA: 0x0044DB0A File Offset: 0x0044BD0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitRequest AnimationStateInitRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AnimationStateInitRequest)
				{
					return null;
				}
				return (AnimationStateInitRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AnimationStateInitRequest);
			}
		}

		// Token: 0x17006440 RID: 25664
		// (get) Token: 0x0601D886 RID: 120966 RVA: 0x0044DB21 File Offset: 0x0044BD21
		// (set) Token: 0x0601D887 RID: 120967 RVA: 0x0044DB3A File Offset: 0x0044BD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsRequest ModifyBulletParamsRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest)
				{
					return null;
				}
				return (ModifyBulletParamsRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest);
			}
		}

		// Token: 0x17006441 RID: 25665
		// (get) Token: 0x0601D888 RID: 120968 RVA: 0x0044DB51 File Offset: 0x0044BD51
		// (set) Token: 0x0601D889 RID: 120969 RVA: 0x0044DB6A File Offset: 0x0044BD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownRequest DrownRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.DrownRequest)
				{
					return null;
				}
				return (DrownRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.DrownRequest);
			}
		}

		// Token: 0x17006442 RID: 25666
		// (get) Token: 0x0601D88A RID: 120970 RVA: 0x0044DB81 File Offset: 0x0044BD81
		// (set) Token: 0x0601D88B RID: 120971 RVA: 0x0044DB9A File Offset: 0x0044BD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffRequest OrderApplyBuffRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.OrderApplyBuffRequest)
				{
					return null;
				}
				return (OrderApplyBuffRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.OrderApplyBuffRequest);
			}
		}

		// Token: 0x17006443 RID: 25667
		// (get) Token: 0x0601D88C RID: 120972 RVA: 0x0044DBB1 File Offset: 0x0044BDB1
		// (set) Token: 0x0601D88D RID: 120973 RVA: 0x0044DBCA File Offset: 0x0044BDCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffRequest OrderRemoveBuffRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest)
				{
					return null;
				}
				return (OrderRemoveBuffRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest);
			}
		}

		// Token: 0x17006444 RID: 25668
		// (get) Token: 0x0601D88E RID: 120974 RVA: 0x0044DBE1 File Offset: 0x0044BDE1
		// (set) Token: 0x0601D88F RID: 120975 RVA: 0x0044DBFA File Offset: 0x0044BDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffRequest ActivateBuffRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ActivateBuffRequest)
				{
					return null;
				}
				return (ActivateBuffRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ActivateBuffRequest);
			}
		}

		// Token: 0x17006445 RID: 25669
		// (get) Token: 0x0601D890 RID: 120976 RVA: 0x0044DC11 File Offset: 0x0044BE11
		// (set) Token: 0x0601D891 RID: 120977 RVA: 0x0044DC2A File Offset: 0x0044BE2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsRequest OrderRemoveBuffByTagsRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest)
				{
					return null;
				}
				return (OrderRemoveBuffByTagsRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest);
			}
		}

		// Token: 0x17006446 RID: 25670
		// (get) Token: 0x0601D892 RID: 120978 RVA: 0x0044DC41 File Offset: 0x0044BE41
		// (set) Token: 0x0601D893 RID: 120979 RVA: 0x0044DC5A File Offset: 0x0044BE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationRequest AiInformationRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AiInformationRequest)
				{
					return null;
				}
				return (AiInformationRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AiInformationRequest);
			}
		}

		// Token: 0x17006447 RID: 25671
		// (get) Token: 0x0601D894 RID: 120980 RVA: 0x0044DC71 File Offset: 0x0044BE71
		// (set) Token: 0x0601D895 RID: 120981 RVA: 0x0044DC8A File Offset: 0x0044BE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeRequest ToughCalcExtraRatioChangeRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest)
				{
					return null;
				}
				return (ToughCalcExtraRatioChangeRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest);
			}
		}

		// Token: 0x17006448 RID: 25672
		// (get) Token: 0x0601D896 RID: 120982 RVA: 0x0044DCA1 File Offset: 0x0044BEA1
		// (set) Token: 0x0601D897 RID: 120983 RVA: 0x0044DCBA File Offset: 0x0044BEBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeRequest BattleStateChangeRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.BattleStateChangeRequest)
				{
					return null;
				}
				return (BattleStateChangeRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.BattleStateChangeRequest);
			}
		}

		// Token: 0x17006449 RID: 25673
		// (get) Token: 0x0601D898 RID: 120984 RVA: 0x0044DCD1 File Offset: 0x0044BED1
		// (set) Token: 0x0601D899 RID: 120985 RVA: 0x0044DCEA File Offset: 0x0044BEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagRequest AnimationGameplayTagRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest)
				{
					return null;
				}
				return (AnimationGameplayTagRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest);
			}
		}

		// Token: 0x1700644A RID: 25674
		// (get) Token: 0x0601D89A RID: 120986 RVA: 0x0044DD01 File Offset: 0x0044BF01
		// (set) Token: 0x0601D89B RID: 120987 RVA: 0x0044DD1A File Offset: 0x0044BF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeRequest BoneVisibleChangeRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest)
				{
					return null;
				}
				return (BoneVisibleChangeRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest);
			}
		}

		// Token: 0x1700644B RID: 25675
		// (get) Token: 0x0601D89C RID: 120988 RVA: 0x0044DD31 File Offset: 0x0044BF31
		// (set) Token: 0x0601D89D RID: 120989 RVA: 0x0044DD4A File Offset: 0x0044BF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsRequest AiBlackboardsRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AiBlackboardsRequest)
				{
					return null;
				}
				return (AiBlackboardsRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AiBlackboardsRequest);
			}
		}

		// Token: 0x1700644C RID: 25676
		// (get) Token: 0x0601D89E RID: 120990 RVA: 0x0044DD61 File Offset: 0x0044BF61
		// (set) Token: 0x0601D89F RID: 120991 RVA: 0x0044DD7A File Offset: 0x0044BF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdRequest AiBlackboardCdRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AiBlackboardCdRequest)
				{
					return null;
				}
				return (AiBlackboardCdRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AiBlackboardCdRequest);
			}
		}

		// Token: 0x1700644D RID: 25677
		// (get) Token: 0x0601D8A0 RID: 120992 RVA: 0x0044DD91 File Offset: 0x0044BF91
		// (set) Token: 0x0601D8A1 RID: 120993 RVA: 0x0044DDAA File Offset: 0x0044BFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateRequest AiHateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.AiHateRequest)
				{
					return null;
				}
				return (AiHateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.AiHateRequest);
			}
		}

		// Token: 0x1700644E RID: 25678
		// (get) Token: 0x0601D8A2 RID: 120994 RVA: 0x0044DDC1 File Offset: 0x0044BFC1
		// (set) Token: 0x0601D8A3 RID: 120995 RVA: 0x0044DDDA File Offset: 0x0044BFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomRequest MonsterBoomRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.MonsterBoomRequest)
				{
					return null;
				}
				return (MonsterBoomRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.MonsterBoomRequest);
			}
		}

		// Token: 0x1700644F RID: 25679
		// (get) Token: 0x0601D8A4 RID: 120996 RVA: 0x0044DDF1 File Offset: 0x0044BFF1
		// (set) Token: 0x0601D8A5 RID: 120997 RVA: 0x0044DE0A File Offset: 0x0044C00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtRequest CaughtRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.CaughtRequest)
				{
					return null;
				}
				return (CaughtRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.CaughtRequest);
			}
		}

		// Token: 0x17006450 RID: 25680
		// (get) Token: 0x0601D8A6 RID: 120998 RVA: 0x0044DE21 File Offset: 0x0044C021
		// (set) Token: 0x0601D8A7 RID: 120999 RVA: 0x0044DE3A File Offset: 0x0044C03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveRequest EntityStaticHookMoveRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest)
				{
					return null;
				}
				return (EntityStaticHookMoveRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest);
			}
		}

		// Token: 0x17006451 RID: 25681
		// (get) Token: 0x0601D8A8 RID: 121000 RVA: 0x0044DE51 File Offset: 0x0044C051
		// (set) Token: 0x0601D8A9 RID: 121001 RVA: 0x0044DE6A File Offset: 0x0044C06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateRequest ChangeStateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ChangeStateRequest)
				{
					return null;
				}
				return (ChangeStateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ChangeStateRequest);
			}
		}

		// Token: 0x17006452 RID: 25682
		// (get) Token: 0x0601D8AA RID: 121002 RVA: 0x0044DE81 File Offset: 0x0044C081
		// (set) Token: 0x0601D8AB RID: 121003 RVA: 0x0044DE9A File Offset: 0x0044C09A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmRequest ChangeStateConfirmRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest)
				{
					return null;
				}
				return (ChangeStateConfirmRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest);
			}
		}

		// Token: 0x17006453 RID: 25683
		// (get) Token: 0x0601D8AC RID: 121004 RVA: 0x0044DEB1 File Offset: 0x0044C0B1
		// (set) Token: 0x0601D8AD RID: 121005 RVA: 0x0044DECA File Offset: 0x0044C0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassRequest FsmConditionPassRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.FsmConditionPassRequest)
				{
					return null;
				}
				return (FsmConditionPassRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.FsmConditionPassRequest);
			}
		}

		// Token: 0x17006454 RID: 25684
		// (get) Token: 0x0601D8AE RID: 121006 RVA: 0x0044DEE1 File Offset: 0x0044C0E1
		// (set) Token: 0x0601D8AF RID: 121007 RVA: 0x0044DEFA File Offset: 0x0044C0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountRequest BuffStackCountRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.BuffStackCountRequest)
				{
					return null;
				}
				return (BuffStackCountRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.BuffStackCountRequest);
			}
		}

		// Token: 0x17006455 RID: 25685
		// (get) Token: 0x0601D8B0 RID: 121008 RVA: 0x0044DF11 File Offset: 0x0044C111
		// (set) Token: 0x0601D8B1 RID: 121009 RVA: 0x0044DF2A File Offset: 0x0044C12A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartRequest ANStartRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ANStartRequest)
				{
					return null;
				}
				return (ANStartRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ANStartRequest);
			}
		}

		// Token: 0x17006456 RID: 25686
		// (get) Token: 0x0601D8B2 RID: 121010 RVA: 0x0044DF41 File Offset: 0x0044C141
		// (set) Token: 0x0601D8B3 RID: 121011 RVA: 0x0044DF5A File Offset: 0x0044C15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailRequest UseSkillFailRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.UseSkillFailRequest)
				{
					return null;
				}
				return (UseSkillFailRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.UseSkillFailRequest);
			}
		}

		// Token: 0x17006457 RID: 25687
		// (get) Token: 0x0601D8B4 RID: 121012 RVA: 0x0044DF71 File Offset: 0x0044C171
		// (set) Token: 0x0601D8B5 RID: 121013 RVA: 0x0044DF8A File Offset: 0x0044C18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionRequest EnterViewDirectionRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.EnterViewDirectionRequest)
				{
					return null;
				}
				return (EnterViewDirectionRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.EnterViewDirectionRequest);
			}
		}

		// Token: 0x17006458 RID: 25688
		// (get) Token: 0x0601D8B6 RID: 121014 RVA: 0x0044DFA1 File Offset: 0x0044C1A1
		// (set) Token: 0x0601D8B7 RID: 121015 RVA: 0x0044DFBA File Offset: 0x0044C1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionRequest ExitViewDirectionRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ExitViewDirectionRequest)
				{
					return null;
				}
				return (ExitViewDirectionRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ExitViewDirectionRequest);
			}
		}

		// Token: 0x17006459 RID: 25689
		// (get) Token: 0x0601D8B8 RID: 121016 RVA: 0x0044DFD1 File Offset: 0x0044C1D1
		// (set) Token: 0x0601D8B9 RID: 121017 RVA: 0x0044DFEA File Offset: 0x0044C1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddRequest PassiveSkillAddRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.PassiveSkillAddRequest)
				{
					return null;
				}
				return (PassiveSkillAddRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.PassiveSkillAddRequest);
			}
		}

		// Token: 0x1700645A RID: 25690
		// (get) Token: 0x0601D8BA RID: 121018 RVA: 0x0044E001 File Offset: 0x0044C201
		// (set) Token: 0x0601D8BB RID: 121019 RVA: 0x0044E01A File Offset: 0x0044C21A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayRequest InterruptSkillInDelayRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest)
				{
					return null;
				}
				return (InterruptSkillInDelayRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest);
			}
		}

		// Token: 0x1700645B RID: 25691
		// (get) Token: 0x0601D8BC RID: 121020 RVA: 0x0044E031 File Offset: 0x0044C231
		// (set) Token: 0x0601D8BD RID: 121021 RVA: 0x0044E04A File Offset: 0x0044C24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillRequest TriggerExitSkillRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.TriggerExitSkillRequest)
				{
					return null;
				}
				return (TriggerExitSkillRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.TriggerExitSkillRequest);
			}
		}

		// Token: 0x1700645C RID: 25692
		// (get) Token: 0x0601D8BE RID: 121022 RVA: 0x0044E061 File Offset: 0x0044C261
		// (set) Token: 0x0601D8BF RID: 121023 RVA: 0x0044E07A File Offset: 0x0044C27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleRequest ActorVisibleRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ActorVisibleRequest)
				{
					return null;
				}
				return (ActorVisibleRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ActorVisibleRequest);
			}
		}

		// Token: 0x1700645D RID: 25693
		// (get) Token: 0x0601D8C0 RID: 121024 RVA: 0x0044E091 File Offset: 0x0044C291
		// (set) Token: 0x0601D8C1 RID: 121025 RVA: 0x0044E0AA File Offset: 0x0044C2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectRequest BuffEffectRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.BuffEffectRequest)
				{
					return null;
				}
				return (BuffEffectRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.BuffEffectRequest);
			}
		}

		// Token: 0x1700645E RID: 25694
		// (get) Token: 0x0601D8C2 RID: 121026 RVA: 0x0044E0C1 File Offset: 0x0044C2C1
		// (set) Token: 0x0601D8C3 RID: 121027 RVA: 0x0044E0DA File Offset: 0x0044C2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeRequest FragileChangeRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.FragileChangeRequest)
				{
					return null;
				}
				return (FragileChangeRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.FragileChangeRequest);
			}
		}

		// Token: 0x1700645F RID: 25695
		// (get) Token: 0x0601D8C4 RID: 121028 RVA: 0x0044E0F1 File Offset: 0x0044C2F1
		// (set) Token: 0x0601D8C5 RID: 121029 RVA: 0x0044E10A File Offset: 0x0044C30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopRequest RTimeStopRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.RTimeStopRequest)
				{
					return null;
				}
				return (RTimeStopRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.RTimeStopRequest);
			}
		}

		// Token: 0x17006460 RID: 25696
		// (get) Token: 0x0601D8C6 RID: 121030 RVA: 0x0044E121 File Offset: 0x0044C321
		// (set) Token: 0x0601D8C7 RID: 121031 RVA: 0x0044E13A File Offset: 0x0044C33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportRequest DrownEndTeleportRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.DrownEndTeleportRequest)
				{
					return null;
				}
				return (DrownEndTeleportRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.DrownEndTeleportRequest);
			}
		}

		// Token: 0x17006461 RID: 25697
		// (get) Token: 0x0601D8C8 RID: 121032 RVA: 0x0044E151 File Offset: 0x0044C351
		// (set) Token: 0x0601D8C9 RID: 121033 RVA: 0x0044E16A File Offset: 0x0044C36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownRequest MonsterDrownRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.MonsterDrownRequest)
				{
					return null;
				}
				return (MonsterDrownRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.MonsterDrownRequest);
			}
		}

		// Token: 0x17006462 RID: 25698
		// (get) Token: 0x0601D8CA RID: 121034 RVA: 0x0044E181 File Offset: 0x0044C381
		// (set) Token: 0x0601D8CB RID: 121035 RVA: 0x0044E19A File Offset: 0x0044C39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveRequest PassiveSkillRemoveRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest)
				{
					return null;
				}
				return (PassiveSkillRemoveRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest);
			}
		}

		// Token: 0x17006463 RID: 25699
		// (get) Token: 0x0601D8CC RID: 121036 RVA: 0x0044E1B1 File Offset: 0x0044C3B1
		// (set) Token: 0x0601D8CD RID: 121037 RVA: 0x0044E1CA File Offset: 0x0044C3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstRequest RTimeStopInstRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.RTimeStopInstRequest)
				{
					return null;
				}
				return (RTimeStopInstRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.RTimeStopInstRequest);
			}
		}

		// Token: 0x17006464 RID: 25700
		// (get) Token: 0x0601D8CE RID: 121038 RVA: 0x0044E1E1 File Offset: 0x0044C3E1
		// (set) Token: 0x0601D8CF RID: 121039 RVA: 0x0044E1FA File Offset: 0x0044C3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorRequest FsmStateBehaviorRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest)
				{
					return null;
				}
				return (FsmStateBehaviorRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest);
			}
		}

		// Token: 0x17006465 RID: 25701
		// (get) Token: 0x0601D8D0 RID: 121040 RVA: 0x0044E211 File Offset: 0x0044C411
		// (set) Token: 0x0601D8D1 RID: 121041 RVA: 0x0044E22A File Offset: 0x0044C42A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageRequest FsmPlayMontageRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.FsmPlayMontageRequest)
				{
					return null;
				}
				return (FsmPlayMontageRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.FsmPlayMontageRequest);
			}
		}

		// Token: 0x17006466 RID: 25702
		// (get) Token: 0x0601D8D2 RID: 121042 RVA: 0x0044E241 File Offset: 0x0044C441
		// (set) Token: 0x0601D8D3 RID: 121043 RVA: 0x0044E25A File Offset: 0x0044C45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimRequest RTimeStopAnimRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.RTimeStopAnimRequest)
				{
					return null;
				}
				return (RTimeStopAnimRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.RTimeStopAnimRequest);
			}
		}

		// Token: 0x17006467 RID: 25703
		// (get) Token: 0x0601D8D4 RID: 121044 RVA: 0x0044E271 File Offset: 0x0044C471
		// (set) Token: 0x0601D8D5 RID: 121045 RVA: 0x0044E28A File Offset: 0x0044C48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleRequest SwitchRoleRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.SwitchRoleRequest)
				{
					return null;
				}
				return (SwitchRoleRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.SwitchRoleRequest);
			}
		}

		// Token: 0x17006468 RID: 25704
		// (get) Token: 0x0601D8D6 RID: 121046 RVA: 0x0044E2A1 File Offset: 0x0044C4A1
		// (set) Token: 0x0601D8D7 RID: 121047 RVA: 0x0044E2BA File Offset: 0x0044C4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagRequest GameplayTagRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.GameplayTagRequest)
				{
					return null;
				}
				return (GameplayTagRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.GameplayTagRequest);
			}
		}

		// Token: 0x17006469 RID: 25705
		// (get) Token: 0x0601D8D8 RID: 121048 RVA: 0x0044E2D1 File Offset: 0x0044C4D1
		// (set) Token: 0x0601D8D9 RID: 121049 RVA: 0x0044E2EA File Offset: 0x0044C4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteRequest ExecuteQteRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ExecuteQteRequest)
				{
					return null;
				}
				return (ExecuteQteRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ExecuteQteRequest);
			}
		}

		// Token: 0x1700646A RID: 25706
		// (get) Token: 0x0601D8DA RID: 121050 RVA: 0x0044E301 File Offset: 0x0044C501
		// (set) Token: 0x0601D8DB RID: 121051 RVA: 0x0044E31A File Offset: 0x0044C51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesRequest CombineEntitiesRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.CombineEntitiesRequest)
				{
					return null;
				}
				return (CombineEntitiesRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.CombineEntitiesRequest);
			}
		}

		// Token: 0x1700646B RID: 25707
		// (get) Token: 0x0601D8DC RID: 121052 RVA: 0x0044E331 File Offset: 0x0044C531
		// (set) Token: 0x0601D8DD RID: 121053 RVA: 0x0044E34A File Offset: 0x0044C54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationRequest DissolveCombineRelationRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest)
				{
					return null;
				}
				return (DissolveCombineRelationRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest);
			}
		}

		// Token: 0x1700646C RID: 25708
		// (get) Token: 0x0601D8DE RID: 121054 RVA: 0x0044E361 File Offset: 0x0044C561
		// (set) Token: 0x0601D8DF RID: 121055 RVA: 0x0044E37A File Offset: 0x0044C57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportRequest ClientCurrentRoleReportRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest)
				{
					return null;
				}
				return (ClientCurrentRoleReportRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest);
			}
		}

		// Token: 0x1700646D RID: 25709
		// (get) Token: 0x0601D8E0 RID: 121056 RVA: 0x0044E391 File Offset: 0x0044C591
		// (set) Token: 0x0601D8E1 RID: 121057 RVA: 0x0044E3AA File Offset: 0x0044C5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampRequest GaSwitchCommonEnemyProCampRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest)
				{
					return null;
				}
				return (GaSwitchCommonEnemyProCampRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest);
			}
		}

		// Token: 0x1700646E RID: 25710
		// (get) Token: 0x0601D8E2 RID: 121058 RVA: 0x0044E3C1 File Offset: 0x0044C5C1
		// (set) Token: 0x0601D8E3 RID: 121059 RVA: 0x0044E3DA File Offset: 0x0044C5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateRequest ChangeSummonEntityStateRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest)
				{
					return null;
				}
				return (ChangeSummonEntityStateRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest);
			}
		}

		// Token: 0x1700646F RID: 25711
		// (get) Token: 0x0601D8E4 RID: 121060 RVA: 0x0044E3F1 File Offset: 0x0044C5F1
		// (set) Token: 0x0601D8E5 RID: 121061 RVA: 0x0044E40A File Offset: 0x0044C60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageRequest CombatMaxCaseMessageRequest
		{
			get
			{
				if (this.messageCase_ != CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest)
				{
					return null;
				}
				return (CombatMaxCaseMessageRequest)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatRequestData.MessageOneofCase.None : CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest);
			}
		}

		// Token: 0x17006470 RID: 25712
		// (get) Token: 0x0601D8E6 RID: 121062 RVA: 0x0044E421 File Offset: 0x0044C621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatRequestData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601D8E7 RID: 121063 RVA: 0x0044E429 File Offset: 0x0044C629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatRequestData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601D8E8 RID: 121064 RVA: 0x0044E439 File Offset: 0x0044C639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatRequestData);
		}

		// Token: 0x0601D8E9 RID: 121065 RVA: 0x0044E448 File Offset: 0x0044C648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatRequestData other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.RequestId == other.RequestId && object.Equals(this.CreateBulletRequest, other.CreateBulletRequest) && object.Equals(this.DestroyBulletRequest, other.DestroyBulletRequest) && object.Equals(this.DamageExecuteRequest, other.DamageExecuteRequest) && object.Equals(this.ApplyGameplayEffectRequest, other.ApplyGameplayEffectRequest) && object.Equals(this.RemoveGameplayEffectRequest, other.RemoveGameplayEffectRequest) && object.Equals(this.HitRequest, other.HitRequest) && object.Equals(this.HitEndRequest, other.HitEndRequest) && object.Equals(this.SkillRequest, other.SkillRequest) && object.Equals(this.UseSkillRequest, other.UseSkillRequest) && object.Equals(this.EndSkillRequest, other.EndSkillRequest) && object.Equals(this.PartUpdateRequest, other.PartUpdateRequest) && object.Equals(this.MaterialRequest, other.MaterialRequest) && object.Equals(this.GameplayCueRequest, other.GameplayCueRequest) && object.Equals(this.EntityIsVisibleRequest, other.EntityIsVisibleRequest) && object.Equals(this.SwitchCharacterStateRequest, other.SwitchCharacterStateRequest) && object.Equals(this.LogicStateInitRequest, other.LogicStateInitRequest) && object.Equals(this.SwitchLogicStateRequest, other.SwitchLogicStateRequest) && object.Equals(this.AnimationStateChangedRequest, other.AnimationStateChangedRequest) && object.Equals(this.AnimationStateInitRequest, other.AnimationStateInitRequest) && object.Equals(this.ModifyBulletParamsRequest, other.ModifyBulletParamsRequest) && object.Equals(this.DrownRequest, other.DrownRequest) && object.Equals(this.OrderApplyBuffRequest, other.OrderApplyBuffRequest) && object.Equals(this.OrderRemoveBuffRequest, other.OrderRemoveBuffRequest) && object.Equals(this.ActivateBuffRequest, other.ActivateBuffRequest) && object.Equals(this.OrderRemoveBuffByTagsRequest, other.OrderRemoveBuffByTagsRequest) && object.Equals(this.AiInformationRequest, other.AiInformationRequest) && object.Equals(this.ToughCalcExtraRatioChangeRequest, other.ToughCalcExtraRatioChangeRequest) && object.Equals(this.BattleStateChangeRequest, other.BattleStateChangeRequest) && object.Equals(this.AnimationGameplayTagRequest, other.AnimationGameplayTagRequest) && object.Equals(this.BoneVisibleChangeRequest, other.BoneVisibleChangeRequest) && object.Equals(this.AiBlackboardsRequest, other.AiBlackboardsRequest) && object.Equals(this.AiBlackboardCdRequest, other.AiBlackboardCdRequest) && object.Equals(this.AiHateRequest, other.AiHateRequest) && object.Equals(this.MonsterBoomRequest, other.MonsterBoomRequest) && object.Equals(this.CaughtRequest, other.CaughtRequest) && object.Equals(this.EntityStaticHookMoveRequest, other.EntityStaticHookMoveRequest) && object.Equals(this.ChangeStateRequest, other.ChangeStateRequest) && object.Equals(this.ChangeStateConfirmRequest, other.ChangeStateConfirmRequest) && object.Equals(this.FsmConditionPassRequest, other.FsmConditionPassRequest) && object.Equals(this.BuffStackCountRequest, other.BuffStackCountRequest) && object.Equals(this.ANStartRequest, other.ANStartRequest) && object.Equals(this.UseSkillFailRequest, other.UseSkillFailRequest) && object.Equals(this.EnterViewDirectionRequest, other.EnterViewDirectionRequest) && object.Equals(this.ExitViewDirectionRequest, other.ExitViewDirectionRequest) && object.Equals(this.PassiveSkillAddRequest, other.PassiveSkillAddRequest) && object.Equals(this.InterruptSkillInDelayRequest, other.InterruptSkillInDelayRequest) && object.Equals(this.TriggerExitSkillRequest, other.TriggerExitSkillRequest) && object.Equals(this.ActorVisibleRequest, other.ActorVisibleRequest) && object.Equals(this.BuffEffectRequest, other.BuffEffectRequest) && object.Equals(this.FragileChangeRequest, other.FragileChangeRequest) && object.Equals(this.RTimeStopRequest, other.RTimeStopRequest) && object.Equals(this.DrownEndTeleportRequest, other.DrownEndTeleportRequest) && object.Equals(this.MonsterDrownRequest, other.MonsterDrownRequest) && object.Equals(this.PassiveSkillRemoveRequest, other.PassiveSkillRemoveRequest) && object.Equals(this.RTimeStopInstRequest, other.RTimeStopInstRequest) && object.Equals(this.FsmStateBehaviorRequest, other.FsmStateBehaviorRequest) && object.Equals(this.FsmPlayMontageRequest, other.FsmPlayMontageRequest) && object.Equals(this.RTimeStopAnimRequest, other.RTimeStopAnimRequest) && object.Equals(this.SwitchRoleRequest, other.SwitchRoleRequest) && object.Equals(this.GameplayTagRequest, other.GameplayTagRequest) && object.Equals(this.ExecuteQteRequest, other.ExecuteQteRequest) && object.Equals(this.CombineEntitiesRequest, other.CombineEntitiesRequest) && object.Equals(this.DissolveCombineRelationRequest, other.DissolveCombineRelationRequest) && object.Equals(this.ClientCurrentRoleReportRequest, other.ClientCurrentRoleReportRequest) && object.Equals(this.GaSwitchCommonEnemyProCampRequest, other.GaSwitchCommonEnemyProCampRequest) && object.Equals(this.ChangeSummonEntityStateRequest, other.ChangeSummonEntityStateRequest) && object.Equals(this.CombatMaxCaseMessageRequest, other.CombatMaxCaseMessageRequest) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D8EA RID: 121066 RVA: 0x0044EA28 File Offset: 0x0044CC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.RequestId != 0)
			{
				num ^= this.RequestId.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CreateBulletRequest)
			{
				num ^= this.CreateBulletRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DestroyBulletRequest)
			{
				num ^= this.DestroyBulletRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DamageExecuteRequest)
			{
				num ^= this.DamageExecuteRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest)
			{
				num ^= this.ApplyGameplayEffectRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest)
			{
				num ^= this.RemoveGameplayEffectRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitRequest)
			{
				num ^= this.HitRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitEndRequest)
			{
				num ^= this.HitEndRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SkillRequest)
			{
				num ^= this.SkillRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillRequest)
			{
				num ^= this.UseSkillRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EndSkillRequest)
			{
				num ^= this.EndSkillRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PartUpdateRequest)
			{
				num ^= this.PartUpdateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MaterialRequest)
			{
				num ^= this.MaterialRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayCueRequest)
			{
				num ^= this.GameplayCueRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityIsVisibleRequest)
			{
				num ^= this.EntityIsVisibleRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest)
			{
				num ^= this.SwitchCharacterStateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.LogicStateInitRequest)
			{
				num ^= this.LogicStateInitRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchLogicStateRequest)
			{
				num ^= this.SwitchLogicStateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateChangedRequest)
			{
				num ^= this.AnimationStateChangedRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateInitRequest)
			{
				num ^= this.AnimationStateInitRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest)
			{
				num ^= this.ModifyBulletParamsRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownRequest)
			{
				num ^= this.DrownRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderApplyBuffRequest)
			{
				num ^= this.OrderApplyBuffRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest)
			{
				num ^= this.OrderRemoveBuffRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActivateBuffRequest)
			{
				num ^= this.ActivateBuffRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest)
			{
				num ^= this.OrderRemoveBuffByTagsRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiInformationRequest)
			{
				num ^= this.AiInformationRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest)
			{
				num ^= this.ToughCalcExtraRatioChangeRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BattleStateChangeRequest)
			{
				num ^= this.BattleStateChangeRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest)
			{
				num ^= this.AnimationGameplayTagRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest)
			{
				num ^= this.BoneVisibleChangeRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardsRequest)
			{
				num ^= this.AiBlackboardsRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardCdRequest)
			{
				num ^= this.AiBlackboardCdRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiHateRequest)
			{
				num ^= this.AiHateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterBoomRequest)
			{
				num ^= this.MonsterBoomRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CaughtRequest)
			{
				num ^= this.CaughtRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest)
			{
				num ^= this.EntityStaticHookMoveRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateRequest)
			{
				num ^= this.ChangeStateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest)
			{
				num ^= this.ChangeStateConfirmRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmConditionPassRequest)
			{
				num ^= this.FsmConditionPassRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffStackCountRequest)
			{
				num ^= this.BuffStackCountRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ANStartRequest)
			{
				num ^= this.ANStartRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillFailRequest)
			{
				num ^= this.UseSkillFailRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EnterViewDirectionRequest)
			{
				num ^= this.EnterViewDirectionRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExitViewDirectionRequest)
			{
				num ^= this.ExitViewDirectionRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillAddRequest)
			{
				num ^= this.PassiveSkillAddRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest)
			{
				num ^= this.InterruptSkillInDelayRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.TriggerExitSkillRequest)
			{
				num ^= this.TriggerExitSkillRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActorVisibleRequest)
			{
				num ^= this.ActorVisibleRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffEffectRequest)
			{
				num ^= this.BuffEffectRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FragileChangeRequest)
			{
				num ^= this.FragileChangeRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopRequest)
			{
				num ^= this.RTimeStopRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownEndTeleportRequest)
			{
				num ^= this.DrownEndTeleportRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterDrownRequest)
			{
				num ^= this.MonsterDrownRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest)
			{
				num ^= this.PassiveSkillRemoveRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopInstRequest)
			{
				num ^= this.RTimeStopInstRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest)
			{
				num ^= this.FsmStateBehaviorRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmPlayMontageRequest)
			{
				num ^= this.FsmPlayMontageRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopAnimRequest)
			{
				num ^= this.RTimeStopAnimRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchRoleRequest)
			{
				num ^= this.SwitchRoleRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayTagRequest)
			{
				num ^= this.GameplayTagRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExecuteQteRequest)
			{
				num ^= this.ExecuteQteRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombineEntitiesRequest)
			{
				num ^= this.CombineEntitiesRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest)
			{
				num ^= this.DissolveCombineRelationRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest)
			{
				num ^= this.ClientCurrentRoleReportRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest)
			{
				num ^= this.GaSwitchCommonEnemyProCampRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest)
			{
				num ^= this.ChangeSummonEntityStateRequest.GetHashCode();
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest)
			{
				num ^= this.CombatMaxCaseMessageRequest.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D8EB RID: 121067 RVA: 0x0044F0C8 File Offset: 0x0044D2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D8EC RID: 121068 RVA: 0x0044F0D5 File Offset: 0x0044D2D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D8ED RID: 121069 RVA: 0x0044F0E0 File Offset: 0x0044D2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.RequestId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RequestId);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CreateBulletRequest)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CreateBulletRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DestroyBulletRequest)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.DestroyBulletRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DamageExecuteRequest)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.DamageExecuteRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ApplyGameplayEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RemoveGameplayEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitRequest)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.HitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitEndRequest)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.HitEndRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SkillRequest)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillRequest)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.UseSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EndSkillRequest)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.EndSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PartUpdateRequest)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PartUpdateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MaterialRequest)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MaterialRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayCueRequest)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.GameplayCueRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityIsVisibleRequest)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.EntityIsVisibleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.SwitchCharacterStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.LogicStateInitRequest)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.LogicStateInitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchLogicStateRequest)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.SwitchLogicStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateChangedRequest)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.AnimationStateChangedRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateInitRequest)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.AnimationStateInitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.ModifyBulletParamsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownRequest)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.DrownRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderApplyBuffRequest)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.OrderApplyBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.OrderRemoveBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActivateBuffRequest)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.ActivateBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.OrderRemoveBuffByTagsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiInformationRequest)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.AiInformationRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest)
			{
				output.WriteRawTag(234, 1);
				output.WriteMessage(this.ToughCalcExtraRatioChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BattleStateChangeRequest)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.BattleStateChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.AnimationGameplayTagRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest)
			{
				output.WriteRawTag(130, 2);
				output.WriteMessage(this.BoneVisibleChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardsRequest)
			{
				output.WriteRawTag(138, 2);
				output.WriteMessage(this.AiBlackboardsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardCdRequest)
			{
				output.WriteRawTag(146, 2);
				output.WriteMessage(this.AiBlackboardCdRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiHateRequest)
			{
				output.WriteRawTag(154, 2);
				output.WriteMessage(this.AiHateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterBoomRequest)
			{
				output.WriteRawTag(162, 2);
				output.WriteMessage(this.MonsterBoomRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CaughtRequest)
			{
				output.WriteRawTag(170, 2);
				output.WriteMessage(this.CaughtRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest)
			{
				output.WriteRawTag(178, 2);
				output.WriteMessage(this.EntityStaticHookMoveRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateRequest)
			{
				output.WriteRawTag(186, 2);
				output.WriteMessage(this.ChangeStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest)
			{
				output.WriteRawTag(194, 2);
				output.WriteMessage(this.ChangeStateConfirmRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmConditionPassRequest)
			{
				output.WriteRawTag(202, 2);
				output.WriteMessage(this.FsmConditionPassRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffStackCountRequest)
			{
				output.WriteRawTag(210, 2);
				output.WriteMessage(this.BuffStackCountRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ANStartRequest)
			{
				output.WriteRawTag(218, 2);
				output.WriteMessage(this.ANStartRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillFailRequest)
			{
				output.WriteRawTag(226, 2);
				output.WriteMessage(this.UseSkillFailRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EnterViewDirectionRequest)
			{
				output.WriteRawTag(234, 2);
				output.WriteMessage(this.EnterViewDirectionRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExitViewDirectionRequest)
			{
				output.WriteRawTag(242, 2);
				output.WriteMessage(this.ExitViewDirectionRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillAddRequest)
			{
				output.WriteRawTag(250, 2);
				output.WriteMessage(this.PassiveSkillAddRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest)
			{
				output.WriteRawTag(138, 3);
				output.WriteMessage(this.InterruptSkillInDelayRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.TriggerExitSkillRequest)
			{
				output.WriteRawTag(146, 3);
				output.WriteMessage(this.TriggerExitSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActorVisibleRequest)
			{
				output.WriteRawTag(186, 3);
				output.WriteMessage(this.ActorVisibleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffEffectRequest)
			{
				output.WriteRawTag(194, 3);
				output.WriteMessage(this.BuffEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FragileChangeRequest)
			{
				output.WriteRawTag(202, 3);
				output.WriteMessage(this.FragileChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopRequest)
			{
				output.WriteRawTag(210, 3);
				output.WriteMessage(this.RTimeStopRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownEndTeleportRequest)
			{
				output.WriteRawTag(218, 3);
				output.WriteMessage(this.DrownEndTeleportRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterDrownRequest)
			{
				output.WriteRawTag(226, 3);
				output.WriteMessage(this.MonsterDrownRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest)
			{
				output.WriteRawTag(234, 3);
				output.WriteMessage(this.PassiveSkillRemoveRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopInstRequest)
			{
				output.WriteRawTag(242, 3);
				output.WriteMessage(this.RTimeStopInstRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest)
			{
				output.WriteRawTag(250, 3);
				output.WriteMessage(this.FsmStateBehaviorRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmPlayMontageRequest)
			{
				output.WriteRawTag(130, 4);
				output.WriteMessage(this.FsmPlayMontageRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopAnimRequest)
			{
				output.WriteRawTag(138, 4);
				output.WriteMessage(this.RTimeStopAnimRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchRoleRequest)
			{
				output.WriteRawTag(146, 4);
				output.WriteMessage(this.SwitchRoleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayTagRequest)
			{
				output.WriteRawTag(154, 4);
				output.WriteMessage(this.GameplayTagRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExecuteQteRequest)
			{
				output.WriteRawTag(162, 4);
				output.WriteMessage(this.ExecuteQteRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombineEntitiesRequest)
			{
				output.WriteRawTag(170, 4);
				output.WriteMessage(this.CombineEntitiesRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest)
			{
				output.WriteRawTag(178, 4);
				output.WriteMessage(this.DissolveCombineRelationRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest)
			{
				output.WriteRawTag(186, 4);
				output.WriteMessage(this.ClientCurrentRoleReportRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest)
			{
				output.WriteRawTag(194, 4);
				output.WriteMessage(this.GaSwitchCommonEnemyProCampRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest)
			{
				output.WriteRawTag(202, 4);
				output.WriteMessage(this.ChangeSummonEntityStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest)
			{
				output.WriteRawTag(154, 6);
				output.WriteMessage(this.CombatMaxCaseMessageRequest);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D8EE RID: 121070 RVA: 0x0044F9E8 File Offset: 0x0044DBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.RequestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RequestId);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CreateBulletRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CreateBulletRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DestroyBulletRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DestroyBulletRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DamageExecuteRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageExecuteRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ApplyGameplayEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RemoveGameplayEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitEndRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitEndRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SkillRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EndSkillRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EndSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PartUpdateRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PartUpdateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MaterialRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MaterialRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayCueRequest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameplayCueRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityIsVisibleRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityIsVisibleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchCharacterStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.LogicStateInitRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LogicStateInitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchLogicStateRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchLogicStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateChangedRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationStateChangedRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateInitRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationStateInitRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ModifyBulletParamsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DrownRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderApplyBuffRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderApplyBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderRemoveBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActivateBuffRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActivateBuffRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrderRemoveBuffByTagsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiInformationRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiInformationRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ToughCalcExtraRatioChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BattleStateChangeRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BattleStateChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimationGameplayTagRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BoneVisibleChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardsRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiBlackboardsRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardCdRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiBlackboardCdRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiHateRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiHateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterBoomRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MonsterBoomRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CaughtRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CaughtRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityStaticHookMoveRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeStateConfirmRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmConditionPassRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmConditionPassRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffStackCountRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffStackCountRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ANStartRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ANStartRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillFailRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.UseSkillFailRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.EnterViewDirectionRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EnterViewDirectionRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExitViewDirectionRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExitViewDirectionRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillAddRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PassiveSkillAddRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.InterruptSkillInDelayRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.TriggerExitSkillRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TriggerExitSkillRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActorVisibleRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActorVisibleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffEffectRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffEffectRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FragileChangeRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FragileChangeRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownEndTeleportRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DrownEndTeleportRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterDrownRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MonsterDrownRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PassiveSkillRemoveRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopInstRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopInstRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmStateBehaviorRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmPlayMontageRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FsmPlayMontageRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopAnimRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RTimeStopAnimRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchRoleRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SwitchRoleRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayTagRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GameplayTagRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExecuteQteRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExecuteQteRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombineEntitiesRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CombineEntitiesRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DissolveCombineRelationRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ClientCurrentRoleReportRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GaSwitchCommonEnemyProCampRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ChangeSummonEntityStateRequest);
			}
			if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CombatMaxCaseMessageRequest);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D8EF RID: 121071 RVA: 0x00450108 File Offset: 0x0044E308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatRequestData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.RequestId != 0)
			{
				this.RequestId = other.RequestId;
			}
			switch (other.MessageCase)
			{
			case CombatRequestData.MessageOneofCase.CreateBulletRequest:
				if (this.CreateBulletRequest == null)
				{
					this.CreateBulletRequest = new CreateBulletRequest();
				}
				this.CreateBulletRequest.MergeFrom(other.CreateBulletRequest);
				break;
			case CombatRequestData.MessageOneofCase.DestroyBulletRequest:
				if (this.DestroyBulletRequest == null)
				{
					this.DestroyBulletRequest = new DestroyBulletRequest();
				}
				this.DestroyBulletRequest.MergeFrom(other.DestroyBulletRequest);
				break;
			case CombatRequestData.MessageOneofCase.DamageExecuteRequest:
				if (this.DamageExecuteRequest == null)
				{
					this.DamageExecuteRequest = new DamageExecuteRequest();
				}
				this.DamageExecuteRequest.MergeFrom(other.DamageExecuteRequest);
				break;
			case CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest:
				if (this.ApplyGameplayEffectRequest == null)
				{
					this.ApplyGameplayEffectRequest = new ApplyGameplayEffectRequest();
				}
				this.ApplyGameplayEffectRequest.MergeFrom(other.ApplyGameplayEffectRequest);
				break;
			case CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest:
				if (this.RemoveGameplayEffectRequest == null)
				{
					this.RemoveGameplayEffectRequest = new RemoveGameplayEffectRequest();
				}
				this.RemoveGameplayEffectRequest.MergeFrom(other.RemoveGameplayEffectRequest);
				break;
			case CombatRequestData.MessageOneofCase.HitRequest:
				if (this.HitRequest == null)
				{
					this.HitRequest = new HitRequest();
				}
				this.HitRequest.MergeFrom(other.HitRequest);
				break;
			case CombatRequestData.MessageOneofCase.HitEndRequest:
				if (this.HitEndRequest == null)
				{
					this.HitEndRequest = new HitEndRequest();
				}
				this.HitEndRequest.MergeFrom(other.HitEndRequest);
				break;
			case CombatRequestData.MessageOneofCase.SkillRequest:
				if (this.SkillRequest == null)
				{
					this.SkillRequest = new SkillRequest();
				}
				this.SkillRequest.MergeFrom(other.SkillRequest);
				break;
			case CombatRequestData.MessageOneofCase.UseSkillRequest:
				if (this.UseSkillRequest == null)
				{
					this.UseSkillRequest = new UseSkillRequest();
				}
				this.UseSkillRequest.MergeFrom(other.UseSkillRequest);
				break;
			case CombatRequestData.MessageOneofCase.EndSkillRequest:
				if (this.EndSkillRequest == null)
				{
					this.EndSkillRequest = new EndSkillRequest();
				}
				this.EndSkillRequest.MergeFrom(other.EndSkillRequest);
				break;
			case CombatRequestData.MessageOneofCase.PartUpdateRequest:
				if (this.PartUpdateRequest == null)
				{
					this.PartUpdateRequest = new PartUpdateRequest();
				}
				this.PartUpdateRequest.MergeFrom(other.PartUpdateRequest);
				break;
			case CombatRequestData.MessageOneofCase.MaterialRequest:
				if (this.MaterialRequest == null)
				{
					this.MaterialRequest = new MaterialRequest();
				}
				this.MaterialRequest.MergeFrom(other.MaterialRequest);
				break;
			case CombatRequestData.MessageOneofCase.GameplayCueRequest:
				if (this.GameplayCueRequest == null)
				{
					this.GameplayCueRequest = new GameplayCueRequest();
				}
				this.GameplayCueRequest.MergeFrom(other.GameplayCueRequest);
				break;
			case CombatRequestData.MessageOneofCase.EntityIsVisibleRequest:
				if (this.EntityIsVisibleRequest == null)
				{
					this.EntityIsVisibleRequest = new EntityIsVisibleRequest();
				}
				this.EntityIsVisibleRequest.MergeFrom(other.EntityIsVisibleRequest);
				break;
			case CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest:
				if (this.SwitchCharacterStateRequest == null)
				{
					this.SwitchCharacterStateRequest = new SwitchCharacterStateRequest();
				}
				this.SwitchCharacterStateRequest.MergeFrom(other.SwitchCharacterStateRequest);
				break;
			case CombatRequestData.MessageOneofCase.LogicStateInitRequest:
				if (this.LogicStateInitRequest == null)
				{
					this.LogicStateInitRequest = new LogicStateInitRequest();
				}
				this.LogicStateInitRequest.MergeFrom(other.LogicStateInitRequest);
				break;
			case CombatRequestData.MessageOneofCase.SwitchLogicStateRequest:
				if (this.SwitchLogicStateRequest == null)
				{
					this.SwitchLogicStateRequest = new SwitchLogicStateRequest();
				}
				this.SwitchLogicStateRequest.MergeFrom(other.SwitchLogicStateRequest);
				break;
			case CombatRequestData.MessageOneofCase.AnimationStateChangedRequest:
				if (this.AnimationStateChangedRequest == null)
				{
					this.AnimationStateChangedRequest = new AnimationStateChangedRequest();
				}
				this.AnimationStateChangedRequest.MergeFrom(other.AnimationStateChangedRequest);
				break;
			case CombatRequestData.MessageOneofCase.AnimationStateInitRequest:
				if (this.AnimationStateInitRequest == null)
				{
					this.AnimationStateInitRequest = new AnimationStateInitRequest();
				}
				this.AnimationStateInitRequest.MergeFrom(other.AnimationStateInitRequest);
				break;
			case CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest:
				if (this.ModifyBulletParamsRequest == null)
				{
					this.ModifyBulletParamsRequest = new ModifyBulletParamsRequest();
				}
				this.ModifyBulletParamsRequest.MergeFrom(other.ModifyBulletParamsRequest);
				break;
			case CombatRequestData.MessageOneofCase.DrownRequest:
				if (this.DrownRequest == null)
				{
					this.DrownRequest = new DrownRequest();
				}
				this.DrownRequest.MergeFrom(other.DrownRequest);
				break;
			case CombatRequestData.MessageOneofCase.OrderApplyBuffRequest:
				if (this.OrderApplyBuffRequest == null)
				{
					this.OrderApplyBuffRequest = new OrderApplyBuffRequest();
				}
				this.OrderApplyBuffRequest.MergeFrom(other.OrderApplyBuffRequest);
				break;
			case CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest:
				if (this.OrderRemoveBuffRequest == null)
				{
					this.OrderRemoveBuffRequest = new OrderRemoveBuffRequest();
				}
				this.OrderRemoveBuffRequest.MergeFrom(other.OrderRemoveBuffRequest);
				break;
			case CombatRequestData.MessageOneofCase.ActivateBuffRequest:
				if (this.ActivateBuffRequest == null)
				{
					this.ActivateBuffRequest = new ActivateBuffRequest();
				}
				this.ActivateBuffRequest.MergeFrom(other.ActivateBuffRequest);
				break;
			case CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest:
				if (this.OrderRemoveBuffByTagsRequest == null)
				{
					this.OrderRemoveBuffByTagsRequest = new OrderRemoveBuffByTagsRequest();
				}
				this.OrderRemoveBuffByTagsRequest.MergeFrom(other.OrderRemoveBuffByTagsRequest);
				break;
			case CombatRequestData.MessageOneofCase.AiInformationRequest:
				if (this.AiInformationRequest == null)
				{
					this.AiInformationRequest = new AiInformationRequest();
				}
				this.AiInformationRequest.MergeFrom(other.AiInformationRequest);
				break;
			case CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest:
				if (this.ToughCalcExtraRatioChangeRequest == null)
				{
					this.ToughCalcExtraRatioChangeRequest = new ToughCalcExtraRatioChangeRequest();
				}
				this.ToughCalcExtraRatioChangeRequest.MergeFrom(other.ToughCalcExtraRatioChangeRequest);
				break;
			case CombatRequestData.MessageOneofCase.BattleStateChangeRequest:
				if (this.BattleStateChangeRequest == null)
				{
					this.BattleStateChangeRequest = new BattleStateChangeRequest();
				}
				this.BattleStateChangeRequest.MergeFrom(other.BattleStateChangeRequest);
				break;
			case CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest:
				if (this.AnimationGameplayTagRequest == null)
				{
					this.AnimationGameplayTagRequest = new AnimationGameplayTagRequest();
				}
				this.AnimationGameplayTagRequest.MergeFrom(other.AnimationGameplayTagRequest);
				break;
			case CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest:
				if (this.BoneVisibleChangeRequest == null)
				{
					this.BoneVisibleChangeRequest = new BoneVisibleChangeRequest();
				}
				this.BoneVisibleChangeRequest.MergeFrom(other.BoneVisibleChangeRequest);
				break;
			case CombatRequestData.MessageOneofCase.AiBlackboardsRequest:
				if (this.AiBlackboardsRequest == null)
				{
					this.AiBlackboardsRequest = new AiBlackboardsRequest();
				}
				this.AiBlackboardsRequest.MergeFrom(other.AiBlackboardsRequest);
				break;
			case CombatRequestData.MessageOneofCase.AiBlackboardCdRequest:
				if (this.AiBlackboardCdRequest == null)
				{
					this.AiBlackboardCdRequest = new AiBlackboardCdRequest();
				}
				this.AiBlackboardCdRequest.MergeFrom(other.AiBlackboardCdRequest);
				break;
			case CombatRequestData.MessageOneofCase.AiHateRequest:
				if (this.AiHateRequest == null)
				{
					this.AiHateRequest = new AiHateRequest();
				}
				this.AiHateRequest.MergeFrom(other.AiHateRequest);
				break;
			case CombatRequestData.MessageOneofCase.MonsterBoomRequest:
				if (this.MonsterBoomRequest == null)
				{
					this.MonsterBoomRequest = new MonsterBoomRequest();
				}
				this.MonsterBoomRequest.MergeFrom(other.MonsterBoomRequest);
				break;
			case CombatRequestData.MessageOneofCase.CaughtRequest:
				if (this.CaughtRequest == null)
				{
					this.CaughtRequest = new CaughtRequest();
				}
				this.CaughtRequest.MergeFrom(other.CaughtRequest);
				break;
			case CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest:
				if (this.EntityStaticHookMoveRequest == null)
				{
					this.EntityStaticHookMoveRequest = new EntityStaticHookMoveRequest();
				}
				this.EntityStaticHookMoveRequest.MergeFrom(other.EntityStaticHookMoveRequest);
				break;
			case CombatRequestData.MessageOneofCase.ChangeStateRequest:
				if (this.ChangeStateRequest == null)
				{
					this.ChangeStateRequest = new ChangeStateRequest();
				}
				this.ChangeStateRequest.MergeFrom(other.ChangeStateRequest);
				break;
			case CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest:
				if (this.ChangeStateConfirmRequest == null)
				{
					this.ChangeStateConfirmRequest = new ChangeStateConfirmRequest();
				}
				this.ChangeStateConfirmRequest.MergeFrom(other.ChangeStateConfirmRequest);
				break;
			case CombatRequestData.MessageOneofCase.FsmConditionPassRequest:
				if (this.FsmConditionPassRequest == null)
				{
					this.FsmConditionPassRequest = new FsmConditionPassRequest();
				}
				this.FsmConditionPassRequest.MergeFrom(other.FsmConditionPassRequest);
				break;
			case CombatRequestData.MessageOneofCase.BuffStackCountRequest:
				if (this.BuffStackCountRequest == null)
				{
					this.BuffStackCountRequest = new BuffStackCountRequest();
				}
				this.BuffStackCountRequest.MergeFrom(other.BuffStackCountRequest);
				break;
			case CombatRequestData.MessageOneofCase.ANStartRequest:
				if (this.ANStartRequest == null)
				{
					this.ANStartRequest = new ANStartRequest();
				}
				this.ANStartRequest.MergeFrom(other.ANStartRequest);
				break;
			case CombatRequestData.MessageOneofCase.UseSkillFailRequest:
				if (this.UseSkillFailRequest == null)
				{
					this.UseSkillFailRequest = new UseSkillFailRequest();
				}
				this.UseSkillFailRequest.MergeFrom(other.UseSkillFailRequest);
				break;
			case CombatRequestData.MessageOneofCase.EnterViewDirectionRequest:
				if (this.EnterViewDirectionRequest == null)
				{
					this.EnterViewDirectionRequest = new EnterViewDirectionRequest();
				}
				this.EnterViewDirectionRequest.MergeFrom(other.EnterViewDirectionRequest);
				break;
			case CombatRequestData.MessageOneofCase.ExitViewDirectionRequest:
				if (this.ExitViewDirectionRequest == null)
				{
					this.ExitViewDirectionRequest = new ExitViewDirectionRequest();
				}
				this.ExitViewDirectionRequest.MergeFrom(other.ExitViewDirectionRequest);
				break;
			case CombatRequestData.MessageOneofCase.PassiveSkillAddRequest:
				if (this.PassiveSkillAddRequest == null)
				{
					this.PassiveSkillAddRequest = new PassiveSkillAddRequest();
				}
				this.PassiveSkillAddRequest.MergeFrom(other.PassiveSkillAddRequest);
				break;
			case CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest:
				if (this.InterruptSkillInDelayRequest == null)
				{
					this.InterruptSkillInDelayRequest = new InterruptSkillInDelayRequest();
				}
				this.InterruptSkillInDelayRequest.MergeFrom(other.InterruptSkillInDelayRequest);
				break;
			case CombatRequestData.MessageOneofCase.TriggerExitSkillRequest:
				if (this.TriggerExitSkillRequest == null)
				{
					this.TriggerExitSkillRequest = new TriggerExitSkillRequest();
				}
				this.TriggerExitSkillRequest.MergeFrom(other.TriggerExitSkillRequest);
				break;
			case CombatRequestData.MessageOneofCase.ActorVisibleRequest:
				if (this.ActorVisibleRequest == null)
				{
					this.ActorVisibleRequest = new ActorVisibleRequest();
				}
				this.ActorVisibleRequest.MergeFrom(other.ActorVisibleRequest);
				break;
			case CombatRequestData.MessageOneofCase.BuffEffectRequest:
				if (this.BuffEffectRequest == null)
				{
					this.BuffEffectRequest = new BuffEffectRequest();
				}
				this.BuffEffectRequest.MergeFrom(other.BuffEffectRequest);
				break;
			case CombatRequestData.MessageOneofCase.FragileChangeRequest:
				if (this.FragileChangeRequest == null)
				{
					this.FragileChangeRequest = new FragileChangeRequest();
				}
				this.FragileChangeRequest.MergeFrom(other.FragileChangeRequest);
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopRequest:
				if (this.RTimeStopRequest == null)
				{
					this.RTimeStopRequest = new RTimeStopRequest();
				}
				this.RTimeStopRequest.MergeFrom(other.RTimeStopRequest);
				break;
			case CombatRequestData.MessageOneofCase.DrownEndTeleportRequest:
				if (this.DrownEndTeleportRequest == null)
				{
					this.DrownEndTeleportRequest = new DrownEndTeleportRequest();
				}
				this.DrownEndTeleportRequest.MergeFrom(other.DrownEndTeleportRequest);
				break;
			case CombatRequestData.MessageOneofCase.MonsterDrownRequest:
				if (this.MonsterDrownRequest == null)
				{
					this.MonsterDrownRequest = new MonsterDrownRequest();
				}
				this.MonsterDrownRequest.MergeFrom(other.MonsterDrownRequest);
				break;
			case CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest:
				if (this.PassiveSkillRemoveRequest == null)
				{
					this.PassiveSkillRemoveRequest = new PassiveSkillRemoveRequest();
				}
				this.PassiveSkillRemoveRequest.MergeFrom(other.PassiveSkillRemoveRequest);
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopInstRequest:
				if (this.RTimeStopInstRequest == null)
				{
					this.RTimeStopInstRequest = new RTimeStopInstRequest();
				}
				this.RTimeStopInstRequest.MergeFrom(other.RTimeStopInstRequest);
				break;
			case CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest:
				if (this.FsmStateBehaviorRequest == null)
				{
					this.FsmStateBehaviorRequest = new FsmStateBehaviorRequest();
				}
				this.FsmStateBehaviorRequest.MergeFrom(other.FsmStateBehaviorRequest);
				break;
			case CombatRequestData.MessageOneofCase.FsmPlayMontageRequest:
				if (this.FsmPlayMontageRequest == null)
				{
					this.FsmPlayMontageRequest = new FsmPlayMontageRequest();
				}
				this.FsmPlayMontageRequest.MergeFrom(other.FsmPlayMontageRequest);
				break;
			case CombatRequestData.MessageOneofCase.RTimeStopAnimRequest:
				if (this.RTimeStopAnimRequest == null)
				{
					this.RTimeStopAnimRequest = new RTimeStopAnimRequest();
				}
				this.RTimeStopAnimRequest.MergeFrom(other.RTimeStopAnimRequest);
				break;
			case CombatRequestData.MessageOneofCase.SwitchRoleRequest:
				if (this.SwitchRoleRequest == null)
				{
					this.SwitchRoleRequest = new SwitchRoleRequest();
				}
				this.SwitchRoleRequest.MergeFrom(other.SwitchRoleRequest);
				break;
			case CombatRequestData.MessageOneofCase.GameplayTagRequest:
				if (this.GameplayTagRequest == null)
				{
					this.GameplayTagRequest = new GameplayTagRequest();
				}
				this.GameplayTagRequest.MergeFrom(other.GameplayTagRequest);
				break;
			case CombatRequestData.MessageOneofCase.ExecuteQteRequest:
				if (this.ExecuteQteRequest == null)
				{
					this.ExecuteQteRequest = new ExecuteQteRequest();
				}
				this.ExecuteQteRequest.MergeFrom(other.ExecuteQteRequest);
				break;
			case CombatRequestData.MessageOneofCase.CombineEntitiesRequest:
				if (this.CombineEntitiesRequest == null)
				{
					this.CombineEntitiesRequest = new CombineEntitiesRequest();
				}
				this.CombineEntitiesRequest.MergeFrom(other.CombineEntitiesRequest);
				break;
			case CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest:
				if (this.DissolveCombineRelationRequest == null)
				{
					this.DissolveCombineRelationRequest = new DissolveCombineRelationRequest();
				}
				this.DissolveCombineRelationRequest.MergeFrom(other.DissolveCombineRelationRequest);
				break;
			case CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest:
				if (this.ClientCurrentRoleReportRequest == null)
				{
					this.ClientCurrentRoleReportRequest = new ClientCurrentRoleReportRequest();
				}
				this.ClientCurrentRoleReportRequest.MergeFrom(other.ClientCurrentRoleReportRequest);
				break;
			case CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest:
				if (this.GaSwitchCommonEnemyProCampRequest == null)
				{
					this.GaSwitchCommonEnemyProCampRequest = new GaSwitchCommonEnemyProCampRequest();
				}
				this.GaSwitchCommonEnemyProCampRequest.MergeFrom(other.GaSwitchCommonEnemyProCampRequest);
				break;
			case CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest:
				if (this.ChangeSummonEntityStateRequest == null)
				{
					this.ChangeSummonEntityStateRequest = new ChangeSummonEntityStateRequest();
				}
				this.ChangeSummonEntityStateRequest.MergeFrom(other.ChangeSummonEntityStateRequest);
				break;
			case CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest:
				if (this.CombatMaxCaseMessageRequest == null)
				{
					this.CombatMaxCaseMessageRequest = new CombatMaxCaseMessageRequest();
				}
				this.CombatMaxCaseMessageRequest.MergeFrom(other.CombatMaxCaseMessageRequest);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D8F0 RID: 121072 RVA: 0x00450DB5 File Offset: 0x0044EFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D8F1 RID: 121073 RVA: 0x00450DC0 File Offset: 0x0044EFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 274U)
				{
					if (num <= 138U)
					{
						if (num <= 66U)
						{
							if (num <= 34U)
							{
								if (num <= 16U)
								{
									if (num == 10U)
									{
										if (this.combatCommon_ == null)
										{
											this.CombatCommon = new CombatCommon();
										}
										input.ReadMessage(this.CombatCommon);
										continue;
									}
									if (num == 16U)
									{
										this.RequestId = input.ReadInt32();
										continue;
									}
								}
								else
								{
									if (num == 26U)
									{
										CreateBulletRequest createBulletRequest = new CreateBulletRequest();
										if (this.messageCase_ == CombatRequestData.MessageOneofCase.CreateBulletRequest)
										{
											createBulletRequest.MergeFrom(this.CreateBulletRequest);
										}
										input.ReadMessage(createBulletRequest);
										this.CreateBulletRequest = createBulletRequest;
										continue;
									}
									if (num == 34U)
									{
										DestroyBulletRequest destroyBulletRequest = new DestroyBulletRequest();
										if (this.messageCase_ == CombatRequestData.MessageOneofCase.DestroyBulletRequest)
										{
											destroyBulletRequest.MergeFrom(this.DestroyBulletRequest);
										}
										input.ReadMessage(destroyBulletRequest);
										this.DestroyBulletRequest = destroyBulletRequest;
										continue;
									}
								}
							}
							else if (num <= 50U)
							{
								if (num == 42U)
								{
									DamageExecuteRequest damageExecuteRequest = new DamageExecuteRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.DamageExecuteRequest)
									{
										damageExecuteRequest.MergeFrom(this.DamageExecuteRequest);
									}
									input.ReadMessage(damageExecuteRequest);
									this.DamageExecuteRequest = damageExecuteRequest;
									continue;
								}
								if (num == 50U)
								{
									ApplyGameplayEffectRequest applyGameplayEffectRequest = new ApplyGameplayEffectRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.ApplyGameplayEffectRequest)
									{
										applyGameplayEffectRequest.MergeFrom(this.ApplyGameplayEffectRequest);
									}
									input.ReadMessage(applyGameplayEffectRequest);
									this.ApplyGameplayEffectRequest = applyGameplayEffectRequest;
									continue;
								}
							}
							else
							{
								if (num == 58U)
								{
									RemoveGameplayEffectRequest removeGameplayEffectRequest = new RemoveGameplayEffectRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.RemoveGameplayEffectRequest)
									{
										removeGameplayEffectRequest.MergeFrom(this.RemoveGameplayEffectRequest);
									}
									input.ReadMessage(removeGameplayEffectRequest);
									this.RemoveGameplayEffectRequest = removeGameplayEffectRequest;
									continue;
								}
								if (num == 66U)
								{
									HitRequest hitRequest = new HitRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitRequest)
									{
										hitRequest.MergeFrom(this.HitRequest);
									}
									input.ReadMessage(hitRequest);
									this.HitRequest = hitRequest;
									continue;
								}
							}
						}
						else if (num <= 98U)
						{
							if (num <= 82U)
							{
								if (num == 74U)
								{
									HitEndRequest hitEndRequest = new HitEndRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.HitEndRequest)
									{
										hitEndRequest.MergeFrom(this.HitEndRequest);
									}
									input.ReadMessage(hitEndRequest);
									this.HitEndRequest = hitEndRequest;
									continue;
								}
								if (num == 82U)
								{
									SkillRequest skillRequest = new SkillRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.SkillRequest)
									{
										skillRequest.MergeFrom(this.SkillRequest);
									}
									input.ReadMessage(skillRequest);
									this.SkillRequest = skillRequest;
									continue;
								}
							}
							else
							{
								if (num == 90U)
								{
									UseSkillRequest useSkillRequest = new UseSkillRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillRequest)
									{
										useSkillRequest.MergeFrom(this.UseSkillRequest);
									}
									input.ReadMessage(useSkillRequest);
									this.UseSkillRequest = useSkillRequest;
									continue;
								}
								if (num == 98U)
								{
									EndSkillRequest endSkillRequest = new EndSkillRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.EndSkillRequest)
									{
										endSkillRequest.MergeFrom(this.EndSkillRequest);
									}
									input.ReadMessage(endSkillRequest);
									this.EndSkillRequest = endSkillRequest;
									continue;
								}
							}
						}
						else if (num <= 114U)
						{
							if (num == 106U)
							{
								PartUpdateRequest partUpdateRequest = new PartUpdateRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.PartUpdateRequest)
								{
									partUpdateRequest.MergeFrom(this.PartUpdateRequest);
								}
								input.ReadMessage(partUpdateRequest);
								this.PartUpdateRequest = partUpdateRequest;
								continue;
							}
							if (num == 114U)
							{
								MaterialRequest materialRequest = new MaterialRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.MaterialRequest)
								{
									materialRequest.MergeFrom(this.MaterialRequest);
								}
								input.ReadMessage(materialRequest);
								this.MaterialRequest = materialRequest;
								continue;
							}
						}
						else
						{
							if (num == 122U)
							{
								GameplayCueRequest gameplayCueRequest = new GameplayCueRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayCueRequest)
								{
									gameplayCueRequest.MergeFrom(this.GameplayCueRequest);
								}
								input.ReadMessage(gameplayCueRequest);
								this.GameplayCueRequest = gameplayCueRequest;
								continue;
							}
							if (num == 130U)
							{
								EntityIsVisibleRequest entityIsVisibleRequest = new EntityIsVisibleRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityIsVisibleRequest)
								{
									entityIsVisibleRequest.MergeFrom(this.EntityIsVisibleRequest);
								}
								input.ReadMessage(entityIsVisibleRequest);
								this.EntityIsVisibleRequest = entityIsVisibleRequest;
								continue;
							}
							if (num == 138U)
							{
								SwitchCharacterStateRequest switchCharacterStateRequest = new SwitchCharacterStateRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchCharacterStateRequest)
								{
									switchCharacterStateRequest.MergeFrom(this.SwitchCharacterStateRequest);
								}
								input.ReadMessage(switchCharacterStateRequest);
								this.SwitchCharacterStateRequest = switchCharacterStateRequest;
								continue;
							}
						}
					}
					else if (num <= 202U)
					{
						if (num <= 170U)
						{
							if (num <= 154U)
							{
								if (num == 146U)
								{
									LogicStateInitRequest logicStateInitRequest = new LogicStateInitRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.LogicStateInitRequest)
									{
										logicStateInitRequest.MergeFrom(this.LogicStateInitRequest);
									}
									input.ReadMessage(logicStateInitRequest);
									this.LogicStateInitRequest = logicStateInitRequest;
									continue;
								}
								if (num == 154U)
								{
									SwitchLogicStateRequest switchLogicStateRequest = new SwitchLogicStateRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchLogicStateRequest)
									{
										switchLogicStateRequest.MergeFrom(this.SwitchLogicStateRequest);
									}
									input.ReadMessage(switchLogicStateRequest);
									this.SwitchLogicStateRequest = switchLogicStateRequest;
									continue;
								}
							}
							else
							{
								if (num == 162U)
								{
									AnimationStateChangedRequest animationStateChangedRequest = new AnimationStateChangedRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateChangedRequest)
									{
										animationStateChangedRequest.MergeFrom(this.AnimationStateChangedRequest);
									}
									input.ReadMessage(animationStateChangedRequest);
									this.AnimationStateChangedRequest = animationStateChangedRequest;
									continue;
								}
								if (num == 170U)
								{
									AnimationStateInitRequest animationStateInitRequest = new AnimationStateInitRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationStateInitRequest)
									{
										animationStateInitRequest.MergeFrom(this.AnimationStateInitRequest);
									}
									input.ReadMessage(animationStateInitRequest);
									this.AnimationStateInitRequest = animationStateInitRequest;
									continue;
								}
							}
						}
						else if (num <= 186U)
						{
							if (num == 178U)
							{
								ModifyBulletParamsRequest modifyBulletParamsRequest = new ModifyBulletParamsRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ModifyBulletParamsRequest)
								{
									modifyBulletParamsRequest.MergeFrom(this.ModifyBulletParamsRequest);
								}
								input.ReadMessage(modifyBulletParamsRequest);
								this.ModifyBulletParamsRequest = modifyBulletParamsRequest;
								continue;
							}
							if (num == 186U)
							{
								DrownRequest drownRequest = new DrownRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownRequest)
								{
									drownRequest.MergeFrom(this.DrownRequest);
								}
								input.ReadMessage(drownRequest);
								this.DrownRequest = drownRequest;
								continue;
							}
						}
						else
						{
							if (num == 194U)
							{
								OrderApplyBuffRequest orderApplyBuffRequest = new OrderApplyBuffRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderApplyBuffRequest)
								{
									orderApplyBuffRequest.MergeFrom(this.OrderApplyBuffRequest);
								}
								input.ReadMessage(orderApplyBuffRequest);
								this.OrderApplyBuffRequest = orderApplyBuffRequest;
								continue;
							}
							if (num == 202U)
							{
								OrderRemoveBuffRequest orderRemoveBuffRequest = new OrderRemoveBuffRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffRequest)
								{
									orderRemoveBuffRequest.MergeFrom(this.OrderRemoveBuffRequest);
								}
								input.ReadMessage(orderRemoveBuffRequest);
								this.OrderRemoveBuffRequest = orderRemoveBuffRequest;
								continue;
							}
						}
					}
					else if (num <= 234U)
					{
						if (num <= 218U)
						{
							if (num == 210U)
							{
								ActivateBuffRequest activateBuffRequest = new ActivateBuffRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActivateBuffRequest)
								{
									activateBuffRequest.MergeFrom(this.ActivateBuffRequest);
								}
								input.ReadMessage(activateBuffRequest);
								this.ActivateBuffRequest = activateBuffRequest;
								continue;
							}
							if (num == 218U)
							{
								OrderRemoveBuffByTagsRequest orderRemoveBuffByTagsRequest = new OrderRemoveBuffByTagsRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.OrderRemoveBuffByTagsRequest)
								{
									orderRemoveBuffByTagsRequest.MergeFrom(this.OrderRemoveBuffByTagsRequest);
								}
								input.ReadMessage(orderRemoveBuffByTagsRequest);
								this.OrderRemoveBuffByTagsRequest = orderRemoveBuffByTagsRequest;
								continue;
							}
						}
						else
						{
							if (num == 226U)
							{
								AiInformationRequest aiInformationRequest = new AiInformationRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiInformationRequest)
								{
									aiInformationRequest.MergeFrom(this.AiInformationRequest);
								}
								input.ReadMessage(aiInformationRequest);
								this.AiInformationRequest = aiInformationRequest;
								continue;
							}
							if (num == 234U)
							{
								ToughCalcExtraRatioChangeRequest toughCalcExtraRatioChangeRequest = new ToughCalcExtraRatioChangeRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ToughCalcExtraRatioChangeRequest)
								{
									toughCalcExtraRatioChangeRequest.MergeFrom(this.ToughCalcExtraRatioChangeRequest);
								}
								input.ReadMessage(toughCalcExtraRatioChangeRequest);
								this.ToughCalcExtraRatioChangeRequest = toughCalcExtraRatioChangeRequest;
								continue;
							}
						}
					}
					else if (num <= 250U)
					{
						if (num == 242U)
						{
							BattleStateChangeRequest battleStateChangeRequest = new BattleStateChangeRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.BattleStateChangeRequest)
							{
								battleStateChangeRequest.MergeFrom(this.BattleStateChangeRequest);
							}
							input.ReadMessage(battleStateChangeRequest);
							this.BattleStateChangeRequest = battleStateChangeRequest;
							continue;
						}
						if (num == 250U)
						{
							AnimationGameplayTagRequest animationGameplayTagRequest = new AnimationGameplayTagRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.AnimationGameplayTagRequest)
							{
								animationGameplayTagRequest.MergeFrom(this.AnimationGameplayTagRequest);
							}
							input.ReadMessage(animationGameplayTagRequest);
							this.AnimationGameplayTagRequest = animationGameplayTagRequest;
							continue;
						}
					}
					else
					{
						if (num == 258U)
						{
							BoneVisibleChangeRequest boneVisibleChangeRequest = new BoneVisibleChangeRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.BoneVisibleChangeRequest)
							{
								boneVisibleChangeRequest.MergeFrom(this.BoneVisibleChangeRequest);
							}
							input.ReadMessage(boneVisibleChangeRequest);
							this.BoneVisibleChangeRequest = boneVisibleChangeRequest;
							continue;
						}
						if (num == 266U)
						{
							AiBlackboardsRequest aiBlackboardsRequest = new AiBlackboardsRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardsRequest)
							{
								aiBlackboardsRequest.MergeFrom(this.AiBlackboardsRequest);
							}
							input.ReadMessage(aiBlackboardsRequest);
							this.AiBlackboardsRequest = aiBlackboardsRequest;
							continue;
						}
						if (num == 274U)
						{
							AiBlackboardCdRequest aiBlackboardCdRequest = new AiBlackboardCdRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiBlackboardCdRequest)
							{
								aiBlackboardCdRequest.MergeFrom(this.AiBlackboardCdRequest);
							}
							input.ReadMessage(aiBlackboardCdRequest);
							this.AiBlackboardCdRequest = aiBlackboardCdRequest;
							continue;
						}
					}
				}
				else if (num <= 450U)
				{
					if (num <= 338U)
					{
						if (num <= 306U)
						{
							if (num <= 290U)
							{
								if (num == 282U)
								{
									AiHateRequest aiHateRequest = new AiHateRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.AiHateRequest)
									{
										aiHateRequest.MergeFrom(this.AiHateRequest);
									}
									input.ReadMessage(aiHateRequest);
									this.AiHateRequest = aiHateRequest;
									continue;
								}
								if (num == 290U)
								{
									MonsterBoomRequest monsterBoomRequest = new MonsterBoomRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterBoomRequest)
									{
										monsterBoomRequest.MergeFrom(this.MonsterBoomRequest);
									}
									input.ReadMessage(monsterBoomRequest);
									this.MonsterBoomRequest = monsterBoomRequest;
									continue;
								}
							}
							else
							{
								if (num == 298U)
								{
									CaughtRequest caughtRequest = new CaughtRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.CaughtRequest)
									{
										caughtRequest.MergeFrom(this.CaughtRequest);
									}
									input.ReadMessage(caughtRequest);
									this.CaughtRequest = caughtRequest;
									continue;
								}
								if (num == 306U)
								{
									EntityStaticHookMoveRequest entityStaticHookMoveRequest = new EntityStaticHookMoveRequest();
									if (this.messageCase_ == CombatRequestData.MessageOneofCase.EntityStaticHookMoveRequest)
									{
										entityStaticHookMoveRequest.MergeFrom(this.EntityStaticHookMoveRequest);
									}
									input.ReadMessage(entityStaticHookMoveRequest);
									this.EntityStaticHookMoveRequest = entityStaticHookMoveRequest;
									continue;
								}
							}
						}
						else if (num <= 322U)
						{
							if (num == 314U)
							{
								ChangeStateRequest changeStateRequest = new ChangeStateRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateRequest)
								{
									changeStateRequest.MergeFrom(this.ChangeStateRequest);
								}
								input.ReadMessage(changeStateRequest);
								this.ChangeStateRequest = changeStateRequest;
								continue;
							}
							if (num == 322U)
							{
								ChangeStateConfirmRequest changeStateConfirmRequest = new ChangeStateConfirmRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeStateConfirmRequest)
								{
									changeStateConfirmRequest.MergeFrom(this.ChangeStateConfirmRequest);
								}
								input.ReadMessage(changeStateConfirmRequest);
								this.ChangeStateConfirmRequest = changeStateConfirmRequest;
								continue;
							}
						}
						else
						{
							if (num == 330U)
							{
								FsmConditionPassRequest fsmConditionPassRequest = new FsmConditionPassRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmConditionPassRequest)
								{
									fsmConditionPassRequest.MergeFrom(this.FsmConditionPassRequest);
								}
								input.ReadMessage(fsmConditionPassRequest);
								this.FsmConditionPassRequest = fsmConditionPassRequest;
								continue;
							}
							if (num == 338U)
							{
								BuffStackCountRequest buffStackCountRequest = new BuffStackCountRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffStackCountRequest)
								{
									buffStackCountRequest.MergeFrom(this.BuffStackCountRequest);
								}
								input.ReadMessage(buffStackCountRequest);
								this.BuffStackCountRequest = buffStackCountRequest;
								continue;
							}
						}
					}
					else if (num <= 370U)
					{
						if (num <= 354U)
						{
							if (num == 346U)
							{
								ANStartRequest anstartRequest = new ANStartRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ANStartRequest)
								{
									anstartRequest.MergeFrom(this.ANStartRequest);
								}
								input.ReadMessage(anstartRequest);
								this.ANStartRequest = anstartRequest;
								continue;
							}
							if (num == 354U)
							{
								UseSkillFailRequest useSkillFailRequest = new UseSkillFailRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.UseSkillFailRequest)
								{
									useSkillFailRequest.MergeFrom(this.UseSkillFailRequest);
								}
								input.ReadMessage(useSkillFailRequest);
								this.UseSkillFailRequest = useSkillFailRequest;
								continue;
							}
						}
						else
						{
							if (num == 362U)
							{
								EnterViewDirectionRequest enterViewDirectionRequest = new EnterViewDirectionRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.EnterViewDirectionRequest)
								{
									enterViewDirectionRequest.MergeFrom(this.EnterViewDirectionRequest);
								}
								input.ReadMessage(enterViewDirectionRequest);
								this.EnterViewDirectionRequest = enterViewDirectionRequest;
								continue;
							}
							if (num == 370U)
							{
								ExitViewDirectionRequest exitViewDirectionRequest = new ExitViewDirectionRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExitViewDirectionRequest)
								{
									exitViewDirectionRequest.MergeFrom(this.ExitViewDirectionRequest);
								}
								input.ReadMessage(exitViewDirectionRequest);
								this.ExitViewDirectionRequest = exitViewDirectionRequest;
								continue;
							}
						}
					}
					else if (num <= 394U)
					{
						if (num == 378U)
						{
							PassiveSkillAddRequest passiveSkillAddRequest = new PassiveSkillAddRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillAddRequest)
							{
								passiveSkillAddRequest.MergeFrom(this.PassiveSkillAddRequest);
							}
							input.ReadMessage(passiveSkillAddRequest);
							this.PassiveSkillAddRequest = passiveSkillAddRequest;
							continue;
						}
						if (num == 394U)
						{
							InterruptSkillInDelayRequest interruptSkillInDelayRequest = new InterruptSkillInDelayRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.InterruptSkillInDelayRequest)
							{
								interruptSkillInDelayRequest.MergeFrom(this.InterruptSkillInDelayRequest);
							}
							input.ReadMessage(interruptSkillInDelayRequest);
							this.InterruptSkillInDelayRequest = interruptSkillInDelayRequest;
							continue;
						}
					}
					else
					{
						if (num == 402U)
						{
							TriggerExitSkillRequest triggerExitSkillRequest = new TriggerExitSkillRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.TriggerExitSkillRequest)
							{
								triggerExitSkillRequest.MergeFrom(this.TriggerExitSkillRequest);
							}
							input.ReadMessage(triggerExitSkillRequest);
							this.TriggerExitSkillRequest = triggerExitSkillRequest;
							continue;
						}
						if (num == 442U)
						{
							ActorVisibleRequest actorVisibleRequest = new ActorVisibleRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.ActorVisibleRequest)
							{
								actorVisibleRequest.MergeFrom(this.ActorVisibleRequest);
							}
							input.ReadMessage(actorVisibleRequest);
							this.ActorVisibleRequest = actorVisibleRequest;
							continue;
						}
						if (num == 450U)
						{
							BuffEffectRequest buffEffectRequest = new BuffEffectRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.BuffEffectRequest)
							{
								buffEffectRequest.MergeFrom(this.BuffEffectRequest);
							}
							input.ReadMessage(buffEffectRequest);
							this.BuffEffectRequest = buffEffectRequest;
							continue;
						}
					}
				}
				else if (num <= 522U)
				{
					if (num <= 482U)
					{
						if (num <= 466U)
						{
							if (num == 458U)
							{
								FragileChangeRequest fragileChangeRequest = new FragileChangeRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.FragileChangeRequest)
								{
									fragileChangeRequest.MergeFrom(this.FragileChangeRequest);
								}
								input.ReadMessage(fragileChangeRequest);
								this.FragileChangeRequest = fragileChangeRequest;
								continue;
							}
							if (num == 466U)
							{
								RTimeStopRequest rtimeStopRequest = new RTimeStopRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopRequest)
								{
									rtimeStopRequest.MergeFrom(this.RTimeStopRequest);
								}
								input.ReadMessage(rtimeStopRequest);
								this.RTimeStopRequest = rtimeStopRequest;
								continue;
							}
						}
						else
						{
							if (num == 474U)
							{
								DrownEndTeleportRequest drownEndTeleportRequest = new DrownEndTeleportRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.DrownEndTeleportRequest)
								{
									drownEndTeleportRequest.MergeFrom(this.DrownEndTeleportRequest);
								}
								input.ReadMessage(drownEndTeleportRequest);
								this.DrownEndTeleportRequest = drownEndTeleportRequest;
								continue;
							}
							if (num == 482U)
							{
								MonsterDrownRequest monsterDrownRequest = new MonsterDrownRequest();
								if (this.messageCase_ == CombatRequestData.MessageOneofCase.MonsterDrownRequest)
								{
									monsterDrownRequest.MergeFrom(this.MonsterDrownRequest);
								}
								input.ReadMessage(monsterDrownRequest);
								this.MonsterDrownRequest = monsterDrownRequest;
								continue;
							}
						}
					}
					else if (num <= 498U)
					{
						if (num == 490U)
						{
							PassiveSkillRemoveRequest passiveSkillRemoveRequest = new PassiveSkillRemoveRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.PassiveSkillRemoveRequest)
							{
								passiveSkillRemoveRequest.MergeFrom(this.PassiveSkillRemoveRequest);
							}
							input.ReadMessage(passiveSkillRemoveRequest);
							this.PassiveSkillRemoveRequest = passiveSkillRemoveRequest;
							continue;
						}
						if (num == 498U)
						{
							RTimeStopInstRequest rtimeStopInstRequest = new RTimeStopInstRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopInstRequest)
							{
								rtimeStopInstRequest.MergeFrom(this.RTimeStopInstRequest);
							}
							input.ReadMessage(rtimeStopInstRequest);
							this.RTimeStopInstRequest = rtimeStopInstRequest;
							continue;
						}
					}
					else
					{
						if (num == 506U)
						{
							FsmStateBehaviorRequest fsmStateBehaviorRequest = new FsmStateBehaviorRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmStateBehaviorRequest)
							{
								fsmStateBehaviorRequest.MergeFrom(this.FsmStateBehaviorRequest);
							}
							input.ReadMessage(fsmStateBehaviorRequest);
							this.FsmStateBehaviorRequest = fsmStateBehaviorRequest;
							continue;
						}
						if (num == 514U)
						{
							FsmPlayMontageRequest fsmPlayMontageRequest = new FsmPlayMontageRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.FsmPlayMontageRequest)
							{
								fsmPlayMontageRequest.MergeFrom(this.FsmPlayMontageRequest);
							}
							input.ReadMessage(fsmPlayMontageRequest);
							this.FsmPlayMontageRequest = fsmPlayMontageRequest;
							continue;
						}
						if (num == 522U)
						{
							RTimeStopAnimRequest rtimeStopAnimRequest = new RTimeStopAnimRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.RTimeStopAnimRequest)
							{
								rtimeStopAnimRequest.MergeFrom(this.RTimeStopAnimRequest);
							}
							input.ReadMessage(rtimeStopAnimRequest);
							this.RTimeStopAnimRequest = rtimeStopAnimRequest;
							continue;
						}
					}
				}
				else if (num <= 554U)
				{
					if (num <= 538U)
					{
						if (num == 530U)
						{
							SwitchRoleRequest switchRoleRequest = new SwitchRoleRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.SwitchRoleRequest)
							{
								switchRoleRequest.MergeFrom(this.SwitchRoleRequest);
							}
							input.ReadMessage(switchRoleRequest);
							this.SwitchRoleRequest = switchRoleRequest;
							continue;
						}
						if (num == 538U)
						{
							GameplayTagRequest gameplayTagRequest = new GameplayTagRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.GameplayTagRequest)
							{
								gameplayTagRequest.MergeFrom(this.GameplayTagRequest);
							}
							input.ReadMessage(gameplayTagRequest);
							this.GameplayTagRequest = gameplayTagRequest;
							continue;
						}
					}
					else
					{
						if (num == 546U)
						{
							ExecuteQteRequest executeQteRequest = new ExecuteQteRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.ExecuteQteRequest)
							{
								executeQteRequest.MergeFrom(this.ExecuteQteRequest);
							}
							input.ReadMessage(executeQteRequest);
							this.ExecuteQteRequest = executeQteRequest;
							continue;
						}
						if (num == 554U)
						{
							CombineEntitiesRequest combineEntitiesRequest = new CombineEntitiesRequest();
							if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombineEntitiesRequest)
							{
								combineEntitiesRequest.MergeFrom(this.CombineEntitiesRequest);
							}
							input.ReadMessage(combineEntitiesRequest);
							this.CombineEntitiesRequest = combineEntitiesRequest;
							continue;
						}
					}
				}
				else if (num <= 570U)
				{
					if (num == 562U)
					{
						DissolveCombineRelationRequest dissolveCombineRelationRequest = new DissolveCombineRelationRequest();
						if (this.messageCase_ == CombatRequestData.MessageOneofCase.DissolveCombineRelationRequest)
						{
							dissolveCombineRelationRequest.MergeFrom(this.DissolveCombineRelationRequest);
						}
						input.ReadMessage(dissolveCombineRelationRequest);
						this.DissolveCombineRelationRequest = dissolveCombineRelationRequest;
						continue;
					}
					if (num == 570U)
					{
						ClientCurrentRoleReportRequest clientCurrentRoleReportRequest = new ClientCurrentRoleReportRequest();
						if (this.messageCase_ == CombatRequestData.MessageOneofCase.ClientCurrentRoleReportRequest)
						{
							clientCurrentRoleReportRequest.MergeFrom(this.ClientCurrentRoleReportRequest);
						}
						input.ReadMessage(clientCurrentRoleReportRequest);
						this.ClientCurrentRoleReportRequest = clientCurrentRoleReportRequest;
						continue;
					}
				}
				else
				{
					if (num == 578U)
					{
						GaSwitchCommonEnemyProCampRequest gaSwitchCommonEnemyProCampRequest = new GaSwitchCommonEnemyProCampRequest();
						if (this.messageCase_ == CombatRequestData.MessageOneofCase.GaSwitchCommonEnemyProCampRequest)
						{
							gaSwitchCommonEnemyProCampRequest.MergeFrom(this.GaSwitchCommonEnemyProCampRequest);
						}
						input.ReadMessage(gaSwitchCommonEnemyProCampRequest);
						this.GaSwitchCommonEnemyProCampRequest = gaSwitchCommonEnemyProCampRequest;
						continue;
					}
					if (num == 586U)
					{
						ChangeSummonEntityStateRequest changeSummonEntityStateRequest = new ChangeSummonEntityStateRequest();
						if (this.messageCase_ == CombatRequestData.MessageOneofCase.ChangeSummonEntityStateRequest)
						{
							changeSummonEntityStateRequest.MergeFrom(this.ChangeSummonEntityStateRequest);
						}
						input.ReadMessage(changeSummonEntityStateRequest);
						this.ChangeSummonEntityStateRequest = changeSummonEntityStateRequest;
						continue;
					}
					if (num == 794U)
					{
						CombatMaxCaseMessageRequest combatMaxCaseMessageRequest = new CombatMaxCaseMessageRequest();
						if (this.messageCase_ == CombatRequestData.MessageOneofCase.CombatMaxCaseMessageRequest)
						{
							combatMaxCaseMessageRequest.MergeFrom(this.CombatMaxCaseMessageRequest);
						}
						input.ReadMessage(combatMaxCaseMessageRequest);
						this.CombatMaxCaseMessageRequest = combatMaxCaseMessageRequest;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C7E7 RID: 51175
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C7E8 RID: 51176
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400C7E9 RID: 51177
		private CombatCommon combatCommon_;

		// Token: 0x0400C7EA RID: 51178
		public const int RequestIdFieldNumber = 2;

		// Token: 0x0400C7EB RID: 51179
		private int requestId_;

		// Token: 0x0400C7EC RID: 51180
		public const int CreateBulletRequestFieldNumber = 3;

		// Token: 0x0400C7ED RID: 51181
		public const int DestroyBulletRequestFieldNumber = 4;

		// Token: 0x0400C7EE RID: 51182
		public const int DamageExecuteRequestFieldNumber = 5;

		// Token: 0x0400C7EF RID: 51183
		public const int ApplyGameplayEffectRequestFieldNumber = 6;

		// Token: 0x0400C7F0 RID: 51184
		public const int RemoveGameplayEffectRequestFieldNumber = 7;

		// Token: 0x0400C7F1 RID: 51185
		public const int HitRequestFieldNumber = 8;

		// Token: 0x0400C7F2 RID: 51186
		public const int HitEndRequestFieldNumber = 9;

		// Token: 0x0400C7F3 RID: 51187
		public const int SkillRequestFieldNumber = 10;

		// Token: 0x0400C7F4 RID: 51188
		public const int UseSkillRequestFieldNumber = 11;

		// Token: 0x0400C7F5 RID: 51189
		public const int EndSkillRequestFieldNumber = 12;

		// Token: 0x0400C7F6 RID: 51190
		public const int PartUpdateRequestFieldNumber = 13;

		// Token: 0x0400C7F7 RID: 51191
		public const int MaterialRequestFieldNumber = 14;

		// Token: 0x0400C7F8 RID: 51192
		public const int GameplayCueRequestFieldNumber = 15;

		// Token: 0x0400C7F9 RID: 51193
		public const int EntityIsVisibleRequestFieldNumber = 16;

		// Token: 0x0400C7FA RID: 51194
		public const int SwitchCharacterStateRequestFieldNumber = 17;

		// Token: 0x0400C7FB RID: 51195
		public const int LogicStateInitRequestFieldNumber = 18;

		// Token: 0x0400C7FC RID: 51196
		public const int SwitchLogicStateRequestFieldNumber = 19;

		// Token: 0x0400C7FD RID: 51197
		public const int AnimationStateChangedRequestFieldNumber = 20;

		// Token: 0x0400C7FE RID: 51198
		public const int AnimationStateInitRequestFieldNumber = 21;

		// Token: 0x0400C7FF RID: 51199
		public const int ModifyBulletParamsRequestFieldNumber = 22;

		// Token: 0x0400C800 RID: 51200
		public const int DrownRequestFieldNumber = 23;

		// Token: 0x0400C801 RID: 51201
		public const int OrderApplyBuffRequestFieldNumber = 24;

		// Token: 0x0400C802 RID: 51202
		public const int OrderRemoveBuffRequestFieldNumber = 25;

		// Token: 0x0400C803 RID: 51203
		public const int ActivateBuffRequestFieldNumber = 26;

		// Token: 0x0400C804 RID: 51204
		public const int OrderRemoveBuffByTagsRequestFieldNumber = 27;

		// Token: 0x0400C805 RID: 51205
		public const int AiInformationRequestFieldNumber = 28;

		// Token: 0x0400C806 RID: 51206
		public const int ToughCalcExtraRatioChangeRequestFieldNumber = 29;

		// Token: 0x0400C807 RID: 51207
		public const int BattleStateChangeRequestFieldNumber = 30;

		// Token: 0x0400C808 RID: 51208
		public const int AnimationGameplayTagRequestFieldNumber = 31;

		// Token: 0x0400C809 RID: 51209
		public const int BoneVisibleChangeRequestFieldNumber = 32;

		// Token: 0x0400C80A RID: 51210
		public const int AiBlackboardsRequestFieldNumber = 33;

		// Token: 0x0400C80B RID: 51211
		public const int AiBlackboardCdRequestFieldNumber = 34;

		// Token: 0x0400C80C RID: 51212
		public const int AiHateRequestFieldNumber = 35;

		// Token: 0x0400C80D RID: 51213
		public const int MonsterBoomRequestFieldNumber = 36;

		// Token: 0x0400C80E RID: 51214
		public const int CaughtRequestFieldNumber = 37;

		// Token: 0x0400C80F RID: 51215
		public const int EntityStaticHookMoveRequestFieldNumber = 38;

		// Token: 0x0400C810 RID: 51216
		public const int ChangeStateRequestFieldNumber = 39;

		// Token: 0x0400C811 RID: 51217
		public const int ChangeStateConfirmRequestFieldNumber = 40;

		// Token: 0x0400C812 RID: 51218
		public const int FsmConditionPassRequestFieldNumber = 41;

		// Token: 0x0400C813 RID: 51219
		public const int BuffStackCountRequestFieldNumber = 42;

		// Token: 0x0400C814 RID: 51220
		public const int ANStartRequestFieldNumber = 43;

		// Token: 0x0400C815 RID: 51221
		public const int UseSkillFailRequestFieldNumber = 44;

		// Token: 0x0400C816 RID: 51222
		public const int EnterViewDirectionRequestFieldNumber = 45;

		// Token: 0x0400C817 RID: 51223
		public const int ExitViewDirectionRequestFieldNumber = 46;

		// Token: 0x0400C818 RID: 51224
		public const int PassiveSkillAddRequestFieldNumber = 47;

		// Token: 0x0400C819 RID: 51225
		public const int InterruptSkillInDelayRequestFieldNumber = 49;

		// Token: 0x0400C81A RID: 51226
		public const int TriggerExitSkillRequestFieldNumber = 50;

		// Token: 0x0400C81B RID: 51227
		public const int ActorVisibleRequestFieldNumber = 55;

		// Token: 0x0400C81C RID: 51228
		public const int BuffEffectRequestFieldNumber = 56;

		// Token: 0x0400C81D RID: 51229
		public const int FragileChangeRequestFieldNumber = 57;

		// Token: 0x0400C81E RID: 51230
		public const int RTimeStopRequestFieldNumber = 58;

		// Token: 0x0400C81F RID: 51231
		public const int DrownEndTeleportRequestFieldNumber = 59;

		// Token: 0x0400C820 RID: 51232
		public const int MonsterDrownRequestFieldNumber = 60;

		// Token: 0x0400C821 RID: 51233
		public const int PassiveSkillRemoveRequestFieldNumber = 61;

		// Token: 0x0400C822 RID: 51234
		public const int RTimeStopInstRequestFieldNumber = 62;

		// Token: 0x0400C823 RID: 51235
		public const int FsmStateBehaviorRequestFieldNumber = 63;

		// Token: 0x0400C824 RID: 51236
		public const int FsmPlayMontageRequestFieldNumber = 64;

		// Token: 0x0400C825 RID: 51237
		public const int RTimeStopAnimRequestFieldNumber = 65;

		// Token: 0x0400C826 RID: 51238
		public const int SwitchRoleRequestFieldNumber = 66;

		// Token: 0x0400C827 RID: 51239
		public const int GameplayTagRequestFieldNumber = 67;

		// Token: 0x0400C828 RID: 51240
		public const int ExecuteQteRequestFieldNumber = 68;

		// Token: 0x0400C829 RID: 51241
		public const int CombineEntitiesRequestFieldNumber = 69;

		// Token: 0x0400C82A RID: 51242
		public const int DissolveCombineRelationRequestFieldNumber = 70;

		// Token: 0x0400C82B RID: 51243
		public const int ClientCurrentRoleReportRequestFieldNumber = 71;

		// Token: 0x0400C82C RID: 51244
		public const int GaSwitchCommonEnemyProCampRequestFieldNumber = 72;

		// Token: 0x0400C82D RID: 51245
		public const int ChangeSummonEntityStateRequestFieldNumber = 73;

		// Token: 0x0400C82E RID: 51246
		public const int CombatMaxCaseMessageRequestFieldNumber = 99;

		// Token: 0x0400C82F RID: 51247
		private object message_;

		// Token: 0x0400C830 RID: 51248
		private CombatRequestData.MessageOneofCase messageCase_;

		// Token: 0x02001AA3 RID: 6819
		public enum MessageOneofCase
		{
			// Token: 0x0400D0F5 RID: 53493
			None,
			// Token: 0x0400D0F6 RID: 53494
			CreateBulletRequest = 3,
			// Token: 0x0400D0F7 RID: 53495
			DestroyBulletRequest,
			// Token: 0x0400D0F8 RID: 53496
			DamageExecuteRequest,
			// Token: 0x0400D0F9 RID: 53497
			ApplyGameplayEffectRequest,
			// Token: 0x0400D0FA RID: 53498
			RemoveGameplayEffectRequest,
			// Token: 0x0400D0FB RID: 53499
			HitRequest,
			// Token: 0x0400D0FC RID: 53500
			HitEndRequest,
			// Token: 0x0400D0FD RID: 53501
			SkillRequest,
			// Token: 0x0400D0FE RID: 53502
			UseSkillRequest,
			// Token: 0x0400D0FF RID: 53503
			EndSkillRequest,
			// Token: 0x0400D100 RID: 53504
			PartUpdateRequest,
			// Token: 0x0400D101 RID: 53505
			MaterialRequest,
			// Token: 0x0400D102 RID: 53506
			GameplayCueRequest,
			// Token: 0x0400D103 RID: 53507
			EntityIsVisibleRequest,
			// Token: 0x0400D104 RID: 53508
			SwitchCharacterStateRequest,
			// Token: 0x0400D105 RID: 53509
			LogicStateInitRequest,
			// Token: 0x0400D106 RID: 53510
			SwitchLogicStateRequest,
			// Token: 0x0400D107 RID: 53511
			AnimationStateChangedRequest,
			// Token: 0x0400D108 RID: 53512
			AnimationStateInitRequest,
			// Token: 0x0400D109 RID: 53513
			ModifyBulletParamsRequest,
			// Token: 0x0400D10A RID: 53514
			DrownRequest,
			// Token: 0x0400D10B RID: 53515
			OrderApplyBuffRequest,
			// Token: 0x0400D10C RID: 53516
			OrderRemoveBuffRequest,
			// Token: 0x0400D10D RID: 53517
			ActivateBuffRequest,
			// Token: 0x0400D10E RID: 53518
			OrderRemoveBuffByTagsRequest,
			// Token: 0x0400D10F RID: 53519
			AiInformationRequest,
			// Token: 0x0400D110 RID: 53520
			ToughCalcExtraRatioChangeRequest,
			// Token: 0x0400D111 RID: 53521
			BattleStateChangeRequest,
			// Token: 0x0400D112 RID: 53522
			AnimationGameplayTagRequest,
			// Token: 0x0400D113 RID: 53523
			BoneVisibleChangeRequest,
			// Token: 0x0400D114 RID: 53524
			AiBlackboardsRequest,
			// Token: 0x0400D115 RID: 53525
			AiBlackboardCdRequest,
			// Token: 0x0400D116 RID: 53526
			AiHateRequest,
			// Token: 0x0400D117 RID: 53527
			MonsterBoomRequest,
			// Token: 0x0400D118 RID: 53528
			CaughtRequest,
			// Token: 0x0400D119 RID: 53529
			EntityStaticHookMoveRequest,
			// Token: 0x0400D11A RID: 53530
			ChangeStateRequest,
			// Token: 0x0400D11B RID: 53531
			ChangeStateConfirmRequest,
			// Token: 0x0400D11C RID: 53532
			FsmConditionPassRequest,
			// Token: 0x0400D11D RID: 53533
			BuffStackCountRequest,
			// Token: 0x0400D11E RID: 53534
			ANStartRequest,
			// Token: 0x0400D11F RID: 53535
			UseSkillFailRequest,
			// Token: 0x0400D120 RID: 53536
			EnterViewDirectionRequest,
			// Token: 0x0400D121 RID: 53537
			ExitViewDirectionRequest,
			// Token: 0x0400D122 RID: 53538
			PassiveSkillAddRequest,
			// Token: 0x0400D123 RID: 53539
			InterruptSkillInDelayRequest = 49,
			// Token: 0x0400D124 RID: 53540
			TriggerExitSkillRequest,
			// Token: 0x0400D125 RID: 53541
			ActorVisibleRequest = 55,
			// Token: 0x0400D126 RID: 53542
			BuffEffectRequest,
			// Token: 0x0400D127 RID: 53543
			FragileChangeRequest,
			// Token: 0x0400D128 RID: 53544
			RTimeStopRequest,
			// Token: 0x0400D129 RID: 53545
			DrownEndTeleportRequest,
			// Token: 0x0400D12A RID: 53546
			MonsterDrownRequest,
			// Token: 0x0400D12B RID: 53547
			PassiveSkillRemoveRequest,
			// Token: 0x0400D12C RID: 53548
			RTimeStopInstRequest,
			// Token: 0x0400D12D RID: 53549
			FsmStateBehaviorRequest,
			// Token: 0x0400D12E RID: 53550
			FsmPlayMontageRequest,
			// Token: 0x0400D12F RID: 53551
			RTimeStopAnimRequest,
			// Token: 0x0400D130 RID: 53552
			SwitchRoleRequest,
			// Token: 0x0400D131 RID: 53553
			GameplayTagRequest,
			// Token: 0x0400D132 RID: 53554
			ExecuteQteRequest,
			// Token: 0x0400D133 RID: 53555
			CombineEntitiesRequest,
			// Token: 0x0400D134 RID: 53556
			DissolveCombineRelationRequest,
			// Token: 0x0400D135 RID: 53557
			ClientCurrentRoleReportRequest,
			// Token: 0x0400D136 RID: 53558
			GaSwitchCommonEnemyProCampRequest,
			// Token: 0x0400D137 RID: 53559
			ChangeSummonEntityStateRequest,
			// Token: 0x0400D138 RID: 53560
			CombatMaxCaseMessageRequest = 99
		}
	}
}
