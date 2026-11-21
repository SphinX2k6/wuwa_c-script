using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED1 RID: 3793
	public struct MapFog : IFlatbufferObject
	{
		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x060096F9 RID: 38649 RVA: 0x0029C076 File Offset: 0x0029A276
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060096FA RID: 38650 RVA: 0x0029C083 File Offset: 0x0029A283
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060096FB RID: 38651 RVA: 0x0029C08C File Offset: 0x0029A28C
		public static MapFog GetRootAsMapFog(ByteBuffer _bb)
		{
			return MapFog.GetRootAsMapFog(_bb, default(MapFog));
		}

		// Token: 0x060096FC RID: 38652 RVA: 0x0029C0A8 File Offset: 0x0029A2A8
		public static MapFog GetRootAsMapFog(ByteBuffer _bb, MapFog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060096FD RID: 38653 RVA: 0x0029C0C5 File Offset: 0x0029A2C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060096FE RID: 38654 RVA: 0x0029C0D4 File Offset: 0x0029A2D4
		public MapFog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x060096FF RID: 38655 RVA: 0x0029C0E4 File Offset: 0x0029A2E4
		public int Fog
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

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x06009700 RID: 38656 RVA: 0x0029C120 File Offset: 0x0029A320
		public int MapId
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

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06009701 RID: 38657 RVA: 0x0029C15C File Offset: 0x0029A35C
		public int AreaId
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

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x06009702 RID: 38658 RVA: 0x0029C198 File Offset: 0x0029A398
		public int GravityFlip
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x06009703 RID: 38659 RVA: 0x0029C1D8 File Offset: 0x0029A3D8
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009704 RID: 38660 RVA: 0x0029C218 File Offset: 0x0029A418
		public int FogUnlockPosition(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x06009705 RID: 38661 RVA: 0x0029C258 File Offset: 0x0029A458
		public int FogUnlockPositionLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009706 RID: 38662 RVA: 0x0029C284 File Offset: 0x0029A484
		public Span<int> GetFogUnlockPositionBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06009707 RID: 38663 RVA: 0x0029C294 File Offset: 0x0029A494
		public int[] GetFogUnlockPositionArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06009708 RID: 38664 RVA: 0x0029C2AC File Offset: 0x0029A4AC
		[NullableContext(1)]
		public int[] FogUnlockPosition()
		{
			return this.GetFogUnlockPositionArray();
		}

		// Token: 0x06009709 RID: 38665 RVA: 0x0029C2B4 File Offset: 0x0029A4B4
		[NullableContext(1)]
		public IEnumerable<int> FogUnlockPositionIter()
		{
			MapFog.<FogUnlockPositionIter>d__24 <FogUnlockPositionIter>d__ = new MapFog.<FogUnlockPositionIter>d__24(-2);
			<FogUnlockPositionIter>d__.<>3__<>4__this = this;
			return <FogUnlockPositionIter>d__;
		}

		// Token: 0x0400546D RID: 21613
		private Table __p;
	}
}
