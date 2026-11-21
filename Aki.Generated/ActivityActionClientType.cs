using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B98 RID: 2968
	public struct ActivityActionClientType : IFlatbufferObject
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06004840 RID: 18496 RVA: 0x001EB0E8 File Offset: 0x001E92E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x001EB0F5 File Offset: 0x001E92F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x001EB0FC File Offset: 0x001E92FC
		public static ActivityActionClientType GetRootAsActivityActionClientType(ByteBuffer _bb)
		{
			return ActivityActionClientType.GetRootAsActivityActionClientType(_bb, default(ActivityActionClientType));
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x001EB118 File Offset: 0x001E9318
		public static ActivityActionClientType GetRootAsActivityActionClientType(ByteBuffer _bb, ActivityActionClientType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x001EB135 File Offset: 0x001E9335
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x001EB144 File Offset: 0x001E9344
		public ActivityActionClientType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06004846 RID: 18502 RVA: 0x001EB154 File Offset: 0x001E9354
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06004847 RID: 18503 RVA: 0x001EB190 File Offset: 0x001E9390
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

		// Token: 0x06004848 RID: 18504 RVA: 0x001EB1C7 File Offset: 0x001E93C7
		public Span<byte> GetTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x001EB1D6 File Offset: 0x001E93D6
		public byte[] GetTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600484A RID: 18506 RVA: 0x001EB1F0 File Offset: 0x001E93F0
		public int Category
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x001EB22C File Offset: 0x001E942C
		public bool StopUltraFastForward
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005073 RID: 20595
		private Table __p;
	}
}
