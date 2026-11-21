using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using Google.Protobuf;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02006346 RID: 25414
	[NullableContext(2)]
	[Nullable(0)]
	public class BaseExploreComponent : EntityComponent
	{
		// Token: 0x170074E1 RID: 29921
		// (get) Token: 0x0603D924 RID: 252196 RVA: 0x011D4198 File Offset: 0x011D2398
		// (set) Token: 0x0603D925 RID: 252197 RVA: 0x011D4208 File Offset: 0x011D2408
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

		// Token: 0x170074E2 RID: 29922
		// (get) Token: 0x0603D926 RID: 252198 RVA: 0x011D426C File Offset: 0x011D246C
		// (set) Token: 0x0603D927 RID: 252199 RVA: 0x011D42DC File Offset: 0x011D24DC
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

		// Token: 0x170074E3 RID: 29923
		// (get) Token: 0x0603D928 RID: 252200 RVA: 0x011D42E5 File Offset: 0x011D24E5
		// (set) Token: 0x0603D929 RID: 252201 RVA: 0x011D42ED File Offset: 0x011D24ED
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

		// Token: 0x170074E4 RID: 29924
		// (get) Token: 0x0603D92A RID: 252202 RVA: 0x011D42F6 File Offset: 0x011D24F6
		[Nullable(1)]
		public override Type[] Dependencies
		{
			[NullableContext(1)]
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

		// Token: 0x0603D92B RID: 252203 RVA: 0x011D4328 File Offset: 0x011D2528
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

		// Token: 0x0603D92C RID: 252204 RVA: 0x011D43F9 File Offset: 0x011D25F9
		protected virtual bool CheckDisableComponent()
		{
			return false;
		}

		// Token: 0x0603D92D RID: 252205 RVA: 0x011D43FC File Offset: 0x011D25FC
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

		// Token: 0x0603D92E RID: 252206 RVA: 0x011D4421 File Offset: 0x011D2621
		protected override void OnTick(float delta)
		{
			if (!this.ExploreComponentEnabled)
			{
				return;
			}
			this.OnExploreComponentTick(delta);
		}

		// Token: 0x0603D92F RID: 252207 RVA: 0x011D4434 File Offset: 0x011D2634
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

		// Token: 0x0603D930 RID: 252208 RVA: 0x011D44F4 File Offset: 0x011D26F4
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

		// Token: 0x0603D931 RID: 252209 RVA: 0x011D463B File Offset: 0x011D283B
		protected virtual void OnExploreComponentTick(float delta)
		{
		}

		// Token: 0x0603D932 RID: 252210 RVA: 0x011D463D File Offset: 0x011D283D
		protected virtual void OnDetectedTargetChanged(GrapplingHookPointComponent prevTarget)
		{
		}

		// Token: 0x0603D933 RID: 252211 RVA: 0x011D463F File Offset: 0x011D283F
		[NullableContext(1)]
		public virtual void ClearDetectedTarget(string reason)
		{
		}

		// Token: 0x0603D934 RID: 252212 RVA: 0x011D4644 File Offset: 0x011D2844
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

		// Token: 0x0603D935 RID: 252213 RVA: 0x011D479C File Offset: 0x011D299C
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

		// Token: 0x0603D936 RID: 252214 RVA: 0x011D47F0 File Offset: 0x011D29F0
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

		// Token: 0x0603D937 RID: 252215 RVA: 0x011D48F8 File Offset: 0x011D2AF8
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

		// Token: 0x0603D938 RID: 252216 RVA: 0x011D494C File Offset: 0x011D2B4C
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

		// Token: 0x0603D939 RID: 252217 RVA: 0x011D49D4 File Offset: 0x011D2BD4
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

		// Token: 0x0603D93A RID: 252218 RVA: 0x011D4B24 File Offset: 0x011D2D24
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

		// Token: 0x0603D93B RID: 252219 RVA: 0x011D4BCC File Offset: 0x011D2DCC
		public int? GetHighlightSkillId()
		{
			HighlightExploreSkillLogic highlightLogic = this.HighlightLogic;
			if (highlightLogic == null)
			{
				return null;
			}
			return new int?(highlightLogic.GetHighlightSkillId());
		}

		// Token: 0x0603D93C RID: 252220 RVA: 0x011D4BF8 File Offset: 0x011D2DF8
		public int? GetHighlightExploreToolId()
		{
			HighlightExploreSkillLogic highlightLogic = this.HighlightLogic;
			if (highlightLogic == null)
			{
				return null;
			}
			return new int?(highlightLogic.GetHighlightExploreToolId());
		}

		// Token: 0x0603D93D RID: 252221 RVA: 0x011D4C24 File Offset: 0x011D2E24
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

		// Token: 0x0603D93E RID: 252222 RVA: 0x011D4C94 File Offset: 0x011D2E94
		public virtual bool CheckAllowLevelEventHighlightSkill()
		{
			return true;
		}

		// Token: 0x0603D93F RID: 252223 RVA: 0x011D4C97 File Offset: 0x011D2E97
		public virtual void OnLevelEventHighlightSkillUpdate(bool enabled)
		{
		}

		// Token: 0x0603D940 RID: 252224 RVA: 0x011D4C9C File Offset: 0x011D2E9C
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

		// Token: 0x0603D941 RID: 252225 RVA: 0x011D4FCC File Offset: 0x011D31CC
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

		// Token: 0x0603D942 RID: 252226 RVA: 0x011D51F0 File Offset: 0x011D33F0
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

		// Token: 0x0603D943 RID: 252227 RVA: 0x011D523C File Offset: 0x011D343C
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

		// Token: 0x0603D944 RID: 252228 RVA: 0x011D534C File Offset: 0x011D354C
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

		// Token: 0x0603D945 RID: 252229 RVA: 0x011D5499 File Offset: 0x011D3699
		public void SetIsHookEndByInterruptProxy(bool isHookEndByInterrupt)
		{
			this.IsHookEndByInterrupt = isHookEndByInterrupt;
		}

		// Token: 0x0603D946 RID: 252230 RVA: 0x011D54A4 File Offset: 0x011D36A4
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			BaseExploreComponent baseExploreComponent = (BaseExploreComponent)componentTemplate;
			if (baseExploreComponent.ActorComponent == null)
			{
				this.ActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComponent), "ActorComponent"))
			{
				return false;
			}
			if (baseExploreComponent.SkillComponent == null)
			{
				this.SkillComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComponent), "SkillComponent"))
			{
				return false;
			}
			if (baseExploreComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
			{
				return false;
			}
			if (baseExploreComponent.HighlightLogic == null)
			{
				this.HighlightLogic = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.HighlightLogic), "HighlightLogic"))
			{
				return false;
			}
			this.CurrentIconTagId = baseExploreComponent.CurrentIconTagId;
			this.CurrentIconHighlightTagId = baseExploreComponent.CurrentIconHighlightTagId;
			this.LevelEventLightingSkill = baseExploreComponent.LevelEventLightingSkill;
			if (baseExploreComponent.InteractingTargetInternal == null)
			{
				this.InteractingTargetInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InteractingTargetInternal), "InteractingTargetInternal"))
			{
				return false;
			}
			this.InteractingTargetEntityId = baseExploreComponent.InteractingTargetEntityId;
			if (baseExploreComponent.FocusTargetInternal == null)
			{
				this.FocusTargetInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FocusTargetInternal), "FocusTargetInternal"))
			{
				return false;
			}
			this.FocusTargetLegalExceptSkill = baseExploreComponent.FocusTargetLegalExceptSkill;
			this.FocusTargetLegalInternal = baseExploreComponent.FocusTargetLegalInternal;
			if (baseExploreComponent.SimulateInteractingTarget == null)
			{
				this.SimulateInteractingTarget = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SimulateInteractingTarget), "SimulateInteractingTarget"))
			{
				return false;
			}
			if (baseExploreComponent.SimulateInteractingTargetLocation == null)
			{
				this.SimulateInteractingTargetLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SimulateInteractingTargetLocation), "SimulateInteractingTargetLocation"))
			{
				return false;
			}
			this.SyncEnabled = baseExploreComponent.SyncEnabled;
			this.IsHookEndByInterrupt = baseExploreComponent.IsHookEndByInterrupt;
			this.LogKey = baseExploreComponent.LogKey;
			this.ExploreComponentEnabled = baseExploreComponent.ExploreComponentEnabled;
			if (baseExploreComponent.PendingHighlightSkill == null)
			{
				this.PendingHighlightSkill = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PendingHighlightSkill), "PendingHighlightSkill"))
			{
				return false;
			}
			this.IsLockingTarget = baseExploreComponent.IsLockingTarget;
			return true;
		}

		// Token: 0x170074E5 RID: 29925
		// (get) Token: 0x0603D947 RID: 252231 RVA: 0x011D56CB File Offset: 0x011D38CB
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074E6 RID: 29926
		// (get) Token: 0x0603D948 RID: 252232 RVA: 0x011D56CE File Offset: 0x011D38CE
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074E7 RID: 29927
		// (get) Token: 0x0603D949 RID: 252233 RVA: 0x011D56D1 File Offset: 0x011D38D1
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020A83 RID: 133763
		public BaseActorComponent ActorComponent;

		// Token: 0x04020A84 RID: 133764
		protected BaseSkillComponent SkillComponent;

		// Token: 0x04020A85 RID: 133765
		public BaseTagComponent TagComponent;

		// Token: 0x04020A86 RID: 133766
		protected HighlightExploreSkillLogic HighlightLogic;

		// Token: 0x04020A87 RID: 133767
		protected int? CurrentIconTagId;

		// Token: 0x04020A88 RID: 133768
		protected int? CurrentIconHighlightTagId;

		// Token: 0x04020A89 RID: 133769
		protected bool LevelEventLightingSkill;

		// Token: 0x04020A8A RID: 133770
		private GrapplingHookPointComponent InteractingTargetInternal;

		// Token: 0x04020A8B RID: 133771
		protected int? InteractingTargetEntityId;

		// Token: 0x04020A8C RID: 133772
		protected GrapplingHookPointComponent FocusTargetInternal;

		// Token: 0x04020A8D RID: 133773
		public bool FocusTargetLegalExceptSkill;

		// Token: 0x04020A8E RID: 133774
		protected bool FocusTargetLegalInternal;

		// Token: 0x04020A8F RID: 133775
		public GrapplingHookPointComponent SimulateInteractingTarget;

		// Token: 0x04020A90 RID: 133776
		public global::Vector SimulateInteractingTargetLocation;

		// Token: 0x04020A91 RID: 133777
		public bool SyncEnabled = true;

		// Token: 0x04020A92 RID: 133778
		protected bool IsHookEndByInterrupt;

		// Token: 0x04020A93 RID: 133779
		[Nullable(1)]
		public string LogKey = "";

		// Token: 0x04020A94 RID: 133780
		protected bool ExploreComponentEnabled;

		// Token: 0x04020A95 RID: 133781
		protected Action PendingHighlightSkill;

		// Token: 0x04020A96 RID: 133782
		public bool IsLockingTarget;
	}
}
