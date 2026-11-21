using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4C RID: 3148
	public struct ChatExpressionGroup : IFlatbufferObject
	{
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06005993 RID: 22931 RVA: 0x002123A0 File Offset: 0x002105A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x002123AD File Offset: 0x002105AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x002123B4 File Offset: 0x002105B4
		public static ChatExpressionGroup GetRootAsChatExpressionGroup(ByteBuffer _bb)
		{
			return ChatExpressionGroup.GetRootAsChatExpressionGroup(_bb, default(ChatExpressionGroup));
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x002123D0 File Offset: 0x002105D0
		public static ChatExpressionGroup GetRootAsChatExpressionGroup(ByteBuffer _bb, ChatExpressionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x002123ED File Offset: 0x002105ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005998 RID: 22936 RVA: 0x002123FC File Offset: 0x002105FC
		public ChatExpressionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06005999 RID: 22937 RVA: 0x0021240C File Offset: 0x0021060C
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

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x0600599A RID: 22938 RVA: 0x00212448 File Offset: 0x00210648
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

		// Token: 0x0600599B RID: 22939 RVA: 0x0021247F File Offset: 0x0021067F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600599C RID: 22940 RVA: 0x0021248E File Offset: 0x0021068E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x0600599D RID: 22941 RVA: 0x002124A8 File Offset: 0x002106A8
		public string GroupTexturePath
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

		// Token: 0x0600599E RID: 22942 RVA: 0x002124DF File Offset: 0x002106DF
		public Span<byte> GetGroupTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600599F RID: 22943 RVA: 0x002124EE File Offset: 0x002106EE
		public byte[] GetGroupTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400514E RID: 20814
		private Table __p;
	}
}
