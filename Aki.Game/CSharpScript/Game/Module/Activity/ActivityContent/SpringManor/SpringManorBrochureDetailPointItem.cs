using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FDD RID: 20445
	public class SpringManorBrochureDetailPointItem : GridProxyAbstract<int>
	{
		// Token: 0x0603335F RID: 209759 RVA: 0x00E5A502 File Offset: 0x00E58702
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x06033360 RID: 209760 RVA: 0x00E5A53B File Offset: 0x00E5873B
		public override void Refresh(int curIndex, bool isSelected, int gridIndex)
		{
			this.SetSelectedState(isSelected);
		}

		// Token: 0x06033361 RID: 209761 RVA: 0x00E5A544 File Offset: 0x00E58744
		private void SetSelectedState(bool isSelected)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(isSelected);
		}

		// Token: 0x06033362 RID: 209762 RVA: 0x00E5A558 File Offset: 0x00E58758
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelectedState(true);
		}

		// Token: 0x06033363 RID: 209763 RVA: 0x00E5A561 File Offset: 0x00E58761
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelectedState(false);
		}
	}
}
