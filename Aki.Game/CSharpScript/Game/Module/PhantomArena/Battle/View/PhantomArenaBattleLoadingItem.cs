using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x02005243 RID: 21059
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleLoadingItem : GridProxyAbstract<IPhantomArenaBattleLoadingInfo>
	{
		// Token: 0x06035CB0 RID: 220336 RVA: 0x00CBA46B File Offset: 0x00CB866B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x06035CB1 RID: 220337 RVA: 0x00CBA4A4 File Offset: 0x00CB86A4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleLoadingItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleLoadingItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035CB2 RID: 220338 RVA: 0x00CBA4E8 File Offset: 0x00CB86E8
		public override void Refresh(IPhantomArenaBattleLoadingInfo data, bool isSelected, int gridIndex)
		{
			if (data.CardData != null)
			{
				this.CardItem.SetUiActive(true);
				UUISprite sprite = base.GetSprite(1);
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
				this.CardItem.Refresh(data.CardData);
				return;
			}
			this.CardItem.SetUiActive(false);
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(true);
			}
			if (data.IsMe)
			{
				string resourceId = (data.Index < 3) ? "SP_LoadingMeFront" : "SP_LoadingMeBack";
				this.RefreshCardFaceByResource(resourceId);
				return;
			}
			string resourceId2 = (data.Index >= 3) ? "SP_LoadingPlayerFront" : "SP_LoadingPlayerBack";
			this.RefreshCardFaceByResource(resourceId2);
		}

		// Token: 0x06035CB3 RID: 220339 RVA: 0x00CBA590 File Offset: 0x00CB8790
		public void RefreshCardFaceByResource(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (resourcePath != null)
			{
				UUISprite sprite = base.GetSprite(1);
				if (sprite != null)
				{
					this.SetSpriteByPath(resourcePath, sprite, false, null, null);
				}
			}
		}

		// Token: 0x0401C85B RID: 116827
		private const int CARD_FRONT = 3;

		// Token: 0x0401C85C RID: 116828
		private const int CARD_TOTAL = 6;

		// Token: 0x0401C85D RID: 116829
		protected PhantomArenaCard CardItem;

		// Token: 0x0200B3C4 RID: 46020
		[NullableContext(0)]
		private class ELoadingItem
		{
			// Token: 0x040367BE RID: 223166
			public const int CardItem = 0;

			// Token: 0x040367BF RID: 223167
			public const int SpriteState = 1;
		}
	}
}
