using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x0200519D RID: 20893
	[NullableContext(2)]
	[Nullable(0)]
	internal class RhythmShipChoseRoleItem : GridProxyAbstract<int>
	{
		// Token: 0x06034284 RID: 213636 RVA: 0x00E978C4 File Offset: 0x00E95AC4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x06034285 RID: 213637 RVA: 0x00E979C6 File Offset: 0x00E95BC6
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x06034286 RID: 213638 RVA: 0x00E979E4 File Offset: 0x00E95BE4
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x06034287 RID: 213639 RVA: 0x00E97A04 File Offset: 0x00E95C04
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			this.RoleId = data;
			RhythmRole? rhythmRoleById = RhythmShipConfig.Instance.GetRhythmRoleById(this.RoleId);
			if (rhythmRoleById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rhythmRoleById.Value.RoleNameText, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), rhythmRoleById.Value.RoleDesText, Array.Empty<object>());
			base.SetTextureByPath(rhythmRoleById.Value.RoleHeadTexture, base.GetTexture(0), null, null);
			if (!string.IsNullOrEmpty(rhythmRoleById.Value.SkillIcon))
			{
				base.GetItem(1).SetUIActive(true);
				base.SetTextureByPath(rhythmRoleById.Value.SkillIcon, base.GetTexture(2), null, null);
			}
			else
			{
				base.GetItem(1).SetUIActive(false);
			}
			this.IsUnLock = activityData.RoleUnlockList.Contains(this.RoleId);
			base.GetItem(5).SetUIActive(!this.IsUnLock);
			this.HaveRedDotItem = RhythmShipModel.Instance.GetRoleRedDotActive(this.RoleId);
			base.GetItem(9).SetUIActive(this.HaveRedDotItem);
		}

		// Token: 0x06034288 RID: 213640 RVA: 0x00E97B5F File Offset: 0x00E95D5F
		public void SetCurrentLevelSelectState(bool isSelected)
		{
			base.GetItem(7).SetUIActive(isSelected);
			base.GetExtendToggle(6).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x06034289 RID: 213641 RVA: 0x00E97B88 File Offset: 0x00E95D88
		private void OnClickToggle(EToggleState state)
		{
			if (this.IsUnLock)
			{
				Action<int, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
				if (onClickToggleCallBack != null)
				{
					onClickToggleCallBack(this.RoleId, base.GetExtendToggle(6));
				}
				if (this.IsUnLock && this.HaveRedDotItem)
				{
					RhythmShipController.Instance.RhythmSetRedDotRequest(null, null, new List<int>
					{
						this.RoleId
					});
				}
				return;
			}
			RhythmRole? rhythmRoleById = RhythmShipConfig.Instance.GetRhythmRoleById(this.RoleId);
			ScrollingTipsController.Instance.ShowTipsByTextId(((rhythmRoleById != null) ? rhythmRoleById.GetValueOrDefault().LockTips : null) ?? "RhythmShipRoleLockTips", Array.Empty<object>());
			Action<int, UUIExtendToggle> onClickToggleCallBack2 = this.OnClickToggleCallBack;
			if (onClickToggleCallBack2 == null)
			{
				return;
			}
			onClickToggleCallBack2(0, base.GetExtendToggle(6));
		}

		// Token: 0x0603428A RID: 213642 RVA: 0x00E97C45 File Offset: 0x00E95E45
		private void OnRhythmShipRedDotRefresh(List<int> planet, List<int> subLevel, List<int> role)
		{
			if (role == null || !role.Contains(this.RoleId))
			{
				return;
			}
			this.HaveRedDotItem = false;
			base.GetItem(9).SetUIActive(false);
		}

		// Token: 0x0401BA43 RID: 113219
		public int RoleId;

		// Token: 0x0401BA44 RID: 113220
		private bool IsUnLock;

		// Token: 0x0401BA45 RID: 113221
		private bool HaveRedDotItem;

		// Token: 0x0401BA46 RID: 113222
		public Action<int, UUIExtendToggle> OnClickToggleCallBack;
	}
}
