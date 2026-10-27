using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E98 RID: 3736
	public struct NodeUnlockDefault : IFlatbufferObject
	{
		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x0600A08B RID: 41099 RVA: 0x002A0F84 File Offset: 0x0029F184
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x002A0F91 File Offset: 0x0029F191
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A08D RID: 41101 RVA: 0x002A0F98 File Offset: 0x0029F198
		public static NodeUnlockDefault GetRootAsNodeUnlockDefault(ByteBuffer _bb)
		{
			return NodeUnlockDefault.GetRootAsNodeUnlockDefault(_bb, default(NodeUnlockDefault));
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x002A0FB4 File Offset: 0x0029F1B4
		public static NodeUnlockDefault GetRootAsNodeUnlockDefault(ByteBuffer _bb, NodeUnlockDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x002A0FD1 File Offset: 0x0029F1D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A090 RID: 41104 RVA: 0x002A0FE0 File Offset: 0x0029F1E0
		public NodeUnlockDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x0600A091 RID: 41105 RVA: 0x002A0FF0 File Offset: 0x0029F1F0
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

		// Token: 0x0600A092 RID: 41106 RVA: 0x002A1027 File Offset: 0x0029F227
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x002A1036 File Offset: 0x0029F236
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x0600A094 RID: 41108 RVA: 0x002A1050 File Offset: 0x0029F250
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

		// Token: 0x0600A095 RID: 41109 RVA: 0x002A1087 File Offset: 0x0029F287
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A096 RID: 41110 RVA: 0x002A1096 File Offset: 0x0029F296
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x0600A097 RID: 41111 RVA: 0x002A10B0 File Offset: 0x0029F2B0
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

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x0600A098 RID: 41112 RVA: 0x002A10EC File Offset: 0x0029F2EC
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

		// Token: 0x04004F4C RID: 20300
		private Table __p;
	}
}
