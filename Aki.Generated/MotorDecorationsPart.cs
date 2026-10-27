using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E35 RID: 3637
	public struct MotorDecorationsPart : IFlatbufferObject
	{
		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x06009751 RID: 38737 RVA: 0x0028C5A5 File Offset: 0x0028A7A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009752 RID: 38738 RVA: 0x0028C5B2 File Offset: 0x0028A7B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009753 RID: 38739 RVA: 0x0028C5BC File Offset: 0x0028A7BC
		public static MotorDecorationsPart GetRootAsMotorDecorationsPart(ByteBuffer _bb)
		{
			return MotorDecorationsPart.GetRootAsMotorDecorationsPart(_bb, default(MotorDecorationsPart));
		}

		// Token: 0x06009754 RID: 38740 RVA: 0x0028C5D8 File Offset: 0x0028A7D8
		public static MotorDecorationsPart GetRootAsMotorDecorationsPart(ByteBuffer _bb, MotorDecorationsPart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009755 RID: 38741 RVA: 0x0028C5F5 File Offset: 0x0028A7F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009756 RID: 38742 RVA: 0x0028C604 File Offset: 0x0028A804
		public MotorDecorationsPart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x06009757 RID: 38743 RVA: 0x0028C614 File Offset: 0x0028A814
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

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x06009758 RID: 38744 RVA: 0x0028C650 File Offset: 0x0028A850
		public string Icon
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

		// Token: 0x06009759 RID: 38745 RVA: 0x0028C687 File Offset: 0x0028A887
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600975A RID: 38746 RVA: 0x0028C696 File Offset: 0x0028A896
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x0600975B RID: 38747 RVA: 0x0028C6B0 File Offset: 0x0028A8B0
		public string IconSelect
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

		// Token: 0x0600975C RID: 38748 RVA: 0x0028C6E7 File Offset: 0x0028A8E7
		public Span<byte> GetIconSelectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600975D RID: 38749 RVA: 0x0028C6F6 File Offset: 0x0028A8F6
		public byte[] GetIconSelectArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600975E RID: 38750 RVA: 0x0028C710 File Offset: 0x0028A910
		public string CameraIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x0600975F RID: 38751 RVA: 0x0028C74C File Offset: 0x0028A94C
		public int CameraIdsLength
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

		// Token: 0x06009760 RID: 38752 RVA: 0x0028C778 File Offset: 0x0028A978
		public string DetailCameraIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x06009761 RID: 38753 RVA: 0x0028C7B4 File Offset: 0x0028A9B4
		public int DetailCameraIdsLength
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

		// Token: 0x06009762 RID: 38754 RVA: 0x0028C7E0 File Offset: 0x0028A9E0
		public string HangPoints(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x06009763 RID: 38755 RVA: 0x0028C81C File Offset: 0x0028AA1C
		public int HangPointsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009764 RID: 38756 RVA: 0x0028C848 File Offset: 0x0028AA48
		public string EditCameraIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x06009765 RID: 38757 RVA: 0x0028C884 File Offset: 0x0028AA84
		public int EditCameraIdsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009766 RID: 38758 RVA: 0x0028C8B0 File Offset: 0x0028AAB0
		public string EditDetailCameraIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x06009767 RID: 38759 RVA: 0x0028C8EC File Offset: 0x0028AAEC
		public int EditDetailCameraIdsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009768 RID: 38760 RVA: 0x0028C918 File Offset: 0x0028AB18
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CameraIdsIter()或GetCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CameraIds()
		{
			return this.CameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009769 RID: 38761 RVA: 0x0028C925 File Offset: 0x0028AB25
		[NullableContext(1)]
		public readonly IEnumerable<string> CameraIdsIter()
		{
			MotorDecorationsPart.<CameraIdsIter>d__34 <CameraIdsIter>d__ = new MotorDecorationsPart.<CameraIdsIter>d__34(-2);
			<CameraIdsIter>d__.<>3__<>4__this = this;
			return <CameraIdsIter>d__;
		}

		// Token: 0x0600976A RID: 38762 RVA: 0x0028C93A File Offset: 0x0028AB3A
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DetailCameraIdsIter()或GetDetailCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DetailCameraIds()
		{
			return this.DetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x0600976B RID: 38763 RVA: 0x0028C947 File Offset: 0x0028AB47
		[NullableContext(1)]
		public readonly IEnumerable<string> DetailCameraIdsIter()
		{
			MotorDecorationsPart.<DetailCameraIdsIter>d__36 <DetailCameraIdsIter>d__ = new MotorDecorationsPart.<DetailCameraIdsIter>d__36(-2);
			<DetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <DetailCameraIdsIter>d__;
		}

		// Token: 0x0600976C RID: 38764 RVA: 0x0028C95C File Offset: 0x0028AB5C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EditCameraIdsIter()或GetEditCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EditCameraIds()
		{
			return this.EditCameraIdsIter().ToArray<string>();
		}

		// Token: 0x0600976D RID: 38765 RVA: 0x0028C969 File Offset: 0x0028AB69
		[NullableContext(1)]
		public readonly IEnumerable<string> EditCameraIdsIter()
		{
			MotorDecorationsPart.<EditCameraIdsIter>d__38 <EditCameraIdsIter>d__ = new MotorDecorationsPart.<EditCameraIdsIter>d__38(-2);
			<EditCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditCameraIdsIter>d__;
		}

		// Token: 0x0600976E RID: 38766 RVA: 0x0028C97E File Offset: 0x0028AB7E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EditDetailCameraIdsIter()或GetEditDetailCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EditDetailCameraIds()
		{
			return this.EditDetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x0600976F RID: 38767 RVA: 0x0028C98B File Offset: 0x0028AB8B
		[NullableContext(1)]
		public readonly IEnumerable<string> EditDetailCameraIdsIter()
		{
			MotorDecorationsPart.<EditDetailCameraIdsIter>d__40 <EditDetailCameraIdsIter>d__ = new MotorDecorationsPart.<EditDetailCameraIdsIter>d__40(-2);
			<EditDetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditDetailCameraIdsIter>d__;
		}

		// Token: 0x06009770 RID: 38768 RVA: 0x0028C9A0 File Offset: 0x0028ABA0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HangPointsIter()或GetHangPointsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] HangPoints()
		{
			return this.HangPointsIter().ToArray<string>();
		}

		// Token: 0x06009771 RID: 38769 RVA: 0x0028C9AD File Offset: 0x0028ABAD
		[NullableContext(1)]
		public readonly IEnumerable<string> HangPointsIter()
		{
			MotorDecorationsPart.<HangPointsIter>d__42 <HangPointsIter>d__ = new MotorDecorationsPart.<HangPointsIter>d__42(-2);
			<HangPointsIter>d__.<>3__<>4__this = this;
			return <HangPointsIter>d__;
		}

		// Token: 0x04004EDB RID: 20187
		private Table __p;
	}
}
