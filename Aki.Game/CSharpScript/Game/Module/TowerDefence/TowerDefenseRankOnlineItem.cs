using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B29 RID: 19241
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseRankOnlineItem : GridProxyAbstract<ITowerDefenseRankPlayerName>
	{
		// Token: 0x06031D5A RID: 204122 RVA: 0x00B91BBC File Offset: 0x00B8FDBC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031D5B RID: 204123 RVA: 0x00B91C28 File Offset: 0x00B8FE28
		private void RefreshName()
		{
			UUIText text = base.GetText(1);
			string playerName = this.PlayerName.PlayerName;
			if (StringUtils.IsBlank(playerName))
			{
				LguiUtil.Instance.SetLocalTextNew(text, "OnlineGymnasium_AnonymityName", Array.Empty<object>());
				return;
			}
			text.SetText(playerName, true);
		}

		// Token: 0x06031D5C RID: 204124 RVA: 0x00B91C70 File Offset: 0x00B8FE70
		private void RefreshPosTexture()
		{
			UUITexture texture = base.GetTexture(0);
			string posTexture = TowerDefenseRankItemUtil.Instance.GetPosTexture(base.GridIndex);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(posTexture);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x06031D5D RID: 204125 RVA: 0x00B91CB4 File Offset: 0x00B8FEB4
		public override void Refresh(ITowerDefenseRankPlayerName data, bool isSelected, int gridIndex)
		{
			this.PlayerName = data;
			this.RefreshName();
			this.RefreshPosTexture();
		}

		// Token: 0x0401A97E RID: 108926
		private ITowerDefenseRankPlayerName PlayerName;

		// Token: 0x0200ACB9 RID: 44217
		[NullableContext(0)]
		private class EOnlineItemComponent
		{
			// Token: 0x040347A0 RID: 214944
			public const int PosTexture = 0;

			// Token: 0x040347A1 RID: 214945
			public const int Name = 1;
		}
	}
}
