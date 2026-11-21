using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200128B RID: 4747
	public struct TrapDefenseAuxiliaryType : IFlatbufferObject
	{
		// Token: 0x17003F17 RID: 16151
		// (get) Token: 0x0600EFB9 RID: 61369 RVA: 0x00360E3B File Offset: 0x0035F03B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EFBA RID: 61370 RVA: 0x00360E48 File Offset: 0x0035F048
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EFBB RID: 61371 RVA: 0x00360E50 File Offset: 0x0035F050
		public static TrapDefenseAuxiliaryType GetRootAsTrapDefenseAuxiliaryType(ByteBuffer _bb)
		{
			return TrapDefenseAuxiliaryType.GetRootAsTrapDefenseAuxiliaryType(_bb, default(TrapDefenseAuxiliaryType));
		}

		// Token: 0x0600EFBC RID: 61372 RVA: 0x00360E6C File Offset: 0x0035F06C
		public static TrapDefenseAuxiliaryType GetRootAsTrapDefenseAuxiliaryType(ByteBuffer _bb, TrapDefenseAuxiliaryType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EFBD RID: 61373 RVA: 0x00360E89 File Offset: 0x0035F089
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EFBE RID: 61374 RVA: 0x00360E98 File Offset: 0x0035F098
		public TrapDefenseAuxiliaryType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x0600EFBF RID: 61375 RVA: 0x00360EA8 File Offset: 0x0035F0A8
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

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x0600EFC0 RID: 61376 RVA: 0x00360EE4 File Offset: 0x0035F0E4
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

		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x0600EFC1 RID: 61377 RVA: 0x00360F20 File Offset: 0x0035F120
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

		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x0600EFC2 RID: 61378 RVA: 0x00360F5C File Offset: 0x0035F15C
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

		// Token: 0x0600EFC3 RID: 61379 RVA: 0x00360F94 File Offset: 0x0035F194
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EFC4 RID: 61380 RVA: 0x00360FA4 File Offset: 0x0035F1A4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x0600EFC5 RID: 61381 RVA: 0x00360FBC File Offset: 0x0035F1BC
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

		// Token: 0x17003F1D RID: 16157
		// (get) Token: 0x0600EFC6 RID: 61382 RVA: 0x00360FFC File Offset: 0x0035F1FC
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

		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x0600EFC7 RID: 61383 RVA: 0x0036103C File Offset: 0x0035F23C
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

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x0600EFC8 RID: 61384 RVA: 0x0036107C File Offset: 0x0035F27C
		public bool IsInitUnlocked
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x0600EFC9 RID: 61385 RVA: 0x003610BC File Offset: 0x0035F2BC
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

		// Token: 0x0600EFCA RID: 61386 RVA: 0x003610FC File Offset: 0x0035F2FC
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x0600EFCB RID: 61387 RVA: 0x0036113C File Offset: 0x0035F33C
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

		// Token: 0x0600EFCC RID: 61388 RVA: 0x00361168 File Offset: 0x0035F368
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600EFCD RID: 61389 RVA: 0x00361178 File Offset: 0x0035F378
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17003F22 RID: 16162
		// (get) Token: 0x0600EFCE RID: 61390 RVA: 0x00361190 File Offset: 0x0035F390
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

		// Token: 0x0600EFCF RID: 61391 RVA: 0x003611C8 File Offset: 0x0035F3C8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600EFD0 RID: 61392 RVA: 0x003611D8 File Offset: 0x0035F3D8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x0600EFD1 RID: 61393 RVA: 0x003611F0 File Offset: 0x0035F3F0
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

		// Token: 0x0600EFD2 RID: 61394 RVA: 0x00361228 File Offset: 0x0035F428
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600EFD3 RID: 61395 RVA: 0x00361238 File Offset: 0x0035F438
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x0600EFD4 RID: 61396 RVA: 0x00361250 File Offset: 0x0035F450
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

		// Token: 0x0600EFD5 RID: 61397 RVA: 0x00361288 File Offset: 0x0035F488
		public Span<byte> GetVideoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600EFD6 RID: 61398 RVA: 0x00361298 File Offset: 0x0035F498
		public byte[] GetVideoPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x0600EFD7 RID: 61399 RVA: 0x003612B0 File Offset: 0x0035F4B0
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

		// Token: 0x0600EFD8 RID: 61400 RVA: 0x003612E8 File Offset: 0x0035F4E8
		public Span<byte> GetPsFeedbackIdBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600EFD9 RID: 61401 RVA: 0x003612F8 File Offset: 0x0035F4F8
		public byte[] GetPsFeedbackIdArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EFDA RID: 61402 RVA: 0x00361310 File Offset: 0x0035F510
		[NullableContext(1)]
		public int[] AttrShow()
		{
			return this.GetAttrShowArray();
		}

		// Token: 0x0600EFDB RID: 61403 RVA: 0x00361318 File Offset: 0x0035F518
		[NullableContext(1)]
		public IEnumerable<int> AttrShowIter()
		{
			TrapDefenseAuxiliaryType.<AttrShowIter>d__50 <AttrShowIter>d__ = new TrapDefenseAuxiliaryType.<AttrShowIter>d__50(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x040058DD RID: 22749
		private Table __p;
	}
}
