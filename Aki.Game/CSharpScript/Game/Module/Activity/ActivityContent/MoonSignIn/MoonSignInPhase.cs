using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x020053E6 RID: 21478
	internal class MoonSignInPhase : UiPanelBase
	{
		// Token: 0x06035647 RID: 218695 RVA: 0x00EE9CA0 File Offset: 0x00EE7EA0
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

		// Token: 0x06035648 RID: 218696 RVA: 0x00EE9D67 File Offset: 0x00EE7F67
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnClickUndeterminedToggle));
		}

		// Token: 0x06035649 RID: 218697 RVA: 0x00EE9D88 File Offset: 0x00EE7F88
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

		// Token: 0x0603564A RID: 218698 RVA: 0x00EE9E20 File Offset: 0x00EE8020
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

		// Token: 0x0603564B RID: 218699 RVA: 0x00EE9E69 File Offset: 0x00EE8069
		private void OnClickToggle(EToggleState toggleState)
		{
			this.OnClickUndeterminedToggle();
		}

		// Token: 0x0603564C RID: 218700 RVA: 0x00EE9E74 File Offset: 0x00EE8074
		private void OnClickUndeterminedToggle()
		{
			MoonSignInDetailViewOpenData param = new MoonSignInDetailViewOpenData
			{
				MoonId = this.PhaseId
			};
			UiManager.Instance.OpenView(EUiViewName.MoonSignInDetailView, param, null);
		}

		// Token: 0x0401C286 RID: 115334
		private int PhaseId;

		// Token: 0x0200B07A RID: 45178
		private class EMoonSignInPhaseDefine
		{
			// Token: 0x04036893 RID: 223379
			public const int Toggle = 0;

			// Token: 0x04036894 RID: 223380
			public const int Texture = 1;

			// Token: 0x04036895 RID: 223381
			public const int DisableTexture = 2;
		}
	}
}
