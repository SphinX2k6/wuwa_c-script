using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059AA RID: 22954
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolSkillItem : GridProxyAbstract<SolarSchoolBehaviorSkill>
	{
		// Token: 0x06038976 RID: 231798 RVA: 0x00FD562C File Offset: 0x00FD382C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038977 RID: 231799 RVA: 0x00FD573C File Offset: 0x00FD393C
		public override void Refresh(SolarSchoolBehaviorSkill data, bool isSelected, int gridIndex)
		{
			base.TrySetTextureByPath(data.Role.FrameHeadIcon, base.GetTexture(2), null, null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), data.Role.Name, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), this.GetSkillDesc(data), Array.Empty<object>());
		}

		// Token: 0x06038978 RID: 231800 RVA: 0x00FD57B0 File Offset: 0x00FD39B0
		[return: Nullable(2)]
		private string GetSkillDesc(SolarSchoolBehaviorSkill data)
		{
			if (!string.IsNullOrEmpty(data.Buff.EffectDesc))
			{
				return data.Buff.EffectDesc;
			}
			return data.FavorLevel.SkillDesc;
		}

		// Token: 0x0200B555 RID: 46421
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038105 RID: 229637
			public const int Root = 0;

			// Token: 0x04038106 RID: 229638
			public const int PnlHead = 1;

			// Token: 0x04038107 RID: 229639
			public const int TexHead = 2;

			// Token: 0x04038108 RID: 229640
			public const int PnlIcon = 3;

			// Token: 0x04038109 RID: 229641
			public const int TexIcon = 4;

			// Token: 0x0403810A RID: 229642
			public const int TxtName = 5;

			// Token: 0x0403810B RID: 229643
			public const int TxtDesc = 6;
		}
	}
}
