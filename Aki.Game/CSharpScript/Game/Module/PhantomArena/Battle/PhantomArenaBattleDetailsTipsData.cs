using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x02004209 RID: 16905
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsTipsData : IPhantomArenaBattleDetailsTipsData
	{
		// Token: 0x170055F9 RID: 22009
		// (get) Token: 0x0602AB57 RID: 174935 RVA: 0x00C074FC File Offset: 0x00C056FC
		// (set) Token: 0x0602AB58 RID: 174936 RVA: 0x00C07504 File Offset: 0x00C05704
		public UUIItem AttachItem { get; set; }

		// Token: 0x170055FA RID: 22010
		// (get) Token: 0x0602AB59 RID: 174937 RVA: 0x00C0750D File Offset: 0x00C0570D
		// (set) Token: 0x0602AB5A RID: 174938 RVA: 0x00C07515 File Offset: 0x00C05715
		public UUIItem TriggerItem { get; set; }

		// Token: 0x170055FB RID: 22011
		// (get) Token: 0x0602AB5B RID: 174939 RVA: 0x00C0751E File Offset: 0x00C0571E
		// (set) Token: 0x0602AB5C RID: 174940 RVA: 0x00C07526 File Offset: 0x00C05726
		public EPhantomArenaBattleDetailsPositionType PositionType { get; set; }

		// Token: 0x170055FC RID: 22012
		// (get) Token: 0x0602AB5D RID: 174941 RVA: 0x00C0752F File Offset: 0x00C0572F
		// (set) Token: 0x0602AB5E RID: 174942 RVA: 0x00C07537 File Offset: 0x00C05737
		public EPhantomArenaBattleDetailsTipsShowType ShowType { get; set; }
	}
}
