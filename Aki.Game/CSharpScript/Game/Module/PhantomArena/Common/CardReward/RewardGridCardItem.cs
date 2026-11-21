using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardReward
{
	// Token: 0x02004194 RID: 16788
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RewardGridCardItem : CommonGridCardItem<CollectGridCardData>
	{
		// Token: 0x0602A88B RID: 174219 RVA: 0x00C00700 File Offset: 0x00BFE900
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

		// Token: 0x0602A88C RID: 174220 RVA: 0x00C00774 File Offset: 0x00BFE974
		public override void Refresh(CollectGridCardData data)
		{
			this.Refresh(data, false, 0);
		}

		// Token: 0x0602A88D RID: 174221 RVA: 0x00C00780 File Offset: 0x00BFE980
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

		// Token: 0x0602A88E RID: 174222 RVA: 0x00C00885 File Offset: 0x00BFEA85
		private void OnPointerUp()
		{
			PhantomArenaController.Instance.OpenDeckBuilderCardInfoViewWithoutOutlookTab(this.Data.CardId);
		}

		// Token: 0x0602A88F RID: 174223 RVA: 0x00C0089C File Offset: 0x00BFEA9C
		private bool CanToggleChange()
		{
			return false;
		}

		// Token: 0x0602A890 RID: 174224 RVA: 0x00C0089F File Offset: 0x00BFEA9F
		public new object GetKey(CollectGridCardData data, int gridIndex)
		{
			return data.CardId;
		}

		// Token: 0x0401715E RID: 94558
		protected CollectGridCardData Data;

		// Token: 0x0401715F RID: 94559
		public bool IsNewPhantomArenaActivity;
	}
}
