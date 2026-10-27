using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B82 RID: 2946
	public struct Climb : IFlatbufferObject
	{
		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06005603 RID: 22019 RVA: 0x001F7028 File Offset: 0x001F5228
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x001F7035 File Offset: 0x001F5235
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x001F703C File Offset: 0x001F523C
		public static Climb GetRootAsClimb(ByteBuffer _bb)
		{
			return Climb.GetRootAsClimb(_bb, default(Climb));
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x001F7058 File Offset: 0x001F5258
		public static Climb GetRootAsClimb(ByteBuffer _bb, Climb obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x001F7075 File Offset: 0x001F5275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x001F7084 File Offset: 0x001F5284
		public Climb __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06005609 RID: 22025 RVA: 0x001F7094 File Offset: 0x001F5294
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

		// Token: 0x0600560A RID: 22026 RVA: 0x001F70CB File Offset: 0x001F52CB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600560B RID: 22027 RVA: 0x001F70DA File Offset: 0x001F52DA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x0600560C RID: 22028 RVA: 0x001F70F4 File Offset: 0x001F52F4
		public Vector? ClimbDetectPoints(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new Vector?(default(Vector).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x0600560D RID: 22029 RVA: 0x001F7154 File Offset: 0x001F5354
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

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x0600560E RID: 22030 RVA: 0x001F7180 File Offset: 0x001F5380
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

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x0600560F RID: 22031 RVA: 0x001F71C0 File Offset: 0x001F53C0
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

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06005610 RID: 22032 RVA: 0x001F7204 File Offset: 0x001F5404
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

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06005611 RID: 22033 RVA: 0x001F7264 File Offset: 0x001F5464
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

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06005612 RID: 22034 RVA: 0x001F72C4 File Offset: 0x001F54C4
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

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06005613 RID: 22035 RVA: 0x001F7324 File Offset: 0x001F5524
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

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06005614 RID: 22036 RVA: 0x001F7384 File Offset: 0x001F5584
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

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06005615 RID: 22037 RVA: 0x001F73E4 File Offset: 0x001F55E4
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

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06005616 RID: 22038 RVA: 0x001F7444 File Offset: 0x001F5644
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

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06005617 RID: 22039 RVA: 0x001F74A4 File Offset: 0x001F56A4
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

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06005618 RID: 22040 RVA: 0x001F74E8 File Offset: 0x001F56E8
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

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06005619 RID: 22041 RVA: 0x001F752C File Offset: 0x001F572C
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

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x0600561A RID: 22042 RVA: 0x001F758C File Offset: 0x001F578C
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

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x0600561B RID: 22043 RVA: 0x001F75D0 File Offset: 0x001F57D0
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

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x0600561C RID: 22044 RVA: 0x001F7614 File Offset: 0x001F5814
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

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x0600561D RID: 22045 RVA: 0x001F7674 File Offset: 0x001F5874
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

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x0600561E RID: 22046 RVA: 0x001F76D4 File Offset: 0x001F58D4
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

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600561F RID: 22047 RVA: 0x001F7718 File Offset: 0x001F5918
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

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06005620 RID: 22048 RVA: 0x001F775C File Offset: 0x001F595C
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

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06005621 RID: 22049 RVA: 0x001F77A0 File Offset: 0x001F59A0
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

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06005622 RID: 22050 RVA: 0x001F77E4 File Offset: 0x001F59E4
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

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06005623 RID: 22051 RVA: 0x001F7844 File Offset: 0x001F5A44
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

		// Token: 0x06005624 RID: 22052 RVA: 0x001F78A2 File Offset: 0x001F5AA2
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ClimbDetectPointsIter()或GetClimbDetectPointsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Vector[] ClimbDetectPoints()
		{
			return this.ClimbDetectPointsIter().ToArray<Vector>();
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x001F78AF File Offset: 0x001F5AAF
		[NullableContext(1)]
		public readonly IEnumerable<Vector> ClimbDetectPointsIter()
		{
			Climb.<ClimbDetectPointsIter>d__60 <ClimbDetectPointsIter>d__ = new Climb.<ClimbDetectPointsIter>d__60(-2);
			<ClimbDetectPointsIter>d__.<>3__<>4__this = this;
			return <ClimbDetectPointsIter>d__;
		}

		// Token: 0x04004B86 RID: 19334
		private Table __p;
	}
}
