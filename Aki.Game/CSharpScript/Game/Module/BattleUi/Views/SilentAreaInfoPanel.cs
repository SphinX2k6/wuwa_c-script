using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DA5 RID: 19877
	[NullableContext(2)]
	[Nullable(0)]
	public class SilentAreaInfoPanel : BattleChildView
	{
		// Token: 0x06031F46 RID: 204614 RVA: 0x00DFAB80 File Offset: 0x00DF8D80
		protected override UniTask InitializeAsync(object param = null)
		{
			SilentAreaInfoPanel.<InitializeAsync>d__6 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<SilentAreaInfoPanel.<InitializeAsync>d__6>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F47 RID: 204615 RVA: 0x00DFABC4 File Offset: 0x00DF8DC4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031F48 RID: 204616 RVA: 0x00DFAC30 File Offset: 0x00DF8E30
		protected override void OnStart()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAnchorOffsetX(0f);
			}
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 != null)
			{
				rootItem2.SetAnchorOffsetY(0f);
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
			{
				if (sequenceName == "Close")
				{
					this.SetActive(false);
				}
			}, false);
		}

		// Token: 0x06031F49 RID: 204617 RVA: 0x00DFAC94 File Offset: 0x00DF8E94
		[NullableContext(1)]
		public void CreateAndShow(string resourceId, UUIItem parent, [Nullable(2)] SilentAreaShowInfo silentAreaInfo)
		{
			if (this.Created)
			{
				this.UpdateInfo(silentAreaInfo);
				this.SetActive(true);
				this.StartCountdown();
				return;
			}
			base.NewByResourceId(parent, resourceId, false, null).ContinueWith(delegate()
			{
				this.Created = true;
				this.UpdateInfo(silentAreaInfo);
				this.StartCountdown();
			}).Forget();
		}

		// Token: 0x06031F4A RID: 204618 RVA: 0x00DFACF8 File Offset: 0x00DF8EF8
		protected override void OnShowBattleChildView()
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x06031F4B RID: 204619 RVA: 0x00DFAD2F File Offset: 0x00DF8F2F
		public void UpdateInfo(SilentAreaShowInfo silentAreaInfo)
		{
			this.SilentAreaInfo = silentAreaInfo;
			if (!this.Created)
			{
				return;
			}
			this.UpdateItems();
		}

		// Token: 0x06031F4C RID: 204620 RVA: 0x00DFAD48 File Offset: 0x00DF8F48
		[NullableContext(1)]
		private unsafe List<ILevelPlayInformation> GetInfoInformationConfig()
		{
			if (this.SilentAreaInfo == null)
			{
				return new List<ILevelPlayInformation>();
			}
			if (this.SilentAreaInfo.ShowInfo.Type == EInformationViewType.LevelPlay)
			{
				return ((ILevelPlayInformationView)this.SilentAreaInfo.ShowInfo).InformationConfig;
			}
			if (this.SilentAreaInfo.ShowInfo.Type != EInformationViewType.BossRushBuffInfo)
			{
				return new List<ILevelPlayInformation>();
			}
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			int bossRushSelectedBuffId = BossRushController.Instance.GetBossRushSelectedBuffId(instanceId);
			BossRushBuff? bossRushBuffConfigById = BossRushConfig.Instance.GetBossRushBuffConfigById(bossRushSelectedBuffId);
			if (bossRushBuffConfigById == null)
			{
				return new List<ILevelPlayInformation>();
			}
			IInformationSubTitle informationSubTitle = new IInformationSubTitle
			{
				TidTitle = bossRushBuffConfigById.Value.BuffTitle,
				TidContent = bossRushBuffConfigById.Value.BuffDesc
			};
			ILevelPlayInformation levelPlayInformation = new ILevelPlayInformation();
			levelPlayInformation.TidMainTitle = "BossRushBuffDesc";
			int num = 1;
			List<IInformationSubTitle> list = new List<IInformationSubTitle>(num);
			CollectionsMarshal.SetCount<IInformationSubTitle>(list, num);
			Span<IInformationSubTitle> span = CollectionsMarshal.AsSpan<IInformationSubTitle>(list);
			int num2 = 0;
			*span[num2] = informationSubTitle;
			levelPlayInformation.SubTitles = list;
			ILevelPlayInformation levelPlayInformation2 = levelPlayInformation;
			num2 = 1;
			List<ILevelPlayInformation> list2 = new List<ILevelPlayInformation>(num2);
			CollectionsMarshal.SetCount<ILevelPlayInformation>(list2, num2);
			Span<ILevelPlayInformation> span2 = CollectionsMarshal.AsSpan<ILevelPlayInformation>(list2);
			num = 0;
			*span2[num] = levelPlayInformation2;
			return list2;
		}

		// Token: 0x06031F4D RID: 204621 RVA: 0x00DFAE78 File Offset: 0x00DF9078
		private void UpdateItems()
		{
			if (this.SilentAreaInfo == null)
			{
				return;
			}
			List<ILevelPlayInformation> infoInformationConfig = this.GetInfoInformationConfig();
			for (int i = 0; i < infoInformationConfig.Count; i++)
			{
				ILevelPlayInformation config = infoInformationConfig[i];
				if (i < this.Items.Count)
				{
					SilentAreaInfoItem silentAreaInfoItem = this.Items[i];
					silentAreaInfoItem.SetCurrentShowType(this.SilentAreaInfo.ShowInfo.Type);
					silentAreaInfoItem.UpdateItem(config);
				}
				else
				{
					UUIItem uuiitem = LguiUtil.Instance.CopyItem(base.GetItem(1), base.GetItem(0));
					SilentAreaInfoItem silentAreaInfoItem = new SilentAreaInfoItem();
					silentAreaInfoItem.SetCurrentShowType(this.SilentAreaInfo.ShowInfo.Type);
					silentAreaInfoItem.Initialize(uuiitem.GetOwner(), config);
					this.Items.Add(silentAreaInfoItem);
				}
			}
			for (int j = 0; j < this.Items.Count; j++)
			{
				this.Items[j].SetActive(j < infoInformationConfig.Count);
			}
		}

		// Token: 0x06031F4E RID: 204622 RVA: 0x00DFAF74 File Offset: 0x00DF9174
		private void StartCountdown()
		{
			this.TimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimerEnd), 8000f, null, null, true, 1f);
		}

		// Token: 0x06031F4F RID: 204623 RVA: 0x00DFAFA0 File Offset: 0x00DF91A0
		public void EndShow()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x06031F50 RID: 204624 RVA: 0x00DFAFF9 File Offset: 0x00DF91F9
		private void OnTimerEnd(float _)
		{
			this.EndShow();
			EventSystem.Instance.Emit(EEventName.BattleUiToggleSilentAreaInfoView);
		}

		// Token: 0x0401A727 RID: 108327
		private bool Created;

		// Token: 0x0401A728 RID: 108328
		private SilentAreaShowInfo SilentAreaInfo;

		// Token: 0x0401A729 RID: 108329
		private TimerHandle TimerHandle;

		// Token: 0x0401A72A RID: 108330
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A72B RID: 108331
		[Nullable(1)]
		private readonly List<SilentAreaInfoItem> Items = new List<SilentAreaInfoItem>();

		// Token: 0x0200AACA RID: 43722
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x04034C61 RID: 216161
			ItemsRoot,
			// Token: 0x04034C62 RID: 216162
			InfoItem
		}
	}
}
