using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance
{
	// Token: 0x02006E53 RID: 28243
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritOriginInfo : ISunSpiritOriginInfo
	{
		// Token: 0x17009A3A RID: 39482
		// (get) Token: 0x06044D61 RID: 281953 RVA: 0x010FD321 File Offset: 0x010FB521
		// (set) Token: 0x06044D62 RID: 281954 RVA: 0x010FD329 File Offset: 0x010FB529
		public EntityHandle EntityHandle { get; set; }

		// Token: 0x17009A3B RID: 39483
		// (get) Token: 0x06044D63 RID: 281955 RVA: 0x010FD332 File Offset: 0x010FB532
		// (set) Token: 0x06044D64 RID: 281956 RVA: 0x010FD33A File Offset: 0x010FB53A
		public Transform Transform { get; set; }

		// Token: 0x17009A3C RID: 39484
		// (get) Token: 0x06044D65 RID: 281957 RVA: 0x010FD343 File Offset: 0x010FB543
		// (set) Token: 0x06044D66 RID: 281958 RVA: 0x010FD34B File Offset: 0x010FB54B
		public int DisableMoveHandle { get; set; }

		// Token: 0x17009A3D RID: 39485
		// (get) Token: 0x06044D67 RID: 281959 RVA: 0x010FD354 File Offset: 0x010FB554
		// (set) Token: 0x06044D68 RID: 281960 RVA: 0x010FD35C File Offset: 0x010FB55C
		public int DisableMoveTickHandle { get; set; }
	}
}
