using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E13 RID: 19987
	[NullableContext(1)]
	[Nullable(0)]
	public class XiaKongQteView : UiTickViewBase
	{
		// Token: 0x060324A2 RID: 205986 RVA: 0x00E18E50 File Offset: 0x00E17050
		public XiaKongQteView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060324A3 RID: 205987 RVA: 0x00E18E70 File Offset: 0x00E17070
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060324A4 RID: 205988 RVA: 0x00E18F3C File Offset: 0x00E1713C
		protected override UniTask OnBeforeStartAsync()
		{
			XiaKongQteView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<XiaKongQteView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060324A5 RID: 205989 RVA: 0x00E18F80 File Offset: 0x00E17180
		private UniTask NewBarItem(XiaKongQteView.EChildType childType)
		{
			XiaKongQteView.<NewBarItem>d__13 <NewBarItem>d__;
			<NewBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewBarItem>d__.<>4__this = this;
			<NewBarItem>d__.childType = childType;
			<NewBarItem>d__.<>1__state = -1;
			<NewBarItem>d__.<>t__builder.Start<XiaKongQteView.<NewBarItem>d__13>(ref <NewBarItem>d__);
			return <NewBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060324A6 RID: 205990 RVA: 0x00E18FCC File Offset: 0x00E171CC
		private UniTask NewSkillItem(XiaKongQteView.EChildType childType)
		{
			XiaKongQteView.<NewSkillItem>d__14 <NewSkillItem>d__;
			<NewSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewSkillItem>d__.<>4__this = this;
			<NewSkillItem>d__.childType = childType;
			<NewSkillItem>d__.<>1__state = -1;
			<NewSkillItem>d__.<>t__builder.Start<XiaKongQteView.<NewSkillItem>d__14>(ref <NewSkillItem>d__);
			return <NewSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x060324A7 RID: 205991 RVA: 0x00E19018 File Offset: 0x00E17218
		private UniTask NewEndSkillItem()
		{
			XiaKongQteView.<NewEndSkillItem>d__15 <NewEndSkillItem>d__;
			<NewEndSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewEndSkillItem>d__.<>4__this = this;
			<NewEndSkillItem>d__.<>1__state = -1;
			<NewEndSkillItem>d__.<>t__builder.Start<XiaKongQteView.<NewEndSkillItem>d__15>(ref <NewEndSkillItem>d__);
			return <NewEndSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x060324A8 RID: 205992 RVA: 0x00E1905C File Offset: 0x00E1725C
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnRoleChange));
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Add<int, int, bool>(EEventName.BattleUiSpecialSkillEnableChanged, new Action<int, int, bool>(this.OnSpecialSkillEnableChanged));
			for (int i = 0; i < this.SkillItemList.Count; i++)
			{
				this.BarItemList[i].Init(this.SkillItemList[i]);
				this.SkillItemList[i].SetPressCallback(new Action<int>(this.OnPressItem));
				this.SkillItemList[i].RefreshType(XiaKongQteView.InputTypeList[i]);
			}
			this.RefreshRoleData();
			if (this.EndSkillItem != null)
			{
				this.EndSkillItem.SetPressCallback(new Action<int>(this.OnPressItem));
				this.EndSkillItem.RefreshType(4);
				this.EndSkillItem.SetSkillIconName("SkillButton_1407200_Name");
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAlpha(0f);
			}
			this.IsPlayStartAnim = false;
		}

		// Token: 0x060324A9 RID: 205993 RVA: 0x00E19184 File Offset: 0x00E17384
		private void RefreshRoleData()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			bool flag;
			if (curRoleData == null)
			{
				flag = true;
			}
			else
			{
				BattleUiRoleData battleUiRoleData = curRoleData;
				flag = (((battleUiRoleData.RoleConfig != null) ? new int?(battleUiRoleData.RoleConfig.GetValueOrDefault().Id) : null).GetValueOrDefault() != 1407);
			}
			if (flag)
			{
				this.RoleData = null;
				this.SpecialSkill = null;
				foreach (XiaKongQteBar xiaKongQteBar in this.BarItemList)
				{
					xiaKongQteBar.Refresh(null);
				}
				base.CloseMe(null);
				return;
			}
			this.RoleData = curRoleData;
			EntityHandle entityHandle = this.RoleData.EntityHandle;
			CharacterSpecialSkillComponent characterSpecialSkillComponent;
			if (entityHandle == null)
			{
				characterSpecialSkillComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				characterSpecialSkillComponent = ((entity != null) ? entity.GetComponent<CharacterSpecialSkillComponent>() : null);
			}
			CharacterSpecialSkillComponent characterSpecialSkillComponent2 = characterSpecialSkillComponent;
			this.SpecialSkill = (((characterSpecialSkillComponent2 != null) ? characterSpecialSkillComponent2.SpecialSkill : null) as SpecialSkillXiaKong);
			SpecialSkillXiaKong specialSkill = this.SpecialSkill;
			if (specialSkill == null || !specialSkill.GetIsUltraSkillState())
			{
				base.CloseMe(null);
				return;
			}
			this.SetVisible(true);
			foreach (XiaKongQteBar xiaKongQteBar2 in this.BarItemList)
			{
				xiaKongQteBar2.Refresh(this.SpecialSkill);
			}
		}

		// Token: 0x060324AA RID: 205994 RVA: 0x00E192EC File Offset: 0x00E174EC
		private void SetVisible(bool visible)
		{
			if (this.IsVisible == visible)
			{
				return;
			}
			this.IsVisible = visible;
			this.SetActive(visible);
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildrenVisible(EBattleUiVisibleReason.SpecialSkill, new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
			{
				EBattleUiChild.SkillButton,
				EBattleUiChild.GamepadSkillButton,
				EBattleUiChild.BattleHud
			}), !visible, true, 0);
		}

		// Token: 0x060324AB RID: 205995 RVA: 0x00E19343 File Offset: 0x00E17543
		protected override void OnAddEventListener()
		{
			InputDistributeController.Instance.BindActions(new <>z__ReadOnlyArray<string>(new string[]
			{
				"向左移动",
				"向右移动",
				"大招"
			}), new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x060324AC RID: 205996 RVA: 0x00E1937E File Offset: 0x00E1757E
		protected override void OnRemoveEventListener()
		{
			InputDistributeController.Instance.UnBindActions(new <>z__ReadOnlyArray<string>(new string[]
			{
				"向左移动",
				"向右移动",
				"大招"
			}), new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x060324AD RID: 205997 RVA: 0x00E193BC File Offset: 0x00E175BC
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnRoleChange));
			EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Remove(EEventName.BattleUiSpecialSkillEnableChanged, new Action<int, int, bool>(this.OnSpecialSkillEnableChanged));
			foreach (XiaKongQteBar xiaKongQteBar in this.BarItemList)
			{
				xiaKongQteBar.Destroy(null);
			}
			this.BarItemList.Clear();
			foreach (XiaKongQteSkillItem xiaKongQteSkillItem in this.SkillItemList)
			{
				xiaKongQteSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
			if (this.EndSkillItem != null)
			{
				this.EndSkillItem.Destroy(null);
				this.EndSkillItem = null;
			}
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildrenVisible(EBattleUiVisibleReason.SpecialSkill, new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
			{
				EBattleUiChild.SkillButton,
				EBattleUiChild.GamepadSkillButton,
				EBattleUiChild.BattleHud
			}), true, true, 0);
		}

		// Token: 0x060324AE RID: 205998 RVA: 0x00E19504 File Offset: 0x00E17704
		private void OnRoleChange(int i, int i1)
		{
			this.RefreshRoleData();
		}

		// Token: 0x060324AF RID: 205999 RVA: 0x00E1950C File Offset: 0x00E1770C
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			foreach (XiaKongQteSkillItem xiaKongQteSkillItem in this.SkillItemList)
			{
				xiaKongQteSkillItem.RefreshOnInputControllerMainTypeChange();
			}
			XiaKongQteSkillItem endSkillItem = this.EndSkillItem;
			if (endSkillItem == null)
			{
				return;
			}
			endSkillItem.RefreshOnInputControllerMainTypeChange();
		}

		// Token: 0x060324B0 RID: 206000 RVA: 0x00E1956C File Offset: 0x00E1776C
		private void OnSpecialSkillEnableChanged(int entityId, int roleId, bool enable)
		{
			if (roleId == 1407 && !enable)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x060324B1 RID: 206001 RVA: 0x00E19580 File Offset: 0x00E17780
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			if (this.SpecialSkill == null)
			{
				return;
			}
			if (actionName == "向左移动")
			{
				this.SpecialSkill.SetInputType(2);
				return;
			}
			if (actionName == "向右移动")
			{
				this.SpecialSkill.SetInputType(1);
				return;
			}
			if (!(actionName == "大招"))
			{
				return;
			}
			this.SpecialSkill.SetInputType(4);
		}

		// Token: 0x060324B2 RID: 206002 RVA: 0x00E195EB File Offset: 0x00E177EB
		private void OnPressItem(int inputType)
		{
			SpecialSkillXiaKong specialSkill = this.SpecialSkill;
			if (specialSkill == null)
			{
				return;
			}
			specialSkill.SetInputType(inputType);
		}

		// Token: 0x060324B3 RID: 206003 RVA: 0x00E19600 File Offset: 0x00E17800
		protected override void OnTick(float delta)
		{
			foreach (XiaKongQteBar xiaKongQteBar in this.BarItemList)
			{
				xiaKongQteBar.Tick(delta);
			}
			foreach (XiaKongQteSkillItem xiaKongQteSkillItem in this.SkillItemList)
			{
				xiaKongQteSkillItem.Tick(delta);
			}
			XiaKongQteSkillItem endSkillItem = this.EndSkillItem;
			if (endSkillItem != null)
			{
				endSkillItem.Tick(delta);
			}
			if (!this.IsPlayStartAnim && this.SpecialSkill != null && this.SpecialSkill.GetNextGenCircleIndex() > 0 && this.SpecialSkill.GetNextEndCircleAttrValue(0) / this.SpecialSkill.GetMinAttrValue() >= 0.3f)
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem != null)
				{
					rootItem.SetAlpha(1f);
				}
				base.PlaySequence("Start01", null, false);
				this.IsPlayStartAnim = true;
			}
		}

		// Token: 0x0401AA6E RID: 109166
		private const int XIA_KONG_ROLE_ID = 1407;

		// Token: 0x0401AA6F RID: 109167
		[StaticVariableRuleIgnore]
		private static readonly int[] InputTypeList = new int[]
		{
			1,
			2
		};

		// Token: 0x0401AA70 RID: 109168
		private readonly List<XiaKongQteSkillItem> SkillItemList = new List<XiaKongQteSkillItem>();

		// Token: 0x0401AA71 RID: 109169
		[Nullable(2)]
		private XiaKongQteSkillItem EndSkillItem;

		// Token: 0x0401AA72 RID: 109170
		private readonly List<XiaKongQteBar> BarItemList = new List<XiaKongQteBar>();

		// Token: 0x0401AA73 RID: 109171
		[Nullable(2)]
		private BattleUiRoleData RoleData;

		// Token: 0x0401AA74 RID: 109172
		[Nullable(2)]
		private SpecialSkillXiaKong SpecialSkill;

		// Token: 0x0401AA75 RID: 109173
		private bool IsVisible;

		// Token: 0x0401AA76 RID: 109174
		private bool IsPlayStartAnim;

		// Token: 0x0200ABBC RID: 43964
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403525A RID: 217690
			BarItem,
			// Token: 0x0403525B RID: 217691
			SkillItem,
			// Token: 0x0403525C RID: 217692
			EndSkillItem,
			// Token: 0x0403525D RID: 217693
			BarItem2,
			// Token: 0x0403525E RID: 217694
			SkillItem2
		}
	}
}
