using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C63 RID: 3171
	public struct Climb : IFlatbufferObject
	{
		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06005BD1 RID: 23505 RVA: 0x00216DE0 File Offset: 0x00214FE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005BD2 RID: 23506 RVA: 0x00216DED File Offset: 0x00214FED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x00216DF4 File Offset: 0x00214FF4
		public static Climb GetRootAsClimb(ByteBuffer _bb)
		{
			return Climb.GetRootAsClimb(_bb, default(Climb));
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x00216E10 File Offset: 0x00215010
		public static Climb GetRootAsClimb(ByteBuffer _bb, Climb obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x00216E2D File Offset: 0x0021502D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x00216E3C File Offset: 0x0021503C
		public Climb __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06005BD7 RID: 23511 RVA: 0x00216E4C File Offset: 0x0021504C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x00216E83 File Offset: 0x00215083
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x00216E92 File Offset: 0x00215092
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x00216EAC File Offset: 0x002150AC
		public Vector? ClimbDetectPoints(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new Vector?(default(Vector).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06005BDB RID: 23515 RVA: 0x00216F0C File Offset: 0x0021510C
		public int ClimbDetectPointsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06005BDC RID: 23516 RVA: 0x00216F38 File Offset: 0x00215138
		public float DetectRadius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 20f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06005BDD RID: 23517 RVA: 0x00216F78 File Offset: 0x00215178
		public float ClimbRadius
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 40f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06005BDE RID: 23518 RVA: 0x00216FBC File Offset: 0x002151BC
		public Vector? ClimbFromTop
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06005BDF RID: 23519 RVA: 0x0021701C File Offset: 0x0021521C
		public Vector? ClimbVault
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06005BE0 RID: 23520 RVA: 0x0021707C File Offset: 0x0021527C
		public Vector? ClimbOnTop
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06005BE1 RID: 23521 RVA: 0x002170DC File Offset: 0x002152DC
		public FloatRange? VaultRange
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06005BE2 RID: 23522 RVA: 0x0021713C File Offset: 0x0021533C
		public FloatRange? UpArriveRange
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06005BE3 RID: 23523 RVA: 0x0021719C File Offset: 0x0021539C
		public Vector? ClimbSprintVault
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x002171FC File Offset: 0x002153FC
		public FloatRange? SprintVaultRange
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06005BE5 RID: 23525 RVA: 0x0021725C File Offset: 0x0021545C
		public float ForwardBlockHeight
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 50f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06005BE6 RID: 23526 RVA: 0x002172A0 File Offset: 0x002154A0
		public float ForwardBlockRadius
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 30f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06005BE7 RID: 23527 RVA: 0x002172E4 File Offset: 0x002154E4
		public FloatRange? ForwardBlockDistance
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06005BE8 RID: 23528 RVA: 0x00217344 File Offset: 0x00215544
		public float SprintVaultLongNeedDistance
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 48f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06005BE9 RID: 23529 RVA: 0x00217388 File Offset: 0x00215588
		public float SprintVaultLongHeight
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 75f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06005BEA RID: 23530 RVA: 0x002173CC File Offset: 0x002155CC
		public FloatRange? SprintVaultLongRange
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06005BEB RID: 23531 RVA: 0x0021742C File Offset: 0x0021562C
		public Vector? BlockUpOffset
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06005BEC RID: 23532 RVA: 0x0021748C File Offset: 0x0021568C
		public float BlockUpDetectRadius
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 20f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06005BED RID: 23533 RVA: 0x002174D0 File Offset: 0x002156D0
		public float BlockUpDetectDistance
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 250f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06005BEE RID: 23534 RVA: 0x00217514 File Offset: 0x00215714
		public float BlockUpBackDistance
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 100f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06005BEF RID: 23535 RVA: 0x00217558 File Offset: 0x00215758
		public float BlockUpBackMinDist
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 50f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06005BF0 RID: 23536 RVA: 0x0021759C File Offset: 0x0021579C
		public Vector? BlockUpFinalMove
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06005BF1 RID: 23537 RVA: 0x002175FC File Offset: 0x002157FC
		public FloatRange? BlockUpVerticalRange
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x0021765A File Offset: 0x0021585A
		[NullableContext(1)]
		public Vector[] ClimbDetectPoints()
		{
			return this.ClimbDetectPointsIter().ToArray<Vector>();
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x00217667 File Offset: 0x00215867
		[NullableContext(1)]
		public IEnumerable<Vector> ClimbDetectPointsIter()
		{
			Climb.<ClimbDetectPointsIter>d__60 <ClimbDetectPointsIter>d__ = new Climb.<ClimbDetectPointsIter>d__60(-2);
			<ClimbDetectPointsIter>d__.<>3__<>4__this = this;
			return <ClimbDetectPointsIter>d__;
		}

		// Token: 0x04005167 RID: 20839
		private Table __p;
	}
}
