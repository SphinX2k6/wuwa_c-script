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
	// Token: 0x02004D42 RID: 19778
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectPhantomPanel : RoleDevelopProjectBasePanel
	{
		// Token: 0x0603318F RID: 209295 RVA: 0x00BE8504 File Offset: 0x00BE6704
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

		// Token: 0x06033190 RID: 209296 RVA: 0x00BE86D8 File Offset: 0x00BE68D8
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectPhantomPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectPhantomPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033191 RID: 209297 RVA: 0x00BE871C File Offset: 0x00BE691C
		private UniTask InitPhantomItems()
		{
			RoleDevelopProjectPhantomPanel.<InitPhantomItems>d__9 <InitPhantomItems>d__;
			<InitPhantomItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPhantomItems>d__.<>4__this = this;
			<InitPhantomItems>d__.<>1__state = -1;
			<InitPhantomItems>d__.<>t__builder.Start<RoleDevelopProjectPhantomPanel.<InitPhantomItems>d__9>(ref <InitPhantomItems>d__);
			return <InitPhantomItems>d__.<>t__builder.Task;
		}

		// Token: 0x06033192 RID: 209298 RVA: 0x00BE8760 File Offset: 0x00BE6960
		private UniTask InitButtonItem()
		{
			RoleDevelopProjectPhantomPanel.<InitButtonItem>d__10 <InitButtonItem>d__;
			<InitButtonItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonItem>d__.<>4__this = this;
			<InitButtonItem>d__.<>1__state = -1;
			<InitButtonItem>d__.<>t__builder.Start<RoleDevelopProjectPhantomPanel.<InitButtonItem>d__10>(ref <InitButtonItem>d__);
			return <InitButtonItem>d__.<>t__builder.Task;
		}

		// Token: 0x06033193 RID: 209299 RVA: 0x00BE87A3 File Offset: 0x00BE69A3
		private void InitLayout()
		{
			this.PhantomSuitLayout = new GenericLayout<RoleDevelopProjectPhantomSuitItem, RoleDevelopPhantomSuitData>(base.GetVerticalLayout(9), new Func<RoleDevelopProjectPhantomSuitItem>(this.CreatePhantomSuitItem), null, false, true);
		}

		// Token: 0x06033194 RID: 209300 RVA: 0x00BE87C8 File Offset: 0x00BE69C8
		protected override void OnRefreshView(bool forceRefresh)
		{
			if (RoleDevelopUtil.IsAnyProspectRole(this.Data.GetId()))
			{
				this.RootItem.SetUIActive(false);
				return;
			}
			this.RootItem.SetUIActive(true);
			RoleDevelopRoleBaseData developRoleData = this.Data.GetDevelopRoleData();
			int id = this.Data.GetId();
			if (this.FetterInitRoleId != id)
			{
				this.SelectPlanId = developRoleData.GetRecommendPlanId();
				this.SelectFirstVisionMonsterId = new int?(developRoleData.GetRecommendFirstVisionMonsterId());
				this.FetterInitRoleId = id;
			}
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

		// Token: 0x06033195 RID: 209301 RVA: 0x00BE8880 File Offset: 0x00BE6A80
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

		// Token: 0x06033196 RID: 209302 RVA: 0x00BE88F8 File Offset: 0x00BE6AF8
		private void RefreshPhantomItems()
		{
			RoleDevelopData data = this.Data;
			List<int> phantomIdList = data.GetDevelopRoleData().GetPhantomIdList();
			for (int i = 0; i < this.PhantomItems.Count; i++)
			{
				this.PhantomItems[i].Refresh(data, (i < phantomIdList.Count) ? phantomIdList[i] : 0, i);
			}
		}

		// Token: 0x06033197 RID: 209303 RVA: 0x00BE8954 File Offset: 0x00BE6B54
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

		// Token: 0x06033198 RID: 209304 RVA: 0x00BE89F0 File Offset: 0x00BE6BF0
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

		// Token: 0x06033199 RID: 209305 RVA: 0x00BE8A5F File Offset: 0x00BE6C5F
		private RoleDevelopProjectPhantomSuitItem CreatePhantomSuitItem()
		{
			return new RoleDevelopProjectPhantomSuitItem();
		}

		// Token: 0x0603319A RID: 209306 RVA: 0x00BE8A66 File Offset: 0x00BE6C66
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

		// Token: 0x0603319B RID: 209307 RVA: 0x00BE8A9D File Offset: 0x00BE6C9D
		private int OnGetSelectedPlanIdCallBack(int roleId)
		{
			return this.SelectPlanId;
		}

		// Token: 0x0603319C RID: 209308 RVA: 0x00BE8AA5 File Offset: 0x00BE6CA5
		private int OnGetSelectedFirstVisionMonsterIdCallBack(int roleId)
		{
			return this.SelectFirstVisionMonsterId.GetValueOrDefault();
		}

		// Token: 0x0401B2A0 RID: 111264
		private List<RoleDevelopProjectPhantomItem> PhantomItems = new List<RoleDevelopProjectPhantomItem>();

		// Token: 0x0401B2A1 RID: 111265
		private ButtonItem ButtonDevelop;

		// Token: 0x0401B2A2 RID: 111266
		public int SelectPlanId;

		// Token: 0x0401B2A3 RID: 111267
		public int? SelectFirstVisionMonsterId = new int?(0);

		// Token: 0x0401B2A4 RID: 111268
		private int FetterInitRoleId;

		// Token: 0x0401B2A5 RID: 111269
		private GenericLayout<RoleDevelopProjectPhantomSuitItem, RoleDevelopPhantomSuitData> PhantomSuitLayout;

		// Token: 0x0200AEA4 RID: 44708
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x04035081 RID: 217217
			public const int PanelPhantomDev = 0;

			// Token: 0x04035082 RID: 217218
			public const int BtnDevelop = 1;

			// Token: 0x04035083 RID: 217219
			public const int BtnPerfectDevelop = 2;

			// Token: 0x04035084 RID: 217220
			public const int SubPhantomCircle1 = 3;

			// Token: 0x04035085 RID: 217221
			public const int SubPhantomCircle2 = 4;

			// Token: 0x04035086 RID: 217222
			public const int SubPhantomCircle3 = 5;

			// Token: 0x04035087 RID: 217223
			public const int SubPhantomCircle4 = 6;

			// Token: 0x04035088 RID: 217224
			public const int SubPhantomCircle5 = 7;

			// Token: 0x04035089 RID: 217225
			public const int BtnSwitch = 8;

			// Token: 0x0403508A RID: 217226
			public const int PanelSuitLayout = 9;

			// Token: 0x0403508B RID: 217227
			public const int PanelSuit = 10;
		}
	}
}
