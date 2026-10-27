using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200615F RID: 24927
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeLevelInfoItem : GridProxyAbstract<RoverlikeLevelInfoItemData>
	{
		// Token: 0x0603F009 RID: 258057 RVA: 0x00F38760 File Offset: 0x00F36960
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F00A RID: 258058 RVA: 0x00F387A8 File Offset: 0x00F369A8
		public override void Refresh(RoverlikeLevelInfoItemData data, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, data.TextId, data.Params);
		}

		// Token: 0x0603F00B RID: 258059 RVA: 0x00F387D8 File Offset: 0x00F369D8
		public void PlayRefreshAnim()
		{
		}

		// Token: 0x0603F00C RID: 258060 RVA: 0x00F387DA File Offset: 0x00F369DA
		public override object GetKey(RoverlikeLevelInfoItemData data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0200C3BE RID: 50110
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B10B RID: 241931
			public const int TxtInfo = 0;
		}
	}
}
