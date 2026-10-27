using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECE RID: 3790
	public struct PhantomBattleDialog : IFlatbufferObject
	{
		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x0600A6E9 RID: 42729 RVA: 0x002AF880 File Offset: 0x002ADA80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6EA RID: 42730 RVA: 0x002AF88D File Offset: 0x002ADA8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A6EB RID: 42731 RVA: 0x002AF894 File Offset: 0x002ADA94
		public static PhantomBattleDialog GetRootAsPhantomBattleDialog(ByteBuffer _bb)
		{
			return PhantomBattleDialog.GetRootAsPhantomBattleDialog(_bb, default(PhantomBattleDialog));
		}

		// Token: 0x0600A6EC RID: 42732 RVA: 0x002AF8B0 File Offset: 0x002ADAB0
		public static PhantomBattleDialog GetRootAsPhantomBattleDialog(ByteBuffer _bb, PhantomBattleDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A6ED RID: 42733 RVA: 0x002AF8CD File Offset: 0x002ADACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A6EE RID: 42734 RVA: 0x002AF8DC File Offset: 0x002ADADC
		public PhantomBattleDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x0600A6EF RID: 42735 RVA: 0x002AF8EC File Offset: 0x002ADAEC
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

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x0600A6F0 RID: 42736 RVA: 0x002AF928 File Offset: 0x002ADB28
		public string PlotName
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

		// Token: 0x0600A6F1 RID: 42737 RVA: 0x002AF95F File Offset: 0x002ADB5F
		public Span<byte> GetPlotNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A6F2 RID: 42738 RVA: 0x002AF96E File Offset: 0x002ADB6E
		public byte[] GetPlotNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x0600A6F3 RID: 42739 RVA: 0x002AF988 File Offset: 0x002ADB88
		public int FlowId
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

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x0600A6F4 RID: 42740 RVA: 0x002AF9C4 File Offset: 0x002ADBC4
		public int StateId
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

		// Token: 0x04004F8C RID: 20364
		private Table __p;
	}
}
