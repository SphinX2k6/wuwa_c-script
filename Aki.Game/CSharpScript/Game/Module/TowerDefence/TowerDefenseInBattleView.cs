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
	// Token: 0x02004B49 RID: 19273
	public class TowerDefenseInBattleView : BattleVisibleChildView
	{
		// Token: 0x06031E83 RID: 204419 RVA: 0x00B92D38 File Offset: 0x00B90F38
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

		// Token: 0x06031E84 RID: 204420 RVA: 0x00B92E62 File Offset: 0x00B91062
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.AddEventListeners();
		}

		// Token: 0x06031E85 RID: 204421 RVA: 0x00B92E80 File Offset: 0x00B91080
		public override void Reset()
		{
			base.Reset();
			this.RemoveEventListeners();
		}

		// Token: 0x06031E86 RID: 204422 RVA: 0x00B92E90 File Offset: 0x00B91090
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseInBattleView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseInBattleView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031E87 RID: 204423 RVA: 0x00B92ED4 File Offset: 0x00B910D4
		protected override void OnStart()
		{
			base.GetSprite(2).SetUIActive(true);
			base.GetSprite(5).SetUIActive(true);
			base.GetText(1).SetUIActive(false);
			this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
			this.SeqPlayer.StopCurrentSequence(false, true);
		}

		// Token: 0x06031E88 RID: 204424 RVA: 0x00B92F30 File Offset: 0x00B91130
		protected override void OnAfterDestroy()
		{
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.TowerDefense, false);
		}

		// Token: 0x06031E89 RID: 204425 RVA: 0x00B92F48 File Offset: 0x00B91148
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

		// Token: 0x06031E8A RID: 204426 RVA: 0x00B92F6E File Offset: 0x00B9116E
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

		// Token: 0x06031E8B RID: 204427 RVA: 0x00B92F90 File Offset: 0x00B91190
		private void AddEventListeners()
		{
			EventSystem.Instance.Add(EEventName.BattleUiToggleTowerDefenseInfoView, new Action(this.OnToggle));
			EventSystem.Instance.Add(EEventName.TowerDefenseOnPhantomInfoUpdateNotify, new Action(this.OnRefreshAll));
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.TryToggleOff));
			EventSystem.Instance.Add(EEventName.TowerDefenseDataInit, new Action(this.HandleTowerDefenseDataInit));
		}

		// Token: 0x06031E8C RID: 204428 RVA: 0x00B93010 File Offset: 0x00B91210
		private void RemoveEventListeners()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiToggleTowerDefenseInfoView, new Action(this.OnToggle));
			EventSystem.Instance.Remove(EEventName.TowerDefenseOnPhantomInfoUpdateNotify, new Action(this.OnRefreshAll));
			EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.TryToggleOff));
			EventSystem.Instance.Remove(EEventName.TowerDefenseDataInit, new Action(this.HandleTowerDefenseDataInit));
		}

		// Token: 0x06031E8D RID: 204429 RVA: 0x00B93090 File Offset: 0x00B91290
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

		// Token: 0x06031E8E RID: 204430 RVA: 0x00B930C8 File Offset: 0x00B912C8
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

		// Token: 0x06031E8F RID: 204431 RVA: 0x00B93100 File Offset: 0x00B91300
		[NullableContext(1)]
		private void TryToggleOff(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			}
		}

		// Token: 0x06031E90 RID: 204432 RVA: 0x00B9312C File Offset: 0x00B9132C
		private void HandleTowerDefenseDataInit()
		{
			if (base.GetVisible())
			{
				this.OnRefreshAll();
			}
		}

		// Token: 0x06031E91 RID: 204433 RVA: 0x00B9313C File Offset: 0x00B9133C
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

		// Token: 0x06031E92 RID: 204434 RVA: 0x00B9316C File Offset: 0x00B9136C
		private void OnRefreshLevel()
		{
			string levelContentInBattle = TowerDefenseController.Instance.GetLevelContentInBattle();
			base.GetText(1).SetText(levelContentInBattle, true);
			base.GetSprite(2).SetFillAmount(TowerDefenseController.Instance.GetProgressInBattle());
		}

		// Token: 0x06031E93 RID: 204435 RVA: 0x00B931A8 File Offset: 0x00B913A8
		private void RefreshLevelUp()
		{
			int levelInBattle = TowerDefenseController.Instance.GetLevelInBattle();
			if (levelInBattle != this.LastLevel)
			{
				this.LastLevel = levelInBattle;
				this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
		}

		// Token: 0x0401A9E4 RID: 109028
		[Nullable(2)]
		private TowerDefenseInBattlePanel ChildPanel;

		// Token: 0x0401A9E5 RID: 109029
		private int LastLevel = 1;

		// Token: 0x0401A9E6 RID: 109030
		[Nullable(1)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200ACC3 RID: 44227
		private class EViewComponent
		{
			// Token: 0x040347CA RID: 214986
			public const int Toggle = 0;

			// Token: 0x040347CB RID: 214987
			public const int LevelText = 1;

			// Token: 0x040347CC RID: 214988
			public const int ProgressSprite = 2;

			// Token: 0x040347CD RID: 214989
			public const int ParentItem = 3;

			// Token: 0x040347CE RID: 214990
			public const int LevelUpItem = 4;

			// Token: 0x040347CF RID: 214991
			public const int IconSprite = 5;
		}

		// Token: 0x0200ACC4 RID: 44228
		private class EVisibleReason
		{
			// Token: 0x040347D0 RID: 214992
			public const int Default = 1;
		}
	}
}
