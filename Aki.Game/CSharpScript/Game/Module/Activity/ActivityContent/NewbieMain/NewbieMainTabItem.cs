using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x02005308 RID: 21256
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NewbieMainTabItem : GridProxyAbstract<NewbieMainTabItemData>
	{
		// Token: 0x06034E05 RID: 216581 RVA: 0x00EC845C File Offset: 0x00EC665C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITextureTransitionComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickTabInternal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034E06 RID: 216582 RVA: 0x00EC86FC File Offset: 0x00EC68FC
		public override void Refresh(NewbieMainTabItemData data, bool isSelected, int gridIndex)
		{
			this.TabItemData = data;
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(data.IsNew);
			}
			this.RefreshProgressText(data);
			this.RefreshTexture(data);
			this.RefreshBgTexture(data);
			this.RefreshStateDisplay(data.State);
			this.RefreshWaitingTitleText(data);
			this.RefreshProcessingTitleText(data);
			UUIText text = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text, data.TabConfig.TitleText, Array.Empty<object>());
			UUIItem uuiitem = text;
			bool bUseChangeColor = data.TabConfig.Type == 1;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			this.SetSpriteByPath(data.TabConfig.TitleIcon, base.GetSprite(1), false, null, null);
			this.RefreshProcessingCountText(data);
		}

		// Token: 0x06034E07 RID: 216583 RVA: 0x00EC87C8 File Offset: 0x00EC69C8
		private void RefreshProgressText(NewbieMainTabItemData data)
		{
			NewbieMainActTab tabConfig = data.TabConfig;
			int completedTaskCount = data.TabData.GetCompletedTaskCount();
			int tabTasksCount = NewbieMainModel.Instance.GetTabTasksCount(tabConfig.Id);
			string textStringId = (tabConfig.Type == 1) ? "NewPlayer_TaskAwards_010" : "NewPlayer_TaskAwards_019";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				completedTaskCount,
				tabTasksCount
			}));
		}

		// Token: 0x06034E08 RID: 216584 RVA: 0x00EC8844 File Offset: 0x00EC6A44
		private void RefreshTexture(NewbieMainTabItemData data)
		{
			string path = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? data.TabConfig.MaleTaskTexture : data.TabConfig.FemaleTaskTexture;
			base.SetTextureByPath(path, base.GetTexture(6), null, null);
		}

		// Token: 0x06034E09 RID: 216585 RVA: 0x00EC8890 File Offset: 0x00EC6A90
		private void RefreshBgTexture(NewbieMainTabItemData data)
		{
			NewbieMainTabItem.<>c__DisplayClass7_0 CS$<>8__locals1 = new NewbieMainTabItem.<>c__DisplayClass7_0();
			CS$<>8__locals1.<>4__this = this;
			if (!NewbieMainDefine.NewbieMainBgTextureResourceMap.TryGetValue((ENewbieMainTabType)data.TabConfig.Type, out CS$<>8__locals1.resourceList))
			{
				return;
			}
			UUITexture texture = base.GetTexture(15);
			if (texture != null)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(CS$<>8__locals1.resourceList[0]);
				base.SetTextureByPath(resourcePath, texture, null, null);
			}
			UiAsyncTask task = new UiAsyncTask("RefreshBgTextureTransition", delegate()
			{
				NewbieMainTabItem.<>c__DisplayClass7_0.<<RefreshBgTexture>b__0>d <<RefreshBgTexture>b__0>d;
				<<RefreshBgTexture>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshBgTexture>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshBgTexture>b__0>d.<>1__state = -1;
				<<RefreshBgTexture>b__0>d.<>t__builder.Start<NewbieMainTabItem.<>c__DisplayClass7_0.<<RefreshBgTexture>b__0>d>(ref <<RefreshBgTexture>b__0>d);
				return <<RefreshBgTexture>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x06034E0A RID: 216586 RVA: 0x00EC8924 File Offset: 0x00EC6B24
		private UniTask RefreshBgTextureTransition(IReadOnlyList<string> resourceList)
		{
			NewbieMainTabItem.<RefreshBgTextureTransition>d__8 <RefreshBgTextureTransition>d__;
			<RefreshBgTextureTransition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshBgTextureTransition>d__.<>4__this = this;
			<RefreshBgTextureTransition>d__.resourceList = resourceList;
			<RefreshBgTextureTransition>d__.<>1__state = -1;
			<RefreshBgTextureTransition>d__.<>t__builder.Start<NewbieMainTabItem.<RefreshBgTextureTransition>d__8>(ref <RefreshBgTextureTransition>d__);
			return <RefreshBgTextureTransition>d__.<>t__builder.Task;
		}

		// Token: 0x06034E0B RID: 216587 RVA: 0x00EC8970 File Offset: 0x00EC6B70
		private void RefreshStateDisplay(ENewbieMainTabState state)
		{
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(state == ENewbieMainTabState.Completed);
			}
			UUIItem item2 = base.GetItem(13);
			if (item2 != null)
			{
				item2.SetUIActive(state == ENewbieMainTabState.Finished);
			}
			UUIItem item3 = base.GetItem(8);
			if (item3 != null)
			{
				item3.SetUIActive(state == ENewbieMainTabState.InProgress);
			}
			UUIItem item4 = base.GetItem(14);
			if (item4 != null)
			{
				item4.SetUIActive(state == ENewbieMainTabState.Lock);
			}
			UUIItem item5 = base.GetItem(7);
			if (item5 == null)
			{
				return;
			}
			item5.SetUIActive(state == ENewbieMainTabState.Lock);
		}

		// Token: 0x06034E0C RID: 216588 RVA: 0x00EC89F0 File Offset: 0x00EC6BF0
		private void RefreshProcessingTitleText(NewbieMainTabItemData data)
		{
			if (data.State != ENewbieMainTabState.InProgress)
			{
				return;
			}
			UUIText text = base.GetText(9);
			if (data.TabConfig.Type == 1)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "NewPlayer_TaskAwards_001", Array.Empty<object>());
				return;
			}
			if (data.TabConfig.Type == 2)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "NewPlayer_TaskAwards_008", Array.Empty<object>());
			}
		}

		// Token: 0x06034E0D RID: 216589 RVA: 0x00EC8A58 File Offset: 0x00EC6C58
		private void RefreshWaitingTitleText(NewbieMainTabItemData data)
		{
			if (data.State != ENewbieMainTabState.Completed)
			{
				return;
			}
			UUIText text = base.GetText(12);
			if (data.TabConfig.Type == 2)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "NewPlayer_TaskAwards_014", Array.Empty<object>());
				return;
			}
			if (data.TabConfig.Type == 1)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "NewPlayer_TaskAwards_007", Array.Empty<object>());
			}
		}

		// Token: 0x06034E0E RID: 216590 RVA: 0x00EC8AC0 File Offset: 0x00EC6CC0
		private void RefreshProcessingCountText(NewbieMainTabItemData data)
		{
			if (data.State != ENewbieMainTabState.InProgress)
			{
				return;
			}
			NewbieMainActTab tabConfig = data.TabConfig;
			if (tabConfig.Type == 1)
			{
				this.RefreshMainProcessingText(data);
				return;
			}
			if (tabConfig.Type == 2)
			{
				int acceptedTaskCount = NewbieMainModel.Instance.GetAcceptedTaskCount(tabConfig.Id, data.TabData);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "NewPlayer_TaskAwards_009", new <>z__ReadOnlySingleElementList<object>(acceptedTaskCount));
			}
		}

		// Token: 0x06034E0F RID: 216591 RVA: 0x00EC8B34 File Offset: 0x00EC6D34
		private void RefreshMainProcessingText(NewbieMainTabItemData data)
		{
			UUIText text = base.GetText(10);
			int? num = (data.ProgressingTask != null) ? new int?(data.ProgressingTask.GetValueOrDefault().QuestType) : null;
			if (num.GetValueOrDefault() == 2)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "NewPlayer_TaskAwards_017", Array.Empty<object>());
				return;
			}
			if (num.GetValueOrDefault() == 3)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "NewPlayer_TaskAwards_018", Array.Empty<object>());
				return;
			}
			if (num.GetValueOrDefault() == 4)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "NewPlayer_TaskAwards_002", new <>z__ReadOnlySingleElementList<object>(data.ProgressingTask.Value.Act));
			}
		}

		// Token: 0x06034E10 RID: 216592 RVA: 0x00EC8BEE File Offset: 0x00EC6DEE
		private void OnClickTabInternal()
		{
			if (this.TabItemData != null)
			{
				Action<NewbieMainTabItemData> onClickTab = this.OnClickTab;
				if (onClickTab == null)
				{
					return;
				}
				onClickTab(this.TabItemData);
			}
		}

		// Token: 0x0401BF73 RID: 114547
		[Nullable(2)]
		private NewbieMainTabItemData TabItemData;

		// Token: 0x0401BF74 RID: 114548
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<NewbieMainTabItemData> OnClickTab;

		// Token: 0x0200AF83 RID: 44931
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040363D1 RID: 222161
			public const int ItemButton = 0;

			// Token: 0x040363D2 RID: 222162
			public const int TypeIconSprite = 1;

			// Token: 0x040363D3 RID: 222163
			public const int TitleText = 2;

			// Token: 0x040363D4 RID: 222164
			public const int TotalProgressText = 3;

			// Token: 0x040363D5 RID: 222165
			public const int NewTagItem = 4;

			// Token: 0x040363D6 RID: 222166
			public const int TagText = 5;

			// Token: 0x040363D7 RID: 222167
			public const int TaskTexture = 6;

			// Token: 0x040363D8 RID: 222168
			public const int TaskLockItem = 7;

			// Token: 0x040363D9 RID: 222169
			public const int ProcessingItem = 8;

			// Token: 0x040363DA RID: 222170
			public const int ProcessingTitleText = 9;

			// Token: 0x040363DB RID: 222171
			public const int ProcessingCountText = 10;

			// Token: 0x040363DC RID: 222172
			public const int WaitingItem = 11;

			// Token: 0x040363DD RID: 222173
			public const int WaitingText = 12;

			// Token: 0x040363DE RID: 222174
			public const int FinishedItem = 13;

			// Token: 0x040363DF RID: 222175
			public const int LockItem = 14;

			// Token: 0x040363E0 RID: 222176
			public const int BgTexture = 15;

			// Token: 0x040363E1 RID: 222177
			public const int BgTextureTransition = 16;
		}
	}
}
