using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005295 RID: 21141
	public class PinballRoleSkillDetailItem : GridProxyAbstract<PinballSkillDisplayConfig>
	{
		// Token: 0x060349E0 RID: 215520 RVA: 0x00EB7818 File Offset: 0x00EB5A18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060349E1 RID: 215521 RVA: 0x00EB7881 File Offset: 0x00EB5A81
		public override void Refresh(PinballSkillDisplayConfig data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Desc, data.ValueList());
		}

		// Token: 0x0200AEF8 RID: 44792
		private enum EComponent
		{
			// Token: 0x040360F2 RID: 221426
			NameText,
			// Token: 0x040360F3 RID: 221427
			DescriptionText
		}
	}
}
