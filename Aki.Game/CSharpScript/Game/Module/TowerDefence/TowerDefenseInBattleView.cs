using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AF1 RID: 15089
	public class TowerDefenseInBattleView : BattleVisibleChildView
	{
		// Token: 0x06026C13 RID: 158739 RVA: 0x00AD6D9C File Offset: 0x00AD4F9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026C14 RID: 158740 RVA: 0x00AD6EC6 File Offset: 0x00AD50C6
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.AddEventListeners();
		}

		// Token: 0x06026C15 RID: 158741 RVA: 0x00AD6EE4 File Offset: 0x00AD50E4
		public override void Reset()
		{
			base.Reset();
			this.RemoveEventListeners();
		}

		// Token: 0x06026C16 RID: 158742 RVA: 0x00AD6EF4 File Offset: 0x00AD50F4
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseInBattleView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseInBattleView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026C17 RID: 158743 RVA: 0x00AD6F38 File Offset: 0x00AD5138
		protected override void OnStart()
		{
			base.GetSprite(2).SetUIActive(true);
			base.GetSprite(5).SetUIActive(true);
			base.GetText(1).SetUIActive(false);
			this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
			this.SeqPlayer.StopCurrentSequence(false, true);
		}

		// Token: 0x06026C18 RID: 158744 RVA: 0x00AD6F94 File Offset: 0x00AD5194
		protected override void OnAfterDestroy()
		{
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.TowerDefense, false);
		}

		// Token: 0x06026C19 RID: 158745 RVA: 0x00AD6FAC File Offset: 0x00AD51AC
		public void StartShow()
		{
			base.SetVisible(1, true);
			this.OnRefreshAll();
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.TowerDefense, true);
		}

		// Token: 0x06026C1A RID: 158746 RVA: 0x00AD6FD2 File Offset: 0x00AD51D2
		public void EndShow()
		{
			base.SetVisible(1, false);
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.TowerDefense, false);
		}

		// Token: 0x06026C1B RID: 158747 RVA: 0x00AD6FF4 File Offset: 0x00AD51F4
		private void AddEventListeners()
		{
			EventSystem.Instance.Add(EEventName.BattleUiToggleTowerDefenseInfoView, new Action(this.OnToggle));
			EventSystem.Instance.Add(EEventName.TowerDefenseOnPhantomInfoUpdateNotify, new Action(this.OnRefreshAll));
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.TryToggleOff));
			EventSystem.Instance.Add(EEventName.TowerDefenseDataInit, new Action(this.HandleTowerDefenseDataInit));
		}

		// Token: 0x06026C1C RID: 158748 RVA: 0x00AD7074 File Offset: 0x00AD5274
		private void RemoveEventListeners()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiToggleTowerDefenseInfoView, new Action(this.OnToggle));
			EventSystem.Instance.Remove(EEventName.TowerDefenseOnPhantomInfoUpdateNotify, new Action(this.OnRefreshAll));
			EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.TryToggleOff));
			EventSystem.Instance.Remove(EEventName.TowerDefenseDataInit, new Action(this.HandleTowerDefenseDataInit));
		}

		// Token: 0x06026C1D RID: 158749 RVA: 0x00AD70F4 File Offset: 0x00AD52F4
		private void OnClick(EToggleState toggleState)
		{
			bool flag = toggleState == EToggleState.ETT_Checked;
			TowerDefenseInBattlePanel childPanel = this.ChildPanel;
			if (childPanel != null)
			{
				childPanel.SetActive(flag);
			}
			if (flag)
			{
				TowerDefenseInBattlePanel childPanel2 = this.ChildPanel;
				if (childPanel2 == null)
				{
					return;
				}
				childPanel2.Refresh();
			}
		}

		// Token: 0x06026C1E RID: 158750 RVA: 0x00AD712C File Offset: 0x00AD532C
		private void OnToggle()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				if (extendToggle.GetToggleState() == EToggleState.ETT_Checked)
				{
					extendToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
			}
		}

		// Token: 0x06026C1F RID: 158751 RVA: 0x00AD7164 File Offset: 0x00AD5364
		[NullableContext(1)]
		private void TryToggleOff(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			}
		}

		// Token: 0x06026C20 RID: 158752 RVA: 0x00AD7190 File Offset: 0x00AD5390
		private void HandleTowerDefenseDataInit()
		{
			if (base.GetVisible())
			{
				this.OnRefreshAll();
			}
		}

		// Token: 0x06026C21 RID: 158753 RVA: 0x00AD71A0 File Offset: 0x00AD53A0
		private void OnRefreshAll()
		{
			if (TowerDefenseModel.Instance.PhantomMessageCache.Id != 0)
			{
				this.OnRefreshLevel();
				TowerDefenseInBattlePanel childPanel = this.ChildPanel;
				if (childPanel != null)
				{
					childPanel.Refresh();
				}
				this.RefreshLevelUp();
			}
		}

		// Token: 0x06026C22 RID: 158754 RVA: 0x00AD71D0 File Offset: 0x00AD53D0
		private void OnRefreshLevel()
		{
			string levelContentInBattle = TowerDefenseController.Instance.GetLevelContentInBattle();
			base.GetText(1).SetText(levelContentInBattle, true);
			base.GetSprite(2).SetFillAmount(TowerDefenseController.Instance.GetProgressInBattle());
		}

		// Token: 0x06026C23 RID: 158755 RVA: 0x00AD720C File Offset: 0x00AD540C
		private void RefreshLevelUp()
		{
			int levelInBattle = TowerDefenseController.Instance.GetLevelInBattle();
			if (levelInBattle != this.LastLevel)
			{
				this.LastLevel = levelInBattle;
				this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
		}

		// Token: 0x04015336 RID: 86838
		[Nullable(2)]
		private TowerDefenseInBattlePanel ChildPanel;

		// Token: 0x04015337 RID: 86839
		private int LastLevel = 1;

		// Token: 0x04015338 RID: 86840
		[Nullable(1)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x020096E3 RID: 38627
		private class EViewComponent
		{
			// Token: 0x0402F17B RID: 192891
			public const int Toggle = 0;

			// Token: 0x0402F17C RID: 192892
			public const int LevelText = 1;

			// Token: 0x0402F17D RID: 192893
			public const int ProgressSprite = 2;

			// Token: 0x0402F17E RID: 192894
			public const int ParentItem = 3;

			// Token: 0x0402F17F RID: 192895
			public const int LevelUpItem = 4;

			// Token: 0x0402F180 RID: 192896
			public const int IconSprite = 5;
		}

		// Token: 0x020096E4 RID: 38628
		private class EVisibleReason
		{
			// Token: 0x0402F181 RID: 192897
			public const int Default = 1;
		}
	}
}
