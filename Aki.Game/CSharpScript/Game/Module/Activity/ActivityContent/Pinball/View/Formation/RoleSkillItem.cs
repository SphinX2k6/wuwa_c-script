using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x020052EA RID: 21226
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleSkillItem : GridProxyAbstract<IRoleSkillItemData>
	{
		// Token: 0x06034D28 RID: 216360 RVA: 0x00EC4154 File Offset: 0x00EC2354
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

		// Token: 0x06034D29 RID: 216361 RVA: 0x00EC41E0 File Offset: 0x00EC23E0
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

		// Token: 0x0200AF6E RID: 44910
		private enum ERoleSkillItem
		{
			// Token: 0x04036351 RID: 222033
			TitleText,
			// Token: 0x04036352 RID: 222034
			DesText,
			// Token: 0x04036353 RID: 222035
			LeaderItem
		}
	}
}
