using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x02003992 RID: 14738
	public class UiCameraSequenceBlackScreenView : UiPanelBase
	{
		// Token: 0x06025F3D RID: 155453 RVA: 0x00AA71BC File Offset: 0x00AA53BC
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

		// Token: 0x06025F3E RID: 155454 RVA: 0x00AA7204 File Offset: 0x00AA5404
		[NullableContext(2)]
		public AActor GetBlackScreenTextureActor()
		{
			UUITexture texture = base.GetTexture(0);
			if (texture == null)
			{
				return null;
			}
			return texture.GetOwner();
		}

		// Token: 0x04014DF6 RID: 85494
		private const int BlackTextureComponentIndex = 0;
	}
}
