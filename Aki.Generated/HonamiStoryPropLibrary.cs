using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4A RID: 3402
	public struct HonamiStoryPropLibrary : IFlatbufferObject
	{
		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06008103 RID: 33027 RVA: 0x00259BC8 File Offset: 0x00257DC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008104 RID: 33028 RVA: 0x00259BD5 File Offset: 0x00257DD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008105 RID: 33029 RVA: 0x00259BDC File Offset: 0x00257DDC
		public static HonamiStoryPropLibrary GetRootAsHonamiStoryPropLibrary(ByteBuffer _bb)
		{
			return HonamiStoryPropLibrary.GetRootAsHonamiStoryPropLibrary(_bb, default(HonamiStoryPropLibrary));
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x00259BF8 File Offset: 0x00257DF8
		public static HonamiStoryPropLibrary GetRootAsHonamiStoryPropLibrary(ByteBuffer _bb, HonamiStoryPropLibrary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008107 RID: 33031 RVA: 0x00259C15 File Offset: 0x00257E15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008108 RID: 33032 RVA: 0x00259C24 File Offset: 0x00257E24
		public HonamiStoryPropLibrary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06008109 RID: 33033 RVA: 0x00259C34 File Offset: 0x00257E34
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

		// Token: 0x0600810A RID: 33034 RVA: 0x00259C70 File Offset: 0x00257E70
		public int HonamiStoryPropId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x0600810B RID: 33035 RVA: 0x00259CB0 File Offset: 0x00257EB0
		public int HonamiStoryPropIdLength
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

		// Token: 0x0600810C RID: 33036 RVA: 0x00259CDB File Offset: 0x00257EDB
		public Span<int> GetHonamiStoryPropIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x00259CEA File Offset: 0x00257EEA
		public int[] GetHonamiStoryPropIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x00259D04 File Offset: 0x00257F04
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HonamiStoryPropIdIter()或GetHonamiStoryPropIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] HonamiStoryPropId()
		{
			HonamiStoryPropLibrary honamiStoryPropLibrary = this;
			return honamiStoryPropLibrary.GetHonamiStoryPropIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600810F RID: 33039 RVA: 0x00259D28 File Offset: 0x00257F28
		[NullableContext(1)]
		public readonly IEnumerable<int> HonamiStoryPropIdIter()
		{
			HonamiStoryPropLibrary.<HonamiStoryPropIdIter>d__16 <HonamiStoryPropIdIter>d__ = new HonamiStoryPropLibrary.<HonamiStoryPropIdIter>d__16(-2);
			<HonamiStoryPropIdIter>d__.<>3__<>4__this = this;
			return <HonamiStoryPropIdIter>d__;
		}

		// Token: 0x04004DC6 RID: 19910
		private Table __p;
	}
}
