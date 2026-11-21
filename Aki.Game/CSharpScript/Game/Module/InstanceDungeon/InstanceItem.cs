using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004840 RID: 18496
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceItem : UiPanelBase
	{
		// Token: 0x0602E7B3 RID: 190387 RVA: 0x00CF856C File Offset: 0x00CF676C
		protected unsafe override void OnRegisterComponent()
		{
			this.ParentModel = (this.OpenParam as InstanceDungeonViewModelBase);
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggleTextureTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickExtendToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602E7B4 RID: 190388 RVA: 0x00CF86E9 File Offset: 0x00CF68E9
		protected override void OnStart()
		{
			this.ExtendToggle = base.GetExtendToggle(0);
			this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			EventSystem.Instance.Add<int>(EEventName.OnChallengeInstanceRedDot, new Action<int>(this.OnChallengeInstanceRedDot));
		}

		// Token: 0x0602E7B5 RID: 190389 RVA: 0x00CF8724 File Offset: 0x00CF6924
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnChallengeInstanceRedDot, new Action<int>(this.OnChallengeInstanceRedDot));
		}

		// Token: 0x0602E7B6 RID: 190390 RVA: 0x00CF8742 File Offset: 0x00CF6942
		private void OnChallengeInstanceRedDot(int instanceId)
		{
			if (this.InstanceId != instanceId)
			{
				return;
			}
			this.UpdateRedDot();
		}

		// Token: 0x0602E7B7 RID: 190391 RVA: 0x00CF8754 File Offset: 0x00CF6954
		[NullableContext(1)]
		public UUIText GetTitleText()
		{
			return base.GetText(2);
		}

		// Token: 0x0602E7B8 RID: 190392 RVA: 0x00CF8760 File Offset: 0x00CF6960
		public void Update(int data, bool isSelect, bool isShow)
		{
			this.InstanceId = data;
			this.ExtendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			this.ExtendToggle.CanExecuteChange.Unbind();
			this.ExtendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
			if (isSelect && this.OnClickCallback != null)
			{
				this.OnClickCallback(this.InstanceId, this.ExtendToggle, null);
			}
			if (!isShow)
			{
				return;
			}
			this.UpdateLockOrFirstReward();
			this.UpdateLevel();
			this.UpdateIcon();
			this.UpdateTextureTransition();
			this.UpdateRedDot();
		}

		// Token: 0x0602E7B9 RID: 190393 RVA: 0x00CF87FC File Offset: 0x00CF69FC
		private void UpdateLockOrFirstReward()
		{
			if (InstanceDungeonEntranceController.Instance.GetInstanceItemLockStateGetter(this.InstanceId))
			{
				base.GetItem(3).SetUIActive(true);
				base.GetItem(4).SetUIActive(false);
				return;
			}
			if (this.ParentModel.IsFinishInstance(this.InstanceId))
			{
				base.GetItem(3).SetUIActive(false);
				base.GetItem(4).SetUIActive(true);
				return;
			}
			base.GetItem(3).SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0602E7BA RID: 190394 RVA: 0x00CF8880 File Offset: 0x00CF6A80
		private void UpdateLevel()
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(this.InstanceId);
			int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(this.InstanceId, WorldLevelModel.Instance.CurWorldLevel);
			Dictionary<int, string> dictionary = config.Value.SubTitle();
			if (dictionary == null || dictionary.Count <= 0)
			{
				LguiUtil.Instance.SetLocalText(base.GetText(2), "InstanceDungeonRecommendLevel", new <>z__ReadOnlySingleElementList<object>(recommendLevel));
				return;
			}
			int? num = null;
			string textStringId = null;
			foreach (KeyValuePair<int, string> keyValuePair in dictionary)
			{
				int num2;
				string text;
				keyValuePair.Deconstruct(out num2, out text);
				int value = num2;
				string text2 = text;
				num = new int?(value);
				textStringId = text2;
			}
			if (num.GetValueOrDefault() == 1)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, Array.Empty<object>());
				return;
			}
			if (num.GetValueOrDefault() == 2)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RecommendLevel", new <>z__ReadOnlySingleElementList<object>(recommendLevel));
			}
		}

		// Token: 0x0602E7BB RID: 190395 RVA: 0x00CF89B0 File Offset: 0x00CF6BB0
		private void UpdateIcon()
		{
			string instanceDetectItemIcon = this.ParentModel.GetInstanceDetectItemIcon(this.InstanceId);
			if (!string.IsNullOrWhiteSpace(instanceDetectItemIcon))
			{
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				base.SetTextureByPath(instanceDetectItemIcon, base.GetTexture(1), null, null);
				return;
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0602E7BC RID: 190396 RVA: 0x00CF8A18 File Offset: 0x00CF6C18
		private void UpdateTextureTransition()
		{
			InstanceDungeonViewModelBase parentModel = this.ParentModel;
			string text = ((parentModel != null) ? parentModel.GetInstanceItemTextureBg(this.InstanceId) : null) ?? "";
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
			base.SetExtendToggleTextureTransitionByPath(resourcePath, base.GetUiExtendToggleTextureTransition(5), EToggleTransitionState.ETT_UnCheckedUnHover);
		}

		// Token: 0x0602E7BD RID: 190397 RVA: 0x00CF8A6C File Offset: 0x00CF6C6C
		private void UpdateRedDot()
		{
			InstanceDungeonViewModelBase parentModel = this.ParentModel;
			bool uiactive = parentModel != null && parentModel.CheckInstanceItemHasRedDot(this.InstanceId);
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0602E7BE RID: 190398 RVA: 0x00CF8AA4 File Offset: 0x00CF6CA4
		public void BindClickCallback([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<int, UUIExtendToggle, InstanceDetectionDynamicData> onClickCallback)
		{
			this.OnClickCallback = onClickCallback;
		}

		// Token: 0x0602E7BF RID: 190399 RVA: 0x00CF8AAD File Offset: 0x00CF6CAD
		[NullableContext(1)]
		public void BindCanExecuteChange(Func<int, bool> canExecuteChange)
		{
			this.InstanceCanExecuteChange = canExecuteChange;
		}

		// Token: 0x0602E7C0 RID: 190400 RVA: 0x00CF8AB6 File Offset: 0x00CF6CB6
		private bool CanExecuteChange()
		{
			return this.InstanceCanExecuteChange == null || this.InstanceCanExecuteChange(this.InstanceId);
		}

		// Token: 0x0602E7C1 RID: 190401 RVA: 0x00CF8AD3 File Offset: 0x00CF6CD3
		private void OnClickExtendToggle(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked && this.OnClickCallback != null)
			{
				this.OnClickCallback(this.InstanceId, this.ExtendToggle, null);
			}
		}

		// Token: 0x04018C0F RID: 101391
		public UUIExtendToggle ExtendToggle;

		// Token: 0x04018C10 RID: 101392
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Action<int, UUIExtendToggle, InstanceDetectionDynamicData> OnClickCallback;

		// Token: 0x04018C11 RID: 101393
		private Func<int, bool> InstanceCanExecuteChange;

		// Token: 0x04018C12 RID: 101394
		private int InstanceId;

		// Token: 0x04018C13 RID: 101395
		private InstanceDungeonViewModelBase ParentModel;
	}
}
