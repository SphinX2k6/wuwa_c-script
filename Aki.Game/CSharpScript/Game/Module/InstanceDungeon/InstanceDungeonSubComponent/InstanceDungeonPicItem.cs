using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058A2 RID: 22690
	public class InstanceDungeonPicItem : UiPanelBase
	{
		// Token: 0x06039BA7 RID: 236455 RVA: 0x00DB83B8 File Offset: 0x00DB65B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039BA8 RID: 236456 RVA: 0x00DB8400 File Offset: 0x00DB6600
		[NullableContext(2)]
		public void RefreshItem(string picPath)
		{
			base.TrySetTextureByPath(picPath, base.GetTexture(0), null, null);
		}

		// Token: 0x0200BB0B RID: 47883
		private enum EComponent
		{
			// Token: 0x0403881B RID: 231451
			PicTexture
		}
	}
}
