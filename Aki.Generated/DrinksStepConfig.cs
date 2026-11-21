using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CEC RID: 3308
	public struct DrinksStepConfig : IFlatbufferObject
	{
		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06006AF8 RID: 27384 RVA: 0x00239820 File Offset: 0x00237A20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x0023982D File Offset: 0x00237A2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x00239834 File Offset: 0x00237A34
		public static DrinksStepConfig GetRootAsDrinksStepConfig(ByteBuffer _bb)
		{
			return DrinksStepConfig.GetRootAsDrinksStepConfig(_bb, default(DrinksStepConfig));
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x00239850 File Offset: 0x00237A50
		public static DrinksStepConfig GetRootAsDrinksStepConfig(ByteBuffer _bb, DrinksStepConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x0023986D File Offset: 0x00237A6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006AFD RID: 27389 RVA: 0x0023987C File Offset: 0x00237A7C
		public DrinksStepConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06006AFE RID: 27390 RVA: 0x0023988C File Offset: 0x00237A8C
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

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06006AFF RID: 27391 RVA: 0x002398C8 File Offset: 0x00237AC8
		public string PrevMaskText
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

		// Token: 0x06006B00 RID: 27392 RVA: 0x002398FF File Offset: 0x00237AFF
		public Span<byte> GetPrevMaskTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x0023990E File Offset: 0x00237B0E
		public byte[] GetPrevMaskTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06006B02 RID: 27394 RVA: 0x00239928 File Offset: 0x00237B28
		public string PrevMaskEvent
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

		// Token: 0x06006B03 RID: 27395 RVA: 0x0023995F File Offset: 0x00237B5F
		public Span<byte> GetPrevMaskEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x0023996E File Offset: 0x00237B6E
		public byte[] GetPrevMaskEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06006B05 RID: 27397 RVA: 0x00239988 File Offset: 0x00237B88
		public int PrevMaskEventDelay
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

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06006B06 RID: 27398 RVA: 0x002399C8 File Offset: 0x00237BC8
		public string StepTitle
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

		// Token: 0x06006B07 RID: 27399 RVA: 0x00239A00 File Offset: 0x00237C00
		public Span<byte> GetStepTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x00239A10 File Offset: 0x00237C10
		public byte[] GetStepTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06006B09 RID: 27401 RVA: 0x00239A28 File Offset: 0x00237C28
		public string MenuTitle
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

		// Token: 0x06006B0A RID: 27402 RVA: 0x00239A60 File Offset: 0x00237C60
		public Span<byte> GetMenuTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x00239A70 File Offset: 0x00237C70
		public byte[] GetMenuTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06006B0C RID: 27404 RVA: 0x00239A88 File Offset: 0x00237C88
		public string MenuButtonTxt
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x00239AC0 File Offset: 0x00237CC0
		public Span<byte> GetMenuButtonTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x00239AD0 File Offset: 0x00237CD0
		public byte[] GetMenuButtonTxtArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005228 RID: 21032
		private Table __p;
	}
}
