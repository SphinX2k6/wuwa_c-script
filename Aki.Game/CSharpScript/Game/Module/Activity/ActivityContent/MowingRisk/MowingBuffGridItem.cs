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
	// Token: 0x02005355 RID: 21333
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MowingBuffGridItem : GridProxyAbstract<IMowingBuffGridItemData>
	{
		// Token: 0x0603515A RID: 217434 RVA: 0x00ED32A8 File Offset: 0x00ED14A8
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

		// Token: 0x0603515B RID: 217435 RVA: 0x00ED3458 File Offset: 0x00ED1658
		protected override UniTask OnBeforeStartAsync()
		{
			MowingBuffGridItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingBuffGridItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603515C RID: 217436 RVA: 0x00ED349B File Offset: 0x00ED169B
		protected override void OnStart()
		{
			base.GetExtendToggle(6).CanExecuteChange.Bind(new Func<bool>(this.HandleCanExecuteChange));
		}

		// Token: 0x0603515D RID: 217437 RVA: 0x00ED34BA File Offset: 0x00ED16BA
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(6).CanExecuteChange.Unbind();
		}

		// Token: 0x0603515E RID: 217438 RVA: 0x00ED34D0 File Offset: 0x00ED16D0
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

		// Token: 0x0603515F RID: 217439 RVA: 0x00ED3629 File Offset: 0x00ED1829
		private void OnClick(EToggleState _)
		{
			MowingRiskModel.Instance.CurrentChosenOverviewBuffId = new int?(this.PassData.BuffId);
			EventSystem.Instance.Emit(EEventName.MowingBasicBuffGridItemClick);
		}

		// Token: 0x06035160 RID: 217440 RVA: 0x00ED3655 File Offset: 0x00ED1855
		private bool HandleCanExecuteChange()
		{
			return !this.PassData.IsChosen;
		}

		// Token: 0x06035161 RID: 217441 RVA: 0x00ED3665 File Offset: 0x00ED1865
		public bool CheckNeedPlayUnlockSequence()
		{
			return !MowingRiskModel.Instance.HasBuffIdRecord(this.PassData.BuffId);
		}

		// Token: 0x06035162 RID: 217442 RVA: 0x00ED3680 File Offset: 0x00ED1880
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

		// Token: 0x0401C075 RID: 114805
		private IMowingBuffGridItemData PassData;

		// Token: 0x0401C076 RID: 114806
		[Nullable(2)]
		private UiPanelBase LockPanel;

		// Token: 0x0401C077 RID: 114807
		[Nullable(2)]
		private MowingBuffLevelPanel LevelPanel;

		// Token: 0x0200AFBD RID: 44989
		[NullableContext(0)]
		private class EItemComponent
		{
			// Token: 0x04036511 RID: 222481
			public const int QualitySprite = 0;

			// Token: 0x04036512 RID: 222482
			public const int ItemTexture = 1;

			// Token: 0x04036513 RID: 222483
			public const int BottomText = 2;

			// Token: 0x04036514 RID: 222484
			public const int BgSprite = 3;

			// Token: 0x04036515 RID: 222485
			public const int TopAdditionItem = 4;

			// Token: 0x04036516 RID: 222486
			public const int BottomAdditionItem = 5;

			// Token: 0x04036517 RID: 222487
			public const int ExtendToggle = 6;

			// Token: 0x04036518 RID: 222488
			public const int UnlockBlueEffectItem = 7;

			// Token: 0x04036519 RID: 222489
			public const int UnlockPurpleEffectItem = 8;

			// Token: 0x0403651A RID: 222490
			public const int UnlockGoldEffectItem = 9;
		}
	}
}
