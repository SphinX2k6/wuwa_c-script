using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200487A RID: 18554
	public class InstanceDungeonPicItem : UiPanelBase
	{
		// Token: 0x0602EACA RID: 191178 RVA: 0x00D072D0 File Offset: 0x00D054D0
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

		// Token: 0x0602EACB RID: 191179 RVA: 0x00D07318 File Offset: 0x00D05518
		[NullableContext(2)]
		public void RefreshItem(string picPath)
		{
			base.TrySetTextureByPath(picPath, base.GetTexture(0), null, null);
		}

		// Token: 0x0200A524 RID: 42276
		private enum EComponent
		{
			// Token: 0x0403321C RID: 209436
			PicTexture
		}
	}
}
