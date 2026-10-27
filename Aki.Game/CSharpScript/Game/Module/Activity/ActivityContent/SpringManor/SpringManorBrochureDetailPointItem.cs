using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200605F RID: 24671
	public class SpringManorBrochureDetailPointItem : GridProxyAbstract<int>
	{
		// Token: 0x0603E69B RID: 255643 RVA: 0x00F1373E File Offset: 0x00F1193E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x0603E69C RID: 255644 RVA: 0x00F13777 File Offset: 0x00F11977
		public override void Refresh(int curIndex, bool isSelected, int gridIndex)
		{
			this.SetSelectedState(isSelected);
		}

		// Token: 0x0603E69D RID: 255645 RVA: 0x00F13780 File Offset: 0x00F11980
		private void SetSelectedState(bool isSelected)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(isSelected);
		}

		// Token: 0x0603E69E RID: 255646 RVA: 0x00F13794 File Offset: 0x00F11994
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelectedState(true);
		}

		// Token: 0x0603E69F RID: 255647 RVA: 0x00F1379D File Offset: 0x00F1199D
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelectedState(false);
		}
	}
}
