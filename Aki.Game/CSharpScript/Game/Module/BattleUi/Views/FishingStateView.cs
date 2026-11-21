using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D06 RID: 19718
	public class FishingStateView : BattleVisibleChildView
	{
		// Token: 0x0603167A RID: 202362 RVA: 0x00DCF208 File Offset: 0x00DCD408
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603167B RID: 202363 RVA: 0x00DCF274 File Offset: 0x00DCD474
		protected override void OnStart()
		{
			base.InitChildType(EBattleUiChild.Ignore);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			EntityHandle entityHandle = shipData.GetEntityHandle();
			BaseAttributeComponent attributeComp;
			if (entityHandle == null)
			{
				attributeComp = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				attributeComp = ((entity != null) ? entity.GetComponent<BaseAttributeComponent>() : null);
			}
			this.AttributeComp = attributeComp;
			this.AddEvents();
			this.RefreshData();
		}

		// Token: 0x0603167C RID: 202364 RVA: 0x00DCF2D7 File Offset: 0x00DCD4D7
		public override void Reset()
		{
			this.RemoveEvents();
			this.AttributeComp = null;
			base.Reset();
		}

		// Token: 0x0603167D RID: 202365 RVA: 0x00DCF2EC File Offset: 0x00DCD4EC
		private void AddEvents()
		{
			if (this.AttributeComp == null)
			{
				return;
			}
			this.AttributeComp.AddListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHealthChanged), null);
			this.AttributeComp.AddListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHealthChanged), null);
		}

		// Token: 0x0603167E RID: 202366 RVA: 0x00DCF329 File Offset: 0x00DCD529
		private void RemoveEvents()
		{
			if (this.AttributeComp == null)
			{
				return;
			}
			this.AttributeComp.RemoveListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHealthChanged));
			this.AttributeComp.RemoveListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHealthChanged));
		}

		// Token: 0x0603167F RID: 202367 RVA: 0x00DCF366 File Offset: 0x00DCD566
		private void OnHealthChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshData();
		}

		// Token: 0x06031680 RID: 202368 RVA: 0x00DCF370 File Offset: 0x00DCD570
		private void RefreshData()
		{
			if (this.AttributeComp == null)
			{
				return;
			}
			float currentValue = this.AttributeComp.GetCurrentValue(EAttributeType.LifeMax);
			float currentValue2 = this.AttributeComp.GetCurrentValue(EAttributeType.Life);
			int num = this.ItemList.Count;
			while ((float)num < currentValue)
			{
				this.AddSingleItem();
				num++;
			}
			for (int i = 0; i < this.ItemList.Count; i++)
			{
				if ((float)i < currentValue)
				{
					this.ItemList[i].SetUiActive(true);
					this.ItemList[i].SetHpVisible((float)i < currentValue2);
				}
				else
				{
					this.ItemList[i].SetUiActive(false);
				}
			}
		}

		// Token: 0x06031681 RID: 202369 RVA: 0x00DCF414 File Offset: 0x00DCD614
		private void AddSingleItem()
		{
			UUIItem item = base.GetItem(0);
			UUIItem item2 = base.GetItem(1);
			AActor actor;
			if (this.ItemList.Count == 0)
			{
				actor = ((item2 != null) ? item2.GetOwner() : null);
			}
			else
			{
				actor = LguiUtil.Instance.DuplicateActor((item2 != null) ? item2.GetOwner() : null, item);
			}
			FishingHpItem fishingHpItem = new FishingHpItem();
			fishingHpItem.CreateThenShowByActorAsync(actor, null, false).Forget();
			this.ItemList.Add(fishingHpItem);
		}

		// Token: 0x0401A2B2 RID: 107186
		[Nullable(2)]
		private BaseAttributeComponent AttributeComp;

		// Token: 0x0401A2B3 RID: 107187
		[Nullable(1)]
		private readonly List<FishingHpItem> ItemList = new List<FishingHpItem>();

		// Token: 0x0200A9B0 RID: 43440
		private enum EChildType
		{
			// Token: 0x040346EB RID: 214763
			ItemContainer,
			// Token: 0x040346EC RID: 214764
			Item
		}
	}
}
