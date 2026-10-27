using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardReward
{
	// Token: 0x020051C4 RID: 20932
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RewardGridCardItem : CommonGridCardItem<CollectGridCardData>
	{
		// Token: 0x06035990 RID: 219536 RVA: 0x00CB30C4 File Offset: 0x00CB12C4
		protected override void OnRegisterCardComponent()
		{
			if (this.IsNewPhantomArenaActivity)
			{
				this.ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>
				{
					new TCardComponentsRegisterInfoByItem(ECardItemComponent.NewCommonBaseCardComponent, base.GetRootItem())
				};
			}
			else
			{
				this.ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>
				{
					new TCardComponentsRegisterInfoByItem(ECardItemComponent.CommonBaseCardComponent, base.GetRootItem())
				};
			}
			this.ComponentsRegisterInfoByResourceId = new List<TCardComponentsRegisterInfoByResourceId>
			{
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardSpineComponent, "UiItem_SoundRemnantItem512Spine", base.GetSpineRootItem())
			};
		}

		// Token: 0x06035991 RID: 219537 RVA: 0x00CB3138 File Offset: 0x00CB1338
		public override void Refresh(CollectGridCardData data)
		{
			this.Refresh(data, false, 0);
		}

		// Token: 0x06035992 RID: 219538 RVA: 0x00CB3144 File Offset: 0x00CB1344
		public override void Refresh(CollectGridCardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			CommonBaseCardComponentData data2 = new CommonBaseCardComponentData
			{
				CardId = data.CardId,
				Attack = data.Attack,
				Life = data.Life,
				Element = data.Element,
				CardFaceTexturePath = data.CardFaceTexturePath,
				ShowCardFaceTexture = (data.CardFaceType == ECardFaceType.Texture),
				Cost = data.Cost,
				OnPointerUp = new Action(this.OnPointerUp),
				CanToggleExecuteChange = new Func<bool>(this.CanToggleChange),
				OutlookUnlocked = data.OutlookUnlocked
			};
			if (this.IsNewPhantomArenaActivity)
			{
				NewCommonBaseCardComponent component = base.GetComponent<NewCommonBaseCardComponent>(ECardItemComponent.NewCommonBaseCardComponent);
				if (component != null)
				{
					component.Refresh(data2);
				}
			}
			else
			{
				CommonBaseCardComponent component2 = base.GetComponent<CommonBaseCardComponent>(ECardItemComponent.CommonBaseCardComponent);
				if (component2 != null)
				{
					component2.Refresh(data2);
				}
			}
			CardSpineComponentData data3 = new CardSpineComponentData
			{
				CardSpineData = data.CardSpineData,
				ShowSpine = (data.CardFaceType == ECardFaceType.Spine)
			};
			CardSpineComponent component3 = base.GetComponent<CardSpineComponent>(ECardItemComponent.CardSpineComponent);
			if (component3 == null)
			{
				return;
			}
			component3.Refresh(data3);
		}

		// Token: 0x06035993 RID: 219539 RVA: 0x00CB3249 File Offset: 0x00CB1449
		private void OnPointerUp()
		{
			PhantomArenaController.Instance.OpenDeckBuilderCardInfoViewWithoutOutlookTab(this.Data.CardId);
		}

		// Token: 0x06035994 RID: 219540 RVA: 0x00CB3260 File Offset: 0x00CB1460
		private bool CanToggleChange()
		{
			return false;
		}

		// Token: 0x06035995 RID: 219541 RVA: 0x00CB3263 File Offset: 0x00CB1463
		public new object GetKey(CollectGridCardData data, int gridIndex)
		{
			return data.CardId;
		}

		// Token: 0x0401C729 RID: 116521
		protected CollectGridCardData Data;

		// Token: 0x0401C72A RID: 116522
		public bool IsNewPhantomArenaActivity;
	}
}
