using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053FA RID: 21498
	[NullableContext(1)]
	public interface IChangeKeyModeRow
	{
		// Token: 0x1700840E RID: 33806
		// (get) Token: 0x06036F1B RID: 225051
		// (set) Token: 0x06036F1C RID: 225052
		string RowSpriteResourceId { get; set; }

		// Token: 0x1700840F RID: 33807
		// (get) Token: 0x06036F1D RID: 225053
		// (set) Token: 0x06036F1E RID: 225054
		string DescriptionA { get; set; }

		// Token: 0x17008410 RID: 33808
		// (get) Token: 0x06036F1F RID: 225055
		// (set) Token: 0x06036F20 RID: 225056
		[Nullable(new byte[]
		{
			2,
			1
		})]
		object[] DescriptionParametersA { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17008411 RID: 33809
		// (get) Token: 0x06036F21 RID: 225057
		// (set) Token: 0x06036F22 RID: 225058
		string DescriptionB { get; set; }

		// Token: 0x17008412 RID: 33810
		// (get) Token: 0x06036F23 RID: 225059
		// (set) Token: 0x06036F24 RID: 225060
		[Nullable(new byte[]
		{
			2,
			1
		})]
		object[] DescriptionParametersB { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
