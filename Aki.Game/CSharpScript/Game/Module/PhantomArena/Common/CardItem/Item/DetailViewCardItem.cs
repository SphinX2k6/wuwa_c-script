using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020041AB RID: 16811
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DetailViewCardItem : CommonBaseCardItem<DetailViewCardItemData>
	{
		// Token: 0x0602A903 RID: 174339 RVA: 0x00C01DC8 File Offset: 0x00BFFFC8
		protected override void OnRegisterCardComponent()
		{
			string resourceId = this.IsNewPhantomArenaActivity ? "UiItem_CardLockNew" : "UiItem_CardLock";
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
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardLockComponent, resourceId, base.GetContentRootItem()),
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardSpineComponent, "UiItem_SoundRemnantItem512Spine", base.GetSpineRootItem())
			};
		}

		// Token: 0x0602A904 RID: 174340 RVA: 0x00C01E64 File Offset: 0x00C00064
		public override void Refresh(DetailViewCardItemData data)
		{
			this.Data = data;
			CommonBaseCardComponentData data2 = new CommonBaseCardComponentData
			{
				CardId = data.CardId,
				Cost = data.Cost,
				Attack = data.Attack,
				Life = data.Life,
				Element = data.Element,
				CardFaceTexturePath = data.CardFaceTexturePath,
				ShowCardFaceTexture = (data.CardFaceType == ECardFaceType.Texture),
				CanToggleExecuteChange = new Func<bool>(this.CanToggleChange),
				OutlookUnlocked = data.OutlookUnlocked
			};
			CommonBaseCardComponent component = base.GetComponent<CommonBaseCardComponent>(ECardItemComponent.CommonBaseCardComponent);
			if (component != null)
			{
				component.Refresh(data2);
			}
			NewCommonBaseCardComponent component2 = base.GetComponent<NewCommonBaseCardComponent>(ECardItemComponent.NewCommonBaseCardComponent);
			if (component2 != null)
			{
				component2.Refresh(data2);
			}
			CardSpineComponentData data3 = new CardSpineComponentData
			{
				CardSpineData = data.CardSpineData,
				ShowSpine = (data.CardFaceType == ECardFaceType.Spine)
			};
			CardSpineComponent component3 = base.GetComponent<CardSpineComponent>(ECardItemComponent.CardSpineComponent);
			if (component3 != null)
			{
				component3.Refresh(data3);
			}
			this.RefreshIsLocked();
		}

		// Token: 0x0602A905 RID: 174341 RVA: 0x00C01F54 File Offset: 0x00C00154
		public void RefreshIsLocked()
		{
			CardLockComponent component = base.GetComponent<CardLockComponent>(ECardItemComponent.CardLockComponent);
			if (component == null)
			{
				return;
			}
			component.Refresh(this.Data.IsLock);
		}

		// Token: 0x0602A906 RID: 174342 RVA: 0x00C01F72 File Offset: 0x00C00172
		private bool CanToggleChange()
		{
			return false;
		}

		// Token: 0x04017194 RID: 94612
		protected DetailViewCardItemData Data;

		// Token: 0x04017195 RID: 94613
		public bool IsNewPhantomArenaActivity;
	}
}
