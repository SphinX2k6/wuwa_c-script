using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068C0 RID: 26816
	[NullableContext(1)]
	[Nullable(0)]
	public class CyberPunkEntranceItem : UiPanelBase
	{
		// Token: 0x06042EC2 RID: 274114 RVA: 0x0104BAB4 File Offset: 0x01049CB4
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

		// Token: 0x06042EC3 RID: 274115 RVA: 0x0104BBE0 File Offset: 0x01049DE0
		protected override void OnBeforeDestroy()
		{
			foreach (ERedDotName name in this.RedDotNames)
			{
				RedDotController.Instance.UnBindGivenUi(name, base.GetItem(5), 0);
			}
			this.RedDotNames.Clear();
			this.RedDotStates.Clear();
		}

		// Token: 0x06042EC4 RID: 274116 RVA: 0x0104BC58 File Offset: 0x01049E58
		public void SetOnClick(Action callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06042EC5 RID: 274117 RVA: 0x0104BC61 File Offset: 0x01049E61
		public void SetOnLockClick(Action callback)
		{
			this.LockClickCallback = callback;
		}

		// Token: 0x06042EC6 RID: 274118 RVA: 0x0104BC6A File Offset: 0x01049E6A
		public void SetConfig(EdgeRunnerUnlock config)
		{
			this.ConfigId = config.Id;
		}

		// Token: 0x06042EC7 RID: 274119 RVA: 0x0104BC79 File Offset: 0x01049E79
		public int GetConfigId()
		{
			return this.ConfigId;
		}

		// Token: 0x06042EC8 RID: 274120 RVA: 0x0104BC81 File Offset: 0x01049E81
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

		// Token: 0x06042EC9 RID: 274121 RVA: 0x0104BCA4 File Offset: 0x01049EA4
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

		// Token: 0x06042ECA RID: 274122 RVA: 0x0104BD72 File Offset: 0x01049F72
		public void SetFinished(bool finished)
		{
			this.IsFinished = finished;
			this.UpdateIconVisibility();
		}

		// Token: 0x06042ECB RID: 274123 RVA: 0x0104BD81 File Offset: 0x01049F81
		public void Refresh(bool locked, string numText)
		{
			this.SetLocked(locked);
			this.SetNumText(numText);
		}

		// Token: 0x06042ECC RID: 274124 RVA: 0x0104BD94 File Offset: 0x01049F94
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

		// Token: 0x06042ECD RID: 274125 RVA: 0x0104BE10 File Offset: 0x0104A010
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

		// Token: 0x06042ECE RID: 274126 RVA: 0x0104BE7C File Offset: 0x0104A07C
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

		// Token: 0x06042ECF RID: 274127 RVA: 0x0104BF43 File Offset: 0x0104A143
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

		// Token: 0x04022D09 RID: 142601
		[Nullable(2)]
		private Action ClickCallback;

		// Token: 0x04022D0A RID: 142602
		[Nullable(2)]
		private Action LockClickCallback;

		// Token: 0x04022D0B RID: 142603
		private readonly List<ERedDotName> RedDotNames = new List<ERedDotName>();

		// Token: 0x04022D0C RID: 142604
		private readonly Dictionary<ERedDotName, bool> RedDotStates = new Dictionary<ERedDotName, bool>();

		// Token: 0x04022D0D RID: 142605
		private bool IsLocked;

		// Token: 0x04022D0E RID: 142606
		private bool IsFinished;

		// Token: 0x04022D0F RID: 142607
		private int ConfigId;

		// Token: 0x0200CA98 RID: 51864
		[NullableContext(0)]
		private static class EEntranceComponent
		{
			// Token: 0x0403D3C3 RID: 250819
			public const int Button = 0;

			// Token: 0x0403D3C4 RID: 250820
			public const int LockIcon = 1;

			// Token: 0x0403D3C5 RID: 250821
			public const int UnLockIcon = 2;

			// Token: 0x0403D3C6 RID: 250822
			public const int FinishedIcon = 3;

			// Token: 0x0403D3C7 RID: 250823
			public const int TxtNum = 4;

			// Token: 0x0403D3C8 RID: 250824
			public const int RedDot = 5;
		}
	}
}
