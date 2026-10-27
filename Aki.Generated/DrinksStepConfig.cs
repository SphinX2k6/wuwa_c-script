using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0A RID: 3082
	public struct DrinksStepConfig : IFlatbufferObject
	{
		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06006519 RID: 25881 RVA: 0x0021A3F1 File Offset: 0x002185F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600651A RID: 25882 RVA: 0x0021A3FE File Offset: 0x002185FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x0021A408 File Offset: 0x00218608
		public static DrinksStepConfig GetRootAsDrinksStepConfig(ByteBuffer _bb)
		{
			return DrinksStepConfig.GetRootAsDrinksStepConfig(_bb, default(DrinksStepConfig));
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x0021A424 File Offset: 0x00218624
		public static DrinksStepConfig GetRootAsDrinksStepConfig(ByteBuffer _bb, DrinksStepConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x0021A441 File Offset: 0x00218641
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x0021A450 File Offset: 0x00218650
		public DrinksStepConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x0600651F RID: 25887 RVA: 0x0021A460 File Offset: 0x00218660
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

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06006520 RID: 25888 RVA: 0x0021A49C File Offset: 0x0021869C
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

		// Token: 0x06006521 RID: 25889 RVA: 0x0021A4D3 File Offset: 0x002186D3
		public Span<byte> GetPrevMaskTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x0021A4E2 File Offset: 0x002186E2
		public byte[] GetPrevMaskTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06006523 RID: 25891 RVA: 0x0021A4FC File Offset: 0x002186FC
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

		// Token: 0x06006524 RID: 25892 RVA: 0x0021A533 File Offset: 0x00218733
		public Span<byte> GetPrevMaskEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x0021A542 File Offset: 0x00218742
		public byte[] GetPrevMaskEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06006526 RID: 25894 RVA: 0x0021A55C File Offset: 0x0021875C
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

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06006527 RID: 25895 RVA: 0x0021A59C File Offset: 0x0021879C
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

		// Token: 0x06006528 RID: 25896 RVA: 0x0021A5D4 File Offset: 0x002187D4
		public Span<byte> GetStepTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x0021A5E4 File Offset: 0x002187E4
		public byte[] GetStepTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x0600652A RID: 25898 RVA: 0x0021A5FC File Offset: 0x002187FC
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

		// Token: 0x0600652B RID: 25899 RVA: 0x0021A634 File Offset: 0x00218834
		public Span<byte> GetMenuTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x0021A644 File Offset: 0x00218844
		public byte[] GetMenuTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x0021A65C File Offset: 0x0021885C
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

		// Token: 0x0600652E RID: 25902 RVA: 0x0021A694 File Offset: 0x00218894
		public Span<byte> GetMenuButtonTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x0021A6A4 File Offset: 0x002188A4
		public byte[] GetMenuButtonTxtArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C46 RID: 19526
		private Table __p;
	}
}
