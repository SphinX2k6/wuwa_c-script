using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level
{
	// Token: 0x020052BD RID: 21181
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballLevelInfoStarItem : GridProxyAbstract<IPinballLevelStarData>
	{
		// Token: 0x06034BB7 RID: 215991 RVA: 0x00EBF704 File Offset: 0x00EBD904
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034BB8 RID: 215992 RVA: 0x00EBF770 File Offset: 0x00EBD970
		[NullableContext(1)]
		public override void Refresh(IPinballLevelStarData data, bool isSelected, int gridIndex)
		{
			string textStringId = data.ConfigConditionDesc ?? "";
			int valueOrDefault = data.ConfigTargetValue.GetValueOrDefault();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, new <>z__ReadOnlySingleElementList<object>(valueOrDefault));
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(data.Passed);
		}

		// Token: 0x0200AF3D RID: 44861
		private enum EComponent
		{
			// Token: 0x0403625E RID: 221790
			SprLight,
			// Token: 0x0403625F RID: 221791
			TxtConditionDesc
		}
	}
}
