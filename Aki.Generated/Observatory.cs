using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F83 RID: 3971
	public struct Observatory : IFlatbufferObject
	{
		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x0600A722 RID: 42786 RVA: 0x002BF31A File Offset: 0x002BD51A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A723 RID: 42787 RVA: 0x002BF327 File Offset: 0x002BD527
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A724 RID: 42788 RVA: 0x002BF330 File Offset: 0x002BD530
		public static Observatory GetRootAsObservatory(ByteBuffer _bb)
		{
			return Observatory.GetRootAsObservatory(_bb, default(Observatory));
		}

		// Token: 0x0600A725 RID: 42789 RVA: 0x002BF34C File Offset: 0x002BD54C
		public static Observatory GetRootAsObservatory(ByteBuffer _bb, Observatory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A726 RID: 42790 RVA: 0x002BF369 File Offset: 0x002BD569
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A727 RID: 42791 RVA: 0x002BF378 File Offset: 0x002BD578
		public Observatory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x0600A728 RID: 42792 RVA: 0x002BF388 File Offset: 0x002BD588
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

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x0600A729 RID: 42793 RVA: 0x002BF3C4 File Offset: 0x002BD5C4
		public int AreaId
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

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x0600A72A RID: 42794 RVA: 0x002BF400 File Offset: 0x002BD600
		public string FlowListName
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

		// Token: 0x0600A72B RID: 42795 RVA: 0x002BF437 File Offset: 0x002BD637
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A72C RID: 42796 RVA: 0x002BF446 File Offset: 0x002BD646
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x0600A72D RID: 42797 RVA: 0x002BF460 File Offset: 0x002BD660
		public int FlowId
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

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x0600A72E RID: 42798 RVA: 0x002BF4A0 File Offset: 0x002BD6A0
		public int StateId
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

		// Token: 0x04005537 RID: 21815
		private Table __p;
	}
}
