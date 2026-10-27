using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A71 RID: 23153
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeRoleCategoryItem : GridProxyAbstract<FlagChallengeRoleCategoryItemData>
	{
		// Token: 0x0603AAA6 RID: 240294 RVA: 0x00DF8418 File Offset: 0x00DF6618
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603AAA7 RID: 240295 RVA: 0x00DF8474 File Offset: 0x00DF6674
		protected override void OnStart()
		{
			UUIGridLayout gridLayout = base.GetGridLayout(1);
			this.RoleLayout = new GenericLayout<FlagChallengeRoleMediumGridItem, RoleDataBase>(gridLayout, new Func<FlagChallengeRoleMediumGridItem>(this.CreateRoleItem), null, false, true);
			this.AnimationController = (gridLayout.GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
			EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeRoleSelectCategoryUpdate, new Action<int>(this.OnFlagChallengeRoleSelectCategoryUpdate));
		}

		// Token: 0x0603AAA8 RID: 240296 RVA: 0x00DF84E0 File Offset: 0x00DF66E0
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeRoleSelectCategoryUpdate, new Action<int>(this.OnFlagChallengeRoleSelectCategoryUpdate));
		}

		// Token: 0x0603AAA9 RID: 240297 RVA: 0x00DF8500 File Offset: 0x00DF6700
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

		// Token: 0x0603AAAA RID: 240298 RVA: 0x00DF8565 File Offset: 0x00DF6765
		private FlagChallengeRoleMediumGridItem CreateRoleItem()
		{
			FlagChallengeRoleMediumGridItem flagChallengeRoleMediumGridItem = new FlagChallengeRoleMediumGridItem();
			flagChallengeRoleMediumGridItem.SetOnSelectRole(new Action<int, EToggleState>(this.OnSelectRole));
			flagChallengeRoleMediumGridItem.SetCanSelectRole(new Func<int, EToggleState, bool>(this.CanSelectRole));
			return flagChallengeRoleMediumGridItem;
		}

		// Token: 0x0603AAAB RID: 240299 RVA: 0x00DF8590 File Offset: 0x00DF6790
		private bool CanSelectRole(int roleId, EToggleState state)
		{
			return this.Data == null || this.Data.CanSelectRole == null || this.Data.CanSelectRole(roleId, state);
		}

		// Token: 0x0603AAAC RID: 240300 RVA: 0x00DF85BB File Offset: 0x00DF67BB
		private void OnSelectRole(int roleId, EToggleState state)
		{
			if (this.Data != null && this.Data.OnSelectRole != null)
			{
				this.Data.OnSelectRole(roleId, state);
			}
			this.RoleLayout.RefreshWithoutDataSync();
		}

		// Token: 0x0603AAAD RID: 240301 RVA: 0x00DF85F0 File Offset: 0x00DF67F0
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

		// Token: 0x0603AAAE RID: 240302 RVA: 0x00DF8674 File Offset: 0x00DF6874
		public override object GetKey(FlagChallengeRoleCategoryItemData data, int displayIndex)
		{
			return (int)data.CategoryType;
		}

		// Token: 0x0401E9C1 RID: 125377
		[Nullable(2)]
		private FlagChallengeRoleCategoryItemData Data;

		// Token: 0x0401E9C2 RID: 125378
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<FlagChallengeRoleMediumGridItem, RoleDataBase> RoleLayout;

		// Token: 0x0401E9C3 RID: 125379
		[Nullable(2)]
		private UUIInturnAnimController AnimationController;
	}
}
