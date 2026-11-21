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
	// Token: 0x020053E1 RID: 21473
	internal class IllustratedUnLockItem : UiPanelBase
	{
		// Token: 0x0603561E RID: 218654 RVA: 0x00EE89CC File Offset: 0x00EE6BCC
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

		// Token: 0x0603561F RID: 218655 RVA: 0x00EE8C70 File Offset: 0x00EE6E70
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

		// Token: 0x06035620 RID: 218656 RVA: 0x00EE8CCC File Offset: 0x00EE6ECC
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

		// Token: 0x06035621 RID: 218657 RVA: 0x00EE8ED7 File Offset: 0x00EE70D7
		private void OnClickShareBtn()
		{
			this.OpenShareView();
		}

		// Token: 0x06035622 RID: 218658 RVA: 0x00EE8EE0 File Offset: 0x00EE70E0
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

		// Token: 0x06035623 RID: 218659 RVA: 0x00EE8F40 File Offset: 0x00EE7140
		private UniTask OpenShareViewAsync()
		{
			IllustratedUnLockItem.<OpenShareViewAsync>d__7 <OpenShareViewAsync>d__;
			<OpenShareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenShareViewAsync>d__.<>4__this = this;
			<OpenShareViewAsync>d__.<>1__state = -1;
			<OpenShareViewAsync>d__.<>t__builder.Start<IllustratedUnLockItem.<OpenShareViewAsync>d__7>(ref <OpenShareViewAsync>d__);
			return <OpenShareViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035624 RID: 218660 RVA: 0x00EE8F84 File Offset: 0x00EE7184
		private UniTask WaitFrame()
		{
			IllustratedUnLockItem.<WaitFrame>d__8 <WaitFrame>d__;
			<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitFrame>d__.<>1__state = -1;
			<WaitFrame>d__.<>t__builder.Start<IllustratedUnLockItem.<WaitFrame>d__8>(ref <WaitFrame>d__);
			return <WaitFrame>d__.<>t__builder.Task;
		}

		// Token: 0x06035625 RID: 218661 RVA: 0x00EE8FC0 File Offset: 0x00EE71C0
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

		// Token: 0x06035626 RID: 218662 RVA: 0x00EE8FFC File Offset: 0x00EE71FC
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

		// Token: 0x06035627 RID: 218663 RVA: 0x00EE9038 File Offset: 0x00EE7238
		public void RefreshShareBtn()
		{
			bool uiactive = ChannelController.Instance.CouldShare();
			base.GetButton(2).RootUIComp.Get().SetUIActive(uiactive);
		}

		// Token: 0x0401C280 RID: 115328
		[Nullable(2)]
		public Action<bool> SetNextAndBackBtnUiActive;

		// Token: 0x0200B070 RID: 45168
		private class EIllustratedUnLockItemDefine
		{
			// Token: 0x0403684E RID: 223310
			public const int MoonTexture = 0;

			// Token: 0x0403684F RID: 223311
			public const int MoonNameText = 1;

			// Token: 0x04036850 RID: 223312
			public const int ShareBtn = 2;

			// Token: 0x04036851 RID: 223313
			public const int StaticTitleText = 3;

			// Token: 0x04036852 RID: 223314
			public const int MoonLabel1NameText = 4;

			// Token: 0x04036853 RID: 223315
			public const int MoonLabel1DesText = 5;

			// Token: 0x04036854 RID: 223316
			public const int MoonLabel2NameText = 6;

			// Token: 0x04036855 RID: 223317
			public const int MoonLabel2DesText = 7;

			// Token: 0x04036856 RID: 223318
			public const int MoonBuffNameText = 8;

			// Token: 0x04036857 RID: 223319
			public const int MoonBuffTexture = 9;

			// Token: 0x04036858 RID: 223320
			public const int MoonBuffUpItem = 10;

			// Token: 0x04036859 RID: 223321
			public const int MoonDesText = 11;

			// Token: 0x0403685A RID: 223322
			public const int BuffBtn = 12;

			// Token: 0x0403685B RID: 223323
			public const int BuffTipsItem = 13;

			// Token: 0x0403685C RID: 223324
			public const int BuffTipsText = 14;

			// Token: 0x0403685D RID: 223325
			public const int BuffTipsCloseBtn = 15;
		}
	}
}
