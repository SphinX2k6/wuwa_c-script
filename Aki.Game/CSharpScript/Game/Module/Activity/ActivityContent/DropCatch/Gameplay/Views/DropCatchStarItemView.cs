using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02005662 RID: 22114
	public class DropCatchStarItemView : GridProxyAbstract<bool>
	{
		// Token: 0x060369B8 RID: 223672 RVA: 0x00F3D98A File Offset: 0x00F3BB8A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x060369B9 RID: 223673 RVA: 0x00F3D9C3 File Offset: 0x00F3BBC3
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(data);
		}

		// Token: 0x060369BA RID: 223674 RVA: 0x00F3D9D7 File Offset: 0x00F3BBD7
		public void Refresh(bool isActive)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(isActive);
		}
	}
}
