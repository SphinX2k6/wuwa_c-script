using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059C3 RID: 22979
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolMapLocationItem : UiPanelBase
	{
		// Token: 0x06038A2F RID: 231983 RVA: 0x00FD90CC File Offset: 0x00FD72CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038A30 RID: 231984 RVA: 0x00FD9178 File Offset: 0x00FD7378
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06038A31 RID: 231985 RVA: 0x00FD91D8 File Offset: 0x00FD73D8
		[NullableContext(1)]
		public void SetLocationName(string txtId, int debugId = 0)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.TrySetLocalTextNew(text, txtId, Array.Empty<object>());
		}

		// Token: 0x06038A32 RID: 231986 RVA: 0x00FD9200 File Offset: 0x00FD7400
		public void SetLocationIcon(string iconPath)
		{
			bool flag = !string.IsNullOrEmpty(iconPath);
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			if (flag)
			{
				base.SetTextureByPath(iconPath, base.GetTexture(2), null, null);
			}
		}

		// Token: 0x06038A33 RID: 231987 RVA: 0x00FD9245 File Offset: 0x00FD7445
		public void SetRedDotActive(bool normalRedPointActive, bool affinityRedPointActive)
		{
			this.NormalRedPointActive = (normalRedPointActive && !affinityRedPointActive);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(this.NormalRedPointActive);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(affinityRedPointActive);
		}

		// Token: 0x06038A34 RID: 231988 RVA: 0x00FD9281 File Offset: 0x00FD7481
		public UUIItem GetRedDotItem()
		{
			if (this.NormalRedPointActive)
			{
				return base.GetItem(1);
			}
			return null;
		}

		// Token: 0x0401DD32 RID: 122162
		private bool NormalRedPointActive;

		// Token: 0x0401DD33 RID: 122163
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B572 RID: 46450
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040381A2 RID: 229794
			public const int TxtContent = 0;

			// Token: 0x040381A3 RID: 229795
			public const int UiItemSolarSchoolRedPoint = 1;

			// Token: 0x040381A4 RID: 229796
			public const int TexIcon = 2;

			// Token: 0x040381A5 RID: 229797
			public const int PnlAffinityRedPoint = 3;
		}
	}
}
