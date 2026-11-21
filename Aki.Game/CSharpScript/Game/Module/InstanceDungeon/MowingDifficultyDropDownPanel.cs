using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Mowing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200485F RID: 18527
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingDifficultyDropDownPanel : UiPanelBase
	{
		// Token: 0x0602E9EA RID: 190954 RVA: 0x00D04284 File Offset: 0x00D02484
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0602E9EB RID: 190955 RVA: 0x00D0433C File Offset: 0x00D0253C
		protected override UniTask OnBeforeStartAsync()
		{
			MowingDifficultyDropDownPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingDifficultyDropDownPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E9EC RID: 190956 RVA: 0x00D04380 File Offset: 0x00D02580
		private UniTask CreateDropDownCom()
		{
			MowingDifficultyDropDownPanel.<CreateDropDownCom>d__6 <CreateDropDownCom>d__;
			<CreateDropDownCom>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDropDownCom>d__.<>4__this = this;
			<CreateDropDownCom>d__.<>1__state = -1;
			<CreateDropDownCom>d__.<>t__builder.Start<MowingDifficultyDropDownPanel.<CreateDropDownCom>d__6>(ref <CreateDropDownCom>d__);
			return <CreateDropDownCom>d__.<>t__builder.Task;
		}

		// Token: 0x0602E9ED RID: 190957 RVA: 0x00D043C3 File Offset: 0x00D025C3
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x0602E9EE RID: 190958 RVA: 0x00D043D2 File Offset: 0x00D025D2
		private DropDownItem OnCreateDropDownItem(UUIItem item, TakeWeedsDifficulty data)
		{
			return new DropDownItem(item);
		}

		// Token: 0x0602E9EF RID: 190959 RVA: 0x00D043DA File Offset: 0x00D025DA
		private DropDownTitle OnCreateDropDownTitle(UUIItem item)
		{
			return new DropDownTitle(item);
		}

		// Token: 0x0602E9F0 RID: 190960 RVA: 0x00D043E4 File Offset: 0x00D025E4
		private unsafe IReadOnlyList<TakeWeedsDifficulty> GetDifficultyDataList()
		{
			KillMonstersScores? config = ConfigKillMonstersScoresByInstanceID.GetConfig(this.InstanceId.Value, true);
			if (config == null || config.Value.DifficultyOptionsLength == 0)
			{
				return Array.Empty<TakeWeedsDifficulty>();
			}
			List<TakeWeedsDifficulty> list = new List<TakeWeedsDifficulty>();
			Span<int> difficultyOptionsBytes = config.Value.GetDifficultyOptionsBytes();
			for (int i = 0; i < difficultyOptionsBytes.Length; i++)
			{
				TakeWeedsDifficulty? config2 = ConfigTakeWeedsDifficultyById.GetConfig(*difficultyOptionsBytes[i], true);
				if (config2 != null)
				{
					list.Add(config2.Value);
				}
			}
			return list;
		}

		// Token: 0x0602E9F1 RID: 190961 RVA: 0x00D04478 File Offset: 0x00D02678
		private TakeWeedsDifficulty GetDropDownItemData(TakeWeedsDifficulty data)
		{
			return data;
		}

		// Token: 0x0602E9F2 RID: 190962 RVA: 0x00D0447C File Offset: 0x00D0267C
		public void RefreshByInstanceId(int id)
		{
			this.InstanceId = new int?(id);
			this.LevelData = ConfigKillMonstersScoresByInstanceID.GetConfig(this.InstanceId.Value, true);
			ActivityMowingData mowingActivityData = ActivityMowingController.Instance.GetMowingActivityData();
			if (mowingActivityData == null)
			{
				Log.Instance.Error(ELogModule.Activity, ELogAuthor.YYZ, "当前没有割草活动数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			CommonDropDown<TakeWeedsDifficulty, TakeWeedsDifficulty> difficultyDropDown = this.DifficultyDropDown;
			if (difficultyDropDown == null)
			{
				return;
			}
			difficultyDropDown.InitScroll(this.GetDifficultyDataList(), new Func<TakeWeedsDifficulty, TakeWeedsDifficulty>(this.GetDropDownItemData), mowingActivityData.GetLevelDiffIndex(this.InstanceId.Value), true);
		}

		// Token: 0x0602E9F3 RID: 190963 RVA: 0x00D04510 File Offset: 0x00D02710
		private void OnSelectDifficulty(int index, TakeWeedsDifficulty data)
		{
			ActivityMowingData mowingActivityData = ActivityMowingController.Instance.GetMowingActivityData();
			TakeWeedsDifficulty takeWeedsDifficulty = data;
			if (mowingActivityData == null)
			{
				Log.Instance.Error(ELogModule.Activity, ELogAuthor.YYZ, "当前没有割草活动数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.LevelData == null)
			{
				Log.Instance.Error(ELogModule.Activity, ELogAuthor.YYZ, "当前没有割草活动副本数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			string item = ConfigTakeWeedsDifficultyById.GetConfig(takeWeedsDifficulty.Id, true).Value.RecommendedLevel.ToString();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "RecommendLevel", new <>z__ReadOnlySingleElementList<object>(item));
			ActivityMowingController.Instance.RequestSetDifficultyAll(mowingActivityData.Id, takeWeedsDifficulty.Id);
		}

		// Token: 0x04018CC8 RID: 101576
		[Nullable(2)]
		private CommonDropDown<TakeWeedsDifficulty, TakeWeedsDifficulty> DifficultyDropDown;

		// Token: 0x04018CC9 RID: 101577
		private int? InstanceId;

		// Token: 0x04018CCA RID: 101578
		private KillMonstersScores? LevelData;

		// Token: 0x0200A4FB RID: 42235
		[NullableContext(0)]
		private static class EDropDownPanelComponents
		{
			// Token: 0x04033188 RID: 209288
			public const int TxtTitle = 0;

			// Token: 0x04033189 RID: 209289
			public const int PanelTitle = 1;

			// Token: 0x0403318A RID: 209290
			public const int DropdownItem = 2;

			// Token: 0x0403318B RID: 209291
			public const int TxtTips = 3;
		}
	}
}
