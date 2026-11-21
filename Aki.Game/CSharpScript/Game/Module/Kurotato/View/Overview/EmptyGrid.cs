using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x0200472A RID: 18218
	internal class EmptyGrid : SyncGridProxyAbstract<int>
	{
		// Token: 0x0602DC1E RID: 187422 RVA: 0x00CCD1D4 File Offset: 0x00CCB3D4
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

		// Token: 0x0602DC1F RID: 187423 RVA: 0x00CCD21C File Offset: 0x00CCB41C
		public override void Refresh(int data)
		{
		}

		// Token: 0x0200A36A RID: 41834
		private enum EEmptyComp
		{
			// Token: 0x04032AAA RID: 207530
			PanelEmpty
		}
	}
}
