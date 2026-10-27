using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001155 RID: 4437
	public struct TrapDefenseAuxiliaryType : IFlatbufferObject
	{
		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x0600E24B RID: 57931 RVA: 0x00335C91 File Offset: 0x00333E91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E24C RID: 57932 RVA: 0x00335C9E File Offset: 0x00333E9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E24D RID: 57933 RVA: 0x00335CA8 File Offset: 0x00333EA8
		public static TrapDefenseAuxiliaryType GetRootAsTrapDefenseAuxiliaryType(ByteBuffer _bb)
		{
			return TrapDefenseAuxiliaryType.GetRootAsTrapDefenseAuxiliaryType(_bb, default(TrapDefenseAuxiliaryType));
		}

		// Token: 0x0600E24E RID: 57934 RVA: 0x00335CC4 File Offset: 0x00333EC4
		public static TrapDefenseAuxiliaryType GetRootAsTrapDefenseAuxiliaryType(ByteBuffer _bb, TrapDefenseAuxiliaryType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E24F RID: 57935 RVA: 0x00335CE1 File Offset: 0x00333EE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E250 RID: 57936 RVA: 0x00335CF0 File Offset: 0x00333EF0
		public TrapDefenseAuxiliaryType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x0600E251 RID: 57937 RVA: 0x00335D00 File Offset: 0x00333F00
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

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x0600E252 RID: 57938 RVA: 0x00335D3C File Offset: 0x00333F3C
		public int ActivityId
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

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x0600E253 RID: 57939 RVA: 0x00335D78 File Offset: 0x00333F78
		public int SortId
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

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0600E254 RID: 57940 RVA: 0x00335DB4 File Offset: 0x00333FB4
		public string Name
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

		// Token: 0x0600E255 RID: 57941 RVA: 0x00335DEC File Offset: 0x00333FEC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E256 RID: 57942 RVA: 0x00335DFC File Offset: 0x00333FFC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0600E257 RID: 57943 RVA: 0x00335E14 File Offset: 0x00334014
		public int DamageType
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

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0600E258 RID: 57944 RVA: 0x00335E54 File Offset: 0x00334054
		public int MaxLevel
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x0600E259 RID: 57945 RVA: 0x00335E94 File Offset: 0x00334094
		public int InitMaxLevel
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x0600E25A RID: 57946 RVA: 0x00335ED4 File Offset: 0x003340D4
		public bool IsInitUnlocked
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x0600E25B RID: 57947 RVA: 0x00335F14 File Offset: 0x00334114
		public int BranchCount
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E25C RID: 57948 RVA: 0x00335F54 File Offset: 0x00334154
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x0600E25D RID: 57949 RVA: 0x00335F94 File Offset: 0x00334194
		public int AttrShowLength
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

		// Token: 0x0600E25E RID: 57950 RVA: 0x00335FC0 File Offset: 0x003341C0
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E25F RID: 57951 RVA: 0x00335FD0 File Offset: 0x003341D0
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x0600E260 RID: 57952 RVA: 0x00335FE8 File Offset: 0x003341E8
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E261 RID: 57953 RVA: 0x00336020 File Offset: 0x00334220
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600E262 RID: 57954 RVA: 0x00336030 File Offset: 0x00334230
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x0600E263 RID: 57955 RVA: 0x00336048 File Offset: 0x00334248
		public string VideoName
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E264 RID: 57956 RVA: 0x00336080 File Offset: 0x00334280
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E265 RID: 57957 RVA: 0x00336090 File Offset: 0x00334290
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x0600E266 RID: 57958 RVA: 0x003360A8 File Offset: 0x003342A8
		public string VideoPath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E267 RID: 57959 RVA: 0x003360E0 File Offset: 0x003342E0
		public Span<byte> GetVideoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600E268 RID: 57960 RVA: 0x003360F0 File Offset: 0x003342F0
		public byte[] GetVideoPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0600E269 RID: 57961 RVA: 0x00336108 File Offset: 0x00334308
		public string PsFeedbackId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E26A RID: 57962 RVA: 0x00336140 File Offset: 0x00334340
		public Span<byte> GetPsFeedbackIdBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600E26B RID: 57963 RVA: 0x00336150 File Offset: 0x00334350
		public byte[] GetPsFeedbackIdArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E26C RID: 57964 RVA: 0x00336168 File Offset: 0x00334368
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttrShowIter()或GetAttrShowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttrShow()
		{
			TrapDefenseAuxiliaryType trapDefenseAuxiliaryType = this;
			return trapDefenseAuxiliaryType.GetAttrShowArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E26D RID: 57965 RVA: 0x0033618C File Offset: 0x0033438C
		[NullableContext(1)]
		public readonly IEnumerable<int> AttrShowIter()
		{
			TrapDefenseAuxiliaryType.<AttrShowIter>d__50 <AttrShowIter>d__ = new TrapDefenseAuxiliaryType.<AttrShowIter>d__50(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x0400529A RID: 21146
		private Table __p;
	}
}
