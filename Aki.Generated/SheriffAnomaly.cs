using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109C RID: 4252
	public struct SheriffAnomaly : IFlatbufferObject
	{
		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x0600D098 RID: 53400 RVA: 0x0030C220 File Offset: 0x0030A420
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D099 RID: 53401 RVA: 0x0030C22D File Offset: 0x0030A42D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D09A RID: 53402 RVA: 0x0030C234 File Offset: 0x0030A434
		public static SheriffAnomaly GetRootAsSheriffAnomaly(ByteBuffer _bb)
		{
			return SheriffAnomaly.GetRootAsSheriffAnomaly(_bb, default(SheriffAnomaly));
		}

		// Token: 0x0600D09B RID: 53403 RVA: 0x0030C250 File Offset: 0x0030A450
		public static SheriffAnomaly GetRootAsSheriffAnomaly(ByteBuffer _bb, SheriffAnomaly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D09C RID: 53404 RVA: 0x0030C26D File Offset: 0x0030A46D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D09D RID: 53405 RVA: 0x0030C27C File Offset: 0x0030A47C
		public SheriffAnomaly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x0600D09E RID: 53406 RVA: 0x0030C28C File Offset: 0x0030A48C
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

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x0600D09F RID: 53407 RVA: 0x0030C2C8 File Offset: 0x0030A4C8
		public int QuestionId
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

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x0600D0A0 RID: 53408 RVA: 0x0030C304 File Offset: 0x0030A504
		public int MarkId
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

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x0600D0A1 RID: 53409 RVA: 0x0030C340 File Offset: 0x0030A540
		public int CriminalId
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

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x0600D0A2 RID: 53410 RVA: 0x0030C380 File Offset: 0x0030A580
		public int Type
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

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x0600D0A3 RID: 53411 RVA: 0x0030C3C0 File Offset: 0x0030A5C0
		public int UnlockConditionGroupId
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

		// Token: 0x0600D0A4 RID: 53412 RVA: 0x0030C400 File Offset: 0x0030A600
		public int UnlockMarkIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x0600D0A5 RID: 53413 RVA: 0x0030C440 File Offset: 0x0030A640
		public int UnlockMarkIdsLength
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

		// Token: 0x0600D0A6 RID: 53414 RVA: 0x0030C46C File Offset: 0x0030A66C
		public Span<int> GetUnlockMarkIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600D0A7 RID: 53415 RVA: 0x0030C47C File Offset: 0x0030A67C
		public int[] GetUnlockMarkIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x0600D0A8 RID: 53416 RVA: 0x0030C494 File Offset: 0x0030A694
		public string Name
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

		// Token: 0x0600D0A9 RID: 53417 RVA: 0x0030C4CC File Offset: 0x0030A6CC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D0AA RID: 53418 RVA: 0x0030C4DC File Offset: 0x0030A6DC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x0600D0AB RID: 53419 RVA: 0x0030C4F4 File Offset: 0x0030A6F4
		public int SheriffZoneId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x0600D0AC RID: 53420 RVA: 0x0030C534 File Offset: 0x0030A734
		public int MainBTId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x0600D0AD RID: 53421 RVA: 0x0030C574 File Offset: 0x0030A774
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x0600D0AE RID: 53422 RVA: 0x0030C5B4 File Offset: 0x0030A7B4
		public int ClueLessCount
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x0600D0AF RID: 53423 RVA: 0x0030C5F4 File Offset: 0x0030A7F4
		public string BTParamName
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

		// Token: 0x0600D0B0 RID: 53424 RVA: 0x0030C62C File Offset: 0x0030A82C
		public Span<byte> GetBTParamNameBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600D0B1 RID: 53425 RVA: 0x0030C63C File Offset: 0x0030A83C
		public byte[] GetBTParamNameArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x0600D0B2 RID: 53426 RVA: 0x0030C654 File Offset: 0x0030A854
		public int TextVisibleScale
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0B3 RID: 53427 RVA: 0x0030C694 File Offset: 0x0030A894
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockMarkIdsIter()或GetUnlockMarkIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnlockMarkIds()
		{
			SheriffAnomaly sheriffAnomaly = this;
			return sheriffAnomaly.GetUnlockMarkIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D0B4 RID: 53428 RVA: 0x0030C6B8 File Offset: 0x0030A8B8
		[NullableContext(1)]
		public readonly IEnumerable<int> UnlockMarkIdsIter()
		{
			SheriffAnomaly.<UnlockMarkIdsIter>d__44 <UnlockMarkIdsIter>d__ = new SheriffAnomaly.<UnlockMarkIdsIter>d__44(-2);
			<UnlockMarkIdsIter>d__.<>3__<>4__this = this;
			return <UnlockMarkIdsIter>d__;
		}

		// Token: 0x040051AA RID: 20906
		private Table __p;
	}
}
