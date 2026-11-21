using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D97 RID: 15767
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeSwitchItem : UiPanelBase
	{
		// Token: 0x060284E5 RID: 165093 RVA: 0x00B49B6C File Offset: 0x00B47D6C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnSwitchLeftClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnSwitchRightClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060284E6 RID: 165094 RVA: 0x00B49C98 File Offset: 0x00B47E98
		protected override void OnStart()
		{
			this.PagePointLayout = new GenericLayout<RoguelikeBossChallengePagePointItem, bool>(base.GetHorizontalLayout(3), new Func<RoguelikeBossChallengePagePointItem>(this.CreatePagePointItem), null, false, true);
		}

		// Token: 0x060284E7 RID: 165095 RVA: 0x00B49CBB File Offset: 0x00B47EBB
		protected override void OnBeforeDestroy()
		{
			this.OnBossChangedCallback = null;
			this.PagePointLayout = null;
			this.BossIdList = new List<int>();
		}

		// Token: 0x060284E8 RID: 165096 RVA: 0x00B49CD6 File Offset: 0x00B47ED6
		public void SetOnBossChangedCallback(Action<ERoguelikeBossChallengeSwitchDirection> callback)
		{
			this.OnBossChangedCallback = callback;
		}

		// Token: 0x060284E9 RID: 165097 RVA: 0x00B49CDF File Offset: 0x00B47EDF
		public void RefreshBossList(List<int> idList)
		{
			this.BossIdList = idList;
			this.CurrentIndex = 0;
			this.RefreshSwitchButtonVisible();
			this.RefreshPagePointLayout();
			this.RefreshBossName();
		}

		// Token: 0x060284EA RID: 165098 RVA: 0x00B49D01 File Offset: 0x00B47F01
		public void SetSelectedIndex(int index)
		{
			if (index < 0 || index >= this.BossIdList.Count)
			{
				return;
			}
			this.CurrentIndex = index;
			this.RefreshSwitchButtonVisible();
			GenericLayout<RoguelikeBossChallengePagePointItem, bool> pagePointLayout = this.PagePointLayout;
			if (pagePointLayout != null)
			{
				pagePointLayout.SelectGridProxy(this.CurrentIndex, true);
			}
			this.RefreshBossName();
		}

		// Token: 0x060284EB RID: 165099 RVA: 0x00B49D41 File Offset: 0x00B47F41
		public int GetCurrentIndex()
		{
			return this.CurrentIndex;
		}

		// Token: 0x060284EC RID: 165100 RVA: 0x00B49D49 File Offset: 0x00B47F49
		public int GetCurrentBossId()
		{
			if (this.CurrentIndex >= 0 && this.CurrentIndex < this.BossIdList.Count)
			{
				return this.BossIdList[this.CurrentIndex];
			}
			return 0;
		}

		// Token: 0x060284ED RID: 165101 RVA: 0x00B49D7C File Offset: 0x00B47F7C
		private void RefreshSwitchButtonVisible()
		{
			bool uiactive = this.BossIdList.Count > 1;
			base.GetButton(0).RootUIComp.Get().SetUIActive(uiactive);
			base.GetButton(1).RootUIComp.Get().SetUIActive(uiactive);
		}

		// Token: 0x060284EE RID: 165102 RVA: 0x00B49DCC File Offset: 0x00B47FCC
		private void RefreshBossName()
		{
			if (this.CurrentIndex < 0 || this.CurrentIndex >= this.BossIdList.Count)
			{
				return;
			}
			int id = this.BossIdList[this.CurrentIndex];
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RogueTower? rogueTower = (instance != null) ? instance.GetRogueTowerConfig(id) : null;
			if (rogueTower == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueTower.Value.Name, Array.Empty<object>());
		}

		// Token: 0x060284EF RID: 165103 RVA: 0x00B49E54 File Offset: 0x00B48054
		private void RefreshPagePointLayout()
		{
			bool flag = this.BossIdList.Count > 1;
			base.GetHorizontalLayout(3).RootUIComp.Get().SetUIActive(flag);
			if (flag)
			{
				List<bool> list = new List<bool>();
				for (int i = 0; i < this.BossIdList.Count; i++)
				{
					list.Add(i == this.CurrentIndex);
				}
				GenericLayout<RoguelikeBossChallengePagePointItem, bool> pagePointLayout = this.PagePointLayout;
				if (pagePointLayout == null)
				{
					return;
				}
				pagePointLayout.RefreshByData(list, delegate
				{
					GenericLayout<RoguelikeBossChallengePagePointItem, bool> pagePointLayout2 = this.PagePointLayout;
					if (pagePointLayout2 == null)
					{
						return;
					}
					pagePointLayout2.SelectGridProxy(this.CurrentIndex, true);
				}, false);
			}
		}

		// Token: 0x060284F0 RID: 165104 RVA: 0x00B49ED6 File Offset: 0x00B480D6
		private RoguelikeBossChallengePagePointItem CreatePagePointItem()
		{
			return new RoguelikeBossChallengePagePointItem();
		}

		// Token: 0x060284F1 RID: 165105 RVA: 0x00B49EE0 File Offset: 0x00B480E0
		private void OnBtnSwitchLeftClick()
		{
			if (this.BossIdList.Count <= 1)
			{
				return;
			}
			this.CurrentIndex = (this.CurrentIndex - 1 + this.BossIdList.Count) % this.BossIdList.Count;
			GenericLayout<RoguelikeBossChallengePagePointItem, bool> pagePointLayout = this.PagePointLayout;
			if (pagePointLayout != null)
			{
				pagePointLayout.SelectGridProxy(this.CurrentIndex, true);
			}
			this.RefreshBossName();
			Action<ERoguelikeBossChallengeSwitchDirection> onBossChangedCallback = this.OnBossChangedCallback;
			if (onBossChangedCallback == null)
			{
				return;
			}
			onBossChangedCallback(ERoguelikeBossChallengeSwitchDirection.Left);
		}

		// Token: 0x060284F2 RID: 165106 RVA: 0x00B49F54 File Offset: 0x00B48154
		private void OnBtnSwitchRightClick()
		{
			if (this.BossIdList.Count <= 1)
			{
				return;
			}
			this.CurrentIndex = (this.CurrentIndex + 1) % this.BossIdList.Count;
			GenericLayout<RoguelikeBossChallengePagePointItem, bool> pagePointLayout = this.PagePointLayout;
			if (pagePointLayout != null)
			{
				pagePointLayout.SelectGridProxy(this.CurrentIndex, true);
			}
			this.RefreshBossName();
			Action<ERoguelikeBossChallengeSwitchDirection> onBossChangedCallback = this.OnBossChangedCallback;
			if (onBossChangedCallback == null)
			{
				return;
			}
			onBossChangedCallback(ERoguelikeBossChallengeSwitchDirection.Right);
		}

		// Token: 0x04015E87 RID: 89735
		[Nullable(2)]
		private Action<ERoguelikeBossChallengeSwitchDirection> OnBossChangedCallback;

		// Token: 0x04015E88 RID: 89736
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoguelikeBossChallengePagePointItem, bool> PagePointLayout;

		// Token: 0x04015E89 RID: 89737
		private List<int> BossIdList = new List<int>();

		// Token: 0x04015E8A RID: 89738
		private int CurrentIndex;

		// Token: 0x0200997A RID: 39290
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402FDB4 RID: 196020
			public const int BtnSwitchL = 0;

			// Token: 0x0402FDB5 RID: 196021
			public const int BtnSwitchR = 1;

			// Token: 0x0402FDB6 RID: 196022
			public const int TxtBossName = 2;

			// Token: 0x0402FDB7 RID: 196023
			public const int PnlPagePointLayout = 3;

			// Token: 0x0402FDB8 RID: 196024
			public const int UiItemPagePoint = 4;
		}
	}
}
