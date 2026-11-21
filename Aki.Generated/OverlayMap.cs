using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8E RID: 3982
	public struct OverlayMap : IFlatbufferObject
	{
		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x0600A879 RID: 43129 RVA: 0x002C229C File Offset: 0x002C049C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A87A RID: 43130 RVA: 0x002C22A9 File Offset: 0x002C04A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A87B RID: 43131 RVA: 0x002C22B0 File Offset: 0x002C04B0
		public static OverlayMap GetRootAsOverlayMap(ByteBuffer _bb)
		{
			return OverlayMap.GetRootAsOverlayMap(_bb, default(OverlayMap));
		}

		// Token: 0x0600A87C RID: 43132 RVA: 0x002C22CC File Offset: 0x002C04CC
		public static OverlayMap GetRootAsOverlayMap(ByteBuffer _bb, OverlayMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A87D RID: 43133 RVA: 0x002C22E9 File Offset: 0x002C04E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A87E RID: 43134 RVA: 0x002C22F8 File Offset: 0x002C04F8
		public OverlayMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x0600A87F RID: 43135 RVA: 0x002C2308 File Offset: 0x002C0508
		public int OverlayMapId
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

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x0600A880 RID: 43136 RVA: 0x002C2344 File Offset: 0x002C0544
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

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x0600A881 RID: 43137 RVA: 0x002C2380 File Offset: 0x002C0580
		public int GravityFlip
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x0600A882 RID: 43138 RVA: 0x002C23BC File Offset: 0x002C05BC
		public string MapAddress
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A883 RID: 43139 RVA: 0x002C23F4 File Offset: 0x002C05F4
		public Span<byte> GetMapAddressBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A884 RID: 43140 RVA: 0x002C2404 File Offset: 0x002C0604
		public byte[] GetMapAddressArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A885 RID: 43141 RVA: 0x002C241C File Offset: 0x002C061C
		public int MapPos(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x0600A886 RID: 43142 RVA: 0x002C245C File Offset: 0x002C065C
		public int MapPosLength
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

		// Token: 0x0600A887 RID: 43143 RVA: 0x002C2488 File Offset: 0x002C0688
		public Span<int> GetMapPosBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600A888 RID: 43144 RVA: 0x002C2498 File Offset: 0x002C0698
		public int[] GetMapPosArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x0600A889 RID: 43145 RVA: 0x002C24B0 File Offset: 0x002C06B0
		public int Rotation
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A88A RID: 43146 RVA: 0x002C24F0 File Offset: 0x002C06F0
		public int WidthHeight(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x0600A88B RID: 43147 RVA: 0x002C2530 File Offset: 0x002C0730
		public int WidthHeightLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A88C RID: 43148 RVA: 0x002C255C File Offset: 0x002C075C
		public Span<int> GetWidthHeightBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600A88D RID: 43149 RVA: 0x002C256C File Offset: 0x002C076C
		public int[] GetWidthHeightArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600A88E RID: 43150 RVA: 0x002C2584 File Offset: 0x002C0784
		[NullableContext(1)]
		public int[] MapPos()
		{
			return this.GetMapPosArray();
		}

		// Token: 0x0600A88F RID: 43151 RVA: 0x002C258C File Offset: 0x002C078C
		[NullableContext(1)]
		public IEnumerable<int> MapPosIter()
		{
			OverlayMap.<MapPosIter>d__31 <MapPosIter>d__ = new OverlayMap.<MapPosIter>d__31(-2);
			<MapPosIter>d__.<>3__<>4__this = this;
			return <MapPosIter>d__;
		}

		// Token: 0x0600A890 RID: 43152 RVA: 0x002C25A1 File Offset: 0x002C07A1
		[NullableContext(1)]
		public int[] WidthHeight()
		{
			return this.GetWidthHeightArray();
		}

		// Token: 0x0600A891 RID: 43153 RVA: 0x002C25A9 File Offset: 0x002C07A9
		[NullableContext(1)]
		public IEnumerable<int> WidthHeightIter()
		{
			OverlayMap.<WidthHeightIter>d__33 <WidthHeightIter>d__ = new OverlayMap.<WidthHeightIter>d__33(-2);
			<WidthHeightIter>d__.<>3__<>4__this = this;
			return <WidthHeightIter>d__;
		}

		// Token: 0x04005543 RID: 21827
		private Table __p;
	}
}
