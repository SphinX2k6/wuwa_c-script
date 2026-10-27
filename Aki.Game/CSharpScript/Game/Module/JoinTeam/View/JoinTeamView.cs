using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.JoinTeam.View
{
	// Token: 0x020057AC RID: 22444
	[NullableContext(1)]
	[Nullable(0)]
	public class JoinTeamView : UiViewBase
	{
		// Token: 0x06039062 RID: 233570 RVA: 0x00D8D9E6 File Offset: 0x00D8BBE6
		public JoinTeamView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039063 RID: 233571 RVA: 0x00D8D9F0 File Offset: 0x00D8BBF0
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

		// Token: 0x06039064 RID: 233572 RVA: 0x00D8DAF4 File Offset: 0x00D8BCF4
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

		// Token: 0x06039065 RID: 233573 RVA: 0x00D8DB5F File Offset: 0x00D8BD5F
		private void OnClickedCloseButton()
		{
			JoinTeamController.Instance.CloseJoinTeamView();
		}

		// Token: 0x06039066 RID: 233574 RVA: 0x00D8DB6C File Offset: 0x00D8BD6C
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

		// Token: 0x06039067 RID: 233575 RVA: 0x00D8DBE8 File Offset: 0x00D8BDE8
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
			if (this.MiniElement != null)
			{
				this.MiniElement.Destroy(null);
				this.MiniElement = null;
			}
		}

		// Token: 0x06039068 RID: 233576 RVA: 0x00D8DC0B File Offset: 0x00D8BE0B
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshJoinTeamRole, new Action(this.OnRefreshJoinTeamRole));
		}

		// Token: 0x06039069 RID: 233577 RVA: 0x00D8DC29 File Offset: 0x00D8BE29
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshJoinTeamRole, new Action(this.OnRefreshJoinTeamRole));
		}

		// Token: 0x0603906A RID: 233578 RVA: 0x00D8DC47 File Offset: 0x00D8BE47
		private void OnRefreshJoinTeamRole()
		{
			this.RefreshJoinTeamView();
		}

		// Token: 0x0603906B RID: 233579 RVA: 0x00D8DC50 File Offset: 0x00D8BE50
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

		// Token: 0x0603906C RID: 233580 RVA: 0x00D8DCE8 File Offset: 0x00D8BEE8
		private void InitializeMiniElement(int elementId)
		{
			AActor owner = base.GetItem(5).GetOwner();
			this.MiniElement = new MiniElementItem(elementId, null, owner);
		}

		// Token: 0x0603906D RID: 233581 RVA: 0x00D8DD10 File Offset: 0x00D8BF10
		private void SetRoleName(string roleNameId)
		{
			base.GetText(0).ShowTextNew(roleNameId);
		}

		// Token: 0x0603906E RID: 233582 RVA: 0x00D8DD20 File Offset: 0x00D8BF20
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

		// Token: 0x0603906F RID: 233583 RVA: 0x00D8DD50 File Offset: 0x00D8BF50
		private void SetRoleDescription(string descriptionId)
		{
			base.GetText(3).ShowTextNew(descriptionId);
		}

		// Token: 0x06039070 RID: 233584 RVA: 0x00D8DD5F File Offset: 0x00D8BF5F
		private void SetTrial()
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.IsTrial);
		}

		// Token: 0x0401DDF9 RID: 122361
		[Nullable(2)]
		private MiniElementItem MiniElement;

		// Token: 0x0401DDFA RID: 122362
		private bool IsTrial;

		// Token: 0x0200B9C1 RID: 47553
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038299 RID: 230041
			public const int RoleName = 0;

			// Token: 0x0403829A RID: 230042
			public const int RoleTexture = 1;

			// Token: 0x0403829B RID: 230043
			public const int RoleEffect = 2;

			// Token: 0x0403829C RID: 230044
			public const int RoleDescriptionText = 3;

			// Token: 0x0403829D RID: 230045
			public const int DetailButton = 4;

			// Token: 0x0403829E RID: 230046
			public const int MiniElementItem = 5;

			// Token: 0x0403829F RID: 230047
			public const int CloseButton = 6;

			// Token: 0x040382A0 RID: 230048
			public const int TrialPanel = 7;
		}
	}
}
