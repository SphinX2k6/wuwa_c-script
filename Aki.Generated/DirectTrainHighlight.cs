using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD4 RID: 3284
	public struct DirectTrainHighlight : IFlatbufferObject
	{
		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06006854 RID: 26708 RVA: 0x002335EF File Offset: 0x002317EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x002335FC File Offset: 0x002317FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x00233604 File Offset: 0x00231804
		public static DirectTrainHighlight GetRootAsDirectTrainHighlight(ByteBuffer _bb)
		{
			return DirectTrainHighlight.GetRootAsDirectTrainHighlight(_bb, default(DirectTrainHighlight));
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x00233620 File Offset: 0x00231820
		public static DirectTrainHighlight GetRootAsDirectTrainHighlight(ByteBuffer _bb, DirectTrainHighlight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x0023363D File Offset: 0x0023183D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006859 RID: 26713 RVA: 0x0023364C File Offset: 0x0023184C
		public DirectTrainHighlight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x0023365C File Offset: 0x0023185C
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

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x0600685B RID: 26715 RVA: 0x00233698 File Offset: 0x00231898
		public string TabTitle
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

		// Token: 0x0600685C RID: 26716 RVA: 0x002336CF File Offset: 0x002318CF
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x002336DE File Offset: 0x002318DE
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x0600685E RID: 26718 RVA: 0x002336F8 File Offset: 0x002318F8
		public string FeatureDesc
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

		// Token: 0x0600685F RID: 26719 RVA: 0x0023372F File Offset: 0x0023192F
		public Span<byte> GetFeatureDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x0023373E File Offset: 0x0023193E
		public byte[] GetFeatureDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005201 RID: 20993
		private Table __p;
	}
}
