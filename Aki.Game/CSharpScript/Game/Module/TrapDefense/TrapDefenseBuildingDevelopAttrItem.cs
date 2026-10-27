using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A97 RID: 19095
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBuildingDevelopAttrItem : GridProxyAbstract<ITrapDefenseBuildingDevelopAttrInfo>
	{
		// Token: 0x060317F3 RID: 202739 RVA: 0x00B79138 File Offset: 0x00B77338
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060317F4 RID: 202740 RVA: 0x00B791C4 File Offset: 0x00B773C4
		public override void Refresh(ITrapDefenseBuildingDevelopAttrInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.SetTextureByPath(data.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			if (data.MultiTxt.GetValueOrDefault())
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Value, Array.Empty<object>());
				return;
			}
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(data.Value.ToString(), true);
		}

		// Token: 0x0401A762 RID: 108386
		protected ITrapDefenseBuildingDevelopAttrInfo Data;

		// Token: 0x0200ABF0 RID: 44016
		[NullableContext(0)]
		private class EAttr
		{
			// Token: 0x040343F8 RID: 214008
			public const int Icon = 0;

			// Token: 0x040343F9 RID: 214009
			public const int Title = 1;

			// Token: 0x040343FA RID: 214010
			public const int Value = 2;
		}
	}
}
