using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059CB RID: 22987
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConfirmPopupView : UiViewBase
	{
		// Token: 0x06038A77 RID: 232055 RVA: 0x00FDAC6E File Offset: 0x00FD8E6E
		public SolarSchoolConfirmPopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038A78 RID: 232056 RVA: 0x00FDAC94 File Offset: 0x00FD8E94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickMaskButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickCloseButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.ToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038A79 RID: 232057 RVA: 0x00FDAE04 File Offset: 0x00FD9004
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolConfirmPopupView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolConfirmPopupView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038A7A RID: 232058 RVA: 0x00FDAE48 File Offset: 0x00FD9048
		protected override void OnBeforeShow()
		{
			UUIButtonComponent button = base.GetButton(1);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(this.Config == null || this.Config.GetValueOrDefault().NeedClose);
		}

		// Token: 0x06038A7B RID: 232059 RVA: 0x00FDAE97 File Offset: 0x00FD9097
		protected override void OnAfterShow()
		{
			ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
			if (confirmBoxData == null)
			{
				return;
			}
			Action afterShowFunction = confirmBoxData.GetAfterShowFunction();
			if (afterShowFunction == null)
			{
				return;
			}
			afterShowFunction();
		}

		// Token: 0x06038A7C RID: 232060 RVA: 0x00FDAEB3 File Offset: 0x00FD90B3
		protected override void OnBeforeHide()
		{
			if (this.LastHide)
			{
				ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
				if (confirmBoxData == null)
				{
					return;
				}
				Action beforePlayCloseFunction = confirmBoxData.BeforePlayCloseFunction;
				if (beforePlayCloseFunction == null)
				{
					return;
				}
				beforePlayCloseFunction();
			}
		}

		// Token: 0x06038A7D RID: 232061 RVA: 0x00FDAED8 File Offset: 0x00FD90D8
		protected override void OnBeforeDestroy()
		{
			this.IsQueuedConfirmPopup = SolarSchoolGamePlayModel.Instance.TryNotifyConfirmPopupClosed();
			this.ResetButtonList();
			if (this.SelectedIndex == -1)
			{
				this.SelectedIndex = 0;
			}
			Action action;
			if (this.ConfirmBoxData != null && this.ConfirmBoxData.FunctionMap.TryGetValue(this.SelectedIndex, out action) && action != null)
			{
				action();
			}
			ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
			if (confirmBoxData == null)
			{
				return;
			}
			Action destroyFunction = confirmBoxData.DestroyFunction;
			if (destroyFunction == null)
			{
				return;
			}
			destroyFunction();
		}

		// Token: 0x06038A7E RID: 232062 RVA: 0x00FDAF50 File Offset: 0x00FD9150
		protected override void OnAfterDestroy()
		{
			if (!this.IsQueuedConfirmPopup)
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "SolarSchoolConfirmPopupSequenceFinished");
			}
		}

		// Token: 0x06038A7F RID: 232063 RVA: 0x00FDAF70 File Offset: 0x00FD9170
		private UniTask InitButton()
		{
			SolarSchoolConfirmPopupView.<InitButton>d__16 <InitButton>d__;
			<InitButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButton>d__.<>4__this = this;
			<InitButton>d__.<>1__state = -1;
			<InitButton>d__.<>t__builder.Start<SolarSchoolConfirmPopupView.<InitButton>d__16>(ref <InitButton>d__);
			return <InitButton>d__.<>t__builder.Task;
		}

		// Token: 0x06038A80 RID: 232064 RVA: 0x00FDAFB4 File Offset: 0x00FD91B4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<ConfirmBoxButton> CreateButton(UUIItem uiItem, int index, Action clickFunction)
		{
			SolarSchoolConfirmPopupView.<CreateButton>d__17 <CreateButton>d__;
			<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<ConfirmBoxButton>.Create();
			<CreateButton>d__.<>4__this = this;
			<CreateButton>d__.uiItem = uiItem;
			<CreateButton>d__.index = index;
			<CreateButton>d__.clickFunction = clickFunction;
			<CreateButton>d__.<>1__state = -1;
			<CreateButton>d__.<>t__builder.Start<SolarSchoolConfirmPopupView.<CreateButton>d__17>(ref <CreateButton>d__);
			return <CreateButton>d__.<>t__builder.Task;
		}

		// Token: 0x06038A81 RID: 232065 RVA: 0x00FDB010 File Offset: 0x00FD9210
		private void ResetButtonList()
		{
			int i = 0;
			int num = this.ButtonList.Length;
			while (i < num)
			{
				this.ButtonList[i].Destroy(null);
				i++;
			}
			this.ButtonList = Array.Empty<ConfirmBoxButton>();
		}

		// Token: 0x06038A82 RID: 232066 RVA: 0x00FDB04C File Offset: 0x00FD924C
		private void ConfirmBoxButtonClick()
		{
			ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
			Func<int, bool> func = (confirmBoxData != null) ? confirmBoxData.CanExecuteCloseFunc : null;
			if (func != null && !func(this.SelectedIndex))
			{
				Action action;
				if (this.ConfirmBoxData != null && this.ConfirmBoxData.FunctionMap.TryGetValue(this.SelectedIndex, out action) && action != null)
				{
					action();
				}
				return;
			}
			base.CloseMe(delegate(bool _)
			{
				Action closeFunction = this.ConfirmBoxData.GetCloseFunction();
				if (closeFunction == null)
				{
					return;
				}
				closeFunction();
			});
		}

		// Token: 0x06038A83 RID: 232067 RVA: 0x00FDB0BB File Offset: 0x00FD92BB
		private void OnClickCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038A84 RID: 232068 RVA: 0x00FDB0C4 File Offset: 0x00FD92C4
		private void OnClickMaskButton()
		{
			if (this.Config == null || !this.Config.GetValueOrDefault().NeedMaskClose)
			{
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x06038A85 RID: 232069 RVA: 0x00FDB100 File Offset: 0x00FD9300
		private void InitToggle()
		{
			ConfirmBoxDataNew data = this.ConfirmBoxData;
			if (!data.HasToggle && this.Config.Value.ToggleType == 1)
			{
				data.HasToggle = true;
				data.SetToggleFunction(delegate(bool isSelectOn)
				{
					ConfirmBoxModel instance = ConfirmBoxModel.Instance;
					if (instance == null)
					{
						return;
					}
					if (isSelectOn)
					{
						instance.NotShowAgainSet.Add(data.ConfigId);
						return;
					}
					instance.NotShowAgainSet.Remove(data.ConfigId);
				});
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle != null)
			{
				UUIItem uuiitem = extendToggle.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(data.HasToggle);
				}
			}
			this.ToggleFunction = (data.HasToggle ? data.GetToggleFunction() : null);
		}

		// Token: 0x06038A86 RID: 232070 RVA: 0x00FDB1B6 File Offset: 0x00FD93B6
		private void ToggleClick(EToggleState toggleState)
		{
			Action<bool> toggleFunction = this.ToggleFunction;
			if (toggleFunction == null)
			{
				return;
			}
			toggleFunction(toggleState == EToggleState.ETT_Checked);
		}

		// Token: 0x0401DD45 RID: 122181
		protected ConfirmBoxButton[] ButtonList = Array.Empty<ConfirmBoxButton>();

		// Token: 0x0401DD46 RID: 122182
		protected ConfirmBox? Config;

		// Token: 0x0401DD47 RID: 122183
		[Nullable(2)]
		protected ConfirmBoxDataNew ConfirmBoxData;

		// Token: 0x0401DD48 RID: 122184
		protected int SelectedIndex = -1;

		// Token: 0x0401DD49 RID: 122185
		private bool IsQueuedConfirmPopup;

		// Token: 0x0401DD4A RID: 122186
		protected readonly List<UUIItem> ButtonRootList = new List<UUIItem>();

		// Token: 0x0401DD4B RID: 122187
		[Nullable(2)]
		protected Action<bool> ToggleFunction;

		// Token: 0x0200B57E RID: 46462
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040381F3 RID: 229875
			public const int BtnMask = 0;

			// Token: 0x040381F4 RID: 229876
			public const int BtnBack = 1;

			// Token: 0x040381F5 RID: 229877
			public const int TxtTips = 2;

			// Token: 0x040381F6 RID: 229878
			public const int TogConsent = 3;

			// Token: 0x040381F7 RID: 229879
			public const int BtnLeft = 4;

			// Token: 0x040381F8 RID: 229880
			public const int BtnRight = 5;
		}
	}
}
