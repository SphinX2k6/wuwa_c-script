using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Enum;
using AkiClient.Game.Aki.Data.UiNavigation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038B0 RID: 14512
	[NullableContext(1)]
	[Nullable(0)]
	public class UiNavigationCursorModule
	{
		// Token: 0x06025A16 RID: 154134 RVA: 0x00A96FDE File Offset: 0x00A951DE
		public UiNavigationCursorModule(SNavigationCursor cursor)
		{
			this.Cursor = cursor;
		}

		// Token: 0x06025A17 RID: 154135 RVA: 0x00A96FF0 File Offset: 0x00A951F0
		public FVector2D GetCursorOffset()
		{
			switch (this.Cursor.OffsetType)
			{
			case ECursorOffsetType.Left:
				return new FVector2D(0f, 0.5f);
			case ECursorOffsetType.Top:
				return new FVector2D(0.5f, 1f);
			case ECursorOffsetType.Right:
				return new FVector2D(1f, 0.5f);
			case ECursorOffsetType.Down:
				return new FVector2D(0.5f, 0f);
			default:
				return new FVector2D(0f, 0f);
			}
		}

		// Token: 0x06025A18 RID: 154136 RVA: 0x00A97078 File Offset: 0x00A95278
		public int GetCursorRotation()
		{
			if (this.Cursor.OffsetType == ECursorOffsetType.Left)
			{
				return 0;
			}
			if (this.Cursor.OffsetType == ECursorOffsetType.Top)
			{
				return 270;
			}
			if (this.Cursor.OffsetType == ECursorOffsetType.Right)
			{
				return 180;
			}
			if (this.Cursor.OffsetType == ECursorOffsetType.Down)
			{
				return 90;
			}
			return 0;
		}

		// Token: 0x06025A19 RID: 154137 RVA: 0x00A970F8 File Offset: 0x00A952F8
		public FVector2D GetBoundOffset()
		{
			switch (this.Cursor.OffsetType)
			{
			case ECursorOffsetType.Left:
				return new FVector2D((float)(-(float)this.Cursor.BoundOffset), 0f);
			case ECursorOffsetType.Top:
				return new FVector2D(0f, (float)this.Cursor.BoundOffset);
			case ECursorOffsetType.Right:
				return new FVector2D((float)this.Cursor.BoundOffset, 0f);
			case ECursorOffsetType.Down:
				return new FVector2D(0f, (float)(-(float)this.Cursor.BoundOffset));
			default:
				return new FVector2D(0f, 0f);
			}
		}

		// Token: 0x04014C58 RID: 85080
		private readonly SNavigationCursor Cursor;
	}
}
