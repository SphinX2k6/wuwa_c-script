using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004547 RID: 17735
	public interface IMapConstructorParams
	{
		// Token: 0x170059CE RID: 22990
		// (get) Token: 0x0602CB1C RID: 183068
		// (set) Token: 0x0602CB1D RID: 183069
		int InstanceId { get; set; }

		// Token: 0x170059CF RID: 22991
		// (get) Token: 0x0602CB1E RID: 183070
		// (set) Token: 0x0602CB1F RID: 183071
		EMapType MapType { get; set; }

		// Token: 0x170059D0 RID: 22992
		// (get) Token: 0x0602CB20 RID: 183072
		// (set) Token: 0x0602CB21 RID: 183073
		float MapDefaultScale { get; set; }

		// Token: 0x170059D1 RID: 22993
		// (get) Token: 0x0602CB22 RID: 183074
		// (set) Token: 0x0602CB23 RID: 183075
		EMapGravityDirection? Gravity { get; set; }

		// Token: 0x170059D2 RID: 22994
		// (get) Token: 0x0602CB24 RID: 183076
		// (set) Token: 0x0602CB25 RID: 183077
		float? MarkScale { get; set; }

		// Token: 0x170059D3 RID: 22995
		// (get) Token: 0x0602CB26 RID: 183078
		// (set) Token: 0x0602CB27 RID: 183079
		float? ClickRange { get; set; }

		// Token: 0x170059D4 RID: 22996
		// (get) Token: 0x0602CB28 RID: 183080
		// (set) Token: 0x0602CB29 RID: 183081
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		Dictionary<string, UTexture> PreloadTiles { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }
	}
}
