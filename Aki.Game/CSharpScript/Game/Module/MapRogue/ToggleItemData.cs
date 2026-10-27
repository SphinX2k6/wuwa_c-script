using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055CF RID: 21967
	[NullableContext(1)]
	[Nullable(0)]
	public class ToggleItemData : IToggleItemData
	{
		// Token: 0x170086F2 RID: 34546
		// (get) Token: 0x06037FC0 RID: 229312 RVA: 0x00D42F82 File Offset: 0x00D41182
		// (set) Token: 0x06037FC1 RID: 229313 RVA: 0x00D42F8A File Offset: 0x00D4118A
		public int Id { get; set; }

		// Token: 0x170086F3 RID: 34547
		// (get) Token: 0x06037FC2 RID: 229314 RVA: 0x00D42F93 File Offset: 0x00D41193
		// (set) Token: 0x06037FC3 RID: 229315 RVA: 0x00D42F9B File Offset: 0x00D4119B
		public string Icon { get; set; }

		// Token: 0x170086F4 RID: 34548
		// (get) Token: 0x06037FC4 RID: 229316 RVA: 0x00D42FA4 File Offset: 0x00D411A4
		// (set) Token: 0x06037FC5 RID: 229317 RVA: 0x00D42FAC File Offset: 0x00D411AC
		public string TitleId { get; set; }

		// Token: 0x170086F5 RID: 34549
		// (get) Token: 0x06037FC6 RID: 229318 RVA: 0x00D42FB5 File Offset: 0x00D411B5
		// (set) Token: 0x06037FC7 RID: 229319 RVA: 0x00D42FBD File Offset: 0x00D411BD
		public string DescId { get; set; }

		// Token: 0x170086F6 RID: 34550
		// (get) Token: 0x06037FC8 RID: 229320 RVA: 0x00D42FC6 File Offset: 0x00D411C6
		// (set) Token: 0x06037FC9 RID: 229321 RVA: 0x00D42FCE File Offset: 0x00D411CE
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] DescParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170086F7 RID: 34551
		// (get) Token: 0x06037FCA RID: 229322 RVA: 0x00D42FD7 File Offset: 0x00D411D7
		// (set) Token: 0x06037FCB RID: 229323 RVA: 0x00D42FDF File Offset: 0x00D411DF
		[Nullable(2)]
		public string ProgressId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170086F8 RID: 34552
		// (get) Token: 0x06037FCC RID: 229324 RVA: 0x00D42FE8 File Offset: 0x00D411E8
		// (set) Token: 0x06037FCD RID: 229325 RVA: 0x00D42FF0 File Offset: 0x00D411F0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] ProgressParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170086F9 RID: 34553
		// (get) Token: 0x06037FCE RID: 229326 RVA: 0x00D42FF9 File Offset: 0x00D411F9
		// (set) Token: 0x06037FCF RID: 229327 RVA: 0x00D43001 File Offset: 0x00D41201
		public bool IsDisabled { get; set; }
	}
}
