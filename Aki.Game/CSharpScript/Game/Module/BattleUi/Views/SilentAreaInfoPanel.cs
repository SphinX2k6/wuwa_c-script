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
	// Token: 0x02005DC1 RID: 24001
	[NullableContext(2)]
	[Nullable(0)]
	public class SilentAreaInfoPanel : BattleChildView
	{
		// Token: 0x0603CFCF RID: 249807 RVA: 0x00EA9CA4 File Offset: 0x00EA7EA4
		protected override UniTask InitializeAsync(object param = null)
		{
			SilentAreaInfoPanel.<InitializeAsync>d__6 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<SilentAreaInfoPanel.<InitializeAsync>d__6>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CFD0 RID: 249808 RVA: 0x00EA9CE8 File Offset: 0x00EA7EE8
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

		// Token: 0x0603CFD1 RID: 249809 RVA: 0x00EA9D54 File Offset: 0x00EA7F54
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

		// Token: 0x0603CFD2 RID: 249810 RVA: 0x00EA9DB8 File Offset: 0x00EA7FB8
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

		// Token: 0x0603CFD3 RID: 249811 RVA: 0x00EA9E1C File Offset: 0x00EA801C
		protected override void OnShowBattleChildView()
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x0603CFD4 RID: 249812 RVA: 0x00EA9E53 File Offset: 0x00EA8053
		public void UpdateInfo(SilentAreaShowInfo silentAreaInfo)
		{
			this.SilentAreaInfo = silentAreaInfo;
			if (!this.Created)
			{
				return;
			}
			this.UpdateItems();
		}

		// Token: 0x0603CFD5 RID: 249813 RVA: 0x00EA9E6C File Offset: 0x00EA806C
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

		// Token: 0x0603CFD6 RID: 249814 RVA: 0x00EA9F9C File Offset: 0x00EA819C
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

		// Token: 0x0603CFD7 RID: 249815 RVA: 0x00EAA098 File Offset: 0x00EA8298
		private void StartCountdown()
		{
			this.TimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimerEnd), 8000f, null, null, true, 1f);
		}

		// Token: 0x0603CFD8 RID: 249816 RVA: 0x00EAA0C4 File Offset: 0x00EA82C4
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

		// Token: 0x0603CFD9 RID: 249817 RVA: 0x00EAA11D File Offset: 0x00EA831D
		private void OnTimerEnd(float _)
		{
			this.EndShow();
			EventSystem.Instance.Emit(EEventName.BattleUiToggleSilentAreaInfoView);
		}

		// Token: 0x0401FC6A RID: 130154
		private bool Created;

		// Token: 0x0401FC6B RID: 130155
		private SilentAreaShowInfo SilentAreaInfo;

		// Token: 0x0401FC6C RID: 130156
		private TimerHandle TimerHandle;

		// Token: 0x0401FC6D RID: 130157
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FC6E RID: 130158
		[Nullable(1)]
		private readonly List<SilentAreaInfoItem> Items = new List<SilentAreaInfoItem>();

		// Token: 0x0200C0C1 RID: 49345
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x0403A28F RID: 238223
			ItemsRoot,
			// Token: 0x0403A290 RID: 238224
			InfoItem
		}
	}
}
