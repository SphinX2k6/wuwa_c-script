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
	// Token: 0x0200589F RID: 22687
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonMowingDropDownItem : UiPanelBase
	{
		// Token: 0x06039B8B RID: 236427 RVA: 0x00DB7DEC File Offset: 0x00DB5FEC
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

		// Token: 0x06039B8C RID: 236428 RVA: 0x00DB7E40 File Offset: 0x00DB6040
		protected override UniTask OnBeforeStartAsync()
		{
			InstanceDungeonMowingDropDownItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InstanceDungeonMowingDropDownItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039B8D RID: 236429 RVA: 0x00DB7E84 File Offset: 0x00DB6084
		private UniTask CreateDropDownCom()
		{
			InstanceDungeonMowingDropDownItem.<CreateDropDownCom>d__8 <CreateDropDownCom>d__;
			<CreateDropDownCom>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDropDownCom>d__.<>4__this = this;
			<CreateDropDownCom>d__.<>1__state = -1;
			<CreateDropDownCom>d__.<>t__builder.Start<InstanceDungeonMowingDropDownItem.<CreateDropDownCom>d__8>(ref <CreateDropDownCom>d__);
			return <CreateDropDownCom>d__.<>t__builder.Task;
		}

		// Token: 0x06039B8E RID: 236430 RVA: 0x00DB7EC7 File Offset: 0x00DB60C7
		protected override void OnStart()
		{
			base.AddChild(this.DifficultyDropDown);
			if (this.ItemDataHandle != null)
			{
				this.RefreshItem(this.ItemDataHandle.InstanceId);
			}
		}

		// Token: 0x06039B8F RID: 236431 RVA: 0x00DB7EEE File Offset: 0x00DB60EE
		private DropDownItem OnCreateDropDownItem(UUIItem item, TakeWeedsDifficulty data)
		{
			return new DropDownItem(item);
		}

		// Token: 0x06039B90 RID: 236432 RVA: 0x00DB7EF6 File Offset: 0x00DB60F6
		private DropDownTitle OnCreateDropDownTitle(UUIItem item)
		{
			return new DropDownTitle(item);
		}

		// Token: 0x06039B91 RID: 236433 RVA: 0x00DB7F00 File Offset: 0x00DB6100
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

		// Token: 0x06039B92 RID: 236434 RVA: 0x00DB7F90 File Offset: 0x00DB6190
		private TakeWeedsDifficulty GetDropDownItemData(TakeWeedsDifficulty data)
		{
			return data;
		}

		// Token: 0x06039B93 RID: 236435 RVA: 0x00DB7F94 File Offset: 0x00DB6194
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

		// Token: 0x06039B94 RID: 236436 RVA: 0x00DB8044 File Offset: 0x00DB6244
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

		// Token: 0x0401E266 RID: 123494
		[Nullable(2)]
		private InstanceDungeonMowingDropDownItemData ItemDataHandle;

		// Token: 0x0401E267 RID: 123495
		private int? InstanceId;

		// Token: 0x0401E268 RID: 123496
		private readonly TakeWeedsDifficulty[] EmptyArray = Array.Empty<TakeWeedsDifficulty>();

		// Token: 0x0401E269 RID: 123497
		[Nullable(2)]
		private CommonDropDown<TakeWeedsDifficulty, TakeWeedsDifficulty> DifficultyDropDown;

		// Token: 0x0401E26A RID: 123498
		private KillMonstersScores? LevelData;

		// Token: 0x0200BB07 RID: 47879
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04038809 RID: 231433
			DropdownItem
		}
	}
}
