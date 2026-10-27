using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DF2 RID: 19954
	public class RoguelikePhantomDotItem : GridProxyAbstract<int>
	{
		// Token: 0x060337EC RID: 210924 RVA: 0x00C084B0 File Offset: 0x00C066B0
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

		// Token: 0x060337ED RID: 210925 RVA: 0x00C084F8 File Offset: 0x00C066F8
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			base.GetItem(0).SetUIActive(isSelected);
		}

		// Token: 0x060337EE RID: 210926 RVA: 0x00C08507 File Offset: 0x00C06707
		public override void OnDeselected(bool fireEvent)
		{
			base.GetItem(0).SetUIActive(false);
		}

		// Token: 0x060337EF RID: 210927 RVA: 0x00C08516 File Offset: 0x00C06716
		public override void OnSelected(bool fireEvent)
		{
			base.GetItem(0).SetUIActive(true);
		}

		// Token: 0x0200AF79 RID: 44921
		private class EComponents
		{
			// Token: 0x04035484 RID: 218244
			public const int Item = 0;
		}
	}
}
