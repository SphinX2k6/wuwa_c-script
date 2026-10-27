using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C55 RID: 3157
	public struct ExploreSkillInteract : IFlatbufferObject
	{
		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06006BEB RID: 27627 RVA: 0x002295C8 File Offset: 0x002277C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006BEC RID: 27628 RVA: 0x002295D5 File Offset: 0x002277D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006BED RID: 27629 RVA: 0x002295DC File Offset: 0x002277DC
		public static ExploreSkillInteract GetRootAsExploreSkillInteract(ByteBuffer _bb)
		{
			return ExploreSkillInteract.GetRootAsExploreSkillInteract(_bb, default(ExploreSkillInteract));
		}

		// Token: 0x06006BEE RID: 27630 RVA: 0x002295F8 File Offset: 0x002277F8
		public static ExploreSkillInteract GetRootAsExploreSkillInteract(ByteBuffer _bb, ExploreSkillInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x00229615 File Offset: 0x00227815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x00229624 File Offset: 0x00227824
		public ExploreSkillInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06006BF1 RID: 27633 RVA: 0x00229634 File Offset: 0x00227834
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

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06006BF2 RID: 27634 RVA: 0x00229670 File Offset: 0x00227870
		public string Tag
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

		// Token: 0x06006BF3 RID: 27635 RVA: 0x002296A7 File Offset: 0x002278A7
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x002296B6 File Offset: 0x002278B6
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06006BF5 RID: 27637 RVA: 0x002296D0 File Offset: 0x002278D0
		public string Desc
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

		// Token: 0x06006BF6 RID: 27638 RVA: 0x00229707 File Offset: 0x00227907
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x00229716 File Offset: 0x00227916
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C9D RID: 19613
		private Table __p;
	}
}
