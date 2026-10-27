using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E55 RID: 3669
	public struct MotorFramePart : IFlatbufferObject
	{
		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x06009A12 RID: 39442 RVA: 0x00292C29 File Offset: 0x00290E29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A13 RID: 39443 RVA: 0x00292C36 File Offset: 0x00290E36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A14 RID: 39444 RVA: 0x00292C40 File Offset: 0x00290E40
		public static MotorFramePart GetRootAsMotorFramePart(ByteBuffer _bb)
		{
			return MotorFramePart.GetRootAsMotorFramePart(_bb, default(MotorFramePart));
		}

		// Token: 0x06009A15 RID: 39445 RVA: 0x00292C5C File Offset: 0x00290E5C
		public static MotorFramePart GetRootAsMotorFramePart(ByteBuffer _bb, MotorFramePart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x00292C79 File Offset: 0x00290E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A17 RID: 39447 RVA: 0x00292C88 File Offset: 0x00290E88
		public MotorFramePart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x06009A18 RID: 39448 RVA: 0x00292C98 File Offset: 0x00290E98
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

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x06009A19 RID: 39449 RVA: 0x00292CD4 File Offset: 0x00290ED4
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

		// Token: 0x06009A1A RID: 39450 RVA: 0x00292D0B File Offset: 0x00290F0B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009A1B RID: 39451 RVA: 0x00292D1A File Offset: 0x00290F1A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06009A1C RID: 39452 RVA: 0x00292D34 File Offset: 0x00290F34
		public string CameraIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x06009A1D RID: 39453 RVA: 0x00292D70 File Offset: 0x00290F70
		public int CameraIdsLength
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

		// Token: 0x06009A1E RID: 39454 RVA: 0x00292D9C File Offset: 0x00290F9C
		public string DetailCameraIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x06009A1F RID: 39455 RVA: 0x00292DD8 File Offset: 0x00290FD8
		public int DetailCameraIdsLength
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

		// Token: 0x06009A20 RID: 39456 RVA: 0x00292E04 File Offset: 0x00291004
		public string EditCameraIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x06009A21 RID: 39457 RVA: 0x00292E40 File Offset: 0x00291040
		public int EditCameraIdsLength
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

		// Token: 0x06009A22 RID: 39458 RVA: 0x00292E6C File Offset: 0x0029106C
		public string EditDetailCameraIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06009A23 RID: 39459 RVA: 0x00292EA8 File Offset: 0x002910A8
		public int EditDetailCameraIdsLength
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

		// Token: 0x06009A24 RID: 39460 RVA: 0x00292ED4 File Offset: 0x002910D4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CameraIdsIter()或GetCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CameraIds()
		{
			return this.CameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009A25 RID: 39461 RVA: 0x00292EE1 File Offset: 0x002910E1
		[NullableContext(1)]
		public readonly IEnumerable<string> CameraIdsIter()
		{
			MotorFramePart.<CameraIdsIter>d__27 <CameraIdsIter>d__ = new MotorFramePart.<CameraIdsIter>d__27(-2);
			<CameraIdsIter>d__.<>3__<>4__this = this;
			return <CameraIdsIter>d__;
		}

		// Token: 0x06009A26 RID: 39462 RVA: 0x00292EF6 File Offset: 0x002910F6
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DetailCameraIdsIter()或GetDetailCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DetailCameraIds()
		{
			return this.DetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009A27 RID: 39463 RVA: 0x00292F03 File Offset: 0x00291103
		[NullableContext(1)]
		public readonly IEnumerable<string> DetailCameraIdsIter()
		{
			MotorFramePart.<DetailCameraIdsIter>d__29 <DetailCameraIdsIter>d__ = new MotorFramePart.<DetailCameraIdsIter>d__29(-2);
			<DetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <DetailCameraIdsIter>d__;
		}

		// Token: 0x06009A28 RID: 39464 RVA: 0x00292F18 File Offset: 0x00291118
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EditCameraIdsIter()或GetEditCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EditCameraIds()
		{
			return this.EditCameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009A29 RID: 39465 RVA: 0x00292F25 File Offset: 0x00291125
		[NullableContext(1)]
		public readonly IEnumerable<string> EditCameraIdsIter()
		{
			MotorFramePart.<EditCameraIdsIter>d__31 <EditCameraIdsIter>d__ = new MotorFramePart.<EditCameraIdsIter>d__31(-2);
			<EditCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditCameraIdsIter>d__;
		}

		// Token: 0x06009A2A RID: 39466 RVA: 0x00292F3A File Offset: 0x0029113A
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EditDetailCameraIdsIter()或GetEditDetailCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EditDetailCameraIds()
		{
			return this.EditDetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009A2B RID: 39467 RVA: 0x00292F47 File Offset: 0x00291147
		[NullableContext(1)]
		public readonly IEnumerable<string> EditDetailCameraIdsIter()
		{
			MotorFramePart.<EditDetailCameraIdsIter>d__33 <EditDetailCameraIdsIter>d__ = new MotorFramePart.<EditDetailCameraIdsIter>d__33(-2);
			<EditDetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditDetailCameraIdsIter>d__;
		}

		// Token: 0x04004EFE RID: 20222
		private Table __p;
	}
}
