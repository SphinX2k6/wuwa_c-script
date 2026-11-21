using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x02006276 RID: 25206
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenActorRuntimeContext
	{
		// Token: 0x1700730F RID: 29455
		// (get) Token: 0x0603CD1E RID: 249118 RVA: 0x01179014 File Offset: 0x01177214
		public int Version
		{
			get
			{
				return this.DataVersion;
			}
		}

		// Token: 0x17007310 RID: 29456
		// (get) Token: 0x0603CD1F RID: 249119 RVA: 0x0117901C File Offset: 0x0117721C
		public int StagnationCount
		{
			get
			{
				return this.StagnatedActors.Count;
			}
		}

		// Token: 0x0603CD20 RID: 249120 RVA: 0x01179029 File Offset: 0x01177229
		public bool IsStagnated(AActor actor)
		{
			return this.StagnatedActors.ContainsKey(actor);
		}

		// Token: 0x0603CD21 RID: 249121 RVA: 0x01179038 File Offset: 0x01177238
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

		// Token: 0x0603CD22 RID: 249122 RVA: 0x01179088 File Offset: 0x01177288
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

		// Token: 0x0603CD23 RID: 249123 RVA: 0x011790E0 File Offset: 0x011772E0
		public void RemoveActor(AActor actor)
		{
			this.UnmarkStagnated(actor, 3);
		}

		// Token: 0x0603CD24 RID: 249124 RVA: 0x011790EB File Offset: 0x011772EB
		public void Reset()
		{
			if (this.StagnatedActors.Count <= 0)
			{
				return;
			}
			this.StagnatedActors.Clear();
			this.DataVersion++;
		}

		// Token: 0x04020415 RID: 132117
		public const int STAGNATION_SOURCE_ALL = 3;

		// Token: 0x04020416 RID: 132118
		private readonly Dictionary<AActor, int> StagnatedActors = new Dictionary<AActor, int>();

		// Token: 0x04020417 RID: 132119
		private int DataVersion;
	}
}
