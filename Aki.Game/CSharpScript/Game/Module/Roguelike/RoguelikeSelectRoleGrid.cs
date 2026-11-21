using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DE6 RID: 15846
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSelectRoleGrid : UiPanelBase, IDynamicScrollItem<RoguelikeSelectRoleData>
	{
		// Token: 0x060287AC RID: 165804 RVA: 0x00B58D58 File Offset: 0x00B56F58
		public RoguelikeSelectRoleGrid(RoguelikeSelectRoleData data)
		{
			this.Data = data;
		}

		// Token: 0x060287AD RID: 165805 RVA: 0x00B58D72 File Offset: 0x00B56F72
		public void BindSelectRoleCallBack(Action<RoleDataBase, int> selectCallback)
		{
			this.SelectRoleCallBack = selectCallback;
		}

		// Token: 0x060287AE RID: 165806 RVA: 0x00B58D7B File Offset: 0x00B56F7B
		public AUIBaseActor GetUsingItem(RoguelikeSelectRoleData data)
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x060287AF RID: 165807 RVA: 0x00B58D8D File Offset: 0x00B56F8D
		public void Update(RoguelikeSelectRoleData data, int index)
		{
			this.Data = data;
			this.RefreshData().AsTask();
		}

		// Token: 0x060287B0 RID: 165808 RVA: 0x00B58DA4 File Offset: 0x00B56FA4
		public UniTask Init(UUIItem actor)
		{
			RoguelikeSelectRoleGrid.<Init>d__9 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RoguelikeSelectRoleGrid.<Init>d__9>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060287B1 RID: 165809 RVA: 0x00B58DF0 File Offset: 0x00B56FF0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060287B2 RID: 165810 RVA: 0x00B58E7C File Offset: 0x00B5707C
		public UniTask RefreshData()
		{
			RoguelikeSelectRoleGrid.<RefreshData>d__12 <RefreshData>d__;
			<RefreshData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshData>d__.<>4__this = this;
			<RefreshData>d__.<>1__state = -1;
			<RefreshData>d__.<>t__builder.Start<RoguelikeSelectRoleGrid.<RefreshData>d__12>(ref <RefreshData>d__);
			return <RefreshData>d__.<>t__builder.Task;
		}

		// Token: 0x060287B3 RID: 165811 RVA: 0x00B58EC0 File Offset: 0x00B570C0
		private void SelectRole(MediumItemGridExtendCallback callbackParameter)
		{
			if (callbackParameter.State == EToggleState.ETT_UnChecked)
			{
				RoleDataBase roleDataBase = callbackParameter.Data as RoleDataBase;
				if (roleDataBase.IsTrialRole())
				{
					RoguelikeModel.Instance.EditFormationRoleList = new List<int>
					{
						roleDataBase.GetDataId()
					};
				}
				else
				{
					RoguelikeModel.Instance.EditFormationRoleList = new List<int>
					{
						roleDataBase.GetRoleId()
					};
				}
				if (RoguelikeSelectRoleGrid.CurSelectRoleItem != null)
				{
					RoguelikeSelectRoleGrid.CurSelectRoleItem.SetSelected(false, false);
				}
				RoguelikeSelectRoleGrid.CurSelectRoleItem = (callbackParameter.MediumItemGrid as RogueRoleSelectionItemGrid);
				RoguelikeSelectRoleGrid.CurSelectRoleId = roleDataBase.GetDataId();
				RoleController.Instance.OnSelectedRoleChangeByConfig(roleDataBase.GetDataId(), roleDataBase.GetRoleSkinId(), null);
				if (this.SelectRoleCallBack != null)
				{
					this.SelectRoleCallBack(roleDataBase, (int)this.Data.Type);
				}
			}
		}

		// Token: 0x060287B4 RID: 165812 RVA: 0x00B58F88 File Offset: 0x00B57188
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x060287B6 RID: 165814 RVA: 0x00B58F9C File Offset: 0x00B5719C
		[CompilerGenerated]
		private void <RefreshData>g__UpdateFunc|12_0(RogueRoleSelectionItemGrid item, RoleDataBase data)
		{
			bool flag = (this.Data.LimitRoleList.Count > 0 && !this.Data.LimitRoleList.Contains(data.GetRoleId())) || data.GetLevelData().GetLevel() == 0;
			bool flag2 = RoleModel.Instance.GetRoleInstanceById(data.GetDataId()) != null;
			bool flag3 = this.Data.LimitRoleList.Contains(data.GetDataId());
			bool flag4 = (flag2 ? WeaponModel.Instance.GetWeaponDataByRoleDataId(data.GetDataId(), true).GetLevel() : 0) < this.Data.AddWeaponLevel && !data.IsTrialRole() && flag2 && flag3;
			bool flag5 = data.GetLevelData().GetLevel() < this.Data.AddRoleLevel && !data.IsTrialRole() && flag2 && flag3;
			CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(data.GetRoleId()),
				SkinId = data.GetRoleSkinId(),
				BottomTextId = (((flag5 || flag4) && !flag && !data.IsTrialRole()) ? "" : ((data.GetLevelData().GetLevel() != 0) ? "Text_LevelShow_Text" : "Text_Role_Not_Have")),
				BottomTextParameter = new object[]
				{
					data.GetLevelData().GetLevel()
				},
				ElementId = new int?(data.GetRoleConfig().ElementId),
				IsTrialRoleVisible = new bool?(data.IsTrialRole()),
				IsNewVisible = new bool?(false),
				IsDisable = new bool?(flag),
				IsRecommendVisible = new bool?(this.Data.RecommendedRoleList.Contains(data.GetRoleId()))
			};
			item.Apply<CharacterMediumItemGrid>(parameters);
			item.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.SelectRole));
			item.SetSelected(RoguelikeSelectRoleGrid.CurSelectRoleId == data.GetDataId(), false);
			if (item != null)
			{
				item.SetAddLevelComponent(this.Data.AddRoleLevel, this.Data.MaxLevel, flag5 || flag4);
			}
		}

		// Token: 0x04015F8D RID: 89997
		public List<RogueRoleSelectionItemGrid> RoleItemList = new List<RogueRoleSelectionItemGrid>();

		// Token: 0x04015F8E RID: 89998
		[StaticVariableRuleIgnore]
		public static RogueRoleSelectionItemGrid CurSelectRoleItem;

		// Token: 0x04015F8F RID: 89999
		[StaticVariableRuleIgnore]
		public static int CurSelectRoleId;

		// Token: 0x04015F90 RID: 90000
		public RoguelikeSelectRoleData Data;

		// Token: 0x04015F91 RID: 90001
		private Action<RoleDataBase, int> SelectRoleCallBack;

		// Token: 0x020099EE RID: 39406
		[NullableContext(0)]
		private class ERoguelikeSelectRoleGridDefine
		{
			// Token: 0x0402FFC3 RID: 196547
			public const int TxtTitle = 0;

			// Token: 0x0402FFC4 RID: 196548
			public const int ItemContainer = 1;

			// Token: 0x0402FFC5 RID: 196549
			public const int RoleItem = 2;
		}
	}
}
