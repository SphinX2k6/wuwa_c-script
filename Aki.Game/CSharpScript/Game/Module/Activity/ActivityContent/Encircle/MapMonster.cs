using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006663 RID: 26211
	[NullableContext(2)]
	[Nullable(0)]
	internal class MapMonster
	{
		// Token: 0x06041AF5 RID: 269045 RVA: 0x00FEDF42 File Offset: 0x00FEC142
		[NullableContext(1)]
		public MapMonster(IHexPos pos, int mapItemId, int priority)
		{
			this.PosInternal = pos;
			this.MapItemIdInternal = new int?(mapItemId);
			this.PriorityInternal = priority;
		}

		// Token: 0x17009632 RID: 38450
		// (get) Token: 0x06041AF6 RID: 269046 RVA: 0x00FEDF6B File Offset: 0x00FEC16B
		public int Priority
		{
			get
			{
				return this.PriorityInternal;
			}
		}

		// Token: 0x17009633 RID: 38451
		// (get) Token: 0x06041AF7 RID: 269047 RVA: 0x00FEDF73 File Offset: 0x00FEC173
		// (set) Token: 0x06041AF8 RID: 269048 RVA: 0x00FEDF7B File Offset: 0x00FEC17B
		public IHexPos Pos
		{
			get
			{
				return this.PosInternal;
			}
			set
			{
				this.PosInternal = value;
			}
		}

		// Token: 0x17009634 RID: 38452
		// (get) Token: 0x06041AF9 RID: 269049 RVA: 0x00FEDF84 File Offset: 0x00FEC184
		// (set) Token: 0x06041AFA RID: 269050 RVA: 0x00FEDF8C File Offset: 0x00FEC18C
		public bool BeTrapped
		{
			get
			{
				return this.BeTrappedInternal;
			}
			set
			{
				this.BeTrappedInternal = value;
			}
		}

		// Token: 0x17009635 RID: 38453
		// (get) Token: 0x06041AFB RID: 269051 RVA: 0x00FEDF95 File Offset: 0x00FEC195
		// (set) Token: 0x06041AFC RID: 269052 RVA: 0x00FEDF9D File Offset: 0x00FEC19D
		public bool BeCaught
		{
			get
			{
				return this.BeCaughtInternal;
			}
			set
			{
				this.BeCaughtInternal = value;
			}
		}

		// Token: 0x17009636 RID: 38454
		// (get) Token: 0x06041AFD RID: 269053 RVA: 0x00FEDFA6 File Offset: 0x00FEC1A6
		// (set) Token: 0x06041AFE RID: 269054 RVA: 0x00FEDFAE File Offset: 0x00FEC1AE
		public int? MapItemId
		{
			get
			{
				return this.MapItemIdInternal;
			}
			set
			{
				this.MapItemIdInternal = value;
			}
		}

		// Token: 0x040222BF RID: 139967
		private IHexPos PosInternal;

		// Token: 0x040222C0 RID: 139968
		private int? MapItemIdInternal;

		// Token: 0x040222C1 RID: 139969
		private bool BeTrappedInternal;

		// Token: 0x040222C2 RID: 139970
		private bool BeCaughtInternal;

		// Token: 0x040222C3 RID: 139971
		private readonly int PriorityInternal = 1;
	}
}
