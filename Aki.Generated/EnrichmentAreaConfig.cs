using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D14 RID: 3348
	public struct EnrichmentAreaConfig : IFlatbufferObject
	{
		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06006F37 RID: 28471 RVA: 0x00242880 File Offset: 0x00240A80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x0024288D File Offset: 0x00240A8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x00242894 File Offset: 0x00240A94
		public static EnrichmentAreaConfig GetRootAsEnrichmentAreaConfig(ByteBuffer _bb)
		{
			return EnrichmentAreaConfig.GetRootAsEnrichmentAreaConfig(_bb, default(EnrichmentAreaConfig));
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x002428B0 File Offset: 0x00240AB0
		public static EnrichmentAreaConfig GetRootAsEnrichmentAreaConfig(ByteBuffer _bb, EnrichmentAreaConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F3B RID: 28475 RVA: 0x002428CD File Offset: 0x00240ACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F3C RID: 28476 RVA: 0x002428DC File Offset: 0x00240ADC
		public EnrichmentAreaConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06006F3D RID: 28477 RVA: 0x002428EC File Offset: 0x00240AEC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06006F3E RID: 28478 RVA: 0x00242928 File Offset: 0x00240B28
		public int EnrichmentId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06006F3F RID: 28479 RVA: 0x00242964 File Offset: 0x00240B64
		public int ItemId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06006F40 RID: 28480 RVA: 0x002429A0 File Offset: 0x00240BA0
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x002429E0 File Offset: 0x00240BE0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06006F42 RID: 28482 RVA: 0x00242A20 File Offset: 0x00240C20
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x00242A4C File Offset: 0x00240C4C
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006F44 RID: 28484 RVA: 0x00242A5C File Offset: 0x00240C5C
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x00242A74 File Offset: 0x00240C74
		[NullableContext(1)]
		public int[] EntityIds()
		{
			return this.GetEntityIdsArray();
		}

		// Token: 0x06006F46 RID: 28486 RVA: 0x00242A7C File Offset: 0x00240C7C
		[NullableContext(1)]
		public IEnumerable<int> EntityIdsIter()
		{
			EnrichmentAreaConfig.<EntityIdsIter>d__22 <EntityIdsIter>d__ = new EnrichmentAreaConfig.<EntityIdsIter>d__22(-2);
			<EntityIdsIter>d__.<>3__<>4__this = this;
			return <EntityIdsIter>d__;
		}

		// Token: 0x04005254 RID: 21076
		private Table __p;
	}
}
