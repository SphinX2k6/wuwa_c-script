using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063DE RID: 25566
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffUnit : UiPanelBase
	{
		// Token: 0x060404D5 RID: 263381 RVA: 0x00F8D784 File Offset: 0x00F8B984
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.HandleOnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060404D6 RID: 263382 RVA: 0x00F8D8F0 File Offset: 0x00F8BAF0
		protected override void OnStart()
		{
			this.Player = new UiSequencePlayer(this.RootItem);
			base.GetExtendToggle(6).CanExecuteChange.Bind(new Func<bool>(this.HandleCanExecuteChange));
		}

		// Token: 0x060404D7 RID: 263383 RVA: 0x00F8D920 File Offset: 0x00F8BB20
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(6).CanExecuteChange.Unbind();
		}

		// Token: 0x060404D8 RID: 263384 RVA: 0x00F8D934 File Offset: 0x00F8BB34
		public void RefreshByCustomData(IMowingBuffUnitData data)
		{
			this.PassData = data;
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(data.IconPath != null);
			}
			if (!string.IsNullOrEmpty(data.IconPath))
			{
				base.SetTextureByPath(data.IconPath, texture, null, null);
			}
			this.UpdateUnlockState(data.IsActive);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.NameTextId, Array.Empty<object>());
			base.GetText(5).SetText(data.ThresholdCount.ToString(), true);
			base.GetExtendToggle(6).SetToggleStateForce(data.IsChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x060404D9 RID: 263385 RVA: 0x00F8D9F4 File Offset: 0x00F8BBF4
		public void UpdateUnlockState(bool isUnlock)
		{
			base.GetSprite(0).SetUIActive(isUnlock);
			base.GetItem(1).SetUIActive(isUnlock);
			base.GetItem(2).SetUIActive(!isUnlock);
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetIsGray(!isUnlock);
			}
			if (texture == null)
			{
				return;
			}
			texture.SetAlpha(isUnlock ? 1f : 0.85f);
		}

		// Token: 0x060404DA RID: 263386 RVA: 0x00F8DA5B File Offset: 0x00F8BC5B
		public void PlayUnlockSequence()
		{
			base.GetItem(7).SetUIActive(true);
			this.UpdateUnlockState(true);
			this.Player.LitePlayAsync("Unlock", true, false).Forget<bool>();
		}

		// Token: 0x060404DB RID: 263387 RVA: 0x00F8DA88 File Offset: 0x00F8BC88
		private void HandleOnClick(EToggleState toggleState)
		{
			MowingRiskModel.Instance.CurrentChosenProgressIndex = new int?(this.PassData.Index);
			EventSystem.Instance.Emit(EEventName.MowingSuperBuffGridItemClick);
		}

		// Token: 0x060404DC RID: 263388 RVA: 0x00F8DAB4 File Offset: 0x00F8BCB4
		private bool HandleCanExecuteChange()
		{
			return !this.PassData.IsChosen;
		}

		// Token: 0x0402175C RID: 137052
		private const float GRAY_ALPHA = 0.85f;

		// Token: 0x0402175D RID: 137053
		private IMowingBuffUnitData PassData;

		// Token: 0x0402175E RID: 137054
		private UiSequencePlayer Player;

		// Token: 0x0200C5EA RID: 50666
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BC1B RID: 244763
			public const int StarSprite = 0;

			// Token: 0x0403BC1C RID: 244764
			public const int ActiveItem = 1;

			// Token: 0x0403BC1D RID: 244765
			public const int InactiveItem = 2;

			// Token: 0x0403BC1E RID: 244766
			public const int IconTexture = 3;

			// Token: 0x0403BC1F RID: 244767
			public const int NameText = 4;

			// Token: 0x0403BC20 RID: 244768
			public const int CountText = 5;

			// Token: 0x0403BC21 RID: 244769
			public const int BuffToggle = 6;

			// Token: 0x0403BC22 RID: 244770
			public const int UnlockAnimItem = 7;
		}
	}
}
