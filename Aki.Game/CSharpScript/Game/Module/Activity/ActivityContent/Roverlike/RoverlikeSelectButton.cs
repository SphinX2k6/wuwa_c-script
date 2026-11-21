using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050E0 RID: 20704
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSelectButton : UiPanelBase
	{
		// Token: 0x06033CE0 RID: 212192 RVA: 0x00E7FE24 File Offset: 0x00E7E024
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

		// Token: 0x06033CE1 RID: 212193 RVA: 0x00E7FF4E File Offset: 0x00E7E14E
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<RoverlikeLootStarItem, bool>(base.GetHorizontalLayout(6), new Func<RoverlikeLootStarItem>(this.CreateStarItem), null, false, true);
			this.SetLock(false, false);
		}

		// Token: 0x06033CE2 RID: 212194 RVA: 0x00E7FF79 File Offset: 0x00E7E179
		private void OnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x06033CE3 RID: 212195 RVA: 0x00E7FF8B File Offset: 0x00E7E18B
		public void SetClickCallback(Action callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06033CE4 RID: 212196 RVA: 0x00E7FF94 File Offset: 0x00E7E194
		public void SetText(string text)
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x06033CE5 RID: 212197 RVA: 0x00E7FFA9 File Offset: 0x00E7E1A9
		public void SetLocalTextNew(string textId, [ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x06033CE6 RID: 212198 RVA: 0x00E7FFC0 File Offset: 0x00E7E1C0
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

		// Token: 0x06033CE7 RID: 212199 RVA: 0x00E80004 File Offset: 0x00E7E204
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

		// Token: 0x06033CE8 RID: 212200 RVA: 0x00E80054 File Offset: 0x00E7E254
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

		// Token: 0x06033CE9 RID: 212201 RVA: 0x00E80090 File Offset: 0x00E7E290
		public void SetStarListActive(bool active)
		{
			GenericLayout<RoverlikeLootStarItem, bool> starLayout = this.StarLayout;
			if (starLayout == null)
			{
				return;
			}
			starLayout.SetActive(active);
		}

		// Token: 0x06033CEA RID: 212202 RVA: 0x00E800A3 File Offset: 0x00E7E2A3
		private RoverlikeLootStarItem CreateStarItem()
		{
			return new RoverlikeLootStarItem();
		}

		// Token: 0x0401B72A RID: 112426
		[Nullable(2)]
		private Action ClickCallback;

		// Token: 0x0401B72B RID: 112427
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootStarItem, bool> StarLayout;

		// Token: 0x0200ADA9 RID: 44457
		[NullableContext(0)]
		private class ERoverlikeSelectButton
		{
			// Token: 0x04035A79 RID: 219769
			public const int Button = 0;

			// Token: 0x04035A7A RID: 219770
			public const int TxtName = 1;

			// Token: 0x04035A7B RID: 219771
			public const int RedDotItem = 2;

			// Token: 0x04035A7C RID: 219772
			public const int SprIcon = 3;

			// Token: 0x04035A7D RID: 219773
			public const int SprLock = 4;

			// Token: 0x04035A7E RID: 219774
			public const int TexIcon = 5;

			// Token: 0x04035A7F RID: 219775
			public const int StarList = 6;
		}
	}
}
