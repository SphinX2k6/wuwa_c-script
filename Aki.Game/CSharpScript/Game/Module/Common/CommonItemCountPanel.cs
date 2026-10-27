using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02005B40 RID: 23360
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonItemCountPanel : UiPanelBase
	{
		// Token: 0x17008C92 RID: 35986
		// (get) Token: 0x0603B24F RID: 242255 RVA: 0x00E1A6A2 File Offset: 0x00E188A2
		// (set) Token: 0x0603B250 RID: 242256 RVA: 0x00E1A6AA File Offset: 0x00E188AA
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

		// Token: 0x0603B251 RID: 242257 RVA: 0x00E1A6E0 File Offset: 0x00E188E0
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

		// Token: 0x0603B252 RID: 242258 RVA: 0x00E1A9A4 File Offset: 0x00E18BA4
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

		// Token: 0x0603B253 RID: 242259 RVA: 0x00E1AA6F File Offset: 0x00E18C6F
		private void SequenceEvent(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0603B254 RID: 242260 RVA: 0x00E1AA88 File Offset: 0x00E18C88
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

		// Token: 0x0603B255 RID: 242261 RVA: 0x00E1AAC9 File Offset: 0x00E18CC9
		public void UpdateView(int itemCount)
		{
			this.Count = itemCount.ToString();
			this.RootItem.SetUIActive(true);
			this.RootItem.SetAsLastHierarchy();
		}

		// Token: 0x0603B256 RID: 242262 RVA: 0x00E1AAEF File Offset: 0x00E18CEF
		private void OnClose()
		{
			this.PlayCloseSequence();
		}

		// Token: 0x0603B257 RID: 242263 RVA: 0x00E1AAF7 File Offset: 0x00E18CF7
		private void OnConfirm()
		{
			Action<int> confirmFunction = this.ConfirmFunction;
			if (confirmFunction != null)
			{
				confirmFunction(int.Parse(this.Count));
			}
			this.PlayCloseSequence();
		}

		// Token: 0x0603B258 RID: 242264 RVA: 0x00E1AB1B File Offset: 0x00E18D1B
		private void OnDel()
		{
			this.Count = this.Count.Substring(0, this.Count.Length - 1);
		}

		// Token: 0x0603B259 RID: 242265 RVA: 0x00E1AB3C File Offset: 0x00E18D3C
		public void SetTitleText(string text)
		{
			base.GetText(15).SetText(text, true);
		}

		// Token: 0x0603B25A RID: 242266 RVA: 0x00E1AB50 File Offset: 0x00E18D50
		public void PlayStartSequence(int itemCount)
		{
			this.SetActive(true);
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			this.UpdateView(itemCount);
		}

		// Token: 0x0603B25B RID: 242267 RVA: 0x00E1AB88 File Offset: 0x00E18D88
		public void PlayCloseSequence()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x0603B25C RID: 242268 RVA: 0x00E1ABB0 File Offset: 0x00E18DB0
		public void SetConfirmFunction(Action<int> callback)
		{
			this.ConfirmFunction = callback;
		}

		// Token: 0x0401ED43 RID: 126275
		private const int MAX_DIGIT = 4;

		// Token: 0x0401ED44 RID: 126276
		private const string MAX_NUMBER = "9999";

		// Token: 0x0401ED45 RID: 126277
		private const int KEYCOUNT = 9;

		// Token: 0x0401ED46 RID: 126278
		private string CountString = "";

		// Token: 0x0401ED47 RID: 126279
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIButtonComponent[] NumButtons;

		// Token: 0x0401ED48 RID: 126280
		[Nullable(2)]
		private Action<int> ConfirmFunction;

		// Token: 0x0401ED49 RID: 126281
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200BD73 RID: 48499
		[NullableContext(0)]
		private class ECommonItemCountPanelDefine
		{
			// Token: 0x04039253 RID: 234067
			public const int CountText = 0;

			// Token: 0x04039254 RID: 234068
			public const int Close = 1;

			// Token: 0x04039255 RID: 234069
			public const int Del = 2;

			// Token: 0x04039256 RID: 234070
			public const int Yes = 3;

			// Token: 0x04039257 RID: 234071
			public const int YesGroup = 4;

			// Token: 0x04039258 RID: 234072
			public const int ZeroButton = 5;

			// Token: 0x04039259 RID: 234073
			public const int OneButton = 6;

			// Token: 0x0403925A RID: 234074
			public const int TwoButton = 7;

			// Token: 0x0403925B RID: 234075
			public const int ThreeButton = 8;

			// Token: 0x0403925C RID: 234076
			public const int FourButton = 9;

			// Token: 0x0403925D RID: 234077
			public const int FiveButton = 10;

			// Token: 0x0403925E RID: 234078
			public const int SixButton = 11;

			// Token: 0x0403925F RID: 234079
			public const int SevenButton = 12;

			// Token: 0x04039260 RID: 234080
			public const int EightButton = 13;

			// Token: 0x04039261 RID: 234081
			public const int NineButton = 14;

			// Token: 0x04039262 RID: 234082
			public const int TitleText = 15;
		}
	}
}
