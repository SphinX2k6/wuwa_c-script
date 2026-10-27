using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060BB RID: 24763
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSpeedRolePanelData : ISolarSpeedRolePanelData
	{
		// Token: 0x170090FB RID: 37115
		// (get) Token: 0x0603E9D9 RID: 256473 RVA: 0x00F205AF File Offset: 0x00F1E7AF
		// (set) Token: 0x0603E9DA RID: 256474 RVA: 0x00F205B7 File Offset: 0x00F1E7B7
		public int Rank { get; set; }

		// Token: 0x170090FC RID: 37116
		// (get) Token: 0x0603E9DB RID: 256475 RVA: 0x00F205C0 File Offset: 0x00F1E7C0
		// (set) Token: 0x0603E9DC RID: 256476 RVA: 0x00F205C8 File Offset: 0x00F1E7C8
		public int PlayerId { get; set; }

		// Token: 0x170090FD RID: 37117
		// (get) Token: 0x0603E9DD RID: 256477 RVA: 0x00F205D1 File Offset: 0x00F1E7D1
		// (set) Token: 0x0603E9DE RID: 256478 RVA: 0x00F205D9 File Offset: 0x00F1E7D9
		public bool IsAddButtonAvailable { get; set; }

		// Token: 0x170090FE RID: 37118
		// (get) Token: 0x0603E9DF RID: 256479 RVA: 0x00F205E2 File Offset: 0x00F1E7E2
		// (set) Token: 0x0603E9E0 RID: 256480 RVA: 0x00F205EA File Offset: 0x00F1E7EA
		public bool IsSelf { get; set; }

		// Token: 0x170090FF RID: 37119
		// (get) Token: 0x0603E9E1 RID: 256481 RVA: 0x00F205F3 File Offset: 0x00F1E7F3
		// (set) Token: 0x0603E9E2 RID: 256482 RVA: 0x00F205FB File Offset: 0x00F1E7FB
		[Nullable(1)]
		public string BgPath { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17009100 RID: 37120
		// (get) Token: 0x0603E9E3 RID: 256483 RVA: 0x00F20604 File Offset: 0x00F1E804
		// (set) Token: 0x0603E9E4 RID: 256484 RVA: 0x00F2060C File Offset: 0x00F1E80C
		public string MedalTexturePath { get; set; }

		// Token: 0x17009101 RID: 37121
		// (get) Token: 0x0603E9E5 RID: 256485 RVA: 0x00F20615 File Offset: 0x00F1E815
		// (set) Token: 0x0603E9E6 RID: 256486 RVA: 0x00F2061D File Offset: 0x00F1E81D
		[Nullable(1)]
		public string MedalColorHex { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17009102 RID: 37122
		// (get) Token: 0x0603E9E7 RID: 256487 RVA: 0x00F20626 File Offset: 0x00F1E826
		// (set) Token: 0x0603E9E8 RID: 256488 RVA: 0x00F2062E File Offset: 0x00F1E82E
		[Nullable(1)]
		public string FxColorHex { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17009103 RID: 37123
		// (get) Token: 0x0603E9E9 RID: 256489 RVA: 0x00F20637 File Offset: 0x00F1E837
		// (set) Token: 0x0603E9EA RID: 256490 RVA: 0x00F2063F File Offset: 0x00F1E83F
		public string PlayerIndexIconPath { get; set; }

		// Token: 0x17009104 RID: 37124
		// (get) Token: 0x0603E9EB RID: 256491 RVA: 0x00F20648 File Offset: 0x00F1E848
		// (set) Token: 0x0603E9EC RID: 256492 RVA: 0x00F20650 File Offset: 0x00F1E850
		[Nullable(1)]
		public string NameText { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17009105 RID: 37125
		// (get) Token: 0x0603E9ED RID: 256493 RVA: 0x00F20659 File Offset: 0x00F1E859
		// (set) Token: 0x0603E9EE RID: 256494 RVA: 0x00F20661 File Offset: 0x00F1E861
		public string DescTextId { get; set; }

		// Token: 0x17009106 RID: 37126
		// (get) Token: 0x0603E9EF RID: 256495 RVA: 0x00F2066A File Offset: 0x00F1E86A
		// (set) Token: 0x0603E9F0 RID: 256496 RVA: 0x00F20672 File Offset: 0x00F1E872
		public string TitleTextId { get; set; }

		// Token: 0x17009107 RID: 37127
		// (get) Token: 0x0603E9F1 RID: 256497 RVA: 0x00F2067B File Offset: 0x00F1E87B
		// (set) Token: 0x0603E9F2 RID: 256498 RVA: 0x00F20683 File Offset: 0x00F1E883
		[Nullable(1)]
		public ISolarSpeedRoleIconPanelData IconData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17009108 RID: 37128
		// (get) Token: 0x0603E9F3 RID: 256499 RVA: 0x00F2068C File Offset: 0x00F1E88C
		// (set) Token: 0x0603E9F4 RID: 256500 RVA: 0x00F20694 File Offset: 0x00F1E894
		public string AvatarTexturePath { get; set; }

		// Token: 0x17009109 RID: 37129
		// (get) Token: 0x0603E9F5 RID: 256501 RVA: 0x00F2069D File Offset: 0x00F1E89D
		// (set) Token: 0x0603E9F6 RID: 256502 RVA: 0x00F206A5 File Offset: 0x00F1E8A5
		public string LineTexturePath { get; set; }

		// Token: 0x1700910A RID: 37130
		// (get) Token: 0x0603E9F7 RID: 256503 RVA: 0x00F206AE File Offset: 0x00F1E8AE
		// (set) Token: 0x0603E9F8 RID: 256504 RVA: 0x00F206B6 File Offset: 0x00F1E8B6
		public string BgTexturePath { get; set; }
	}
}
