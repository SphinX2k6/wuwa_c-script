using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3A RID: 3898
	public struct MotorFramePart : IFlatbufferObject
	{
		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x0600A032 RID: 41010 RVA: 0x002B06A6 File Offset: 0x002AE8A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x002B06B3 File Offset: 0x002AE8B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A034 RID: 41012 RVA: 0x002B06BC File Offset: 0x002AE8BC
		public static MotorFramePart GetRootAsMotorFramePart(ByteBuffer _bb)
		{
			return MotorFramePart.GetRootAsMotorFramePart(_bb, default(MotorFramePart));
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x002B06D8 File Offset: 0x002AE8D8
		public static MotorFramePart GetRootAsMotorFramePart(ByteBuffer _bb, MotorFramePart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x002B06F5 File Offset: 0x002AE8F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A037 RID: 41015 RVA: 0x002B0704 File Offset: 0x002AE904
		public MotorFramePart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x0600A038 RID: 41016 RVA: 0x002B0714 File Offset: 0x002AE914
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

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x0600A039 RID: 41017 RVA: 0x002B0750 File Offset: 0x002AE950
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

		// Token: 0x0600A03A RID: 41018 RVA: 0x002B0787 File Offset: 0x002AE987
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x002B0796 File Offset: 0x002AE996
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x002B07B0 File Offset: 0x002AE9B0
		public string CameraIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x0600A03D RID: 41021 RVA: 0x002B07EC File Offset: 0x002AE9EC
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

		// Token: 0x0600A03E RID: 41022 RVA: 0x002B0818 File Offset: 0x002AEA18
		public string DetailCameraIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x0600A03F RID: 41023 RVA: 0x002B0854 File Offset: 0x002AEA54
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

		// Token: 0x0600A040 RID: 41024 RVA: 0x002B0880 File Offset: 0x002AEA80
		public string EditCameraIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x0600A041 RID: 41025 RVA: 0x002B08BC File Offset: 0x002AEABC
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

		// Token: 0x0600A042 RID: 41026 RVA: 0x002B08E8 File Offset: 0x002AEAE8
		public string EditDetailCameraIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x0600A043 RID: 41027 RVA: 0x002B0924 File Offset: 0x002AEB24
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

		// Token: 0x0600A044 RID: 41028 RVA: 0x002B0950 File Offset: 0x002AEB50
		[NullableContext(1)]
		public string[] CameraIds()
		{
			return this.CameraIdsIter().ToArray<string>();
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x002B095D File Offset: 0x002AEB5D
		[NullableContext(1)]
		public IEnumerable<string> CameraIdsIter()
		{
			MotorFramePart.<CameraIdsIter>d__27 <CameraIdsIter>d__ = new MotorFramePart.<CameraIdsIter>d__27(-2);
			<CameraIdsIter>d__.<>3__<>4__this = this;
			return <CameraIdsIter>d__;
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x002B0972 File Offset: 0x002AEB72
		[NullableContext(1)]
		public string[] DetailCameraIds()
		{
			return this.DetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x0600A047 RID: 41031 RVA: 0x002B097F File Offset: 0x002AEB7F
		[NullableContext(1)]
		public IEnumerable<string> DetailCameraIdsIter()
		{
			MotorFramePart.<DetailCameraIdsIter>d__29 <DetailCameraIdsIter>d__ = new MotorFramePart.<DetailCameraIdsIter>d__29(-2);
			<DetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <DetailCameraIdsIter>d__;
		}

		// Token: 0x0600A048 RID: 41032 RVA: 0x002B0994 File Offset: 0x002AEB94
		[NullableContext(1)]
		public string[] EditCameraIds()
		{
			return this.EditCameraIdsIter().ToArray<string>();
		}

		// Token: 0x0600A049 RID: 41033 RVA: 0x002B09A1 File Offset: 0x002AEBA1
		[NullableContext(1)]
		public IEnumerable<string> EditCameraIdsIter()
		{
			MotorFramePart.<EditCameraIdsIter>d__31 <EditCameraIdsIter>d__ = new MotorFramePart.<EditCameraIdsIter>d__31(-2);
			<EditCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditCameraIdsIter>d__;
		}

		// Token: 0x0600A04A RID: 41034 RVA: 0x002B09B6 File Offset: 0x002AEBB6
		[NullableContext(1)]
		public string[] EditDetailCameraIds()
		{
			return this.EditDetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x0600A04B RID: 41035 RVA: 0x002B09C3 File Offset: 0x002AEBC3
		[NullableContext(1)]
		public IEnumerable<string> EditDetailCameraIdsIter()
		{
			MotorFramePart.<EditDetailCameraIdsIter>d__33 <EditDetailCameraIdsIter>d__ = new MotorFramePart.<EditDetailCameraIdsIter>d__33(-2);
			<EditDetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditDetailCameraIdsIter>d__;
		}

		// Token: 0x040054E3 RID: 21731
		private Table __p;
	}
}
