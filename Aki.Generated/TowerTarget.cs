using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001145 RID: 4421
	public struct TowerTarget : IFlatbufferObject
	{
		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x0600E080 RID: 57472 RVA: 0x0033195E File Offset: 0x0032FB5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E081 RID: 57473 RVA: 0x0033196B File Offset: 0x0032FB6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E082 RID: 57474 RVA: 0x00331974 File Offset: 0x0032FB74
		public static TowerTarget GetRootAsTowerTarget(ByteBuffer _bb)
		{
			return TowerTarget.GetRootAsTowerTarget(_bb, default(TowerTarget));
		}

		// Token: 0x0600E083 RID: 57475 RVA: 0x00331990 File Offset: 0x0032FB90
		public static TowerTarget GetRootAsTowerTarget(ByteBuffer _bb, TowerTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E084 RID: 57476 RVA: 0x003319AD File Offset: 0x0032FBAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E085 RID: 57477 RVA: 0x003319BC File Offset: 0x0032FBBC
		public TowerTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x0600E086 RID: 57478 RVA: 0x003319CC File Offset: 0x0032FBCC
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

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x0600E087 RID: 57479 RVA: 0x00331A08 File Offset: 0x0032FC08
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

		// Token: 0x0600E088 RID: 57480 RVA: 0x00331A44 File Offset: 0x0032FC44
		public int Params(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x0600E089 RID: 57481 RVA: 0x00331A84 File Offset: 0x0032FC84
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

		// Token: 0x0600E08A RID: 57482 RVA: 0x00331AAF File Offset: 0x0032FCAF
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600E08B RID: 57483 RVA: 0x00331ABE File Offset: 0x0032FCBE
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x0600E08C RID: 57484 RVA: 0x00331AD8 File Offset: 0x0032FCD8
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

		// Token: 0x0600E08D RID: 57485 RVA: 0x00331B10 File Offset: 0x0032FD10
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E08E RID: 57486 RVA: 0x00331B20 File Offset: 0x0032FD20
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E08F RID: 57487 RVA: 0x00331B38 File Offset: 0x0032FD38
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Params()
		{
			TowerTarget towerTarget = this;
			return towerTarget.GetParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E090 RID: 57488 RVA: 0x00331B5C File Offset: 0x0032FD5C
		[NullableContext(1)]
		public readonly IEnumerable<int> ParamsIter()
		{
			TowerTarget.<ParamsIter>d__22 <ParamsIter>d__ = new TowerTarget.<ParamsIter>d__22(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04005287 RID: 21127
		private Table __p;
	}
}
