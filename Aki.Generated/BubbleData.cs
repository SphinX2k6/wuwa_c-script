using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B52 RID: 2898
	public struct BubbleData : IFlatbufferObject
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06005006 RID: 20486 RVA: 0x001E99D6 File Offset: 0x001E7BD6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x001E99E3 File Offset: 0x001E7BE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x001E99EC File Offset: 0x001E7BEC
		public static BubbleData GetRootAsBubbleData(ByteBuffer _bb)
		{
			return BubbleData.GetRootAsBubbleData(_bb, default(BubbleData));
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x001E9A08 File Offset: 0x001E7C08
		public static BubbleData GetRootAsBubbleData(ByteBuffer _bb, BubbleData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x001E9A25 File Offset: 0x001E7C25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x001E9A34 File Offset: 0x001E7C34
		public BubbleData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600500C RID: 20492 RVA: 0x001E9A44 File Offset: 0x001E7C44
		public string ActionGuid
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x001E9A7B File Offset: 0x001E7C7B
		public Span<byte> GetActionGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x001E9A8A File Offset: 0x001E7C8A
		public byte[] GetActionGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600500F RID: 20495 RVA: 0x001E9AA4 File Offset: 0x001E7CA4
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

		// Token: 0x06005010 RID: 20496 RVA: 0x001E9ADB File Offset: 0x001E7CDB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x001E9AEA File Offset: 0x001E7CEA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06005012 RID: 20498 RVA: 0x001E9B04 File Offset: 0x001E7D04
		public bool Async
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06005013 RID: 20499 RVA: 0x001E9B44 File Offset: 0x001E7D44
		public string Params
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

		// Token: 0x06005014 RID: 20500 RVA: 0x001E9B7C File Offset: 0x001E7D7C
		public Span<byte> GetParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x001E9B8C File Offset: 0x001E7D8C
		public byte[] GetParamsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06005016 RID: 20502 RVA: 0x001E9BA4 File Offset: 0x001E7DA4
		public int ActionId
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

		// Token: 0x04004B4F RID: 19279
		private Table __p;
	}
}
