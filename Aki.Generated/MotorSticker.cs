using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6A RID: 3690
	public struct MotorSticker : IFlatbufferObject
	{
		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x06009C1B RID: 39963 RVA: 0x0029740C File Offset: 0x0029560C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C1C RID: 39964 RVA: 0x00297419 File Offset: 0x00295619
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C1D RID: 39965 RVA: 0x00297420 File Offset: 0x00295620
		public static MotorSticker GetRootAsMotorSticker(ByteBuffer _bb)
		{
			return MotorSticker.GetRootAsMotorSticker(_bb, default(MotorSticker));
		}

		// Token: 0x06009C1E RID: 39966 RVA: 0x0029743C File Offset: 0x0029563C
		public static MotorSticker GetRootAsMotorSticker(ByteBuffer _bb, MotorSticker obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C1F RID: 39967 RVA: 0x00297459 File Offset: 0x00295659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C20 RID: 39968 RVA: 0x00297468 File Offset: 0x00295668
		public MotorSticker __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x06009C21 RID: 39969 RVA: 0x00297478 File Offset: 0x00295678
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

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x06009C22 RID: 39970 RVA: 0x002974B4 File Offset: 0x002956B4
		public int GroupId
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

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x06009C23 RID: 39971 RVA: 0x002974F0 File Offset: 0x002956F0
		public int PartId
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

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x06009C24 RID: 39972 RVA: 0x0029752C File Offset: 0x0029572C
		public bool FreeFlag
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x06009C25 RID: 39973 RVA: 0x0029756C File Offset: 0x0029576C
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x06009C26 RID: 39974 RVA: 0x002975AC File Offset: 0x002957AC
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x06009C27 RID: 39975 RVA: 0x002975EC File Offset: 0x002957EC
		public string MaterialDA
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

		// Token: 0x06009C28 RID: 39976 RVA: 0x00297624 File Offset: 0x00295824
		public Span<byte> GetMaterialDABytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x00297634 File Offset: 0x00295834
		public byte[] GetMaterialDAArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x06009C2A RID: 39978 RVA: 0x0029764C File Offset: 0x0029584C
		public string StickerPath
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

		// Token: 0x06009C2B RID: 39979 RVA: 0x00297684 File Offset: 0x00295884
		public Span<byte> GetStickerPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009C2C RID: 39980 RVA: 0x00297694 File Offset: 0x00295894
		public byte[] GetStickerPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x06009C2D RID: 39981 RVA: 0x002976AC File Offset: 0x002958AC
		public string StickerPBRPath
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

		// Token: 0x06009C2E RID: 39982 RVA: 0x002976E4 File Offset: 0x002958E4
		public Span<byte> GetStickerPBRPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009C2F RID: 39983 RVA: 0x002976F4 File Offset: 0x002958F4
		public byte[] GetStickerPBRPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x06009C30 RID: 39984 RVA: 0x0029770C File Offset: 0x0029590C
		public string StickerIconPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C31 RID: 39985 RVA: 0x00297744 File Offset: 0x00295944
		public Span<byte> GetStickerIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009C32 RID: 39986 RVA: 0x00297754 File Offset: 0x00295954
		public byte[] GetStickerIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x06009C33 RID: 39987 RVA: 0x0029776C File Offset: 0x0029596C
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

		// Token: 0x06009C34 RID: 39988 RVA: 0x002977A4 File Offset: 0x002959A4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009C35 RID: 39989 RVA: 0x002977B4 File Offset: 0x002959B4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x06009C36 RID: 39990 RVA: 0x002977CC File Offset: 0x002959CC
		public string IconMiddle
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

		// Token: 0x06009C37 RID: 39991 RVA: 0x00297804 File Offset: 0x00295A04
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x00297814 File Offset: 0x00295A14
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x06009C39 RID: 39993 RVA: 0x0029782C File Offset: 0x00295A2C
		public string IconSmall
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

		// Token: 0x06009C3A RID: 39994 RVA: 0x00297864 File Offset: 0x00295A64
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009C3B RID: 39995 RVA: 0x00297874 File Offset: 0x00295A74
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x06009C3C RID: 39996 RVA: 0x0029788C File Offset: 0x00295A8C
		public string Title
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

		// Token: 0x06009C3D RID: 39997 RVA: 0x002978C4 File Offset: 0x00295AC4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x002978D4 File Offset: 0x00295AD4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x06009C3F RID: 39999 RVA: 0x002978EC File Offset: 0x00295AEC
		public string SubTitle
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x00297924 File Offset: 0x00295B24
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06009C41 RID: 40001 RVA: 0x00297934 File Offset: 0x00295B34
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x06009C42 RID: 40002 RVA: 0x0029794C File Offset: 0x00295B4C
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C43 RID: 40003 RVA: 0x00297984 File Offset: 0x00295B84
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x00297994 File Offset: 0x00295B94
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x06009C45 RID: 40005 RVA: 0x002979AC File Offset: 0x00295BAC
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C46 RID: 40006 RVA: 0x002979E4 File Offset: 0x00295BE4
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x002979F4 File Offset: 0x00295BF4
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x00297A0C File Offset: 0x00295C0C
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x06009C49 RID: 40009 RVA: 0x00297A4C File Offset: 0x00295C4C
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009C4A RID: 40010 RVA: 0x00297A78 File Offset: 0x00295C78
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x00297A88 File Offset: 0x00295C88
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x06009C4C RID: 40012 RVA: 0x00297AA0 File Offset: 0x00295CA0
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x06009C4D RID: 40013 RVA: 0x00297AE0 File Offset: 0x00295CE0
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C4E RID: 40014 RVA: 0x00297B18 File Offset: 0x00295D18
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x00297B28 File Offset: 0x00295D28
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x00297B40 File Offset: 0x00295D40
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			MotorSticker motorSticker = this;
			return motorSticker.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009C51 RID: 40017 RVA: 0x00297B64 File Offset: 0x00295D64
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			MotorSticker.<ItemAccessIter>d__76 <ItemAccessIter>d__ = new MotorSticker.<ItemAccessIter>d__76(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x04004F17 RID: 20247
		private Table __p;
	}
}
