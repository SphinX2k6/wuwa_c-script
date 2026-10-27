using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071C1 RID: 29121
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenActorRuntimeContext
	{
		// Token: 0x17009DBF RID: 40383
		// (get) Token: 0x06047423 RID: 291875 RVA: 0x0121F108 File Offset: 0x0121D308
		public int Version
		{
			get
			{
				return this.DataVersion;
			}
		}

		// Token: 0x17009DC0 RID: 40384
		// (get) Token: 0x06047424 RID: 291876 RVA: 0x0121F110 File Offset: 0x0121D310
		public int StagnationCount
		{
			get
			{
				return this.StagnatedActors.Count;
			}
		}

		// Token: 0x06047425 RID: 291877 RVA: 0x0121F11D File Offset: 0x0121D31D
		public bool IsStagnated(AActor actor)
		{
			return this.StagnatedActors.ContainsKey(actor);
		}

		// Token: 0x06047426 RID: 291878 RVA: 0x0121F12C File Offset: 0x0121D32C
		public bool MarkStagnated(AActor actor, EStagnationSource source)
		{
			int num2;
			int num = this.StagnatedActors.TryGetValue(actor, out num2) ? num2 : 0;
			int num3 = num | (int)source;
			if (num3 == num)
			{
				return false;
			}
			this.StagnatedActors[actor] = num3;
			if (num != 0)
			{
				return false;
			}
			this.DataVersion++;
			return true;
		}

		// Token: 0x06047427 RID: 291879 RVA: 0x0121F17C File Offset: 0x0121D37C
		public bool UnmarkStagnated(AActor actor, int sources)
		{
			int num;
			if (!this.StagnatedActors.TryGetValue(actor, out num))
			{
				return false;
			}
			int num2 = num & ~sources;
			if (num2 == num)
			{
				return false;
			}
			if (num2 != 0)
			{
				this.StagnatedActors[actor] = num2;
				return false;
			}
			this.StagnatedActors.Remove(actor);
			this.DataVersion++;
			return true;
		}

		// Token: 0x06047428 RID: 291880 RVA: 0x0121F1D4 File Offset: 0x0121D3D4
		public void RemoveActor(AActor actor)
		{
			this.UnmarkStagnated(actor, 3);
		}

		// Token: 0x06047429 RID: 291881 RVA: 0x0121F1DF File Offset: 0x0121D3DF
		public void Reset()
		{
			if (this.StagnatedActors.Count <= 0)
			{
				return;
			}
			this.StagnatedActors.Clear();
			this.DataVersion++;
		}

		// Token: 0x040257A6 RID: 153510
		public const int STAGNATION_SOURCE_ALL = 3;

		// Token: 0x040257A7 RID: 153511
		private readonly Dictionary<AActor, int> StagnatedActors = new Dictionary<AActor, int>();

		// Token: 0x040257A8 RID: 153512
		private int DataVersion;
	}
}
