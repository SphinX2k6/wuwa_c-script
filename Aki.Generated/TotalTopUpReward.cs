using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001266 RID: 4710
	public struct TotalTopUpReward : IFlatbufferObject
	{
		// Token: 0x17003DE4 RID: 15844
		// (get) Token: 0x0600EC7A RID: 60538 RVA: 0x00359B36 File Offset: 0x00357D36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EC7B RID: 60539 RVA: 0x00359B43 File Offset: 0x00357D43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EC7C RID: 60540 RVA: 0x00359B4C File Offset: 0x00357D4C
		public static TotalTopUpReward GetRootAsTotalTopUpReward(ByteBuffer _bb)
		{
			return TotalTopUpReward.GetRootAsTotalTopUpReward(_bb, default(TotalTopUpReward));
		}

		// Token: 0x0600EC7D RID: 60541 RVA: 0x00359B68 File Offset: 0x00357D68
		public static TotalTopUpReward GetRootAsTotalTopUpReward(ByteBuffer _bb, TotalTopUpReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EC7E RID: 60542 RVA: 0x00359B85 File Offset: 0x00357D85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EC7F RID: 60543 RVA: 0x00359B94 File Offset: 0x00357D94
		public TotalTopUpReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DE5 RID: 15845
		// (get) Token: 0x0600EC80 RID: 60544 RVA: 0x00359BA4 File Offset: 0x00357DA4
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

		// Token: 0x17003DE6 RID: 15846
		// (get) Token: 0x0600EC81 RID: 60545 RVA: 0x00359BE0 File Offset: 0x00357DE0
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

		// Token: 0x17003DE7 RID: 15847
		// (get) Token: 0x0600EC82 RID: 60546 RVA: 0x00359C1C File Offset: 0x00357E1C
		public int PreviewFunction
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

		// Token: 0x17003DE8 RID: 15848
		// (get) Token: 0x0600EC83 RID: 60547 RVA: 0x00359C58 File Offset: 0x00357E58
		public bool ShowPreviewIcon
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003DE9 RID: 15849
		// (get) Token: 0x0600EC84 RID: 60548 RVA: 0x00359C98 File Offset: 0x00357E98
		public int ShowRewardCount
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

		// Token: 0x0600EC85 RID: 60549 RVA: 0x00359CD8 File Offset: 0x00357ED8
		public int PreviewButtonRegistry(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DEA RID: 15850
		// (get) Token: 0x0600EC86 RID: 60550 RVA: 0x00359D18 File Offset: 0x00357F18
		public int PreviewButtonRegistryLength
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

		// Token: 0x0600EC87 RID: 60551 RVA: 0x00359D44 File Offset: 0x00357F44
		public Span<int> GetPreviewButtonRegistryBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600EC88 RID: 60552 RVA: 0x00359D54 File Offset: 0x00357F54
		public int[] GetPreviewButtonRegistryArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x0600EC89 RID: 60553 RVA: 0x00359D6C File Offset: 0x00357F6C
		public int MotorPreviewId
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

		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x0600EC8A RID: 60554 RVA: 0x00359DAC File Offset: 0x00357FAC
		public string PreviewContentId
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

		// Token: 0x0600EC8B RID: 60555 RVA: 0x00359DE4 File Offset: 0x00357FE4
		public Span<byte> GetPreviewContentIdBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600EC8C RID: 60556 RVA: 0x00359DF4 File Offset: 0x00357FF4
		public byte[] GetPreviewContentIdArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x0600EC8D RID: 60557 RVA: 0x00359E0C File Offset: 0x0035800C
		public int ClaimFunction
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

		// Token: 0x0600EC8E RID: 60558 RVA: 0x00359E49 File Offset: 0x00358049
		[NullableContext(1)]
		public int[] PreviewButtonRegistry()
		{
			return this.GetPreviewButtonRegistryArray();
		}

		// Token: 0x0600EC8F RID: 60559 RVA: 0x00359E51 File Offset: 0x00358051
		[NullableContext(1)]
		public IEnumerable<int> PreviewButtonRegistryIter()
		{
			TotalTopUpReward.<PreviewButtonRegistryIter>d__32 <PreviewButtonRegistryIter>d__ = new TotalTopUpReward.<PreviewButtonRegistryIter>d__32(-2);
			<PreviewButtonRegistryIter>d__.<>3__<>4__this = this;
			return <PreviewButtonRegistryIter>d__;
		}

		// Token: 0x040058B4 RID: 22708
		private Table __p;
	}
}
