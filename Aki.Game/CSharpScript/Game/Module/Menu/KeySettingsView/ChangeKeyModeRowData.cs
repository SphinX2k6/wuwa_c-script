using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200545D RID: 21597
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeKeyModeRowData
	{
		// Token: 0x06037206 RID: 225798 RVA: 0x00D111D8 File Offset: 0x00D0F3D8
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

		// Token: 0x0401D15B RID: 119131
		public readonly int Index;

		// Token: 0x0401D15C RID: 119132
		public readonly string SpriteResourceId;

		// Token: 0x0401D15D RID: 119133
		public readonly string DescriptionA;

		// Token: 0x0401D15E RID: 119134
		public readonly string DescriptionB;

		// Token: 0x0401D15F RID: 119135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public readonly object[] DescriptionParametersA;

		// Token: 0x0401D160 RID: 119136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public readonly object[] DescriptionParametersB;
	}
}
