using System;
using UnrealEngine;

// Token: 0x02003091 RID: 12433
public class CharacterSwimUtils
{
	// Token: 0x0400CC27 RID: 52263
	private const int MAX_BYTE = 255;

	// Token: 0x0400CC28 RID: 52264
	private const int EIGHTY = 80;

	// Token: 0x0400CC29 RID: 52265
	public static readonly FVector AfterTransformLocationOffset = new FVector(80f, 0f, 0f);

	// Token: 0x0400CC2A RID: 52266
	public static readonly FLinearColor DebugColor1 = new FLinearColor(255f, 255f, 0f, 1f);

	// Token: 0x0400CC2B RID: 52267
	public static readonly FLinearColor DebugColor2 = new FLinearColor(0f, 255f, 0f, 1f);

	// Token: 0x0400CC2C RID: 52268
	public static readonly FLinearColor DebugColor3 = new FLinearColor(255f, 0f, 0f, 1f);

	// Token: 0x0400CC2D RID: 52269
	public static readonly FLinearColor DebugColor4 = new FLinearColor(0f, 255f, 255f, 1f);
}
