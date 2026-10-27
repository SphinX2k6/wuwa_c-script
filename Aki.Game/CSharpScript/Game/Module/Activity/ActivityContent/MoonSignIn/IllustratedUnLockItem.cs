using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x02006463 RID: 25699
	internal class IllustratedUnLockItem : UiPanelBase
	{
		// Token: 0x0604095D RID: 264541 RVA: 0x00FA1A50 File Offset: 0x00F9FC50
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickShareBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickBuffBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickBuffTipsCloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604095E RID: 264542 RVA: 0x00FA1CF4 File Offset: 0x00F9FEF4
		protected override void OnStart()
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
			UUIItem item = base.GetItem(13);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(15);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x0604095F RID: 264543 RVA: 0x00FA1D50 File Offset: 0x00F9FF50
		public void RefreshItem(int moonId)
		{
			PhaseOfMoon? phaseOfMoonById = MoonSignInConfig.Instance.GetPhaseOfMoonById(moonId);
			if (phaseOfMoonById == null)
			{
				return;
			}
			PhaseOfMoon value = phaseOfMoonById.Value;
			MoonSignInData data = MoonSignInController.Instance.GetData();
			MoonPhaseSelect moonPhaseSelect = (data != null) ? data.GetMoonPhaseSelect(moonId) : null;
			if (moonPhaseSelect == null)
			{
				return;
			}
			base.SetTextureByPath(value.Texture, base.GetTexture(0), null, null);
			base.SetTextureByPath(value.BuffTexture, base.GetTexture(9), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.MoonName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), value.BuffName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), value.MoonDes, Array.Empty<object>());
			MoonLabel? moonLabelById = MoonSignInConfig.Instance.GetMoonLabelById(moonPhaseSelect.Label1);
			MoonLabel? moonLabelById2 = MoonSignInConfig.Instance.GetMoonLabelById(moonPhaseSelect.Label2);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), ((moonLabelById != null) ? moonLabelById.GetValueOrDefault().MoonLabelName : null) ?? string.Empty, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), ((moonLabelById2 != null) ? moonLabelById2.GetValueOrDefault().MoonLabelName : null) ?? string.Empty, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), ((moonLabelById != null) ? moonLabelById.GetValueOrDefault().MoonText1 : null) ?? string.Empty, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), ((moonLabelById2 != null) ? moonLabelById2.GetValueOrDefault().MoonText2 : null) ?? string.Empty, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), value.BuffDes, Array.Empty<object>());
		}

		// Token: 0x06040960 RID: 264544 RVA: 0x00FA1F5B File Offset: 0x00FA015B
		private void OnClickShareBtn()
		{
			this.OpenShareView();
		}

		// Token: 0x06040961 RID: 264545 RVA: 0x00FA1F64 File Offset: 0x00FA0164
		private void OpenShareView()
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
			Action<bool> setNextAndBackBtnUiActive = this.SetNextAndBackBtnUiActive;
			if (setNextAndBackBtnUiActive != null)
			{
				setNextAndBackBtnUiActive(false);
			}
			UiAsyncTask task = new UiAsyncTask("OpenShareView", delegate()
			{
				IllustratedUnLockItem.<<OpenShareView>b__6_0>d <<OpenShareView>b__6_0>d;
				<<OpenShareView>b__6_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OpenShareView>b__6_0>d.<>4__this = this;
				<<OpenShareView>b__6_0>d.<>1__state = -1;
				<<OpenShareView>b__6_0>d.<>t__builder.Start<IllustratedUnLockItem.<<OpenShareView>b__6_0>d>(ref <<OpenShareView>b__6_0>d);
				return <<OpenShareView>b__6_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x06040962 RID: 264546 RVA: 0x00FA1FC4 File Offset: 0x00FA01C4
		private UniTask OpenShareViewAsync()
		{
			IllustratedUnLockItem.<OpenShareViewAsync>d__7 <OpenShareViewAsync>d__;
			<OpenShareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenShareViewAsync>d__.<>4__this = this;
			<OpenShareViewAsync>d__.<>1__state = -1;
			<OpenShareViewAsync>d__.<>t__builder.Start<IllustratedUnLockItem.<OpenShareViewAsync>d__7>(ref <OpenShareViewAsync>d__);
			return <OpenShareViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040963 RID: 264547 RVA: 0x00FA2008 File Offset: 0x00FA0208
		private UniTask WaitFrame()
		{
			IllustratedUnLockItem.<WaitFrame>d__8 <WaitFrame>d__;
			<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitFrame>d__.<>1__state = -1;
			<WaitFrame>d__.<>t__builder.Start<IllustratedUnLockItem.<WaitFrame>d__8>(ref <WaitFrame>d__);
			return <WaitFrame>d__.<>t__builder.Task;
		}

		// Token: 0x06040964 RID: 264548 RVA: 0x00FA2044 File Offset: 0x00FA0244
		private void OnClickBuffBtn()
		{
			base.GetItem(13).SetUIActive(true);
			UUIButtonComponent button = base.GetButton(15);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x06040965 RID: 264549 RVA: 0x00FA2080 File Offset: 0x00FA0280
		private void OnClickBuffTipsCloseBtn()
		{
			base.GetItem(13).SetUIActive(false);
			UUIButtonComponent button = base.GetButton(15);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06040966 RID: 264550 RVA: 0x00FA20BC File Offset: 0x00FA02BC
		public void RefreshShareBtn()
		{
			bool uiactive = ChannelController.Instance.CouldShare();
			base.GetButton(2).RootUIComp.Get().SetUIActive(uiactive);
		}

		// Token: 0x04021951 RID: 137553
		[Nullable(2)]
		public Action<bool> SetNextAndBackBtnUiActive;

		// Token: 0x0200C68A RID: 50826
		private class EIllustratedUnLockItemDefine
		{
			// Token: 0x0403BEF3 RID: 245491
			public const int MoonTexture = 0;

			// Token: 0x0403BEF4 RID: 245492
			public const int MoonNameText = 1;

			// Token: 0x0403BEF5 RID: 245493
			public const int ShareBtn = 2;

			// Token: 0x0403BEF6 RID: 245494
			public const int StaticTitleText = 3;

			// Token: 0x0403BEF7 RID: 245495
			public const int MoonLabel1NameText = 4;

			// Token: 0x0403BEF8 RID: 245496
			public const int MoonLabel1DesText = 5;

			// Token: 0x0403BEF9 RID: 245497
			public const int MoonLabel2NameText = 6;

			// Token: 0x0403BEFA RID: 245498
			public const int MoonLabel2DesText = 7;

			// Token: 0x0403BEFB RID: 245499
			public const int MoonBuffNameText = 8;

			// Token: 0x0403BEFC RID: 245500
			public const int MoonBuffTexture = 9;

			// Token: 0x0403BEFD RID: 245501
			public const int MoonBuffUpItem = 10;

			// Token: 0x0403BEFE RID: 245502
			public const int MoonDesText = 11;

			// Token: 0x0403BEFF RID: 245503
			public const int BuffBtn = 12;

			// Token: 0x0403BF00 RID: 245504
			public const int BuffTipsItem = 13;

			// Token: 0x0403BF01 RID: 245505
			public const int BuffTipsText = 14;

			// Token: 0x0403BF02 RID: 245506
			public const int BuffTipsCloseBtn = 15;
		}
	}
}
