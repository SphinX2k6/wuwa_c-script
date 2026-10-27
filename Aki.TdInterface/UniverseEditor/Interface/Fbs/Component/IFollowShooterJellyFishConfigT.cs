using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052A7 RID: 21159
	public class IFollowShooterJellyFishConfigT
	{
		// Token: 0x17009B28 RID: 39720
		// (get) Token: 0x060227E6 RID: 141286 RVA: 0x004C824E File Offset: 0x004C644E
		// (set) Token: 0x060227E7 RID: 141287 RVA: 0x004C8256 File Offset: 0x004C6456
		public EFollowShooterType Type { get; set; }

		// Token: 0x17009B29 RID: 39721
		// (get) Token: 0x060227E8 RID: 141288 RVA: 0x004C825F File Offset: 0x004C645F
		// (set) Token: 0x060227E9 RID: 141289 RVA: 0x004C8267 File Offset: 0x004C6467
		public float ResetRange { get; set; }

		// Token: 0x17009B2A RID: 39722
		// (get) Token: 0x060227EA RID: 141290 RVA: 0x004C8270 File Offset: 0x004C6470
		// (set) Token: 0x060227EB RID: 141291 RVA: 0x004C8278 File Offset: 0x004C6478
		public byte NullMask { get; set; }

		// Token: 0x060227EC RID: 141292 RVA: 0x004C8281 File Offset: 0x004C6481
		public IFollowShooterJellyFishConfigT()
		{
			this.Type = EFollowShooterType.JellyFish;
			this.ResetRange = 0f;
			this.NullMask = 0;
		}
	}
}
