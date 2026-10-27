using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x0200621F RID: 25119
	[NullableContext(2)]
	[Nullable(0)]
	internal class RhythmShipChoseRoleItem : GridProxyAbstract<int>
	{
		// Token: 0x0603F5C3 RID: 259523 RVA: 0x00F5096C File Offset: 0x00F4EB6C
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

		// Token: 0x0603F5C4 RID: 259524 RVA: 0x00F50A6E File Offset: 0x00F4EC6E
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x0603F5C5 RID: 259525 RVA: 0x00F50A8C File Offset: 0x00F4EC8C
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x0603F5C6 RID: 259526 RVA: 0x00F50AAC File Offset: 0x00F4ECAC
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

		// Token: 0x0603F5C7 RID: 259527 RVA: 0x00F50C07 File Offset: 0x00F4EE07
		public void SetCurrentLevelSelectState(bool isSelected)
		{
			base.GetItem(7).SetUIActive(isSelected);
			base.GetExtendToggle(6).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x0603F5C8 RID: 259528 RVA: 0x00F50C30 File Offset: 0x00F4EE30
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

		// Token: 0x0603F5C9 RID: 259529 RVA: 0x00F50CED File Offset: 0x00F4EEED
		private void OnRhythmShipRedDotRefresh(List<int> planet, List<int> subLevel, List<int> role)
		{
			if (role == null || !role.Contains(this.RoleId))
			{
				return;
			}
			this.HaveRedDotItem = false;
			base.GetItem(9).SetUIActive(false);
		}

		// Token: 0x04021114 RID: 135444
		public int RoleId;

		// Token: 0x04021115 RID: 135445
		private bool IsUnLock;

		// Token: 0x04021116 RID: 135446
		private bool HaveRedDotItem;

		// Token: 0x04021117 RID: 135447
		public Action<int, UUIExtendToggle> OnClickToggleCallBack;
	}
}
