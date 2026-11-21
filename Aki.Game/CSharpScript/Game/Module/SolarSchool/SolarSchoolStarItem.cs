using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059AB RID: 22955
	public class SolarSchoolStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x0603897A RID: 231802 RVA: 0x00FD57F7 File Offset: 0x00FD39F7
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
		}

		// Token: 0x0603897B RID: 231803 RVA: 0x00FD5804 File Offset: 0x00FD3A04
		public override void Refresh(bool lit, bool isSelected, int gridIndex)
		{
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(lit);
		}
	}
}
