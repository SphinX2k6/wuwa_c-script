using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View.Item
{
	// Token: 0x02003D4C RID: 15692
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleLangCustomRoleItem : GridProxyAbstract<RoleInstance>
	{
		// Token: 0x06028334 RID: 164660 RVA: 0x00B42860 File Offset: 0x00B40A60
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06028335 RID: 164661 RVA: 0x00B4296E File Offset: 0x00B40B6E
		protected override void OnStart()
		{
			base.GetExtendToggle(4).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x06028336 RID: 164662 RVA: 0x00B42990 File Offset: 0x00B40B90
		public override void Refresh(RoleInstance roleData, bool isSelected, int gridIndex)
		{
			int roleId = roleData.GetRoleId();
			this.RoleData = roleData;
			this.RoleId = roleId;
			int roleSkinId = roleData.GetRoleSkinId();
			List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(true);
			bool uiactive = false;
			using (List<SceneTeamItem>.Enumerator enumerator = teamItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetConfigId == roleId)
					{
						uiactive = true;
						break;
					}
				}
			}
			base.GetItem(6).SetUIActive(uiactive);
			base.SetRoleSkinIcon("", base.GetTexture(0), roleSkinId, null, null);
			base.SetRoleSkinIcon("", base.GetTexture(5), roleSkinId, null, null);
			int id = roleData.GetElementInfo().Value.Id;
			base.SetElementIcon("", base.GetTexture(1), id, null);
			FColor color = FColor.FromHex(ElementInfoConfig.Instance.GetElementInfo(id).Value.ElementColor);
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetColor(color);
			}
			int roleLangType = RoleLangCustomModel.Instance.GetRoleLangType(roleId);
			RoleVoiceLanguage? roleLangCustomConfigById = MenuBaseConfig.Instance.GetRoleLangCustomConfigById(roleLangType);
			base.GetText(2).ShowTextNew(roleLangCustomConfigById.Value.Text);
			FavorRoleInfo? favorRoleInfoConfig = RoleFavorConfig.Instance.GetFavorRoleInfoConfig(roleId);
			if (favorRoleInfoConfig == null)
			{
				return;
			}
			string item = "";
			if (roleLangType == 0)
			{
				item = PublicUtil.Instance.GetConfigTextByKey(favorRoleInfoConfig.Value.CVNameCn);
			}
			else if (roleLangType == 1)
			{
				item = PublicUtil.Instance.GetConfigTextByKey(favorRoleInfoConfig.Value.CVNameEn);
			}
			else if (roleLangType == 2)
			{
				item = PublicUtil.Instance.GetConfigTextByKey(favorRoleInfoConfig.Value.CVNameJp);
			}
			else if (roleLangType == 3)
			{
				item = PublicUtil.Instance.GetConfigTextByKey(favorRoleInfoConfig.Value.CVNameKo);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Role_VoiceDIY_CV", new <>z__ReadOnlySingleElementList<object>(item));
			if (this.OnToggleSelectedCheck != null)
			{
				this.SetSelected(this.OnToggleSelectedCheck(roleId), false);
			}
		}

		// Token: 0x06028337 RID: 164663 RVA: 0x00B42BD8 File Offset: 0x00B40DD8
		public void RefreshByData()
		{
			this.Refresh(this.RoleData, true, 0);
		}

		// Token: 0x06028338 RID: 164664 RVA: 0x00B42BE8 File Offset: 0x00B40DE8
		public void SetSelected(bool isSelected, bool fireEvent = false)
		{
			base.GetExtendToggle(4).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06028339 RID: 164665 RVA: 0x00B42C01 File Offset: 0x00B40E01
		private void OnToggleStateChanged(EToggleState state)
		{
			if (this.OnToggleStateChangedCallback != null)
			{
				this.OnToggleStateChangedCallback(this.RoleId);
			}
		}

		// Token: 0x04015D68 RID: 89448
		protected int RoleId;

		// Token: 0x04015D69 RID: 89449
		protected RoleInstance RoleData;

		// Token: 0x04015D6A RID: 89450
		[Nullable(2)]
		public Func<int, bool> OnToggleSelectedCheck;

		// Token: 0x04015D6B RID: 89451
		[Nullable(2)]
		public Action<int> OnToggleStateChangedCallback;

		// Token: 0x0200992F RID: 39215
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0402FCA9 RID: 195753
			TexRole,
			// Token: 0x0402FCAA RID: 195754
			TexElementIcon,
			// Token: 0x0402FCAB RID: 195755
			TxtLanguage,
			// Token: 0x0402FCAC RID: 195756
			TxtCVName,
			// Token: 0x0402FCAD RID: 195757
			Toggle,
			// Token: 0x0402FCAE RID: 195758
			TexRoleShadow,
			// Token: 0x0402FCAF RID: 195759
			PanelInTeam
		}
	}
}
