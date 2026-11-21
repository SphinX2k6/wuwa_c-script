using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1C RID: 3612
	public struct HonamiStoryItem : IFlatbufferObject
	{
		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x060085A5 RID: 34213 RVA: 0x0027521D File Offset: 0x0027341D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060085A6 RID: 34214 RVA: 0x0027522A File Offset: 0x0027342A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060085A7 RID: 34215 RVA: 0x00275234 File Offset: 0x00273434
		public static HonamiStoryItem GetRootAsHonamiStoryItem(ByteBuffer _bb)
		{
			return HonamiStoryItem.GetRootAsHonamiStoryItem(_bb, default(HonamiStoryItem));
		}

		// Token: 0x060085A8 RID: 34216 RVA: 0x00275250 File Offset: 0x00273450
		public static HonamiStoryItem GetRootAsHonamiStoryItem(ByteBuffer _bb, HonamiStoryItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060085A9 RID: 34217 RVA: 0x0027526D File Offset: 0x0027346D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060085AA RID: 34218 RVA: 0x0027527C File Offset: 0x0027347C
		public HonamiStoryItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x060085AB RID: 34219 RVA: 0x0027528C File Offset: 0x0027348C
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

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x060085AC RID: 34220 RVA: 0x002752C8 File Offset: 0x002734C8
		public int ActivityId
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

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x060085AD RID: 34221 RVA: 0x00275304 File Offset: 0x00273504
		public int ItemType
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

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x060085AE RID: 34222 RVA: 0x00275340 File Offset: 0x00273540
		public int SubType
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

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x060085AF RID: 34223 RVA: 0x00275380 File Offset: 0x00273580
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x002753B8 File Offset: 0x002735B8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x002753C8 File Offset: 0x002735C8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x060085B2 RID: 34226 RVA: 0x002753E0 File Offset: 0x002735E0
		public string IconBackpack
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060085B3 RID: 34227 RVA: 0x00275418 File Offset: 0x00273618
		public Span<byte> GetIconBackpackBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060085B4 RID: 34228 RVA: 0x00275428 File Offset: 0x00273628
		public byte[] GetIconBackpackArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x060085B5 RID: 34229 RVA: 0x00275440 File Offset: 0x00273640
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060085B6 RID: 34230 RVA: 0x00275478 File Offset: 0x00273678
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060085B7 RID: 34231 RVA: 0x00275488 File Offset: 0x00273688
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x060085B8 RID: 34232 RVA: 0x002754A0 File Offset: 0x002736A0
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060085B9 RID: 34233 RVA: 0x002754D8 File Offset: 0x002736D8
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060085BA RID: 34234 RVA: 0x002754E8 File Offset: 0x002736E8
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x060085BB RID: 34235 RVA: 0x00275500 File Offset: 0x00273700
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060085BC RID: 34236 RVA: 0x00275538 File Offset: 0x00273738
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060085BD RID: 34237 RVA: 0x00275548 File Offset: 0x00273748
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x060085BE RID: 34238 RVA: 0x00275560 File Offset: 0x00273760
		public int GridOccupy(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x060085BF RID: 34239 RVA: 0x002755A0 File Offset: 0x002737A0
		public int GridOccupyLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060085C0 RID: 34240 RVA: 0x002755CC File Offset: 0x002737CC
		public Span<int> GetGridOccupyBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x060085C1 RID: 34241 RVA: 0x002755DC File Offset: 0x002737DC
		public int[] GetGridOccupyArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x060085C2 RID: 34242 RVA: 0x002755F4 File Offset: 0x002737F4
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x060085C3 RID: 34243 RVA: 0x00275634 File Offset: 0x00273834
		public int SellPrice
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x060085C4 RID: 34244 RVA: 0x00275674 File Offset: 0x00273874
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060085C5 RID: 34245 RVA: 0x002756AC File Offset: 0x002738AC
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060085C6 RID: 34246 RVA: 0x002756BC File Offset: 0x002738BC
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x060085C7 RID: 34247 RVA: 0x002756D4 File Offset: 0x002738D4
		public int DropShowPlan
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x060085C8 RID: 34248 RVA: 0x00275714 File Offset: 0x00273914
		public int DropPlan
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x060085C9 RID: 34249 RVA: 0x00275754 File Offset: 0x00273954
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060085CA RID: 34250 RVA: 0x0027578C File Offset: 0x0027398C
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060085CB RID: 34251 RVA: 0x0027579C File Offset: 0x0027399C
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x060085CC RID: 34252 RVA: 0x002757B4 File Offset: 0x002739B4
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060085CD RID: 34253 RVA: 0x002757EC File Offset: 0x002739EC
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060085CE RID: 34254 RVA: 0x002757FC File Offset: 0x002739FC
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x060085CF RID: 34255 RVA: 0x00275814 File Offset: 0x00273A14
		public string Mesh
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060085D0 RID: 34256 RVA: 0x0027584C File Offset: 0x00273A4C
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060085D1 RID: 34257 RVA: 0x0027585C File Offset: 0x00273A5C
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x060085D2 RID: 34258 RVA: 0x00275874 File Offset: 0x00273A74
		[NullableContext(1)]
		public int[] GridOccupy()
		{
			return this.GetGridOccupyArray();
		}

		// Token: 0x060085D3 RID: 34259 RVA: 0x0027587C File Offset: 0x00273A7C
		[NullableContext(1)]
		public IEnumerable<int> GridOccupyIter()
		{
			HonamiStoryItem.<GridOccupyIter>d__66 <GridOccupyIter>d__ = new HonamiStoryItem.<GridOccupyIter>d__66(-2);
			<GridOccupyIter>d__.<>3__<>4__this = this;
			return <GridOccupyIter>d__;
		}

		// Token: 0x04005396 RID: 21398
		private Table __p;
	}
}
