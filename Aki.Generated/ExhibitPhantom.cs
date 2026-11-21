using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2A RID: 3370
	public struct ExhibitPhantom : IFlatbufferObject
	{
		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x060070C5 RID: 28869 RVA: 0x00245DBE File Offset: 0x00243FBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060070C6 RID: 28870 RVA: 0x00245DCB File Offset: 0x00243FCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x00245DD4 File Offset: 0x00243FD4
		public static ExhibitPhantom GetRootAsExhibitPhantom(ByteBuffer _bb)
		{
			return ExhibitPhantom.GetRootAsExhibitPhantom(_bb, default(ExhibitPhantom));
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x00245DF0 File Offset: 0x00243FF0
		public static ExhibitPhantom GetRootAsExhibitPhantom(ByteBuffer _bb, ExhibitPhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x00245E0D File Offset: 0x0024400D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x00245E1C File Offset: 0x0024401C
		public ExhibitPhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x060070CB RID: 28875 RVA: 0x00245E2C File Offset: 0x0024402C
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

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x060070CC RID: 28876 RVA: 0x00245E68 File Offset: 0x00244068
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

		// Token: 0x060070CD RID: 28877 RVA: 0x00245EA4 File Offset: 0x002440A4
		public float Zoom(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x060070CE RID: 28878 RVA: 0x00245EE8 File Offset: 0x002440E8
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

		// Token: 0x060070CF RID: 28879 RVA: 0x00245F13 File Offset: 0x00244113
		public Span<float> GetZoomBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x00245F22 File Offset: 0x00244122
		public float[] GetZoomArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x00245F3C File Offset: 0x0024413C
		public float Location(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x060070D2 RID: 28882 RVA: 0x00245F80 File Offset: 0x00244180
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

		// Token: 0x060070D3 RID: 28883 RVA: 0x00245FAC File Offset: 0x002441AC
		public Span<float> GetLocationBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x00245FBC File Offset: 0x002441BC
		public float[] GetLocationArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x00245FD4 File Offset: 0x002441D4
		public float Rotator(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x060070D6 RID: 28886 RVA: 0x00246018 File Offset: 0x00244218
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

		// Token: 0x060070D7 RID: 28887 RVA: 0x00246044 File Offset: 0x00244244
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x00246054 File Offset: 0x00244254
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x060070D9 RID: 28889 RVA: 0x0024606C File Offset: 0x0024426C
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060070DA RID: 28890 RVA: 0x002460AC File Offset: 0x002442AC
		[NullableContext(1)]
		public float[] Location()
		{
			return this.GetLocationArray();
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x002460B4 File Offset: 0x002442B4
		[NullableContext(1)]
		public IEnumerable<float> LocationIter()
		{
			ExhibitPhantom.<LocationIter>d__30 <LocationIter>d__ = new ExhibitPhantom.<LocationIter>d__30(-2);
			<LocationIter>d__.<>3__<>4__this = this;
			return <LocationIter>d__;
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x002460C9 File Offset: 0x002442C9
		[NullableContext(1)]
		public float[] Rotator()
		{
			return this.GetRotatorArray();
		}

		// Token: 0x060070DD RID: 28893 RVA: 0x002460D1 File Offset: 0x002442D1
		[NullableContext(1)]
		public IEnumerable<float> RotatorIter()
		{
			ExhibitPhantom.<RotatorIter>d__32 <RotatorIter>d__ = new ExhibitPhantom.<RotatorIter>d__32(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x002460E6 File Offset: 0x002442E6
		[NullableContext(1)]
		public float[] Zoom()
		{
			return this.GetZoomArray();
		}

		// Token: 0x060070DF RID: 28895 RVA: 0x002460EE File Offset: 0x002442EE
		[NullableContext(1)]
		public IEnumerable<float> ZoomIter()
		{
			ExhibitPhantom.<ZoomIter>d__34 <ZoomIter>d__ = new ExhibitPhantom.<ZoomIter>d__34(-2);
			<ZoomIter>d__.<>3__<>4__this = this;
			return <ZoomIter>d__;
		}

		// Token: 0x0400526F RID: 21103
		private Table __p;
	}
}
