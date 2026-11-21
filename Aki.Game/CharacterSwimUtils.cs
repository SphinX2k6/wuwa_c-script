using System;
using UnrealEngine;

// Token: 0x020025E8 RID: 9704
public class CharacterSwimUtils
{
	// Token: 0x0400D00A RID: 53258
	private const int MAX_BYTE = 255;

	// Token: 0x0400D00B RID: 53259
	private const int EIGHTY = 80;

	// Token: 0x0400D00C RID: 53260
	public static readonly FVector AfterTransformLocationOffset = new FVector(80f, 0f, 0f);

	// Token: 0x0400D00D RID: 53261
	public static readonly FLinearColor DebugColor1 = new FLinearColor(255f, 255f, 0f, 1f);

	// Token: 0x0400D00E RID: 53262
	public static readonly FLinearColor DebugColor2 = new FLinearColor(0f, 255f, 0f, 1f);

	// Token: 0x0400D00F RID: 53263
	public static readonly FLinearColor DebugColor3 = new FLinearColor(255f, 0f, 0f, 1f);

	// Token: 0x0400D010 RID: 53264
	public static readonly FLinearColor DebugColor4 = new FLinearColor(0f, 255f, 255f, 1f);
}
