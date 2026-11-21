using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B00 RID: 15104
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefensePhantomSkillItem : GridProxyAbstract<ITowerDefensePhantomSkillItemData>
	{
		// Token: 0x06026CA5 RID: 158885 RVA: 0x00ADAE7C File Offset: 0x00AD907C
		[NullableContext(1)]
		public override void Refresh(ITowerDefensePhantomSkillItemData data, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(0);
			if (StringUtils.IsEmpty(data.SkillTextId))
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
			}
			else
			{
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.SkillTextId, Array.Empty<object>());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_InstanceDungeonRecommendLevel_Text", new <>z__ReadOnlySingleElementList<object>(data.Level));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.DescriptionTextId, data.DescriptionArgs);
		}

		// Token: 0x06026CA6 RID: 158886 RVA: 0x00ADAF10 File Offset: 0x00AD9110
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x020096FC RID: 38652
		private class EComponent
		{
			// Token: 0x0402F210 RID: 193040
			public const int SkillText = 0;

			// Token: 0x0402F211 RID: 193041
			public const int LevelText = 1;

			// Token: 0x0402F212 RID: 193042
			public const int DescriptionText = 2;
		}
	}
}
