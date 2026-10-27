using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Enum;
using AkiClient.Game.Aki.Data.UiNavigation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004939 RID: 18745
	[NullableContext(1)]
	[Nullable(0)]
	public class UiNavigationCursorModule
	{
		// Token: 0x06030EE9 RID: 200425 RVA: 0x00B5C16E File Offset: 0x00B5A36E
		public UiNavigationCursorModule(SNavigationCursor cursor)
		{
			this.Cursor = cursor;
		}

		// Token: 0x06030EEA RID: 200426 RVA: 0x00B5C180 File Offset: 0x00B5A380
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

		// Token: 0x06030EEB RID: 200427 RVA: 0x00B5C208 File Offset: 0x00B5A408
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

		// Token: 0x06030EEC RID: 200428 RVA: 0x00B5C288 File Offset: 0x00B5A488
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

		// Token: 0x0401A3E5 RID: 107493
		private readonly SNavigationCursor Cursor;
	}
}
