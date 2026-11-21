using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.RoleUi;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.RoleSelect
{
	// Token: 0x0200470A RID: 18186
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoRoleGridItem : LoopScrollMediumItemGrid<int>
	{
		// Token: 0x0602DB0D RID: 187149 RVA: 0x00CC6C83 File Offset: 0x00CC4E83
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
		}

		// Token: 0x0602DB0E RID: 187150 RVA: 0x00CC6C94 File Offset: 0x00CC4E94
		protected override void OnRefresh(int data, bool isSelected, int gridIndex)
		{
			this.RoleId = data;
			KurotatoRoleData kurotatoRoleData = KurotatoActivityController.Instance.GetActivityData().GetKurotatoRoleData(data);
			int realRoleId = kurotatoRoleData.RealRoleId;
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(realRoleId);
			this.IsDisableInternal = (!kurotatoRoleData.IsUnLock || (this.LimitRoleList.Count > 0 && !this.LimitRoleList.Contains(data)));
			bool flag = this.IsHandBookContext ? kurotatoRoleData.HasHandBookRedDot : kurotatoRoleData.HasRoleSelectRedDot;
			bool flag2 = !this.IsDisableInternal && kurotatoRoleData.NeedPlayUnlockAnim;
			CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
			{
				Data = roleConfig,
				ItemConfigId = new int?(realRoleId),
				SkinId = kurotatoRoleData.RealRoleSkinId,
				BottomTextId = kurotatoRoleData.Name,
				IsShowLock = new bool?(!kurotatoRoleData.IsUnLock),
				IsDisable = new bool?(this.IsDisableInternal),
				IsRecommendVisible = new bool?(this.RecommendRoleList.Contains(realRoleId)),
				IsShowArchive = new bool?(this.IsEndlessLevel && kurotatoRoleData.HasArchived),
				IsNewVisible = new bool?(!this.IsDisableInternal && flag)
			};
			base.SetUseFixedAsync(true);
			base.Apply<CharacterMediumItemGrid>(parameters);
			if (flag2)
			{
				base.SetIsProhibit(new bool?(true));
				MediumItemGridProhibitComponent itemGridComponent = base.GetItemGridComponent<MediumItemGridProhibitComponent>(typeof(MediumItemGridProhibitComponent));
				if (itemGridComponent != null)
				{
					itemGridComponent.PlayUnlockAnim().Forget();
				}
				kurotatoRoleData.MarkUnlockAnimPlayed();
				return;
			}
			base.SetIsProhibit(new bool?(false));
		}

		// Token: 0x0602DB0F RID: 187151 RVA: 0x00CC6E1A File Offset: 0x00CC501A
		public void SetToggleClickCallback(Action<int> callback)
		{
			this.ToggleClickCallback = callback;
		}

		// Token: 0x0602DB10 RID: 187152 RVA: 0x00CC6E23 File Offset: 0x00CC5023
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<int> toggleClickCallback = this.ToggleClickCallback;
				if (toggleClickCallback == null)
				{
					return;
				}
				toggleClickCallback(this.RoleId);
			}
		}

		// Token: 0x0602DB11 RID: 187153 RVA: 0x00CC6E3F File Offset: 0x00CC503F
		protected override void OnExtendToggleClicked()
		{
			this.ReadRedDot();
			if (this.IsSelected)
			{
				return;
			}
			Action<int> toggleClickCallback = this.ToggleClickCallback;
			if (toggleClickCallback == null)
			{
				return;
			}
			toggleClickCallback(this.RoleId);
		}

		// Token: 0x0602DB12 RID: 187154 RVA: 0x00CC6E66 File Offset: 0x00CC5066
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, true);
			this.ReadRedDot();
		}

		// Token: 0x0602DB13 RID: 187155 RVA: 0x00CC6E76 File Offset: 0x00CC5076
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}

		// Token: 0x0602DB14 RID: 187156 RVA: 0x00CC6E80 File Offset: 0x00CC5080
		private void ReadRedDot()
		{
			if (this.IsDisableInternal)
			{
				return;
			}
			KurotatoRoleData kurotatoRoleData = KurotatoActivityController.Instance.GetActivityData().GetKurotatoRoleData(this.RoleId);
			if (this.IsHandBookContext && kurotatoRoleData.HasHandBookRedDot)
			{
				kurotatoRoleData.ReadHandBookRedDot(true);
				base.SetNewVisible(new bool?(false));
				return;
			}
			if (!this.IsHandBookContext && kurotatoRoleData.HasRoleSelectRedDot)
			{
				kurotatoRoleData.ReadRoleSelectRedDot();
				base.SetNewVisible(new bool?(false));
			}
		}

		// Token: 0x040186F0 RID: 100080
		private int RoleId;

		// Token: 0x040186F1 RID: 100081
		public List<int> LimitRoleList = new List<int>();

		// Token: 0x040186F2 RID: 100082
		public List<int> RecommendRoleList = new List<int>();

		// Token: 0x040186F3 RID: 100083
		public bool IsEndlessLevel;

		// Token: 0x040186F4 RID: 100084
		public bool IsHandBookContext;

		// Token: 0x040186F5 RID: 100085
		private bool IsDisableInternal;

		// Token: 0x040186F6 RID: 100086
		[Nullable(2)]
		private Action<int> ToggleClickCallback;
	}
}
