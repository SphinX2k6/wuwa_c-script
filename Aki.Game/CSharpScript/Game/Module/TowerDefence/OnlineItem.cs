using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AC3 RID: 15043
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class OnlineItem : GridProxyAbstract<ITowerDefenseRankPlayerName>
	{
		// Token: 0x06026A75 RID: 158325 RVA: 0x00AD3D78 File Offset: 0x00AD1F78
		public OnlineItem(bool isShowInBottom)
		{
			this.IsShowInBottom = isShowInBottom;
		}

		// Token: 0x06026A76 RID: 158326 RVA: 0x00AD3D88 File Offset: 0x00AD1F88
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

		// Token: 0x06026A77 RID: 158327 RVA: 0x00AD3DF4 File Offset: 0x00AD1FF4
		private void RefreshName()
		{
			int? id = PlayerInfoModel.Instance.GetId();
			int playerId = this.PlayerName.PlayerId;
			bool flag = id.GetValueOrDefault() == playerId & id != null;
			UUIText text = base.GetText(1);
			if (this.IsShowInBottom && flag)
			{
				string newText = PlayerInfoModel.Instance.GetAccountName(true) ?? string.Empty;
				text.SetText(newText, true);
				return;
			}
			string playerName = this.PlayerName.PlayerName;
			if (StringUtils.IsBlank(playerName))
			{
				LguiUtil.Instance.SetLocalTextNew(text, "OnlineGymnasium_AnonymityName", Array.Empty<object>());
				return;
			}
			text.SetText(playerName, true);
		}

		// Token: 0x06026A78 RID: 158328 RVA: 0x00AD3E94 File Offset: 0x00AD2094
		private void RefreshPosTexture()
		{
			UUITexture texture = base.GetTexture(0);
			string posTexture = TowerDefenseRankItemUtil.Instance.GetPosTexture(base.GridIndex);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(posTexture);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x06026A79 RID: 158329 RVA: 0x00AD3ED8 File Offset: 0x00AD20D8
		public override void Refresh(ITowerDefenseRankPlayerName data, bool isSelected, int gridIndex)
		{
			this.PlayerName = data;
			this.RefreshName();
			this.RefreshPosTexture();
		}

		// Token: 0x04015297 RID: 86679
		private ITowerDefenseRankPlayerName PlayerName;

		// Token: 0x04015298 RID: 86680
		private readonly bool IsShowInBottom;

		// Token: 0x020096BF RID: 38591
		[NullableContext(0)]
		private class EOnlineItem
		{
			// Token: 0x0402F0E4 RID: 192740
			public const int PosTexture = 0;

			// Token: 0x0402F0E5 RID: 192741
			public const int Name = 1;
		}
	}
}
