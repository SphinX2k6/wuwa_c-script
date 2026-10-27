using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x020064A8 RID: 25768
	public class MatchThreeSkillItem : GridProxyAbstract<MatchThreeSkill>
	{
		// Token: 0x06040B43 RID: 265027 RVA: 0x00FAA63C File Offset: 0x00FA883C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040B44 RID: 265028 RVA: 0x00FAA6E8 File Offset: 0x00FA88E8
		public override void Refresh(MatchThreeSkill data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.Desc, Array.Empty<object>());
			this.RefreshIcon(data);
			this.RefreshEnergy(data);
		}

		// Token: 0x06040B45 RID: 265029 RVA: 0x00FAA740 File Offset: 0x00FA8940
		private void RefreshEnergy(MatchThreeSkill data)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(text, "MatchThreeRoleRecharge", new <>z__ReadOnlySingleElementList<object>(data.Energy));
		}

		// Token: 0x06040B46 RID: 265030 RVA: 0x00FAA77C File Offset: 0x00FA897C
		private void RefreshIcon(MatchThreeSkill data)
		{
			UUISprite sprite = base.GetSprite(2);
			if (sprite == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(data.Icon))
			{
				sprite.SetUIActive(false);
				return;
			}
			sprite.SetUIActive(true);
			this.SetSpriteByPath(data.Icon, sprite, false, null, null);
		}
	}
}
