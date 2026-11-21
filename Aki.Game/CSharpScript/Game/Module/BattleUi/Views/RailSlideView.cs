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
	// Token: 0x02004D8F RID: 19855
	[NullableContext(1)]
	[Nullable(0)]
	public class RailSlideView : UiTickViewBase
	{
		// Token: 0x06031DBF RID: 204223 RVA: 0x00DF1A8B File Offset: 0x00DEFC8B
		public RailSlideView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031DC0 RID: 204224 RVA: 0x00DF1AAC File Offset: 0x00DEFCAC
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

		// Token: 0x06031DC1 RID: 204225 RVA: 0x00DF1B18 File Offset: 0x00DEFD18
		protected override UniTask OnBeforeStartAsync()
		{
			RailSlideView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RailSlideView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031DC2 RID: 204226 RVA: 0x00DF1B5B File Offset: 0x00DEFD5B
		protected override void OnStart()
		{
			base.OnStart();
			this.RefreshRoleData();
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
		}

		// Token: 0x06031DC3 RID: 204227 RVA: 0x00DF1B85 File Offset: 0x00DEFD85
		protected override void OnBeforeShow()
		{
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.RoleSpecialState, EBattleUiChild.Joystick, false, true, 0);
		}

		// Token: 0x06031DC4 RID: 204228 RVA: 0x00DF1B9E File Offset: 0x00DEFD9E
		protected override void OnAfterHide()
		{
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.RoleSpecialState, EBattleUiChild.Joystick, true, true, 0);
		}

		// Token: 0x06031DC5 RID: 204229 RVA: 0x00DF1BB8 File Offset: 0x00DEFDB8
		public UniTask NewAllSkillItems()
		{
			RailSlideView.<NewAllSkillItems>d__15 <NewAllSkillItems>d__;
			<NewAllSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllSkillItems>d__.<>4__this = this;
			<NewAllSkillItems>d__.<>1__state = -1;
			<NewAllSkillItems>d__.<>t__builder.Start<RailSlideView.<NewAllSkillItems>d__15>(ref <NewAllSkillItems>d__);
			return <NewAllSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x06031DC6 RID: 204230 RVA: 0x00DF1BFC File Offset: 0x00DEFDFC
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

		// Token: 0x06031DC7 RID: 204231 RVA: 0x00DF1C50 File Offset: 0x00DEFE50
		private void RefreshAllSkillItems()
		{
			this.SkillItemList[0].RefreshByMoveType(EInputAxis.MoveRight, -1f, false);
			this.SkillItemList[1].RefreshByMoveType(EInputAxis.MoveRight, 1f, false);
			this.SkillItemList[0].RefreshKeyByActionName(RailSlideView.ActionNameList[0]);
			this.SkillItemList[1].RefreshKeyByActionName(RailSlideView.ActionNameList[1]);
		}

		// Token: 0x06031DC8 RID: 204232 RVA: 0x00DF1CC5 File Offset: 0x00DEFEC5
		protected override void OnAddEventListener()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.BindActions(RailSlideView.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x06031DC9 RID: 204233 RVA: 0x00DF1CEE File Offset: 0x00DEFEEE
		protected override void OnRemoveEventListener()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.UnBindActions(RailSlideView.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x06031DCA RID: 204234 RVA: 0x00DF1D18 File Offset: 0x00DEFF18
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

		// Token: 0x06031DCB RID: 204235 RVA: 0x00DF1D98 File Offset: 0x00DEFF98
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

		// Token: 0x06031DCC RID: 204236 RVA: 0x00DF1DDD File Offset: 0x00DEFFDD
		private void OnBattleUiCurRoleDataChanged(int i, int i1)
		{
			this.RefreshRoleData();
		}

		// Token: 0x06031DCD RID: 204237 RVA: 0x00DF1DE8 File Offset: 0x00DEFFE8
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

		// Token: 0x06031DCE RID: 204238 RVA: 0x00DF1E20 File Offset: 0x00DF0020
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

		// Token: 0x06031DCF RID: 204239 RVA: 0x00DF1E94 File Offset: 0x00DF0094
		private void RemoveEntityEvents()
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
			this.RoleData = null;
		}

		// Token: 0x06031DD0 RID: 204240 RVA: 0x00DF1EF8 File Offset: 0x00DF00F8
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

		// Token: 0x06031DD1 RID: 204241 RVA: 0x00DF1F38 File Offset: 0x00DF0138
		private void OnEnableTag1Changed(int tagId, bool tagExist)
		{
			this.SkillItemList[0].SetCustomDynamicEffectId(tagExist ? 1003 : 0);
		}

		// Token: 0x06031DD2 RID: 204242 RVA: 0x00DF1F56 File Offset: 0x00DF0156
		private void OnEnableTag2Changed(int tagId, bool tagExist)
		{
			this.SkillItemList[1].SetCustomDynamicEffectId(tagExist ? 1003 : 0);
		}

		// Token: 0x06031DD3 RID: 204243 RVA: 0x00DF1F74 File Offset: 0x00DF0174
		private void OnForbidMoveTagIdChanged(int tagId, bool tagExist)
		{
			this.SkillItemList[0].SetUiActive(!tagExist);
			this.SkillItemList[1].SetUiActive(!tagExist);
		}

		// Token: 0x06031DD4 RID: 204244 RVA: 0x00DF1FA0 File Offset: 0x00DF01A0
		protected override void OnTick(float delta)
		{
			foreach (MoveSkillItem moveSkillItem in this.SkillItemList)
			{
				moveSkillItem.Tick(delta);
			}
		}

		// Token: 0x0401A636 RID: 108086
		[StaticVariableRuleIgnore]
		private static readonly string[] ActionNameList = new string[]
		{
			"向左移动",
			"向右移动"
		};

		// Token: 0x0401A637 RID: 108087
		[StaticVariableRuleIgnore]
		private static readonly int Tag1 = GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑轨.能够左跳"];

		// Token: 0x0401A638 RID: 108088
		[StaticVariableRuleIgnore]
		private static readonly int Tag2 = GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑轨.能够右跳"];

		// Token: 0x0401A639 RID: 108089
		[StaticVariableRuleIgnore]
		private static readonly int ForbidMoveTagId = GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑轨UI.隐藏跳跃按键"];

		// Token: 0x0401A63A RID: 108090
		private const int EFFECT_ID = 1003;

		// Token: 0x0401A63B RID: 108091
		private readonly List<MoveSkillItem> SkillItemList = new List<MoveSkillItem>();

		// Token: 0x0401A63C RID: 108092
		[Nullable(2)]
		private BattleUiRoleData RoleData;

		// Token: 0x0401A63D RID: 108093
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x0200AA90 RID: 43664
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034B66 RID: 215910
			Item1,
			// Token: 0x04034B67 RID: 215911
			Item2
		}
	}
}
