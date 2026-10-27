using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062E7 RID: 25319
	public class PinballWeaponTipsTopView : UiPanelBase
	{
		// Token: 0x0603FB49 RID: 260937 RVA: 0x00F69C3C File Offset: 0x00F67E3C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClickLockToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FB4A RID: 260938 RVA: 0x00F69D45 File Offset: 0x00F67F45
		[NullableContext(1)]
		public void Refresh(PinballWeaponData data)
		{
			this.Data = data;
			this.RefreshUi();
		}

		// Token: 0x0603FB4B RID: 260939 RVA: 0x00F69D54 File Offset: 0x00F67F54
		public void SetLockToggleShowState(bool bShow)
		{
			this.LockToggleShowState = bShow;
		}

		// Token: 0x0603FB4C RID: 260940 RVA: 0x00F69D60 File Offset: 0x00F67F60
		private void RefreshUi()
		{
			if (this.Data == null)
			{
				return;
			}
			this.RefreshLockToggleShowState();
			PinballWeaponQuality? pinballWeaponQuality;
			base.TrySetTextureByPath((PinballConfig.Instance.GetPinballWeaponQualityConfigById(this.Data.Quality) != null) ? pinballWeaponQuality.GetValueOrDefault().TexQuality : null, base.GetTexture(0), null, null);
			base.TrySetTextureByPath(this.Data.Icon, base.GetTexture(1), null, null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), this.Data.Name, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), PinballConfig.Instance.GetPinballWeaponTypeName(this.Data.Type), Array.Empty<object>());
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(this.Data.GetIsLock() ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603FB4D RID: 260941 RVA: 0x00F69E58 File Offset: 0x00F68058
		public void RefreshLockToggleShowState()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.RootUIComp.Get().SetUIActive(this.LockToggleShowState);
		}

		// Token: 0x0603FB4E RID: 260942 RVA: 0x00F69E8C File Offset: 0x00F6808C
		private void OnClickLockToggle(EToggleState state)
		{
			if (this.Data == null)
			{
				Log.Instance.Error(ELogModule.PinballBattle, ELogAuthor.CB, "锁定武器失败，武器数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			PinballController pinballController = ActivityManager.GetActivityController(ActivityType.PinballActivity) as PinballController;
			bool bLock = state == EToggleState.ETT_UnChecked;
			pinballController.RequestWeaponLock(this.Data.IncId, bLock);
		}

		// Token: 0x04021465 RID: 136293
		[Nullable(1)]
		private PinballWeaponData Data;

		// Token: 0x04021466 RID: 136294
		private bool LockToggleShowState = true;

		// Token: 0x0200C4D4 RID: 50388
		private enum EComponent
		{
			// Token: 0x0403B657 RID: 243287
			TexQuality,
			// Token: 0x0403B658 RID: 243288
			TexWeaponIcon,
			// Token: 0x0403B659 RID: 243289
			TextName,
			// Token: 0x0403B65A RID: 243290
			TextType,
			// Token: 0x0403B65B RID: 243291
			LockToggle
		}
	}
}
