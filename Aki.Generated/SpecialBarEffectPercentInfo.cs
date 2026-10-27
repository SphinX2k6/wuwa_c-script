using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E3 RID: 4579
	public struct SpecialBarEffectPercentInfo : IFlatbufferObject
	{
		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x0600EB8E RID: 60302 RVA: 0x0034A7B5 File Offset: 0x003489B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB8F RID: 60303 RVA: 0x0034A7C2 File Offset: 0x003489C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB90 RID: 60304 RVA: 0x0034A7CC File Offset: 0x003489CC
		public static SpecialBarEffectPercentInfo GetRootAsSpecialBarEffectPercentInfo(ByteBuffer _bb)
		{
			return SpecialBarEffectPercentInfo.GetRootAsSpecialBarEffectPercentInfo(_bb, default(SpecialBarEffectPercentInfo));
		}

		// Token: 0x0600EB91 RID: 60305 RVA: 0x0034A7E8 File Offset: 0x003489E8
		public static SpecialBarEffectPercentInfo GetRootAsSpecialBarEffectPercentInfo(ByteBuffer _bb, SpecialBarEffectPercentInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB92 RID: 60306 RVA: 0x0034A805 File Offset: 0x00348A05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB93 RID: 60307 RVA: 0x0034A814 File Offset: 0x00348A14
		public SpecialBarEffectPercentInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F34 RID: 16180
		// (get) Token: 0x0600EB94 RID: 60308 RVA: 0x0034A824 File Offset: 0x00348A24
		public int MinPercent
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

		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x0600EB95 RID: 60309 RVA: 0x0034A860 File Offset: 0x00348A60
		public int MaxPercent
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

		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x0600EB96 RID: 60310 RVA: 0x0034A89C File Offset: 0x00348A9C
		public float MinValue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x0600EB97 RID: 60311 RVA: 0x0034A8DC File Offset: 0x00348ADC
		public float MaxValue
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x0600EB98 RID: 60312 RVA: 0x0034A920 File Offset: 0x00348B20
		public string FloatParameterName
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

		// Token: 0x0600EB99 RID: 60313 RVA: 0x0034A958 File Offset: 0x00348B58
		public Span<byte> GetFloatParameterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600EB9A RID: 60314 RVA: 0x0034A968 File Offset: 0x00348B68
		public byte[] GetFloatParameterNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400535C RID: 21340
		private Table __p;
	}
}
