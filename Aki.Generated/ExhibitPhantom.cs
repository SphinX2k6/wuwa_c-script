using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C47 RID: 3143
	public struct ExhibitPhantom : IFlatbufferObject
	{
		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06006AC3 RID: 27331 RVA: 0x00226A76 File Offset: 0x00224C76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x00226A83 File Offset: 0x00224C83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x00226A8C File Offset: 0x00224C8C
		public static ExhibitPhantom GetRootAsExhibitPhantom(ByteBuffer _bb)
		{
			return ExhibitPhantom.GetRootAsExhibitPhantom(_bb, default(ExhibitPhantom));
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x00226AA8 File Offset: 0x00224CA8
		public static ExhibitPhantom GetRootAsExhibitPhantom(ByteBuffer _bb, ExhibitPhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x00226AC5 File Offset: 0x00224CC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x00226AD4 File Offset: 0x00224CD4
		public ExhibitPhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06006AC9 RID: 27337 RVA: 0x00226AE4 File Offset: 0x00224CE4
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

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06006ACA RID: 27338 RVA: 0x00226B20 File Offset: 0x00224D20
		public int BodyType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x00226B5C File Offset: 0x00224D5C
		public float Zoom(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06006ACC RID: 27340 RVA: 0x00226BA0 File Offset: 0x00224DA0
		public int ZoomLength
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

		// Token: 0x06006ACD RID: 27341 RVA: 0x00226BCB File Offset: 0x00224DCB
		public Span<float> GetZoomBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x00226BDA File Offset: 0x00224DDA
		public float[] GetZoomArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x00226BF4 File Offset: 0x00224DF4
		public float Location(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06006AD0 RID: 27344 RVA: 0x00226C38 File Offset: 0x00224E38
		public int LocationLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x00226C64 File Offset: 0x00224E64
		public Span<float> GetLocationBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x00226C74 File Offset: 0x00224E74
		public float[] GetLocationArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x00226C8C File Offset: 0x00224E8C
		public float Rotator(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06006AD4 RID: 27348 RVA: 0x00226CD0 File Offset: 0x00224ED0
		public int RotatorLength
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

		// Token: 0x06006AD5 RID: 27349 RVA: 0x00226CFC File Offset: 0x00224EFC
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x00226D0C File Offset: 0x00224F0C
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06006AD7 RID: 27351 RVA: 0x00226D24 File Offset: 0x00224F24
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x00226D64 File Offset: 0x00224F64
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LocationIter()或GetLocationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Location()
		{
			ExhibitPhantom exhibitPhantom = this;
			return exhibitPhantom.GetLocationArray() ?? Array.Empty<float>();
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00226D88 File Offset: 0x00224F88
		[NullableContext(1)]
		public readonly IEnumerable<float> LocationIter()
		{
			ExhibitPhantom.<LocationIter>d__30 <LocationIter>d__ = new ExhibitPhantom.<LocationIter>d__30(-2);
			<LocationIter>d__.<>3__<>4__this = this;
			return <LocationIter>d__;
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x00226DA0 File Offset: 0x00224FA0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RotatorIter()或GetRotatorBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Rotator()
		{
			ExhibitPhantom exhibitPhantom = this;
			return exhibitPhantom.GetRotatorArray() ?? Array.Empty<float>();
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x00226DC4 File Offset: 0x00224FC4
		[NullableContext(1)]
		public readonly IEnumerable<float> RotatorIter()
		{
			ExhibitPhantom.<RotatorIter>d__32 <RotatorIter>d__ = new ExhibitPhantom.<RotatorIter>d__32(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x00226DDC File Offset: 0x00224FDC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ZoomIter()或GetZoomBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Zoom()
		{
			ExhibitPhantom exhibitPhantom = this;
			return exhibitPhantom.GetZoomArray() ?? Array.Empty<float>();
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x00226E00 File Offset: 0x00225000
		[NullableContext(1)]
		public readonly IEnumerable<float> ZoomIter()
		{
			ExhibitPhantom.<ZoomIter>d__34 <ZoomIter>d__ = new ExhibitPhantom.<ZoomIter>d__34(-2);
			<ZoomIter>d__.<>3__<>4__this = this;
			return <ZoomIter>d__;
		}

		// Token: 0x04004C8C RID: 19596
		private Table __p;
	}
}
