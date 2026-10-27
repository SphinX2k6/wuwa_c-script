using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DAB RID: 23979
	[NullableContext(1)]
	[Nullable(0)]
	public class RailSlideView : UiTickViewBase
	{
		// Token: 0x0603CE48 RID: 249416 RVA: 0x00EA0BDF File Offset: 0x00E9EDDF
		public RailSlideView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603CE49 RID: 249417 RVA: 0x00EA0C00 File Offset: 0x00E9EE00
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

		// Token: 0x0603CE4A RID: 249418 RVA: 0x00EA0C6C File Offset: 0x00E9EE6C
		protected override UniTask OnBeforeStartAsync()
		{
			RailSlideView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RailSlideView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CE4B RID: 249419 RVA: 0x00EA0CAF File Offset: 0x00E9EEAF
		protected override void OnStart()
		{
			base.OnStart();
			this.RefreshRoleData();
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
		}

		// Token: 0x0603CE4C RID: 249420 RVA: 0x00EA0CD9 File Offset: 0x00E9EED9
		protected override void OnBeforeShow()
		{
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.RoleSpecialState, EBattleUiChild.Joystick, false, true, 0);
		}

		// Token: 0x0603CE4D RID: 249421 RVA: 0x00EA0CF2 File Offset: 0x00E9EEF2
		protected override void OnAfterHide()
		{
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.RoleSpecialState, EBattleUiChild.Joystick, true, true, 0);
		}

		// Token: 0x0603CE4E RID: 249422 RVA: 0x00EA0D0C File Offset: 0x00E9EF0C
		public UniTask NewAllSkillItems()
		{
			RailSlideView.<NewAllSkillItems>d__15 <NewAllSkillItems>d__;
			<NewAllSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllSkillItems>d__.<>4__this = this;
			<NewAllSkillItems>d__.<>1__state = -1;
			<NewAllSkillItems>d__.<>t__builder.Start<RailSlideView.<NewAllSkillItems>d__15>(ref <NewAllSkillItems>d__);
			return <NewAllSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603CE4F RID: 249423 RVA: 0x00EA0D50 File Offset: 0x00E9EF50
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<MoveSkillItem> NewSkillItem(AActor rootActor, int inputIndex)
		{
			RailSlideView.<NewSkillItem>d__16 <NewSkillItem>d__;
			<NewSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<MoveSkillItem>.Create();
			<NewSkillItem>d__.<>4__this = this;
			<NewSkillItem>d__.rootActor = rootActor;
			<NewSkillItem>d__.inputIndex = inputIndex;
			<NewSkillItem>d__.<>1__state = -1;
			<NewSkillItem>d__.<>t__builder.Start<RailSlideView.<NewSkillItem>d__16>(ref <NewSkillItem>d__);
			return <NewSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603CE50 RID: 249424 RVA: 0x00EA0DA4 File Offset: 0x00E9EFA4
		private void RefreshAllSkillItems()
		{
			this.SkillItemList[0].RefreshByMoveType(EInputAxis.MoveRight, -1f, false);
			this.SkillItemList[1].RefreshByMoveType(EInputAxis.MoveRight, 1f, false);
			this.SkillItemList[0].RefreshKeyByActionName(RailSlideView.ActionNameList[0]);
			this.SkillItemList[1].RefreshKeyByActionName(RailSlideView.ActionNameList[1]);
		}

		// Token: 0x0603CE51 RID: 249425 RVA: 0x00EA0E19 File Offset: 0x00E9F019
		protected override void OnAddEventListener()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.BindActions(RailSlideView.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x0603CE52 RID: 249426 RVA: 0x00EA0E42 File Offset: 0x00E9F042
		protected override void OnRemoveEventListener()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.UnBindActions(RailSlideView.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x0603CE53 RID: 249427 RVA: 0x00EA0E6C File Offset: 0x00E9F06C
		protected override void OnBeforeDestroy()
		{
			foreach (MoveSkillItem moveSkillItem in this.SkillItemList)
			{
				moveSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
			this.RemoveEntityEvents();
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
		}

		// Token: 0x0603CE54 RID: 249428 RVA: 0x00EA0EEC File Offset: 0x00E9F0EC
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			for (int i = 0; i < RailSlideView.ActionNameList.Length; i++)
			{
				if (actionName == RailSlideView.ActionNameList[i])
				{
					this.SkillItemList[i].OnInputAction(false);
					return;
				}
			}
		}

		// Token: 0x0603CE55 RID: 249429 RVA: 0x00EA0F31 File Offset: 0x00E9F131
		private void OnBattleUiCurRoleDataChanged(int i, int i1)
		{
			this.RefreshRoleData();
		}

		// Token: 0x0603CE56 RID: 249430 RVA: 0x00EA0F3C File Offset: 0x00E9F13C
		private void RefreshRoleData()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (this.RoleData == curRoleData)
			{
				return;
			}
			this.RemoveEntityEvents();
			this.RoleData = curRoleData;
			this.AddEntityEvents();
		}

		// Token: 0x0603CE57 RID: 249431 RVA: 0x00EA0F74 File Offset: 0x00E9F174
		private void AddEntityEvents()
		{
			if (this.RoleData == null)
			{
				return;
			}
			BaseTagComponent gameplayTagComponent = this.RoleData.GameplayTagComponent;
			if (gameplayTagComponent == null)
			{
				return;
			}
			this.ListenForTagAddOrRemove(gameplayTagComponent, RailSlideView.Tag1, new BaseTagComponent.TTagSwitchedCallback(this.OnEnableTag1Changed), true);
			this.ListenForTagAddOrRemove(gameplayTagComponent, RailSlideView.Tag2, new BaseTagComponent.TTagSwitchedCallback(this.OnEnableTag2Changed), true);
			this.ListenForTagAddOrRemove(gameplayTagComponent, RailSlideView.ForbidMoveTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnForbidMoveTagIdChanged), true);
		}

		// Token: 0x0603CE58 RID: 249432 RVA: 0x00EA0FE8 File Offset: 0x00E9F1E8
		private void RemoveEntityEvents()
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
			this.RoleData = null;
		}

		// Token: 0x0603CE59 RID: 249433 RVA: 0x00EA104C File Offset: 0x00E9F24C
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

		// Token: 0x0603CE5A RID: 249434 RVA: 0x00EA108C File Offset: 0x00E9F28C
		private void OnEnableTag1Changed(int tagId, bool tagExist)
		{
			this.SkillItemList[0].SetCustomDynamicEffectId(tagExist ? 1003 : 0);
		}

		// Token: 0x0603CE5B RID: 249435 RVA: 0x00EA10AA File Offset: 0x00E9F2AA
		private void OnEnableTag2Changed(int tagId, bool tagExist)
		{
			this.SkillItemList[1].SetCustomDynamicEffectId(tagExist ? 1003 : 0);
		}

		// Token: 0x0603CE5C RID: 249436 RVA: 0x00EA10C8 File Offset: 0x00E9F2C8
		private void OnForbidMoveTagIdChanged(int tagId, bool tagExist)
		{
			this.SkillItemList[0].SetUiActive(!tagExist);
			this.SkillItemList[1].SetUiActive(!tagExist);
		}

		// Token: 0x0603CE5D RID: 249437 RVA: 0x00EA10F4 File Offset: 0x00E9F2F4
		protected override void OnTick(float delta)
		{
			foreach (MoveSkillItem moveSkillItem in this.SkillItemList)
			{
				moveSkillItem.Tick(delta);
			}
		}

		// Token: 0x0401FB79 RID: 129913
		[StaticVariableRuleIgnore]
		private static readonly string[] ActionNameList = new string[]
		{
			"向左移动",
			"向右移动"
		};

		// Token: 0x0401FB7A RID: 129914
		[StaticVariableRuleIgnore]
		private static readonly int Tag1 = GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑轨.能够左跳"];

		// Token: 0x0401FB7B RID: 129915
		[StaticVariableRuleIgnore]
		private static readonly int Tag2 = GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑轨.能够右跳"];

		// Token: 0x0401FB7C RID: 129916
		[StaticVariableRuleIgnore]
		private static readonly int ForbidMoveTagId = GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑轨UI.隐藏跳跃按键"];

		// Token: 0x0401FB7D RID: 129917
		private const int EFFECT_ID = 1003;

		// Token: 0x0401FB7E RID: 129918
		private readonly List<MoveSkillItem> SkillItemList = new List<MoveSkillItem>();

		// Token: 0x0401FB7F RID: 129919
		[Nullable(2)]
		private BattleUiRoleData RoleData;

		// Token: 0x0401FB80 RID: 129920
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x0200C086 RID: 49286
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A192 RID: 237970
			Item1,
			// Token: 0x0403A193 RID: 237971
			Item2
		}
	}
}
