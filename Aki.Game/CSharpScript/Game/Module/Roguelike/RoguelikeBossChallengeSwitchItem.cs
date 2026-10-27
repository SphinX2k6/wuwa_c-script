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
	// Token: 0x02004DCE RID: 19918
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeSwitchItem : UiPanelBase
	{
		// Token: 0x06033678 RID: 210552 RVA: 0x00C0062C File Offset: 0x00BFE82C
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

		// Token: 0x06033679 RID: 210553 RVA: 0x00C00758 File Offset: 0x00BFE958
		protected override void OnStart()
		{
			this.PagePointLayout = new GenericLayout<RoguelikeBossChallengePagePointItem, bool>(base.GetHorizontalLayout(3), new Func<RoguelikeBossChallengePagePointItem>(this.CreatePagePointItem), null, false, true);
		}

		// Token: 0x0603367A RID: 210554 RVA: 0x00C0077B File Offset: 0x00BFE97B
		protected override void OnBeforeDestroy()
		{
			this.OnBossChangedCallback = null;
			this.PagePointLayout = null;
			this.BossIdList = new List<int>();
		}

		// Token: 0x0603367B RID: 210555 RVA: 0x00C00796 File Offset: 0x00BFE996
		public void SetOnBossChangedCallback(Action<ERoguelikeBossChallengeSwitchDirection> callback)
		{
			this.OnBossChangedCallback = callback;
		}

		// Token: 0x0603367C RID: 210556 RVA: 0x00C0079F File Offset: 0x00BFE99F
		public void RefreshBossList(List<int> idList)
		{
			this.BossIdList = idList;
			this.CurrentIndex = 0;
			this.RefreshSwitchButtonVisible();
			this.RefreshPagePointLayout();
			this.RefreshBossName();
		}

		// Token: 0x0603367D RID: 210557 RVA: 0x00C007C1 File Offset: 0x00BFE9C1
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

		// Token: 0x0603367E RID: 210558 RVA: 0x00C00801 File Offset: 0x00BFEA01
		public int GetCurrentIndex()
		{
			return this.CurrentIndex;
		}

		// Token: 0x0603367F RID: 210559 RVA: 0x00C00809 File Offset: 0x00BFEA09
		public int GetCurrentBossId()
		{
			if (this.CurrentIndex >= 0 && this.CurrentIndex < this.BossIdList.Count)
			{
				return this.BossIdList[this.CurrentIndex];
			}
			return 0;
		}

		// Token: 0x06033680 RID: 210560 RVA: 0x00C0083C File Offset: 0x00BFEA3C
		private void RefreshSwitchButtonVisible()
		{
			bool uiactive = this.BossIdList.Count > 1;
			base.GetButton(0).RootUIComp.Get().SetUIActive(uiactive);
			base.GetButton(1).RootUIComp.Get().SetUIActive(uiactive);
		}

		// Token: 0x06033681 RID: 210561 RVA: 0x00C0088C File Offset: 0x00BFEA8C
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

		// Token: 0x06033682 RID: 210562 RVA: 0x00C00914 File Offset: 0x00BFEB14
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

		// Token: 0x06033683 RID: 210563 RVA: 0x00C00996 File Offset: 0x00BFEB96
		private RoguelikeBossChallengePagePointItem CreatePagePointItem()
		{
			return new RoguelikeBossChallengePagePointItem();
		}

		// Token: 0x06033684 RID: 210564 RVA: 0x00C009A0 File Offset: 0x00BFEBA0
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

		// Token: 0x06033685 RID: 210565 RVA: 0x00C00A14 File Offset: 0x00BFEC14
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

		// Token: 0x0401B4B4 RID: 111796
		[Nullable(2)]
		private Action<ERoguelikeBossChallengeSwitchDirection> OnBossChangedCallback;

		// Token: 0x0401B4B5 RID: 111797
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoguelikeBossChallengePagePointItem, bool> PagePointLayout;

		// Token: 0x0401B4B6 RID: 111798
		private List<int> BossIdList = new List<int>();

		// Token: 0x0401B4B7 RID: 111799
		private int CurrentIndex;

		// Token: 0x0200AF45 RID: 44869
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403537F RID: 217983
			public const int BtnSwitchL = 0;

			// Token: 0x04035380 RID: 217984
			public const int BtnSwitchR = 1;

			// Token: 0x04035381 RID: 217985
			public const int TxtBossName = 2;

			// Token: 0x04035382 RID: 217986
			public const int PnlPagePointLayout = 3;

			// Token: 0x04035383 RID: 217987
			public const int UiItemPagePoint = 4;
		}
	}
}
