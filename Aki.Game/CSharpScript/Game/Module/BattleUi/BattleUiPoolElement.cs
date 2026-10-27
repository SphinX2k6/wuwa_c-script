using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C9C RID: 23708
	public class BattleUiPoolElement
	{
		// Token: 0x0603BE5B RID: 245339 RVA: 0x00E4F480 File Offset: 0x00E4D680
		public void Clear()
		{
			if (this.ActorList != null)
			{
				foreach (AActor actor in this.ActorList)
				{
					ActorSystem.Instance.Put("BattleUiPool.Clear", actor, null);
				}
				this.ActorList.Clear();
			}
			this.Actor = null;
		}

		// Token: 0x0401F3E3 RID: 127971
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AActor> ActorList;

		// Token: 0x0401F3E4 RID: 127972
		public bool ExistMulti = true;

		// Token: 0x0401F3E5 RID: 127973
		[Nullable(2)]
		public AActor Actor;
	}
}
