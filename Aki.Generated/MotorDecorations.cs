using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E34 RID: 3636
	public struct MotorDecorations : IFlatbufferObject
	{
		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06009719 RID: 38681 RVA: 0x0028BDE4 File Offset: 0x00289FE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600971A RID: 38682 RVA: 0x0028BDF1 File Offset: 0x00289FF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600971B RID: 38683 RVA: 0x0028BDF8 File Offset: 0x00289FF8
		public static MotorDecorations GetRootAsMotorDecorations(ByteBuffer _bb)
		{
			return MotorDecorations.GetRootAsMotorDecorations(_bb, default(MotorDecorations));
		}

		// Token: 0x0600971C RID: 38684 RVA: 0x0028BE14 File Offset: 0x0028A014
		public static MotorDecorations GetRootAsMotorDecorations(ByteBuffer _bb, MotorDecorations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x0028BE31 File Offset: 0x0028A031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x0028BE40 File Offset: 0x0028A040
		public MotorDecorations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x0600971F RID: 38687 RVA: 0x0028BE50 File Offset: 0x0028A050
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

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x06009720 RID: 38688 RVA: 0x0028BE8C File Offset: 0x0028A08C
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

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06009721 RID: 38689 RVA: 0x0028BEC8 File Offset: 0x0028A0C8
		public int PartId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x06009722 RID: 38690 RVA: 0x0028BF04 File Offset: 0x0028A104
		public bool FreeFlag
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x06009723 RID: 38691 RVA: 0x0028BF44 File Offset: 0x0028A144
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

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x06009724 RID: 38692 RVA: 0x0028BF84 File Offset: 0x0028A184
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

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06009725 RID: 38693 RVA: 0x0028BFC4 File Offset: 0x0028A1C4
		public int ModelId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06009726 RID: 38694 RVA: 0x0028C004 File Offset: 0x0028A204
		public string DecorationsIconPath
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

		// Token: 0x06009727 RID: 38695 RVA: 0x0028C03C File Offset: 0x0028A23C
		public Span<byte> GetDecorationsIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009728 RID: 38696 RVA: 0x0028C04C File Offset: 0x0028A24C
		public byte[] GetDecorationsIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x06009729 RID: 38697 RVA: 0x0028C064 File Offset: 0x0028A264
		public string Icon
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

		// Token: 0x0600972A RID: 38698 RVA: 0x0028C09C File Offset: 0x0028A29C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600972B RID: 38699 RVA: 0x0028C0AC File Offset: 0x0028A2AC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x0600972C RID: 38700 RVA: 0x0028C0C4 File Offset: 0x0028A2C4
		public string IconMiddle
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

		// Token: 0x0600972D RID: 38701 RVA: 0x0028C0FC File Offset: 0x0028A2FC
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600972E RID: 38702 RVA: 0x0028C10C File Offset: 0x0028A30C
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x0600972F RID: 38703 RVA: 0x0028C124 File Offset: 0x0028A324
		public string IconSmall
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

		// Token: 0x06009730 RID: 38704 RVA: 0x0028C15C File Offset: 0x0028A35C
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009731 RID: 38705 RVA: 0x0028C16C File Offset: 0x0028A36C
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x06009732 RID: 38706 RVA: 0x0028C184 File Offset: 0x0028A384
		public string Title
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

		// Token: 0x06009733 RID: 38707 RVA: 0x0028C1BC File Offset: 0x0028A3BC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009734 RID: 38708 RVA: 0x0028C1CC File Offset: 0x0028A3CC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x06009735 RID: 38709 RVA: 0x0028C1E4 File Offset: 0x0028A3E4
		public string SubTitle
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

		// Token: 0x06009736 RID: 38710 RVA: 0x0028C21C File Offset: 0x0028A41C
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009737 RID: 38711 RVA: 0x0028C22C File Offset: 0x0028A42C
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x06009738 RID: 38712 RVA: 0x0028C244 File Offset: 0x0028A444
		public string TypeDescription
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

		// Token: 0x06009739 RID: 38713 RVA: 0x0028C27C File Offset: 0x0028A47C
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600973A RID: 38714 RVA: 0x0028C28C File Offset: 0x0028A48C
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x0600973B RID: 38715 RVA: 0x0028C2A4 File Offset: 0x0028A4A4
		public string AttributesDescription
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

		// Token: 0x0600973C RID: 38716 RVA: 0x0028C2DC File Offset: 0x0028A4DC
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600973D RID: 38717 RVA: 0x0028C2EC File Offset: 0x0028A4EC
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600973E RID: 38718 RVA: 0x0028C304 File Offset: 0x0028A504
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x0600973F RID: 38719 RVA: 0x0028C344 File Offset: 0x0028A544
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009740 RID: 38720 RVA: 0x0028C370 File Offset: 0x0028A570
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06009741 RID: 38721 RVA: 0x0028C380 File Offset: 0x0028A580
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x06009742 RID: 38722 RVA: 0x0028C398 File Offset: 0x0028A598
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x06009743 RID: 38723 RVA: 0x0028C3D8 File Offset: 0x0028A5D8
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009744 RID: 38724 RVA: 0x0028C410 File Offset: 0x0028A610
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06009745 RID: 38725 RVA: 0x0028C420 File Offset: 0x0028A620
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06009746 RID: 38726 RVA: 0x0028C438 File Offset: 0x0028A638
		public float Scale(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x06009747 RID: 38727 RVA: 0x0028C47C File Offset: 0x0028A67C
		public int ScaleLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009748 RID: 38728 RVA: 0x0028C4A8 File Offset: 0x0028A6A8
		public Span<float> GetScaleBytes()
		{
			return this.__p.__vector_as_span<float>(40, 4);
		}

		// Token: 0x06009749 RID: 38729 RVA: 0x0028C4B8 File Offset: 0x0028A6B8
		public float[] GetScaleArray()
		{
			return this.__p.__vector_as_array<float>(40) ?? Array.Empty<float>();
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x0600974A RID: 38730 RVA: 0x0028C4D0 File Offset: 0x0028A6D0
		public string SocketName
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

		// Token: 0x0600974B RID: 38731 RVA: 0x0028C508 File Offset: 0x0028A708
		public Span<byte> GetSocketNameBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600974C RID: 38732 RVA: 0x0028C518 File Offset: 0x0028A718
		public byte[] GetSocketNameArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x0600974D RID: 38733 RVA: 0x0028C530 File Offset: 0x0028A730
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			MotorDecorations motorDecorations = this;
			return motorDecorations.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600974E RID: 38734 RVA: 0x0028C554 File Offset: 0x0028A754
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			MotorDecorations.<ItemAccessIter>d__75 <ItemAccessIter>d__ = new MotorDecorations.<ItemAccessIter>d__75(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600974F RID: 38735 RVA: 0x0028C56C File Offset: 0x0028A76C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ScaleIter()或GetScaleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Scale()
		{
			MotorDecorations motorDecorations = this;
			return motorDecorations.GetScaleArray() ?? Array.Empty<float>();
		}

		// Token: 0x06009750 RID: 38736 RVA: 0x0028C590 File Offset: 0x0028A790
		[NullableContext(1)]
		public readonly IEnumerable<float> ScaleIter()
		{
			MotorDecorations.<ScaleIter>d__77 <ScaleIter>d__ = new MotorDecorations.<ScaleIter>d__77(-2);
			<ScaleIter>d__.<>3__<>4__this = this;
			return <ScaleIter>d__;
		}

		// Token: 0x04004EDA RID: 20186
		private Table __p;
	}
}
