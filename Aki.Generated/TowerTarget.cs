using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200127B RID: 4731
	public struct TowerTarget : IFlatbufferObject
	{
		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x0600EDEE RID: 60910 RVA: 0x0035CDC6 File Offset: 0x0035AFC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EDEF RID: 60911 RVA: 0x0035CDD3 File Offset: 0x0035AFD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EDF0 RID: 60912 RVA: 0x0035CDDC File Offset: 0x0035AFDC
		public static TowerTarget GetRootAsTowerTarget(ByteBuffer _bb)
		{
			return TowerTarget.GetRootAsTowerTarget(_bb, default(TowerTarget));
		}

		// Token: 0x0600EDF1 RID: 60913 RVA: 0x0035CDF8 File Offset: 0x0035AFF8
		public static TowerTarget GetRootAsTowerTarget(ByteBuffer _bb, TowerTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EDF2 RID: 60914 RVA: 0x0035CE15 File Offset: 0x0035B015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EDF3 RID: 60915 RVA: 0x0035CE24 File Offset: 0x0035B024
		public TowerTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x0600EDF4 RID: 60916 RVA: 0x0035CE34 File Offset: 0x0035B034
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

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x0600EDF5 RID: 60917 RVA: 0x0035CE70 File Offset: 0x0035B070
		public int TargetType
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

		// Token: 0x0600EDF6 RID: 60918 RVA: 0x0035CEAC File Offset: 0x0035B0AC
		public int Params(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x0600EDF7 RID: 60919 RVA: 0x0035CEEC File Offset: 0x0035B0EC
		public int ParamsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EDF8 RID: 60920 RVA: 0x0035CF17 File Offset: 0x0035B117
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600EDF9 RID: 60921 RVA: 0x0035CF26 File Offset: 0x0035B126
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x0600EDFA RID: 60922 RVA: 0x0035CF40 File Offset: 0x0035B140
		public string DesText
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

		// Token: 0x0600EDFB RID: 60923 RVA: 0x0035CF78 File Offset: 0x0035B178
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EDFC RID: 60924 RVA: 0x0035CF88 File Offset: 0x0035B188
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EDFD RID: 60925 RVA: 0x0035CFA0 File Offset: 0x0035B1A0
		[NullableContext(1)]
		public int[] Params()
		{
			return this.GetParamsArray();
		}

		// Token: 0x0600EDFE RID: 60926 RVA: 0x0035CFA8 File Offset: 0x0035B1A8
		[NullableContext(1)]
		public IEnumerable<int> ParamsIter()
		{
			TowerTarget.<ParamsIter>d__22 <ParamsIter>d__ = new TowerTarget.<ParamsIter>d__22(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x040058CA RID: 22730
		private Table __p;
	}
}
