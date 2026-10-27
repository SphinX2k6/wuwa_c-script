using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EEB RID: 3819
	public struct PhantomHandBook : IFlatbufferObject
	{
		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x0600A8D8 RID: 43224 RVA: 0x002B3BA9 File Offset: 0x002B1DA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A8D9 RID: 43225 RVA: 0x002B3BB6 File Offset: 0x002B1DB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A8DA RID: 43226 RVA: 0x002B3BC0 File Offset: 0x002B1DC0
		public static PhantomHandBook GetRootAsPhantomHandBook(ByteBuffer _bb)
		{
			return PhantomHandBook.GetRootAsPhantomHandBook(_bb, default(PhantomHandBook));
		}

		// Token: 0x0600A8DB RID: 43227 RVA: 0x002B3BDC File Offset: 0x002B1DDC
		public static PhantomHandBook GetRootAsPhantomHandBook(ByteBuffer _bb, PhantomHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A8DC RID: 43228 RVA: 0x002B3BF9 File Offset: 0x002B1DF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A8DD RID: 43229 RVA: 0x002B3C08 File Offset: 0x002B1E08
		public PhantomHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x0600A8DE RID: 43230 RVA: 0x002B3C18 File Offset: 0x002B1E18
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

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x0600A8DF RID: 43231 RVA: 0x002B3C54 File Offset: 0x002B1E54
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A8E0 RID: 43232 RVA: 0x002B3C8B File Offset: 0x002B1E8B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A8E1 RID: 43233 RVA: 0x002B3C9A File Offset: 0x002B1E9A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x0600A8E2 RID: 43234 RVA: 0x002B3CB4 File Offset: 0x002B1EB4
		public string TypeDescrtption
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

		// Token: 0x0600A8E3 RID: 43235 RVA: 0x002B3CEB File Offset: 0x002B1EEB
		public Span<byte> GetTypeDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A8E4 RID: 43236 RVA: 0x002B3CFA File Offset: 0x002B1EFA
		public byte[] GetTypeDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x0600A8E5 RID: 43237 RVA: 0x002B3D14 File Offset: 0x002B1F14
		public string Intensity
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

		// Token: 0x0600A8E6 RID: 43238 RVA: 0x002B3D4C File Offset: 0x002B1F4C
		public Span<byte> GetIntensityBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A8E7 RID: 43239 RVA: 0x002B3D5C File Offset: 0x002B1F5C
		public byte[] GetIntensityArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x0600A8E8 RID: 43240 RVA: 0x002B3D74 File Offset: 0x002B1F74
		public string Place
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

		// Token: 0x0600A8E9 RID: 43241 RVA: 0x002B3DAC File Offset: 0x002B1FAC
		public Span<byte> GetPlaceBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A8EA RID: 43242 RVA: 0x002B3DBC File Offset: 0x002B1FBC
		public byte[] GetPlaceArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x0600A8EB RID: 43243 RVA: 0x002B3DD4 File Offset: 0x002B1FD4
		public string Title1
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

		// Token: 0x0600A8EC RID: 43244 RVA: 0x002B3E0C File Offset: 0x002B200C
		public Span<byte> GetTitle1Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A8ED RID: 43245 RVA: 0x002B3E1C File Offset: 0x002B201C
		public byte[] GetTitle1Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x0600A8EE RID: 43246 RVA: 0x002B3E34 File Offset: 0x002B2034
		public string Descrtption1
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

		// Token: 0x0600A8EF RID: 43247 RVA: 0x002B3E6C File Offset: 0x002B206C
		public Span<byte> GetDescrtption1Bytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A8F0 RID: 43248 RVA: 0x002B3E7C File Offset: 0x002B207C
		public byte[] GetDescrtption1Array()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x0600A8F1 RID: 43249 RVA: 0x002B3E94 File Offset: 0x002B2094
		public string Title2
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

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x002B3ECC File Offset: 0x002B20CC
		public Span<byte> GetTitle2Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x002B3EDC File Offset: 0x002B20DC
		public byte[] GetTitle2Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170026E9 RID: 9961
		// (get) Token: 0x0600A8F4 RID: 43252 RVA: 0x002B3EF4 File Offset: 0x002B20F4
		public string Descrtption2
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

		// Token: 0x0600A8F5 RID: 43253 RVA: 0x002B3F2C File Offset: 0x002B212C
		public Span<byte> GetDescrtption2Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A8F6 RID: 43254 RVA: 0x002B3F3C File Offset: 0x002B213C
		public byte[] GetDescrtption2Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A8F7 RID: 43255 RVA: 0x002B3F54 File Offset: 0x002B2154
		public float Scale(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x0600A8F8 RID: 43256 RVA: 0x002B3F98 File Offset: 0x002B2198
		public int ScaleLength
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

		// Token: 0x0600A8F9 RID: 43257 RVA: 0x002B3FC4 File Offset: 0x002B21C4
		public Span<float> GetScaleBytes()
		{
			return this.__p.__vector_as_span<float>(22, 4);
		}

		// Token: 0x0600A8FA RID: 43258 RVA: 0x002B3FD4 File Offset: 0x002B21D4
		public float[] GetScaleArray()
		{
			return this.__p.__vector_as_array<float>(22) ?? Array.Empty<float>();
		}

		// Token: 0x0600A8FB RID: 43259 RVA: 0x002B3FEC File Offset: 0x002B21EC
		public float Position(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x0600A8FC RID: 43260 RVA: 0x002B4030 File Offset: 0x002B2230
		public int PositionLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x002B405C File Offset: 0x002B225C
		public Span<float> GetPositionBytes()
		{
			return this.__p.__vector_as_span<float>(24, 4);
		}

		// Token: 0x0600A8FE RID: 43262 RVA: 0x002B406C File Offset: 0x002B226C
		public float[] GetPositionArray()
		{
			return this.__p.__vector_as_array<float>(24) ?? Array.Empty<float>();
		}

		// Token: 0x0600A8FF RID: 43263 RVA: 0x002B4084 File Offset: 0x002B2284
		public float Rotator(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x0600A900 RID: 43264 RVA: 0x002B40C8 File Offset: 0x002B22C8
		public int RotatorLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A901 RID: 43265 RVA: 0x002B40F4 File Offset: 0x002B22F4
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(26, 4);
		}

		// Token: 0x0600A902 RID: 43266 RVA: 0x002B4104 File Offset: 0x002B2304
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(26) ?? Array.Empty<float>();
		}

		// Token: 0x0600A903 RID: 43267 RVA: 0x002B411C File Offset: 0x002B231C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PositionIter()或GetPositionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Position()
		{
			PhantomHandBook phantomHandBook = this;
			return phantomHandBook.GetPositionArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x002B4140 File Offset: 0x002B2340
		[NullableContext(1)]
		public readonly IEnumerable<float> PositionIter()
		{
			PhantomHandBook.<PositionIter>d__58 <PositionIter>d__ = new PhantomHandBook.<PositionIter>d__58(-2);
			<PositionIter>d__.<>3__<>4__this = this;
			return <PositionIter>d__;
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x002B4158 File Offset: 0x002B2358
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RotatorIter()或GetRotatorBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Rotator()
		{
			PhantomHandBook phantomHandBook = this;
			return phantomHandBook.GetRotatorArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A906 RID: 43270 RVA: 0x002B417C File Offset: 0x002B237C
		[NullableContext(1)]
		public readonly IEnumerable<float> RotatorIter()
		{
			PhantomHandBook.<RotatorIter>d__60 <RotatorIter>d__ = new PhantomHandBook.<RotatorIter>d__60(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x0600A907 RID: 43271 RVA: 0x002B4194 File Offset: 0x002B2394
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ScaleIter()或GetScaleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Scale()
		{
			PhantomHandBook phantomHandBook = this;
			return phantomHandBook.GetScaleArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A908 RID: 43272 RVA: 0x002B41B8 File Offset: 0x002B23B8
		[NullableContext(1)]
		public readonly IEnumerable<float> ScaleIter()
		{
			PhantomHandBook.<ScaleIter>d__62 <ScaleIter>d__ = new PhantomHandBook.<ScaleIter>d__62(-2);
			<ScaleIter>d__.<>3__<>4__this = this;
			return <ScaleIter>d__;
		}

		// Token: 0x04004FAD RID: 20397
		private Table __p;
	}
}
