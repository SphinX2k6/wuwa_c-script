using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D48 RID: 19784
	public class BattleDefendCreatureView : BattleEntityChildView
	{
		// Token: 0x06031AAC RID: 203436 RVA: 0x00DE3FAC File Offset: 0x00DE21AC
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

		// Token: 0x06031AAD RID: 203437 RVA: 0x00DE409C File Offset: 0x00DE229C
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			LguiUtil.Instance.SetLocalText(base.GetText(0), "InstanceDungeonDefendCreatureTips", Array.Empty<object>());
			base.GetText(2).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			this.SetHpPercentageText(1f);
		}

		// Token: 0x06031AAE RID: 203438 RVA: 0x00DE40F0 File Offset: 0x00DE22F0
		[NullableContext(1)]
		protected override void AddEntityEvents(Entity entity)
		{
			base.ListenForAttributeChanged(entity, EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnDefendCreatureHealthChanged));
		}

		// Token: 0x06031AAF RID: 203439 RVA: 0x00DE4108 File Offset: 0x00DE2308
		private void SetHpPercentageText(float percentage)
		{
			string str = (percentage * 100f).ToString("F0");
			LguiUtil.Instance.SetLocalText(base.GetText(1), "InstanceDungeonDefendCreatureNumber", new <>z__ReadOnlySingleElementList<object>(str + "%"));
		}

		// Token: 0x06031AB0 RID: 203440 RVA: 0x00DE4150 File Offset: 0x00DE2350
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

		// Token: 0x0200AA1D RID: 43549
		private enum EChildComponentType
		{
			// Token: 0x04034930 RID: 215344
			TextDescription,
			// Token: 0x04034931 RID: 215345
			TextProgress,
			// Token: 0x04034932 RID: 215346
			TextAddProgress,
			// Token: 0x04034933 RID: 215347
			SpriteYes,
			// Token: 0x04034934 RID: 215348
			SpriteNo,
			// Token: 0x04034935 RID: 215349
			PanelState
		}
	}
}
