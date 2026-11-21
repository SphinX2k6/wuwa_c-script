using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050C4 RID: 20676
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeBattleTopPanel : UiPanelBase
	{
		// Token: 0x06033BE6 RID: 211942 RVA: 0x00E7B6E0 File Offset: 0x00E798E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnDetailClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBlessClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnBtnBackClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033BE7 RID: 211943 RVA: 0x00E7B874 File Offset: 0x00E79A74
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeBattleTopPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeBattleTopPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033BE8 RID: 211944 RVA: 0x00E7B8B8 File Offset: 0x00E79AB8
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnPanelSequenceClose), false);
			this.BlessingLayout = new GenericLayout<RoverlikeBlessingSlotItem, IRoverlikeBlessingSlotItemData>(base.GetHorizontalLayout(2), () => new RoverlikeBlessingSlotItem(), null, false, true);
			this.RefreshBlessingLayout();
		}

		// Token: 0x06033BE9 RID: 211945 RVA: 0x00E7B928 File Offset: 0x00E79B28
		public void SetCurrencyEnableClick(bool bEnable)
		{
			RoverlikeTopCurrencyItem currencyItem = this.CurrencyItem;
			if (currencyItem == null)
			{
				return;
			}
			currencyItem.SetBtnEnable(bEnable);
		}

		// Token: 0x06033BEA RID: 211946 RVA: 0x00E7B93B File Offset: 0x00E79B3B
		public void SetRefreshEnabled(bool bEnable)
		{
			this.RefreshEnabled = bEnable;
		}

		// Token: 0x06033BEB RID: 211947 RVA: 0x00E7B944 File Offset: 0x00E79B44
		public void StartShow()
		{
			this.RefreshBlessingLayout();
			RoverlikeTopCurrencyItem currencyItem = this.CurrencyItem;
			if (currencyItem != null)
			{
				currencyItem.BeginShow();
			}
			if (this.RefreshEnabled)
			{
				EventSystem.Instance.Add(EEventName.RoverlikeGainDataUpdate, new Action(this.OnGainDataUpdate));
			}
			EventSystem.Instance.Add(EEventName.ActivityDataInitComplete, new Action(this.OnActivityDataInitComplete));
		}

		// Token: 0x06033BEC RID: 211948 RVA: 0x00E7B9A8 File Offset: 0x00E79BA8
		public void EndShow()
		{
			RoverlikeTopCurrencyItem currencyItem = this.CurrencyItem;
			if (currencyItem != null)
			{
				currencyItem.BeginHide();
			}
			if (this.RefreshEnabled)
			{
				EventSystem.Instance.Remove(EEventName.RoverlikeGainDataUpdate, new Action(this.OnGainDataUpdate));
			}
			EventSystem.Instance.Remove(EEventName.ActivityDataInitComplete, new Action(this.OnActivityDataInitComplete));
		}

		// Token: 0x06033BED RID: 211949 RVA: 0x00E7BA08 File Offset: 0x00E79C08
		private void InitBlessingSlot()
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
			RoverRogueActivity? roverRogueActivity = (roverlikeActivityData != null) ? roverlikeActivityData.GetParamConfig() : null;
			this.BlessSlotIds = ((roverRogueActivity != null) ? new List<int>(roverRogueActivity.Value.SlotList()) : new List<int>());
		}

		// Token: 0x06033BEE RID: 211950 RVA: 0x00E7BA68 File Offset: 0x00E79C68
		private void RefreshBlessingLayout()
		{
			IBlessingDisplayDiff blessingDisplayDiff = this.ComputeDisplayDiff();
			bool flag = blessingDisplayDiff.ChangedSlots.Count > 0 || blessingDisplayDiff.Count > this.CachedPassiveCount;
			if (this.RefreshEnabled && this.AnimInitialized && flag)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null || !levelSequencePlayer.IsPlayingSequence("Trail"))
				{
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 == null)
					{
						return;
					}
					levelSequencePlayer2.PlayOrReplaySequenceByName("Trail", false, null);
				}
				return;
			}
			this.ApplyDisplay(false);
			this.AnimInitialized = true;
		}

		// Token: 0x06033BEF RID: 211951 RVA: 0x00E7BAF8 File Offset: 0x00E79CF8
		private void ApplyDisplay(bool playAnim)
		{
			IBlessingDisplayDiff blessingDisplayDiff = this.ComputeDisplayDiff();
			this.BlessingLayout.RefreshByData(blessingDisplayDiff.DataList, null, false);
			UUIText text = base.GetText(4);
			if (blessingDisplayDiff.Count > 0)
			{
				UUIText uuitext = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(blessingDisplayDiff.Count);
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				text.SetUIActive(true);
			}
			else
			{
				text.SetUIActive(false);
			}
			if (playAnim)
			{
				foreach (int num in blessingDisplayDiff.ChangedSlots)
				{
					GenericLayout<RoverlikeBlessingSlotItem, IRoverlikeBlessingSlotItemData> blessingLayout = this.BlessingLayout;
					if (blessingLayout != null)
					{
						RoverlikeBlessingSlotItem layoutItemByKey = blessingLayout.GetLayoutItemByKey(num);
						if (layoutItemByKey != null)
						{
							layoutItemByKey.PlaySelectAnim();
						}
					}
				}
				if (blessingDisplayDiff.Count > this.CachedPassiveCount)
				{
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.PlayOrReplaySequenceByName("Num", false, null);
					}
				}
			}
			foreach (IRoverlikeBlessingSlotItemData roverlikeBlessingSlotItemData in blessingDisplayDiff.DataList)
			{
				this.CachedSlotBlessMap[roverlikeBlessingSlotItemData.SlotId] = roverlikeBlessingSlotItemData.Id;
			}
			this.CachedPassiveCount = blessingDisplayDiff.Count;
		}

		// Token: 0x06033BF0 RID: 211952 RVA: 0x00E7BC6C File Offset: 0x00E79E6C
		private IBlessingDisplayDiff ComputeDisplayDiff()
		{
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			List<RoverlikeGainEntry> list = ((instanceData != null) ? instanceData.GetBlessList() : null) ?? new List<RoverlikeGainEntry>();
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (RoverlikeGainEntry roverlikeGainEntry in list)
			{
				RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(roverlikeGainEntry.ConfigId);
				if (blessConfig != null && this.BlessSlotIds.Contains(blessConfig.Value.SlotId))
				{
					dictionary[blessConfig.Value.SlotId] = roverlikeGainEntry.ConfigId;
				}
			}
			List<IRoverlikeBlessingSlotItemData> list2 = new List<IRoverlikeBlessingSlotItemData>();
			List<int> list3 = new List<int>();
			foreach (int num in this.BlessSlotIds)
			{
				int num3;
				int num2 = dictionary.TryGetValue(num, out num3) ? num3 : 0;
				int num5;
				int num4 = this.CachedSlotBlessMap.TryGetValue(num, out num5) ? num5 : 0;
				if (num2 != num4)
				{
					list3.Add(num);
				}
				RoverlikeBlessingSlotItemData item = new RoverlikeBlessingSlotItemData
				{
					Id = num2,
					SlotId = num
				};
				list2.Add(item);
			}
			return new BlessingDisplayDiff
			{
				DataList = list2,
				ChangedSlots = list3,
				Count = this.ComputePassiveCount()
			};
		}

		// Token: 0x06033BF1 RID: 211953 RVA: 0x00E7BDF0 File Offset: 0x00E79FF0
		private int ComputePassiveCount()
		{
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			int num = 0;
			foreach (RoverlikeGainEntry roverlikeGainEntry in (((instanceData != null) ? instanceData.GetBlessList() : null) ?? new List<RoverlikeGainEntry>()))
			{
				RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(roverlikeGainEntry.ConfigId);
				if (blessConfig != null && !this.BlessSlotIds.Contains(blessConfig.Value.SlotId))
				{
					num++;
				}
			}
			using (List<RoverlikeGainEntry>.Enumerator enumerator = (((instanceData != null) ? instanceData.GetItemList() : null) ?? new List<RoverlikeGainEntry>()).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.ItemRemainingRooms > 0)
					{
						num++;
					}
				}
			}
			num += ((instanceData != null) ? instanceData.GetRoleEnhanceList().Count : 0);
			return num;
		}

		// Token: 0x06033BF2 RID: 211954 RVA: 0x00E7BF00 File Offset: 0x00E7A100
		private void OnPanelSequenceClose(string sequenceName)
		{
			if (sequenceName != "Trail")
			{
				return;
			}
			this.ApplyDisplay(true);
			this.AnimInitialized = true;
		}

		// Token: 0x06033BF3 RID: 211955 RVA: 0x00E7BF1E File Offset: 0x00E7A11E
		private void OnActivityDataInitComplete()
		{
			RoverlikeTopCurrencyItem currencyItem = this.CurrencyItem;
			if (currencyItem != null)
			{
				currencyItem.InitCurrency();
			}
			this.InitBlessingSlot();
			this.RefreshBlessingLayout();
		}

		// Token: 0x06033BF4 RID: 211956 RVA: 0x00E7BF3D File Offset: 0x00E7A13D
		private void OnGainDataUpdate()
		{
			this.RefreshBlessingLayout();
		}

		// Token: 0x06033BF5 RID: 211957 RVA: 0x00E7BF48 File Offset: 0x00E7A148
		private void OnDetailClick()
		{
			RoverlikeController.Instance.OpenGameInfoView(null);
		}

		// Token: 0x06033BF6 RID: 211958 RVA: 0x00E7BF68 File Offset: 0x00E7A168
		private void OnBlessClick()
		{
			RoverlikeController.Instance.OpenGameInfoView(new EUiTabViewName?(EUiTabViewName.RoverlikeDetailBlessTabView));
		}

		// Token: 0x06033BF7 RID: 211959 RVA: 0x00E7BF7E File Offset: 0x00E7A17E
		private void OnBtnBackClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikePauseView, null, null);
		}

		// Token: 0x06033BF8 RID: 211960 RVA: 0x00E7BF94 File Offset: 0x00E7A194
		public void SetHighlightByBlessId(int blessId)
		{
			this.ClearHighlight();
			RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(blessId);
			if (blessConfig == null)
			{
				return;
			}
			GenericLayout<RoverlikeBlessingSlotItem, IRoverlikeBlessingSlotItemData> blessingLayout = this.BlessingLayout;
			if (blessingLayout == null)
			{
				return;
			}
			RoverlikeBlessingSlotItem layoutItemByKey = blessingLayout.GetLayoutItemByKey(blessConfig.Value.SlotId);
			if (layoutItemByKey == null)
			{
				return;
			}
			layoutItemByKey.SetSelectOn(true);
		}

		// Token: 0x06033BF9 RID: 211961 RVA: 0x00E7BFEC File Offset: 0x00E7A1EC
		public void ClearHighlight()
		{
			GenericLayout<RoverlikeBlessingSlotItem, IRoverlikeBlessingSlotItemData> blessingLayout = this.BlessingLayout;
			foreach (RoverlikeBlessingSlotItem roverlikeBlessingSlotItem in (((blessingLayout != null) ? blessingLayout.GetLayoutItemList() : null) ?? new List<RoverlikeBlessingSlotItem>()))
			{
				roverlikeBlessingSlotItem.SetSelectOn(false);
			}
		}

		// Token: 0x0401B6D6 RID: 112342
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeBlessingSlotItem, IRoverlikeBlessingSlotItemData> BlessingLayout;

		// Token: 0x0401B6D7 RID: 112343
		[Nullable(2)]
		protected RoverlikeTopCurrencyItem CurrencyItem;

		// Token: 0x0401B6D8 RID: 112344
		private List<int> BlessSlotIds = new List<int>();

		// Token: 0x0401B6D9 RID: 112345
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B6DA RID: 112346
		private bool RefreshEnabled;

		// Token: 0x0401B6DB RID: 112347
		private bool AnimInitialized;

		// Token: 0x0401B6DC RID: 112348
		private int CachedPassiveCount;

		// Token: 0x0401B6DD RID: 112349
		private readonly Dictionary<int, int> CachedSlotBlessMap = new Dictionary<int, int>();

		// Token: 0x0200AD88 RID: 44424
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040359EB RID: 219627
			public const int BtnCommon = 0;

			// Token: 0x040359EC RID: 219628
			public const int ButtonLayout = 1;

			// Token: 0x040359ED RID: 219629
			public const int BlessSlotLayout = 2;

			// Token: 0x040359EE RID: 219630
			public const int BlessingItem = 3;

			// Token: 0x040359EF RID: 219631
			public const int TxtPassiveBlessCount = 4;

			// Token: 0x040359F0 RID: 219632
			public const int ItemCurrency = 5;

			// Token: 0x040359F1 RID: 219633
			public const int BtnBack = 6;
		}
	}
}
