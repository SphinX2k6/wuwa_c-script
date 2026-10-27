using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D66 RID: 23910
	public class BattleDefendCreatureView : BattleEntityChildView
	{
		// Token: 0x0603CB50 RID: 248656 RVA: 0x00E93764 File Offset: 0x00E91964
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CB51 RID: 248657 RVA: 0x00E93854 File Offset: 0x00E91A54
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			LguiUtil.Instance.SetLocalText(base.GetText(0), "InstanceDungeonDefendCreatureTips", Array.Empty<object>());
			base.GetText(2).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			this.SetHpPercentageText(1f);
		}

		// Token: 0x0603CB52 RID: 248658 RVA: 0x00E938A8 File Offset: 0x00E91AA8
		[NullableContext(1)]
		protected override void AddEntityEvents(Entity entity)
		{
			base.ListenForAttributeChanged(entity, EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnDefendCreatureHealthChanged));
		}

		// Token: 0x0603CB53 RID: 248659 RVA: 0x00E938C0 File Offset: 0x00E91AC0
		private void SetHpPercentageText(float percentage)
		{
			string str = (percentage * 100f).ToString("F0");
			LguiUtil.Instance.SetLocalText(base.GetText(1), "InstanceDungeonDefendCreatureNumber", new <>z__ReadOnlySingleElementList<object>(str + "%"));
		}

		// Token: 0x0603CB54 RID: 248660 RVA: 0x00E93908 File Offset: 0x00E91B08
		private void OnDefendCreatureHealthChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			if (!this.IsValid())
			{
				return;
			}
			BaseAttributeComponent component = base.GetEntity().GetComponent<BaseAttributeComponent>();
			float currentValue = component.GetCurrentValue(EAttributeType.Life);
			float currentValue2 = component.GetCurrentValue(EAttributeType.LifeMax);
			float hpPercentageText = (currentValue2 > 0f) ? (currentValue / currentValue2) : 0f;
			this.SetHpPercentageText(hpPercentageText);
		}

		// Token: 0x0200C017 RID: 49175
		private enum EChildComponentType
		{
			// Token: 0x04039F6D RID: 237421
			TextDescription,
			// Token: 0x04039F6E RID: 237422
			TextProgress,
			// Token: 0x04039F6F RID: 237423
			TextAddProgress,
			// Token: 0x04039F70 RID: 237424
			SpriteYes,
			// Token: 0x04039F71 RID: 237425
			SpriteNo,
			// Token: 0x04039F72 RID: 237426
			PanelState
		}
	}
}
