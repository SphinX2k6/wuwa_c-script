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
	// Token: 0x02005868 RID: 22632
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceItem : UiPanelBase
	{
		// Token: 0x06039896 RID: 235670 RVA: 0x00DA9844 File Offset: 0x00DA7A44
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

		// Token: 0x06039897 RID: 235671 RVA: 0x00DA99C1 File Offset: 0x00DA7BC1
		protected override void OnStart()
		{
			this.ExtendToggle = base.GetExtendToggle(0);
			this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			EventSystem.Instance.Add<int>(EEventName.OnChallengeInstanceRedDot, new Action<int>(this.OnChallengeInstanceRedDot));
		}

		// Token: 0x06039898 RID: 235672 RVA: 0x00DA99FC File Offset: 0x00DA7BFC
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnChallengeInstanceRedDot, new Action<int>(this.OnChallengeInstanceRedDot));
		}

		// Token: 0x06039899 RID: 235673 RVA: 0x00DA9A1A File Offset: 0x00DA7C1A
		private void OnChallengeInstanceRedDot(int instanceId)
		{
			if (this.InstanceId != instanceId)
			{
				return;
			}
			this.UpdateRedDot();
		}

		// Token: 0x0603989A RID: 235674 RVA: 0x00DA9A2C File Offset: 0x00DA7C2C
		[NullableContext(1)]
		public UUIText GetTitleText()
		{
			return base.GetText(2);
		}

		// Token: 0x0603989B RID: 235675 RVA: 0x00DA9A38 File Offset: 0x00DA7C38
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

		// Token: 0x0603989C RID: 235676 RVA: 0x00DA9AD4 File Offset: 0x00DA7CD4
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

		// Token: 0x0603989D RID: 235677 RVA: 0x00DA9B58 File Offset: 0x00DA7D58
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

		// Token: 0x0603989E RID: 235678 RVA: 0x00DA9C88 File Offset: 0x00DA7E88
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

		// Token: 0x0603989F RID: 235679 RVA: 0x00DA9CF0 File Offset: 0x00DA7EF0
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

		// Token: 0x060398A0 RID: 235680 RVA: 0x00DA9D44 File Offset: 0x00DA7F44
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

		// Token: 0x060398A1 RID: 235681 RVA: 0x00DA9D7C File Offset: 0x00DA7F7C
		public void BindClickCallback([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<int, UUIExtendToggle, InstanceDetectionDynamicData> onClickCallback)
		{
			this.OnClickCallback = onClickCallback;
		}

		// Token: 0x060398A2 RID: 235682 RVA: 0x00DA9D85 File Offset: 0x00DA7F85
		[NullableContext(1)]
		public void BindCanExecuteChange(Func<int, bool> canExecuteChange)
		{
			this.InstanceCanExecuteChange = canExecuteChange;
		}

		// Token: 0x060398A3 RID: 235683 RVA: 0x00DA9D8E File Offset: 0x00DA7F8E
		private bool CanExecuteChange()
		{
			return this.InstanceCanExecuteChange == null || this.InstanceCanExecuteChange(this.InstanceId);
		}

		// Token: 0x060398A4 RID: 235684 RVA: 0x00DA9DAB File Offset: 0x00DA7FAB
		private void OnClickExtendToggle(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked && this.OnClickCallback != null)
			{
				this.OnClickCallback(this.InstanceId, this.ExtendToggle, null);
			}
		}

		// Token: 0x0401E172 RID: 123250
		public UUIExtendToggle ExtendToggle;

		// Token: 0x0401E173 RID: 123251
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Action<int, UUIExtendToggle, InstanceDetectionDynamicData> OnClickCallback;

		// Token: 0x0401E174 RID: 123252
		private Func<int, bool> InstanceCanExecuteChange;

		// Token: 0x0401E175 RID: 123253
		private int InstanceId;

		// Token: 0x0401E176 RID: 123254
		private InstanceDungeonViewModelBase ParentModel;
	}
}
