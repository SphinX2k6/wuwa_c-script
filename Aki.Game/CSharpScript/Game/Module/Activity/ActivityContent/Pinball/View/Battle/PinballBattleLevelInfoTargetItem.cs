using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x020052F2 RID: 21234
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballBattleLevelInfoTargetItem : GridProxyAbstract<PinballBattleLevelInfoTargetData>
	{
		// Token: 0x06034D68 RID: 216424 RVA: 0x00EC51D4 File Offset: 0x00EC33D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034D69 RID: 216425 RVA: 0x00EC52A0 File Offset: 0x00EC34A0
		[NullableContext(1)]
		public override void Refresh(PinballBattleLevelInfoTargetData data, bool isSelected, int gridIndex)
		{
			if (data.IsSpecial)
			{
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(0);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUISprite sprite = base.GetSprite(3);
				if (sprite != null)
				{
					sprite.SetUIActive(data.IsFinish);
				}
			}
			else
			{
				UUIItem item3 = base.GetItem(0);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
				UUIItem item4 = base.GetItem(2);
				if (item4 != null)
				{
					item4.SetUIActive(false);
				}
				UUISprite sprite2 = base.GetSprite(1);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(data.IsFinish);
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.Desc, new <>z__ReadOnlySingleElementList<object>(data.Value));
		}

		// Token: 0x0200AF74 RID: 44916
		private enum ETargetItemComponent
		{
			// Token: 0x0403637C RID: 222076
			PnlPointNormal,
			// Token: 0x0403637D RID: 222077
			SprNormalTargetFinish,
			// Token: 0x0403637E RID: 222078
			PnlPointSpecial,
			// Token: 0x0403637F RID: 222079
			SprSpecialTargetFinish,
			// Token: 0x04036380 RID: 222080
			TextTargetDesc
		}
	}
}
