using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomInteract
{
	// Token: 0x020040D0 RID: 16592
	internal class PhantomGridItem : UiPanelBase
	{
		// Token: 0x06029EFF RID: 171775 RVA: 0x00BDB16E File Offset: 0x00BD936E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
		}

		// Token: 0x06029F00 RID: 171776 RVA: 0x00BDB1A8 File Offset: 0x00BD93A8
		[NullableContext(2)]
		public void SetIcon(string path)
		{
			UUITexture texture = base.GetTexture(1);
			if (path == null)
			{
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
				return;
			}
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			base.SetTextureByPath(path, texture, null, null);
		}
	}
}
