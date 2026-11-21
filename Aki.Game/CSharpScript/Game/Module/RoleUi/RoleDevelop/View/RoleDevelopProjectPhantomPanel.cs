using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D0B RID: 15627
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectPhantomPanel : RoleDevelopProjectBasePanel
	{
		// Token: 0x06027FE7 RID: 163815 RVA: 0x00B31290 File Offset: 0x00B2F490
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickSwitchButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027FE8 RID: 163816 RVA: 0x00B31464 File Offset: 0x00B2F664
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectPhantomPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectPhantomPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027FE9 RID: 163817 RVA: 0x00B314A8 File Offset: 0x00B2F6A8
		private UniTask InitPhantomItems()
		{
			RoleDevelopProjectPhantomPanel.<InitPhantomItems>d__9 <InitPhantomItems>d__;
			<InitPhantomItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPhantomItems>d__.<>4__this = this;
			<InitPhantomItems>d__.<>1__state = -1;
			<InitPhantomItems>d__.<>t__builder.Start<RoleDevelopProjectPhantomPanel.<InitPhantomItems>d__9>(ref <InitPhantomItems>d__);
			return <InitPhantomItems>d__.<>t__builder.Task;
		}

		// Token: 0x06027FEA RID: 163818 RVA: 0x00B314EC File Offset: 0x00B2F6EC
		private UniTask InitButtonItem()
		{
			RoleDevelopProjectPhantomPanel.<InitButtonItem>d__10 <InitButtonItem>d__;
			<InitButtonItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonItem>d__.<>4__this = this;
			<InitButtonItem>d__.<>1__state = -1;
			<InitButtonItem>d__.<>t__builder.Start<RoleDevelopProjectPhantomPanel.<InitButtonItem>d__10>(ref <InitButtonItem>d__);
			return <InitButtonItem>d__.<>t__builder.Task;
		}

		// Token: 0x06027FEB RID: 163819 RVA: 0x00B3152F File Offset: 0x00B2F72F
		private void InitLayout()
		{
			this.PhantomSuitLayout = new GenericLayout<RoleDevelopProjectPhantomSuitItem, RoleDevelopPhantomSuitData>(base.GetVerticalLayout(9), new Func<RoleDevelopProjectPhantomSuitItem>(this.CreatePhantomSuitItem), null, false, true);
		}

		// Token: 0x06027FEC RID: 163820 RVA: 0x00B31554 File Offset: 0x00B2F754
		protected override void OnDataChanged()
		{
			int id = this.Data.GetId();
			if (this.FetterInitRoleId == id)
			{
				return;
			}
			RoleDevelopRoleBaseData developRoleData = this.Data.GetDevelopRoleData();
			this.SelectPlanId = developRoleData.GetRecommendPlanId();
			this.SelectFirstVisionMonsterId = new int?(developRoleData.GetRecommendFirstVisionMonsterId());
			this.FetterInitRoleId = id;
		}

		// Token: 0x06027FED RID: 163821 RVA: 0x00B315A8 File Offset: 0x00B2F7A8
		protected override void OnRefreshView(bool forceRefresh)
		{
			if (RoleDevelopUtil.IsAnyProspectRole(this.Data.GetId()))
			{
				this.RootItem.SetUIActive(false);
				return;
			}
			this.RootItem.SetUIActive(true);
			RoleDevelopRoleBaseData developRoleData = this.Data.GetDevelopRoleData();
			UUIItem item = base.GetItem(0);
			this.RefreshPhantomSuitList(forceRefresh);
			if (!developRoleData.CanDevelopPhantom())
			{
				item.SetUIActive(false);
				return;
			}
			item.SetUIActive(true);
			base.GetItem(2).SetUIActive(false);
			this.RefreshPhantomItems();
		}

		// Token: 0x06027FEE RID: 163822 RVA: 0x00B31624 File Offset: 0x00B2F824
		private void RefreshPhantomSuitList(bool forceRefresh)
		{
			if (!forceRefresh && this.PhantomSuitLayout.GetDisplayGridNum() > 0)
			{
				this.PhantomSuitLayout.RefreshWithoutDataSync();
				return;
			}
			List<RoleDevelopPhantomSuitData> recommendPhantomSuits = this.Data.GetDevelopRoleData().GetRecommendPhantomSuits(new int?(this.SelectPlanId), this.SelectFirstVisionMonsterId);
			if (recommendPhantomSuits.Count > 0)
			{
				recommendPhantomSuits[0].IsNeedFetterButton = new bool?(true);
			}
			this.PhantomSuitLayout.RefreshByData(recommendPhantomSuits, null, false);
		}

		// Token: 0x06027FEF RID: 163823 RVA: 0x00B3169C File Offset: 0x00B2F89C
		private void RefreshPhantomItems()
		{
			RoleDevelopData data = this.Data;
			List<int> phantomIdList = data.GetDevelopRoleData().GetPhantomIdList();
			for (int i = 0; i < this.PhantomItems.Count; i++)
			{
				this.PhantomItems[i].Refresh(data, (i < phantomIdList.Count) ? phantomIdList[i] : 0, i, true);
			}
		}

		// Token: 0x06027FF0 RID: 163824 RVA: 0x00B316FC File Offset: 0x00B2F8FC
		private void OnClickSwitchButton()
		{
			if (this.Data == null)
			{
				return;
			}
			VisionRecommendViewOpenParam param = new VisionRecommendViewOpenParam
			{
				RoleId = this.Data.GetId(),
				IsFromRoleDev = true,
				SuccessCallBack = new Action<int, int, int?>(this.OnChangeFetterGroupSuccessCallBack),
				GetSelectedPlanIdCallBack = new Func<int, int>(this.OnGetSelectedPlanIdCallBack),
				GetSelectedFirstVisionMonsterIdCallBack = new Func<int, int>(this.OnGetSelectedFirstVisionMonsterIdCallBack)
			};
			UiManager.Instance.OpenView(EUiViewName.VisionNewRecommendView, param, null);
			RoleController.Instance.LogRoleDevelopClick(this.Data.GetId(), ERoleDevelopCategoryType.Phantom, ERoleDevelopLogSubPage.PhantomDevelopSwitchSuit, null);
		}

		// Token: 0x06027FF1 RID: 163825 RVA: 0x00B31798 File Offset: 0x00B2F998
		private void OnClickDevelop(int value)
		{
			if (this.Data == null)
			{
				return;
			}
			int id = this.Data.GetId();
			int num = 0;
			PhantomBattleModel.Instance.CurrentEquipmentSelectIndex = num;
			int equipByIndex = PhantomBattleController.Instance.GetEquipByIndex(id, num);
			PhantomBattleModel.Instance.CurrentSelectUniqueId = equipByIndex;
			PhantomUtil.OpenVisionEquipmentView(id, num, null);
			RoleController.Instance.LogRoleDevelopClick(id, ERoleDevelopCategoryType.Phantom, ERoleDevelopLogSubPage.PhantomDevelopJump, null);
		}

		// Token: 0x06027FF2 RID: 163826 RVA: 0x00B31807 File Offset: 0x00B2FA07
		private RoleDevelopProjectPhantomSuitItem CreatePhantomSuitItem()
		{
			return new RoleDevelopProjectPhantomSuitItem();
		}

		// Token: 0x06027FF3 RID: 163827 RVA: 0x00B3180E File Offset: 0x00B2FA0E
		private void OnChangeFetterGroupSuccessCallBack(int roleId, int planId, int? firstVisionMonsterId)
		{
			this.SelectPlanId = planId;
			this.SelectFirstVisionMonsterId = firstVisionMonsterId;
			this.RefreshPhantomSuitList(true);
			if (RoleDevelopModel.Instance.DevTargetRoleId == roleId)
			{
				RoleController.Instance.RequestUpdateDevelopTarget(roleId, ERoleDevelopUpdateTargetSource.RoleDevelop, new int?(planId), firstVisionMonsterId);
			}
		}

		// Token: 0x06027FF4 RID: 163828 RVA: 0x00B31845 File Offset: 0x00B2FA45
		private int OnGetSelectedPlanIdCallBack(int roleId)
		{
			return this.SelectPlanId;
		}

		// Token: 0x06027FF5 RID: 163829 RVA: 0x00B3184D File Offset: 0x00B2FA4D
		private int OnGetSelectedFirstVisionMonsterIdCallBack(int roleId)
		{
			return this.SelectFirstVisionMonsterId.GetValueOrDefault();
		}

		// Token: 0x04015C70 RID: 89200
		private List<RoleDevelopProjectPhantomItem> PhantomItems = new List<RoleDevelopProjectPhantomItem>();

		// Token: 0x04015C71 RID: 89201
		private ButtonItem ButtonDevelop;

		// Token: 0x04015C72 RID: 89202
		public int SelectPlanId;

		// Token: 0x04015C73 RID: 89203
		public int? SelectFirstVisionMonsterId = new int?(0);

		// Token: 0x04015C74 RID: 89204
		private int FetterInitRoleId;

		// Token: 0x04015C75 RID: 89205
		private GenericLayout<RoleDevelopProjectPhantomSuitItem, RoleDevelopPhantomSuitData> PhantomSuitLayout;

		// Token: 0x020098D7 RID: 39127
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FA9E RID: 195230
			PanelPhantomDev,
			// Token: 0x0402FA9F RID: 195231
			BtnDevelop,
			// Token: 0x0402FAA0 RID: 195232
			BtnPerfectDevelop,
			// Token: 0x0402FAA1 RID: 195233
			SubPhantomCircle1,
			// Token: 0x0402FAA2 RID: 195234
			SubPhantomCircle2,
			// Token: 0x0402FAA3 RID: 195235
			SubPhantomCircle3,
			// Token: 0x0402FAA4 RID: 195236
			SubPhantomCircle4,
			// Token: 0x0402FAA5 RID: 195237
			SubPhantomCircle5,
			// Token: 0x0402FAA6 RID: 195238
			BtnSwitch,
			// Token: 0x0402FAA7 RID: 195239
			PanelSuitLayout,
			// Token: 0x0402FAA8 RID: 195240
			PanelSuit
		}
	}
}
