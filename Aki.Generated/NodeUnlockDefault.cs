using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7D RID: 3965
	public struct NodeUnlockDefault : IFlatbufferObject
	{
		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x0600A6AB RID: 42667 RVA: 0x002BE4AC File Offset: 0x002BC6AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6AC RID: 42668 RVA: 0x002BE4B9 File Offset: 0x002BC6B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A6AD RID: 42669 RVA: 0x002BE4C0 File Offset: 0x002BC6C0
		public static NodeUnlockDefault GetRootAsNodeUnlockDefault(ByteBuffer _bb)
		{
			return NodeUnlockDefault.GetRootAsNodeUnlockDefault(_bb, default(NodeUnlockDefault));
		}

		// Token: 0x0600A6AE RID: 42670 RVA: 0x002BE4DC File Offset: 0x002BC6DC
		public static NodeUnlockDefault GetRootAsNodeUnlockDefault(ByteBuffer _bb, NodeUnlockDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A6AF RID: 42671 RVA: 0x002BE4F9 File Offset: 0x002BC6F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A6B0 RID: 42672 RVA: 0x002BE508 File Offset: 0x002BC708
		public NodeUnlockDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x0600A6B1 RID: 42673 RVA: 0x002BE518 File Offset: 0x002BC718
		public string Id
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

		// Token: 0x0600A6B2 RID: 42674 RVA: 0x002BE54F File Offset: 0x002BC74F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600A6B3 RID: 42675 RVA: 0x002BE55E File Offset: 0x002BC75E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x0600A6B4 RID: 42676 RVA: 0x002BE578 File Offset: 0x002BC778
		public string Desc
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

		// Token: 0x0600A6B5 RID: 42677 RVA: 0x002BE5AF File Offset: 0x002BC7AF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A6B6 RID: 42678 RVA: 0x002BE5BE File Offset: 0x002BC7BE
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x0600A6B7 RID: 42679 RVA: 0x002BE5D8 File Offset: 0x002BC7D8
		public int AccessId
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

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x0600A6B8 RID: 42680 RVA: 0x002BE614 File Offset: 0x002BC814
		public int HelpId
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

		// Token: 0x04005531 RID: 21809
		private Table __p;
	}
}
