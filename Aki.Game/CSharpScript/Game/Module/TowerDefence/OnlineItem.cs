using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B1B RID: 19227
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class OnlineItem : GridProxyAbstract<ITowerDefenseRankPlayerName>
	{
		// Token: 0x06031CE5 RID: 204005 RVA: 0x00B8FD14 File Offset: 0x00B8DF14
		public OnlineItem(bool isShowInBottom)
		{
			this.IsShowInBottom = isShowInBottom;
		}

		// Token: 0x06031CE6 RID: 204006 RVA: 0x00B8FD24 File Offset: 0x00B8DF24
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

		// Token: 0x06031CE7 RID: 204007 RVA: 0x00B8FD90 File Offset: 0x00B8DF90
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

		// Token: 0x06031CE8 RID: 204008 RVA: 0x00B8FE30 File Offset: 0x00B8E030
		private void RefreshPosTexture()
		{
			UUITexture texture = base.GetTexture(0);
			string posTexture = TowerDefenseRankItemUtil.Instance.GetPosTexture(base.GridIndex);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(posTexture);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x06031CE9 RID: 204009 RVA: 0x00B8FE74 File Offset: 0x00B8E074
		public override void Refresh(ITowerDefenseRankPlayerName data, bool isSelected, int gridIndex)
		{
			this.PlayerName = data;
			this.RefreshName();
			this.RefreshPosTexture();
		}

		// Token: 0x0401A945 RID: 108869
		private ITowerDefenseRankPlayerName PlayerName;

		// Token: 0x0401A946 RID: 108870
		private readonly bool IsShowInBottom;

		// Token: 0x0200AC9F RID: 44191
		[NullableContext(0)]
		private class EOnlineItem
		{
			// Token: 0x04034733 RID: 214835
			public const int PosTexture = 0;

			// Token: 0x04034734 RID: 214836
			public const int Name = 1;
		}
	}
}
