using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC5 RID: 3013
	public struct AiBehaviorTree : IFlatbufferObject
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06004BCF RID: 19407 RVA: 0x001F2629 File Offset: 0x001F0829
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x001F2636 File Offset: 0x001F0836
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x001F2640 File Offset: 0x001F0840
		public static AiBehaviorTree GetRootAsAiBehaviorTree(ByteBuffer _bb)
		{
			return AiBehaviorTree.GetRootAsAiBehaviorTree(_bb, default(AiBehaviorTree));
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x001F265C File Offset: 0x001F085C
		public static AiBehaviorTree GetRootAsAiBehaviorTree(ByteBuffer _bb, AiBehaviorTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x001F2679 File Offset: 0x001F0879
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x001F2688 File Offset: 0x001F0888
		public AiBehaviorTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x001F2698 File Offset: 0x001F0898
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

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x001F26D4 File Offset: 0x001F08D4
		public string Description
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

		// Token: 0x06004BD7 RID: 19415 RVA: 0x001F270B File Offset: 0x001F090B
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x001F271A File Offset: 0x001F091A
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06004BD9 RID: 19417 RVA: 0x001F2734 File Offset: 0x001F0934
		public string BtPath
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

		// Token: 0x06004BDA RID: 19418 RVA: 0x001F276B File Offset: 0x001F096B
		public Span<byte> GetBtPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x001F277A File Offset: 0x001F097A
		public byte[] GetBtPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06004BDC RID: 19420 RVA: 0x001F2794 File Offset: 0x001F0994
		public string BtType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x001F27CC File Offset: 0x001F09CC
		public Span<byte> GetBtTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x001F27DC File Offset: 0x001F09DC
		public byte[] GetBtTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040050A6 RID: 20646
		private Table __p;
	}
}
