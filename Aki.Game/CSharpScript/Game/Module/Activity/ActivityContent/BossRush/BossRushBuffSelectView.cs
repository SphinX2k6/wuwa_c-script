using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x020068FB RID: 26875
	[NullableContext(1)]
	[Nullable(0)]
	public class BossRushBuffSelectView : UiTabViewBase
	{
		// Token: 0x06043068 RID: 274536 RVA: 0x01053838 File Offset: 0x01051A38
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06043069 RID: 274537 RVA: 0x01053920 File Offset: 0x01051B20
		protected override void OnStart()
		{
			this.LoopScrollView = new LoopScrollView<BuffGridItem, BuffGridItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<BuffGridItem>(this.CreateLoopItem), false);
			base.GetItem(1).SetUIActive(false);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			EventSystem.Instance.Emit(EEventName.OnBossRushBuffViewOpened);
		}

		// Token: 0x0604306A RID: 274538 RVA: 0x0105398B File Offset: 0x01051B8B
		private BuffGridItem CreateLoopItem()
		{
			return new BuffGridItem();
		}

		// Token: 0x0604306B RID: 274539 RVA: 0x01053994 File Offset: 0x01051B94
		private void OnClickConfirmButton()
		{
			List<BossRushBuffInfo> list = new List<BossRushBuffInfo>();
			int num = 1;
			foreach (BuffScrollItemData buffScrollItemData in this.CurrentSelectableBuffData)
			{
				if (buffScrollItemData.Selected)
				{
					BossRushBuffInfo bossRushBuffInfo = new BossRushBuffInfo();
					bossRushBuffInfo.BuffId = buffScrollItemData.BuffId;
					bossRushBuffInfo.ChangeAble = true;
					bossRushBuffInfo.State = buffScrollItemData.State;
					bossRushBuffInfo.Slot = num;
					num++;
					list.Add(bossRushBuffInfo);
				}
			}
			int currentSelectCount = this.GetCurrentSelectCount();
			if (currentSelectCount < this.CurrentTeamInfo.GetBuffMaxCount())
			{
				for (int i = currentSelectCount; i < this.CurrentTeamInfo.GetBuffMaxCount(); i++)
				{
					BossRushBuffInfo bossRushBuffInfo2 = (BossRushModel.Instance.CurrentSelectBuffTabName == EBuffTabName.Normal) ? this.CurrentTeamInfo.GetIndexPrepareSelectBuff(i) : this.CurrentTeamInfo.GetIndexPrepareSelectScoreBuff(i);
					BossRushBuffInfo bossRushBuffInfo3 = new BossRushBuffInfo();
					bossRushBuffInfo3.BuffId = 0;
					bossRushBuffInfo3.ChangeAble = bossRushBuffInfo2.ChangeAble;
					bossRushBuffInfo3.State = ((bossRushBuffInfo3.BuffId == 0 && bossRushBuffInfo2.State == BossRushBuffSelectionStatus.BuffSelected) ? BossRushBuffSelectionStatus.BuffEmpty : bossRushBuffInfo2.State);
					bossRushBuffInfo3.Slot = num;
					num++;
					list.Add(bossRushBuffInfo3);
				}
			}
			if (BossRushModel.Instance.CurrentSelectBuffTabName == EBuffTabName.Normal)
			{
				this.CurrentTeamInfo.SetPrepareSelectBuff(list.ToArray());
			}
			else if (BossRushModel.Instance.CurrentSelectBuffTabName == EBuffTabName.Powerful)
			{
				this.CurrentTeamInfo.SetPrepareSelectScoreBuff(list.ToArray());
			}
			EventSystem.Instance.Emit(EEventName.OnChangeBossRushBuff);
			EventSystem.Instance.Emit<EUiTabViewName>(EEventName.RequestChangeBossRushView, EUiTabViewName.BossRushLevelDetailView);
		}

		// Token: 0x0604306C RID: 274540 RVA: 0x01053B4C File Offset: 0x01051D4C
		protected override void OnBeforeShow()
		{
			this.TryShowAnimation();
			this.CurrentTeamInfo = BossRushModel.Instance.CurrentTeamInfo;
			this.CurrentSelectableBuffData = new List<BuffScrollItemData>();
			using (List<BossRushBuffInfo>.Enumerator enumerator = this.CurrentTeamInfo.GetOptionBuff().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					BossRushBuffInfo buffData = enumerator.Current;
					BuffScrollItemData buffScrollItemData = new BuffScrollItemData();
					buffScrollItemData.BuffId = buffData.BuffId;
					buffScrollItemData.State = buffData.State;
					buffScrollItemData.Selected = (((BossRushModel.Instance.CurrentSelectBuffTabName == EBuffTabName.Normal) ? this.CurrentTeamInfo.GetPrepareSelectBuff().FindIndex((BossRushBuffInfo value) => value.BuffId == buffData.BuffId) : this.CurrentTeamInfo.GetPrepareSelectScoreBuff().FindIndex((BossRushBuffInfo value) => value.BuffId == buffData.BuffId)) != -1);
					buffScrollItemData.SelectedAtStart = buffScrollItemData.Selected;
					buffScrollItemData.OnClickToggle = new Action<BuffScrollItemData>(this.OnClickToggle);
					buffScrollItemData.CheckClickAble = new Func<BuffScrollItemData, bool>(this.CheckClickAble);
					this.CurrentSelectableBuffData.Add(buffScrollItemData);
				}
			}
			this.RefreshScrollView(true);
			this.RefreshCountText();
			this.IsBuffMaxCountOne = (this.CurrentTeamInfo.LevelInfo.GetMaxBuffCount() == 1);
		}

		// Token: 0x0604306D RID: 274541 RVA: 0x01053CAC File Offset: 0x01051EAC
		private void TryShowAnimation()
		{
			string sequenceName = "Start";
			if (BossRushModel.Instance.PlayBackAnimation)
			{
				sequenceName = "ShowView";
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
			}
			BossRushModel.Instance.PlayBackAnimation = false;
		}

		// Token: 0x0604306E RID: 274542 RVA: 0x01053CFC File Offset: 0x01051EFC
		private void OnClickToggle(BuffScrollItemData data)
		{
			if (this.IsBuffMaxCountOne && !data.Selected)
			{
				foreach (BuffScrollItemData buffScrollItemData in this.CurrentSelectableBuffData)
				{
					buffScrollItemData.Selected = false;
				}
			}
			data.Selected = !data.Selected;
			this.RefreshScrollView(false);
			this.RefreshCountText();
		}

		// Token: 0x0604306F RID: 274543 RVA: 0x01053D7C File Offset: 0x01051F7C
		private bool CheckClickAble(BuffScrollItemData data)
		{
			if (this.FirstRefresh)
			{
				return true;
			}
			if (data.State != BossRushBuffSelectionStatus.BuffLocked)
			{
				if (data.Selected)
				{
					return true;
				}
				if (this.CheckIfStillCanSelectBuff())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06043070 RID: 274544 RVA: 0x01053DA8 File Offset: 0x01051FA8
		private bool CheckIfStillCanSelectBuff()
		{
			if (this.FirstRefresh)
			{
				return true;
			}
			if (this.IsBuffMaxCountOne || this.CurrentTeamInfo.LevelInfo.GetMaxBuffCount() > this.GetCurrentSelectCount())
			{
				return true;
			}
			ScrollingTipsController.Instance.ShowTipsById("BossRushMaxBuffText", Array.Empty<object>());
			return false;
		}

		// Token: 0x06043071 RID: 274545 RVA: 0x01053DF8 File Offset: 0x01051FF8
		private int GetCurrentSelectCount()
		{
			int num = 0;
			using (List<BuffScrollItemData>.Enumerator enumerator = this.CurrentSelectableBuffData.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Selected)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06043072 RID: 274546 RVA: 0x01053E54 File Offset: 0x01052054
		private void RefreshScrollView(bool needGridAnimation = false)
		{
			if (this.LoopScrollView != null)
			{
				List<BuffGridItemData> list = new List<BuffGridItemData>();
				this.FirstRefresh = true;
				int count = this.CurrentSelectableBuffData.Count;
				for (int i = 0; i < count; i++)
				{
					list.Add(new BuffGridItemData
					{
						BuffScrollItemData1 = this.CurrentSelectableBuffData[i]
					});
				}
				this.LoopScrollView.RefreshByData(list, false, delegate
				{
					this.FirstRefresh = false;
				}, needGridAnimation);
				base.GetLoopScrollViewComponent(0).RootUIComp.Get().SetUIActive(list.Count > 0);
			}
		}

		// Token: 0x06043073 RID: 274547 RVA: 0x01053EED File Offset: 0x010520ED
		protected override void OnBeforeHide()
		{
			LoopScrollView<BuffGridItem, BuffGridItemData> loopScrollView = this.LoopScrollView;
			if (loopScrollView == null)
			{
				return;
			}
			loopScrollView.ClearGridProxies();
		}

		// Token: 0x06043074 RID: 274548 RVA: 0x01053F00 File Offset: 0x01052100
		private void RefreshCountText()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "BossRushSelectBuffText", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.GetCurrentSelectCount().ToString(),
				this.CurrentTeamInfo.LevelInfo.GetMaxBuffCount().ToString()
			}));
		}

		// Token: 0x04022E3F RID: 142911
		[Nullable(2)]
		private BossRushTeamInfo CurrentTeamInfo;

		// Token: 0x04022E40 RID: 142912
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<BuffScrollItemData> CurrentSelectableBuffData;

		// Token: 0x04022E41 RID: 142913
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<BuffGridItem, BuffGridItemData> LoopScrollView;

		// Token: 0x04022E42 RID: 142914
		private bool FirstRefresh = true;

		// Token: 0x04022E43 RID: 142915
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04022E44 RID: 142916
		private bool IsBuffMaxCountOne;

		// Token: 0x0200CAAF RID: 51887
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403D420 RID: 250912
			public const int LoopScrollView = 0;

			// Token: 0x0403D421 RID: 250913
			public const int ContentItem = 1;

			// Token: 0x0403D422 RID: 250914
			public const int SelectCountText = 2;

			// Token: 0x0403D423 RID: 250915
			public const int ConfirmButton = 3;
		}
	}
}
