using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02004B21 RID: 19233
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonItemCountPanel : UiPanelBase
	{
		// Token: 0x1700606C RID: 24684
		// (get) Token: 0x060301C1 RID: 197057 RVA: 0x00D6B3BA File Offset: 0x00D695BA
		// (set) Token: 0x060301C2 RID: 197058 RVA: 0x00D6B3C2 File Offset: 0x00D695C2
		private string Count
		{
			get
			{
				return this.CountString;
			}
			set
			{
				this.CountString = value;
				base.GetText(0).SetText(this.CountString, true);
				base.GetInteractionGroup(4).SetInteractable(this.CountString.Length > 0);
			}
		}

		// Token: 0x060301C3 RID: 197059 RVA: 0x00D6B3F8 File Offset: 0x00D695F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIInteractionGroup));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnConfirm));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnDel));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060301C4 RID: 197060 RVA: 0x00D6B6BC File Offset: 0x00D698BC
		protected override void OnStart()
		{
			this.NumButtons = new UUIButtonComponent[10];
			for (int j = 0; j <= 9; j++)
			{
				UUIButtonComponent button = base.GetButton(5 + j);
				this.NumButtons[j] = button;
			}
			int i;
			Action <>9__0;
			int i2;
			for (i = 0; i <= 9; i = i2 + 1)
			{
				FLGUIButtonDynamicDelegate onClickCallBack = this.NumButtons[i].OnClickCallBack;
				Action callback;
				if ((callback = <>9__0) == null)
				{
					callback = (<>9__0 = delegate()
					{
						if (this.Count.Length < 4)
						{
							this.Count += i.ToString();
							return;
						}
						this.Count = "9999";
					});
				}
				onClickCallBack.Bind(callback);
				i2 = i;
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceEvent), false);
		}

		// Token: 0x060301C5 RID: 197061 RVA: 0x00D6B787 File Offset: 0x00D69987
		private void SequenceEvent(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x060301C6 RID: 197062 RVA: 0x00D6B7A0 File Offset: 0x00D699A0
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
			UUIButtonComponent[] numButtons = this.NumButtons;
			for (int i = 0; i < numButtons.Length; i++)
			{
				numButtons[i].OnClickCallBack.Unbind();
			}
		}

		// Token: 0x060301C7 RID: 197063 RVA: 0x00D6B7E1 File Offset: 0x00D699E1
		public void UpdateView(int itemCount)
		{
			this.Count = itemCount.ToString();
			this.RootItem.SetUIActive(true);
			this.RootItem.SetAsLastHierarchy();
		}

		// Token: 0x060301C8 RID: 197064 RVA: 0x00D6B807 File Offset: 0x00D69A07
		private void OnClose()
		{
			this.PlayCloseSequence();
		}

		// Token: 0x060301C9 RID: 197065 RVA: 0x00D6B80F File Offset: 0x00D69A0F
		private void OnConfirm()
		{
			Action<int> confirmFunction = this.ConfirmFunction;
			if (confirmFunction != null)
			{
				confirmFunction(int.Parse(this.Count));
			}
			this.PlayCloseSequence();
		}

		// Token: 0x060301CA RID: 197066 RVA: 0x00D6B833 File Offset: 0x00D69A33
		private void OnDel()
		{
			this.Count = this.Count.Substring(0, this.Count.Length - 1);
		}

		// Token: 0x060301CB RID: 197067 RVA: 0x00D6B854 File Offset: 0x00D69A54
		public void SetTitleText(string text)
		{
			base.GetText(15).SetText(text, true);
		}

		// Token: 0x060301CC RID: 197068 RVA: 0x00D6B868 File Offset: 0x00D69A68
		public void PlayStartSequence(int itemCount)
		{
			this.SetActive(true);
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			this.UpdateView(itemCount);
		}

		// Token: 0x060301CD RID: 197069 RVA: 0x00D6B8A0 File Offset: 0x00D69AA0
		public void PlayCloseSequence()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x060301CE RID: 197070 RVA: 0x00D6B8C8 File Offset: 0x00D69AC8
		public void SetConfirmFunction(Action<int> callback)
		{
			this.ConfirmFunction = callback;
		}

		// Token: 0x040197FF RID: 104447
		private const int MAX_DIGIT = 4;

		// Token: 0x04019800 RID: 104448
		private const string MAX_NUMBER = "9999";

		// Token: 0x04019801 RID: 104449
		private const int KEYCOUNT = 9;

		// Token: 0x04019802 RID: 104450
		private string CountString = "";

		// Token: 0x04019803 RID: 104451
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIButtonComponent[] NumButtons;

		// Token: 0x04019804 RID: 104452
		[Nullable(2)]
		private Action<int> ConfirmFunction;

		// Token: 0x04019805 RID: 104453
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A77C RID: 42876
		[NullableContext(0)]
		private class ECommonItemCountPanelDefine
		{
			// Token: 0x04033C1F RID: 211999
			public const int CountText = 0;

			// Token: 0x04033C20 RID: 212000
			public const int Close = 1;

			// Token: 0x04033C21 RID: 212001
			public const int Del = 2;

			// Token: 0x04033C22 RID: 212002
			public const int Yes = 3;

			// Token: 0x04033C23 RID: 212003
			public const int YesGroup = 4;

			// Token: 0x04033C24 RID: 212004
			public const int ZeroButton = 5;

			// Token: 0x04033C25 RID: 212005
			public const int OneButton = 6;

			// Token: 0x04033C26 RID: 212006
			public const int TwoButton = 7;

			// Token: 0x04033C27 RID: 212007
			public const int ThreeButton = 8;

			// Token: 0x04033C28 RID: 212008
			public const int FourButton = 9;

			// Token: 0x04033C29 RID: 212009
			public const int FiveButton = 10;

			// Token: 0x04033C2A RID: 212010
			public const int SixButton = 11;

			// Token: 0x04033C2B RID: 212011
			public const int SevenButton = 12;

			// Token: 0x04033C2C RID: 212012
			public const int EightButton = 13;

			// Token: 0x04033C2D RID: 212013
			public const int NineButton = 14;

			// Token: 0x04033C2E RID: 212014
			public const int TitleText = 15;
		}
	}
}
