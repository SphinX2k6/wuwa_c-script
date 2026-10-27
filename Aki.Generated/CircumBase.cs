using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7E RID: 2942
	public struct CircumBase : IFlatbufferObject
	{
		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060055B9 RID: 21945 RVA: 0x001F662C File Offset: 0x001F482C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x001F6639 File Offset: 0x001F4839
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x001F6640 File Offset: 0x001F4840
		public static CircumBase GetRootAsCircumBase(ByteBuffer _bb)
		{
			return CircumBase.GetRootAsCircumBase(_bb, default(CircumBase));
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x001F665C File Offset: 0x001F485C
		public static CircumBase GetRootAsCircumBase(ByteBuffer _bb, CircumBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x001F6679 File Offset: 0x001F4879
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x001F6688 File Offset: 0x001F4888
		public CircumBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060055BF RID: 21951 RVA: 0x001F6698 File Offset: 0x001F4898
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

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060055C0 RID: 21952 RVA: 0x001F66D4 File Offset: 0x001F48D4
		public int EntryType
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

		// Token: 0x060055C1 RID: 21953 RVA: 0x001F6710 File Offset: 0x001F4910
		public int ArgId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060055C2 RID: 21954 RVA: 0x001F6750 File Offset: 0x001F4950
		public int ArgIdLength
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

		// Token: 0x060055C3 RID: 21955 RVA: 0x001F677B File Offset: 0x001F497B
		public Span<int> GetArgIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x001F678A File Offset: 0x001F498A
		public int[] GetArgIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060055C5 RID: 21957 RVA: 0x001F67A4 File Offset: 0x001F49A4
		public string Title
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

		// Token: 0x060055C6 RID: 21958 RVA: 0x001F67DC File Offset: 0x001F49DC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x001F67EC File Offset: 0x001F49EC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060055C8 RID: 21960 RVA: 0x001F6804 File Offset: 0x001F4A04
		public int GachaId
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

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060055C9 RID: 21961 RVA: 0x001F6844 File Offset: 0x001F4A44
		public string SubTitle
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

		// Token: 0x060055CA RID: 21962 RVA: 0x001F687C File Offset: 0x001F4A7C
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x001F688C File Offset: 0x001F4A8C
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x001F68A4 File Offset: 0x001F4AA4
		public string BgPathF
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

		// Token: 0x060055CD RID: 21965 RVA: 0x001F68DC File Offset: 0x001F4ADC
		public Span<byte> GetBgPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x001F68EC File Offset: 0x001F4AEC
		public byte[] GetBgPathFArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060055CF RID: 21967 RVA: 0x001F6904 File Offset: 0x001F4B04
		public string BgPath
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

		// Token: 0x060055D0 RID: 21968 RVA: 0x001F693C File Offset: 0x001F4B3C
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x001F694C File Offset: 0x001F4B4C
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060055D2 RID: 21970 RVA: 0x001F6964 File Offset: 0x001F4B64
		public string Description
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

		// Token: 0x060055D3 RID: 21971 RVA: 0x001F699C File Offset: 0x001F4B9C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x001F69AC File Offset: 0x001F4BAC
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060055D5 RID: 21973 RVA: 0x001F69C4 File Offset: 0x001F4BC4
		public int RewardPreview
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060055D6 RID: 21974 RVA: 0x001F6A04 File Offset: 0x001F4C04
		public bool ShowCondition
		{
			get
			{
				int num = this.__p.__offset(24);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x001F6A44 File Offset: 0x001F4C44
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArgIdIter()或GetArgIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ArgId()
		{
			CircumBase circumBase = this;
			return circumBase.GetArgIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x001F6A68 File Offset: 0x001F4C68
		[NullableContext(1)]
		public readonly IEnumerable<int> ArgIdIter()
		{
			CircumBase.<ArgIdIter>d__44 <ArgIdIter>d__ = new CircumBase.<ArgIdIter>d__44(-2);
			<ArgIdIter>d__.<>3__<>4__this = this;
			return <ArgIdIter>d__;
		}

		// Token: 0x04004B82 RID: 19330
		private Table __p;
	}
}
