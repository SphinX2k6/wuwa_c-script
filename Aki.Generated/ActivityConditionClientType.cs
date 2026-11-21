using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9A RID: 2970
	public struct ActivityConditionClientType : IFlatbufferObject
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x001EB544 File Offset: 0x001E9744
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x001EB551 File Offset: 0x001E9751
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x001EB558 File Offset: 0x001E9758
		public static ActivityConditionClientType GetRootAsActivityConditionClientType(ByteBuffer _bb)
		{
			return ActivityConditionClientType.GetRootAsActivityConditionClientType(_bb, default(ActivityConditionClientType));
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x001EB574 File Offset: 0x001E9774
		public static ActivityConditionClientType GetRootAsActivityConditionClientType(ByteBuffer _bb, ActivityConditionClientType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x001EB591 File Offset: 0x001E9791
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x001EB5A0 File Offset: 0x001E97A0
		public ActivityConditionClientType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06004864 RID: 18532 RVA: 0x001EB5B0 File Offset: 0x001E97B0
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

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x001EB5EC File Offset: 0x001E97EC
		public string TypeName
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

		// Token: 0x06004866 RID: 18534 RVA: 0x001EB623 File Offset: 0x001E9823
		public Span<byte> GetTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x001EB632 File Offset: 0x001E9832
		public byte[] GetTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005076 RID: 20598
		private Table __p;
	}
}
