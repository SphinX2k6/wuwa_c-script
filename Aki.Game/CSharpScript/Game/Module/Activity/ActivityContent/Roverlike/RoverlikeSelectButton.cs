using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006162 RID: 24930
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSelectButton : UiPanelBase
	{
		// Token: 0x0603F020 RID: 258080 RVA: 0x00F38F50 File Offset: 0x00F37150
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F021 RID: 258081 RVA: 0x00F3907A File Offset: 0x00F3727A
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<RoverlikeLootStarItem, bool>(base.GetHorizontalLayout(6), new Func<RoverlikeLootStarItem>(this.CreateStarItem), null, false, true);
			this.SetLock(false, false);
		}

		// Token: 0x0603F022 RID: 258082 RVA: 0x00F390A5 File Offset: 0x00F372A5
		private void OnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x0603F023 RID: 258083 RVA: 0x00F390B7 File Offset: 0x00F372B7
		public void SetClickCallback(Action callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x0603F024 RID: 258084 RVA: 0x00F390C0 File Offset: 0x00F372C0
		public void SetText(string text)
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x0603F025 RID: 258085 RVA: 0x00F390D5 File Offset: 0x00F372D5
		public void SetLocalTextNew(string textId, [ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x0603F026 RID: 258086 RVA: 0x00F390EC File Offset: 0x00F372EC
		public void SetImage(string path)
		{
			UUITexture texture = base.GetTexture(5);
			if (texture == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(path))
			{
				texture.SetUIActive(true);
				base.SetTextureByPath(path, texture, null, null);
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x0603F027 RID: 258087 RVA: 0x00F39130 File Offset: 0x00F37330
		public void SetLock(bool locked, bool interactiveWhenLocked = false)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(locked);
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(!locked);
			}
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(!locked || interactiveWhenLocked);
		}

		// Token: 0x0603F028 RID: 258088 RVA: 0x00F39180 File Offset: 0x00F37380
		public void SetStars(int level, int maxLevel)
		{
			List<bool> list = new List<bool>();
			for (int i = 0; i < maxLevel; i++)
			{
				list.Add(i < level);
			}
			GenericLayout<RoverlikeLootStarItem, bool> starLayout = this.StarLayout;
			if (starLayout == null)
			{
				return;
			}
			starLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0603F029 RID: 258089 RVA: 0x00F391BC File Offset: 0x00F373BC
		public void SetStarListActive(bool active)
		{
			GenericLayout<RoverlikeLootStarItem, bool> starLayout = this.StarLayout;
			if (starLayout == null)
			{
				return;
			}
			starLayout.SetActive(active);
		}

		// Token: 0x0603F02A RID: 258090 RVA: 0x00F391CF File Offset: 0x00F373CF
		private RoverlikeLootStarItem CreateStarItem()
		{
			return new RoverlikeLootStarItem();
		}

		// Token: 0x04020DFD RID: 134653
		[Nullable(2)]
		private Action ClickCallback;

		// Token: 0x04020DFE RID: 134654
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootStarItem, bool> StarLayout;

		// Token: 0x0200C3C2 RID: 50114
		[NullableContext(0)]
		private class ERoverlikeSelectButton
		{
			// Token: 0x0403B118 RID: 241944
			public const int Button = 0;

			// Token: 0x0403B119 RID: 241945
			public const int TxtName = 1;

			// Token: 0x0403B11A RID: 241946
			public const int RedDotItem = 2;

			// Token: 0x0403B11B RID: 241947
			public const int SprIcon = 3;

			// Token: 0x0403B11C RID: 241948
			public const int SprLock = 4;

			// Token: 0x0403B11D RID: 241949
			public const int TexIcon = 5;

			// Token: 0x0403B11E RID: 241950
			public const int StarList = 6;
		}
	}
}
