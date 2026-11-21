using System;

namespace Sharphereal.Core
{
	// Token: 0x02000006 RID: 6
	public class Time
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002146 File Offset: 0x00000346
		// (set) Token: 0x0600000D RID: 13 RVA: 0x0000214D File Offset: 0x0000034D
		public static int frameCount { get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002155 File Offset: 0x00000355
		// (set) Token: 0x0600000F RID: 15 RVA: 0x0000215C File Offset: 0x0000035C
		public static float deltaTime { get; private set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002164 File Offset: 0x00000364
		// (set) Token: 0x06000011 RID: 17 RVA: 0x0000216B File Offset: 0x0000036B
		public static float unscaledDeltaTime { get; private set; }

		// Token: 0x06000012 RID: 18 RVA: 0x00002173 File Offset: 0x00000373
		public static void Tick(float deltaTime, float unscaledDeltaTime)
		{
			Time.frameCount++;
			Time.deltaTime = deltaTime;
			Time.unscaledDeltaTime = unscaledDeltaTime;
		}
	}
}
