using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006317 RID: 25367
	public class PinballRoleSkillDetailItem : GridProxyAbstract<PinballSkillDisplayConfig>
	{
		// Token: 0x0603FD1F RID: 261407 RVA: 0x00F708BC File Offset: 0x00F6EABC
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

		// Token: 0x0603FD20 RID: 261408 RVA: 0x00F70925 File Offset: 0x00F6EB25
		public override void Refresh(PinballSkillDisplayConfig data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Desc, data.ValueList());
		}

		// Token: 0x0200C511 RID: 50449
		private enum EComponent
		{
			// Token: 0x0403B790 RID: 243600
			NameText,
			// Token: 0x0403B791 RID: 243601
			DescriptionText
		}
	}
}
