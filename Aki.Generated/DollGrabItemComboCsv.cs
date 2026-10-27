using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF5 RID: 3061
	public struct DollGrabItemComboCsv : IFlatbufferObject
	{
		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x0600629A RID: 25242 RVA: 0x002142E4 File Offset: 0x002124E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x002142F1 File Offset: 0x002124F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x002142F8 File Offset: 0x002124F8
		public static DollGrabItemComboCsv GetRootAsDollGrabItemComboCsv(ByteBuffer _bb)
		{
			return DollGrabItemComboCsv.GetRootAsDollGrabItemComboCsv(_bb, default(DollGrabItemComboCsv));
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x00214314 File Offset: 0x00212514
		public static DollGrabItemComboCsv GetRootAsDollGrabItemComboCsv(ByteBuffer _bb, DollGrabItemComboCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600629E RID: 25246 RVA: 0x00214331 File Offset: 0x00212531
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600629F RID: 25247 RVA: 0x00214340 File Offset: 0x00212540
		public DollGrabItemComboCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060062A0 RID: 25248 RVA: 0x00214350 File Offset: 0x00212550
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

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060062A1 RID: 25249 RVA: 0x0021438C File Offset: 0x0021258C
		public string Name
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

		// Token: 0x060062A2 RID: 25250 RVA: 0x002143C3 File Offset: 0x002125C3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060062A3 RID: 25251 RVA: 0x002143D2 File Offset: 0x002125D2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060062A4 RID: 25252 RVA: 0x002143EC File Offset: 0x002125EC
		public int MainItemId
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

		// Token: 0x060062A5 RID: 25253 RVA: 0x00214428 File Offset: 0x00212628
		public int PartItemIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060062A6 RID: 25254 RVA: 0x00214468 File Offset: 0x00212668
		public int PartItemIdsLength
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

		// Token: 0x060062A7 RID: 25255 RVA: 0x00214494 File Offset: 0x00212694
		public Span<int> GetPartItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x002144A4 File Offset: 0x002126A4
		public int[] GetPartItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060062A9 RID: 25257 RVA: 0x002144BC File Offset: 0x002126BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PartItemIdsIter()或GetPartItemIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PartItemIds()
		{
			DollGrabItemComboCsv dollGrabItemComboCsv = this;
			return dollGrabItemComboCsv.GetPartItemIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x002144E0 File Offset: 0x002126E0
		[NullableContext(1)]
		public readonly IEnumerable<int> PartItemIdsIter()
		{
			DollGrabItemComboCsv.<PartItemIdsIter>d__22 <PartItemIdsIter>d__ = new DollGrabItemComboCsv.<PartItemIdsIter>d__22(-2);
			<PartItemIdsIter>d__.<>3__<>4__this = this;
			return <PartItemIdsIter>d__;
		}

		// Token: 0x04004C22 RID: 19490
		private Table __p;
	}
}
