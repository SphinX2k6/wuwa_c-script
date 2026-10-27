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
	// Token: 0x02004E1D RID: 19997
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSelectRoleGrid : UiPanelBase, IDynamicScrollItem<RoguelikeSelectRoleData>
	{
		// Token: 0x06033941 RID: 211265 RVA: 0x00C0F820 File Offset: 0x00C0DA20
		public RoguelikeSelectRoleGrid(RoguelikeSelectRoleData data)
		{
			this.Data = data;
		}

		// Token: 0x06033942 RID: 211266 RVA: 0x00C0F83A File Offset: 0x00C0DA3A
		public void BindSelectRoleCallBack(Action<RoleDataBase, int> selectCallback)
		{
			this.SelectRoleCallBack = selectCallback;
		}

		// Token: 0x06033943 RID: 211267 RVA: 0x00C0F843 File Offset: 0x00C0DA43
		public AUIBaseActor GetUsingItem(RoguelikeSelectRoleData data)
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x06033944 RID: 211268 RVA: 0x00C0F855 File Offset: 0x00C0DA55
		public void Update(RoguelikeSelectRoleData data, int index)
		{
			this.Data = data;
			this.RefreshData().AsTask();
		}

		// Token: 0x06033945 RID: 211269 RVA: 0x00C0F86C File Offset: 0x00C0DA6C
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

		// Token: 0x06033946 RID: 211270 RVA: 0x00C0F8B8 File Offset: 0x00C0DAB8
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

		// Token: 0x06033947 RID: 211271 RVA: 0x00C0F944 File Offset: 0x00C0DB44
		public UniTask RefreshData()
		{
			RoguelikeSelectRoleGrid.<RefreshData>d__12 <RefreshData>d__;
			<RefreshData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshData>d__.<>4__this = this;
			<RefreshData>d__.<>1__state = -1;
			<RefreshData>d__.<>t__builder.Start<RoguelikeSelectRoleGrid.<RefreshData>d__12>(ref <RefreshData>d__);
			return <RefreshData>d__.<>t__builder.Task;
		}

		// Token: 0x06033948 RID: 211272 RVA: 0x00C0F988 File Offset: 0x00C0DB88
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

		// Token: 0x06033949 RID: 211273 RVA: 0x00C0FA50 File Offset: 0x00C0DC50
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0603394B RID: 211275 RVA: 0x00C0FA64 File Offset: 0x00C0DC64
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

		// Token: 0x0401B5BA RID: 112058
		public List<RogueRoleSelectionItemGrid> RoleItemList = new List<RogueRoleSelectionItemGrid>();

		// Token: 0x0401B5BB RID: 112059
		[StaticVariableRuleIgnore]
		public static RogueRoleSelectionItemGrid CurSelectRoleItem;

		// Token: 0x0401B5BC RID: 112060
		[StaticVariableRuleIgnore]
		public static int CurSelectRoleId;

		// Token: 0x0401B5BD RID: 112061
		public RoguelikeSelectRoleData Data;

		// Token: 0x0401B5BE RID: 112062
		private Action<RoleDataBase, int> SelectRoleCallBack;

		// Token: 0x0200AFBC RID: 44988
		[NullableContext(0)]
		private class ERoguelikeSelectRoleGridDefine
		{
			// Token: 0x04035593 RID: 218515
			public const int TxtTitle = 0;

			// Token: 0x04035594 RID: 218516
			public const int ItemContainer = 1;

			// Token: 0x04035595 RID: 218517
			public const int RoleItem = 2;
		}
	}
}
