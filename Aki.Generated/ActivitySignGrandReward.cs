using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA6 RID: 2982
	public struct ActivitySignGrandReward : IFlatbufferObject
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06004925 RID: 18725 RVA: 0x001ECFC0 File Offset: 0x001EB1C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x001ECFCD File Offset: 0x001EB1CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x001ECFD4 File Offset: 0x001EB1D4
		public static ActivitySignGrandReward GetRootAsActivitySignGrandReward(ByteBuffer _bb)
		{
			return ActivitySignGrandReward.GetRootAsActivitySignGrandReward(_bb, default(ActivitySignGrandReward));
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x001ECFF0 File Offset: 0x001EB1F0
		public static ActivitySignGrandReward GetRootAsActivitySignGrandReward(ByteBuffer _bb, ActivitySignGrandReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x001ED00D File Offset: 0x001EB20D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x001ED01C File Offset: 0x001EB21C
		public ActivitySignGrandReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600492B RID: 18731 RVA: 0x001ED02C File Offset: 0x001EB22C
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

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600492C RID: 18732 RVA: 0x001ED068 File Offset: 0x001EB268
		public int GrandRewardIndex
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600492D RID: 18733 RVA: 0x001ED0A4 File Offset: 0x001EB2A4
		public string GrandSourcePath
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

		// Token: 0x0600492E RID: 18734 RVA: 0x001ED0DB File Offset: 0x001EB2DB
		public Span<byte> GetGrandSourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x001ED0EA File Offset: 0x001EB2EA
		public byte[] GetGrandSourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06004930 RID: 18736 RVA: 0x001ED104 File Offset: 0x001EB304
		public int PreviewType
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

		// Token: 0x06004931 RID: 18737 RVA: 0x001ED144 File Offset: 0x001EB344
		public int PreviewList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06004932 RID: 18738 RVA: 0x001ED184 File Offset: 0x001EB384
		public int PreviewListLength
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

		// Token: 0x06004933 RID: 18739 RVA: 0x001ED1B0 File Offset: 0x001EB3B0
		public Span<int> GetPreviewListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x001ED1C0 File Offset: 0x001EB3C0
		public int[] GetPreviewListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06004935 RID: 18741 RVA: 0x001ED1D8 File Offset: 0x001EB3D8
		public string GrandTitle
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x001ED210 File Offset: 0x001EB410
		public Span<byte> GetGrandTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x001ED220 File Offset: 0x001EB420
		public byte[] GetGrandTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06004938 RID: 18744 RVA: 0x001ED238 File Offset: 0x001EB438
		public string GrandDesc
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

		// Token: 0x06004939 RID: 18745 RVA: 0x001ED270 File Offset: 0x001EB470
		public Span<byte> GetGrandDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x001ED280 File Offset: 0x001EB480
		public byte[] GetGrandDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x001ED298 File Offset: 0x001EB498
		[NullableContext(1)]
		public int[] PreviewList()
		{
			return this.GetPreviewListArray();
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x001ED2A0 File Offset: 0x001EB4A0
		[NullableContext(1)]
		public IEnumerable<int> PreviewListIter()
		{
			ActivitySignGrandReward.<PreviewListIter>d__32 <PreviewListIter>d__ = new ActivitySignGrandReward.<PreviewListIter>d__32(-2);
			<PreviewListIter>d__.<>3__<>4__this = this;
			return <PreviewListIter>d__;
		}

		// Token: 0x04005083 RID: 20611
		private Table __p;
	}
}
