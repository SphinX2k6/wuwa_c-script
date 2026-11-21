using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004554 RID: 17748
	[NullableContext(2)]
	[Nullable(0)]
	public class MapTileMgrParams
	{
		// Token: 0x170059F3 RID: 23027
		// (get) Token: 0x0602CB7B RID: 183163 RVA: 0x00C86ED3 File Offset: 0x00C850D3
		// (set) Token: 0x0602CB7C RID: 183164 RVA: 0x00C86EDB File Offset: 0x00C850DB
		[Nullable(1)]
		public UUIItem MapRootItem { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170059F4 RID: 23028
		// (get) Token: 0x0602CB7D RID: 183165 RVA: 0x00C86EE4 File Offset: 0x00C850E4
		// (set) Token: 0x0602CB7E RID: 183166 RVA: 0x00C86EEC File Offset: 0x00C850EC
		[Nullable(1)]
		public UUIItem TileContainer { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170059F5 RID: 23029
		// (get) Token: 0x0602CB7F RID: 183167 RVA: 0x00C86EF5 File Offset: 0x00C850F5
		// (set) Token: 0x0602CB80 RID: 183168 RVA: 0x00C86EFD File Offset: 0x00C850FD
		[Nullable(1)]
		public UUITexture TileTexture { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170059F6 RID: 23030
		// (get) Token: 0x0602CB81 RID: 183169 RVA: 0x00C86F06 File Offset: 0x00C85106
		// (set) Token: 0x0602CB82 RID: 183170 RVA: 0x00C86F0E File Offset: 0x00C8510E
		public UUIItem SubMapContainer { get; set; }

		// Token: 0x170059F7 RID: 23031
		// (get) Token: 0x0602CB83 RID: 183171 RVA: 0x00C86F17 File Offset: 0x00C85117
		// (set) Token: 0x0602CB84 RID: 183172 RVA: 0x00C86F1F File Offset: 0x00C8511F
		public UUITexture SubMapTexture { get; set; }

		// Token: 0x170059F8 RID: 23032
		// (get) Token: 0x0602CB85 RID: 183173 RVA: 0x00C86F28 File Offset: 0x00C85128
		// (set) Token: 0x0602CB86 RID: 183174 RVA: 0x00C86F30 File Offset: 0x00C85130
		public EMapType MapType { get; set; }

		// Token: 0x170059F9 RID: 23033
		// (get) Token: 0x0602CB87 RID: 183175 RVA: 0x00C86F39 File Offset: 0x00C85139
		// (set) Token: 0x0602CB88 RID: 183176 RVA: 0x00C86F41 File Offset: 0x00C85141
		public int MapId { get; set; }

		// Token: 0x170059FA RID: 23034
		// (get) Token: 0x0602CB89 RID: 183177 RVA: 0x00C86F4A File Offset: 0x00C8514A
		// (set) Token: 0x0602CB8A RID: 183178 RVA: 0x00C86F52 File Offset: 0x00C85152
		public int InstanceDungeonId { get; set; }

		// Token: 0x170059FB RID: 23035
		// (get) Token: 0x0602CB8B RID: 183179 RVA: 0x00C86F5B File Offset: 0x00C8515B
		// (set) Token: 0x0602CB8C RID: 183180 RVA: 0x00C86F63 File Offset: 0x00C85163
		public int MapVersion { get; set; }

		// Token: 0x170059FC RID: 23036
		// (get) Token: 0x0602CB8D RID: 183181 RVA: 0x00C86F6C File Offset: 0x00C8516C
		// (set) Token: 0x0602CB8E RID: 183182 RVA: 0x00C86F74 File Offset: 0x00C85174
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

		// Token: 0x170059FD RID: 23037
		// (get) Token: 0x0602CB8F RID: 183183 RVA: 0x00C86F7D File Offset: 0x00C8517D
		// (set) Token: 0x0602CB90 RID: 183184 RVA: 0x00C86F85 File Offset: 0x00C85185
		public UUIItem SubMapMask { get; set; }

		// Token: 0x170059FE RID: 23038
		// (get) Token: 0x0602CB91 RID: 183185 RVA: 0x00C86F8E File Offset: 0x00C8518E
		// (set) Token: 0x0602CB92 RID: 183186 RVA: 0x00C86F96 File Offset: 0x00C85196
		public UUIItem FogUnlockItem { get; set; }

		// Token: 0x170059FF RID: 23039
		// (get) Token: 0x0602CB93 RID: 183187 RVA: 0x00C86F9F File Offset: 0x00C8519F
		// (set) Token: 0x0602CB94 RID: 183188 RVA: 0x00C86FA7 File Offset: 0x00C851A7
		public EMapGravityDirection? Gravity { get; set; }
	}
}
