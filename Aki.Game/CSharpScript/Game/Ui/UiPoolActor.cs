using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035F7 RID: 13815
	[NullableContext(1)]
	[Nullable(0)]
	public class UiPoolActor
	{
		// Token: 0x17004929 RID: 18729
		// (get) Token: 0x060232DE RID: 144094 RVA: 0x009FEA4D File Offset: 0x009FCC4D
		// (set) Token: 0x060232DF RID: 144095 RVA: 0x009FEA55 File Offset: 0x009FCC55
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

		// Token: 0x1700492A RID: 18730
		// (get) Token: 0x060232E0 RID: 144096 RVA: 0x009FEA5E File Offset: 0x009FCC5E
		public bool IsValid
		{
			get
			{
				AActor actorInternal = this.ActorInternal;
				return actorInternal != null && actorInternal.IsValid();
			}
		}

		// Token: 0x1700492B RID: 18731
		// (get) Token: 0x060232E1 RID: 144097 RVA: 0x009FEA71 File Offset: 0x009FCC71
		public UUIItem UiItem
		{
			get
			{
				AActor actorInternal = this.ActorInternal;
				return ((actorInternal != null) ? actorInternal.RootComponent : null) as UUIItem;
			}
		}

		// Token: 0x1700492C RID: 18732
		// (get) Token: 0x060232E2 RID: 144098 RVA: 0x009FEA8A File Offset: 0x009FCC8A
		public string Path
		{
			get
			{
				return this.PathInternal;
			}
		}

		// Token: 0x1700492D RID: 18733
		// (get) Token: 0x060232E3 RID: 144099 RVA: 0x009FEA92 File Offset: 0x009FCC92
		// (set) Token: 0x060232E4 RID: 144100 RVA: 0x009FEA9A File Offset: 0x009FCC9A
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

		// Token: 0x060232E5 RID: 144101 RVA: 0x009FEAA3 File Offset: 0x009FCCA3
		public void Clear()
		{
			if (!this.IsValid)
			{
				return;
			}
			ActorSystem.Instance.Put("UiPoolActor.Clear", this.ActorInternal, null);
			this.ActorInternal = null;
		}

		// Token: 0x060232E6 RID: 144102 RVA: 0x009FEACC File Offset: 0x009FCCCC
		public UiPoolActor(string path)
		{
			this.PathInternal = path;
		}

		// Token: 0x04013D9E RID: 81310
		[Nullable(2)]
		private AActor ActorInternal;

		// Token: 0x04013D9F RID: 81311
		private readonly string PathInternal = "";

		// Token: 0x04013DA0 RID: 81312
		private double EndTimeInternal;
	}
}
