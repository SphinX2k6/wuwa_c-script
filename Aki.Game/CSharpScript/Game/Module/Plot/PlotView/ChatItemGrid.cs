using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004011 RID: 16401
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class ChatItemGrid : GridProxyAbstract<ChatItemData>
	{
		// Token: 0x06029830 RID: 170032 RVA: 0x00BB7EC8 File Offset: 0x00BB60C8
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

		// Token: 0x06029831 RID: 170033 RVA: 0x00BB7FB5 File Offset: 0x00BB61B5
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06029832 RID: 170034 RVA: 0x00BB7FC8 File Offset: 0x00BB61C8
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x06029833 RID: 170035 RVA: 0x00BB7FE4 File Offset: 0x00BB61E4
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

		// Token: 0x06029834 RID: 170036 RVA: 0x00BB8094 File Offset: 0x00BB6294
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

		// Token: 0x04016A83 RID: 92803
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x02009BCE RID: 39886
		private static class EChatComponents
		{
			// Token: 0x0403080F RID: 198671
			public const int ChatItem = 0;

			// Token: 0x04030810 RID: 198672
			public const int RoleTexture = 1;

			// Token: 0x04030811 RID: 198673
			public const int NameText = 2;

			// Token: 0x04030812 RID: 198674
			public const int ContentText = 3;

			// Token: 0x04030813 RID: 198675
			public const int HeadGreyItem = 4;

			// Token: 0x04030814 RID: 198676
			public const int ContentGreyItem = 5;
		}
	}
}
