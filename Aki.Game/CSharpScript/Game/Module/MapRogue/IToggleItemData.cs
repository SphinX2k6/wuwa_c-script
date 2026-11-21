using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045A4 RID: 17828
	[NullableContext(1)]
	public interface IToggleItemData
	{
		// Token: 0x17005AB1 RID: 23217
		// (get) Token: 0x0602CEAE RID: 183982
		// (set) Token: 0x0602CEAF RID: 183983
		int Id { get; set; }

		// Token: 0x17005AB2 RID: 23218
		// (get) Token: 0x0602CEB0 RID: 183984
		// (set) Token: 0x0602CEB1 RID: 183985
		string Icon { get; set; }

		// Token: 0x17005AB3 RID: 23219
		// (get) Token: 0x0602CEB2 RID: 183986
		// (set) Token: 0x0602CEB3 RID: 183987
		string TitleId { get; set; }

		// Token: 0x17005AB4 RID: 23220
		// (get) Token: 0x0602CEB4 RID: 183988
		// (set) Token: 0x0602CEB5 RID: 183989
		string DescId { get; set; }

		// Token: 0x17005AB5 RID: 23221
		// (get) Token: 0x0602CEB6 RID: 183990
		// (set) Token: 0x0602CEB7 RID: 183991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		string[] DescParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005AB6 RID: 23222
		// (get) Token: 0x0602CEB8 RID: 183992
		// (set) Token: 0x0602CEB9 RID: 183993
		[Nullable(2)]
		string ProgressId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005AB7 RID: 23223
		// (get) Token: 0x0602CEBA RID: 183994
		// (set) Token: 0x0602CEBB RID: 183995
		[Nullable(new byte[]
		{
			2,
			1
		})]
		string[] ProgressParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005AB8 RID: 23224
		// (get) Token: 0x0602CEBC RID: 183996
		// (set) Token: 0x0602CEBD RID: 183997
		bool IsDisabled { get; set; }
	}
}
