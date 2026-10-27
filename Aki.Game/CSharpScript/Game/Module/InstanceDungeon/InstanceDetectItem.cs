using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005864 RID: 22628
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDetectItem : UiPanelBase, IDynamicScrollItem<InstanceDetectionDynamicData>
	{
		// Token: 0x06039865 RID: 235621 RVA: 0x00DA8678 File Offset: 0x00DA6878
		[NullableContext(1)]
		public UniTask Init(UUIItem actor)
		{
			InstanceDetectItem.<Init>d__14 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<InstanceDetectItem.<Init>d__14>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06039866 RID: 235622 RVA: 0x00DA86C4 File Offset: 0x00DA68C4
		protected unsafe override void OnRegisterComponent()
		{
			this.ParentModel = (this.OpenParam as InstanceDungeonViewModelBase);
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039867 RID: 235623 RVA: 0x00DA87A4 File Offset: 0x00DA69A4
		private UniTask InitChildItem()
		{
			InstanceDetectItem.<InitChildItem>d__16 <InitChildItem>d__;
			<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitChildItem>d__.<>4__this = this;
			<InitChildItem>d__.<>1__state = -1;
			<InitChildItem>d__.<>t__builder.Start<InstanceDetectItem.<InitChildItem>d__16>(ref <InitChildItem>d__);
			return <InitChildItem>d__.<>t__builder.Task;
		}

		// Token: 0x06039868 RID: 235624 RVA: 0x00DA87E8 File Offset: 0x00DA69E8
		[NullableContext(1)]
		public AUIBaseActor GetUsingItem(InstanceDetectionDynamicData data)
		{
			if (data.ExtraType == EInstanceDetectionExtraType.TextOnly)
			{
				return base.GetText(4).GetOwner() as AUIBaseActor;
			}
			bool flag = !InstanceDungeonEntranceController.Instance.GetInstanceItemLockStateGetter(data.InstanceGirdId);
			if (data.InstanceSeriesTitle != 0)
			{
				return (flag ? base.GetItem(0) : base.GetItem(2)).GetOwner() as AUIBaseActor;
			}
			return (flag ? base.GetItem(1) : base.GetItem(3)).GetOwner() as AUIBaseActor;
		}

		// Token: 0x06039869 RID: 235625 RVA: 0x00DA8868 File Offset: 0x00DA6A68
		[NullableContext(1)]
		public void Update(InstanceDetectionDynamicData data, int index)
		{
			this.Data = data;
			if (this.UpdateExtraType(data))
			{
				return;
			}
			this.BindAllInstanceDetectGetter(data.InstanceGirdId);
			bool instanceItemLockStateGetter = InstanceDungeonEntranceController.Instance.GetInstanceItemLockStateGetter(data.InstanceGirdId);
			InstanceSeriesItem instanceSeriesItem = this.InstanceSeriesItem;
			InstanceItem instanceItem = this.InstanceItem;
			this.InstanceSeriesItem.SetUiActive(!instanceItemLockStateGetter);
			this.InstanceItem.SetUiActive(!instanceItemLockStateGetter);
			this.LockInstanceSeriesItem.SetUiActive(instanceItemLockStateGetter);
			this.LockInstanceItem.SetUiActive(instanceItemLockStateGetter);
			if (instanceItemLockStateGetter)
			{
				instanceItem = this.LockInstanceItem;
				instanceSeriesItem = this.LockInstanceSeriesItem;
			}
			if (data.InstanceSeriesTitle == 0)
			{
				instanceSeriesItem.SetUiActive(false);
				instanceItem.SetUiActive(true);
				instanceItem.BindClickCallback(this.OnInstanceCallback);
				instanceItem.BindCanExecuteChange(this.InstanceCanExecuteChange);
				instanceItem.Update(data.InstanceGirdId, data.IsSelect, data.IsShow);
				return;
			}
			instanceItem.SetUiActive(false);
			instanceSeriesItem.SetUiActive(true);
			instanceSeriesItem.CurrentData = data;
			instanceSeriesItem.BindCanShowRedDot(this.CanShowRedDot);
			if (instanceSeriesItem != null)
			{
				this.UpdateInstanceSeriesItemGetter(instanceSeriesItem, data.InstanceGirdId);
			}
			if (this.InstanceIconRightPathGetter != null)
			{
				instanceSeriesItem.IconRightPath = this.InstanceIconRightPathGetter(data.InstanceGirdId);
			}
			if (!data.IsOnlyOneGrid)
			{
				instanceSeriesItem.BindClickCallback(this.OnSeriesCallback);
				instanceSeriesItem.Update(data.InstanceSeriesTitle, data.IsSelect, false);
				return;
			}
			instanceSeriesItem.BindClickCallbackOnlyOneGrid(this.OnInstanceCallback);
			instanceSeriesItem.Update(data.InstanceGirdId, data.IsSelect, true);
		}

		// Token: 0x0603986A RID: 235626 RVA: 0x00DA89DC File Offset: 0x00DA6BDC
		[NullableContext(1)]
		private bool UpdateExtraType(InstanceDetectionDynamicData data)
		{
			if (data.ExtraType == EInstanceDetectionExtraType.None)
			{
				return false;
			}
			if (data.ExtraType == EInstanceDetectionExtraType.TextOnly)
			{
				this.InstanceSeriesItem.SetUiActive(false);
				this.InstanceItem.SetUiActive(false);
				this.LockInstanceSeriesItem.SetUiActive(false);
				this.LockInstanceItem.SetUiActive(false);
				UUIText text = base.GetText(4);
				LguiUtil.Instance.SetLocalTextNew(text, data.ExtraText, Array.Empty<object>());
				text.SetUIActive(true);
			}
			return true;
		}

		// Token: 0x0603986B RID: 235627 RVA: 0x00DA8A54 File Offset: 0x00DA6C54
		public void UpdateSelf()
		{
			InstanceDetectionDynamicData data = this.Data;
			bool instanceItemLockStateGetter = InstanceDungeonEntranceController.Instance.GetInstanceItemLockStateGetter(data.InstanceGirdId);
			InstanceSeriesItem instanceSeriesItem = this.InstanceSeriesItem;
			if (instanceSeriesItem != null)
			{
				instanceSeriesItem.SetUiActive(!instanceItemLockStateGetter);
			}
			InstanceSeriesItem lockInstanceSeriesItem = this.LockInstanceSeriesItem;
			if (lockInstanceSeriesItem != null)
			{
				lockInstanceSeriesItem.SetUiActive(instanceItemLockStateGetter);
			}
			InstanceSeriesItem instanceSeriesItem2 = this.InstanceSeriesItem;
			if (instanceItemLockStateGetter)
			{
				instanceSeriesItem2 = this.LockInstanceSeriesItem;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(data.InstanceGirdId);
			LguiUtil.Instance.SetLocalTextNew((instanceSeriesItem2 != null) ? instanceSeriesItem2.GetTitleText() : null, config.Value.MapName, Array.Empty<object>());
			if (instanceSeriesItem2 != null)
			{
				this.UpdateInstanceSeriesItemGetter(instanceSeriesItem2, data.InstanceGirdId);
			}
			instanceSeriesItem2.RefreshSubtitleByIdAndArgs();
		}

		// Token: 0x0603986C RID: 235628 RVA: 0x00DA8B04 File Offset: 0x00DA6D04
		private void BindAllInstanceDetectGetter(int instanceId)
		{
			InstanceDetectItemGetterData instanceDetectItemGetterData = null;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (config != null)
			{
				EDungeonSubType instSubType = (EDungeonSubType)config.Value.InstSubType;
				InstanceDungeonMapDefine.InstanceDetectItemGetterDataMap.TryGetValue(instSubType, out instanceDetectItemGetterData);
			}
			this.BindSubtitleTextIdGetter((instanceDetectItemGetterData != null) ? instanceDetectItemGetterData.SubtitleTextIdGetter : null);
			this.BindSubtitleArgsGetter((instanceDetectItemGetterData != null) ? instanceDetectItemGetterData.SubtitleArgsGetter : null);
			this.BindInstanceCheckFinishedGetter((instanceDetectItemGetterData != null) ? instanceDetectItemGetterData.CheckFinishedGetter : null);
		}

		// Token: 0x0603986D RID: 235629 RVA: 0x00DA8B7C File Offset: 0x00DA6D7C
		[NullableContext(1)]
		private void UpdateInstanceSeriesItemGetter(InstanceSeriesItem instanceSeriesItem, int instanceId)
		{
			TInstanceSubtitleTextIdGetter instanceSubtitleTextIdGetter = this.InstanceSubtitleTextIdGetter;
			instanceSeriesItem.SubtitleTextId = ((instanceSubtitleTextIdGetter != null) ? instanceSubtitleTextIdGetter(instanceId) : null);
			TInstanceSubtitleArgsGetter instanceSubtitleArgsGetter = this.InstanceSubtitleArgsGetter;
			instanceSeriesItem.SubtitleTextArgs = ((instanceSubtitleArgsGetter != null) ? instanceSubtitleArgsGetter(instanceId) : null);
			instanceSeriesItem.RefreshSubtitleByIdAndArgs();
			instanceSeriesItem.HasOverrideFinishState = (this.InstanceCheckFinishedGetter != null);
			if (this.InstanceCheckFinishedGetter != null)
			{
				instanceSeriesItem.OverrideFinishState = this.InstanceCheckFinishedGetter(instanceId);
			}
		}

		// Token: 0x0603986E RID: 235630 RVA: 0x00DA8BEC File Offset: 0x00DA6DEC
		[NullableContext(1)]
		public void UpdateSelfByText(string text)
		{
			InstanceDetectionDynamicData data = this.Data;
			bool instanceItemLockStateGetter = InstanceDungeonEntranceController.Instance.GetInstanceItemLockStateGetter(data.InstanceGirdId);
			InstanceSeriesItem instanceSeriesItem = this.InstanceSeriesItem;
			if (instanceSeriesItem != null)
			{
				instanceSeriesItem.SetUiActive(!instanceItemLockStateGetter);
			}
			InstanceSeriesItem lockInstanceSeriesItem = this.LockInstanceSeriesItem;
			if (lockInstanceSeriesItem != null)
			{
				lockInstanceSeriesItem.SetUiActive(instanceItemLockStateGetter);
			}
			if (instanceItemLockStateGetter)
			{
				InstanceSeriesItem lockInstanceSeriesItem2 = this.LockInstanceSeriesItem;
				if (lockInstanceSeriesItem2 == null)
				{
					return;
				}
				lockInstanceSeriesItem2.UpdateSubtitleByText(text);
			}
		}

		// Token: 0x0603986F RID: 235631 RVA: 0x00DA8C4C File Offset: 0x00DA6E4C
		[NullableContext(1)]
		public UUIText GetActiveNameText()
		{
			if (this.InstanceSeriesItem.IsUiActiveInHierarchy())
			{
				return this.InstanceSeriesItem.GetTitleText();
			}
			if (this.InstanceItem.IsUiActiveInHierarchy())
			{
				return this.InstanceItem.GetTitleText();
			}
			if (this.LockInstanceSeriesItem.IsUiActiveInHierarchy())
			{
				return this.LockInstanceSeriesItem.GetTitleText();
			}
			return this.LockInstanceItem.GetTitleText();
		}

		// Token: 0x06039870 RID: 235632 RVA: 0x00DA8CAF File Offset: 0x00DA6EAF
		[NullableContext(1)]
		public void BindClickSeriesCallback(Action<int, UUIExtendToggle, bool> onClickCallback)
		{
			this.OnSeriesCallback = onClickCallback;
		}

		// Token: 0x06039871 RID: 235633 RVA: 0x00DA8CB8 File Offset: 0x00DA6EB8
		public void BindClickInstanceCallback([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<int, UUIExtendToggle, InstanceDetectionDynamicData> onClickCallback)
		{
			this.OnInstanceCallback = onClickCallback;
		}

		// Token: 0x06039872 RID: 235634 RVA: 0x00DA8CC1 File Offset: 0x00DA6EC1
		[NullableContext(1)]
		public void BindCanExecuteChange(Func<int, bool> canExecuteChange)
		{
			this.InstanceCanExecuteChange = canExecuteChange;
		}

		// Token: 0x06039873 RID: 235635 RVA: 0x00DA8CCA File Offset: 0x00DA6ECA
		public void BindSubtitleTextIdGetter(TInstanceSubtitleTextIdGetter getter)
		{
			this.InstanceSubtitleTextIdGetter = getter;
		}

		// Token: 0x06039874 RID: 235636 RVA: 0x00DA8CD3 File Offset: 0x00DA6ED3
		public void BindSubtitleArgsGetter(TInstanceSubtitleArgsGetter getter)
		{
			this.InstanceSubtitleArgsGetter = getter;
		}

		// Token: 0x06039875 RID: 235637 RVA: 0x00DA8CDC File Offset: 0x00DA6EDC
		public void BindInstanceCheckFinishedGetter(TInstanceCheckFinishedGetter getter)
		{
			this.InstanceCheckFinishedGetter = getter;
		}

		// Token: 0x06039876 RID: 235638 RVA: 0x00DA8CE5 File Offset: 0x00DA6EE5
		[NullableContext(1)]
		public void BindCanShowRedDot(Func<int, bool> getter)
		{
			this.CanShowRedDot = getter;
		}

		// Token: 0x06039877 RID: 235639 RVA: 0x00DA8CEE File Offset: 0x00DA6EEE
		public void BindIconRightPathGetter(Func<int, string> getter)
		{
			this.InstanceIconRightPathGetter = getter;
		}

		// Token: 0x06039878 RID: 235640 RVA: 0x00DA8CF7 File Offset: 0x00DA6EF7
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x06039879 RID: 235641 RVA: 0x00DA8D00 File Offset: 0x00DA6F00
		public UUIExtendToggle GetExtendToggleForGuide()
		{
			if (!this.InstanceItem.GetActive())
			{
				Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "聚焦引导索引到了副本标题, 检查extraParam字段是否配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return this.InstanceItem.ExtendToggle;
		}

		// Token: 0x17008A5C RID: 35420
		// (get) Token: 0x0603987A RID: 235642 RVA: 0x00DA8D43 File Offset: 0x00DA6F43
		public int InstanceId
		{
			get
			{
				return this.Data.InstanceGirdId;
			}
		}

		// Token: 0x0401E140 RID: 123200
		protected InstanceDetectionDynamicData Data;

		// Token: 0x0401E141 RID: 123201
		private InstanceSeriesItem InstanceSeriesItem;

		// Token: 0x0401E142 RID: 123202
		private InstanceItem InstanceItem;

		// Token: 0x0401E143 RID: 123203
		private InstanceSeriesItem LockInstanceSeriesItem;

		// Token: 0x0401E144 RID: 123204
		private InstanceItem LockInstanceItem;

		// Token: 0x0401E145 RID: 123205
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<int, UUIExtendToggle, bool> OnSeriesCallback;

		// Token: 0x0401E146 RID: 123206
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Action<int, UUIExtendToggle, InstanceDetectionDynamicData> OnInstanceCallback;

		// Token: 0x0401E147 RID: 123207
		private Func<int, bool> InstanceCanExecuteChange;

		// Token: 0x0401E148 RID: 123208
		private TInstanceSubtitleTextIdGetter InstanceSubtitleTextIdGetter;

		// Token: 0x0401E149 RID: 123209
		private TInstanceSubtitleArgsGetter InstanceSubtitleArgsGetter;

		// Token: 0x0401E14A RID: 123210
		private TInstanceCheckFinishedGetter InstanceCheckFinishedGetter;

		// Token: 0x0401E14B RID: 123211
		private Func<int, string> InstanceIconRightPathGetter;

		// Token: 0x0401E14C RID: 123212
		private Func<int, bool> CanShowRedDot;

		// Token: 0x0401E14D RID: 123213
		private InstanceDungeonViewModelBase ParentModel;
	}
}
