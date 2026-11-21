using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9E RID: 3998
	public struct PersonalTips : IFlatbufferObject
	{
		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x0600A9DC RID: 43484 RVA: 0x002C523C File Offset: 0x002C343C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x002C5249 File Offset: 0x002C3449
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x002C5250 File Offset: 0x002C3450
		public static PersonalTips GetRootAsPersonalTips(ByteBuffer _bb)
		{
			return PersonalTips.GetRootAsPersonalTips(_bb, default(PersonalTips));
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x002C526C File Offset: 0x002C346C
		public static PersonalTips GetRootAsPersonalTips(ByteBuffer _bb, PersonalTips obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x002C5289 File Offset: 0x002C3489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x002C5298 File Offset: 0x002C3498
		public PersonalTips __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x0600A9E2 RID: 43490 RVA: 0x002C52A8 File Offset: 0x002C34A8
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

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x0600A9E3 RID: 43491 RVA: 0x002C52E4 File Offset: 0x002C34E4
		public int FunctionId
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

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x0600A9E4 RID: 43492 RVA: 0x002C5320 File Offset: 0x002C3520
		public int Sort
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

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x0600A9E5 RID: 43493 RVA: 0x002C535C File Offset: 0x002C355C
		public string RedDotName
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

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x002C5394 File Offset: 0x002C3594
		public Span<byte> GetRedDotNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x002C53A4 File Offset: 0x002C35A4
		public byte[] GetRedDotNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x0600A9E8 RID: 43496 RVA: 0x002C53BC File Offset: 0x002C35BC
		public string Description
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

		// Token: 0x0600A9E9 RID: 43497 RVA: 0x002C53F4 File Offset: 0x002C35F4
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A9EA RID: 43498 RVA: 0x002C5404 File Offset: 0x002C3604
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x0600A9EB RID: 43499 RVA: 0x002C541C File Offset: 0x002C361C
		public string IconPath
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x002C5454 File Offset: 0x002C3654
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A9ED RID: 43501 RVA: 0x002C5464 File Offset: 0x002C3664
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005554 RID: 21844
		private Table __p;
	}
}
