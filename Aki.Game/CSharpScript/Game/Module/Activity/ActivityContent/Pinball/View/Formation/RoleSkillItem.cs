using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x0200636C RID: 25452
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleSkillItem : GridProxyAbstract<IRoleSkillItemData>
	{
		// Token: 0x06040067 RID: 262247 RVA: 0x00F7D1F4 File Offset: 0x00F7B3F4
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040068 RID: 262248 RVA: 0x00F7D280 File Offset: 0x00F7B480
		[NullableContext(1)]
		public override void Refresh(IRoleSkillItemData data, bool isSelected, int gridIndex)
		{
			PinballSkillDisplayConfig? pinballSkillDisplayConfigById = PinballConfig.Instance.GetPinballSkillDisplayConfigById(data.ConfigId);
			if (pinballSkillDisplayConfigById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), pinballSkillDisplayConfigById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), pinballSkillDisplayConfigById.Value.Desc, pinballSkillDisplayConfigById.Value.ValueList());
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0200C587 RID: 50567
		private enum ERoleSkillItem
		{
			// Token: 0x0403B9EF RID: 244207
			TitleText,
			// Token: 0x0403B9F0 RID: 244208
			DesText,
			// Token: 0x0403B9F1 RID: 244209
			LeaderItem
		}
	}
}
