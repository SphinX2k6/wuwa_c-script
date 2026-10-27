using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View.Item
{
	// Token: 0x02004D83 RID: 19843
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleLangCustomRoleItem : GridProxyAbstract<RoleInstance>
	{
		// Token: 0x060334C7 RID: 210119 RVA: 0x00BF9264 File Offset: 0x00BF7464
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

		// Token: 0x060334C8 RID: 210120 RVA: 0x00BF9372 File Offset: 0x00BF7572
		protected override void OnStart()
		{
			base.GetExtendToggle(4).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x060334C9 RID: 210121 RVA: 0x00BF9394 File Offset: 0x00BF7594
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

		// Token: 0x060334CA RID: 210122 RVA: 0x00BF95DC File Offset: 0x00BF77DC
		public void RefreshByData()
		{
			this.Refresh(this.RoleData, true, 0);
		}

		// Token: 0x060334CB RID: 210123 RVA: 0x00BF95EC File Offset: 0x00BF77EC
		public void SetSelected(bool isSelected, bool fireEvent = false)
		{
			base.GetExtendToggle(4).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x060334CC RID: 210124 RVA: 0x00BF9605 File Offset: 0x00BF7805
		private void OnToggleStateChanged(EToggleState state)
		{
			if (this.OnToggleStateChangedCallback != null)
			{
				this.OnToggleStateChangedCallback(this.RoleId);
			}
		}

		// Token: 0x0401B395 RID: 111509
		protected int RoleId;

		// Token: 0x0401B396 RID: 111510
		protected RoleInstance RoleData;

		// Token: 0x0401B397 RID: 111511
		[Nullable(2)]
		public Func<int, bool> OnToggleSelectedCheck;

		// Token: 0x0401B398 RID: 111512
		[Nullable(2)]
		public Action<int> OnToggleStateChangedCallback;

		// Token: 0x0200AEFB RID: 44795
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04035275 RID: 217717
			TexRole,
			// Token: 0x04035276 RID: 217718
			TexElementIcon,
			// Token: 0x04035277 RID: 217719
			TxtLanguage,
			// Token: 0x04035278 RID: 217720
			TxtCVName,
			// Token: 0x04035279 RID: 217721
			Toggle,
			// Token: 0x0403527A RID: 217722
			TexRoleShadow,
			// Token: 0x0403527B RID: 217723
			PanelInTeam
		}
	}
}
