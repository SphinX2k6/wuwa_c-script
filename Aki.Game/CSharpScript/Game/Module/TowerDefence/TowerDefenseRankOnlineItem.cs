using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AD1 RID: 15057
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseRankOnlineItem : GridProxyAbstract<ITowerDefenseRankPlayerName>
	{
		// Token: 0x06026AEA RID: 158442 RVA: 0x00AD5C20 File Offset: 0x00AD3E20
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

		// Token: 0x06026AEB RID: 158443 RVA: 0x00AD5C8C File Offset: 0x00AD3E8C
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

		// Token: 0x06026AEC RID: 158444 RVA: 0x00AD5CD4 File Offset: 0x00AD3ED4
		private void RefreshPosTexture()
		{
			UUITexture texture = base.GetTexture(0);
			string posTexture = TowerDefenseRankItemUtil.Instance.GetPosTexture(base.GridIndex);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(posTexture);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x06026AED RID: 158445 RVA: 0x00AD5D18 File Offset: 0x00AD3F18
		public override void Refresh(ITowerDefenseRankPlayerName data, bool isSelected, int gridIndex)
		{
			this.PlayerName = data;
			this.RefreshName();
			this.RefreshPosTexture();
		}

		// Token: 0x040152D0 RID: 86736
		private ITowerDefenseRankPlayerName PlayerName;

		// Token: 0x020096D9 RID: 38617
		[NullableContext(0)]
		private class EOnlineItemComponent
		{
			// Token: 0x0402F151 RID: 192849
			public const int PosTexture = 0;

			// Token: 0x0402F152 RID: 192850
			public const int Name = 1;
		}
	}
}
