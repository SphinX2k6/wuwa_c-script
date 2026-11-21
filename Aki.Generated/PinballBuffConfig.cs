using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001008 RID: 4104
	public struct PinballBuffConfig : IFlatbufferObject
	{
		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x0600B445 RID: 46149 RVA: 0x002DCB10 File Offset: 0x002DAD10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B446 RID: 46150 RVA: 0x002DCB1D File Offset: 0x002DAD1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B447 RID: 46151 RVA: 0x002DCB24 File Offset: 0x002DAD24
		public static PinballBuffConfig GetRootAsPinballBuffConfig(ByteBuffer _bb)
		{
			return PinballBuffConfig.GetRootAsPinballBuffConfig(_bb, default(PinballBuffConfig));
		}

		// Token: 0x0600B448 RID: 46152 RVA: 0x002DCB40 File Offset: 0x002DAD40
		public static PinballBuffConfig GetRootAsPinballBuffConfig(ByteBuffer _bb, PinballBuffConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B449 RID: 46153 RVA: 0x002DCB5D File Offset: 0x002DAD5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B44A RID: 46154 RVA: 0x002DCB6C File Offset: 0x002DAD6C
		public PinballBuffConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x0600B44B RID: 46155 RVA: 0x002DCB7C File Offset: 0x002DAD7C
		public int BuffId
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

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x0600B44C RID: 46156 RVA: 0x002DCBB8 File Offset: 0x002DADB8
		public int Sort
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

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x0600B44D RID: 46157 RVA: 0x002DCBF4 File Offset: 0x002DADF4
		public string BuffIcon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B44E RID: 46158 RVA: 0x002DCC2B File Offset: 0x002DAE2B
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B44F RID: 46159 RVA: 0x002DCC3A File Offset: 0x002DAE3A
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x0600B450 RID: 46160 RVA: 0x002DCC54 File Offset: 0x002DAE54
		public string BuffName
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

		// Token: 0x0600B451 RID: 46161 RVA: 0x002DCC8C File Offset: 0x002DAE8C
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B452 RID: 46162 RVA: 0x002DCC9C File Offset: 0x002DAE9C
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x0600B453 RID: 46163 RVA: 0x002DCCB4 File Offset: 0x002DAEB4
		public string BuffDesc
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

		// Token: 0x0600B454 RID: 46164 RVA: 0x002DCCEC File Offset: 0x002DAEEC
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B455 RID: 46165 RVA: 0x002DCCFC File Offset: 0x002DAEFC
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B456 RID: 46166 RVA: 0x002DCD14 File Offset: 0x002DAF14
		public string BuffParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x0600B457 RID: 46167 RVA: 0x002DCD50 File Offset: 0x002DAF50
		public int BuffParamLength
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

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x0600B458 RID: 46168 RVA: 0x002DCD7C File Offset: 0x002DAF7C
		public int BuffType
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

		// Token: 0x0600B459 RID: 46169 RVA: 0x002DCDB9 File Offset: 0x002DAFB9
		[NullableContext(1)]
		public string[] BuffParam()
		{
			return this.BuffParamIter().ToArray<string>();
		}

		// Token: 0x0600B45A RID: 46170 RVA: 0x002DCDC6 File Offset: 0x002DAFC6
		[NullableContext(1)]
		public IEnumerable<string> BuffParamIter()
		{
			PinballBuffConfig.<BuffParamIter>d__30 <BuffParamIter>d__ = new PinballBuffConfig.<BuffParamIter>d__30(-2);
			<BuffParamIter>d__.<>3__<>4__this = this;
			return <BuffParamIter>d__;
		}

		// Token: 0x040055D1 RID: 21969
		private Table __p;
	}
}
