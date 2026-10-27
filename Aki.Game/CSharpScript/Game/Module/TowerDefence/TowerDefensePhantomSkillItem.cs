using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B58 RID: 19288
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefensePhantomSkillItem : GridProxyAbstract<ITowerDefensePhantomSkillItemData>
	{
		// Token: 0x06031F16 RID: 204566 RVA: 0x00B96C40 File Offset: 0x00B94E40
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

		// Token: 0x06031F17 RID: 204567 RVA: 0x00B96CD4 File Offset: 0x00B94ED4
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

		// Token: 0x0200ACDD RID: 44253
		private class EComponent
		{
			// Token: 0x04034867 RID: 215143
			public const int SkillText = 0;

			// Token: 0x04034868 RID: 215144
			public const int LevelText = 1;

			// Token: 0x04034869 RID: 215145
			public const int DescriptionText = 2;
		}
	}
}
