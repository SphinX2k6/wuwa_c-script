using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BEF RID: 3055
	public struct DigitalScreen : IFlatbufferObject
	{
		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06006206 RID: 25094 RVA: 0x00212F5D File Offset: 0x0021115D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x00212F6A File Offset: 0x0021116A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x00212F74 File Offset: 0x00211174
		public static DigitalScreen GetRootAsDigitalScreen(ByteBuffer _bb)
		{
			return DigitalScreen.GetRootAsDigitalScreen(_bb, default(DigitalScreen));
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x00212F90 File Offset: 0x00211190
		public static DigitalScreen GetRootAsDigitalScreen(ByteBuffer _bb, DigitalScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x00212FAD File Offset: 0x002111AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600620B RID: 25099 RVA: 0x00212FBC File Offset: 0x002111BC
		public DigitalScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x0600620C RID: 25100 RVA: 0x00212FCC File Offset: 0x002111CC
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

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x00213008 File Offset: 0x00211208
		public string BackgroundPicture
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

		// Token: 0x0600620E RID: 25102 RVA: 0x0021303F File Offset: 0x0021123F
		public Span<byte> GetBackgroundPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x0021304E File Offset: 0x0021124E
		public byte[] GetBackgroundPictureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06006210 RID: 25104 RVA: 0x00213068 File Offset: 0x00211268
		public int Prefab
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

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06006211 RID: 25105 RVA: 0x002130A4 File Offset: 0x002112A4
		public int ExistTime
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

		// Token: 0x06006212 RID: 25106 RVA: 0x002130E4 File Offset: 0x002112E4
		public int TextId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x00213124 File Offset: 0x00211324
		public int TextIdLength
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

		// Token: 0x06006214 RID: 25108 RVA: 0x00213150 File Offset: 0x00211350
		public Span<int> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x00213160 File Offset: 0x00211360
		public int[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06006216 RID: 25110 RVA: 0x00213178 File Offset: 0x00211378
		public float TextFactor
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06006217 RID: 25111 RVA: 0x002131BC File Offset: 0x002113BC
		public string LogoIconPath
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

		// Token: 0x06006218 RID: 25112 RVA: 0x002131F4 File Offset: 0x002113F4
		public Span<byte> GetLogoIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x00213204 File Offset: 0x00211404
		public byte[] GetLogoIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600621A RID: 25114 RVA: 0x0021321C File Offset: 0x0021141C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TextIdIter()或GetTextIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TextId()
		{
			DigitalScreen digitalScreen = this;
			return digitalScreen.GetTextIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x00213240 File Offset: 0x00211440
		[NullableContext(1)]
		public readonly IEnumerable<int> TextIdIter()
		{
			DigitalScreen.<TextIdIter>d__30 <TextIdIter>d__ = new DigitalScreen.<TextIdIter>d__30(-2);
			<TextIdIter>d__.<>3__<>4__this = this;
			return <TextIdIter>d__;
		}

		// Token: 0x04004C1C RID: 19484
		private Table __p;
	}
}
