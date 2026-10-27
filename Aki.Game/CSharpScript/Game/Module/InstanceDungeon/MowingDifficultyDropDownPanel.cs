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
	// Token: 0x02005887 RID: 22663
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingDifficultyDropDownPanel : UiPanelBase
	{
		// Token: 0x06039AC7 RID: 236231 RVA: 0x00DB536C File Offset: 0x00DB356C
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

		// Token: 0x06039AC8 RID: 236232 RVA: 0x00DB5424 File Offset: 0x00DB3624
		protected override UniTask OnBeforeStartAsync()
		{
			MowingDifficultyDropDownPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingDifficultyDropDownPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039AC9 RID: 236233 RVA: 0x00DB5468 File Offset: 0x00DB3668
		private UniTask CreateDropDownCom()
		{
			MowingDifficultyDropDownPanel.<CreateDropDownCom>d__6 <CreateDropDownCom>d__;
			<CreateDropDownCom>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDropDownCom>d__.<>4__this = this;
			<CreateDropDownCom>d__.<>1__state = -1;
			<CreateDropDownCom>d__.<>t__builder.Start<MowingDifficultyDropDownPanel.<CreateDropDownCom>d__6>(ref <CreateDropDownCom>d__);
			return <CreateDropDownCom>d__.<>t__builder.Task;
		}

		// Token: 0x06039ACA RID: 236234 RVA: 0x00DB54AB File Offset: 0x00DB36AB
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x06039ACB RID: 236235 RVA: 0x00DB54BA File Offset: 0x00DB36BA
		private DropDownItem OnCreateDropDownItem(UUIItem item, TakeWeedsDifficulty data)
		{
			return new DropDownItem(item);
		}

		// Token: 0x06039ACC RID: 236236 RVA: 0x00DB54C2 File Offset: 0x00DB36C2
		private DropDownTitle OnCreateDropDownTitle(UUIItem item)
		{
			return new DropDownTitle(item);
		}

		// Token: 0x06039ACD RID: 236237 RVA: 0x00DB54CC File Offset: 0x00DB36CC
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

		// Token: 0x06039ACE RID: 236238 RVA: 0x00DB5560 File Offset: 0x00DB3760
		private TakeWeedsDifficulty GetDropDownItemData(TakeWeedsDifficulty data)
		{
			return data;
		}

		// Token: 0x06039ACF RID: 236239 RVA: 0x00DB5564 File Offset: 0x00DB3764
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

		// Token: 0x06039AD0 RID: 236240 RVA: 0x00DB55F8 File Offset: 0x00DB37F8
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

		// Token: 0x0401E22B RID: 123435
		[Nullable(2)]
		private CommonDropDown<TakeWeedsDifficulty, TakeWeedsDifficulty> DifficultyDropDown;

		// Token: 0x0401E22C RID: 123436
		private int? InstanceId;

		// Token: 0x0401E22D RID: 123437
		private KillMonstersScores? LevelData;

		// Token: 0x0200BAE2 RID: 47842
		[NullableContext(0)]
		private static class EDropDownPanelComponents
		{
			// Token: 0x04038787 RID: 231303
			public const int TxtTitle = 0;

			// Token: 0x04038788 RID: 231304
			public const int PanelTitle = 1;

			// Token: 0x04038789 RID: 231305
			public const int DropdownItem = 2;

			// Token: 0x0403878A RID: 231306
			public const int TxtTips = 3;
		}
	}
}
