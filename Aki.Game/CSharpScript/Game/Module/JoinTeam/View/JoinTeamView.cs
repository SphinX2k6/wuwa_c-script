using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.JoinTeam.View
{
	// Token: 0x02004783 RID: 18307
	[NullableContext(1)]
	[Nullable(0)]
	public class JoinTeamView : UiViewBase
	{
		// Token: 0x0602DF72 RID: 188274 RVA: 0x00CDC7A2 File Offset: 0x00CDA9A2
		public JoinTeamView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602DF73 RID: 188275 RVA: 0x00CDC7AC File Offset: 0x00CDA9AC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUINiagara)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickedDetailButton)),
				new ValueTuple<int, Delegate>(6, new Action(this.OnClickedCloseButton))
			};
		}

		// Token: 0x0602DF74 RID: 188276 RVA: 0x00CDC8B0 File Offset: 0x00CDAAB0
		private void OnClickedDetailButton()
		{
			RoleModel instance = RoleModel.Instance;
			int value = JoinTeamModel.Instance.GetRoleDescriptionId().Value;
			int value2 = JoinTeamConfig.Instance.GetRoleConfigId(value).Value;
			RoleDataBase roleDataById = instance.GetRoleDataById(value2, true);
			JoinTeamController.Instance.CloseJoinTeamView();
			if (roleDataById != null)
			{
				RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, roleDataById.GetRoleId(), null, null, null);
			}
		}

		// Token: 0x0602DF75 RID: 188277 RVA: 0x00CDC91B File Offset: 0x00CDAB1B
		private void OnClickedCloseButton()
		{
			JoinTeamController.Instance.CloseJoinTeamView();
		}

		// Token: 0x0602DF76 RID: 188278 RVA: 0x00CDC928 File Offset: 0x00CDAB28
		protected override void OnStart()
		{
			object openParam = this.OpenParam;
			bool flag;
			bool flag2;
			if (openParam is bool)
			{
				flag = (bool)openParam;
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
			this.IsTrial = (flag2 && flag);
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(!this.IsTrial);
				}
			}
			this.RefreshJoinTeamView();
			this.AddEvents();
		}

		// Token: 0x0602DF77 RID: 188279 RVA: 0x00CDC9A4 File Offset: 0x00CDABA4
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
			if (this.MiniElement != null)
			{
				this.MiniElement.Destroy(null);
				this.MiniElement = null;
			}
		}

		// Token: 0x0602DF78 RID: 188280 RVA: 0x00CDC9C7 File Offset: 0x00CDABC7
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshJoinTeamRole, new Action(this.OnRefreshJoinTeamRole));
		}

		// Token: 0x0602DF79 RID: 188281 RVA: 0x00CDC9E5 File Offset: 0x00CDABE5
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshJoinTeamRole, new Action(this.OnRefreshJoinTeamRole));
		}

		// Token: 0x0602DF7A RID: 188282 RVA: 0x00CDCA03 File Offset: 0x00CDAC03
		private void OnRefreshJoinTeamRole()
		{
			this.RefreshJoinTeamView();
		}

		// Token: 0x0602DF7B RID: 188283 RVA: 0x00CDCA0C File Offset: 0x00CDAC0C
		private void RefreshJoinTeamView()
		{
			int? roleDescriptionId = JoinTeamModel.Instance.GetRoleDescriptionId();
			if (roleDescriptionId == null)
			{
				return;
			}
			JoinTeamConfig instance = JoinTeamConfig.Instance;
			string roleNameId = instance.GetRoleNameId(roleDescriptionId.Value);
			string roleTexturePath = instance.GetRoleTexturePath(roleDescriptionId.Value);
			int value = instance.GetRoleElementId(roleDescriptionId.Value).Value;
			string roleDescriptionId2 = instance.GetRoleDescriptionId(roleDescriptionId.Value);
			this.InitializeMiniElement(value);
			this.SetRoleTexture(roleTexturePath);
			this.SetRoleName(roleNameId);
			this.SetRoleDescription(roleDescriptionId2);
			base.GetUiNiagara(2).ActivateSystem(true);
			this.SetTrial();
		}

		// Token: 0x0602DF7C RID: 188284 RVA: 0x00CDCAA4 File Offset: 0x00CDACA4
		private void InitializeMiniElement(int elementId)
		{
			AActor owner = base.GetItem(5).GetOwner();
			this.MiniElement = new MiniElementItem(elementId, null, owner);
		}

		// Token: 0x0602DF7D RID: 188285 RVA: 0x00CDCACC File Offset: 0x00CDACCC
		private void SetRoleName(string roleNameId)
		{
			base.GetText(0).ShowTextNew(roleNameId);
		}

		// Token: 0x0602DF7E RID: 188286 RVA: 0x00CDCADC File Offset: 0x00CDACDC
		private void SetRoleTexture(string roleTexturePath)
		{
			base.SetTextureByPath(roleTexturePath, base.GetTexture(1), null, delegate(bool success)
			{
				if (success)
				{
					UUITexture texture = base.GetTexture(1);
					if (texture == null)
					{
						return;
					}
					texture.SetUIActive(true);
				}
			});
		}

		// Token: 0x0602DF7F RID: 188287 RVA: 0x00CDCB0C File Offset: 0x00CDAD0C
		private void SetRoleDescription(string descriptionId)
		{
			base.GetText(3).ShowTextNew(descriptionId);
		}

		// Token: 0x0602DF80 RID: 188288 RVA: 0x00CDCB1B File Offset: 0x00CDAD1B
		private void SetTrial()
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.IsTrial);
		}

		// Token: 0x0401888F RID: 100495
		[Nullable(2)]
		private MiniElementItem MiniElement;

		// Token: 0x04018890 RID: 100496
		private bool IsTrial;

		// Token: 0x0200A3D7 RID: 41943
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032C89 RID: 208009
			public const int RoleName = 0;

			// Token: 0x04032C8A RID: 208010
			public const int RoleTexture = 1;

			// Token: 0x04032C8B RID: 208011
			public const int RoleEffect = 2;

			// Token: 0x04032C8C RID: 208012
			public const int RoleDescriptionText = 3;

			// Token: 0x04032C8D RID: 208013
			public const int DetailButton = 4;

			// Token: 0x04032C8E RID: 208014
			public const int MiniElementItem = 5;

			// Token: 0x04032C8F RID: 208015
			public const int CloseButton = 6;

			// Token: 0x04032C90 RID: 208016
			public const int TrialPanel = 7;
		}
	}
}
