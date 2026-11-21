using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C7E RID: 19582
	public class BattleUiPoolElement
	{
		// Token: 0x06030DAE RID: 200110 RVA: 0x00D9FB08 File Offset: 0x00D9DD08
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

		// Token: 0x04019E9C RID: 106140
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AActor> ActorList;

		// Token: 0x04019E9D RID: 106141
		public bool ExistMulti = true;

		// Token: 0x04019E9E RID: 106142
		[Nullable(2)]
		public AActor Actor;
	}
}
