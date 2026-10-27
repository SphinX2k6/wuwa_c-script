using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level
{
	// Token: 0x0200633F RID: 25407
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballLevelInfoStarItem : GridProxyAbstract<IPinballLevelStarData>
	{
		// Token: 0x0603FEF6 RID: 261878 RVA: 0x00F787A4 File Offset: 0x00F769A4
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

		// Token: 0x0603FEF7 RID: 261879 RVA: 0x00F78810 File Offset: 0x00F76A10
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

		// Token: 0x0200C556 RID: 50518
		private enum EComponent
		{
			// Token: 0x0403B8FC RID: 243964
			SprLight,
			// Token: 0x0403B8FD RID: 243965
			TxtConditionDesc
		}
	}
}
