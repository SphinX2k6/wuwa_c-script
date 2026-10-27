using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060BA RID: 24762
	[NullableContext(2)]
	public interface ISolarSpeedRolePanelData
	{
		// Token: 0x170090EB RID: 37099
		// (get) Token: 0x0603E9B9 RID: 256441
		// (set) Token: 0x0603E9BA RID: 256442
		int Rank { get; set; }

		// Token: 0x170090EC RID: 37100
		// (get) Token: 0x0603E9BB RID: 256443
		// (set) Token: 0x0603E9BC RID: 256444
		int PlayerId { get; set; }

		// Token: 0x170090ED RID: 37101
		// (get) Token: 0x0603E9BD RID: 256445
		// (set) Token: 0x0603E9BE RID: 256446
		bool IsAddButtonAvailable { get; set; }

		// Token: 0x170090EE RID: 37102
		// (get) Token: 0x0603E9BF RID: 256447
		// (set) Token: 0x0603E9C0 RID: 256448
		bool IsSelf { get; set; }

		// Token: 0x170090EF RID: 37103
		// (get) Token: 0x0603E9C1 RID: 256449
		// (set) Token: 0x0603E9C2 RID: 256450
		[Nullable(1)]
		string BgPath { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170090F0 RID: 37104
		// (get) Token: 0x0603E9C3 RID: 256451
		// (set) Token: 0x0603E9C4 RID: 256452
		string MedalTexturePath { get; set; }

		// Token: 0x170090F1 RID: 37105
		// (get) Token: 0x0603E9C5 RID: 256453
		// (set) Token: 0x0603E9C6 RID: 256454
		[Nullable(1)]
		string MedalColorHex { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170090F2 RID: 37106
		// (get) Token: 0x0603E9C7 RID: 256455
		// (set) Token: 0x0603E9C8 RID: 256456
		[Nullable(1)]
		string FxColorHex { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170090F3 RID: 37107
		// (get) Token: 0x0603E9C9 RID: 256457
		// (set) Token: 0x0603E9CA RID: 256458
		string PlayerIndexIconPath { get; set; }

		// Token: 0x170090F4 RID: 37108
		// (get) Token: 0x0603E9CB RID: 256459
		// (set) Token: 0x0603E9CC RID: 256460
		[Nullable(1)]
		string NameText { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170090F5 RID: 37109
		// (get) Token: 0x0603E9CD RID: 256461
		// (set) Token: 0x0603E9CE RID: 256462
		string DescTextId { get; set; }

		// Token: 0x170090F6 RID: 37110
		// (get) Token: 0x0603E9CF RID: 256463
		// (set) Token: 0x0603E9D0 RID: 256464
		string TitleTextId { get; set; }

		// Token: 0x170090F7 RID: 37111
		// (get) Token: 0x0603E9D1 RID: 256465
		// (set) Token: 0x0603E9D2 RID: 256466
		[Nullable(1)]
		ISolarSpeedRoleIconPanelData IconData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170090F8 RID: 37112
		// (get) Token: 0x0603E9D3 RID: 256467
		// (set) Token: 0x0603E9D4 RID: 256468
		string AvatarTexturePath { get; set; }

		// Token: 0x170090F9 RID: 37113
		// (get) Token: 0x0603E9D5 RID: 256469
		// (set) Token: 0x0603E9D6 RID: 256470
		string LineTexturePath { get; set; }

		// Token: 0x170090FA RID: 37114
		// (get) Token: 0x0603E9D7 RID: 256471
		// (set) Token: 0x0603E9D8 RID: 256472
		string BgTexturePath { get; set; }
	}
}
