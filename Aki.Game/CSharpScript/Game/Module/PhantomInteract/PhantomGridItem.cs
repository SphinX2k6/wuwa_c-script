using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomInteract
{
	// Token: 0x02005100 RID: 20736
	internal class PhantomGridItem : UiPanelBase
	{
		// Token: 0x06035006 RID: 217094 RVA: 0x00C8DE92 File Offset: 0x00C8C092
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
		}

		// Token: 0x06035007 RID: 217095 RVA: 0x00C8DECC File Offset: 0x00C8C0CC
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
