using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x02005810 RID: 22544
	[NullableContext(1)]
	[Nullable(0)]
	public class CyberPunkEntranceItem : UiPanelBase
	{
		// Token: 0x06037A1A RID: 227866 RVA: 0x00F8D0DC File Offset: 0x00F8B2DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06037A1B RID: 227867 RVA: 0x00F8D208 File Offset: 0x00F8B408
		protected override void OnBeforeDestroy()
		{
			foreach (ERedDotName name in this.RedDotNames)
			{
				RedDotController.Instance.UnBindGivenUi(name, base.GetItem(5), 0);
			}
			this.RedDotNames.Clear();
			this.RedDotStates.Clear();
		}

		// Token: 0x06037A1C RID: 227868 RVA: 0x00F8D280 File Offset: 0x00F8B480
		public void SetOnClick(Action callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06037A1D RID: 227869 RVA: 0x00F8D289 File Offset: 0x00F8B489
		public void SetOnLockClick(Action callback)
		{
			this.LockClickCallback = callback;
		}

		// Token: 0x06037A1E RID: 227870 RVA: 0x00F8D292 File Offset: 0x00F8B492
		public void SetConfig(EdgeRunnerUnlock config)
		{
			this.ConfigId = config.Id;
		}

		// Token: 0x06037A1F RID: 227871 RVA: 0x00F8D2A1 File Offset: 0x00F8B4A1
		public int GetConfigId()
		{
			return this.ConfigId;
		}

		// Token: 0x06037A20 RID: 227872 RVA: 0x00F8D2A9 File Offset: 0x00F8B4A9
		public void SetLocked(bool locked)
		{
			this.IsLocked = locked;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(locked);
			}
			this.UpdateIconVisibility();
		}

		// Token: 0x06037A21 RID: 227873 RVA: 0x00F8D2CC File Offset: 0x00F8B4CC
		public void SetNumText(string text)
		{
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			string[] array = text.Split('/', StringSplitOptions.None);
			if (array.Length != 2)
			{
				text2.SetText(text, true);
				return;
			}
			string text3 = array[0];
			string text4 = array[1];
			int num = int.Parse(text3);
			int num2 = int.Parse(text4);
			string value = EProgressTextColorHelper.ToColorString(EProgressTextColor.InProgress);
			if (num == 0)
			{
				value = EProgressTextColorHelper.ToColorString(EProgressTextColor.Zero);
			}
			else if (num == num2)
			{
				value = EProgressTextColorHelper.ToColorString(EProgressTextColor.Completed);
				this.SetFinished(true);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(text3);
			defaultInterpolatedStringHandler.AppendLiteral("</color>/");
			defaultInterpolatedStringHandler.AppendFormatted(text4);
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			text2.SetText(newText, true);
		}

		// Token: 0x06037A22 RID: 227874 RVA: 0x00F8D39A File Offset: 0x00F8B59A
		public void SetFinished(bool finished)
		{
			this.IsFinished = finished;
			this.UpdateIconVisibility();
		}

		// Token: 0x06037A23 RID: 227875 RVA: 0x00F8D3A9 File Offset: 0x00F8B5A9
		public void Refresh(bool locked, string numText)
		{
			this.SetLocked(locked);
			this.SetNumText(numText);
		}

		// Token: 0x06037A24 RID: 227876 RVA: 0x00F8D3BC File Offset: 0x00F8B5BC
		public void BindRedDot(ERedDotName redDotName)
		{
			if (this.RedDotNames.Contains(redDotName))
			{
				return;
			}
			this.RedDotNames.Add(redDotName);
			this.RedDotStates[redDotName] = false;
			RedDotController.Instance.BindRedDot(redDotName, base.GetItem(5), delegate(bool state, int _)
			{
				this.RedDotStates[redDotName] = state;
				this.UpdateRedDotVisibility();
			}, 0);
		}

		// Token: 0x06037A25 RID: 227877 RVA: 0x00F8D438 File Offset: 0x00F8B638
		private void UpdateRedDotVisibility()
		{
			bool uiactive = false;
			using (Dictionary<ERedDotName, bool>.ValueCollection.Enumerator enumerator = this.RedDotStates.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current)
					{
						uiactive = true;
						break;
					}
				}
			}
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x06037A26 RID: 227878 RVA: 0x00F8D4A4 File Offset: 0x00F8B6A4
		private void UpdateIconVisibility()
		{
			if (this.IsLocked)
			{
				UUIItem item = base.GetItem(1);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(2);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIItem item3 = base.GetItem(3);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(false);
				return;
			}
			else if (this.IsFinished)
			{
				UUIItem item4 = base.GetItem(1);
				if (item4 != null)
				{
					item4.SetUIActive(false);
				}
				UUIItem item5 = base.GetItem(2);
				if (item5 != null)
				{
					item5.SetUIActive(true);
				}
				UUIItem item6 = base.GetItem(3);
				if (item6 == null)
				{
					return;
				}
				item6.SetUIActive(true);
				return;
			}
			else
			{
				UUIItem item7 = base.GetItem(1);
				if (item7 != null)
				{
					item7.SetUIActive(false);
				}
				UUIItem item8 = base.GetItem(2);
				if (item8 != null)
				{
					item8.SetUIActive(true);
				}
				UUIItem item9 = base.GetItem(3);
				if (item9 == null)
				{
					return;
				}
				item9.SetUIActive(false);
				return;
			}
		}

		// Token: 0x06037A27 RID: 227879 RVA: 0x00F8D56B File Offset: 0x00F8B76B
		private void OnClickButton()
		{
			if (this.IsLocked)
			{
				Action lockClickCallback = this.LockClickCallback;
				if (lockClickCallback == null)
				{
					return;
				}
				lockClickCallback();
				return;
			}
			else
			{
				Action clickCallback = this.ClickCallback;
				if (clickCallback == null)
				{
					return;
				}
				clickCallback();
				return;
			}
		}

		// Token: 0x0401D565 RID: 120165
		[Nullable(2)]
		private Action ClickCallback;

		// Token: 0x0401D566 RID: 120166
		[Nullable(2)]
		private Action LockClickCallback;

		// Token: 0x0401D567 RID: 120167
		private readonly List<ERedDotName> RedDotNames = new List<ERedDotName>();

		// Token: 0x0401D568 RID: 120168
		private readonly Dictionary<ERedDotName, bool> RedDotStates = new Dictionary<ERedDotName, bool>();

		// Token: 0x0401D569 RID: 120169
		private bool IsLocked;

		// Token: 0x0401D56A RID: 120170
		private bool IsFinished;

		// Token: 0x0401D56B RID: 120171
		private int ConfigId;

		// Token: 0x0200B460 RID: 46176
		[NullableContext(0)]
		private static class EEntranceComponent
		{
			// Token: 0x04037C9D RID: 228509
			public const int Button = 0;

			// Token: 0x04037C9E RID: 228510
			public const int LockIcon = 1;

			// Token: 0x04037C9F RID: 228511
			public const int UnLockIcon = 2;

			// Token: 0x04037CA0 RID: 228512
			public const int FinishedIcon = 3;

			// Token: 0x04037CA1 RID: 228513
			public const int TxtNum = 4;

			// Token: 0x04037CA2 RID: 228514
			public const int RedDot = 5;
		}
	}
}
