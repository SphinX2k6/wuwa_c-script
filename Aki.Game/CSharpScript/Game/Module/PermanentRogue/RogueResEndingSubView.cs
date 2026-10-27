using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005311 RID: 21265
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResEndingSubView : UiViewBase
	{
		// Token: 0x0603663F RID: 222783 RVA: 0x00CDE91A File Offset: 0x00CDCB1A
		public RogueResEndingSubView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036640 RID: 222784 RVA: 0x00CDE944 File Offset: 0x00CDCB44
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickPrev)),
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickNext))
			};
		}

		// Token: 0x06036641 RID: 222785 RVA: 0x00CDEA48 File Offset: 0x00CDCC48
		protected override UniTask OnBeforeStartAsync()
		{
			RogueResEndingSubView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueResEndingSubView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036642 RID: 222786 RVA: 0x00CDEA8C File Offset: 0x00CDCC8C
		protected override void OnStart()
		{
			this.CurEndingId = (int)this.OpenParam;
			RogueResEnd value = ConfigRogueResEndById.GetConfig(this.CurEndingId, true).Value;
			this.CurSeasonId = value.SeasonId;
			foreach (int num in ActivityPermanentRogueModel.Instance.GetEndingListBySeasonId(value.SeasonId))
			{
				if (ActivityPermanentRogueModel.Instance.GetEndingIsUnlock(num))
				{
					this.EndingIdList.Add(num);
				}
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06036643 RID: 222787 RVA: 0x00CDEB54 File Offset: 0x00CDCD54
		protected override void OnBeforeShow()
		{
			int num = this.EndingIdList.IndexOf(this.CurEndingId);
			for (int i = 0; i < this.EndingIdList.Count; i++)
			{
				int num2 = this.EndingIdList[i];
				if (ActivityPermanentRogueModel.Instance.GetEndingIsUnlock(num2) && !ActivityPermanentRogueModel.Instance.GetCacheEndingOpen(num2))
				{
					this.UnReachEnding[num2] = i;
				}
			}
			if (num == 0)
			{
				UUIButtonComponent button = base.GetButton(1);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(false);
				}
			}
			if (num == this.EndingIdList.Count - 1)
			{
				UUIButtonComponent button2 = base.GetButton(2);
				if (button2 != null)
				{
					button2.RootUIComp.Get().SetUIActive(false);
				}
			}
			this.RefreshEnding();
		}

		// Token: 0x06036644 RID: 222788 RVA: 0x00CDEC16 File Offset: 0x00CDCE16
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.EndingItem = null;
			this.SequencePlayer = null;
			this.EndingParamMap.Clear();
		}

		// Token: 0x06036645 RID: 222789 RVA: 0x00CDEC38 File Offset: 0x00CDCE38
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036646 RID: 222790 RVA: 0x00CDEC44 File Offset: 0x00CDCE44
		private void OnClickPrev()
		{
			int num = this.EndingIdList.IndexOf(this.CurEndingId);
			if (num == 0)
			{
				return;
			}
			if (num == 1)
			{
				UUIButtonComponent button = base.GetButton(1);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(false);
				}
				UUIButtonComponent button2 = base.GetButton(2);
				if (button2 != null)
				{
					button2.RootUIComp.Get().SetUIActive(true);
				}
			}
			else
			{
				UUIButtonComponent button3 = base.GetButton(1);
				if (button3 != null)
				{
					button3.RootUIComp.Get().SetUIActive(true);
				}
				UUIButtonComponent button4 = base.GetButton(2);
				if (button4 != null)
				{
					button4.RootUIComp.Get().SetUIActive(true);
				}
			}
			this.CurEndingId = this.EndingIdList[num - 1];
			this.RefreshEnding();
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsPlayingSequence("SwitchRight"))
			{
				LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.StopCurrentSequence(false, false);
				}
			}
			LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
			if (sequencePlayer3 != null && sequencePlayer3.IsPlayingSequence("SwitchLeft"))
			{
				LevelSequencePlayer sequencePlayer4 = this.SequencePlayer;
				if (sequencePlayer4 == null)
				{
					return;
				}
				sequencePlayer4.ReplaySequenceByKey("SwitchLeft");
				return;
			}
			else
			{
				LevelSequencePlayer sequencePlayer5 = this.SequencePlayer;
				if (sequencePlayer5 == null)
				{
					return;
				}
				sequencePlayer5.PlayLevelSequenceByName("SwitchLeft", false, null, false);
				return;
			}
		}

		// Token: 0x06036647 RID: 222791 RVA: 0x00CDED84 File Offset: 0x00CDCF84
		private void OnClickNext()
		{
			int num = this.EndingIdList.IndexOf(this.CurEndingId);
			if (num == this.EndingIdList.Count - 1)
			{
				return;
			}
			if (num == this.EndingIdList.Count - 2)
			{
				UUIButtonComponent button = base.GetButton(2);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(false);
				}
				UUIButtonComponent button2 = base.GetButton(1);
				if (button2 != null)
				{
					button2.RootUIComp.Get().SetUIActive(true);
				}
			}
			else
			{
				UUIButtonComponent button3 = base.GetButton(1);
				if (button3 != null)
				{
					button3.RootUIComp.Get().SetUIActive(true);
				}
				UUIButtonComponent button4 = base.GetButton(2);
				if (button4 != null)
				{
					button4.RootUIComp.Get().SetUIActive(true);
				}
			}
			this.CurEndingId = this.EndingIdList[num + 1];
			this.RefreshEnding();
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsPlayingSequence("SwitchLeft"))
			{
				LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.StopCurrentSequence(false, false);
				}
			}
			LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
			if (sequencePlayer3 != null && sequencePlayer3.IsPlayingSequence("SwitchRight"))
			{
				LevelSequencePlayer sequencePlayer4 = this.SequencePlayer;
				if (sequencePlayer4 == null)
				{
					return;
				}
				sequencePlayer4.ReplaySequenceByKey("SwitchRight");
				return;
			}
			else
			{
				LevelSequencePlayer sequencePlayer5 = this.SequencePlayer;
				if (sequencePlayer5 == null)
				{
					return;
				}
				sequencePlayer5.PlayLevelSequenceByName("SwitchRight", false, null, false);
				return;
			}
		}

		// Token: 0x06036648 RID: 222792 RVA: 0x00CDEEDC File Offset: 0x00CDD0DC
		public void RefreshEnding()
		{
			bool endingIsUnlock = ActivityPermanentRogueModel.Instance.GetEndingIsUnlock(this.CurEndingId);
			List<int> endingListBySeasonId = ActivityPermanentRogueModel.Instance.GetEndingListBySeasonId(this.CurSeasonId);
			if (!this.EndingParamMap.ContainsKey(this.CurEndingId))
			{
				RogueEndingItemParam value = new RogueEndingItemParam
				{
					ConfigId = this.CurEndingId,
					Index = endingListBySeasonId.IndexOf(this.CurEndingId) + 1,
					IsSubView = true,
					IsUnlock = endingIsUnlock
				};
				this.EndingParamMap[this.CurEndingId] = value;
			}
			RogueEndingCollectionItem endingItem = this.EndingItem;
			if (endingItem != null)
			{
				endingItem.Refresh(this.EndingParamMap[this.CurEndingId], false, 0);
			}
			RogueResEnd? config = ConfigRogueResEndById.GetConfig(this.CurEndingId, true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), config.Value.Desc, Array.Empty<object>());
			if (endingIsUnlock && !ActivityPermanentRogueModel.Instance.GetCacheEndingOpen(this.CurEndingId))
			{
				ActivityPermanentRogueModel.Instance.SetCacheEndingOpen(this.CurEndingId);
			}
			EventSystem.Instance.Emit<int>(EEventName.RogueResEndingSwitch, this.CurEndingId);
			this.RefreshRedDot();
		}

		// Token: 0x06036649 RID: 222793 RVA: 0x00CDEFFC File Offset: 0x00CDD1FC
		private void RefreshRedDot()
		{
			int curEndingId = this.CurEndingId;
			if (ActivityPermanentRogueModel.Instance.GetCacheEndingOpen(curEndingId) && this.UnReachEnding.ContainsKey(curEndingId))
			{
				this.UnReachEnding.Remove(curEndingId);
			}
			bool uiactive = false;
			bool uiactive2 = false;
			int num = this.EndingIdList.IndexOf(curEndingId);
			foreach (KeyValuePair<int, int> keyValuePair in this.UnReachEnding)
			{
				if (keyValuePair.Value < num)
				{
					uiactive = true;
				}
				else if (keyValuePair.Value > num)
				{
					uiactive2 = true;
				}
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(uiactive2);
		}

		// Token: 0x0401CBDA RID: 117722
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CBDB RID: 117723
		[Nullable(2)]
		private RogueEndingCollectionItem EndingItem;

		// Token: 0x0401CBDC RID: 117724
		private int CurEndingId;

		// Token: 0x0401CBDD RID: 117725
		private int CurSeasonId;

		// Token: 0x0401CBDE RID: 117726
		private readonly List<int> EndingIdList = new List<int>();

		// Token: 0x0401CBDF RID: 117727
		private readonly Dictionary<int, int> UnReachEnding = new Dictionary<int, int>();

		// Token: 0x0401CBE0 RID: 117728
		private readonly Dictionary<int, IRogueEndingItemParam> EndingParamMap = new Dictionary<int, IRogueEndingItemParam>();

		// Token: 0x0401CBE1 RID: 117729
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
