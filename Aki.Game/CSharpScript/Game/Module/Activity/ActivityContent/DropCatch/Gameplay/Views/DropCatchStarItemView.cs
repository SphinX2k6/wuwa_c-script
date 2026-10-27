using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02006712 RID: 26386
	public class DropCatchStarItemView : GridProxyAbstract<bool>
	{
		// Token: 0x06041E6C RID: 269932 RVA: 0x00FFC5BE File Offset: 0x00FFA7BE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x06041E6D RID: 269933 RVA: 0x00FFC5F7 File Offset: 0x00FFA7F7
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(data);
		}

		// Token: 0x06041E6E RID: 269934 RVA: 0x00FFC60B File Offset: 0x00FFA80B
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
