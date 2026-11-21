using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F37 RID: 3895
	public struct MotorFightWave : IFlatbufferObject
	{
		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x06009FBF RID: 40895 RVA: 0x002AF6A9 File Offset: 0x002AD8A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009FC0 RID: 40896 RVA: 0x002AF6B6 File Offset: 0x002AD8B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009FC1 RID: 40897 RVA: 0x002AF6C0 File Offset: 0x002AD8C0
		public static MotorFightWave GetRootAsMotorFightWave(ByteBuffer _bb)
		{
			return MotorFightWave.GetRootAsMotorFightWave(_bb, default(MotorFightWave));
		}

		// Token: 0x06009FC2 RID: 40898 RVA: 0x002AF6DC File Offset: 0x002AD8DC
		public static MotorFightWave GetRootAsMotorFightWave(ByteBuffer _bb, MotorFightWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009FC3 RID: 40899 RVA: 0x002AF6F9 File Offset: 0x002AD8F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009FC4 RID: 40900 RVA: 0x002AF708 File Offset: 0x002AD908
		public MotorFightWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x06009FC5 RID: 40901 RVA: 0x002AF718 File Offset: 0x002AD918
		public int WaveId
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

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x06009FC6 RID: 40902 RVA: 0x002AF754 File Offset: 0x002AD954
		public int RefreshType
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

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x06009FC7 RID: 40903 RVA: 0x002AF790 File Offset: 0x002AD990
		public int RefreshGroupId
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

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x06009FC8 RID: 40904 RVA: 0x002AF7CC File Offset: 0x002AD9CC
		public int BuffGateBornGroup
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

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x06009FC9 RID: 40905 RVA: 0x002AF80C File Offset: 0x002ADA0C
		public int ConditionId
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

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x06009FCA RID: 40906 RVA: 0x002AF84C File Offset: 0x002ADA4C
		public int Weight
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

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06009FCB RID: 40907 RVA: 0x002AF88C File Offset: 0x002ADA8C
		public int BornTrack
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009FCC RID: 40908 RVA: 0x002AF8CC File Offset: 0x002ADACC
		public int BornDistance(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x06009FCD RID: 40909 RVA: 0x002AF90C File Offset: 0x002ADB0C
		public int BornDistanceLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009FCE RID: 40910 RVA: 0x002AF938 File Offset: 0x002ADB38
		public Span<int> GetBornDistanceBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06009FCF RID: 40911 RVA: 0x002AF948 File Offset: 0x002ADB48
		public int[] GetBornDistanceArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06009FD0 RID: 40912 RVA: 0x002AF960 File Offset: 0x002ADB60
		[NullableContext(1)]
		public int[] BornDistance()
		{
			return this.GetBornDistanceArray();
		}

		// Token: 0x06009FD1 RID: 40913 RVA: 0x002AF968 File Offset: 0x002ADB68
		[NullableContext(1)]
		public IEnumerable<int> BornDistanceIter()
		{
			MotorFightWave.<BornDistanceIter>d__28 <BornDistanceIter>d__ = new MotorFightWave.<BornDistanceIter>d__28(-2);
			<BornDistanceIter>d__.<>3__<>4__this = this;
			return <BornDistanceIter>d__;
		}

		// Token: 0x040054E0 RID: 21728
		private Table __p;
	}
}
