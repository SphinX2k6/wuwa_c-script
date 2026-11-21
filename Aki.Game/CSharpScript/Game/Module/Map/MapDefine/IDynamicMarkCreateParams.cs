using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004539 RID: 17721
	[NullableContext(1)]
	public interface IDynamicMarkCreateParams
	{
		// Token: 0x17005997 RID: 22935
		// (get) Token: 0x0602CABA RID: 182970
		// (set) Token: 0x0602CABB RID: 182971
		TTrackTarget TrackTarget { get; set; }

		// Token: 0x17005998 RID: 22936
		// (get) Token: 0x0602CABC RID: 182972
		// (set) Token: 0x0602CABD RID: 182973
		int MarkConfigId { get; set; }

		// Token: 0x17005999 RID: 22937
		// (get) Token: 0x0602CABE RID: 182974
		// (set) Token: 0x0602CABF RID: 182975
		EMarkType MarkType { get; set; }

		// Token: 0x1700599A RID: 22938
		// (get) Token: 0x0602CAC0 RID: 182976
		// (set) Token: 0x0602CAC1 RID: 182977
		int? MarkId { get; set; }

		// Token: 0x1700599B RID: 22939
		// (get) Token: 0x0602CAC2 RID: 182978
		// (set) Token: 0x0602CAC3 RID: 182979
		ETrackSource? TrackSource { get; set; }

		// Token: 0x1700599C RID: 22940
		// (get) Token: 0x0602CAC4 RID: 182980
		// (set) Token: 0x0602CAC5 RID: 182981
		bool? DestroyOnUnTrack { get; set; }

		// Token: 0x1700599D RID: 22941
		// (get) Token: 0x0602CAC6 RID: 182982
		// (set) Token: 0x0602CAC7 RID: 182983
		int? TeleportId { get; set; }

		// Token: 0x1700599E RID: 22942
		// (get) Token: 0x0602CAC8 RID: 182984
		// (set) Token: 0x0602CAC9 RID: 182985
		int? EntityConfigId { get; set; }

		// Token: 0x1700599F RID: 22943
		// (get) Token: 0x0602CACA RID: 182986
		// (set) Token: 0x0602CACB RID: 182987
		MarkState? ServerMarkState { get; set; }

		// Token: 0x170059A0 RID: 22944
		// (get) Token: 0x0602CACC RID: 182988
		// (set) Token: 0x0602CACD RID: 182989
		[Nullable(2)]
		MapAndDungeonInfo MapAndDungeonInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170059A1 RID: 22945
		// (get) Token: 0x0602CACE RID: 182990
		// (set) Token: 0x0602CACF RID: 182991
		EMapGravityDirection? Gravity { get; set; }

		// Token: 0x170059A2 RID: 22946
		// (get) Token: 0x0602CAD0 RID: 182992
		// (set) Token: 0x0602CAD1 RID: 182993
		int? AreaId { get; set; }
	}
}
