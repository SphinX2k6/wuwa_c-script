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
	// Token: 0x02005E2E RID: 24110
	[NullableContext(1)]
	[Nullable(0)]
	public class XiaKongQteView : UiTickViewBase
	{
		// Token: 0x0603D512 RID: 251154 RVA: 0x00EC78E4 File Offset: 0x00EC5AE4
		public XiaKongQteView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603D513 RID: 251155 RVA: 0x00EC7904 File Offset: 0x00EC5B04
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

		// Token: 0x0603D514 RID: 251156 RVA: 0x00EC79D0 File Offset: 0x00EC5BD0
		protected override UniTask OnBeforeStartAsync()
		{
			XiaKongQteView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<XiaKongQteView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D515 RID: 251157 RVA: 0x00EC7A14 File Offset: 0x00EC5C14
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

		// Token: 0x0603D516 RID: 251158 RVA: 0x00EC7A60 File Offset: 0x00EC5C60
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

		// Token: 0x0603D517 RID: 251159 RVA: 0x00EC7AAC File Offset: 0x00EC5CAC
		private UniTask NewEndSkillItem()
		{
			XiaKongQteView.<NewEndSkillItem>d__15 <NewEndSkillItem>d__;
			<NewEndSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewEndSkillItem>d__.<>4__this = this;
			<NewEndSkillItem>d__.<>1__state = -1;
			<NewEndSkillItem>d__.<>t__builder.Start<XiaKongQteView.<NewEndSkillItem>d__15>(ref <NewEndSkillItem>d__);
			return <NewEndSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D518 RID: 251160 RVA: 0x00EC7AF0 File Offset: 0x00EC5CF0
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

		// Token: 0x0603D519 RID: 251161 RVA: 0x00EC7C18 File Offset: 0x00EC5E18
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

		// Token: 0x0603D51A RID: 251162 RVA: 0x00EC7D80 File Offset: 0x00EC5F80
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

		// Token: 0x0603D51B RID: 251163 RVA: 0x00EC7DD7 File Offset: 0x00EC5FD7
		protected override void OnAddEventListener()
		{
			InputDistributeController.Instance.BindActions(new <>z__ReadOnlyArray<string>(new string[]
			{
				"向左移动",
				"向右移动",
				"大招"
			}), new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603D51C RID: 251164 RVA: 0x00EC7E12 File Offset: 0x00EC6012
		protected override void OnRemoveEventListener()
		{
			InputDistributeController.Instance.UnBindActions(new <>z__ReadOnlyArray<string>(new string[]
			{
				"向左移动",
				"向右移动",
				"大招"
			}), new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603D51D RID: 251165 RVA: 0x00EC7E50 File Offset: 0x00EC6050
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

		// Token: 0x0603D51E RID: 251166 RVA: 0x00EC7F98 File Offset: 0x00EC6198
		private void OnRoleChange(int i, int i1)
		{
			this.RefreshRoleData();
		}

		// Token: 0x0603D51F RID: 251167 RVA: 0x00EC7FA0 File Offset: 0x00EC61A0
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

		// Token: 0x0603D520 RID: 251168 RVA: 0x00EC8000 File Offset: 0x00EC6200
		private void OnSpecialSkillEnableChanged(int entityId, int roleId, bool enable)
		{
			if (roleId == 1407 && !enable)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0603D521 RID: 251169 RVA: 0x00EC8014 File Offset: 0x00EC6214
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

		// Token: 0x0603D522 RID: 251170 RVA: 0x00EC807F File Offset: 0x00EC627F
		private void OnPressItem(int inputType)
		{
			SpecialSkillXiaKong specialSkill = this.SpecialSkill;
			if (specialSkill == null)
			{
				return;
			}
			specialSkill.SetInputType(inputType);
		}

		// Token: 0x0603D523 RID: 251171 RVA: 0x00EC8094 File Offset: 0x00EC6294
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

		// Token: 0x0401FFA7 RID: 130983
		private const int XIA_KONG_ROLE_ID = 1407;

		// Token: 0x0401FFA8 RID: 130984
		[StaticVariableRuleIgnore]
		private static readonly int[] InputTypeList = new int[]
		{
			1,
			2
		};

		// Token: 0x0401FFA9 RID: 130985
		private readonly List<XiaKongQteSkillItem> SkillItemList = new List<XiaKongQteSkillItem>();

		// Token: 0x0401FFAA RID: 130986
		[Nullable(2)]
		private XiaKongQteSkillItem EndSkillItem;

		// Token: 0x0401FFAB RID: 130987
		private readonly List<XiaKongQteBar> BarItemList = new List<XiaKongQteBar>();

		// Token: 0x0401FFAC RID: 130988
		[Nullable(2)]
		private BattleUiRoleData RoleData;

		// Token: 0x0401FFAD RID: 130989
		[Nullable(2)]
		private SpecialSkillXiaKong SpecialSkill;

		// Token: 0x0401FFAE RID: 130990
		private bool IsVisible;

		// Token: 0x0401FFAF RID: 130991
		private bool IsPlayStartAnim;

		// Token: 0x0200C1AD RID: 49581
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A868 RID: 239720
			BarItem,
			// Token: 0x0403A869 RID: 239721
			SkillItem,
			// Token: 0x0403A86A RID: 239722
			EndSkillItem,
			// Token: 0x0403A86B RID: 239723
			BarItem2,
			// Token: 0x0403A86C RID: 239724
			SkillItem2
		}
	}
}
