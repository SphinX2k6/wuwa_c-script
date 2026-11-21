using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6C RID: 3948
	public struct NewPlayerSupportActiviy : IFlatbufferObject
	{
		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x0600A4F2 RID: 42226 RVA: 0x002BA630 File Offset: 0x002B8830
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A4F3 RID: 42227 RVA: 0x002BA63D File Offset: 0x002B883D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A4F4 RID: 42228 RVA: 0x002BA644 File Offset: 0x002B8844
		public static NewPlayerSupportActiviy GetRootAsNewPlayerSupportActiviy(ByteBuffer _bb)
		{
			return NewPlayerSupportActiviy.GetRootAsNewPlayerSupportActiviy(_bb, default(NewPlayerSupportActiviy));
		}

		// Token: 0x0600A4F5 RID: 42229 RVA: 0x002BA660 File Offset: 0x002B8860
		public static NewPlayerSupportActiviy GetRootAsNewPlayerSupportActiviy(ByteBuffer _bb, NewPlayerSupportActiviy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A4F6 RID: 42230 RVA: 0x002BA67D File Offset: 0x002B887D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A4F7 RID: 42231 RVA: 0x002BA68C File Offset: 0x002B888C
		public NewPlayerSupportActiviy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x0600A4F8 RID: 42232 RVA: 0x002BA69C File Offset: 0x002B889C
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

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x0600A4F9 RID: 42233 RVA: 0x002BA6D8 File Offset: 0x002B88D8
		public int ContinueDays
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

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x0600A4FA RID: 42234 RVA: 0x002BA714 File Offset: 0x002B8914
		public int EnableTime
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

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x0600A4FB RID: 42235 RVA: 0x002BA750 File Offset: 0x002B8950
		public int EnableMaxLv
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400551A RID: 21786
		private Table __p;
	}
}
