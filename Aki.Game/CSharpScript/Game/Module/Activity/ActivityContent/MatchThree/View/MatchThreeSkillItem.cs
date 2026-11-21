using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x02005426 RID: 21542
	public class MatchThreeSkillItem : GridProxyAbstract<MatchThreeSkill>
	{
		// Token: 0x06035807 RID: 219143 RVA: 0x00EF1684 File Offset: 0x00EEF884
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

		// Token: 0x06035808 RID: 219144 RVA: 0x00EF1730 File Offset: 0x00EEF930
		public override void Refresh(MatchThreeSkill data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.Desc, Array.Empty<object>());
			this.RefreshIcon(data);
			this.RefreshEnergy(data);
		}

		// Token: 0x06035809 RID: 219145 RVA: 0x00EF1788 File Offset: 0x00EEF988
		private void RefreshEnergy(MatchThreeSkill data)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(text, "MatchThreeRoleRecharge", new <>z__ReadOnlySingleElementList<object>(data.Energy));
		}

		// Token: 0x0603580A RID: 219146 RVA: 0x00EF17C4 File Offset: 0x00EEF9C4
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
