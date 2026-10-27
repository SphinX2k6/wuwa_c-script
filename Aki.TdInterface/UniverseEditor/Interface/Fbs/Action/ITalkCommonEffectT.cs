using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A8 RID: 29352
	public class ITalkCommonEffectT
	{
		// Token: 0x1700D9B5 RID: 55733
		// (get) Token: 0x0603414F RID: 213327 RVA: 0x00700381 File Offset: 0x006FE581
		// (set) Token: 0x06034150 RID: 213328 RVA: 0x00700389 File Offset: 0x006FE589
		public ETalkEffectType Type { get; set; }

		// Token: 0x1700D9B6 RID: 55734
		// (get) Token: 0x06034151 RID: 213329 RVA: 0x00700392 File Offset: 0x006FE592
		// (set) Token: 0x06034152 RID: 213330 RVA: 0x0070039A File Offset: 0x006FE59A
		public string Path { get; set; }

		// Token: 0x1700D9B7 RID: 55735
		// (get) Token: 0x06034153 RID: 213331 RVA: 0x007003A3 File Offset: 0x006FE5A3
		// (set) Token: 0x06034154 RID: 213332 RVA: 0x007003AB File Offset: 0x006FE5AB
		public IAbsolutePos2T Pos2 { get; set; }

		// Token: 0x1700D9B8 RID: 55736
		// (get) Token: 0x06034155 RID: 213333 RVA: 0x007003B4 File Offset: 0x006FE5B4
		// (set) Token: 0x06034156 RID: 213334 RVA: 0x007003BC File Offset: 0x006FE5BC
		public bool StartFromLoop { get; set; }

		// Token: 0x1700D9B9 RID: 55737
		// (get) Token: 0x06034157 RID: 213335 RVA: 0x007003C5 File Offset: 0x006FE5C5
		// (set) Token: 0x06034158 RID: 213336 RVA: 0x007003CD File Offset: 0x006FE5CD
		public byte NullMask { get; set; }

		// Token: 0x06034159 RID: 213337 RVA: 0x007003D6 File Offset: 0x006FE5D6
		public ITalkCommonEffectT()
		{
			this.Type = ETalkEffectType.Effect;
			this.Path = null;
			this.Pos2 = null;
			this.StartFromLoop = false;
			this.NullMask = 0;
		}
	}
}
