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
	// Token: 0x02005D97 RID: 23959
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleRailMoveView : UiTickViewBase
	{
		// Token: 0x0603CCD7 RID: 249047 RVA: 0x00E997DC File Offset: 0x00E979DC
		public MotorcycleRailMoveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603CCD8 RID: 249048 RVA: 0x00E997FC File Offset: 0x00E979FC
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

		// Token: 0x0603CCD9 RID: 249049 RVA: 0x00E99868 File Offset: 0x00E97A68
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleRailMoveView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleRailMoveView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CCDA RID: 249050 RVA: 0x00E998AB File Offset: 0x00E97AAB
		protected override void OnStart()
		{
			base.OnStart();
			this.RefreshRoleData();
		}

		// Token: 0x0603CCDB RID: 249051 RVA: 0x00E998B9 File Offset: 0x00E97AB9
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

		// Token: 0x0603CCDC RID: 249052 RVA: 0x00E998E5 File Offset: 0x00E97AE5
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

		// Token: 0x0603CCDD RID: 249053 RVA: 0x00E99914 File Offset: 0x00E97B14
		public UniTask NewAllSkillItems()
		{
			MotorcycleRailMoveView.<NewAllSkillItems>d__13 <NewAllSkillItems>d__;
			<NewAllSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllSkillItems>d__.<>4__this = this;
			<NewAllSkillItems>d__.<>1__state = -1;
			<NewAllSkillItems>d__.<>t__builder.Start<MotorcycleRailMoveView.<NewAllSkillItems>d__13>(ref <NewAllSkillItems>d__);
			return <NewAllSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603CCDE RID: 249054 RVA: 0x00E99958 File Offset: 0x00E97B58
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

		// Token: 0x0603CCDF RID: 249055 RVA: 0x00E999AC File Offset: 0x00E97BAC
		private void RefreshAllSkillItems()
		{
			this.SkillItemList[0].RefreshByMoveType(EInputAxis.MoveRight, -1f, false);
			this.SkillItemList[1].RefreshByMoveType(EInputAxis.MoveRight, 1f, false);
			this.SkillItemList[0].RefreshKeyByActionName(MotorcycleRailMoveView.ActionNameList[0]);
			this.SkillItemList[1].RefreshKeyByActionName(MotorcycleRailMoveView.ActionNameList[1]);
			this.SkillItemList[0].SetCustomSkillItemEnable(false);
			this.SkillItemList[1].SetCustomSkillItemEnable(false);
		}

		// Token: 0x0603CCE0 RID: 249056 RVA: 0x00E99A45 File Offset: 0x00E97C45
		protected override void OnAddEventListener()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.BindActions(MotorcycleRailMoveView.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x0603CCE1 RID: 249057 RVA: 0x00E99A6E File Offset: 0x00E97C6E
		protected override void OnRemoveEventListener()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.UnBindActions(MotorcycleRailMoveView.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x0603CCE2 RID: 249058 RVA: 0x00E99A98 File Offset: 0x00E97C98
		protected override void OnBeforeDestroy()
		{
			foreach (MoveSkillItem moveSkillItem in this.SkillItemList)
			{
				moveSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
			this.RemoveEntityEvents();
		}

		// Token: 0x0603CCE3 RID: 249059 RVA: 0x00E99AFC File Offset: 0x00E97CFC
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

		// Token: 0x0603CCE4 RID: 249060 RVA: 0x00E99B44 File Offset: 0x00E97D44
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

		// Token: 0x0603CCE5 RID: 249061 RVA: 0x00E99B78 File Offset: 0x00E97D78
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

		// Token: 0x0603CCE6 RID: 249062 RVA: 0x00E99BEC File Offset: 0x00E97DEC
		private void RemoveEntityEvents()
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
		}

		// Token: 0x0603CCE7 RID: 249063 RVA: 0x00E99C48 File Offset: 0x00E97E48
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

		// Token: 0x0603CCE8 RID: 249064 RVA: 0x00E99C88 File Offset: 0x00E97E88
		private void OnSwitchLeftTagChanged(int tagId, bool tagExist)
		{
			this.SkillItemList[0].SetCustomSkillItemEnable(tagExist);
			this.SkillItemList[0].SetCustomDynamicEffectId(tagExist ? 1003 : 0);
		}

		// Token: 0x0603CCE9 RID: 249065 RVA: 0x00E99CB8 File Offset: 0x00E97EB8
		private void OnSwitchRightTagChanged(int tagId, bool tagExist)
		{
			this.SkillItemList[1].SetCustomSkillItemEnable(tagExist);
			this.SkillItemList[1].SetCustomDynamicEffectId(tagExist ? 1003 : 0);
		}

		// Token: 0x0603CCEA RID: 249066 RVA: 0x00E99CE8 File Offset: 0x00E97EE8
		protected override void OnTick(float delta)
		{
			foreach (MoveSkillItem moveSkillItem in this.SkillItemList)
			{
				moveSkillItem.Tick(delta);
			}
		}

		// Token: 0x0401FAC3 RID: 129731
		[StaticVariableRuleIgnore]
		private static readonly string[] ActionNameList = new string[]
		{
			"向左移动",
			"向右移动"
		};

		// Token: 0x0401FAC4 RID: 129732
		[StaticVariableRuleIgnore]
		private static readonly int SwitchLeftTag = GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.滑轨.能够左跳"];

		// Token: 0x0401FAC5 RID: 129733
		[StaticVariableRuleIgnore]
		private static readonly int SwitchRightTag = GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.滑轨.能够右跳"];

		// Token: 0x0401FAC6 RID: 129734
		private const int EFFECT_ID = 1003;

		// Token: 0x0401FAC7 RID: 129735
		private readonly List<MoveSkillItem> SkillItemList = new List<MoveSkillItem>();

		// Token: 0x0401FAC8 RID: 129736
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x0200C057 RID: 49239
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A0A9 RID: 237737
			SwitchLeftBtn,
			// Token: 0x0403A0AA RID: 237738
			SwitchRightBtn
		}
	}
}
