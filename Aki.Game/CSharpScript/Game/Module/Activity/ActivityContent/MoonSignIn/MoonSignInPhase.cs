using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x02006468 RID: 25704
	internal class MoonSignInPhase : UiPanelBase
	{
		// Token: 0x06040986 RID: 264582 RVA: 0x00FA2D24 File Offset: 0x00FA0F24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040987 RID: 264583 RVA: 0x00FA2DEB File Offset: 0x00FA0FEB
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnClickUndeterminedToggle));
		}

		// Token: 0x06040988 RID: 264584 RVA: 0x00FA2E0C File Offset: 0x00FA100C
		public void RefreshItem(int phaseId)
		{
			PhaseOfMoon? phaseOfMoonById = MoonSignInConfig.Instance.GetPhaseOfMoonById(phaseId);
			if (phaseOfMoonById == null)
			{
				return;
			}
			this.PhaseId = phaseId;
			base.SetTextureShowUntilLoaded(phaseOfMoonById.Value.Texture, base.GetTexture(1), null);
			base.SetTextureShowUntilLoaded(phaseOfMoonById.Value.Texture, base.GetTexture(2), null);
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			bool flag = data.CheckPhaseLock(this.PhaseId);
			base.GetExtendToggle(0).SetToggleState(flag ? EToggleState.ETT_UnDetermined : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06040989 RID: 264585 RVA: 0x00FA2EA4 File Offset: 0x00FA10A4
		public void RefreshItemLockState()
		{
			if (this.PhaseId == 0)
			{
				return;
			}
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			bool flag = data.CheckPhaseLock(this.PhaseId);
			base.GetExtendToggle(0).SetToggleState(flag ? EToggleState.ETT_UnDetermined : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0604098A RID: 264586 RVA: 0x00FA2EED File Offset: 0x00FA10ED
		private void OnClickToggle(EToggleState toggleState)
		{
			this.OnClickUndeterminedToggle();
		}

		// Token: 0x0604098B RID: 264587 RVA: 0x00FA2EF8 File Offset: 0x00FA10F8
		private void OnClickUndeterminedToggle()
		{
			MoonSignInDetailViewOpenData param = new MoonSignInDetailViewOpenData
			{
				MoonId = this.PhaseId
			};
			UiManager.Instance.OpenView(EUiViewName.MoonSignInDetailView, param, null);
		}

		// Token: 0x04021957 RID: 137559
		private int PhaseId;

		// Token: 0x0200C694 RID: 50836
		private class EMoonSignInPhaseDefine
		{
			// Token: 0x0403BF38 RID: 245560
			public const int Toggle = 0;

			// Token: 0x0403BF39 RID: 245561
			public const int Texture = 1;

			// Token: 0x0403BF3A RID: 245562
			public const int DisableTexture = 2;
		}
	}
}
