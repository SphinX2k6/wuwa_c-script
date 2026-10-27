using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005753 RID: 22355
	internal class EmptyGrid : SyncGridProxyAbstract<int>
	{
		// Token: 0x06038D0E RID: 232718 RVA: 0x00D7E7F4 File Offset: 0x00D7C9F4
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

		// Token: 0x06038D0F RID: 232719 RVA: 0x00D7E83C File Offset: 0x00D7CA3C
		public override void Refresh(int data)
		{
		}

		// Token: 0x0200B94C RID: 47436
		private enum EEmptyComp
		{
			// Token: 0x040380A4 RID: 229540
			PanelEmpty
		}
	}
}
