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
	// Token: 0x02005265 RID: 21093
	public class PinballWeaponTipsTopView : UiPanelBase
	{
		// Token: 0x0603480A RID: 215050 RVA: 0x00EB0B98 File Offset: 0x00EAED98
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

		// Token: 0x0603480B RID: 215051 RVA: 0x00EB0CA1 File Offset: 0x00EAEEA1
		[NullableContext(1)]
		public void Refresh(PinballWeaponData data)
		{
			this.Data = data;
			this.RefreshUi();
		}

		// Token: 0x0603480C RID: 215052 RVA: 0x00EB0CB0 File Offset: 0x00EAEEB0
		public void SetLockToggleShowState(bool bShow)
		{
			this.LockToggleShowState = bShow;
		}

		// Token: 0x0603480D RID: 215053 RVA: 0x00EB0CBC File Offset: 0x00EAEEBC
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

		// Token: 0x0603480E RID: 215054 RVA: 0x00EB0DB4 File Offset: 0x00EAEFB4
		public void RefreshLockToggleShowState()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.RootUIComp.Get().SetUIActive(this.LockToggleShowState);
		}

		// Token: 0x0603480F RID: 215055 RVA: 0x00EB0DE8 File Offset: 0x00EAEFE8
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

		// Token: 0x0401BD94 RID: 114068
		[Nullable(1)]
		private PinballWeaponData Data;

		// Token: 0x0401BD95 RID: 114069
		private bool LockToggleShowState = true;

		// Token: 0x0200AEBB RID: 44731
		private enum EComponent
		{
			// Token: 0x04035FB9 RID: 221113
			TexQuality,
			// Token: 0x04035FBA RID: 221114
			TexWeaponIcon,
			// Token: 0x04035FBB RID: 221115
			TextName,
			// Token: 0x04035FBC RID: 221116
			TextType,
			// Token: 0x04035FBD RID: 221117
			LockToggle
		}
	}
}
