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

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004877 RID: 18551
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonMowingDropDownItem : UiPanelBase
	{
		// Token: 0x0602EAAE RID: 191150 RVA: 0x00D06D04 File Offset: 0x00D04F04
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0602EAAF RID: 191151 RVA: 0x00D06D58 File Offset: 0x00D04F58
		protected override UniTask OnBeforeStartAsync()
		{
			InstanceDungeonMowingDropDownItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InstanceDungeonMowingDropDownItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EAB0 RID: 191152 RVA: 0x00D06D9C File Offset: 0x00D04F9C
		private UniTask CreateDropDownCom()
		{
			InstanceDungeonMowingDropDownItem.<CreateDropDownCom>d__8 <CreateDropDownCom>d__;
			<CreateDropDownCom>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDropDownCom>d__.<>4__this = this;
			<CreateDropDownCom>d__.<>1__state = -1;
			<CreateDropDownCom>d__.<>t__builder.Start<InstanceDungeonMowingDropDownItem.<CreateDropDownCom>d__8>(ref <CreateDropDownCom>d__);
			return <CreateDropDownCom>d__.<>t__builder.Task;
		}

		// Token: 0x0602EAB1 RID: 191153 RVA: 0x00D06DDF File Offset: 0x00D04FDF
		protected override void OnStart()
		{
			base.AddChild(this.DifficultyDropDown);
			if (this.ItemDataHandle != null)
			{
				this.RefreshItem(this.ItemDataHandle.InstanceId);
			}
		}

		// Token: 0x0602EAB2 RID: 191154 RVA: 0x00D06E06 File Offset: 0x00D05006
		private DropDownItem OnCreateDropDownItem(UUIItem item, TakeWeedsDifficulty data)
		{
			return new DropDownItem(item);
		}

		// Token: 0x0602EAB3 RID: 191155 RVA: 0x00D06E0E File Offset: 0x00D0500E
		private DropDownTitle OnCreateDropDownTitle(UUIItem item)
		{
			return new DropDownTitle(item);
		}

		// Token: 0x0602EAB4 RID: 191156 RVA: 0x00D06E18 File Offset: 0x00D05018
		private TakeWeedsDifficulty[] GetDifficultyDataList()
		{
			KillMonstersScores? config = ConfigKillMonstersScoresByInstanceID.GetConfig(this.InstanceId.Value, true);
			if (config == null || config.Value.DifficultyOptionsLength == 0)
			{
				return this.EmptyArray;
			}
			List<TakeWeedsDifficulty> list = new List<TakeWeedsDifficulty>();
			int[] array = config.Value.DifficultyOptions();
			for (int i = 0; i < array.Length; i++)
			{
				TakeWeedsDifficulty? config2 = ConfigTakeWeedsDifficultyById.GetConfig(array[i], true);
				if (config2 != null)
				{
					list.Add(config2.Value);
				}
			}
			return list.ToArray();
		}

		// Token: 0x0602EAB5 RID: 191157 RVA: 0x00D06EA8 File Offset: 0x00D050A8
		private TakeWeedsDifficulty GetDropDownItemData(TakeWeedsDifficulty data)
		{
			return data;
		}

		// Token: 0x0602EAB6 RID: 191158 RVA: 0x00D06EAC File Offset: 0x00D050AC
		public void RefreshItem(int instanceId)
		{
			if (base.InAsyncLoading())
			{
				this.ItemDataHandle = new InstanceDungeonMowingDropDownItemData
				{
					InstanceId = instanceId
				};
				return;
			}
			this.InstanceId = new int?(instanceId);
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

		// Token: 0x0602EAB7 RID: 191159 RVA: 0x00D06F5C File Offset: 0x00D0515C
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
			ActivityMowingController.Instance.RequestSetDifficultyAll(mowingActivityData.Id, takeWeedsDifficulty.Id);
		}

		// Token: 0x04018D03 RID: 101635
		[Nullable(2)]
		private InstanceDungeonMowingDropDownItemData ItemDataHandle;

		// Token: 0x04018D04 RID: 101636
		private int? InstanceId;

		// Token: 0x04018D05 RID: 101637
		private readonly TakeWeedsDifficulty[] EmptyArray = Array.Empty<TakeWeedsDifficulty>();

		// Token: 0x04018D06 RID: 101638
		[Nullable(2)]
		private CommonDropDown<TakeWeedsDifficulty, TakeWeedsDifficulty> DifficultyDropDown;

		// Token: 0x04018D07 RID: 101639
		private KillMonstersScores? LevelData;

		// Token: 0x0200A520 RID: 42272
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403320A RID: 209418
			DropdownItem
		}
	}
}
