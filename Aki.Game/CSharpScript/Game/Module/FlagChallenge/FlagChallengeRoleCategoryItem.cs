using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A4D RID: 19021
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeRoleCategoryItem : GridProxyAbstract<FlagChallengeRoleCategoryItemData>
	{
		// Token: 0x0602F9EF RID: 195055 RVA: 0x00D4899C File Offset: 0x00D46B9C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602F9F0 RID: 195056 RVA: 0x00D489F8 File Offset: 0x00D46BF8
		protected override void OnStart()
		{
			UUIGridLayout gridLayout = base.GetGridLayout(1);
			this.RoleLayout = new GenericLayout<FlagChallengeRoleMediumGridItem, RoleDataBase>(gridLayout, new Func<FlagChallengeRoleMediumGridItem>(this.CreateRoleItem), null, false, true);
			this.AnimationController = (gridLayout.GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
			EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeRoleSelectCategoryUpdate, new Action<int>(this.OnFlagChallengeRoleSelectCategoryUpdate));
		}

		// Token: 0x0602F9F1 RID: 195057 RVA: 0x00D48A64 File Offset: 0x00D46C64
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeRoleSelectCategoryUpdate, new Action<int>(this.OnFlagChallengeRoleSelectCategoryUpdate));
		}

		// Token: 0x0602F9F2 RID: 195058 RVA: 0x00D48A84 File Offset: 0x00D46C84
		public override void Refresh(FlagChallengeRoleCategoryItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, data.TitleKey, Array.Empty<object>());
			this.RoleLayout.RefreshByData(data.RoleList ?? new List<RoleDataBase>(), null, false);
			UUIInturnAnimController animationController = this.AnimationController;
			if (animationController == null)
			{
				return;
			}
			animationController.Play("", -1, false);
		}

		// Token: 0x0602F9F3 RID: 195059 RVA: 0x00D48AE9 File Offset: 0x00D46CE9
		private FlagChallengeRoleMediumGridItem CreateRoleItem()
		{
			FlagChallengeRoleMediumGridItem flagChallengeRoleMediumGridItem = new FlagChallengeRoleMediumGridItem();
			flagChallengeRoleMediumGridItem.SetOnSelectRole(new Action<int, EToggleState>(this.OnSelectRole));
			flagChallengeRoleMediumGridItem.SetCanSelectRole(new Func<int, EToggleState, bool>(this.CanSelectRole));
			return flagChallengeRoleMediumGridItem;
		}

		// Token: 0x0602F9F4 RID: 195060 RVA: 0x00D48B14 File Offset: 0x00D46D14
		private bool CanSelectRole(int roleId, EToggleState state)
		{
			return this.Data == null || this.Data.CanSelectRole == null || this.Data.CanSelectRole(roleId, state);
		}

		// Token: 0x0602F9F5 RID: 195061 RVA: 0x00D48B3F File Offset: 0x00D46D3F
		private void OnSelectRole(int roleId, EToggleState state)
		{
			if (this.Data != null && this.Data.OnSelectRole != null)
			{
				this.Data.OnSelectRole(roleId, state);
			}
			this.RoleLayout.RefreshWithoutDataSync();
		}

		// Token: 0x0602F9F6 RID: 195062 RVA: 0x00D48B74 File Offset: 0x00D46D74
		private void OnFlagChallengeRoleSelectCategoryUpdate(int roleId)
		{
			if (this.Data == null || this.Data.RoleList == null)
			{
				return;
			}
			bool flag = false;
			using (List<RoleDataBase>.Enumerator enumerator = this.Data.RoleList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetDataId() == roleId)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				this.RoleLayout.RefreshWithoutDataSync();
			}
		}

		// Token: 0x0602F9F7 RID: 195063 RVA: 0x00D48BF8 File Offset: 0x00D46DF8
		public override object GetKey(FlagChallengeRoleCategoryItemData data, int displayIndex)
		{
			return (int)data.CategoryType;
		}

		// Token: 0x04019468 RID: 103528
		[Nullable(2)]
		private FlagChallengeRoleCategoryItemData Data;

		// Token: 0x04019469 RID: 103529
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<FlagChallengeRoleMediumGridItem, RoleDataBase> RoleLayout;

		// Token: 0x0401946A RID: 103530
		[Nullable(2)]
		private UUIInturnAnimController AnimationController;
	}
}
