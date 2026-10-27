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
	// Token: 0x02005D24 RID: 23844
	public class FishingStateView : BattleVisibleChildView
	{
		// Token: 0x0603C721 RID: 247585 RVA: 0x00E7EA68 File Offset: 0x00E7CC68
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

		// Token: 0x0603C722 RID: 247586 RVA: 0x00E7EAD4 File Offset: 0x00E7CCD4
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

		// Token: 0x0603C723 RID: 247587 RVA: 0x00E7EB37 File Offset: 0x00E7CD37
		public override void Reset()
		{
			this.RemoveEvents();
			this.AttributeComp = null;
			base.Reset();
		}

		// Token: 0x0603C724 RID: 247588 RVA: 0x00E7EB4C File Offset: 0x00E7CD4C
		private void AddEvents()
		{
			if (this.AttributeComp == null)
			{
				return;
			}
			this.AttributeComp.AddListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHealthChanged), null);
			this.AttributeComp.AddListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHealthChanged), null);
		}

		// Token: 0x0603C725 RID: 247589 RVA: 0x00E7EB89 File Offset: 0x00E7CD89
		private void RemoveEvents()
		{
			if (this.AttributeComp == null)
			{
				return;
			}
			this.AttributeComp.RemoveListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHealthChanged));
			this.AttributeComp.RemoveListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHealthChanged));
		}

		// Token: 0x0603C726 RID: 247590 RVA: 0x00E7EBC6 File Offset: 0x00E7CDC6
		private void OnHealthChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshData();
		}

		// Token: 0x0603C727 RID: 247591 RVA: 0x00E7EBD0 File Offset: 0x00E7CDD0
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

		// Token: 0x0603C728 RID: 247592 RVA: 0x00E7EC74 File Offset: 0x00E7CE74
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

		// Token: 0x0401F7F9 RID: 129017
		[Nullable(2)]
		private BaseAttributeComponent AttributeComp;

		// Token: 0x0401F7FA RID: 129018
		[Nullable(1)]
		private readonly List<FishingHpItem> ItemList = new List<FishingHpItem>();

		// Token: 0x0200BFAA RID: 49066
		private enum EChildType
		{
			// Token: 0x04039D29 RID: 236841
			ItemContainer,
			// Token: 0x04039D2A RID: 236842
			Item
		}
	}
}
