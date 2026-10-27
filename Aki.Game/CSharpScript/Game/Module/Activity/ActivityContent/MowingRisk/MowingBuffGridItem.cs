using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063D7 RID: 25559
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MowingBuffGridItem : GridProxyAbstract<IMowingBuffGridItemData>
	{
		// Token: 0x06040499 RID: 263321 RVA: 0x00F8C310 File Offset: 0x00F8A510
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604049A RID: 263322 RVA: 0x00F8C4C0 File Offset: 0x00F8A6C0
		protected override UniTask OnBeforeStartAsync()
		{
			MowingBuffGridItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingBuffGridItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604049B RID: 263323 RVA: 0x00F8C503 File Offset: 0x00F8A703
		protected override void OnStart()
		{
			base.GetExtendToggle(6).CanExecuteChange.Bind(new Func<bool>(this.HandleCanExecuteChange));
		}

		// Token: 0x0604049C RID: 263324 RVA: 0x00F8C522 File Offset: 0x00F8A722
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(6).CanExecuteChange.Unbind();
		}

		// Token: 0x0604049D RID: 263325 RVA: 0x00F8C538 File Offset: 0x00F8A738
		public override void Refresh(IMowingBuffGridItemData data, bool isSelected, int gridIndex)
		{
			this.PassData = data;
			this.SetSpriteByPath(data.QualityPath, base.GetSprite(0), false, null, null);
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(data.IconPath != null);
			}
			if (!string.IsNullOrEmpty(data.IconPath))
			{
				base.SetTextureByPath(data.IconPath, texture, null, null);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.NameTextId, Array.Empty<object>());
			base.GetSprite(3).SetUIActive(data.IsShowBackground);
			base.GetItem(5).SetUIActive(false);
			base.GetExtendToggle(6).SetToggleStateForce(data.IsChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			base.GetItem(4).SetUIActive(true);
			UiPanelBase lockPanel = this.LockPanel;
			if (lockPanel != null)
			{
				lockPanel.SetUiActive(!data.IsUnlock);
			}
			MowingBuffLevelPanel levelPanel = this.LevelPanel;
			if (levelPanel != null)
			{
				levelPanel.SetUiActive(data.LevelContent != null);
			}
			MowingBuffLevelPanel levelPanel2 = this.LevelPanel;
			if (levelPanel2 != null)
			{
				levelPanel2.RefreshByLevelContent(data.LevelContent);
			}
			base.GetItem(7).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
		}

		// Token: 0x0604049E RID: 263326 RVA: 0x00F8C691 File Offset: 0x00F8A891
		private void OnClick(EToggleState _)
		{
			MowingRiskModel.Instance.CurrentChosenOverviewBuffId = new int?(this.PassData.BuffId);
			EventSystem.Instance.Emit(EEventName.MowingBasicBuffGridItemClick);
		}

		// Token: 0x0604049F RID: 263327 RVA: 0x00F8C6BD File Offset: 0x00F8A8BD
		private bool HandleCanExecuteChange()
		{
			return !this.PassData.IsChosen;
		}

		// Token: 0x060404A0 RID: 263328 RVA: 0x00F8C6CD File Offset: 0x00F8A8CD
		public bool CheckNeedPlayUnlockSequence()
		{
			return !MowingRiskModel.Instance.HasBuffIdRecord(this.PassData.BuffId);
		}

		// Token: 0x060404A1 RID: 263329 RVA: 0x00F8C6E8 File Offset: 0x00F8A8E8
		public void PlayUnlockEffect()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			instance.RecordBuffId(this.PassData.BuffId);
			EMowingBuffType? buffTypeByBuffId = instance.GetBuffTypeByBuffId(this.PassData.BuffId);
			int? num = null;
			if (buffTypeByBuffId != null)
			{
				switch (buffTypeByBuffId.GetValueOrDefault())
				{
				case EMowingBuffType.BasicLow:
					num = new int?(7);
					break;
				case EMowingBuffType.BasicHigh:
					num = new int?(8);
					break;
				case EMowingBuffType.Super:
					num = new int?(9);
					break;
				}
			}
			if (num != null)
			{
				base.GetItem(num.Value).SetUIActive(true);
			}
		}

		// Token: 0x04021746 RID: 137030
		private IMowingBuffGridItemData PassData;

		// Token: 0x04021747 RID: 137031
		[Nullable(2)]
		private UiPanelBase LockPanel;

		// Token: 0x04021748 RID: 137032
		[Nullable(2)]
		private MowingBuffLevelPanel LevelPanel;

		// Token: 0x0200C5D6 RID: 50646
		[NullableContext(0)]
		private class EItemComponent
		{
			// Token: 0x0403BBB2 RID: 244658
			public const int QualitySprite = 0;

			// Token: 0x0403BBB3 RID: 244659
			public const int ItemTexture = 1;

			// Token: 0x0403BBB4 RID: 244660
			public const int BottomText = 2;

			// Token: 0x0403BBB5 RID: 244661
			public const int BgSprite = 3;

			// Token: 0x0403BBB6 RID: 244662
			public const int TopAdditionItem = 4;

			// Token: 0x0403BBB7 RID: 244663
			public const int BottomAdditionItem = 5;

			// Token: 0x0403BBB8 RID: 244664
			public const int ExtendToggle = 6;

			// Token: 0x0403BBB9 RID: 244665
			public const int UnlockBlueEffectItem = 7;

			// Token: 0x0403BBBA RID: 244666
			public const int UnlockPurpleEffectItem = 8;

			// Token: 0x0403BBBB RID: 244667
			public const int UnlockGoldEffectItem = 9;
		}
	}
}
