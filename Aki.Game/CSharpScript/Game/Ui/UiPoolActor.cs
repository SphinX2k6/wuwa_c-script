using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046C6 RID: 18118
	[NullableContext(1)]
	[Nullable(0)]
	public class UiPoolActor
	{
		// Token: 0x1700766D RID: 30317
		// (get) Token: 0x0602EB92 RID: 191378 RVA: 0x00AD00B9 File Offset: 0x00ACE2B9
		// (set) Token: 0x0602EB93 RID: 191379 RVA: 0x00AD00C1 File Offset: 0x00ACE2C1
		[Nullable(2)]
		public AActor Actor
		{
			[NullableContext(2)]
			get
			{
				return this.ActorInternal;
			}
			[NullableContext(2)]
			set
			{
				this.ActorInternal = value;
			}
		}

		// Token: 0x1700766E RID: 30318
		// (get) Token: 0x0602EB94 RID: 191380 RVA: 0x00AD00CA File Offset: 0x00ACE2CA
		public bool IsValid
		{
			get
			{
				AActor actorInternal = this.ActorInternal;
				return actorInternal != null && actorInternal.IsValid();
			}
		}

		// Token: 0x1700766F RID: 30319
		// (get) Token: 0x0602EB95 RID: 191381 RVA: 0x00AD00DD File Offset: 0x00ACE2DD
		public UUIItem UiItem
		{
			get
			{
				AActor actorInternal = this.ActorInternal;
				return ((actorInternal != null) ? actorInternal.RootComponent : null) as UUIItem;
			}
		}

		// Token: 0x17007670 RID: 30320
		// (get) Token: 0x0602EB96 RID: 191382 RVA: 0x00AD00F6 File Offset: 0x00ACE2F6
		public string Path
		{
			get
			{
				return this.PathInternal;
			}
		}

		// Token: 0x17007671 RID: 30321
		// (get) Token: 0x0602EB97 RID: 191383 RVA: 0x00AD00FE File Offset: 0x00ACE2FE
		// (set) Token: 0x0602EB98 RID: 191384 RVA: 0x00AD0106 File Offset: 0x00ACE306
		public double EndTime
		{
			get
			{
				return this.EndTimeInternal;
			}
			set
			{
				this.EndTimeInternal = value;
			}
		}

		// Token: 0x0602EB99 RID: 191385 RVA: 0x00AD010F File Offset: 0x00ACE30F
		public void Clear()
		{
			if (!this.IsValid)
			{
				return;
			}
			ActorSystem.Instance.Put("UiPoolActor.Clear", this.ActorInternal, null);
			this.ActorInternal = null;
		}

		// Token: 0x0602EB9A RID: 191386 RVA: 0x00AD0138 File Offset: 0x00ACE338
		public UiPoolActor(string path)
		{
			this.PathInternal = path;
		}

		// Token: 0x040196F7 RID: 104183
		[Nullable(2)]
		private AActor ActorInternal;

		// Token: 0x040196F8 RID: 104184
		private readonly string PathInternal = "";

		// Token: 0x040196F9 RID: 104185
		private double EndTimeInternal;
	}
}
