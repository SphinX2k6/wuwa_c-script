using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x020054EE RID: 21742
	internal class ActivityFunPlayPage : GridProxyAbstract<FunPlaySharpComment>
	{
		// Token: 0x06035E07 RID: 220679 RVA: 0x00F0CA20 File Offset: 0x00F0AC20
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035E08 RID: 220680 RVA: 0x00F0CA68 File Offset: 0x00F0AC68
		public override void Refresh(FunPlaySharpComment data, bool isSelected, int gridIndex)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06035E09 RID: 220681 RVA: 0x00F0CA7C File Offset: 0x00F0AC7C
		public override void OnSelected(bool fireEvent)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
		}

		// Token: 0x06035E0A RID: 220682 RVA: 0x00F0CA90 File Offset: 0x00F0AC90
		public override void OnDeselected(bool fireEvent)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0200B14B RID: 45387
		private class EComponent
		{
			// Token: 0x04036D38 RID: 224568
			public const int DotPic = 0;
		}
	}
}
