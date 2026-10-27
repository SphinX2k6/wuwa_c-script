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
	// Token: 0x02005733 RID: 22323
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoRoleGridItem : LoopScrollMediumItemGrid<int>
	{
		// Token: 0x06038BFD RID: 232445 RVA: 0x00D785D7 File Offset: 0x00D767D7
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
		}

		// Token: 0x06038BFE RID: 232446 RVA: 0x00D785E8 File Offset: 0x00D767E8
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

		// Token: 0x06038BFF RID: 232447 RVA: 0x00D7876E File Offset: 0x00D7696E
		public void SetToggleClickCallback(Action<int> callback)
		{
			this.ToggleClickCallback = callback;
		}

		// Token: 0x06038C00 RID: 232448 RVA: 0x00D78777 File Offset: 0x00D76977
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

		// Token: 0x06038C01 RID: 232449 RVA: 0x00D78793 File Offset: 0x00D76993
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

		// Token: 0x06038C02 RID: 232450 RVA: 0x00D787BA File Offset: 0x00D769BA
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, true);
			this.ReadRedDot();
		}

		// Token: 0x06038C03 RID: 232451 RVA: 0x00D787CA File Offset: 0x00D769CA
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}

		// Token: 0x06038C04 RID: 232452 RVA: 0x00D787D4 File Offset: 0x00D769D4
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

		// Token: 0x0401DC5A RID: 121946
		private int RoleId;

		// Token: 0x0401DC5B RID: 121947
		public List<int> LimitRoleList = new List<int>();

		// Token: 0x0401DC5C RID: 121948
		public List<int> RecommendRoleList = new List<int>();

		// Token: 0x0401DC5D RID: 121949
		public bool IsEndlessLevel;

		// Token: 0x0401DC5E RID: 121950
		public bool IsHandBookContext;

		// Token: 0x0401DC5F RID: 121951
		private bool IsDisableInternal;

		// Token: 0x0401DC60 RID: 121952
		[Nullable(2)]
		private Action<int> ToggleClickCallback;
	}
}
