using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D79 RID: 19833
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleRailMoveView : UiTickViewBase
	{
		// Token: 0x06031C34 RID: 203828 RVA: 0x00DEA094 File Offset: 0x00DE8294
		public MotorcycleRailMoveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031C35 RID: 203829 RVA: 0x00DEA0B4 File Offset: 0x00DE82B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031C36 RID: 203830 RVA: 0x00DEA120 File Offset: 0x00DE8320
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleRailMoveView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleRailMoveView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031C37 RID: 203831 RVA: 0x00DEA163 File Offset: 0x00DE8363
		protected override void OnStart()
		{
			base.OnStart();
			this.RefreshRoleData();
		}

		// Token: 0x06031C38 RID: 203832 RVA: 0x00DEA171 File Offset: 0x00DE8371
		protected override void OnBeforeShow()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.RoleSpecialState, new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
			{
				EBattleUiChild.Joystick,
				EBattleUiChild.Formation,
				EBattleUiChild.GamepadFormation,
				EBattleUiChild.MotorcycleMobileJoystick,
				EBattleUiChild.MotorcycleControlHud
			}), false, true, 0);
		}

		// Token: 0x06031C39 RID: 203833 RVA: 0x00DEA19D File Offset: 0x00DE839D
		protected override void OnAfterHide()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.RoleSpecialState, new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
			{
				EBattleUiChild.Joystick,
				EBattleUiChild.Formation,
				EBattleUiChild.GamepadFormation,
				EBattleUiChild.MotorcycleMobileJoystick,
				EBattleUiChild.MotorcycleControlHud
			}), true, true, 0);
		}

		// Token: 0x06031C3A RID: 203834 RVA: 0x00DEA1CC File Offset: 0x00DE83CC
		public UniTask NewAllSkillItems()
		{
			MotorcycleRailMoveView.<NewAllSkillItems>d__13 <NewAllSkillItems>d__;
			<NewAllSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllSkillItems>d__.<>4__this = this;
			<NewAllSkillItems>d__.<>1__state = -1;
			<NewAllSkillItems>d__.<>t__builder.Start<MotorcycleRailMoveView.<NewAllSkillItems>d__13>(ref <NewAllSkillItems>d__);
			return <NewAllSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x06031C3B RID: 203835 RVA: 0x00DEA210 File Offset: 0x00DE8410
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<MoveSkillItem> NewSkillItem(AActor rootActor, int inputIndex)
		{
			MotorcycleRailMoveView.<NewSkillItem>d__14 <NewSkillItem>d__;
			<NewSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<MoveSkillItem>.Create();
			<NewSkillItem>d__.<>4__this = this;
			<NewSkillItem>d__.rootActor = rootActor;
			<NewSkillItem>d__.inputIndex = inputIndex;
			<NewSkillItem>d__.<>1__state = -1;
			<NewSkillItem>d__.<>t__builder.Start<MotorcycleRailMoveView.<NewSkillItem>d__14>(ref <NewSkillItem>d__);
			return <NewSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031C3C RID: 203836 RVA: 0x00DEA264 File Offset: 0x00DE8464
		private void RefreshAllSkillItems()
		{
			this.SkillItemList[0].RefreshByMoveType(EInputAxis.MoveRight, -1f, false);
			this.SkillItemList[1].RefreshByMoveType(EInputAxis.MoveRight, 1f, false);
			this.SkillItemList[0].RefreshKeyByActionName(MotorcycleRailMoveView.ActionNameList[0]);
			this.SkillItemList[1].RefreshKeyByActionName(MotorcycleRailMoveView.ActionNameList[1]);
			this.SkillItemList[0].SetCustomSkillItemEnable(false);
			this.SkillItemList[1].SetCustomSkillItemEnable(false);
		}

		// Token: 0x06031C3D RID: 203837 RVA: 0x00DEA2FD File Offset: 0x00DE84FD
		protected override void OnAddEventListener()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.BindActions(MotorcycleRailMoveView.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x06031C3E RID: 203838 RVA: 0x00DEA326 File Offset: 0x00DE8526
		protected override void OnRemoveEventListener()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.UnBindActions(MotorcycleRailMoveView.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x06031C3F RID: 203839 RVA: 0x00DEA350 File Offset: 0x00DE8550
		protected override void OnBeforeDestroy()
		{
			foreach (MoveSkillItem moveSkillItem in this.SkillItemList)
			{
				moveSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
			this.RemoveEntityEvents();
		}

		// Token: 0x06031C40 RID: 203840 RVA: 0x00DEA3B4 File Offset: 0x00DE85B4
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			for (int i = 0; i < MotorcycleRailMoveView.ActionNameList.Length; i++)
			{
				if (actionName == MotorcycleRailMoveView.ActionNameList[i])
				{
					this.SkillItemList[i].OnInputAction(false);
					return;
				}
			}
		}

		// Token: 0x06031C41 RID: 203841 RVA: 0x00DEA3FC File Offset: 0x00DE85FC
		private void RefreshRoleData()
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			if (!FormationDataController.Instance.IsPlayerExist(playerId))
			{
				return;
			}
			this.RemoveEntityEvents();
			this.AddEntityEvents();
		}

		// Token: 0x06031C42 RID: 203842 RVA: 0x00DEA430 File Offset: 0x00DE8630
		private void AddEntityEvents()
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			if (!FormationDataController.Instance.IsPlayerExist(playerId))
			{
				return;
			}
			WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
			PlayerTagComponent playerTagComponent = (playerEntity != null) ? playerEntity.GetComponent<PlayerTagComponent>() : null;
			if (playerTagComponent == null)
			{
				return;
			}
			this.ListenForTagAddOrRemove(playerTagComponent, MotorcycleRailMoveView.SwitchLeftTag, new BaseTagComponent.TTagSwitchedCallback(this.OnSwitchLeftTagChanged), true);
			this.ListenForTagAddOrRemove(playerTagComponent, MotorcycleRailMoveView.SwitchRightTag, new BaseTagComponent.TTagSwitchedCallback(this.OnSwitchRightTagChanged), true);
		}

		// Token: 0x06031C43 RID: 203843 RVA: 0x00DEA4A4 File Offset: 0x00DE86A4
		private void RemoveEntityEvents()
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
		}

		// Token: 0x06031C44 RID: 203844 RVA: 0x00DEA500 File Offset: 0x00DE8700
		private void ListenForTagAddOrRemove(BaseTagComponent tagComponent, int tagId, BaseTagComponent.TTagSwitchedCallback callback, bool checkExistImmediately = false)
		{
			if (checkExistImmediately && tagComponent.HasTag(tagId))
			{
				callback(tagId, true);
			}
			ITagTask tagTask = tagComponent.ListenForTagAddOrRemove(new int?(tagId), callback, null);
			if (tagTask != null)
			{
				this.TagTaskList.Add(tagTask);
			}
		}

		// Token: 0x06031C45 RID: 203845 RVA: 0x00DEA540 File Offset: 0x00DE8740
		private void OnSwitchLeftTagChanged(int tagId, bool tagExist)
		{
			this.SkillItemList[0].SetCustomSkillItemEnable(tagExist);
			this.SkillItemList[0].SetCustomDynamicEffectId(tagExist ? 1003 : 0);
		}

		// Token: 0x06031C46 RID: 203846 RVA: 0x00DEA570 File Offset: 0x00DE8770
		private void OnSwitchRightTagChanged(int tagId, bool tagExist)
		{
			this.SkillItemList[1].SetCustomSkillItemEnable(tagExist);
			this.SkillItemList[1].SetCustomDynamicEffectId(tagExist ? 1003 : 0);
		}

		// Token: 0x06031C47 RID: 203847 RVA: 0x00DEA5A0 File Offset: 0x00DE87A0
		protected override void OnTick(float delta)
		{
			foreach (MoveSkillItem moveSkillItem in this.SkillItemList)
			{
				moveSkillItem.Tick(delta);
			}
		}

		// Token: 0x0401A57B RID: 107899
		[StaticVariableRuleIgnore]
		private static readonly string[] ActionNameList = new string[]
		{
			"向左移动",
			"向右移动"
		};

		// Token: 0x0401A57C RID: 107900
		[StaticVariableRuleIgnore]
		private static readonly int SwitchLeftTag = GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.滑轨.能够左跳"];

		// Token: 0x0401A57D RID: 107901
		[StaticVariableRuleIgnore]
		private static readonly int SwitchRightTag = GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.滑轨.能够右跳"];

		// Token: 0x0401A57E RID: 107902
		private const int EFFECT_ID = 1003;

		// Token: 0x0401A57F RID: 107903
		private readonly List<MoveSkillItem> SkillItemList = new List<MoveSkillItem>();

		// Token: 0x0401A580 RID: 107904
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x0200AA5D RID: 43613
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034A6C RID: 215660
			SwitchLeftBtn,
			// Token: 0x04034A6D RID: 215661
			SwitchRightBtn
		}
	}
}
