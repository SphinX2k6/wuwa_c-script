using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4B RID: 3147
	public struct ChatExpression : IFlatbufferObject
	{
		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06005982 RID: 22914 RVA: 0x00212199 File Offset: 0x00210399
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x002121A6 File Offset: 0x002103A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x002121B0 File Offset: 0x002103B0
		public static ChatExpression GetRootAsChatExpression(ByteBuffer _bb)
		{
			return ChatExpression.GetRootAsChatExpression(_bb, default(ChatExpression));
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x002121CC File Offset: 0x002103CC
		public static ChatExpression GetRootAsChatExpression(ByteBuffer _bb, ChatExpression obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x002121E9 File Offset: 0x002103E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x002121F8 File Offset: 0x002103F8
		public ChatExpression __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06005988 RID: 22920 RVA: 0x00212208 File Offset: 0x00210408
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

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06005989 RID: 22921 RVA: 0x00212244 File Offset: 0x00210444
		public int GroupId
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

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600598A RID: 22922 RVA: 0x00212280 File Offset: 0x00210480
		public string Name
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

		// Token: 0x0600598B RID: 22923 RVA: 0x002122B7 File Offset: 0x002104B7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x002122C6 File Offset: 0x002104C6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600598D RID: 22925 RVA: 0x002122E0 File Offset: 0x002104E0
		public string ExpressionTexturePath
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

		// Token: 0x0600598E RID: 22926 RVA: 0x00212318 File Offset: 0x00210518
		public Span<byte> GetExpressionTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x00212328 File Offset: 0x00210528
		public byte[] GetExpressionTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06005990 RID: 22928 RVA: 0x00212340 File Offset: 0x00210540
		public string MaleVariant
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x00212378 File Offset: 0x00210578
		public Span<byte> GetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x00212388 File Offset: 0x00210588
		public byte[] GetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400514D RID: 20813
		private Table __p;
	}
}
