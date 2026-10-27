using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005042 RID: 20546
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class ChatItemGrid : GridProxyAbstract<ChatItemData>
	{
		// Token: 0x06034954 RID: 215380 RVA: 0x00C6AE28 File Offset: 0x00C69028
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034955 RID: 215381 RVA: 0x00C6AF15 File Offset: 0x00C69115
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06034956 RID: 215382 RVA: 0x00C6AF28 File Offset: 0x00C69128
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x06034957 RID: 215383 RVA: 0x00C6AF44 File Offset: 0x00C69144
		[NullableContext(1)]
		public override void Refresh(ChatItemData data, bool isSelected, int gridIndex)
		{
			string newText = PlotModel.Instance.PlotTextReplacer.Replace(data.Name, false) ?? data.Name;
			string newText2 = PlotModel.Instance.PlotTextReplacer.Replace(data.Message, false) ?? data.Message;
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(newText, true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetText(newText2, true);
			}
			if (!StringUtils.IsEmpty(data.Icon))
			{
				base.SetTextureByPath(data.Icon, base.GetTexture(1), null, null);
			}
			this.RefreshItemModes(data.DisplayMode);
		}

		// Token: 0x06034958 RID: 215384 RVA: 0x00C6AFF4 File Offset: 0x00C691F4
		private void RefreshItemModes(ChatItemDisplayMode? mode)
		{
			ChatItemDisplayMode? chatItemDisplayMode = mode;
			ChatItemDisplayMode chatItemDisplayMode2 = ChatItemDisplayMode.Start;
			if (chatItemDisplayMode.GetValueOrDefault() == chatItemDisplayMode2 & chatItemDisplayMode != null)
			{
				LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
				if (viewSequencePlayer != null)
				{
					viewSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
				}
				UUIItem item = base.GetItem(4);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(5);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
			else
			{
				if (mode.GetValueOrDefault() != ChatItemDisplayMode.GreyOnly)
				{
					if (mode.GetValueOrDefault() == ChatItemDisplayMode.Close)
					{
						LevelSequencePlayer viewSequencePlayer2 = this.ViewSequencePlayer;
						if (viewSequencePlayer2 != null)
						{
							viewSequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
						}
						UUIItem item3 = base.GetItem(4);
						if (item3 != null)
						{
							item3.SetUIActive(true);
						}
						UUIItem item4 = base.GetItem(5);
						if (item4 == null)
						{
							return;
						}
						item4.SetUIActive(true);
					}
					return;
				}
				UUIItem item5 = base.GetItem(4);
				if (item5 != null)
				{
					item5.SetUIActive(true);
				}
				UUIItem item6 = base.GetItem(5);
				if (item6 == null)
				{
					return;
				}
				item6.SetUIActive(true);
				return;
			}
		}

		// Token: 0x0401C060 RID: 114784
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x0200B194 RID: 45460
		private static class EChatComponents
		{
			// Token: 0x04035DBA RID: 220602
			public const int ChatItem = 0;

			// Token: 0x04035DBB RID: 220603
			public const int RoleTexture = 1;

			// Token: 0x04035DBC RID: 220604
			public const int NameText = 2;

			// Token: 0x04035DBD RID: 220605
			public const int ContentText = 3;

			// Token: 0x04035DBE RID: 220606
			public const int HeadGreyItem = 4;

			// Token: 0x04035DBF RID: 220607
			public const int ContentGreyItem = 5;
		}
	}
}
