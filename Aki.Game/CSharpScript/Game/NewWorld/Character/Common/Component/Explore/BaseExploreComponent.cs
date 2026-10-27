using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using Google.Protobuf;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02007118 RID: 28952
	[NullableContext(2)]
	[Nullable(0)]
	public class BaseExploreComponent : EntityComponent
	{
		// Token: 0x17009D1B RID: 40219
		// (get) Token: 0x06046ADF RID: 289503 RVA: 0x011CB394 File Offset: 0x011C9594
		// (set) Token: 0x06046AE0 RID: 289504 RVA: 0x011CB404 File Offset: 0x011C9604
		public GrapplingHookPointComponent InteractingTarget
		{
			get
			{
				if (this.InteractingTargetInternal != null && !this.InteractingTargetInternal.Valid)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.CK;
					string message = this.LogKey + "获取InteractingTarget时钩锁点实体已失效, 重置为undefined";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.InteractingTargetInternal = null;
				}
				return this.InteractingTargetInternal;
			}
			set
			{
				GrapplingHookPointComponent interactingTargetInternal = this.InteractingTargetInternal;
				if (interactingTargetInternal != null && interactingTargetInternal.Valid && value != this.InteractingTargetInternal)
				{
					this.InteractingTargetInternal.ChangeHookPointState(EHookPointState.Normal);
				}
				this.InteractingTargetInternal = value;
				this.InteractingTargetEntityId = ((value != null) ? new int?(value.Entity.Id) : null);
			}
		}

		// Token: 0x17009D1C RID: 40220
		// (get) Token: 0x06046AE1 RID: 289505 RVA: 0x011CB468 File Offset: 0x011C9668
		// (set) Token: 0x06046AE2 RID: 289506 RVA: 0x011CB4D8 File Offset: 0x011C96D8
		public GrapplingHookPointComponent FocusTarget
		{
			get
			{
				if (this.FocusTargetInternal != null && !this.FocusTargetInternal.Valid)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.CK;
					string message = this.LogKey + "获取FocusTarget时钩锁点实体已失效, 重置为undefined";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.FocusTargetInternal = null;
				}
				return this.FocusTargetInternal;
			}
			set
			{
				this.FocusTargetInternal = value;
			}
		}

		// Token: 0x17009D1D RID: 40221
		// (get) Token: 0x06046AE3 RID: 289507 RVA: 0x011CB4E1 File Offset: 0x011C96E1
		// (set) Token: 0x06046AE4 RID: 289508 RVA: 0x011CB4E9 File Offset: 0x011C96E9
		public bool FocusTargetLegal
		{
			get
			{
				return this.FocusTargetLegalInternal;
			}
			set
			{
				this.FocusTargetLegalInternal = value;
			}
		}

		// Token: 0x17009D1E RID: 40222
		// (get) Token: 0x06046AE5 RID: 289509 RVA: 0x011CB4F2 File Offset: 0x011C96F2
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public new static Type[] Dependencies
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return new Type[]
				{
					typeof(BaseActorComponent),
					typeof(BaseSkillComponent),
					typeof(BaseTagComponent)
				};
			}
		}

		// Token: 0x06046AE6 RID: 289510 RVA: 0x011CB524 File Offset: 0x011C9724
		protected unsafe override bool OnStart()
		{
			this.ActorComponent = base.Entity.GetComponent<BaseActorComponent>();
			this.SkillComponent = base.Entity.GetComponent<BaseSkillComponent>();
			this.TagComponent = base.Entity.GetComponent<BaseTagComponent>();
			if (this.CheckDisableComponent())
			{
				base.Disable("CheckDisableComponent");
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = this.LogKey + "OnExploreComponentStart";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ClientEntityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PendingHighlightSkill", this.PendingHighlightSkill != null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return true;
		}

		// Token: 0x06046AE7 RID: 289511 RVA: 0x011CB5F5 File Offset: 0x011C97F5
		protected virtual bool CheckDisableComponent()
		{
			return false;
		}

		// Token: 0x06046AE8 RID: 289512 RVA: 0x011CB5F8 File Offset: 0x011C97F8
		protected override bool OnEnd()
		{
			if (this.CheckDisableComponent())
			{
				return true;
			}
			HighlightExploreSkillLogic highlightLogic = this.HighlightLogic;
			if (highlightLogic != null)
			{
				highlightLogic.Dispose();
			}
			this.HighlightLogic = null;
			return true;
		}

		// Token: 0x06046AE9 RID: 289513 RVA: 0x011CB61D File Offset: 0x011C981D
		protected override void OnTick(float delta)
		{
			if (!this.ExploreComponentEnabled)
			{
				return;
			}
			this.OnExploreComponentTick(delta);
		}

		// Token: 0x06046AEA RID: 289514 RVA: 0x011CB630 File Offset: 0x011C9830
		[NullableContext(1)]
		protected unsafe virtual bool OnExploreComponentEnable(string reason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = this.LogKey + "OnExploreComponentEnable";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponentEnabled", this.ExploreComponentEnabled);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (this.ExploreComponentEnabled)
			{
				return false;
			}
			CharacterExploreModel.Instance.RegisterExploreComponent(this);
			this.ExploreComponentEnabled = true;
			this.InitHighlightHandle();
			return true;
		}

		// Token: 0x06046AEB RID: 289515 RVA: 0x011CB6F0 File Offset: 0x011C98F0
		[NullableContext(1)]
		protected unsafe virtual bool OnExploreComponentDisable(string reason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = this.LogKey + "OnExploreComponentDisable";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponentEnabled", this.ExploreComponentEnabled);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (!this.ExploreComponentEnabled)
			{
				return false;
			}
			GrapplingHookPointComponent interactingTarget = this.InteractingTarget;
			if (interactingTarget != null)
			{
				interactingTarget.ChangeHookPointState(EHookPointState.Normal);
			}
			ICompositeSkillSession activeCompositeSession = CharacterExploreModel.Instance.CompositeExploreSkillSession.ActiveCompositeSession;
			if (activeCompositeSession != null && activeCompositeSession.EnterSent && !this.IsHookEndByInterrupt)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Character;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = this.LogKey + "OnExploreComponentDisable: 复合技能流程中, 跳过SendHookEndRequest, 等待终止技能发送";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CompositeName", activeCompositeSession.Config.Name);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				this.SendHookEndRequest(this.InteractingTarget, null);
			}
			this.InteractingTarget = null;
			this.CancelLockTarget("OnExploreComponentDisable", true);
			this.ExploreComponentEnabled = false;
			return true;
		}

		// Token: 0x06046AEC RID: 289516 RVA: 0x011CB837 File Offset: 0x011C9A37
		protected virtual void OnExploreComponentTick(float delta)
		{
		}

		// Token: 0x06046AED RID: 289517 RVA: 0x011CB839 File Offset: 0x011C9A39
		protected virtual void OnDetectedTargetChanged(GrapplingHookPointComponent prevTarget)
		{
		}

		// Token: 0x06046AEE RID: 289518 RVA: 0x011CB83B File Offset: 0x011C9A3B
		[NullableContext(1)]
		public virtual void ClearDetectedTarget(string reason)
		{
		}

		// Token: 0x06046AEF RID: 289519 RVA: 0x011CB840 File Offset: 0x011C9A40
		[NullableContext(1)]
		public unsafe bool ForceLockTarget([Nullable(2)] GrapplingHookPointComponent target, string reason)
		{
			if (target == null || !target.Valid)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.CK;
				string message = this.LogKey + "锁定目标失败, 钩锁点实体不合法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", (target != null) ? new int?(target.EntityConfigId) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (target == this.InteractingTarget)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Character;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = this.LogKey + "锁定目标失败, 锁定目标和当前正在交互的目标相同";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Character;
			ELogAuthor author3 = ELogAuthor.CK;
			string message3 = this.LogKey + "锁定目标";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("TargetEntityConfigId", target.EntityConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			this.IsLockingTarget = true;
			this.FocusTargetLegalExceptSkill = true;
			this.SetFocusTarget(target, true);
			return true;
		}

		// Token: 0x06046AF0 RID: 289520 RVA: 0x011CB998 File Offset: 0x011C9B98
		[NullableContext(1)]
		public void CancelLockTarget(string reason, bool resetFocusTarget)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = this.LogKey + "取消目标锁定";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.IsLockingTarget = false;
			if (resetFocusTarget)
			{
				this.SetFocusTarget(null, true);
			}
		}

		// Token: 0x06046AF1 RID: 289521 RVA: 0x011CB9EC File Offset: 0x011C9BEC
		public unsafe void SetFocusTarget(GrapplingHookPointComponent target, bool targetLegal = true)
		{
			GrapplingHookPointComponent focusTarget = this.FocusTarget;
			this.FocusTargetLegal = (target != null && target.Valid && targetLegal);
			this.FocusTargetInternal = target;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = this.LogKey + "设置当前焦距目标";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TargetEntityConfigId", (target != null) ? new int?(target.EntityConfigId) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetLegal", target != null && target.Valid && targetLegal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Type", (target != null && target.Valid) ? target.GetHookInteractType() : "None");
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			EventSystem.Instance.Emit(EEventName.ExploreComponentTargetChanged);
			this.OnDetectedTargetChanged(focusTarget);
		}

		// Token: 0x06046AF2 RID: 289522 RVA: 0x011CBAF4 File Offset: 0x011C9CF4
		public global::Vector GetInteractingTargetLocation()
		{
			BaseActorComponent actorComponent = this.ActorComponent;
			if (actorComponent == null || !actorComponent.IsAutonomousProxy)
			{
				GrapplingHookPointComponent simulateInteractingTarget = this.SimulateInteractingTarget;
				return ((simulateInteractingTarget != null) ? simulateInteractingTarget.HookLocation : null) ?? this.SimulateInteractingTargetLocation;
			}
			GrapplingHookPointComponent interactingTarget = this.InteractingTarget;
			if (interactingTarget == null)
			{
				return null;
			}
			return interactingTarget.HookLocation;
		}

		// Token: 0x06046AF3 RID: 289523 RVA: 0x011CBB48 File Offset: 0x011C9D48
		public void InitHighlightHandle()
		{
			if (this.HighlightLogic != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.CK;
				string message = this.LogKey + "高亮模块已经完成初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ClientEntityId", base.Entity.Id);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.HighlightLogic = new HighlightExploreSkillLogic();
			this.HighlightLogic.Init(this);
			Action pendingHighlightSkill = this.PendingHighlightSkill;
			if (pendingHighlightSkill != null)
			{
				pendingHighlightSkill();
			}
			this.PendingHighlightSkill = null;
		}

		// Token: 0x06046AF4 RID: 289524 RVA: 0x011CBBD0 File Offset: 0x011C9DD0
		public unsafe void ShowHighlightExploreSkill(int exploreToolId, float duration, bool? needRevertSkill, string tagName = null, int? itemId = null, bool? needTips = null, bool? autoHideAfterUseExploreSkill = null)
		{
			if (this.HighlightLogic == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.CK;
				string message = this.LogKey + "尝试高亮探索技能时, 组件还未初始化完成, 缓存高亮操作, 考虑修改配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ClientEntityId", base.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreToolId", exploreToolId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Duration", duration);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.PendingHighlightSkill = delegate()
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Character;
					ELogAuthor author2 = ELogAuthor.CK;
					string message2 = this.LogKey + "执行缓存的高亮操作";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ClientEntityId", this.Entity.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ExploreToolId", exploreToolId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Duration", duration);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
					this.ShowHighlightExploreSkill(exploreToolId, duration, needRevertSkill, tagName, itemId, needTips, autoHideAfterUseExploreSkill);
				};
				return;
			}
			this.HighlightLogic.ShowHighlightExploreSkill(exploreToolId, duration, new bool?(needRevertSkill.GetValueOrDefault()), tagName, itemId, new bool?(needTips.GetValueOrDefault()), autoHideAfterUseExploreSkill);
		}

		// Token: 0x06046AF5 RID: 289525 RVA: 0x011CBD20 File Offset: 0x011C9F20
		public unsafe void HideHighlightExploreSkill()
		{
			if (this.HighlightLogic == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.CK;
				string message = this.LogKey + "尝试取消探索技能高亮时, 组件还未初始化完成, 考虑修改配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ClientEntityId", base.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PendingHighlightSkill", this.PendingHighlightSkill != null);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.PendingHighlightSkill = null;
				return;
			}
			this.HighlightLogic.HideHighlightExploreSkill();
		}

		// Token: 0x06046AF6 RID: 289526 RVA: 0x011CBDC8 File Offset: 0x011C9FC8
		public int? GetHighlightSkillId()
		{
			HighlightExploreSkillLogic highlightLogic = this.HighlightLogic;
			if (highlightLogic == null)
			{
				return null;
			}
			return new int?(highlightLogic.GetHighlightSkillId());
		}

		// Token: 0x06046AF7 RID: 289527 RVA: 0x011CBDF4 File Offset: 0x011C9FF4
		public int? GetHighlightExploreToolId()
		{
			HighlightExploreSkillLogic highlightLogic = this.HighlightLogic;
			if (highlightLogic == null)
			{
				return null;
			}
			return new int?(highlightLogic.GetHighlightExploreToolId());
		}

		// Token: 0x06046AF8 RID: 289528 RVA: 0x011CBE20 File Offset: 0x011CA020
		[NullableContext(1)]
		public void HandleSkillIconLogic(bool isAdd, string reason)
		{
			GrapplingHookPointComponent focusTarget = this.FocusTarget;
			int? num = (focusTarget != null) ? focusTarget.GetTagId() : null;
			GrapplingHookPointComponent focusTarget2 = this.FocusTarget;
			int? num2 = (focusTarget2 != null) ? new int?(focusTarget2.GetHighlightTagId()) : null;
			if (this.LevelEventLightingSkill)
			{
				this.CurrentIconTagId = num;
				this.CurrentIconHighlightTagId = num2;
				return;
			}
			this.UpdateHookIconTag(isAdd, num, reason);
			this.UpdateHookIconHighlightTag(isAdd, num2);
		}

		// Token: 0x06046AF9 RID: 289529 RVA: 0x011CBE90 File Offset: 0x011CA090
		public virtual bool CheckAllowLevelEventHighlightSkill()
		{
			return true;
		}

		// Token: 0x06046AFA RID: 289530 RVA: 0x011CBE93 File Offset: 0x011CA093
		public virtual void OnLevelEventHighlightSkillUpdate(bool enabled)
		{
		}

		// Token: 0x06046AFB RID: 289531 RVA: 0x011CBE98 File Offset: 0x011CA098
		[NullableContext(1)]
		public unsafe void UpdateHookIconTag(bool add, int? tagId, string reason)
		{
			int? currentIconTagId = this.CurrentIconTagId;
			if (add)
			{
				if (currentIconTagId != null)
				{
					int? num = currentIconTagId;
					int num2 = 0;
					if (!(num.GetValueOrDefault() == num2 & num != null))
					{
						num = tagId;
						int? num3 = currentIconTagId;
						if (!(num.GetValueOrDefault() == num3.GetValueOrDefault() & num != null == (num3 != null)) && this.TagComponent.HasTag(currentIconTagId.Value))
						{
							this.TagComponent.RemoveTag(new int?(currentIconTagId.Value));
							Log instance = Log.Instance;
							ELogModule module = ELogModule.Character;
							ELogAuthor author = ELogAuthor.CK;
							string message = this.LogKey + "添加定点钩索可用标签时删除旧的定点钩索标签";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("OldTag", GameplayTagUtils.GetNameByTagId(currentIconTagId.Value));
							instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						}
					}
				}
				if (tagId != null)
				{
					int? num3 = tagId;
					int num2 = 0;
					if (!(num3.GetValueOrDefault() == num2 & num3 != null) && !this.TagComponent.HasTag(tagId.Value))
					{
						this.TagComponent.AddTag(new int?(tagId.Value));
						this.CurrentIconTagId = tagId;
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Character;
						ELogAuthor author2 = ELogAuthor.CK;
						string message2 = this.LogKey + "添加定点钩索可用标签";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Reason", reason);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Tag", GameplayTagUtils.GetNameByTagId(tagId.Value));
						instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
						return;
					}
				}
			}
			else if (this.CurrentIconTagId != null)
			{
				int? num3 = this.CurrentIconTagId;
				int num2 = 0;
				if (!(num3.GetValueOrDefault() == num2 & num3 != null) && this.TagComponent.HasTag(this.CurrentIconTagId.Value))
				{
					this.TagComponent.RemoveTag(new int?(this.CurrentIconTagId.Value));
					int value = this.CurrentIconTagId.Value;
					this.CurrentIconTagId = null;
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Character;
					ELogAuthor author3 = ELogAuthor.CK;
					string message3 = this.LogKey + "删除定点钩索可用标签";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Reason", reason);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("OldTag", GameplayTagUtils.GetNameByTagId(value));
					instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				}
			}
		}

		// Token: 0x06046AFC RID: 289532 RVA: 0x011CC1C8 File Offset: 0x011CA3C8
		public unsafe void UpdateHookIconHighlightTag(bool add, int? tagId)
		{
			int? currentIconHighlightTagId = this.CurrentIconHighlightTagId;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = this.LogKey + "更新按钮高亮Tag";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Add", add);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CurrentIconHighlightTagId", this.CurrentIconHighlightTagId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TryAddTagId", tagId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("HasTag", tagId != null && this.TagComponent.HasTag(tagId.Value));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			if ((currentIconHighlightTagId ?? 1) == 0)
			{
				return;
			}
			if (add)
			{
				if (currentIconHighlightTagId != null && currentIconHighlightTagId.GetValueOrDefault() != 0)
				{
					int? num = tagId;
					int? num2 = currentIconHighlightTagId;
					if (!(num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)) && this.TagComponent.HasTag(currentIconHighlightTagId.Value))
					{
						this.TagComponent.RemoveTag(new int?(currentIconHighlightTagId.Value));
					}
				}
				if (tagId != null && tagId.GetValueOrDefault() != 0 && !this.TagComponent.HasTag(tagId.Value))
				{
					this.TagComponent.AddTag(new int?(tagId.Value));
					this.CurrentIconHighlightTagId = tagId;
					return;
				}
			}
			else
			{
				int? num2 = this.CurrentIconHighlightTagId;
				if (num2 != null && num2.GetValueOrDefault() != 0 && this.TagComponent.HasTag(this.CurrentIconHighlightTagId.Value))
				{
					this.TagComponent.RemoveTag(new int?(this.CurrentIconHighlightTagId.Value));
					this.CurrentIconHighlightTagId = null;
				}
			}
		}

		// Token: 0x06046AFD RID: 289533 RVA: 0x011CC3EC File Offset: 0x011CA5EC
		protected void SendHookMovePush()
		{
			GrapplingHookPointComponent interactingTarget = this.InteractingTarget;
			if (interactingTarget != null && interactingTarget.Valid)
			{
				BaseActorComponent actorComponent = this.ActorComponent;
				if (actorComponent != null && actorComponent.IsAutonomousProxy)
				{
					RoleSceneInteractController.SendHookMovePush(base.Entity, interactingTarget);
					return;
				}
			}
		}

		// Token: 0x06046AFE RID: 289534 RVA: 0x011CC438 File Offset: 0x011CA638
		protected unsafe void SendHookTargetRequest(GrapplingHookPointComponent target, [Nullable(1)] Action onFailure, string compositeSessionName = null)
		{
			GrapplingHookPointComponent target2 = target;
			if (target2 != null && target2.Valid)
			{
				BaseActorComponent actorComponent = this.ActorComponent;
				if (actorComponent != null && actorComponent.IsAutonomousProxy)
				{
					HookLockPointRequest hookLockPointRequest = HookLockPointRequest.Create();
					hookLockPointRequest.EntityId = target.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.CK;
					string message = this.LogKey + "SendHookTargetRequest";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", target.EntityConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CompositeSession", compositeSessionName ?? "None");
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					FixHookClientLevelEventExecutor.ExecuteHookActions(FixHookClientLevelEventExecutor.EHookPointStage.ClientHook, target);
					Net.Instance.Call(ERequestMessageId.HookLockPointRequest, hookLockPointRequest, delegate(IMessage msg, Net.CallbackStatus _)
					{
						HookLockPointResponse hookLockPointResponse = (HookLockPointResponse)msg;
						ErrorCode? errorCode = (hookLockPointResponse != null) ? new ErrorCode?(hookLockPointResponse.ErrorCode) : null;
						if (errorCode != null)
						{
							ErrorCode valueOrDefault = errorCode.GetValueOrDefault();
							if (valueOrDefault <= ErrorCode.ErrSceneEntityNotExist)
							{
								if (valueOrDefault == ErrorCode.Success)
								{
									goto IL_18C;
								}
								if (valueOrDefault == ErrorCode.ErrSceneEntityNotExist)
								{
									Log instance2 = Log.Instance;
									ELogModule module2 = ELogModule.Character;
									ELogAuthor author2 = ELogAuthor.CK;
									string message2 = "SendHookTargetRequest错误, 钩锁点不存在";
									<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityConfigId", target.EntityConfigId);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ServerEntityId", target.ServerEntityId);
									instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
									goto IL_18C;
								}
							}
							else if (valueOrDefault == ErrorCode.HookLockPointLocked || valueOrDefault == ErrorCode.HookLockPointConditionNotMet)
							{
								goto IL_18C;
							}
						}
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.Character;
						ELogAuthor author3 = ELogAuthor.CK;
						string message3 = "SendHookTargetRequest错误";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityConfigId", target.EntityConfigId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("ServerEntityId", target.ServerEntityId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("ErrorCode", (hookLockPointResponse != null) ? new ErrorCode?(hookLockPointResponse.ErrorCode) : null);
						instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
						IL_18C:
						if (hookLockPointResponse == null || hookLockPointResponse.ErrorCode > ErrorCode.Success)
						{
							Action onFailure2 = onFailure;
							if (onFailure2 == null)
							{
								return;
							}
							onFailure2();
						}
					}, 0);
					return;
				}
			}
		}

		// Token: 0x06046AFF RID: 289535 RVA: 0x011CC548 File Offset: 0x011CA748
		protected unsafe void SendHookEndRequest(GrapplingHookPointComponent target, string compositeSessionName = null)
		{
			if (target != null && target.Valid)
			{
				BaseActorComponent actorComponent = this.ActorComponent;
				if (actorComponent != null && actorComponent.IsAutonomousProxy)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.CK;
					string message = this.LogKey + "SendHookEndRequest";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", target.EntityConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CompositeSession", compositeSessionName ?? "None");
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					long creatureDataId = target.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
					HookLockPointExitRequest hookLockPointExitRequest = HookLockPointExitRequest.Create();
					hookLockPointExitRequest.EntityId = creatureDataId;
					hookLockPointExitRequest.HookLockPointExitWay = (this.IsHookEndByInterrupt ? HookLockPointExitWay.Midway : HookLockPointExitWay.Endpoint);
					FixHookClientLevelEventExecutor.ExecuteHookActions(this.IsHookEndByInterrupt ? FixHookClientLevelEventExecutor.EHookPointStage.ClientMidway : FixHookClientLevelEventExecutor.EHookPointStage.ClientEndpoint, target);
					Net.Instance.Call(ERequestMessageId.HookLockPointExitRequest, hookLockPointExitRequest, null, 0);
					if (target.WillBeDestroyedAfterHook)
					{
						HookLockPointFinishRequest hookLockPointFinishRequest = HookLockPointFinishRequest.Create();
						hookLockPointFinishRequest.EntityId = creatureDataId;
						Net.Instance.Call(ERequestMessageId.HookLockPointFinishRequest, hookLockPointFinishRequest, null, 0);
						return;
					}
					if (target.WillBeHideAfterHook)
					{
						CreatureController.Instance.SetEntityEnable(target.Entity, false, this.LogKey + "SendHookEndRequest", true);
					}
					return;
				}
			}
		}

		// Token: 0x06046B00 RID: 289536 RVA: 0x011CC695 File Offset: 0x011CA895
		public void SetIsHookEndByInterruptProxy(bool isHookEndByInterrupt)
		{
			this.IsHookEndByInterrupt = isHookEndByInterrupt;
		}

		// Token: 0x06046B01 RID: 289537 RVA: 0x011CC6A0 File Offset: 0x011CA8A0
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			BaseExploreComponent baseExploreComponent = (BaseExploreComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComponent"))
			{
				if (baseExploreComponent.ActorComponent == null)
				{
					this.ActorComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComponent), "ActorComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SkillComponent"))
			{
				if (baseExploreComponent.SkillComponent == null)
				{
					this.SkillComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseSkillComponent>(this.SkillComponent), "SkillComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComponent"))
			{
				if (baseExploreComponent.TagComponent == null)
				{
					this.TagComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("HighlightLogic"))
			{
				if (baseExploreComponent.HighlightLogic == null)
				{
					this.HighlightLogic = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<HighlightExploreSkillLogic>(this.HighlightLogic), "HighlightLogic"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurrentIconTagId"))
			{
				this.CurrentIconTagId = baseExploreComponent.CurrentIconTagId;
			}
			if (base.CanResetComponentProperty("CurrentIconHighlightTagId"))
			{
				this.CurrentIconHighlightTagId = baseExploreComponent.CurrentIconHighlightTagId;
			}
			if (base.CanResetComponentProperty("LevelEventLightingSkill"))
			{
				this.LevelEventLightingSkill = baseExploreComponent.LevelEventLightingSkill;
			}
			if (base.CanResetComponentProperty("InteractingTargetInternal"))
			{
				if (baseExploreComponent.InteractingTargetInternal == null)
				{
					this.InteractingTargetInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<GrapplingHookPointComponent>(this.InteractingTargetInternal), "InteractingTargetInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("InteractingTargetEntityId"))
			{
				this.InteractingTargetEntityId = baseExploreComponent.InteractingTargetEntityId;
			}
			if (base.CanResetComponentProperty("FocusTargetInternal"))
			{
				if (baseExploreComponent.FocusTargetInternal == null)
				{
					this.FocusTargetInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<GrapplingHookPointComponent>(this.FocusTargetInternal), "FocusTargetInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FocusTargetLegalExceptSkill"))
			{
				this.FocusTargetLegalExceptSkill = baseExploreComponent.FocusTargetLegalExceptSkill;
			}
			if (base.CanResetComponentProperty("FocusTargetLegalInternal"))
			{
				this.FocusTargetLegalInternal = baseExploreComponent.FocusTargetLegalInternal;
			}
			if (base.CanResetComponentProperty("SimulateInteractingTarget"))
			{
				if (baseExploreComponent.SimulateInteractingTarget == null)
				{
					this.SimulateInteractingTarget = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<GrapplingHookPointComponent>(this.SimulateInteractingTarget), "SimulateInteractingTarget"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SimulateInteractingTargetLocation"))
			{
				if (baseExploreComponent.SimulateInteractingTargetLocation == null)
				{
					this.SimulateInteractingTargetLocation = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SimulateInteractingTargetLocation), "SimulateInteractingTargetLocation"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SyncEnabled"))
			{
				this.SyncEnabled = baseExploreComponent.SyncEnabled;
			}
			if (base.CanResetComponentProperty("IsHookEndByInterrupt"))
			{
				this.IsHookEndByInterrupt = baseExploreComponent.IsHookEndByInterrupt;
			}
			if (base.CanResetComponentProperty("LogKey"))
			{
				this.LogKey = baseExploreComponent.LogKey;
			}
			if (base.CanResetComponentProperty("ExploreComponentEnabled"))
			{
				this.ExploreComponentEnabled = baseExploreComponent.ExploreComponentEnabled;
			}
			if (base.CanResetComponentProperty("PendingHighlightSkill"))
			{
				if (baseExploreComponent.PendingHighlightSkill == null)
				{
					this.PendingHighlightSkill = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action>(this.PendingHighlightSkill), "PendingHighlightSkill"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsLockingTarget"))
			{
				this.IsLockingTarget = baseExploreComponent.IsLockingTarget;
			}
			return true;
		}

		// Token: 0x040251A3 RID: 151971
		public BaseActorComponent ActorComponent;

		// Token: 0x040251A4 RID: 151972
		protected BaseSkillComponent SkillComponent;

		// Token: 0x040251A5 RID: 151973
		public BaseTagComponent TagComponent;

		// Token: 0x040251A6 RID: 151974
		protected HighlightExploreSkillLogic HighlightLogic;

		// Token: 0x040251A7 RID: 151975
		protected int? CurrentIconTagId;

		// Token: 0x040251A8 RID: 151976
		protected int? CurrentIconHighlightTagId;

		// Token: 0x040251A9 RID: 151977
		protected bool LevelEventLightingSkill;

		// Token: 0x040251AA RID: 151978
		private GrapplingHookPointComponent InteractingTargetInternal;

		// Token: 0x040251AB RID: 151979
		protected int? InteractingTargetEntityId;

		// Token: 0x040251AC RID: 151980
		protected GrapplingHookPointComponent FocusTargetInternal;

		// Token: 0x040251AD RID: 151981
		public bool FocusTargetLegalExceptSkill;

		// Token: 0x040251AE RID: 151982
		protected bool FocusTargetLegalInternal;

		// Token: 0x040251AF RID: 151983
		public GrapplingHookPointComponent SimulateInteractingTarget;

		// Token: 0x040251B0 RID: 151984
		public global::Vector SimulateInteractingTargetLocation;

		// Token: 0x040251B1 RID: 151985
		public bool SyncEnabled = true;

		// Token: 0x040251B2 RID: 151986
		protected bool IsHookEndByInterrupt;

		// Token: 0x040251B3 RID: 151987
		[Nullable(1)]
		public string LogKey = "";

		// Token: 0x040251B4 RID: 151988
		protected bool ExploreComponentEnabled;

		// Token: 0x040251B5 RID: 151989
		protected Action PendingHighlightSkill;

		// Token: 0x040251B6 RID: 151990
		public bool IsLockingTarget;
	}
}
