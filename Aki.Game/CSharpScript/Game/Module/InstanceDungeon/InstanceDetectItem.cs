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
	// Token: 0x0200483C RID: 18492
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDetectItem : UiPanelBase, IDynamicScrollItem<InstanceDetectionDynamicData>
	{
		// Token: 0x0602E782 RID: 190338 RVA: 0x00CF73A0 File Offset: 0x00CF55A0
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

		// Token: 0x0602E783 RID: 190339 RVA: 0x00CF73EC File Offset: 0x00CF55EC
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

		// Token: 0x0602E784 RID: 190340 RVA: 0x00CF74CC File Offset: 0x00CF56CC
		private UniTask InitChildItem()
		{
			InstanceDetectItem.<InitChildItem>d__16 <InitChildItem>d__;
			<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitChildItem>d__.<>4__this = this;
			<InitChildItem>d__.<>1__state = -1;
			<InitChildItem>d__.<>t__builder.Start<InstanceDetectItem.<InitChildItem>d__16>(ref <InitChildItem>d__);
			return <InitChildItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602E785 RID: 190341 RVA: 0x00CF7510 File Offset: 0x00CF5710
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

		// Token: 0x0602E786 RID: 190342 RVA: 0x00CF7590 File Offset: 0x00CF5790
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

		// Token: 0x0602E787 RID: 190343 RVA: 0x00CF7704 File Offset: 0x00CF5904
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

		// Token: 0x0602E788 RID: 190344 RVA: 0x00CF777C File Offset: 0x00CF597C
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

		// Token: 0x0602E789 RID: 190345 RVA: 0x00CF782C File Offset: 0x00CF5A2C
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

		// Token: 0x0602E78A RID: 190346 RVA: 0x00CF78A4 File Offset: 0x00CF5AA4
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

		// Token: 0x0602E78B RID: 190347 RVA: 0x00CF7914 File Offset: 0x00CF5B14
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

		// Token: 0x0602E78C RID: 190348 RVA: 0x00CF7974 File Offset: 0x00CF5B74
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

		// Token: 0x0602E78D RID: 190349 RVA: 0x00CF79D7 File Offset: 0x00CF5BD7
		[NullableContext(1)]
		public void BindClickSeriesCallback(Action<int, UUIExtendToggle, bool> onClickCallback)
		{
			this.OnSeriesCallback = onClickCallback;
		}

		// Token: 0x0602E78E RID: 190350 RVA: 0x00CF79E0 File Offset: 0x00CF5BE0
		public void BindClickInstanceCallback([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<int, UUIExtendToggle, InstanceDetectionDynamicData> onClickCallback)
		{
			this.OnInstanceCallback = onClickCallback;
		}

		// Token: 0x0602E78F RID: 190351 RVA: 0x00CF79E9 File Offset: 0x00CF5BE9
		[NullableContext(1)]
		public void BindCanExecuteChange(Func<int, bool> canExecuteChange)
		{
			this.InstanceCanExecuteChange = canExecuteChange;
		}

		// Token: 0x0602E790 RID: 190352 RVA: 0x00CF79F2 File Offset: 0x00CF5BF2
		public void BindSubtitleTextIdGetter(TInstanceSubtitleTextIdGetter getter)
		{
			this.InstanceSubtitleTextIdGetter = getter;
		}

		// Token: 0x0602E791 RID: 190353 RVA: 0x00CF79FB File Offset: 0x00CF5BFB
		public void BindSubtitleArgsGetter(TInstanceSubtitleArgsGetter getter)
		{
			this.InstanceSubtitleArgsGetter = getter;
		}

		// Token: 0x0602E792 RID: 190354 RVA: 0x00CF7A04 File Offset: 0x00CF5C04
		public void BindInstanceCheckFinishedGetter(TInstanceCheckFinishedGetter getter)
		{
			this.InstanceCheckFinishedGetter = getter;
		}

		// Token: 0x0602E793 RID: 190355 RVA: 0x00CF7A0D File Offset: 0x00CF5C0D
		[NullableContext(1)]
		public void BindCanShowRedDot(Func<int, bool> getter)
		{
			this.CanShowRedDot = getter;
		}

		// Token: 0x0602E794 RID: 190356 RVA: 0x00CF7A16 File Offset: 0x00CF5C16
		public void BindIconRightPathGetter(Func<int, string> getter)
		{
			this.InstanceIconRightPathGetter = getter;
		}

		// Token: 0x0602E795 RID: 190357 RVA: 0x00CF7A1F File Offset: 0x00CF5C1F
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0602E796 RID: 190358 RVA: 0x00CF7A28 File Offset: 0x00CF5C28
		public UUIExtendToggle GetExtendToggleForGuide()
		{
			if (!this.InstanceItem.GetActive())
			{
				Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "聚焦引导索引到了副本标题, 检查extraParam字段是否配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return this.InstanceItem.ExtendToggle;
		}

		// Token: 0x17005E28 RID: 24104
		// (get) Token: 0x0602E797 RID: 190359 RVA: 0x00CF7A6B File Offset: 0x00CF5C6B
		public int InstanceId
		{
			get
			{
				return this.Data.InstanceGirdId;
			}
		}

		// Token: 0x04018BDD RID: 101341
		protected InstanceDetectionDynamicData Data;

		// Token: 0x04018BDE RID: 101342
		private InstanceSeriesItem InstanceSeriesItem;

		// Token: 0x04018BDF RID: 101343
		private InstanceItem InstanceItem;

		// Token: 0x04018BE0 RID: 101344
		private InstanceSeriesItem LockInstanceSeriesItem;

		// Token: 0x04018BE1 RID: 101345
		private InstanceItem LockInstanceItem;

		// Token: 0x04018BE2 RID: 101346
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<int, UUIExtendToggle, bool> OnSeriesCallback;

		// Token: 0x04018BE3 RID: 101347
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Action<int, UUIExtendToggle, InstanceDetectionDynamicData> OnInstanceCallback;

		// Token: 0x04018BE4 RID: 101348
		private Func<int, bool> InstanceCanExecuteChange;

		// Token: 0x04018BE5 RID: 101349
		private TInstanceSubtitleTextIdGetter InstanceSubtitleTextIdGetter;

		// Token: 0x04018BE6 RID: 101350
		private TInstanceSubtitleArgsGetter InstanceSubtitleArgsGetter;

		// Token: 0x04018BE7 RID: 101351
		private TInstanceCheckFinishedGetter InstanceCheckFinishedGetter;

		// Token: 0x04018BE8 RID: 101352
		private Func<int, string> InstanceIconRightPathGetter;

		// Token: 0x04018BE9 RID: 101353
		private Func<int, bool> CanShowRedDot;

		// Token: 0x04018BEA RID: 101354
		private InstanceDungeonViewModelBase ParentModel;
	}
}
