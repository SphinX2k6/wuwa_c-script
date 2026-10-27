using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068A5 RID: 26789
	[NullableContext(1)]
	[Nullable(0)]
	public class AdamFormationRoleContainer : UiPanelBase, IDynamicScrollItem<AdamFormationRoleGroupInfo>
	{
		// Token: 0x06042D96 RID: 273814 RVA: 0x010462C8 File Offset: 0x010444C8
		public UniTask Init(UUIItem actor)
		{
			AdamFormationRoleContainer.<Init>d__5 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<AdamFormationRoleContainer.<Init>d__5>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06042D97 RID: 273815 RVA: 0x01046313 File Offset: 0x01044513
		public void ClearItem()
		{
		}

		// Token: 0x06042D98 RID: 273816 RVA: 0x01046315 File Offset: 0x01044515
		[return: Nullable(2)]
		public AUIBaseActor GetUsingItem(AdamFormationRoleGroupInfo data)
		{
			if (data.IsTitleType)
			{
				UUIItem item = base.GetItem(2);
				return ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			}
			UUIGridLayout gridLayout = base.GetGridLayout(0);
			return ((gridLayout != null) ? gridLayout.GetOwner() : null) as AUIBaseActor;
		}

		// Token: 0x06042D99 RID: 273817 RVA: 0x01046350 File Offset: 0x01044550
		public void Update(AdamFormationRoleGroupInfo data, int index)
		{
			this.Data = data;
			if (data.IsTitleType)
			{
				this.RefreshTitle();
				return;
			}
			this.RefreshRoleList();
		}

		// Token: 0x06042D9A RID: 273818 RVA: 0x0104636E File Offset: 0x0104456E
		public void InitData(AdamFormationRoleGroupInfo data)
		{
			this.Data = data;
		}

		// Token: 0x06042D9B RID: 273819 RVA: 0x01046377 File Offset: 0x01044577
		public void Refresh()
		{
			if (this.Data.IsTitleType)
			{
				this.RefreshTitle();
				return;
			}
			GenericLayout<WeeklyRogueRoleGridItem, RoleDataBase> roleLayout = this.RoleLayout;
			if (roleLayout == null)
			{
				return;
			}
			roleLayout.RefreshWithoutDataSync();
		}

		// Token: 0x06042D9C RID: 273820 RVA: 0x010463A0 File Offset: 0x010445A0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x06042D9D RID: 273821 RVA: 0x01046428 File Offset: 0x01044628
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
			base.GetGridLayout(0).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06042D9E RID: 273822 RVA: 0x0104645C File Offset: 0x0104465C
		private void RefreshTitle()
		{
			base.GetGridLayout(0).RootUIComp.Get().SetUIActive(false);
			AdamFormationRoleGroupTitleInfo titleInfo = this.Data.TitleInfo;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), titleInfo.TitleTextId, Array.Empty<object>());
			base.GetItem(4).SetUIActive(titleInfo.IsEmpty);
			base.GetItem(2).SetUIActive(true);
		}

		// Token: 0x06042D9F RID: 273823 RVA: 0x010464CC File Offset: 0x010446CC
		private void RefreshRoleList()
		{
			base.GetItem(2).SetUIActive(false);
			if (this.RoleLayout == null)
			{
				this.RoleLayout = new GenericLayout<WeeklyRogueRoleGridItem, RoleDataBase>(base.GetGridLayout(0), new Func<WeeklyRogueRoleGridItem>(this.OnCreateRole), null, false, true);
			}
			RoleDataBase[] newDataList = this.Data.DataList ?? Array.Empty<RoleDataBase>();
			Action callBack = delegate()
			{
				Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
				foreach (RoleDataBase roleDataBase in roleIndexMap.Values)
				{
					int num = Array.IndexOf<RoleDataBase>(this.RoleDataList, roleDataBase);
					int num2 = Array.IndexOf<RoleDataBase>(newDataList, roleDataBase);
					if (num != num2)
					{
						RoleSelectModel.Instance.SelectedRoleSet.Remove(roleDataBase.GetDataId());
						WeeklyRogueRoleGridItem layoutItemByKey = this.RoleLayout.GetLayoutItemByKey(roleDataBase.GetDataId());
						if (layoutItemByKey != null)
						{
							layoutItemByKey.OnDeselected(false);
						}
					}
				}
				foreach (RoleDataBase roleDataBase2 in roleIndexMap.Values)
				{
					RoleSelectModel.Instance.SelectedRoleSet.Add(roleDataBase2.GetDataId());
					WeeklyRogueRoleGridItem layoutItemByKey2 = this.RoleLayout.GetLayoutItemByKey(roleDataBase2.GetDataId());
					if (layoutItemByKey2 != null)
					{
						layoutItemByKey2.OnForceSelected(true);
					}
				}
				this.RoleDataList = newDataList;
			};
			bool flag = newDataList.Length != 0;
			this.RoleLayout.GetRootUiItem().SetUIActive(flag);
			if (flag)
			{
				this.RoleLayout.RefreshByData(new List<RoleDataBase>(newDataList), callBack, true);
			}
		}

		// Token: 0x06042DA0 RID: 273824 RVA: 0x0104657A File Offset: 0x0104477A
		private AdamFormationRoleGridItem OnCreateRole()
		{
			AdamFormationRoleGridItem adamFormationRoleGridItem = new AdamFormationRoleGridItem();
			adamFormationRoleGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
			adamFormationRoleGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
			adamFormationRoleGridItem.RecommendedRoleIdSet = this.RecommendedRoleIdSet;
			return adamFormationRoleGridItem;
		}

		// Token: 0x06042DA1 RID: 273825 RVA: 0x010465B4 File Offset: 0x010447B4
		protected void ToggleFunction(MediumItemGridExtendCallback param)
		{
			Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
			HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
			RoleDataBase roleDataBase = param.Data as RoleDataBase;
			if (roleDataBase == null)
			{
				return;
			}
			if (param.State == EToggleState.ETT_UnChecked)
			{
				using (Dictionary<int, RoleDataBase>.Enumerator enumerator = roleIndexMap.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<int, RoleDataBase> keyValuePair = enumerator.Current;
						if (keyValuePair.Value == roleDataBase)
						{
							roleIndexMap.Remove(keyValuePair.Key);
							selectedRoleSet.Remove(roleDataBase.GetDataId());
							break;
						}
					}
					goto IL_BB;
				}
			}
			if (param.State == EToggleState.ETT_Checked)
			{
				for (int i = 1; i <= 3; i++)
				{
					if (!roleIndexMap.ContainsKey(i))
					{
						roleIndexMap[i] = roleDataBase;
						selectedRoleSet.Add(roleDataBase.GetDataId());
						break;
					}
				}
			}
			IL_BB:
			GenericLayout<WeeklyRogueRoleGridItem, RoleDataBase> roleLayout = this.RoleLayout;
			if (roleLayout != null)
			{
				roleLayout.RefreshWithoutDataSync();
			}
			Action<RoleDataBase> refreshRole = this.RefreshRole;
			if (refreshRole == null)
			{
				return;
			}
			refreshRole(roleDataBase);
		}

		// Token: 0x06042DA2 RID: 273826 RVA: 0x010466B0 File Offset: 0x010448B0
		[NullableContext(2)]
		protected bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
		{
			if (state != EToggleState.ETT_UnChecked)
			{
				return true;
			}
			if (RoleSelectModel.Instance.RoleIndexMap.Count >= 3)
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleFull", Array.Empty<object>());
				return false;
			}
			RoleDataBase roleDataBase = data as RoleDataBase;
			if (roleDataBase == null)
			{
				return true;
			}
			int roleId = roleDataBase.GetRoleId();
			using (Dictionary<int, RoleDataBase>.ValueCollection.Enumerator enumerator = RoleSelectModel.Instance.RoleIndexMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetRoleId() == roleId)
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("Text_SameRole_Text", Array.Empty<object>());
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x04022C9C RID: 142492
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoleDataBase> RefreshRole;

		// Token: 0x04022C9D RID: 142493
		[Nullable(2)]
		public IReadOnlySet<int> RecommendedRoleIdSet;

		// Token: 0x04022C9E RID: 142494
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WeeklyRogueRoleGridItem, RoleDataBase> RoleLayout;

		// Token: 0x04022C9F RID: 142495
		private AdamFormationRoleGroupInfo Data;

		// Token: 0x04022CA0 RID: 142496
		private RoleDataBase[] RoleDataList = Array.Empty<RoleDataBase>();
	}
}
