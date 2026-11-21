using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043DD RID: 17373
	[NullableContext(1)]
	public interface IChangeKeyModeRow
	{
		// Token: 0x170057DA RID: 22490
		// (get) Token: 0x0602BE63 RID: 179811
		// (set) Token: 0x0602BE64 RID: 179812
		string RowSpriteResourceId { get; set; }

		// Token: 0x170057DB RID: 22491
		// (get) Token: 0x0602BE65 RID: 179813
		// (set) Token: 0x0602BE66 RID: 179814
		string DescriptionA { get; set; }

		// Token: 0x170057DC RID: 22492
		// (get) Token: 0x0602BE67 RID: 179815
		// (set) Token: 0x0602BE68 RID: 179816
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

		// Token: 0x170057DD RID: 22493
		// (get) Token: 0x0602BE69 RID: 179817
		// (set) Token: 0x0602BE6A RID: 179818
		string DescriptionB { get; set; }

		// Token: 0x170057DE RID: 22494
		// (get) Token: 0x0602BE6B RID: 179819
		// (set) Token: 0x0602BE6C RID: 179820
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
