using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA7 RID: 2983
	public struct ActivitySplitPak : IFlatbufferObject
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600493D RID: 18749 RVA: 0x001ED2B5 File Offset: 0x001EB4B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x001ED2C2 File Offset: 0x001EB4C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x001ED2CC File Offset: 0x001EB4CC
		public static ActivitySplitPak GetRootAsActivitySplitPak(ByteBuffer _bb)
		{
			return ActivitySplitPak.GetRootAsActivitySplitPak(_bb, default(ActivitySplitPak));
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x001ED2E8 File Offset: 0x001EB4E8
		public static ActivitySplitPak GetRootAsActivitySplitPak(ByteBuffer _bb, ActivitySplitPak obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x001ED305 File Offset: 0x001EB505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x001ED314 File Offset: 0x001EB514
		public ActivitySplitPak __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06004943 RID: 18755 RVA: 0x001ED324 File Offset: 0x001EB524
		public int ActivityType
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

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06004944 RID: 18756 RVA: 0x001ED360 File Offset: 0x001EB560
		public string ActivityTypeString
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

		// Token: 0x06004945 RID: 18757 RVA: 0x001ED397 File Offset: 0x001EB597
		public Span<byte> GetActivityTypeStringBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x001ED3A6 File Offset: 0x001EB5A6
		public byte[] GetActivityTypeStringArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x001ED3C0 File Offset: 0x001EB5C0
		public string DependentDbList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06004948 RID: 18760 RVA: 0x001ED3FC File Offset: 0x001EB5FC
		public int DependentDbListLength
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

		// Token: 0x06004949 RID: 18761 RVA: 0x001ED427 File Offset: 0x001EB627
		[NullableContext(1)]
		public string[] DependentDbList()
		{
			return this.DependentDbListIter().ToArray<string>();
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x001ED434 File Offset: 0x001EB634
		[NullableContext(1)]
		public IEnumerable<string> DependentDbListIter()
		{
			ActivitySplitPak.<DependentDbListIter>d__18 <DependentDbListIter>d__ = new ActivitySplitPak.<DependentDbListIter>d__18(-2);
			<DependentDbListIter>d__.<>3__<>4__this = this;
			return <DependentDbListIter>d__;
		}

		// Token: 0x04005084 RID: 20612
		private Table __p;
	}
}
