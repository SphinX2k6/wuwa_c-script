using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCA RID: 3018
	public struct AiSenseGroup : IFlatbufferObject
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06004C27 RID: 19495 RVA: 0x001F35E1 File Offset: 0x001F17E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x001F35EE File Offset: 0x001F17EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x001F35F8 File Offset: 0x001F17F8
		public static AiSenseGroup GetRootAsAiSenseGroup(ByteBuffer _bb)
		{
			return AiSenseGroup.GetRootAsAiSenseGroup(_bb, default(AiSenseGroup));
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x001F3614 File Offset: 0x001F1814
		public static AiSenseGroup GetRootAsAiSenseGroup(ByteBuffer _bb, AiSenseGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x001F3631 File Offset: 0x001F1831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x001F3640 File Offset: 0x001F1840
		public AiSenseGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06004C2D RID: 19501 RVA: 0x001F3650 File Offset: 0x001F1850
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

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06004C2E RID: 19502 RVA: 0x001F368C File Offset: 0x001F188C
		public FloatRange? LoseDelay
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x001F36EC File Offset: 0x001F18EC
		public int AiSenseIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06004C30 RID: 19504 RVA: 0x001F372C File Offset: 0x001F192C
		public int AiSenseIdsLength
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

		// Token: 0x06004C31 RID: 19505 RVA: 0x001F3757 File Offset: 0x001F1957
		public Span<int> GetAiSenseIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x001F3766 File Offset: 0x001F1966
		public int[] GetAiSenseIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06004C33 RID: 19507 RVA: 0x001F3780 File Offset: 0x001F1980
		public float ShareDis
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x001F37C1 File Offset: 0x001F19C1
		[NullableContext(1)]
		public int[] AiSenseIds()
		{
			return this.GetAiSenseIdsArray();
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x001F37C9 File Offset: 0x001F19C9
		[NullableContext(1)]
		public IEnumerable<int> AiSenseIdsIter()
		{
			AiSenseGroup.<AiSenseIdsIter>d__20 <AiSenseIdsIter>d__ = new AiSenseGroup.<AiSenseIdsIter>d__20(-2);
			<AiSenseIdsIter>d__.<>3__<>4__this = this;
			return <AiSenseIdsIter>d__;
		}

		// Token: 0x040050AB RID: 20651
		private Table __p;
	}
}
