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
	// Token: 0x020051A4 RID: 20900
	internal class DifficultyItem : UiPanelBase
	{
		// Token: 0x060342A2 RID: 213666 RVA: 0x00E98840 File Offset: 0x00E96A40
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

		// Token: 0x060342A3 RID: 213667 RVA: 0x00E988D3 File Offset: 0x00E96AD3
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClickToggle));
		}

		// Token: 0x060342A4 RID: 213668 RVA: 0x00E9890E File Offset: 0x00E96B0E
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x060342A5 RID: 213669 RVA: 0x00E9892C File Offset: 0x00E96B2C
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

		// Token: 0x060342A6 RID: 213670 RVA: 0x00E989F0 File Offset: 0x00E96BF0
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

		// Token: 0x060342A7 RID: 213671 RVA: 0x00E98A68 File Offset: 0x00E96C68
		private void OnUndeterminedClickToggle()
		{
			RhythmSubLevel? rhythmShipSubLevelById = RhythmShipConfig.Instance.GetRhythmShipSubLevelById(this.SubLevelId);
			ScrollingTipsController.Instance.ShowTipsByTextId(((rhythmShipSubLevelById != null) ? rhythmShipSubLevelById.GetValueOrDefault().LockTips : null) ?? "RhythmShipLevelLockTips", Array.Empty<object>());
		}

		// Token: 0x060342A8 RID: 213672 RVA: 0x00E98AB9 File Offset: 0x00E96CB9
		public void SelectToggle()
		{
			if (!this.IsUnLock)
			{
				return;
			}
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x060342A9 RID: 213673 RVA: 0x00E98AD4 File Offset: 0x00E96CD4
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

		// Token: 0x0401BA6D RID: 113261
		public int SubLevelId;

		// Token: 0x0401BA6E RID: 113262
		public bool IsUnLock;

		// Token: 0x0401BA6F RID: 113263
		public bool HaveRedDotItem;

		// Token: 0x0401BA70 RID: 113264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle> OnClickToggleCallBack;
	}
}
