using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02004440 RID: 17472
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeKeyModeRowData
	{
		// Token: 0x0602C14F RID: 180559 RVA: 0x00C605F0 File Offset: 0x00C5E7F0
		[NullableContext(1)]
		public ChangeKeyModeRowData(int index, IChangeKeyModeRow changeKeyModeRow)
		{
			this.Index = index;
			this.SpriteResourceId = changeKeyModeRow.RowSpriteResourceId;
			this.DescriptionA = changeKeyModeRow.DescriptionA;
			this.DescriptionB = changeKeyModeRow.DescriptionB;
			this.DescriptionParametersA = changeKeyModeRow.DescriptionParametersA;
			this.DescriptionParametersB = changeKeyModeRow.DescriptionParametersB;
		}

		// Token: 0x04017BF4 RID: 97268
		public readonly int Index;

		// Token: 0x04017BF5 RID: 97269
		public readonly string SpriteResourceId;

		// Token: 0x04017BF6 RID: 97270
		public readonly string DescriptionA;

		// Token: 0x04017BF7 RID: 97271
		public readonly string DescriptionB;

		// Token: 0x04017BF8 RID: 97272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public readonly object[] DescriptionParametersA;

		// Token: 0x04017BF9 RID: 97273
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public readonly object[] DescriptionParametersB;
	}
}
