using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FeedbackReward
{
	// Token: 0x02004A63 RID: 19043
	public class RewardPanel : UiPanelBase
	{
		// Token: 0x0602FA83 RID: 195203 RVA: 0x00D4BDA4 File Offset: 0x00D49FA4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FA84 RID: 195204 RVA: 0x00D4BE10 File Offset: 0x00D4A010
		protected override UniTask OnBeforeStartAsync()
		{
			RewardPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FA85 RID: 195205 RVA: 0x00D4BE54 File Offset: 0x00D4A054
		[NullableContext(2)]
		public void RefreshItem(string texturePath, int? playerTitleId)
		{
			UUITexture texture = base.GetTexture(0);
			if (!string.IsNullOrEmpty(texturePath))
			{
				PlayerTitleItem playerTitleItem = this.PlayerTitleItem;
				if (playerTitleItem != null)
				{
					playerTitleItem.SetUiActive(false);
				}
				texture.SetUIActive(true);
				base.SetTextureByPath(texturePath, texture, null, null);
				return;
			}
			PlayerTitleItem playerTitleItem2 = this.PlayerTitleItem;
			if (playerTitleItem2 != null)
			{
				playerTitleItem2.SetUiActive(true);
			}
			texture.SetUIActive(false);
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			PlayerTitleItem playerTitleItem3 = this.PlayerTitleItem;
			if (playerTitleItem3 == null)
			{
				return;
			}
			playerTitleItem3.Refresh(playerTitleId, null, new int?((int)playerGender));
		}

		// Token: 0x040194E9 RID: 103657
		[Nullable(2)]
		private PlayerTitleItem PlayerTitleItem;

		// Token: 0x0200A6C5 RID: 42693
		private enum ERewardPanel
		{
			// Token: 0x040338CD RID: 211149
			Texture,
			// Token: 0x040338CE RID: 211150
			PlayerTitleItem
		}
	}
}
