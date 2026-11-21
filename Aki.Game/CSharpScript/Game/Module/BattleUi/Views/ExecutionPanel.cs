using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D02 RID: 19714
	[NullableContext(2)]
	[Nullable(0)]
	public class ExecutionPanel : UiPanelBase
	{
		// Token: 0x06031655 RID: 202325 RVA: 0x00DCE8A4 File Offset: 0x00DCCAA4
		[NullableContext(1)]
		public void Init(UUIItem parentItem)
		{
			this.ChildViewData = BattleUiModel.Instance.ChildViewData;
			this.ChildVisible = this.ChildViewData.GetChildVisible(EBattleUiChild.BattleHud);
			this.Initialize(parentItem).Forget();
		}

		// Token: 0x06031656 RID: 202326 RVA: 0x00DCE8D8 File Offset: 0x00DCCAD8
		[NullableContext(1)]
		public UniTask Initialize(UUIItem parentItem)
		{
			ExecutionPanel.<Initialize>d__12 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.parentItem = parentItem;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<ExecutionPanel.<Initialize>d__12>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x06031657 RID: 202327 RVA: 0x00DCE924 File Offset: 0x00DCCB24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031658 RID: 202328 RVA: 0x00DCE9AE File Offset: 0x00DCCBAE
		public UUIItem GetExecutionItem()
		{
			if (!base.IsShowOrShowing)
			{
				return null;
			}
			return base.GetItem(0);
		}

		// Token: 0x06031659 RID: 202329 RVA: 0x00DCE9C4 File Offset: 0x00DCCBC4
		protected override UniTask OnBeforeStartAsync()
		{
			ExecutionPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ExecutionPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603165A RID: 202330 RVA: 0x00DCEA08 File Offset: 0x00DCCC08
		[NullableContext(0)]
		private UniTask<bool> NewSkillItem()
		{
			ExecutionPanel.<NewSkillItem>d__16 <NewSkillItem>d__;
			<NewSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<NewSkillItem>d__.<>4__this = this;
			<NewSkillItem>d__.<>1__state = -1;
			<NewSkillItem>d__.<>t__builder.Start<ExecutionPanel.<NewSkillItem>d__16>(ref <NewSkillItem>d__);
			return <NewSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603165B RID: 202331 RVA: 0x00DCEA4B File Offset: 0x00DCCC4B
		protected override void OnStart()
		{
			this.InitTweenAnim(1);
			this.InitTweenAnim(2);
		}

		// Token: 0x0603165C RID: 202332 RVA: 0x00DCEA5B File Offset: 0x00DCCC5B
		protected override void OnAfterShow()
		{
			this.StopTweenAnim(2);
			this.PlayTweenAnim(1);
		}

		// Token: 0x0603165D RID: 202333 RVA: 0x00DCEA6C File Offset: 0x00DCCC6C
		protected override UniTask OnBeforeHideAsync()
		{
			ExecutionPanel.<OnBeforeHideAsync>d__19 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<ExecutionPanel.<OnBeforeHideAsync>d__19>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603165E RID: 202334 RVA: 0x00DCEAAF File Offset: 0x00DCCCAF
		private void OnCloseAnimTimerEnd(float _)
		{
			this.CloseTimer = null;
			this.Promise.SetResult();
			this.Promise = null;
		}

		// Token: 0x0603165F RID: 202335 RVA: 0x00DCEACC File Offset: 0x00DCCCCC
		protected override void OnBeforeDestroy()
		{
			if (this.CloseTimer != null)
			{
				TimerSystem.Instance.Remove(this.CloseTimer);
				this.CloseTimer = null;
				this.Promise.SetResult();
			}
			ExecutionItem skillItem = this.SkillItem;
			if (skillItem != null)
			{
				skillItem.Destroy(null);
			}
			this.SkillItem = null;
			this.RemoveEvents();
		}

		// Token: 0x06031660 RID: 202336 RVA: 0x00DCEB24 File Offset: 0x00DCCD24
		private void AddEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.BindAction("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			this.ChildViewData.AddCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleChildVisibleChanged));
		}

		// Token: 0x06031661 RID: 202337 RVA: 0x00DCEB74 File Offset: 0x00DCCD74
		private void RemoveEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.UnBindAction("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			this.ChildViewData.RemoveCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleChildVisibleChanged));
		}

		// Token: 0x06031662 RID: 202338 RVA: 0x00DCEBC1 File Offset: 0x00DCCDC1
		[NullableContext(1)]
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType == InputDistributeDefine.EActionType.Release)
			{
				this.OnInteract();
			}
		}

		// Token: 0x06031663 RID: 202339 RVA: 0x00DCEBD0 File Offset: 0x00DCCDD0
		private void OnInteract()
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null || !entityHandle.Valid)
			{
				this.RemoveEntityEvents();
				this.EntityHandle = null;
				base.Hide(null);
				return;
			}
			ExecutionItem skillItem = this.SkillItem;
			if (skillItem != null)
			{
				skillItem.OnInputAction(false);
			}
			PawnInteractBaseComponent component = this.EntityHandle.Entity.GetComponent<PawnInteractBaseComponent>();
			if (component == null || !component.IsPawnInteractive())
			{
				return;
			}
			component.InteractPawn(-1, null);
		}

		// Token: 0x06031664 RID: 202340 RVA: 0x00DCEC48 File Offset: 0x00DCCE48
		private void OnBattleChildVisibleChanged()
		{
			this.ChildVisible = this.ChildViewData.GetChildVisible(EBattleUiChild.BattleHud);
			if (this.ChildVisible)
			{
				EntityHandle entityHandle = this.EntityHandle;
				if (entityHandle != null && entityHandle.Valid && !base.IsShowOrShowing)
				{
					base.Show(null);
					return;
				}
			}
			else if (!base.IsHideOrHiding)
			{
				base.Hide(null);
			}
		}

		// Token: 0x06031665 RID: 202341 RVA: 0x00DCECA4 File Offset: 0x00DCCEA4
		private void InitTweenAnim(int componentType)
		{
			TArray<UActorComponent> tarray = base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>(tarray.Count);
			foreach (UActorComponent uactorComponent in tarray)
			{
				list.Add((ULGUIPlayTweenComponent)uactorComponent);
			}
			if (this.TweenAnimMap == null)
			{
				this.TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();
			}
			this.TweenAnimMap[componentType] = list;
		}

		// Token: 0x06031666 RID: 202342 RVA: 0x00DCED40 File Offset: 0x00DCCF40
		private void PlayTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap != null && this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x06031667 RID: 202343 RVA: 0x00DCEDA4 File Offset: 0x00DCCFA4
		private void StopTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap != null && this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Stop();
				}
			}
		}

		// Token: 0x06031668 RID: 202344 RVA: 0x00DCEE08 File Offset: 0x00DCD008
		public void ShowByEntity(int entityId, ECustomOptionType? optionType)
		{
			ECustomOptionType? optionType2 = this.OptionType;
			ECustomOptionType? ecustomOptionType = optionType;
			if (!(optionType2.GetValueOrDefault() == ecustomOptionType.GetValueOrDefault() & optionType2 != null == (ecustomOptionType != null)))
			{
				this.OptionType = optionType;
				if (this.OptionType.GetValueOrDefault() == ECustomOptionType.Execution)
				{
					ExecutionItem skillItem = this.SkillItem;
					if (skillItem != null)
					{
						skillItem.RefreshSkillIconByResId("SP_IconPutDeath");
					}
				}
				else if (this.OptionType.GetValueOrDefault() == ECustomOptionType.BreakWeakness)
				{
					ExecutionItem skillItem2 = this.SkillItem;
					if (skillItem2 != null)
					{
						skillItem2.RefreshSkillIconByResId("T_MstSkil_1002_UI");
					}
				}
			}
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle != null && entityHandle.Id == entityId)
			{
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById == null)
			{
				this.OnRemove();
				return;
			}
			this.RemoveEntityEvents();
			this.EntityHandle = entityById;
			this.OnAdd();
		}

		// Token: 0x06031669 RID: 202345 RVA: 0x00DCEED3 File Offset: 0x00DCD0D3
		public void HideByEntity(int entityId)
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null || entityHandle.Id != entityId)
			{
				return;
			}
			this.OnRemove();
		}

		// Token: 0x0603166A RID: 202346 RVA: 0x00DCEEF6 File Offset: 0x00DCD0F6
		private void OnAdd()
		{
			this.AddEntityEvents();
			if (!base.IsShowOrShowing && this.ChildVisible)
			{
				base.Show(null);
			}
			BattleUiModel.Instance.SetExecutionInteractEnable(true);
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, false, true, 0);
		}

		// Token: 0x0603166B RID: 202347 RVA: 0x00DCEF36 File Offset: 0x00DCD136
		private void OnRemove()
		{
			this.RemoveEntityEvents();
			this.EntityHandle = null;
			if (!base.IsHideOrHiding)
			{
				base.Hide(null);
			}
			BattleUiModel.Instance.SetExecutionInteractEnable(false);
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, true, true, 0);
		}

		// Token: 0x0603166C RID: 202348 RVA: 0x00DCEF75 File Offset: 0x00DCD175
		private void AddEntityEvents()
		{
			if (this.EntityHandle == null)
			{
				return;
			}
			EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}

		// Token: 0x0603166D RID: 202349 RVA: 0x00DCEFA2 File Offset: 0x00DCD1A2
		private void RemoveEntityEvents()
		{
			if (this.EntityHandle == null)
			{
				return;
			}
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}

		// Token: 0x0603166E RID: 202350 RVA: 0x00DCEFCF File Offset: 0x00DCD1CF
		[NullableContext(1)]
		private void OnRemoveEntity(ERemoveEntityType eRemoveEntityType, EntityHandle entityHandle)
		{
			this.OnRemove();
		}

		// Token: 0x0401A2A5 RID: 107173
		private const float CLOSE_ANIM_TIME = 300f;

		// Token: 0x0401A2A6 RID: 107174
		private const EBattleUiChild ChildType = EBattleUiChild.BattleHud;

		// Token: 0x0401A2A7 RID: 107175
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap;

		// Token: 0x0401A2A8 RID: 107176
		private EntityHandle EntityHandle;

		// Token: 0x0401A2A9 RID: 107177
		private ExecutionItem SkillItem;

		// Token: 0x0401A2AA RID: 107178
		private TimerHandle CloseTimer;

		// Token: 0x0401A2AB RID: 107179
		private CustomPromise Promise;

		// Token: 0x0401A2AC RID: 107180
		private BattleUiChildViewData ChildViewData;

		// Token: 0x0401A2AD RID: 107181
		private bool ChildVisible = true;

		// Token: 0x0401A2AE RID: 107182
		private ECustomOptionType? OptionType = new ECustomOptionType?(ECustomOptionType.Execution);

		// Token: 0x0200A9A8 RID: 43432
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040346CA RID: 214730
			SkillItem,
			// Token: 0x040346CB RID: 214731
			AnimStart,
			// Token: 0x040346CC RID: 214732
			AnimClose
		}
	}
}
