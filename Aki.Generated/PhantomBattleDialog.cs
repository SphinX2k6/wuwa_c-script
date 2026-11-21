using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB3 RID: 4019
	public struct PhantomBattleDialog : IFlatbufferObject
	{
		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x0600AD0A RID: 44298 RVA: 0x002CC9A0 File Offset: 0x002CABA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD0B RID: 44299 RVA: 0x002CC9AD File Offset: 0x002CABAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD0C RID: 44300 RVA: 0x002CC9B4 File Offset: 0x002CABB4
		public static PhantomBattleDialog GetRootAsPhantomBattleDialog(ByteBuffer _bb)
		{
			return PhantomBattleDialog.GetRootAsPhantomBattleDialog(_bb, default(PhantomBattleDialog));
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x002CC9D0 File Offset: 0x002CABD0
		public static PhantomBattleDialog GetRootAsPhantomBattleDialog(ByteBuffer _bb, PhantomBattleDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x002CC9ED File Offset: 0x002CABED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD0F RID: 44303 RVA: 0x002CC9FC File Offset: 0x002CABFC
		public PhantomBattleDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x0600AD10 RID: 44304 RVA: 0x002CCA0C File Offset: 0x002CAC0C
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

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x0600AD11 RID: 44305 RVA: 0x002CCA48 File Offset: 0x002CAC48
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

		// Token: 0x0600AD12 RID: 44306 RVA: 0x002CCA7F File Offset: 0x002CAC7F
		public Span<byte> GetPlotNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AD13 RID: 44307 RVA: 0x002CCA8E File Offset: 0x002CAC8E
		public byte[] GetPlotNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x0600AD14 RID: 44308 RVA: 0x002CCAA8 File Offset: 0x002CACA8
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

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x0600AD15 RID: 44309 RVA: 0x002CCAE4 File Offset: 0x002CACE4
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

		// Token: 0x04005571 RID: 21873
		private Table __p;
	}
}
