using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006226 RID: 25126
	internal class DifficultyItem : UiPanelBase
	{
		// Token: 0x0603F5E1 RID: 259553 RVA: 0x00F518E8 File Offset: 0x00F4FAE8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x0603F5E2 RID: 259554 RVA: 0x00F5197B File Offset: 0x00F4FB7B
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClickToggle));
		}

		// Token: 0x0603F5E3 RID: 259555 RVA: 0x00F519B6 File Offset: 0x00F4FBB6
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x0603F5E4 RID: 259556 RVA: 0x00F519D4 File Offset: 0x00F4FBD4
		public void RefreshPanel(int subLevelId)
		{
			if (subLevelId <= 0)
			{
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			this.SubLevelId = subLevelId;
			Dictionary<int, RhythmSubLevelPb> subLevelInfoMapBySubLevelId = RhythmShipModel.Instance.GetSubLevelInfoMapBySubLevelId(subLevelId);
			RhythmSubLevelPb rhythmSubLevelPb = null;
			if (subLevelInfoMapBySubLevelId != null)
			{
				subLevelInfoMapBySubLevelId.TryGetValue(subLevelId, out rhythmSubLevelPb);
			}
			bool uiactive = rhythmSubLevelPb != null && rhythmSubLevelPb.Cleared;
			base.GetItem(3).SetUIActive(uiactive);
			this.IsUnLock = RhythmShipModel.Instance.GetSubLevelIsUnlock(subLevelId);
			base.GetItem(2).SetUIActive(!this.IsUnLock);
			this.HaveRedDotItem = RhythmShipModel.Instance.GetSubLevelRedDotActive(subLevelId);
			base.GetItem(1).SetUIActive(this.HaveRedDotItem);
			base.GetExtendToggle(0).SetToggleStateForce(this.IsUnLock ? EToggleState.ETT_UnChecked : EToggleState.ETT_UnDetermined, false, false, false);
		}

		// Token: 0x0603F5E5 RID: 259557 RVA: 0x00F51A98 File Offset: 0x00F4FC98
		private void OnClickToggle(EToggleState state)
		{
			if (!this.IsUnLock)
			{
				RhythmSubLevel? rhythmShipSubLevelById = RhythmShipConfig.Instance.GetRhythmShipSubLevelById(this.SubLevelId);
				ScrollingTipsController.Instance.ShowTipsByTextId(((rhythmShipSubLevelById != null) ? rhythmShipSubLevelById.GetValueOrDefault().LockTips : null) ?? "RhythmShipLevelLockTips", Array.Empty<object>());
			}
			Action<int, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.SubLevelId, base.GetExtendToggle(0));
		}

		// Token: 0x0603F5E6 RID: 259558 RVA: 0x00F51B10 File Offset: 0x00F4FD10
		private void OnUndeterminedClickToggle()
		{
			RhythmSubLevel? rhythmShipSubLevelById = RhythmShipConfig.Instance.GetRhythmShipSubLevelById(this.SubLevelId);
			ScrollingTipsController.Instance.ShowTipsByTextId(((rhythmShipSubLevelById != null) ? rhythmShipSubLevelById.GetValueOrDefault().LockTips : null) ?? "RhythmShipLevelLockTips", Array.Empty<object>());
		}

		// Token: 0x0603F5E7 RID: 259559 RVA: 0x00F51B61 File Offset: 0x00F4FD61
		public void SelectToggle()
		{
			if (!this.IsUnLock)
			{
				return;
			}
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x0603F5E8 RID: 259560 RVA: 0x00F51B7C File Offset: 0x00F4FD7C
		[NullableContext(2)]
		private void OnRhythmShipRedDotRefresh(List<int> planet, List<int> subLevel, List<int> role)
		{
			if (subLevel == null || !subLevel.Contains(this.SubLevelId))
			{
				return;
			}
			this.HaveRedDotItem = false;
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x0402113E RID: 135486
		public int SubLevelId;

		// Token: 0x0402113F RID: 135487
		public bool IsUnLock;

		// Token: 0x04021140 RID: 135488
		public bool HaveRedDotItem;

		// Token: 0x04021141 RID: 135489
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle> OnClickToggleCallBack;
	}
}
