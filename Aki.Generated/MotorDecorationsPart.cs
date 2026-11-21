using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1A RID: 3866
	public struct MotorDecorationsPart : IFlatbufferObject
	{
		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x06009D71 RID: 40305 RVA: 0x002AA226 File Offset: 0x002A8426
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D72 RID: 40306 RVA: 0x002AA233 File Offset: 0x002A8433
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D73 RID: 40307 RVA: 0x002AA23C File Offset: 0x002A843C
		public static MotorDecorationsPart GetRootAsMotorDecorationsPart(ByteBuffer _bb)
		{
			return MotorDecorationsPart.GetRootAsMotorDecorationsPart(_bb, default(MotorDecorationsPart));
		}

		// Token: 0x06009D74 RID: 40308 RVA: 0x002AA258 File Offset: 0x002A8458
		public static MotorDecorationsPart GetRootAsMotorDecorationsPart(ByteBuffer _bb, MotorDecorationsPart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D75 RID: 40309 RVA: 0x002AA275 File Offset: 0x002A8475
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D76 RID: 40310 RVA: 0x002AA284 File Offset: 0x002A8484
		public MotorDecorationsPart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x06009D77 RID: 40311 RVA: 0x002AA294 File Offset: 0x002A8494
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

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x06009D78 RID: 40312 RVA: 0x002AA2D0 File Offset: 0x002A84D0
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

		// Token: 0x06009D79 RID: 40313 RVA: 0x002AA307 File Offset: 0x002A8507
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009D7A RID: 40314 RVA: 0x002AA316 File Offset: 0x002A8516
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x06009D7B RID: 40315 RVA: 0x002AA330 File Offset: 0x002A8530
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

		// Token: 0x06009D7C RID: 40316 RVA: 0x002AA367 File Offset: 0x002A8567
		public Span<byte> GetIconSelectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009D7D RID: 40317 RVA: 0x002AA376 File Offset: 0x002A8576
		public byte[] GetIconSelectArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06009D7E RID: 40318 RVA: 0x002AA390 File Offset: 0x002A8590
		public string CameraIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06009D7F RID: 40319 RVA: 0x002AA3CC File Offset: 0x002A85CC
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

		// Token: 0x06009D80 RID: 40320 RVA: 0x002AA3F8 File Offset: 0x002A85F8
		public string DetailCameraIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06009D81 RID: 40321 RVA: 0x002AA434 File Offset: 0x002A8634
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

		// Token: 0x06009D82 RID: 40322 RVA: 0x002AA460 File Offset: 0x002A8660
		public string HangPoints(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06009D83 RID: 40323 RVA: 0x002AA49C File Offset: 0x002A869C
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

		// Token: 0x06009D84 RID: 40324 RVA: 0x002AA4C8 File Offset: 0x002A86C8
		public string EditCameraIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06009D85 RID: 40325 RVA: 0x002AA504 File Offset: 0x002A8704
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

		// Token: 0x06009D86 RID: 40326 RVA: 0x002AA530 File Offset: 0x002A8730
		public string EditDetailCameraIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06009D87 RID: 40327 RVA: 0x002AA56C File Offset: 0x002A876C
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

		// Token: 0x06009D88 RID: 40328 RVA: 0x002AA598 File Offset: 0x002A8798
		[NullableContext(1)]
		public string[] CameraIds()
		{
			return this.CameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009D89 RID: 40329 RVA: 0x002AA5A5 File Offset: 0x002A87A5
		[NullableContext(1)]
		public IEnumerable<string> CameraIdsIter()
		{
			MotorDecorationsPart.<CameraIdsIter>d__34 <CameraIdsIter>d__ = new MotorDecorationsPart.<CameraIdsIter>d__34(-2);
			<CameraIdsIter>d__.<>3__<>4__this = this;
			return <CameraIdsIter>d__;
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x002AA5BA File Offset: 0x002A87BA
		[NullableContext(1)]
		public string[] DetailCameraIds()
		{
			return this.DetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x002AA5C7 File Offset: 0x002A87C7
		[NullableContext(1)]
		public IEnumerable<string> DetailCameraIdsIter()
		{
			MotorDecorationsPart.<DetailCameraIdsIter>d__36 <DetailCameraIdsIter>d__ = new MotorDecorationsPart.<DetailCameraIdsIter>d__36(-2);
			<DetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <DetailCameraIdsIter>d__;
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x002AA5DC File Offset: 0x002A87DC
		[NullableContext(1)]
		public string[] EditCameraIds()
		{
			return this.EditCameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009D8D RID: 40333 RVA: 0x002AA5E9 File Offset: 0x002A87E9
		[NullableContext(1)]
		public IEnumerable<string> EditCameraIdsIter()
		{
			MotorDecorationsPart.<EditCameraIdsIter>d__38 <EditCameraIdsIter>d__ = new MotorDecorationsPart.<EditCameraIdsIter>d__38(-2);
			<EditCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditCameraIdsIter>d__;
		}

		// Token: 0x06009D8E RID: 40334 RVA: 0x002AA5FE File Offset: 0x002A87FE
		[NullableContext(1)]
		public string[] EditDetailCameraIds()
		{
			return this.EditDetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009D8F RID: 40335 RVA: 0x002AA60B File Offset: 0x002A880B
		[NullableContext(1)]
		public IEnumerable<string> EditDetailCameraIdsIter()
		{
			MotorDecorationsPart.<EditDetailCameraIdsIter>d__40 <EditDetailCameraIdsIter>d__ = new MotorDecorationsPart.<EditDetailCameraIdsIter>d__40(-2);
			<EditDetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditDetailCameraIdsIter>d__;
		}

		// Token: 0x06009D90 RID: 40336 RVA: 0x002AA620 File Offset: 0x002A8820
		[NullableContext(1)]
		public string[] HangPoints()
		{
			return this.HangPointsIter().ToArray<string>();
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x002AA62D File Offset: 0x002A882D
		[NullableContext(1)]
		public IEnumerable<string> HangPointsIter()
		{
			MotorDecorationsPart.<HangPointsIter>d__42 <HangPointsIter>d__ = new MotorDecorationsPart.<HangPointsIter>d__42(-2);
			<HangPointsIter>d__.<>3__<>4__this = this;
			return <HangPointsIter>d__;
		}

		// Token: 0x040054C0 RID: 21696
		private Table __p;
	}
}
