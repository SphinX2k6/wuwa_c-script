using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059A9 RID: 22953
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolShortCaptionItem : UiPanelBase
	{
		// Token: 0x06038969 RID: 231785 RVA: 0x00FD53E3 File Offset: 0x00FD35E3
		public void SetNavCallbacks(Action onHome, Action onClose)
		{
			this.HomeCallback = onHome;
			this.CloseCallback = onClose;
		}

		// Token: 0x0603896A RID: 231786 RVA: 0x00FD53F4 File Offset: 0x00FD35F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnHomeClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnCloseClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603896B RID: 231787 RVA: 0x00FD5520 File Offset: 0x00FD3720
		protected override void OnStart()
		{
		}

		// Token: 0x0603896C RID: 231788 RVA: 0x00FD5522 File Offset: 0x00FD3722
		protected override void OnBeforeDestroy()
		{
			this.HomeCallback = null;
			this.CloseCallback = null;
		}

		// Token: 0x0603896D RID: 231789 RVA: 0x00FD5532 File Offset: 0x00FD3732
		[NullableContext(1)]
		public void SetTitle(string title)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(title, true);
		}

		// Token: 0x0603896E RID: 231790 RVA: 0x00FD5547 File Offset: 0x00FD3747
		public void SetTitleIconVisible(bool visible)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(visible);
		}

		// Token: 0x0603896F RID: 231791 RVA: 0x00FD555B File Offset: 0x00FD375B
		public void SetHomeVisible(bool visible)
		{
			this.SetButtonVisible(2, visible);
		}

		// Token: 0x06038970 RID: 231792 RVA: 0x00FD5565 File Offset: 0x00FD3765
		public void SetCloseVisible(bool visible)
		{
			this.SetButtonVisible(4, visible);
		}

		// Token: 0x06038971 RID: 231793 RVA: 0x00FD5570 File Offset: 0x00FD3770
		public void SetHelpGroupId(int helpGroupId)
		{
			UUIItem item = base.GetItem(3);
			bool flag = helpGroupId != 0;
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			object obj;
			if (item == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIExtendButtonComponent.StaticClass()) : null);
			}
			UUIExtendButtonComponent uuiextendButtonComponent = obj as UUIExtendButtonComponent;
			if (uuiextendButtonComponent != null)
			{
				uuiextendButtonComponent.HelpGroupId = helpGroupId;
			}
		}

		// Token: 0x06038972 RID: 231794 RVA: 0x00FD55CC File Offset: 0x00FD37CC
		private void SetButtonVisible(int component, bool visible)
		{
			UUIButtonComponent button = base.GetButton(component);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(visible);
		}

		// Token: 0x06038973 RID: 231795 RVA: 0x00FD55FD File Offset: 0x00FD37FD
		private void OnBtnHomeClick()
		{
			Action homeCallback = this.HomeCallback;
			if (homeCallback == null)
			{
				return;
			}
			homeCallback();
		}

		// Token: 0x06038974 RID: 231796 RVA: 0x00FD560F File Offset: 0x00FD380F
		private void OnBtnCloseClick()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x0401DCE3 RID: 122083
		private Action HomeCallback;

		// Token: 0x0401DCE4 RID: 122084
		private Action CloseCallback;

		// Token: 0x0200B554 RID: 46420
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038100 RID: 229632
			public const int SprTitleIcon = 0;

			// Token: 0x04038101 RID: 229633
			public const int TxtTitle = 1;

			// Token: 0x04038102 RID: 229634
			public const int BtnHome = 2;

			// Token: 0x04038103 RID: 229635
			public const int BtnHelpInfo = 3;

			// Token: 0x04038104 RID: 229636
			public const int BtnSolarSchoolBack = 4;
		}
	}
}
