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
	// Token: 0x02004213 RID: 16915
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleLoadingItem : GridProxyAbstract<IPhantomArenaBattleLoadingInfo>
	{
		// Token: 0x0602ABAB RID: 175019 RVA: 0x00C07AAB File Offset: 0x00C05CAB
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x0602ABAC RID: 175020 RVA: 0x00C07AE4 File Offset: 0x00C05CE4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleLoadingItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleLoadingItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ABAD RID: 175021 RVA: 0x00C07B28 File Offset: 0x00C05D28
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

		// Token: 0x0602ABAE RID: 175022 RVA: 0x00C07BD0 File Offset: 0x00C05DD0
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

		// Token: 0x04017290 RID: 94864
		private const int CARD_FRONT = 3;

		// Token: 0x04017291 RID: 94865
		private const int CARD_TOTAL = 6;

		// Token: 0x04017292 RID: 94866
		protected PhantomArenaCard CardItem;

		// Token: 0x02009DFC RID: 40444
		[NullableContext(0)]
		private class ELoadingItem
		{
			// Token: 0x04031211 RID: 201233
			public const int CardItem = 0;

			// Token: 0x04031212 RID: 201234
			public const int SpriteState = 1;
		}
	}
}
