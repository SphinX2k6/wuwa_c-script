using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004548 RID: 17736
	public class MapConstructorParams : IMapConstructorParams
	{
		// Token: 0x170059D5 RID: 22997
		// (get) Token: 0x0602CB2A RID: 183082 RVA: 0x00C86B53 File Offset: 0x00C84D53
		// (set) Token: 0x0602CB2B RID: 183083 RVA: 0x00C86B5B File Offset: 0x00C84D5B
		public int InstanceId { get; set; }

		// Token: 0x170059D6 RID: 22998
		// (get) Token: 0x0602CB2C RID: 183084 RVA: 0x00C86B64 File Offset: 0x00C84D64
		// (set) Token: 0x0602CB2D RID: 183085 RVA: 0x00C86B6C File Offset: 0x00C84D6C
		public EMapType MapType { get; set; }

		// Token: 0x170059D7 RID: 22999
		// (get) Token: 0x0602CB2E RID: 183086 RVA: 0x00C86B75 File Offset: 0x00C84D75
		// (set) Token: 0x0602CB2F RID: 183087 RVA: 0x00C86B7D File Offset: 0x00C84D7D
		public float MapDefaultScale { get; set; }

		// Token: 0x170059D8 RID: 23000
		// (get) Token: 0x0602CB30 RID: 183088 RVA: 0x00C86B86 File Offset: 0x00C84D86
		// (set) Token: 0x0602CB31 RID: 183089 RVA: 0x00C86B8E File Offset: 0x00C84D8E
		public EMapGravityDirection? Gravity { get; set; }

		// Token: 0x170059D9 RID: 23001
		// (get) Token: 0x0602CB32 RID: 183090 RVA: 0x00C86B97 File Offset: 0x00C84D97
		// (set) Token: 0x0602CB33 RID: 183091 RVA: 0x00C86B9F File Offset: 0x00C84D9F
		public float? MarkScale { get; set; }

		// Token: 0x170059DA RID: 23002
		// (get) Token: 0x0602CB34 RID: 183092 RVA: 0x00C86BA8 File Offset: 0x00C84DA8
		// (set) Token: 0x0602CB35 RID: 183093 RVA: 0x00C86BB0 File Offset: 0x00C84DB0
		public float? ClickRange { get; set; }

		// Token: 0x170059DB RID: 23003
		// (get) Token: 0x0602CB36 RID: 183094 RVA: 0x00C86BB9 File Offset: 0x00C84DB9
		// (set) Token: 0x0602CB37 RID: 183095 RVA: 0x00C86BC1 File Offset: 0x00C84DC1
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, UTexture> PreloadTiles { [return: Nullable(new byte[]
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
