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
	// Token: 0x0200535C RID: 21340
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffUnit : UiPanelBase
	{
		// Token: 0x06035196 RID: 217494 RVA: 0x00ED471C File Offset: 0x00ED291C
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

		// Token: 0x06035197 RID: 217495 RVA: 0x00ED4888 File Offset: 0x00ED2A88
		protected override void OnStart()
		{
			this.Player = new UiSequencePlayer(this.RootItem);
			base.GetExtendToggle(6).CanExecuteChange.Bind(new Func<bool>(this.HandleCanExecuteChange));
		}

		// Token: 0x06035198 RID: 217496 RVA: 0x00ED48B8 File Offset: 0x00ED2AB8
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(6).CanExecuteChange.Unbind();
		}

		// Token: 0x06035199 RID: 217497 RVA: 0x00ED48CC File Offset: 0x00ED2ACC
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

		// Token: 0x0603519A RID: 217498 RVA: 0x00ED498C File Offset: 0x00ED2B8C
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

		// Token: 0x0603519B RID: 217499 RVA: 0x00ED49F3 File Offset: 0x00ED2BF3
		public void PlayUnlockSequence()
		{
			base.GetItem(7).SetUIActive(true);
			this.UpdateUnlockState(true);
			this.Player.LitePlayAsync("Unlock", true, false).Forget<bool>();
		}

		// Token: 0x0603519C RID: 217500 RVA: 0x00ED4A20 File Offset: 0x00ED2C20
		private void HandleOnClick(EToggleState toggleState)
		{
			MowingRiskModel.Instance.CurrentChosenProgressIndex = new int?(this.PassData.Index);
			EventSystem.Instance.Emit(EEventName.MowingSuperBuffGridItemClick);
		}

		// Token: 0x0603519D RID: 217501 RVA: 0x00ED4A4C File Offset: 0x00ED2C4C
		private bool HandleCanExecuteChange()
		{
			return !this.PassData.IsChosen;
		}

		// Token: 0x0401C08B RID: 114827
		private const float GRAY_ALPHA = 0.85f;

		// Token: 0x0401C08C RID: 114828
		private IMowingBuffUnitData PassData;

		// Token: 0x0401C08D RID: 114829
		private UiSequencePlayer Player;

		// Token: 0x0200AFD1 RID: 45009
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403657A RID: 222586
			public const int StarSprite = 0;

			// Token: 0x0403657B RID: 222587
			public const int ActiveItem = 1;

			// Token: 0x0403657C RID: 222588
			public const int InactiveItem = 2;

			// Token: 0x0403657D RID: 222589
			public const int IconTexture = 3;

			// Token: 0x0403657E RID: 222590
			public const int NameText = 4;

			// Token: 0x0403657F RID: 222591
			public const int CountText = 5;

			// Token: 0x04036580 RID: 222592
			public const int BuffToggle = 6;

			// Token: 0x04036581 RID: 222593
			public const int UnlockAnimItem = 7;
		}
	}
}
